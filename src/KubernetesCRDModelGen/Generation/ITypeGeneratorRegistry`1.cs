using Microsoft.OpenApi.Interfaces;

namespace KubernetesCRDModelGen.Generation
{
    public interface ITypeGeneratorRegistry<in TElement> : ITypeGeneratorRegistry<TElement, PrimaryGeneratorCategory>
        where TElement : IOpenApiElement
    {
    }
}
