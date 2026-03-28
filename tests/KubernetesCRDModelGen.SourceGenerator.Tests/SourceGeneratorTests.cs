using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using Shouldly;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Xunit;

namespace KubernetesCRDModelGen.SourceGenerator.Tests;

public class SourceGeneratorTests
{
    [Fact]
    public void TestSourceGeneratorUsesNullableDirectiveOnceForKubeVirtCrd()
    {
        var generated = RunGeneratorForAdditionalText(
            "kubevirts.kubevirt.io.yaml",
            File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "kubevirts.kubevirt.io.yaml")));

        generated.ShouldContain("partial class V1KubeVirt");
        generated.ShouldContain("partial class V1KubeVirtList");
        generated.ShouldContain("public double? CpuRequest { get; set; }");
        generated.Split("#nullable enable", StringSplitOptions.None).Length - 1.ShouldBe(1);
        generated.ShouldNotContain("#nullable disable");

        var diagnostics = RunGeneratorForAdditionalTextWithDiagnostics(
            "kubevirts.kubevirt.io.yaml",
            File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "kubevirts.kubevirt.io.yaml"))).Diagnostics;
        diagnostics.Select(x => x.Id).ShouldContain("KG0");
        diagnostics.Select(x => x.Id).ShouldNotContain("KG1");
        diagnostics.Select(x => x.Id).ShouldNotContain("KG2");
        diagnostics.Select(x => x.Id).ShouldNotContain("KG3");
        diagnostics.Select(x => x.Id).ShouldNotContain("KG4");
        diagnostics.Select(x => x.Id).ShouldNotContain("KG5");
    }

    [Fact]
    public void TestSourceGeneratorIgnoresNonYamlFiles()
    {
        var generated = RunGeneratorForAdditionalText("notes.txt", "hello world");

        generated.ShouldBeEmpty();
    }

    [Fact]
    public void TestSourceGeneratorReportsParsingDiagnosticsForInvalidYaml()
    {
        var (generated, diagnostics) = RunGeneratorForAdditionalTextWithDiagnostics("broken.yaml", "not: [valid");

        generated.ShouldBeEmpty();
        diagnostics.Select(x => x.Id).ShouldContain("KG1");
    }

    [Fact]
    public void TestSourceGeneratorEmitsMultipleVersionsFromKubeVirtFixture()
    {
        var generated = RunGeneratorForAdditionalText(
            "kubevirts.kubevirt.io.yaml",
            File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "kubevirts.kubevirt.io.yaml")));

        generated.ShouldContain("partial class V1KubeVirt");
        generated.ShouldContain("partial class V1alpha3KubeVirt");
        generated.ShouldContain("partial class V1KubeVirtList");
        generated.ShouldContain("partial class V1alpha3KubeVirtList");
    }

    private static string RunGeneratorForAdditionalText(string path, string content)
    {
        var (_, generated) = RunGeneratorForAdditionalTextWithDiagnostics(path, content);
        return generated;
    }

    private static (IReadOnlyList<Diagnostic> Diagnostics, string Generated) RunGeneratorForAdditionalTextWithDiagnostics(string path, string content)
    {
        var generator = new SourceGenerator();
        var syntaxTree = CSharpSyntaxTree.ParseText("namespace Dummy; public class Marker {}");
        var compilation = CSharpCompilation.Create(
            "tests",
            [syntaxTree],
            references: AppDomain.CurrentDomain
                .GetAssemblies()
                .Where(a => !a.IsDynamic && !string.IsNullOrWhiteSpace(a.Location))
                .Select(a => MetadataReference.CreateFromFile(a.Location)),
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        var driver = CSharpGeneratorDriver.Create(
            [generator],
            additionalTexts: [new TestAdditionalText(path, content)],
            parseOptions: (CSharpParseOptions?)syntaxTree.Options);

        driver.RunGeneratorsAndUpdateCompilation(compilation, out _, out _);

        var runResult = driver.GetRunResult();
        var generated = string.Join("\n", runResult.GeneratedTrees.Select(tree => tree.ToString()));
        var diagnostics = runResult.Diagnostics.ToArray();

        return (diagnostics, generated);
    }

    private sealed class TestAdditionalText : AdditionalText
    {
        private readonly SourceText text;

        public TestAdditionalText(string path, string content)
        {
            Path = path;
            text = SourceText.From(content);
        }

        public override string Path { get; }

        public override SourceText? GetText(CancellationToken cancellationToken = default) => text;
    }
}
