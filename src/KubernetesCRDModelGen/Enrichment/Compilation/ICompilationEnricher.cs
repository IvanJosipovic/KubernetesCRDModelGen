using Microsoft.CodeAnalysis.CSharp;

namespace KubernetesCRDModelGen.Enrichment.Compilation
{
    public interface ICompilationEnricher : IAsyncEnricher<CSharpCompilation>
    {
    }
}
