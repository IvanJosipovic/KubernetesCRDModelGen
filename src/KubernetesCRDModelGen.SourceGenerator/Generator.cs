using k8s;
using k8s.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
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

                    while (parser.TryConsume(out DocumentStart start))
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

                                context.AddSource($"{crd.Metadata.Name.Replace(".", "-")}.g.cs", code);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error converting from Json to {type} {json} {ex}", key, json, ex);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong Type: {type}", key);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Generating Code: {error}", ex);
                }
            }
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // No initialization required for this one
        }
    }
}