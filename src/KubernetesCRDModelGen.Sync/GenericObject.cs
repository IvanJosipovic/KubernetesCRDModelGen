using k8s;
using k8s.Models;

namespace KubernetesCRDModelGen.Sync;

public class GenericObject : IKubernetesObject<V1ObjectMeta>
{
    public string ApiVersion { get; set; }
    public string Kind { get; set; }
    public V1ObjectMeta Metadata { get; set; }
}
