﻿using Yardarm.Names;

namespace Yardarm.Generation.Internal
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
