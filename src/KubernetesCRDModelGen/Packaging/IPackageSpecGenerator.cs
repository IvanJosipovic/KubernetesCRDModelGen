using NuGet.ProjectModel;

namespace KubernetesCRDModelGen.Packaging
{
    public interface IPackageSpecGenerator
    {
        PackageSpec Generate();
    }
}
