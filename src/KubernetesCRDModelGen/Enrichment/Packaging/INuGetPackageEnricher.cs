using NuGet.Packaging;

namespace KubernetesCRDModelGen.Enrichment.Packaging
{
    public interface INuGetPackageEnricher : IEnricher<PackageBuilder>
    {
    }
}
