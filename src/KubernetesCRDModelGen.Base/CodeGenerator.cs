using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi;
using System.Collections.Generic;

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
    public CompilationUnitSyntax GenerateCompilationUnit(IOpenApiSchema schema, string @namespace, string version, string kind, string group, string plural, string? listKind, bool isObsolete = false, string? obsoleteMessage = null)
        => renderer.RenderCompilationUnit(modelBuilder.BuildCompilationUnit(schema, @namespace, version, kind, group, plural, listKind, isObsolete, obsoleteMessage));

    /// <summary>
    /// Generates source code and reports non-fatal mapping warnings encountered during model construction.
    /// </summary>
    public CompilationUnitSyntax GenerateCompilationUnitWithWarnings(IOpenApiSchema schema, string @namespace, string version, string kind, string group, string plural, string? listKind, Action<string>? reportWarning, bool isObsolete = false, string? obsoleteMessage = null)
        => renderer.RenderCompilationUnit(modelBuilder.BuildCompilationUnitWithWarnings(schema, @namespace, version, kind, group, plural, listKind, reportWarning, isObsolete, obsoleteMessage));

    /// <inheritdoc/>
    public CompilationUnitSyntax GenerateCompilationUnit(string @namespace, string group, IReadOnlyList<MemberDeclarationSyntax> members)
        => renderer.RenderCompilationUnit(@namespace, group, members);

    /// <inheritdoc/>
    public BaseTypeDeclarationSyntax[] GenerateClass(IOpenApiSchema schema, string kind, string? version = null, string? group = null, string? plural = null, string? listKind = null, bool isObsolete = false, string? obsoleteMessage = null)
        => renderer.RenderTypes(modelBuilder.BuildTypes(schema, kind, version, group, plural, listKind, isObsolete, obsoleteMessage));

    /// <summary>
    /// Generates types and reports non-fatal mapping warnings encountered during model construction.
    /// </summary>
    public BaseTypeDeclarationSyntax[] GenerateClassWithWarnings(IOpenApiSchema schema, string kind, string? version = null, string? group = null, string? plural = null, string? listKind = null, Action<string>? reportWarning = null, bool isObsolete = false, string? obsoleteMessage = null)
        => renderer.RenderTypes(modelBuilder.BuildTypesWithWarnings(schema, kind, reportWarning, version, group, plural, listKind, isObsolete, obsoleteMessage));

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
