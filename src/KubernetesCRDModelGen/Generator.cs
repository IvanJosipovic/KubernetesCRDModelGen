using k8s.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using System.Reflection;
using System.Text.Json;
using System.Xml;

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

    private readonly MetadataReference[] metadataReferences;

    private readonly CSharpCompilationOptions _options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)
        .WithConcurrentBuild(true)
        .WithDeterministic(true)
        .WithNullableContextOptions(NullableContextOptions.Enable)
        .WithOptimizationLevel(OptimizationLevel.Release)
        .WithOverflowChecks(false)
        .WithPlatform(Platform.AnyCpu)
        .WithSpecificDiagnosticOptions(
        [
            // Don't warn for binding redirects
            new("CS1701", ReportDiagnostic.Suppress),
            new("CS1702", ReportDiagnostic.Suppress)
        ]);

    /// <summary>
    /// Initializes a new instance of the <see cref="Generator"/> class.
    /// </summary>
    /// <param name="logger">The logger to use for logging messages.</param>
    public Generator(ILoggerFactory loggerFactory)
    {
        logger = loggerFactory.CreateLogger<Generator>();
        codeGenerator = new CodeGenerator();
        metadataReferences ??= GetReferences();
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
            var syntaxTree = code.SyntaxTree;

            // Use pooled memory streams to reduce GC pressure
            using var peStream = new MemoryStream(1024 * 256); // Reduced pre-size
            using var xmlDocumentationStream = new MemoryStream(32 * 1024); // Reduced pre-size

            var compilation = CSharpCompilation.Create(
                crd.Metadata.Name,
                syntaxTrees: new[] { syntaxTree },
                references: metadataReferences,
                options: _options);

            var result = compilation.Emit(peStream, xmlDocumentationStream: xmlDocumentationStream);

            if (!result.Success)
            {
                foreach (var diagnostic in result.Diagnostics)
                {
                    if (diagnostic.IsWarningAsError || diagnostic.Severity == DiagnosticSeverity.Error)
                        logger.LogError("Error creating Assembly: {id}: {message}", diagnostic.Id, diagnostic.GetMessage());
                }
            }
            else
            {
                peStream.Seek(0, SeekOrigin.Begin);
                var assembly = Assembly.Load(peStream.ToArray());

                xmlDocumentationStream.Seek(0, SeekOrigin.Begin);
                var xml = new XmlDocument();
                xml.Load(xmlDocumentationStream);

                return (assembly, xml);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error creating Assembly");
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
        var versions = crd.Spec.Versions.Where(x => x.Served).ToList();
        if (versions.Count == 0)
            throw new InvalidOperationException("No served versions found in CRD.");

        var types = new List<MemberDeclarationSyntax>(versions.Count * 2); // Pre-size for fewer allocations
        var reader = new OpenApiJsonReader();
        var openApiDoc = new OpenApiDocument();

        foreach (var version in versions)
        {
            var schema = version.Schema.OpenAPIV3Schema;
            if (schema == null) continue;

            var node = JsonSerializer.SerializeToNode(schema);
            var doc = reader.ReadFragment<OpenApiSchema>(node, OpenApiSpecVersion.OpenApi3_0, openApiDoc, out var diag);

            if (diag != null && diag.Errors.Count > 0)
            {
                logger.LogError("Error: {err}", string.Join(", ", diag.Errors.Select(x => x.Message)));
                continue;
            }

            var codeList = codeGenerator.GenerateClass(doc, crd.Spec.Names.Kind, version.Name, crd.Spec.Group, crd.Spec.Names.Plural, crd.Spec.Names.ListKind);
            if (codeList != null && codeList.Length > 0)
                types.AddRange(codeList);
        }

        return codeGenerator.GenerateCompilationUnit(@namespace, crd.Spec.Group, types.ToArray());
    }

    private MetadataReference[] GetReferences()
    {
        var references = new List<MetadataReference>();

        var assembly = GetType().Assembly;

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
