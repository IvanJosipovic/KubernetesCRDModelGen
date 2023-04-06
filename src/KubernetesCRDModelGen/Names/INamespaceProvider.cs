using KubernetesCRDModelGen.Spec;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace KubernetesCRDModelGen.Names
{
    public interface INamespaceProvider
    {
        NameSyntax GetNamespace(ILocatedOpenApiElement element);
    }
}
