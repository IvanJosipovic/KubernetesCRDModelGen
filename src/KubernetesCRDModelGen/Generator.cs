using k8s.Models;
using KubernetesCRDModelGen.Base;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
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

    private readonly CodeGenerator codeGenerator;

    private static readonly Lazy<MetadataReference[]> MetadataReferencesCache = new(GetReferences);
    private static readonly Lazy<CSharpCompilation> CompilationTemplateCache = new(CreateCompilationTemplate);
    private static readonly Lazy<IIncrementalGenerator?> JsonSourceGeneratorCache = new(GetJsonSourceGenerator);
    private static readonly JsonTypeInfo<V1JSONSchemaProps> V1JsonSchemaPropsTypeInfo = GeneratorSourceGenerationContext.Default.V1JSONSchemaProps;
    private static readonly ConditionalWeakTable<V1JSONSchemaProps, OpenApiSchema> OpenApiSchemaCache = new();
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
    public Generator()
    {
        codeGenerator = new CodeGenerator();
    }

    /// <inheritdoc/>
    public void SetEnumSupport(bool enabled)
    {
        codeGenerator.SetEnumSupport(enabled);
    }

    /// <inheritdoc/>
    public GeneratedAssemblyResult GenerateAssembly(V1CustomResourceDefinition crd, string @namespace = ModelNamespace)
    {
        var crdName = crd.Metadata?.Name ?? "<unknown>";

        try
        {
            var schemaDiagnostics = new List<GeneratedAssemblyDiagnostic>();
            var code = GenerateCompilationUnit(crd, @namespace, schemaDiagnostics);

            var compilation = CompilationTemplateCache.Value
                .WithAssemblyName(crdName)
                .AddSyntaxTrees(code.SyntaxTree);
            compilation = RunJsonSourceGenerator(compilation, schemaDiagnostics);

            using var peStream = new MemoryStream();
            using var xmlDocumentationStream = new MemoryStream();

            var result = compilation.Emit(peStream, xmlDocumentationStream: xmlDocumentationStream);
            var diagnostics = schemaDiagnostics
                .Concat(result.Diagnostics
                .Where(diagnostic => diagnostic.IsWarningAsError || diagnostic.Severity >= DiagnosticSeverity.Warning)
                .Select(GeneratedAssemblyDiagnostic.FromRoslynDiagnostic)
                .ToArray())
                .ToArray();

            if (!result.Success)
            {
                return new GeneratedAssemblyResult(null, null, diagnostics, null);
            }

            peStream.Seek(0, SeekOrigin.Begin);
            xmlDocumentationStream.Seek(0, SeekOrigin.Begin);

            var alc = new AssemblyLoadContext(crdName, isCollectible: true);
            var assembly = alc.LoadFromStream(peStream);

            var xml = new XmlDocument();
            xml.Load(xmlDocumentationStream);

            return new GeneratedAssemblyResult(
                assembly,
                xml,
                diagnostics,
                new GeneratedAssemblyUnloadHandle(alc));
        }
        catch (Exception ex)
        {
            return new GeneratedAssemblyResult(
                null,
                null,
                [GeneratedAssemblyDiagnostic.FromException(ex)],
                null,
                ex);
        }
    }

    /// <inheritdoc/>
    public string GenerateCode(V1CustomResourceDefinition crd, string @namespace = ModelNamespace)
    {
        var code = GenerateCompilationUnit(crd, @namespace);

        return code.NormalizeWhitespace().ToFullString();
    }

    private CompilationUnitSyntax GenerateCompilationUnit(V1CustomResourceDefinition crd, string @namespace, ICollection<GeneratedAssemblyDiagnostic>? diagnostics = null)
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

            var doc = GetOpenApiSchema(reader, schemaStream, schema, diagnostics);
            if (doc is null)
            {
                continue;
            }

            var code = codeGenerator.GenerateClassWithWarnings(
                doc,
                crd.Spec.Names.Kind,
                version.Name,
                crd.Spec.Group,
                crd.Spec.Names.Plural,
                crd.Spec.Names.ListKind,
                message => diagnostics?.Add(
                    GeneratedAssemblyDiagnostic.Create(
                        GeneratedAssemblyDiagnostic.IntegerFormatDiagnosticId,
                        message,
                        GeneratedAssemblyDiagnosticSeverity.Warning)),
                version.Deprecated == true,
                version.DeprecationWarning);
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

    private static CSharpCompilation RunJsonSourceGenerator(CSharpCompilation compilation, ICollection<GeneratedAssemblyDiagnostic>? diagnostics)
    {
        var generator = JsonSourceGeneratorCache.Value;
        if (generator is null)
        {
            return compilation;
        }

        var driver = CSharpGeneratorDriver.Create(generator);
        driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var generatorDiagnostics);

        AppendRoslynDiagnostics(diagnostics, generatorDiagnostics);

        return (CSharpCompilation)outputCompilation;
    }

    private static IIncrementalGenerator? GetJsonSourceGenerator()
        => GetJsonSourceGenerator(typeof(Generator).Assembly, static (assembly, resourceName) => assembly.GetManifestResourceStream(resourceName));

    private static void AppendRoslynDiagnostics(ICollection<GeneratedAssemblyDiagnostic>? diagnostics, IEnumerable<Diagnostic> roslynDiagnostics)
    {
        if (diagnostics is null)
        {
            return;
        }

        foreach (var diagnostic in roslynDiagnostics.Where(diagnostic => diagnostic.IsWarningAsError || diagnostic.Severity >= DiagnosticSeverity.Warning))
        {
            diagnostics.Add(GeneratedAssemblyDiagnostic.FromRoslynDiagnostic(diagnostic));
        }
    }

    private static IIncrementalGenerator? GetJsonSourceGenerator(Assembly generatorAssembly, Func<Assembly, string, Stream?> openResourceStream)
    {
        try
        {
            var embeddedResourceName = generatorAssembly
                .GetManifestResourceNames()
                .FirstOrDefault(name => name.EndsWith("System.Text.Json.SourceGeneration.dll", StringComparison.OrdinalIgnoreCase));

            if (embeddedResourceName is null)
            {
                return null;
            }

            using var stream = openResourceStream(generatorAssembly, embeddedResourceName);
            if (stream is null)
            {
                return null;
            }

            var sourceGeneratorAssembly = AssemblyLoadContext.Default.LoadFromStream(stream);
            var generatorType = sourceGeneratorAssembly.GetType("System.Text.Json.SourceGeneration.JsonSourceGenerator", throwOnError: false);

            return generatorType is not null && Activator.CreateInstance(generatorType) is IIncrementalGenerator generator
                ? generator
                : null;
        }
        catch
        {
        }

        return null;
    }

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

        references.Add(MetadataReference.CreateFromFile(typeof(JavaScriptEncoder).Assembly.Location));

        return [.. references];
    }

    private OpenApiSchema? GetOpenApiSchema(OpenApiJsonReader reader, MemoryStream schemaStream, V1JSONSchemaProps schema, ICollection<GeneratedAssemblyDiagnostic>? diagnostics = null)
    {
        if (OpenApiSchemaCache.TryGetValue(schema, out var cachedSchema))
        {
            return cachedSchema;
        }

        schemaStream.SetLength(0);
        JsonSerializer.Serialize(schemaStream, schema, V1JsonSchemaPropsTypeInfo);
        schemaStream.Position = 0;

        var openApiSchema = reader.ReadFragment<OpenApiSchema>(schemaStream, OpenApiVersion, new OpenApiDocument(), out var diag);

        if (diag != null && diag.Errors.Count > 0)
        {
            foreach (var error in diag.Errors)
            {
                diagnostics?.Add(
                    GeneratedAssemblyDiagnostic.Create(
                        GeneratedAssemblyDiagnostic.OpenApiSchemaDiagnosticId,
                        error.Message,
                        GeneratedAssemblyDiagnosticSeverity.Warning));
            }
        }

        if (openApiSchema is not null)
        {
            OpenApiSchemaCache.Add(schema, openApiSchema);
        }

        return openApiSchema;
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
