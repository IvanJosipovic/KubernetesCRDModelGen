using Microsoft.OpenApi.Interfaces;

namespace KubernetesCRDModelGen.Spec
{
    public interface ILocatedOpenApiElement<out T> : ILocatedOpenApiElement
        where T : IOpenApiElement
    {
        new T Element { get; }
    }
}
