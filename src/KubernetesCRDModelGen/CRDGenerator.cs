using k8s;
using k8s.Models;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using System.Reflection;
using System.Text;
using System.Xml;
using Yardarm;
using Yardarm.SystemTextJson;

namespace KubernetesCRDModelGen;

public class CRDGenerator : ICRDGenerator {
    public const string ModelNamespace = "KubernetesCRDModelGen.Models2";

    private ILogger<CRDGenerator>? Logger { get; set; }

    private MetadataReference[] MetadataReferences { get; set; }

    public CRDGenerator(ILogger<CRDGenerator> logger) {
        Logger = logger;
    }

    public CRDGenerator() {
    }

    public string GenerateCode(V1CustomResourceDefinition crd, string @namespace = ModelNamespace) {
        return "";
    }

    public async Task<(Stream?, Stream?)> GenerateAssemblyStream(V1CustomResourceDefinition crd, string @namespace = ModelNamespace, bool embedSources = false) {
        var settings = new YardarmGenerationSettings();
        settings.EmbedAllSources = embedSources;
        settings.RootNamespace = ModelNamespace;
        settings.AssemblyName = Guid.NewGuid().ToString();
        settings.AddExtension<SystemTextJsonExtension>();
        settings.AddExtension<KubernetesExtension>();

        var openApiDocument = ConvertCRDToOpenAPI(crd);

        var generator = new YardarmGenerator(openApiDocument, settings);

        var res = await generator.EmitAsync();

        if (!res.Success) throw new Exception("Assembly build is not successful");

        return (settings.DllOutput, settings.XmlDocumentationOutput);
    }

    public async Task<(Assembly?, XmlDocument?)> GenerateAssembly(V1CustomResourceDefinition crd, string @namespace = ModelNamespace, bool embedSources = false)
    {
        var output = await GenerateAssemblyStream(crd, @namespace, embedSources);

        output.Item1.Seek(0, SeekOrigin.Begin);
        var assembly = System.Runtime.Loader.AssemblyLoadContext.Default.LoadFromStream(output.Item1);

        output.Item2.Seek(0, SeekOrigin.Begin);
        var xml = new XmlDocument();
        xml.Load(output.Item2);

        return (assembly, xml);
    }

    private OpenApiDocument ConvertCRDToOpenAPI(V1CustomResourceDefinition crd)
    {
        var final = "openapi: \"3.0.0\"\r\npaths: {}\r\ncomponents:\r\n  schemas:\r\n";

        foreach (var version in crd.Spec.Versions)
        {
            var schema = version.Schema.OpenAPIV3Schema;

            schema.Properties.Add("KubeApiVersion", new V1JSONSchemaProps() { Type = "string", DefaultProperty = version.Name });
            schema.Properties.Add("KubeKind", new V1JSONSchemaProps() { Type = "string", DefaultProperty = crd.Spec.Names.Kind });
            schema.Properties.Add("KubeGroup", new V1JSONSchemaProps() { Type = "string", DefaultProperty = crd.Spec.Group });
            schema.Properties.Add("KubePluralName", new V1JSONSchemaProps() { Type = "string", DefaultProperty = crd.Spec.Names.Plural });

            var yaml = KubernetesYaml.Serialize(schema);

            final = final + $"{(version.Name.CapitalizeFirstLetter() + crd.Spec.Names.Kind).Indent(4)}:" + Environment.NewLine + yaml.Indent(6);

            final += Environment.NewLine;
        }

        return new OpenApiStringReader().Read(final, out _);
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