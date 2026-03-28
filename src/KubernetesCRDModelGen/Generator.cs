using k8s.Models;
using KubernetesCRDModelGen.Base;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using System.Reflection;
using System.Runtime.Loader;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using static k8s.KubernetesJson;

namespace KubernetesCRDModelGen;

/// <inheritdoc/>
public class Generator : IGenerator
{
    /// <summary>
    /// Default Namespace
    /// </summary>
    public const string ModelNamespace = "KubernetesCRDModelGen.Models";

    private readonly ILogger<Generator> logger;

    private readonly CodeGenerator codeGenerator;

    private static readonly Lazy<MetadataReference[]> MetadataReferencesCache = new(GetReferences);
    private static readonly Lazy<CSharpCompilation> CompilationTemplateCache = new(CreateCompilationTemplate);
    private static readonly OpenApiSpecVersion OpenApiVersion = OpenApiSpecVersion.OpenApi3_0;

    private static readonly CSharpCompilationOptions CompilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)
        .WithConcurrentBuild(false)
        .WithDeterministic(true)
        .WithNullableContextOptions(NullableContextOptions.Enable)
        .WithOptimizationLevel(OptimizationLevel.Release)
        .WithOverflowChecks(false)
        .WithPlatform(Platform.AnyCpu);

    /// <summary>
    /// Initializes a new instance of the <see cref="Generator"/> class.
    /// </summary>
    /// <param name="loggerFactory">The logger to use for logging messages.</param>
    public Generator(ILoggerFactory loggerFactory)
    {
        logger = loggerFactory.CreateLogger<Generator>();
        codeGenerator = new CodeGenerator();
    }

    /// <inheritdoc/>
    public void SetEnumSupport(bool enabled)
    {
        codeGenerator.SetEnumSupport(enabled);
    }

    /// <inheritdoc/>
    public (Assembly?, XmlDocument?) GenerateAssembly(V1CustomResourceDefinition crd, string @namespace = ModelNamespace)
    {
        try
        {
            var code = GenerateCompilationUnit(crd, @namespace);

            var compilation = CompilationTemplateCache.Value
                .WithAssemblyName(crd.Metadata.Name)
                .AddSyntaxTrees(code.SyntaxTree);

            using var peStream = new MemoryStream();
            using var xmlDocumentationStream = new MemoryStream();

            var result = compilation.Emit(peStream, xmlDocumentationStream: xmlDocumentationStream);

            if (!result.Success)
            {
                var failures = result.Diagnostics.Where(diagnostic => diagnostic.IsWarningAsError || diagnostic.Severity == DiagnosticSeverity.Error);

                foreach (var diagnostic in failures)
                {
                    logger.LogError("Error creating Assembly: {id}: {message}", diagnostic.Id, diagnostic.GetMessage());
                }
            }
            else
            {
                peStream.Seek(0, SeekOrigin.Begin);
                xmlDocumentationStream.Seek(0, SeekOrigin.Begin);

                var alc = new AssemblyLoadContext(crd.Metadata.Name, isCollectible: true);
                var assembly = alc.LoadFromStream(peStream);

                var xml = new XmlDocument();
                xml.Load(xmlDocumentationStream);

                return (assembly, xml);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error creating Assembly for CRD {crdName}", crd.Metadata.Name);
        }

        return (null, null);
    }

    /// <inheritdoc/>
    public string GenerateCode(V1CustomResourceDefinition crd, string @namespace = ModelNamespace)
    {
        var code = GenerateCompilationUnit(crd, @namespace);

        return code.NormalizeWhitespace().ToFullString();
    }

    private CompilationUnitSyntax GenerateCompilationUnit(V1CustomResourceDefinition crd, string @namespace)
    {
        var types = new List<MemberDeclarationSyntax>(crd.Spec.Versions.Count);

        var reader = new OpenApiJsonReader();
        using var schemaStream = new MemoryStream();

        foreach (var version in crd.Spec.Versions)
        {
            if (!version.Served)
            {
                continue;
            }

            if (version.Schema?.OpenAPIV3Schema is null)
            {
                continue;
            }

            var schema = version.Schema.OpenAPIV3Schema;
            if (schema is null)
            {
                continue;
            }

            schemaStream.SetLength(0);
            JsonSerializer.Serialize(schemaStream, schema, GeneratorSourceGenerationContext.Default.V1JSONSchemaProps);
            schemaStream.Position = 0;

            var doc = reader.ReadFragment<OpenApiSchema>(schemaStream, OpenApiVersion, new OpenApiDocument(), out var diag);

            if (diag != null && diag.Errors.Count > 0)
            {
                var messages = string.Join(" | ", diag.Errors.Select(x => x.Message));
                logger.LogError("Error converting schema to OpenAPI: {messages}", messages);
            }

            if (doc is null)
            {
                continue;
            }

            var code = codeGenerator.GenerateClass(doc, crd.Spec.Names.Kind, version.Name, crd.Spec.Group, crd.Spec.Names.Plural, crd.Spec.Names.ListKind);
            types.AddRange(code);
        }

        return codeGenerator.GenerateCompilationUnit(@namespace, crd.Spec.Group, types);
    }

    private static CSharpCompilation CreateCompilationTemplate()
        => CSharpCompilation.Create(
            assemblyName: "KubernetesCRDModelGen.Dynamic",
            syntaxTrees: [],
            references: MetadataReferencesCache.Value,
            options: CompilationOptions);

    private static MetadataReference[] GetReferences()
    {
        var references = new List<MetadataReference>();

        var assembly = typeof(Generator).Assembly;

        var assemblies = assembly.GetManifestResourceNames().Where(x => x.StartsWith("runtime.") && x.EndsWith(".dll")).ToList();

        foreach (var item in assemblies)
        {
            using var stream = assembly.GetManifestResourceStream(item);
            var ass = MetadataReference.CreateFromStream(stream!);
            references.Add(ass);
        }

        return [.. references];
    }
}

[JsonSerializable(typeof(JsonElement))]
[JsonSerializable(typeof(V1JSONSchemaProps))]
[JsonSerializable(typeof(Dictionary<object, object>))]
[JsonSerializable(typeof(byte))]
[JsonSerializable(typeof(Int16))]
[JsonSerializable(typeof(Int32))]
[JsonSerializable(typeof(Int64))]
[JsonSourceGenerationOptions(
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    UseStringEnumConverter = true,
    Converters = new[] { typeof(Iso8601TimeSpanConverter), typeof(KubernetesDateTimeConverter), typeof(KubernetesDateTimeOffsetConverter)})
]
internal partial class GeneratorSourceGenerationContext : JsonSerializerContext
{
}
