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

namespace KubernetesCRDModelGen;

public class CRDGenerator : ICRDGenerator
{
    public const string ModelNamespace = "KubernetesCRDModelGen.Models";

    private ILogger<CRDGenerator>? Logger { get; set; }

    private MetadataReference[] MetadataReferences { get; set; }

    public CRDGenerator(ILogger<CRDGenerator> logger)
    {
        Logger = logger;
    }

    public CRDGenerator()
    {
    }

    public string GenerateCode(V1CustomResourceDefinition crd, string @namespace = ModelNamespace)
    {


        return "";
    }

    public async Task<(Assembly?, XmlDocument?)> GenerateAssembly(V1CustomResourceDefinition crd, string @namespace = ModelNamespace, bool embedSources = true)
    {
        var settings = new YardarmGenerationSettings();
        settings.EmbedAllSources = embedSources;
        settings.RootNamespace = "KubernetesCRDModelGen";
        settings.AssemblyName = "KubernetesCRDModelGen.Models";
        //settings.AddExtension<SystemTextJsonExtension>();

        var openApiDocument = ConvertCRDToOpenAPI(crd);

        var generator = new YardarmGenerator(openApiDocument, settings);

        var res = await generator.EmitAsync();

        if (!res.Success) throw new Exception("Assembly build is not successful");

        settings.DllOutput.Seek(0, SeekOrigin.Begin);
        var assembly = System.Runtime.Loader.AssemblyLoadContext.Default.LoadFromStream(settings.DllOutput);

        settings.XmlDocumentationOutput.Seek(0, SeekOrigin.Begin);
        var xml = new XmlDocument();
        xml.Load(settings.XmlDocumentationOutput);

        return (assembly, xml);
    }

    private OpenApiDocument ConvertCRDToOpenAPI(V1CustomResourceDefinition crd) {
        var final = "openapi: \"3.0.0\"\r\npaths: {}\r\ncomponents:\r\n  schemas:\r\n";
        var kind = crd.Spec.Names.Kind;

        foreach (var version in crd.Spec.Versions) {

            // Supplement Schema
            //todo add ApiVersion/Kind
            //todo add


            var yaml = KubernetesYaml.Serialize(version.Schema.OpenAPIV3Schema);

            final = final + $"{(version.Name.CapitalizeFirstLetter() + kind).Indent(4)}:" + Environment.NewLine + yaml.Indent(6);

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