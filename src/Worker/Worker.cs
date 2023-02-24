
using Microsoft.OpenApi.Models;
using k8s.Models;
using k8s;
using System.Text;
using Yardarm.SystemTextJson;
using Yardarm;
using Microsoft.OpenApi.Readers;

namespace Worker {
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var objects = await KubernetesYaml.LoadAllFromFileAsync("CRD.yaml");

            var crd = (V1CustomResourceDefinition)objects[0];

            var openApiDocument = ConvertCRDToOpenAPI(crd);

            var settings = new YardarmGenerationSettings();
            settings.EmbedAllSources = true;
            settings.RootNamespace = "KubernetesCRDModelGen.Models";
            settings.AssemblyName = "KubernetesCRDModelGen.Models";
            //settings.AddExtension<SystemTextJsonExtension>();

            var generator = new YardarmGenerator(openApiDocument, settings);

            var res = await generator.EmitAsync();

            if (!res.Success) throw new Exception("Assembly build is not successful");

            using (Stream outStream = File.OpenWrite("models.dll"))
            {
                settings.DllOutput.Seek(0, SeekOrigin.Begin);
                settings.DllOutput.CopyTo(outStream);
            }

            using (Stream outStream = File.OpenWrite("models.pdb"))
            {
                settings.PdbOutput.Seek(0, SeekOrigin.Begin);
                settings.PdbOutput.CopyTo(outStream);
            }

            using (Stream outStream = File.OpenWrite("models.xml"))
            {
                settings.XmlDocumentationOutput.Seek(0, SeekOrigin.Begin);
                settings.XmlDocumentationOutput.CopyTo(outStream);
            }
        }

        private OpenApiDocument ConvertCRDToOpenAPI(V1CustomResourceDefinition crd)
        {
            var final = "openapi: \"3.0.0\"\r\npaths: {}\r\ncomponents:\r\n  schemas:\r\n";
            var kind = crd.Spec.Names.Kind;

            foreach (var version in crd.Spec.Versions) {
                var yaml = KubernetesYaml.Serialize(version.Schema.OpenAPIV3Schema);

                final = final + $"{(version.Name.CapitalizeFirstLetter() + kind).Indent(4)}:" + Environment.NewLine + yaml.Indent(6);
            }

            return new OpenApiStringReader().Read(final, out _);
        }
    }

    public static class StringExtensions {
        public static string Indent(this string input, int numSpaces) {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (numSpaces < 0)
                throw new ArgumentOutOfRangeException(nameof(numSpaces), "Number of spaces must be non-negative.");

            if (numSpaces == 0)
                return input;

            StringBuilder sb = new();
            string spaceStr = new(' ', numSpaces);

            using (StringReader reader = new StringReader(input)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    sb.Append(spaceStr);
                    sb.AppendLine(line);
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static string CapitalizeFirstLetter(this string str) {
            if (str.Length == 0) {
                return string.Empty;
            }
            else if (str.Length == 1) {
                return char.ToUpper(str[0]).ToString();
            }
            else {
                return char.ToUpper(str[0]) + str.Substring(1);
            }
        }
    }

}