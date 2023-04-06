using KubernetesCRDModelGen.Names;

namespace KubernetesCRDModelGen.Generation.Internal
{
    internal class ClientGenerator : ResourceSyntaxTreeGenerator
    {
        protected override string ResourcePrefix => "KubernetesCRDModelGen.Models.";

        public ClientGenerator(GenerationContext generationContext, IRootNamespace rootNamespace)
            : base(generationContext, rootNamespace)
        {
        }
    }
}
