using k8s.Models;
using KubernetesCRDModelGen.Base;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using Shouldly;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using Xunit;

namespace KubernetesCRDModelGen.Tests;

public class CoverageRegressionTests
{
    [Fact]
    public void RemoveIllegalFileNameCharacters_StripsInvalidCharacters()
    {
        var invalid = Path.GetInvalidFileNameChars().First();

        var sanitized = CodeGenerator.RemoveIllegalFileNameCharacters($"before{invalid}after");

        sanitized.ShouldBe("beforeafter");
    }

    [Fact]
    public void RemoveIllegalFileNameCharacters_RejectsEmptyFileNames()
    {
        Should.Throw<ArgumentException>(() => CodeGenerator.RemoveIllegalFileNameCharacters(string.Empty))
            .ParamName.ShouldBe("fileName");
    }

    [Fact]
    public void GenerateCompilationUnitWithWarnings_ReportsUnsupportedIntegerFormats()
    {
        var schema = LoadSchema("""
type: object
properties:
  spec:
    type: object
    properties:
      oddCount:
        type: integer
        format: uint64
""");

        var generator = new CodeGenerator();
        var warnings = new List<string>();

        var unit = generator.GenerateCompilationUnitWithWarnings(schema, "Tests.Models", "v1", "Widget", "example.com", "widgets", "WidgetList", warnings.Add);
        var code = unit.NormalizeWhitespace().ToFullString();

        warnings.ShouldHaveSingleItem();
        warnings[0].ShouldContain("Unsupported integer format 'uint64'");
        code.ShouldContain("public int? OddCount");
    }

    [Fact]
    public void GenerateClass_RespectsEnumSupportFlag()
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
          - not-ready
""");

        var generator = new CodeGenerator();
        generator.SetEnumSupport(false);

        var types = generator.GenerateClass(schema, "Widget", "v1", "example.com", "widgets", "WidgetList");

        types.ShouldNotContain(type => type.Identifier.ValueText == "V1WidgetSpecStateEnum");
        var root = types.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax>().Single(type => type.Identifier.ValueText == "V1WidgetSpec");
        root.Members.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax>()
            .Single(property => property.Identifier.ValueText == "State")
            .Type!
            .ToString()
            .ShouldBe("string?");
    }

    [Fact]
    public void GeneratedAssemblyResult_SuccessIsFalseWhenDiagnosticsContainErrors()
    {
        var result = new GeneratedAssemblyResult(
            typeof(string).Assembly,
            new System.Xml.XmlDocument(),
            [new GeneratedAssemblyDiagnostic("ERR001", "boom", GeneratedAssemblyDiagnosticSeverity.Error)],
            null);

        result.Success.ShouldBeFalse();
    }

    [Fact]
    public void GeneratedAssemblyUnloadHandle_UnloadIsIdempotent()
    {
        var constructor = typeof(GeneratedAssemblyUnloadHandle).GetConstructor(
            BindingFlags.Instance | BindingFlags.NonPublic,
            binder: null,
            [typeof(AssemblyLoadContext)],
            modifiers: null);

        constructor.ShouldNotBeNull();

        var loadContext = new AssemblyLoadContext("coverage-test", isCollectible: true);
        var handle = (GeneratedAssemblyUnloadHandle)constructor!.Invoke([loadContext]);

        handle.IsUnloaded.ShouldBeFalse();

        handle.Unload();
        handle.IsUnloaded.ShouldBeTrue();

        handle.Unload();
        handle.IsUnloaded.ShouldBeTrue();
    }

    [Fact]
    public void GeneratedAssemblyDiagnostic_FromRoslynDiagnosticPreservesSourceLocation()
    {
        var method = typeof(GeneratedAssemblyDiagnostic).GetMethod("FromRoslynDiagnostic", BindingFlags.Static | BindingFlags.NonPublic);
        method.ShouldNotBeNull();

        var syntaxTree = Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParseText("class Demo { }", path: "demo.cs", cancellationToken: TestContext.Current.CancellationToken);
        var location = Location.Create(syntaxTree, new TextSpan(0, 1));
        var diagnostic = Diagnostic.Create(
            new DiagnosticDescriptor("TEST123", "title", "message", "Testing", DiagnosticSeverity.Warning, isEnabledByDefault: true),
            location);

        var result = (GeneratedAssemblyDiagnostic)method!.Invoke(null, [diagnostic])!;

        result.Id.ShouldBe("TEST123");
        result.FilePath.ShouldBe("demo.cs");
        result.Line.ShouldBe(1);
        result.Column.ShouldBe(1);
        result.IsWarningAsError.ShouldBeFalse();
    }

    [Fact]
    public void GeneratedAssemblyDiagnostic_FromRoslynDiagnosticHandlesNonSourceLocations()
    {
        var method = typeof(GeneratedAssemblyDiagnostic).GetMethod("FromRoslynDiagnostic", BindingFlags.Static | BindingFlags.NonPublic);
        method.ShouldNotBeNull();

        var diagnostic = Diagnostic.Create(
            new DiagnosticDescriptor("TEST124", "title", "message", "Testing", DiagnosticSeverity.Info, isEnabledByDefault: true),
            Location.None);

        var result = (GeneratedAssemblyDiagnostic)method!.Invoke(null, [diagnostic])!;

        result.FilePath.ShouldBeNull();
        result.Line.ShouldBeNull();
        result.Column.ShouldBeNull();
        result.Severity.ShouldBe(GeneratedAssemblyDiagnosticSeverity.Info);
    }

    private static OpenApiSchema LoadSchema(string schemaYaml)
    {
        var crd = (V1CustomResourceDefinition)k8s.KubernetesYaml.LoadAllFromString($$"""
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
""")[0];

        using var stream = new MemoryStream();
        System.Text.Json.JsonSerializer.Serialize(stream, crd.Spec.Versions.Single().Schema!.OpenAPIV3Schema, GeneratorSourceGenerationContext.Default.V1JSONSchemaProps);
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
