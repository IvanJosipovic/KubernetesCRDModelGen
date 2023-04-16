using k8s;
using k8s.Models;
using Microsoft.CodeAnalysis;
using System;
using System.IO;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace KubernetesCRDModelGen.SourceGenerator
{
    [Generator]
    public class Generator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
#if DEBUG
            //if (!Debugger.IsAttached)
            //{
            //    Debugger.Launch();
            //}
#endif

            var name = context.Compilation.AssemblyName;

            var serializer = new SerializerBuilder().Build();

            var deserializer = new DeserializerBuilder().Build();

            var crdGen = new CRDGenerator();

            foreach (var file in context.AdditionalFiles)
            {
                try
                {
                    var cont = file.GetText().ToString();

                    using TextReader reader = new StringReader(cont);

                    var parser = new Parser(reader);

                    parser.Consume<StreamStart>();

                    while (parser.Accept<DocumentStart>(out var start))
                    {
                        var doc = deserializer.Deserialize(parser);
                        var yaml = serializer.Serialize(doc);

                        var meta = KubernetesYaml.Deserialize<KubernetesObject>(yaml);
                        var key = $"{meta.ApiVersion}/{meta.Kind}";

                        if (key == $"{V1CustomResourceDefinition.KubeGroup}/{V1CustomResourceDefinition.KubeApiVersion}/{V1CustomResourceDefinition.KubeKind}")
                        {
                            try
                            {
                                var crd = KubernetesYaml.Deserialize<V1CustomResourceDefinition>(yaml);
                                var code = crdGen.GenerateCode(crd, "KubernetesCRDModelGen.Models");

                                context.AddSource($"{crd.Metadata.Name.Replace(".", "-")}.g.cs", code);
                            }
                            catch (Exception e)
                            {
                                context.ReportDiagnostic(Diagnostic.Create(
                                    new DiagnosticDescriptor(
                                    "KG2",
                                    $"Error converting {file.Path} {key}",
                                    "{0}\n{1}",
                                    "KubernetesCRDModelGen",
                                    DiagnosticSeverity.Error,
                                    true), Location.None, $"Error converting {file.Path} {key} {e.Message}", e.StackTrace));
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    context.ReportDiagnostic(Diagnostic.Create(
                        new DiagnosticDescriptor(
                        "KG1",
                        $"Error parsing {file.Path}",
                        "{0}\n{1}",
                        "KubernetesCRDModelGen",
                        DiagnosticSeverity.Error,
                        true), Location.None, e.Message, e.StackTrace));
                }
            }
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // No initialization required for this one
        }
    }
}