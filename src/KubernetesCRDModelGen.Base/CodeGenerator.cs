using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi;

namespace KubernetesCRDModelGen.Base;

/// <inheritdoc/>
public class CodeGenerator : ICodeGenerator
{
    private readonly OpenApiSchemaModelBuilder modelBuilder = new();
    private readonly RoslynCodeModelRenderer renderer = new();

    /// <inheritdoc/>
    public void SetEnumSupport(bool enabled)
    {
        modelBuilder.EnumSupport = enabled;
    }

    /// <inheritdoc/>
    public CompilationUnitSyntax GenerateCompilationUnit(IOpenApiSchema schema, string @namespace, string version, string kind, string group, string plural, string? listKind)
        => renderer.RenderCompilationUnit(modelBuilder.BuildCompilationUnit(schema, @namespace, version, kind, group, plural, listKind));

    /// <inheritdoc/>
    public CompilationUnitSyntax GenerateCompilationUnit(string @namespace, string group, MemberDeclarationSyntax[] members)
        => renderer.RenderCompilationUnit(@namespace, group, members);

    /// <inheritdoc/>
    public BaseTypeDeclarationSyntax[] GenerateClass(IOpenApiSchema schema, string kind, string? version = null, string? group = null, string? plural = null, string? listKind = null)
        => renderer.RenderTypes(modelBuilder.BuildTypes(schema, kind, version, group, plural, listKind));

    internal static string? CleanIdentifier(string name, bool @namespace = false)
        => CodeGenerationUtilities.CleanIdentifier(name, @namespace);

    /// <summary>
    /// Removes characters from a file name that are illegal on the current platform.
    /// </summary>
    /// <param name="fileName">The file name to sanitize.</param>
    /// <returns>The sanitized file name.</returns>
    public static string RemoveIllegalFileNameCharacters(string fileName)
        => CodeGenerationUtilities.RemoveIllegalFileNameCharacters(fileName);
}
