using KubernetesCRDModelGen.Spec;
using Microsoft.OpenApi.Interfaces;

namespace KubernetesCRDModelGen.Generation
{
    // ReSharper disable once UnusedTypeParameter
    public interface ITypeGeneratorFactory<in TElement, TGeneratorCategory>
        where TElement : IOpenApiElement
    {
        ITypeGenerator Create(ILocatedOpenApiElement<TElement> element, ITypeGenerator? parent);
    }
}
