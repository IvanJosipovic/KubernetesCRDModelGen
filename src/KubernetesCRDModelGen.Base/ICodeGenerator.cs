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
    /// <param name="crd">The custom resource definition.</param>
    /// <param name="namespace">The namespace to use for the generated code.</param>
    /// <returns>A string containing the generated source code.</returns>
    CompilationUnitSyntax GenerateCompilationUnit(IOpenApiSchema schema, string @namespace, string version, string kind, string group, string plural, string? listKind);

    /// <summary>
    /// Enables or disables enum support in the generated code.
    /// When enabled, enums will be generated as part of the code model.
    /// </summary>
    /// <param name="enabled">True to enable enum support, false to disable.</param>
    void SetEnumSupport(bool enabled);
}
