using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
/// <summary>IPAMHandleSpec contains the specification for an IPAMHandle resource.</summary>
public partial class V1IPAMHandleSpec
{
    /// <summary></summary>
    [JsonPropertyName("block")]
    public IDictionary<string, int> Block { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("handleID")]
    public string HandleID { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1IPAMHandle : IKubernetesObject<V1ObjectMeta>, ISpec<V1IPAMHandleSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPAMHandle";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ipamhandles";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IPAMHandleSpec contains the specification for an IPAMHandle resource.</summary>
    [JsonPropertyName("spec")]
    public V1IPAMHandleSpec? Spec { get; set; }
}