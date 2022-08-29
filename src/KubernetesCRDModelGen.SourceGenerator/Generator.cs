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

            CRDGenerator.FixSerializer();

            var serializer = new SerializerBuilder()
                .JsonCompatible()
                .Build();

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
                        var json = serializer.Serialize(doc);

                        var meta = KubernetesJson.Deserialize<KubernetesObject>(json);
                        var key = $"{meta.ApiVersion}/{meta.Kind}";

                        if (key == $"{V1CustomResourceDefinition.KubeGroup}/{V1CustomResourceDefinition.KubeApiVersion}/{V1CustomResourceDefinition.KubeKind}")
                        {
                            try
                            {
                                var crd = KubernetesJson.Deserialize<V1CustomResourceDefinition>(json);
                                var code = crdGen.GenerateCode(crd, name);

                                // fix for summary https://github.com/borisdj/CsCodeGenerator/issues/6
                                code = code.Replace("    // <summary>", "    /// <summary>");

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
                                    true), Location.None, e.Message, e.StackTrace));
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