using System.Collections.Generic;
using System.Threading;
using Microsoft.CodeAnalysis;

namespace KubernetesCRDModelGen.Generation
{
    public interface IReferenceGenerator
    {
        IAsyncEnumerable<MetadataReference> Generate(CancellationToken cancellationToken = default);
    }
}
