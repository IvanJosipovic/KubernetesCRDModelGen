using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
/// <summary>GlobalNetworkSetSpec contains the specification for a NetworkSet resource.</summary>
public partial class V1GlobalNetworkSetSpec
{
    /// <summary>The list of IP networks that belong to this set.</summary>
    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>GlobalNetworkSet contains a set of arbitrary IP sub-networks/CIDRs that share labels to allow rules to refer to them via selectors.  The labels of GlobalNetworkSet are not namespaced.</summary>
public partial class V1GlobalNetworkSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1GlobalNetworkSetSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "GlobalNetworkSet";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "globalnetworksets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GlobalNetworkSetSpec contains the specification for a NetworkSet resource.</summary>
    [JsonPropertyName("spec")]
    public V1GlobalNetworkSetSpec? Spec { get; set; }
}