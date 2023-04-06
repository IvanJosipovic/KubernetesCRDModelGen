using KubernetesCRDModelGen.Enrichment;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace KubernetesCRDModelGen.Enrichment.Compilation
{
    public interface IAssemblyInfoEnricher : IEnricher<CompilationUnitSyntax>
    {
    }
}
