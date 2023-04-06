using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace KubernetesCRDModelGen.Names
{
    // ReSharper disable InconsistentNaming
    public interface IRequestsNamespace : IKnownNamespace
    {
        NameSyntax IOperationRequest { get; }
        NameSyntax OperationRequest { get; }
    }
}
