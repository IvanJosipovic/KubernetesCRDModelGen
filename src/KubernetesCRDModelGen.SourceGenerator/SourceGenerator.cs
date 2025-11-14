using KubernetesCRDModelGen.Base;
using Microsoft.CodeAnalysis;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;
using YamlDotNet.System.Text.Json;

namespace KubernetesCRDModelGen.SourceGenerator
{
    [Generator]
    public class SourceGenerator : IIncrementalGenerator
    {
        private static CodeGenerator codeGenerator;

        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
#if DEBUG
            if (!Debugger.IsAttached)
            {
                //Debugger.Launch();
            }
#endif
            codeGenerator = new CodeGenerator();

            var localFilesPipeline = context.AdditionalTextsProvider.Select(static (text, cancellationToken) =>
            {
                if (!text.Path.EndsWith(".yaml"))
                {
                    return default;
                }

                return (Name: Path.GetFileName(text.Path), Text: text.GetText(cancellationToken)?.ToString());
            })
            .Where((pair) => pair is not ((_, null) or (null, _)));


            var client = new HttpClient();
            var externalYamlUrlsPipeline = context
                .AnalyzerConfigOptionsProvider
                .Select((config, _) => config.GlobalOptions
                    .TryGetValue($"build_property.CRDYamlSourceUrls", out var yamlCrdUrls)
                    ? yamlCrdUrls.Replace("\n", "").Split([','], StringSplitOptions.RemoveEmptyEntries)
                    : [])
                .SelectMany((urls, _) => urls)
                .Select((url, _) => (Url: url, Text: client.GetStringAsync(url).Result));
                

            context.RegisterSourceOutput(localFilesPipeline, static (context, pair) =>
            {
                // Log the filename that is loaded
                context.ReportDiagnostic(Diagnostic.Create(
                    new DiagnosticDescriptor(
                        "KG0",
                        "File loaded",
                        "Loaded file: {0}",
                        "KubernetesCRDModelGen",
                        DiagnosticSeverity.Info,
                        true),
                    Location.None,
                    pair.Name));

                GenerateSource(context, pair.Name, pair.Text);
            });

            context.RegisterSourceOutput(externalYamlUrlsPipeline, static (context, pair) =>
            {

                context.ReportDiagnostic(Diagnostic.Create(
                    new DiagnosticDescriptor(
                        "KG4",
                        "Fetched Yaml from Url",
                        "Loading {0}",
                        "KubernetesCRDModelGen",
                        DiagnosticSeverity.Info,
                        true),
                    Location.None,
                    pair.Url));

                GenerateSource(context, pair.Url, pair.Text);
            });

            return;

            static void GenerateSource(SourceProductionContext context, string sourceName, string? text)
            {
                try
                {
                    TextReader reader = new StringReader(text);

                    var openAPIReader = new OpenApiJsonReader();

                    var deserializer = new DeserializerBuilder()
                        .AddSystemTextJson()
                        .IgnoreUnmatchedProperties()
                        .Build();

                    var parser = new MergingParser(new Parser(reader));

                    parser.Consume<StreamStart>();

                    while (parser.Accept<DocumentStart>(out var start))
                    {
                        var crd = deserializer.Deserialize<V1CustomResourceDefinition?>(parser);

                        if (crd is null)
                        {
                            continue;
                        }

                        var key = $"{crd.ApiVersion}/{crd.Kind}";

                        if (key == $"apiextensions.k8s.io/v1/CustomResourceDefinition")
                        {
                            try
                            {
                                var versions = crd.Spec.Versions.Where(x => x.Served);

                                foreach (var version in versions)
                                {
                                    var doc = openAPIReader.ReadFragment<OpenApiSchema>(version.Schema.OpenAPIV3Schema, OpenApiSpecVersion.OpenApi3_0, new OpenApiDocument(), out var diag);

                                    if (diag != null && diag.Errors.Count > 0)
                                    {
                                        context.ReportDiagnostic(Diagnostic.Create(
                                            new DiagnosticDescriptor(
                                                "KG3",
                                                "Error Parsin Open API Spec",
                                                "Loaded source: {0}\r\n{1}",
                                                "KubernetesCRDModelGen",
                                                DiagnosticSeverity.Error,
                                                true),
                                            Location.None,
                                            sourceName, diag.Errors.Select(x => x.Message).Aggregate((a, b) => a + "\r\n" + b)));
                                    }

                                    var code = codeGenerator.GenerateCompilationUnit(doc, "KubernetesCRDModelGen.Models", version.Name, crd.Spec.Names.Kind, crd.Spec.Group, crd.Spec.Names.Plural, crd.Spec.Names.ListKind);

                                    var filename = CodeGenerator.RemoveIllegalFileNameCharacters($"{version.Name}.{crd.Metadata.Name}.g.cs");

                                    context.AddSource(filename, code.NormalizeWhitespace().ToFullString());
                                }
                            }
                            catch (Exception e)
                            {
                                context.ReportDiagnostic(Diagnostic.Create(
                                    new DiagnosticDescriptor(
                                    "KG2",
                                    $"Error converting {sourceName} {key}",
                                    "{0}\n{1}",
                                    "KubernetesCRDModelGen",
                                    DiagnosticSeverity.Error,
                                    true), Location.None, $"Error converting {sourceName} {key} {e.Message}", e.StackTrace));
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    context.ReportDiagnostic(Diagnostic.Create(
                        new DiagnosticDescriptor(
                        "KG1",
                        $"Error parsing {sourceName}",
                        "{0}\n{1}",
                        "KubernetesCRDModelGen",
                        DiagnosticSeverity.Error,
                        true), Location.None, e, e.StackTrace));
                }
            }
        }
    }
}