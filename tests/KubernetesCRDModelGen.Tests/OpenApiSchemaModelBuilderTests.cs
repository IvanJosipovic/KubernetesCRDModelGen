using k8s;
using k8s.Models;
using KubernetesCRDModelGen;
using KubernetesCRDModelGen.Base;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using Shouldly;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using Xunit;

namespace KubernetesCRDModelGen.Tests;

public class OpenApiSchemaModelBuilderTests
{
    [Fact]
    public void BuildTypes_DeduplicatesCollidingPropertyNames()
    {
        var schema = LoadSchema("""
type: object
properties:
  foo-bar:
    type: string
  foo bar:
    type: string
""");

        var builder = new OpenApiSchemaModelBuilder();

        var types = builder.BuildTypes(schema, "Spec");
        var spec = types.OfType<GeneratedClassModel>().Single(x => x.Name == "Spec");

        spec.Properties.Select(x => x.Name).ShouldBe(["FooBar", "FooBar1"]);
    }

    [Fact]
    public void BuildTypes_DeduplicatesCollidingNestedTypeNames()
    {
        var schema = LoadSchema("""
type: object
properties:
  child-one:
    type: object
    properties:
      name:
        type: string
  child one:
    type: object
    properties:
      enabled:
        type: boolean
""");

        var builder = new OpenApiSchemaModelBuilder();

        var types = builder.BuildTypes(schema, "Spec");
        var classes = types.OfType<GeneratedClassModel>().ToArray();
        var spec = classes.Single(x => x.Name == "Spec");
        var nested = classes.Where(x => x.Name == "SpecChildOne").ToArray();

        nested.Length.ShouldBe(1);
        spec.Properties.Select(x => x.Type.DisplayName).ShouldBe(["SpecChildOne", "SpecChildOne"]);
        spec.Properties.Select(x => x.Name).ShouldBe(["ChildOne", "ChildOne1"]);
    }

    [Fact]
    public void BuildTypes_GeneratesDistinctEnumMembersForCollidingValues()
    {
        var schema = LoadSchema("""
type: object
properties:
  state:
    type: string
    enum:
      - in-progress
      - in progress
""");

        var builder = new OpenApiSchemaModelBuilder();

        var types = builder.BuildTypes(schema, "Spec");
        var enumModel = types.OfType<GeneratedEnumModel>().Single(x => x.Name == "SpecStateEnum");

        enumModel.Members.Select(x => x.Name).ShouldBe(["InProgress", "InProgress1"]);
        enumModel.Members.Select(x => x.Value).ShouldBe(["in-progress", "in progress"]);
    }

    [Fact]
    public void BuildTypes_ComputesRequiredAndNullableFlags()
    {
        var schema = LoadSchema("""
type: object
required:
  - requiredString
  - requiredNullable
  - requiredWithDefault
properties:
  requiredString:
    type: string
  optionalString:
    type: string
  requiredNullable:
    type: string
    nullable: true
  requiredWithDefault:
    type: string
    default: hello
""");

        var builder = new OpenApiSchemaModelBuilder();

        var types = builder.BuildTypes(schema, "Spec");
        var spec = types.OfType<GeneratedClassModel>().Single(x => x.Name == "Spec");

        spec.Properties.Single(x => x.Name == "RequiredString").IsRequired.ShouldBeTrue();
        spec.Properties.Single(x => x.Name == "RequiredString").IsNullable.ShouldBeFalse();

        spec.Properties.Single(x => x.Name == "OptionalString").IsRequired.ShouldBeFalse();
        spec.Properties.Single(x => x.Name == "OptionalString").IsNullable.ShouldBeTrue();

        spec.Properties.Single(x => x.Name == "RequiredNullable").IsRequired.ShouldBeTrue();
        spec.Properties.Single(x => x.Name == "RequiredNullable").IsNullable.ShouldBeTrue();

        spec.Properties.Single(x => x.Name == "RequiredWithDefault").IsRequired.ShouldBeFalse();
        spec.Properties.Single(x => x.Name == "RequiredWithDefault").IsNullable.ShouldBeTrue();
        spec.Properties.Single(x => x.Name == "RequiredWithDefault").DefaultValue.ShouldBe("hello");
    }

    [Fact]
    public void BuildTypes_AddsKubernetesRootMetadataAndListModels()
    {
        var schema = LoadSchema("""
type: object
properties:
  spec:
    type: object
    description: Desired state.
    properties:
      size:
        type: string
""");

        var builder = new OpenApiSchemaModelBuilder();

        var types = builder.BuildTypes(schema, "Widget", "v1", "example.com", "widgets", "WidgetList");
        var classes = types.OfType<GeneratedClassModel>().ToArray();

        var list = classes.Single(x => x.Name == "V1WidgetList");
        var root = classes.Single(x => x.Name == "V1Widget");
        var spec = classes.Single(x => x.Name == "V1WidgetSpec");

        list.IsKubernetesEntity.ShouldBeTrue();
        list.BaseTypes.Select(x => x.DisplayName).ShouldBe(["IKubernetesObject<V1ListMeta>", "IItems<V1Widget>"]);
        list.Properties.Select(x => x.Name).ShouldBe(["ApiVersion", "Kind", "Metadata", "Items"]);

        root.IsKubernetesEntity.ShouldBeTrue();
        root.BaseTypes.Select(x => x.DisplayName).ShouldContain("IKubernetesObject<V1ObjectMeta>");
        root.BaseTypes.Select(x => x.DisplayName).ShouldContain("ISpec<V1WidgetSpec?>");
        root.Fields.Select(x => x.Name).ShouldBe(["KubeApiVersion", "KubeKind", "KubeGroup", "KubePluralName"]);
        root.Properties.Select(x => x.Name).ShouldBe(["ApiVersion", "Kind", "Metadata", "Spec"]);

        spec.Properties.Single(x => x.Name == "Size").Type.DisplayName.ShouldBe("string");
    }

    [Fact]
    public void CodeGenerator_FacadeMatchesSharedModelPipeline()
    {
        var schema = LoadSchema("""
type: object
properties:
  spec:
    type: object
    properties:
      state:
        type: string
        enum:
          - ready
          - not ready
""");

        var builder = new OpenApiSchemaModelBuilder();
        var renderer = new RoslynCodeModelRenderer();
        var direct = renderer.RenderCompilationUnit(builder.BuildCompilationUnit(schema, "Tests.Models", "v1", "Widget", "example.com", "widgets", "WidgetList"));

        var generator = new CodeGenerator();
        var throughFacade = generator.GenerateCompilationUnit(schema, "Tests.Models", "v1", "Widget", "example.com", "widgets", "WidgetList");

        direct.ToFullString().ShouldBe(throughFacade.ToFullString());
    }

    private static OpenApiSchema LoadSchema(string schemaYaml)
    {
        var crd = (V1CustomResourceDefinition)KubernetesYaml.LoadAllFromString($$"""
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: widgets.example.com
spec:
  group: example.com
  names:
    plural: widgets
    singular: widget
    kind: Widget
    listKind: WidgetList
  scope: Namespaced
  versions:
    - name: v1
      served: true
      storage: true
      schema:
        openAPIV3Schema:
{{Indent(schemaYaml, 10)}}
""" )[0];

        using var stream = new MemoryStream();
        JsonSerializer.Serialize(stream, crd.Spec.Versions.Single().Schema!.OpenAPIV3Schema, GeneratorSourceGenerationContext.Default.V1JSONSchemaProps);
        stream.Position = 0;

        return new OpenApiJsonReader().ReadFragment<OpenApiSchema>(stream, OpenApiSpecVersion.OpenApi3_0, new OpenApiDocument(), out var diagnostics)
            ?? throw new InvalidOperationException(string.Join(" | ", diagnostics.Errors.Select(x => x.Message)));
    }

    private static string Indent(string value, int count)
    {
        var indent = new string(' ', count);
        return indent + value.Replace("\r\n", "\n").Replace("\n", Environment.NewLine + indent, StringComparison.Ordinal);
    }
}
