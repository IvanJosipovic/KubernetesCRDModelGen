using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace KubernetesCRDModelGen.Generation
{
    public interface ISyntaxTreeGenerator
    {
        IEnumerable<SyntaxTree> Generate();
    }
}
