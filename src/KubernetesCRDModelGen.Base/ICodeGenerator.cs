using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.OpenApi;

namespace KubernetesCRDModelGen.Base;

// <summary>
// Provides methods to generate source code from a IOpenApiSchema.
// </summary>
public interface ICodeGenerator
{
    /// <summary>
    /// Generates source code from the given schema with the containing types.
    /// </summary>
    /// <param name="schema">Schema to generate</param>
    /// <param name="namespace">The namespace to use for the generated code.</param>
    /// <param name="version">Api Version</param>
    /// <param name="kind">Kube Kind</param>
    /// <param name="group">Api Group</param>
    /// <param name="plural">Kube Plural</param>
    /// <param name="listKind">Kube List Kind</param>
    /// <returns>CompilationUnitSyntax with the generated source code.</returns>
    CompilationUnitSyntax GenerateCompilationUnit(IOpenApiSchema schema, string @namespace, string version, string kind, string group, string plural, string? listKind);

    /// <summary>
    /// Enables or disables enum support in the generated code.
    /// When enabled, enums will be generated as part of the code model.
    /// </summary>
    /// <param name="enabled">True to enable enum support, false to disable.</param>
    void SetEnumSupport(bool enabled);
}
