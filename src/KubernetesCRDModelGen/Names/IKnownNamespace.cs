using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace KubernetesCRDModelGen.Names
{
    public interface IKnownNamespace
    {
        NameSyntax Name { get; }
    }
}
