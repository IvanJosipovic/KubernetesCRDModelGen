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
    /// <summary>
    /// Generates C# source files from CRD YAML inputs.
    /// </summary>
    [Generator]
    public class SourceGenerator : IIncrementalGenerator
    {
        private static readonly CodeGenerator codeGenerator = new();

        private static readonly HttpClient httpClient = new();

        /// <inheritdoc />
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
#if DEBUG
            if (!Debugger.IsAttached)
            {
                //Debugger.Launch();
            }
#endif
            var localFilesPipeline = context.AdditionalTextsProvider.Select(static (text, cancellationToken) =>
                {
                    if (!text.Path.EndsWith(".yaml", StringComparison.OrdinalIgnoreCase) &&
                        !text.Path.EndsWith(".yml", StringComparison.OrdinalIgnoreCase))
                    {
                        return default;
                    }

                    return (Name: Path.GetFileName(text.Path), Text: text.GetText(cancellationToken)?.ToString());
                })
                .Where((pair) => pair is not ((_, null) or (null, _)));

            var externalYamlUrlsPipeline = context
                .AnalyzerConfigOptionsProvider
                .Select((config, _) => config.GlobalOptions
                    .TryGetValue($"build_property.CRDYamlSourceUrls", out var yamlCrdUrls)
                    ? yamlCrdUrls
                        .Replace("\n", "")
                        .Split([','], StringSplitOptions.RemoveEmptyEntries)
                        .Select(url => url.Trim())
                    : [])
                .SelectMany((urls, _) => urls)
                .Select((url, _) =>
                {
                    try
                    {
                        var text = httpClient.GetStringAsync(url).GetAwaiter().GetResult();
                        return (Url: url, Text: (string?)text);
                    }
                    catch
                    {
                        return (Url: url, Text: (string?)null);
                    }
                });


            context.RegisterSourceOutput(localFilesPipeline, static (context, pair) =>
            {
                if (pair.Text is null)
                {
                    context.ReportDiagnostic(
                        Diagnostic.Create(
                            new DiagnosticDescriptor(
                                "KG5",
                                "Failed to read YAML",
                                "Failed to read YAML file {0}",
                                "KubernetesCRDModelGen",
                            DiagnosticSeverity.Error,
                            true),
                        Location.None,
                        pair.Name));

                    return;
                }

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
                if (pair.Text is null)
                {
                    context.ReportDiagnostic(Diagnostic.Create(
                        new DiagnosticDescriptor(
                            "KG5",
                            "Failed to fetch YAML",
                            "Failed to fetch URL {0}",
                            "KubernetesCRDModelGen",
                            DiagnosticSeverity.Error,
                            true),
                        Location.None,
                        pair.Url));

                    return;
                }

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
                                    if (version.Schema?.OpenAPIV3Schema is null)
                                    {
                                        continue;
                                    }

                                    var doc = openAPIReader.ReadFragment<OpenApiSchema>(version.Schema.OpenAPIV3Schema,
                                        OpenApiSpecVersion.OpenApi3_0, new OpenApiDocument(), out var diag);

                                    if (diag != null && diag.Errors.Count > 0)
                                    {
                                        context.ReportDiagnostic(Diagnostic.Create(
                                            new DiagnosticDescriptor(
                                                "KG3",
                                                "Error Parsing Open API Spec",
                                                "Loaded source: {0}\r\n{1}",
                                                "KubernetesCRDModelGen",
                                                DiagnosticSeverity.Error,
                                                true),
                                            Location.None,
                                            sourceName,
                                            diag.Errors.Select(x => x.Message).Aggregate((a, b) => a + "\r\n" + b)));
                                    }

                                    if (doc is null)
                                    {
                                        continue;
                                    }

                                    var code = codeGenerator.GenerateCompilationUnit(doc,
                                        "KubernetesCRDModelGen.Models", version.Name, crd.Spec.Names.Kind,
                                        crd.Spec.Group, crd.Spec.Names.Plural, crd.Spec.Names.ListKind, version.Deprecated == true, version.DeprecationWarning);

                                    var filename =
                                        CodeGenerator.RemoveIllegalFileNameCharacters(
                                            $"{version.Name}.{crd.Metadata.Name}.g.cs");

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
                                        true), Location.None, $"Error converting {sourceName} {key} {e.Message}",
                                    e.StackTrace));
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
