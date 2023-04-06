using System.Collections.Generic;
using NuGet.Frameworks;
using NuGet.LibraryModel;

namespace KubernetesCRDModelGen.Packaging
{
    public interface IDependencyGenerator
    {
        IEnumerable<LibraryDependency> GetDependencies(NuGetFramework targetFramework);
    }
}
