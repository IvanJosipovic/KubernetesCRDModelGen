using Microsoft.CodeAnalysis;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
                Debugger.Launch();
            }
#endif
            codeGenerator = new CodeGenerator();

            var pipeline = context.AdditionalTextsProvider.Select(static (text, cancellationToken) =>
            {
                if (!text.Path.EndsWith(".yaml"))
                {
                    return default;
                }

                return (Name: Path.GetFileName(text.Path), Text: text.GetText(cancellationToken)?.ToString());
            })
            .Where((pair) => pair is not ((_, null) or (null, _)));

            context.RegisterSourceOutput(pipeline, static (context, pair) =>
            {
                try
                {
                    TextReader reader = new StringReader(pair.Text);

                    //var serializer = new SerializerBuilder().Build();

                    var deserializer = new DeserializerBuilder()
                        //.WithTypeConverter(new SystemTextJsonYamlTypeConverter())
                        .WithTypeInspector(x => new SystemTextJsonTypeInspector(x))
                        //.IgnoreUnmatchedProperties()
                        .Build();

                    var parser = new MergingParser(new Parser(reader));

                    parser.Consume<StreamStart>();

                    while (parser.Accept<DocumentStart>(out var start))
                    {
                        var crd = deserializer.Deserialize<V1CustomResourceDefinition>(parser);

                        var key = $"{crd.ApiVersion}/{crd.Kind}";

                        if (key == $"apiextensions.k8s.io/v1/CustomResourceDefinition")
                        {
                            try
                            {
                                var version = crd.Spec.Versions.First(x => x.Served && x.Storage);

                                var schema = version.Schema.OpenAPIV3Schema;

                                var code = codeGenerator.GenerateCompilationUnit(schema, "KubernetesCRDModelGen.Models", version.Name, crd.Spec.Names.Kind, crd.Spec.Group, crd.Spec.Names.Plural, crd.Spec.Names.ListKind);

                                context.AddSource($"{crd.Metadata.Name.Replace(".", "-")}.g.cs", code.SyntaxTree.GetText());
                            }
                            catch (Exception e)
                            {
                                context.ReportDiagnostic(Diagnostic.Create(
                                    new DiagnosticDescriptor(
                                    "KG2",
                                    $"Error converting {pair.Name} {key}",
                                    "{0}\n{1}",
                                    "KubernetesCRDModelGen",
                                    DiagnosticSeverity.Error,
                                    true), Location.None, $"Error converting {pair.Name} {key} {e.Message}", e.StackTrace));
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    context.ReportDiagnostic(Diagnostic.Create(
                        new DiagnosticDescriptor(
                        "KG1",
                        $"Error parsing {pair.Name}",
                        "{0}\n{1}",
                        "KubernetesCRDModelGen",
                        DiagnosticSeverity.Error,
                        true), Location.None, e, e.StackTrace));
            }
            });
        }
    }
}