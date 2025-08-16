using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BGPPeerList : IKubernetesObject<V1ListMeta>, IItems<V1BGPPeer>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPPeerList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgppeers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1BGPPeer> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPPeerSpecPasswordSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPPeerSpecPassword
{
    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1BGPPeerSpecPasswordSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPPeerSpec
{
    /// <summary></summary>
    [JsonPropertyName("asNumber")]
    public int? AsNumber { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filters")]
    public IList<string>? Filters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keepOriginalNextHop")]
    public bool? KeepOriginalNextHop { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localASNumber")]
    public int? LocalASNumber { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localWorkloadSelector")]
    public string? LocalWorkloadSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxRestartTime")]
    public string? MaxRestartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nextHopMode")]
    public string? NextHopMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("node")]
    public string? Node { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSelector")]
    public string? NodeSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("numAllowedLocalASNumbers")]
    public int? NumAllowedLocalASNumbers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("password")]
    public V1BGPPeerSpecPassword? Password { get; set; }

    /// <summary></summary>
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("peerSelector")]
    public string? PeerSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reachableBy")]
    public string? ReachableBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reversePeering")]
    public string? ReversePeering { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceAddress")]
    public string? SourceAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ttlSecurity")]
    public int? TtlSecurity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BGPPeer : IKubernetesObject<V1ObjectMeta>, ISpec<V1BGPPeerSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPPeer";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgppeers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1BGPPeerSpec? Spec { get; set; }
}