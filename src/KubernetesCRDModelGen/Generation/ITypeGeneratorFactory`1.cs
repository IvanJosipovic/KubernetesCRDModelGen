using Microsoft.OpenApi.Interfaces;

namespace KubernetesCRDModelGen.Generation
{
    public interface ITypeGeneratorFactory<in TElement> : ITypeGeneratorFactory<TElement, PrimaryGeneratorCategory>
        where TElement : IOpenApiElement
    {
    }
}
