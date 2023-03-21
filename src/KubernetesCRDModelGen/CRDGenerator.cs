using k8s;
using k8s.Models;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;
using System.Xml;
using Yardarm;
using Yardarm.SystemTextJson;

namespace KubernetesCRDModelGen;

public class CRDGenerator : ICRDGenerator {
    public const string RootNamespace = "KubernetesCRDModelGen.Models";

    private ILogger<CRDGenerator>? Logger { get; set; }

    private MetadataReference[] MetadataReferences { get; set; }

    public CRDGenerator(ILogger<CRDGenerator> logger) {
        Logger = logger;
    }

    public CRDGenerator() {
    }

    public async Task<(Stream, Stream)> GeneratePackageStream(IEnumerable<V1CustomResourceDefinition> crds, string assemblyName, string @namespace = RootNamespace) {
        var settings = new YardarmGenerationSettings();
        settings.EmbedAllSources = true;
        settings.RootNamespace = @namespace;
        settings.AssemblyName = assemblyName;
        settings.AddExtension<SystemTextJsonExtension>();
        settings.AddExtension<KubernetesExtension>();
        settings.NuGetOutput = new MemoryStream();
        settings.NuGetSymbolsOutput = new MemoryStream();

        var openApiDocument = ConvertCRDToOpenAPI(crds);

        var generator = new YardarmGenerator(openApiDocument, settings);

        var res = await generator.EmitAsync();

        if (!res.Success) throw new Exception("Assembly build is not successful");

        return (settings.NuGetOutput, settings.NuGetSymbolsOutput);
    }

    public async Task<(Stream?, Stream?)> GenerateAssemblyStream(V1CustomResourceDefinition crd, string @namespace = RootNamespace, bool embedSources = false) {
        var settings = new YardarmGenerationSettings();
        settings.EmbedAllSources = embedSources;
        settings.RootNamespace = @namespace;
        settings.AssemblyName = crd.Metadata.Name;
        settings.AddExtension<SystemTextJsonExtension>();
        settings.AddExtension<KubernetesExtension>();

        var openApiDocument = ConvertCRDToOpenAPI(crd);

        var generator = new YardarmGenerator(openApiDocument, settings);

        var res = await generator.EmitAsync();

        if (!res.Success) throw new Exception("Assembly build is not successful");

        return (settings.DllOutput, settings.XmlDocumentationOutput);
    }

    public async Task<(Assembly?, XmlDocument?)> GenerateAssembly(V1CustomResourceDefinition crd, string @namespace = RootNamespace, bool embedSources = false)
    {
        var output = await GenerateAssemblyStream(crd, @namespace, embedSources);

        output.Item1.Seek(0, SeekOrigin.Begin);

        using (var memoryStream = new MemoryStream()) {
            output.Item1.CopyTo(memoryStream);
            var assembly = Assembly.Load(memoryStream.ToArray());

            output.Item2.Seek(0, SeekOrigin.Begin);
            var xml = new XmlDocument();
            xml.Load(output.Item2);

            return (assembly, xml);
        }

        //var assembly = AssemblyLoadContext.Default.LoadFromStream(output.Item1);
    }

    private static OpenApiDocument ConvertCRDToOpenAPI(V1CustomResourceDefinition crd) => ConvertCRDToOpenAPI(new[] { crd });

    private static OpenApiDocument ConvertCRDToOpenAPI(IEnumerable<V1CustomResourceDefinition> crds)
    {
        var final = "openapi: \"3.0.0\"\r\npaths: {}\r\ncomponents:\r\n  schemas:\r\n";

        foreach (var crd in crds) {
            foreach (var version in crd.Spec.Versions) {
                var schema = version.Schema.OpenAPIV3Schema;
                var name = version.Name + crd.Spec.Group.Replace(".", "") + crd.Spec.Names.Kind;

                if (schema.Properties == null) {
                    schema.Properties = new Dictionary<string, V1JSONSchemaProps>();
                }

                schema.Properties.Add("KubeApiVersion", new V1JSONSchemaProps() { Type = "string", DefaultProperty = version.Name });
                schema.Properties.Add("KubeKind", new V1JSONSchemaProps() { Type = "string", DefaultProperty = crd.Spec.Names.Kind });
                schema.Properties.Add("KubeGroup", new V1JSONSchemaProps() { Type = "string", DefaultProperty = crd.Spec.Group });
                schema.Properties.Add("KubePluralName", new V1JSONSchemaProps() { Type = "string", DefaultProperty = crd.Spec.Names.Plural });

                var yaml = KubernetesYaml.Serialize(schema);

                final = final + $"{name.Indent(4)}:" + Environment.NewLine + yaml.Indent(6);

                final += Environment.NewLine;
            }
        }

        var doc = new OpenApiStringReader().Read(final, out var diag);

        if (doc.Components == null) {
            throw new Exception("Components are null");
        }

        return doc;
    }

    private void GenerateReferences()
    {
        var references = new List<MetadataReference>();

        var assebly = GetType().Assembly;

        var assemblies = assebly.GetManifestResourceNames().Where(x => x.StartsWith("runtime.") && x.EndsWith(".dll")).ToList();

        foreach (var item in assemblies)
        {
            using var stream = assebly.GetManifestResourceStream(item);
            var ass = MetadataReference.CreateFromStream(stream);
            references.Add(ass);
        }

        references.AddRange(Basic.Reference.Assemblies.NetStandard20.References.All);

        MetadataReferences = references.ToArray();
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