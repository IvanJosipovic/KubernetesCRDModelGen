using k8s;
using k8s.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using Shouldly;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using Xunit;

namespace KubernetesCRDModelGen.Tests;

public partial class GeneratorTests
{
    [Fact]
    public async Task TestGenerateAssemblySucceeds()
    {
        var crd = await KubernetesYaml.LoadFromFileAsync<V1CustomResourceDefinition>("managedclusters.containerservice.azure.com.yaml");

        var result = GenerateAssembly(crd);
        using var unloadHandle = result.UnloadHandle;

        result.Success.ShouldBeTrue();
        result.Assembly.ShouldNotBeNull();
        result.XmlDocumentation.ShouldNotBeNull();
        result.Diagnostics.ShouldNotContain(x => x.Severity == GeneratedAssemblyDiagnosticSeverity.Error);
        unloadHandle.ShouldNotBeNull();
        unloadHandle!.IsUnloaded.ShouldBeFalse();
    }

    [Fact]
    public void TestGenerateAssemblyMaterializesPropertyDescriptionsInXmlDocumentation()
    {
        const string modelNamespace = "KubernetesCRDModelGen.Tests.Models";
        var yaml = """
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
          type: object
          properties:
            apiVersion:
              type: string
            kind:
              type: string
            metadata:
              type: object
            spec:
              type: object
              description: Widget desired state.
              properties:
                size:
                  type: string
                  description: Size of the widget.
                enabled:
                  type: boolean
                  description: Whether the widget is enabled.
""";

        var result = GenerateAssembly(yaml, modelNamespace);
        using var unloadHandle = result.UnloadHandle;
        var xml = result.XmlDocumentation;

        xml.ShouldNotBeNull();
        xml!.SelectSingleNode("/doc/members/member[@name='P:KubernetesCRDModelGen.Tests.Models.example.com.V1WidgetSpec.Size']/summary")
            ?.InnerText.ShouldBe("Size of the widget.");
        xml.SelectSingleNode("/doc/members/member[@name='P:KubernetesCRDModelGen.Tests.Models.example.com.V1WidgetSpec.Enabled']/summary")
            ?.InnerText.ShouldBe("Whether the widget is enabled.");
        xml.SelectSingleNode("/doc/members/member[@name='P:KubernetesCRDModelGen.Tests.Models.example.com.V1Widget.Spec']/summary")
            ?.InnerText.ShouldBe("Widget desired state.");
    }

    [Fact]
    public void TestGenerateAssemblyMarksDeprecatedVersionsObsolete()
    {
        const string modelNamespace = "KubernetesCRDModelGen.Tests.Models";
        var yaml = """
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
      deprecated: true
      deprecationWarning: widgets.example.com/v1 is deprecated.
      schema:
        openAPIV3Schema:
          type: object
          properties:
            apiVersion:
              type: string
            kind:
              type: string
            metadata:
              type: object
""";

        var result = GenerateAssembly(yaml, modelNamespace);
        using var unloadHandle = result.UnloadHandle;
        var assembly = result.Assembly;

        assembly.ShouldNotBeNull();
        var root = assembly!.GetType("KubernetesCRDModelGen.Tests.Models.example.com.V1Widget");
        var list = assembly.GetType("KubernetesCRDModelGen.Tests.Models.example.com.V1WidgetList");

        root.ShouldNotBeNull();
        list.ShouldNotBeNull();
        root!.GetCustomAttribute<ObsoleteAttribute>()!.Message.ShouldBe("widgets.example.com/v1 is deprecated.");
        list!.GetCustomAttribute<ObsoleteAttribute>()!.Message.ShouldBe("widgets.example.com/v1 is deprecated.");
    }

    [Fact]
    public void TestGenerateAssemblyEmitsModelSourceGenerationContext()
    {
        var yaml = """
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
          type: object
          properties:
            apiVersion:
              type: string
            kind:
              type: string
            metadata:
              type: object
""";

        var result = GenerateAssembly(yaml);
        using var unloadHandle = result.UnloadHandle;
        var assembly = result.Assembly;

        assembly.ShouldNotBeNull(string.Join(Environment.NewLine, result.Diagnostics.Select(x => $"{x.Id} {x.Severity} {x.Message}")));
        var context = assembly!.GetType("KubernetesCRDModelGen.Tests.Models.example.com.ModelSourceGenerationContext");
        var rootType = assembly.GetType("KubernetesCRDModelGen.Tests.Models.example.com.V1Widget");
        var listType = assembly.GetType("KubernetesCRDModelGen.Tests.Models.example.com.V1WidgetList");

        context.ShouldNotBeNull();
        rootType.ShouldNotBeNull();
        listType.ShouldNotBeNull();
        context!.IsSubclassOf(typeof(System.Text.Json.Serialization.JsonSerializerContext)).ShouldBeTrue();
        context.CustomAttributes
            .Where(x => x.AttributeType == typeof(System.Text.Json.Serialization.JsonSerializableAttribute))
            .Select(x => x.ConstructorArguments[0].Value)
            .ShouldContain(rootType);
        context.CustomAttributes
            .Where(x => x.AttributeType == typeof(System.Text.Json.Serialization.JsonSerializableAttribute))
            .Select(x => x.ConstructorArguments[0].Value)
            .ShouldContain(listType);
    }

    [Fact]
    public void TestGenerateAssemblyCanRunJsonSourceGeneratorWhenEnabled()
    {
        var yaml = """
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
          type: object
          properties:
            apiVersion:
              type: string
            kind:
              type: string
            metadata:
              type: object
""";

        var result = GenerateAssembly(yaml, enableJsonSourceGeneration: true);
        using var unloadHandle = result.UnloadHandle;
        var assembly = result.Assembly;

        result.Success.ShouldBeTrue(string.Join(Environment.NewLine, result.Diagnostics.Select(x => $"{x.Id} {x.Severity} {x.Message}")));
        assembly.ShouldNotBeNull();

        var context = assembly!.GetType("KubernetesCRDModelGen.Tests.Models.example.com.ModelSourceGenerationContext");
        context.ShouldNotBeNull();
        context!.GetProperty("Default", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static).ShouldNotBeNull();
    }

    [Fact]
    public void TestDependentAppsCanAccessModelSourceGenerationContext()
    {
        var yaml = """
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
          type: object
          properties:
            apiVersion:
              type: string
            kind:
              type: string
            metadata:
              type: object
""";

        var result = GenerateAssembly(yaml);
        using var unloadHandle = result.UnloadHandle;
        var assembly = result.Assembly;

        result.Success.ShouldBeTrue(string.Join(Environment.NewLine, result.Diagnostics.Select(x => $"{x.Id} {x.Severity} {x.Message}")));
        assembly.ShouldNotBeNull();

        var context = assembly!.GetExportedTypes()
            .SingleOrDefault(type => type.FullName == "KubernetesCRDModelGen.Tests.Models.example.com.ModelSourceGenerationContext");

        context.ShouldNotBeNull();
        context!.IsPublic.ShouldBeTrue();
        context.IsSubclassOf(typeof(System.Text.Json.Serialization.JsonSerializerContext)).ShouldBeTrue();
        Activator.CreateInstance(context).ShouldNotBeNull();
    }

    [Fact]
    public void TestGenerateCodeMarksDeprecatedVersionsObsoleteWithoutMessage()
    {
        const string modelNamespace = "KubernetesCRDModelGen.Tests.Models";
        var yaml = """
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
      deprecated: true
      schema:
        openAPIV3Schema:
          type: object
          properties:
            apiVersion:
              type: string
            kind:
              type: string
            metadata:
              type: object
""";

        var crd = (V1CustomResourceDefinition)KubernetesYaml.LoadAllFromString(yaml)[0];
        var generator = new Generator();

        var code = generator.GenerateCode(crd, modelNamespace);

        code.ShouldContain("[global::System.Obsolete]");
        code.ShouldNotContain("[global::System.Obsolete(\"");
    }

    [Fact]
    public async Task TestGenerateAssemblyMaterializesXmlDocumentationForManagedClustersCrd()
    {
        const string modelNamespace = "KubernetesCRDModelGen.Tests.Models";
        var crd = await KubernetesYaml.LoadFromFileAsync<V1CustomResourceDefinition>("managedclusters.containerservice.azure.com.yaml");

        var result = GenerateAssembly(crd, modelNamespace);
        using var unloadHandle = result.UnloadHandle;
        var xml = result.XmlDocumentation;

        xml.ShouldNotBeNull();
        xml!.SelectSingleNode("/doc/members/member[@name='T:KubernetesCRDModelGen.Tests.Models.containerservice.azure.com.V1api20210501ManagedClusterSpecAadProfile']/summary")
            ?.InnerText.ShouldBe("AadProfile: The Azure Active Directory configuration.");
        xml.SelectSingleNode("/doc/members/member[@name='P:KubernetesCRDModelGen.Tests.Models.containerservice.azure.com.V1api20210501ManagedClusterSpecAadProfile.AdminGroupObjectIDs']/summary")
            ?.InnerText.ShouldBe("AdminGroupObjectIDs: The list of AAD group object IDs that will have admin role of the cluster.");
        xml.SelectSingleNode("/doc/members/member[@name='P:KubernetesCRDModelGen.Tests.Models.containerservice.azure.com.V1api20210501ManagedClusterSpec.AadProfile']/summary")
            ?.InnerText.ShouldBe("AadProfile: The Azure Active Directory configuration.");
    }

    [Fact]
    public async Task TestGenerateCodeEmitsNullableDirectiveOncePerFile()
    {
        const string modelNamespace = "KubernetesCRDModelGen.Tests.Models";
        var yaml = """
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
          type: object
          properties:
            apiVersion:
              type: string
            kind:
              type: string
            metadata:
              type: object
            spec:
              type: object
              properties:
                nested:
                  type: object
                  properties:
                    value:
                      type: string
""";

        var crd = (V1CustomResourceDefinition)KubernetesYaml.LoadAllFromString(yaml)[0];
        var generator = new Generator();

        var code = generator.GenerateCode(crd, modelNamespace);

        code.IndexOf("#nullable enable", StringComparison.Ordinal).ShouldBeGreaterThanOrEqualTo(0);
        (code.Split("#nullable enable", StringSplitOptions.None).Length - 1).ShouldBe(1);
        code.ShouldNotContain("#nullable disable");
    }

    [Fact]
    public void TestGenerateAssemblyReturnsStructuredDiagnosticsOnFailure()
    {
        var result = GenerateAssembly(new V1CustomResourceDefinition());

        result.Success.ShouldBeFalse();
        result.Assembly.ShouldBeNull();
        result.XmlDocumentation.ShouldBeNull();
        result.UnloadHandle.ShouldBeNull();
        result.Diagnostics.ShouldNotBeEmpty();
        result.Diagnostics.ShouldContain(x => x.Id == GeneratedAssemblyDiagnostic.ExceptionDiagnosticId);
        result.Diagnostics.ShouldContain(x => x.Severity == GeneratedAssemblyDiagnosticSeverity.Error);
    }

    [Fact]
    public void TestGeneratedAssemblyResultDeconstructsAndReportsSuccess()
    {
        var xml = new XmlDocument();
        var assembly = typeof(string).Assembly;
        var result = new GeneratedAssemblyResult(assembly, xml, Array.Empty<GeneratedAssemblyDiagnostic>(), null);

        result.Success.ShouldBeTrue();

        result.Deconstruct(out var deconstructedAssembly, out var deconstructedXml);

        deconstructedAssembly.ShouldBeSameAs(assembly);
        deconstructedXml.ShouldBeSameAs(xml);
    }

    [Fact]
    public void TestGetOpenApiSchemaCachesParsedSchema()
    {
        var generator = new Generator();
        var method = typeof(Generator).GetMethod("GetOpenApiSchema", BindingFlags.Instance | BindingFlags.NonPublic);
        method.ShouldNotBeNull();

        var schema = new V1JSONSchemaProps
        {
            Type = "object",
            Properties = new Dictionary<string, V1JSONSchemaProps>
            {
                ["name"] = new()
                {
                    Type = "string",
                },
            },
        };

        var reader = new OpenApiJsonReader();
        using var schemaStream = new MemoryStream();
        var diagnostics = new List<GeneratedAssemblyDiagnostic>();

        var first = (OpenApiSchema?)method!.Invoke(generator, [reader, schemaStream, schema, diagnostics]);
        var second = (OpenApiSchema?)method.Invoke(generator, [reader, schemaStream, schema, diagnostics]);

        first.ShouldNotBeNull();
        second.ShouldNotBeNull();
        second.ShouldBeSameAs(first);
        diagnostics.ShouldBeEmpty();
    }

    [Fact]
    public void TestGenerateAssemblyMapsSupportedFormatsToRuntimeTypes()
    {
        var yaml = """
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1
      served: true
      storage: true
      schema:
        openAPIV3Schema:
          type: object
          properties:
            apiVersion:
              type: string
            kind:
              type: string
            metadata:
              type: object
            spec:
              type: object
              properties:
                payload:
                  type: string
                  format: byte
                blob:
                  type: string
                  format: binary
                createdAt:
                  type: string
                  format: date-time
                birthDate:
                  type: string
                  format: date
                timeout:
                  type: string
                  format: duration
                ratio:
                  type: number
                  format: float
                amount:
                  type: number
                  format: double
                score:
                  type: number
                smallCount:
                  type: integer
                  format: int32
                largeCount:
                  type: integer
                  format: int64
""";

        var type = GetTypeYaml(yaml, "Test");
        var specType = type!.GetProperty("Spec")!.PropertyType;

        specType.GetProperty("Payload")!.PropertyType.ShouldBe(typeof(byte[]));
        specType.GetProperty("Blob")!.PropertyType.ShouldBe(typeof(byte[]));
        specType.GetProperty("CreatedAt")!.PropertyType.ShouldBe(typeof(DateTime?));
        specType.GetProperty("BirthDate")!.PropertyType.ShouldBe(typeof(DateTime?));
        specType.GetProperty("Timeout")!.PropertyType.ShouldBe(typeof(TimeSpan?));
        specType.GetProperty("Ratio")!.PropertyType.ShouldBe(typeof(float?));
        specType.GetProperty("Amount")!.PropertyType.ShouldBe(typeof(double?));
        specType.GetProperty("Score")!.PropertyType.ShouldBe(typeof(double?));
        specType.GetProperty("SmallCount")!.PropertyType.ShouldBe(typeof(int?));
        specType.GetProperty("LargeCount")!.PropertyType.ShouldBe(typeof(long?));
    }

    [Fact]
    public void TestGenerateAssemblyWarnsOnUnknownIntegerFormatAndFallsBackToInt()
    {
        var yaml = """
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1
      served: true
      storage: true
      schema:
        openAPIV3Schema:
          type: object
          properties:
            apiVersion:
              type: string
            kind:
              type: string
            metadata:
              type: object
            spec:
              type: object
              properties:
                oddCount:
                  type: integer
                  format: uint64
""";

        var result = GenerateAssembly(yaml);
        using var unloadHandle = result.UnloadHandle;

        result.Success.ShouldBeTrue();
        result.Diagnostics.ShouldContain(x =>
            x.Id == "KCRDGEN003" &&
            x.Severity == GeneratedAssemblyDiagnosticSeverity.Warning &&
            x.Message.Contains("Unsupported integer format 'uint64'", StringComparison.Ordinal));

        var type = GetTypeYaml(yaml, "Test");
        var specType = type!.GetProperty("Spec")!.PropertyType;
        specType.GetProperty("OddCount")!.PropertyType.ShouldBe(typeof(int?));
    }

    [Fact]
    public void TestGenerateAssemblyAddsImplicitEmbeddedResourceProperties()
    {
        var yaml = """
apiVersion: apiextensions.k8s.io/v1
kind: CustomResourceDefinition
metadata:
  name: tests.kubeui.com
spec:
  group: kubeui.com
  names:
    plural: tests
    singular: test
    kind: Test
    listKind: TestList
  scope: Namespaced
  versions:
    - name: v1
      served: true
      storage: true
      schema:
        openAPIV3Schema:
          type: object
          properties:
            apiVersion:
              type: string
            kind:
              type: string
            metadata:
              type: object
            spec:
              type: object
              properties:
                template:
                  type: object
                  x-kubernetes-embedded-resource: true
                  properties:
                    spec:
                      type: object
                      properties:
                        replicas:
                          type: integer
""";

        var type = GetTypeYaml(yaml, "Test");
        var specType = type!.GetProperty("Spec")!.PropertyType;
        var templateType = specType.GetProperty("Template")!.PropertyType;

        templateType.GetProperty("ApiVersion")!.PropertyType.ShouldBe(typeof(string));
        templateType.GetProperty("Kind")!.PropertyType.ShouldBe(typeof(string));
        templateType.GetProperty("Metadata")!.PropertyType.ShouldBe(typeof(V1ObjectMeta));
        templateType.GetProperty("Spec")!.ShouldNotBeNull();
    }
}
