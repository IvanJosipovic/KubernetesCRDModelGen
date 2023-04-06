using System.Collections.Generic;
using KubernetesCRDModelGen.Spec;
using Microsoft.OpenApi.Interfaces;

namespace KubernetesCRDModelGen.Generation
{
    // ReSharper disable once UnusedTypeParameter
    public interface ITypeGeneratorRegistry<in TElement, TGeneratorCategory>
        where TElement : IOpenApiElement
    {
        public ITypeGenerator Get(ILocatedOpenApiElement<TElement> element);

        IEnumerable<ITypeGenerator> GetAll();
    }
}
