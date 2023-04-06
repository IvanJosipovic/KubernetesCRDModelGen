using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace KubernetesCRDModelGen.Names
{
    // ReSharper disable InconsistentNaming
    public interface IApiNamespace : IKnownNamespace
    {
        NameSyntax IApi { get; }
    }
}
