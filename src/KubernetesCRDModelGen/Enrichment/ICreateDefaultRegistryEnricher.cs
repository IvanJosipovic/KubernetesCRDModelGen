using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace KubernetesCRDModelGen.Enrichment
{
    public interface ICreateDefaultRegistryEnricher : IEnricher<ExpressionSyntax>
    {
    }
}
