using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KubernetesCRDModelGen.Base;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using k8s.Models;
using Shouldly;
using Xunit;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;
using YamlDotNet.System.Text.Json;
using SourceGeneratorUnderTest = global::KubernetesCRDModelGen.SourceGenerator.SourceGenerator;

namespace KubernetesCRDModelGen.SourceGenerator.Tests;

public class SourceGeneratorTests
{
    private static readonly string KubeVirtFixturePath = Path.Combine(AppContext.BaseDirectory, "kubevirts.kubevirt.io.yaml");
    private static readonly string KubeVirtFixtureContent = File.ReadAllText(KubeVirtFixturePath);

    [Fact]
    public async Task KubeVirtFixture_GeneratesExpectedSources()
    {
        var test = CreateTest();
        test.TestCode = "namespace Dummy; public class Marker {}";
        test.TestState.AdditionalFiles.Add(("kubevirts.kubevirt.io.yaml", KubeVirtFixtureContent));
        test.ExpectedDiagnostics.Add(new DiagnosticResult("KG0", DiagnosticSeverity.Info).WithNoLocation());

        foreach (var generatedSource in GetExpectedKubeVirtGeneratedSources())
        {
            test.TestState.GeneratedSources.Add((typeof(SourceGeneratorUnderTest), generatedSource.filename, generatedSource.content));
        }

        await test.RunAsync(TestContext.Current.CancellationToken);
    }

    [Fact]
    public async Task NonYamlFiles_AreIgnored()
    {
        var test = CreateTest();
        test.TestCode = "namespace Dummy; public class Marker {}";
        test.TestState.AdditionalFiles.Add(("notes.txt", "hello world"));

        await test.RunAsync(TestContext.Current.CancellationToken);
    }

    [Fact]
    public async Task InvalidYaml_ReportsParsingDiagnostic()
    {
        var test = CreateTest();
        test.TestCode = "namespace Dummy; public class Marker {}";
        test.TestState.AdditionalFiles.Add(("broken.yaml", "not: [valid"));
        test.ExpectedDiagnostics.Add(new DiagnosticResult("KG0", DiagnosticSeverity.Info).WithNoLocation());
        test.ExpectedDiagnostics.Add(new DiagnosticResult("KG1", DiagnosticSeverity.Error).WithNoLocation());

        await test.RunAsync(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void KubeVirtFixture_ContainsExpectedVersionedDefinitions()
    {
        var generatedSources = GetExpectedKubeVirtGeneratedSources().ToArray();

        generatedSources.Any(source => source.filename == "v1.kubevirts.kubevirt.io.g.cs").ShouldBeTrue();
        generatedSources.Any(source => source.filename == "v1alpha3.kubevirts.kubevirt.io.g.cs").ShouldBeTrue();
        generatedSources.Any(source => source.content.Contains("partial class V1KubeVirt")).ShouldBeTrue();
        generatedSources.Any(source => source.content.Contains("partial class V1KubeVirtList")).ShouldBeTrue();
        generatedSources.Any(source => source.content.Contains("partial class V1alpha3KubeVirt")).ShouldBeTrue();
        generatedSources.Any(source => source.content.Contains("partial class V1alpha3KubeVirtList")).ShouldBeTrue();
        generatedSources.All(source => source.content.Contains("public string ApiVersion { get; set; }")).ShouldBeTrue();
        generatedSources.All(source => source.content.Split("#nullable enable", StringSplitOptions.None).Length - 1 == 1).ShouldBeTrue();
        generatedSources.All(source => !source.content.Contains("#nullable disable")).ShouldBeTrue();
    }

    private static CSharpSourceGeneratorTest<SourceGeneratorUnderTest, DefaultVerifier> CreateTest()
    {
        var test = new CSharpSourceGeneratorTest<SourceGeneratorUnderTest, DefaultVerifier>
        {
            ReferenceAssemblies = ReferenceAssemblies.Net.Net90,
            CompilerDiagnostics = CompilerDiagnostics.None,
        };

        test.TestState.AdditionalReferences.Add(MetadataReference.CreateFromFile(typeof(V1ObjectMeta).Assembly.Location));

        return test;
    }

    private static IEnumerable<(string filename, string content)> GetExpectedKubeVirtGeneratedSources()
    {
        var deserializer = new DeserializerBuilder()
            .AddSystemTextJson()
            .IgnoreUnmatchedProperties()
            .Build();
        using var reader = new StringReader(KubeVirtFixtureContent);
        var parser = new MergingParser(new Parser(reader));
        parser.Consume<StreamStart>();

        var crd = deserializer.Deserialize<global::KubernetesCRDModelGen.SourceGenerator.V1CustomResourceDefinition?>(parser);
        crd.ShouldNotBeNull();

        var codeGenerator = new CodeGenerator();
        var openApiReader = new OpenApiJsonReader();

        foreach (var version in crd.Spec.Versions.Where(version => version.Served && version.Schema?.OpenAPIV3Schema is not null))
        {
            var schema = openApiReader.ReadFragment<OpenApiSchema>(
                version.Schema!.OpenAPIV3Schema,
                OpenApiSpecVersion.OpenApi3_0,
                new OpenApiDocument(),
                out _);
            schema.ShouldNotBeNull();

            var code = codeGenerator
                .GenerateCompilationUnit(
                    schema,
                    "KubernetesCRDModelGen.Models",
                    version.Name,
                    crd.Spec.Names.Kind,
                    crd.Spec.Group,
                    crd.Spec.Names.Plural,
                    crd.Spec.Names.ListKind,
                    version.Deprecated == true,
                    version.DeprecationWarning)
                .NormalizeWhitespace()
                .ToFullString();

            yield return ($"{version.Name}.{crd.Metadata.Name}.g.cs", code);
        }
    }
}
