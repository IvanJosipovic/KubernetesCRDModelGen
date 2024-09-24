using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
/// <summary>Deprecated: this field is only used for APIv1 backwards compatibility. Setting this field is not allowed, this field is for internal use only.</summary>
public partial class V1IPPoolSpecIpip
{
    /// <summary>When enabled is true, ipip tunneling will be used to deliver packets to destinations within this pool.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The IPIP mode.  This can be one of "always" or "cross-subnet".  A mode of "always" will also use IPIP tunneling for routing to destination IP addresses within this pool.  A mode of "cross-subnet" will only use IPIP tunneling when the destination node is on a different subnet to the originating node.  The default value (if not specified) is "always".</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>IPPoolSpec contains the specification for an IPPool resource.</summary>
public partial class V1IPPoolSpec
{
    /// <summary>AllowedUse controls what the IP pool will be used for.  If not specified or empty, defaults to ["Tunnel", "Workload"] for back-compatibility</summary>
    [JsonPropertyName("allowedUses")]
    public IList<string>? AllowedUses { get; set; }

    /// <summary>The block size to use for IP address assignments from this pool. Defaults to 26 for IPv4 and 122 for IPv6.</summary>
    [JsonPropertyName("blockSize")]
    public int? BlockSize { get; set; }

    /// <summary>The pool CIDR.</summary>
    [JsonPropertyName("cidr")]
    public string Cidr { get; set; }

    /// <summary>Disable exporting routes from this IP Pool's CIDR over BGP. [Default: false]</summary>
    [JsonPropertyName("disableBGPExport")]
    public bool? DisableBGPExport { get; set; }

    /// <summary>When disabled is true, Calico IPAM will not assign addresses from this pool.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Deprecated: this field is only used for APIv1 backwards compatibility. Setting this field is not allowed, this field is for internal use only.</summary>
    [JsonPropertyName("ipip")]
    public V1IPPoolSpecIpip? Ipip { get; set; }

    /// <summary>Contains configuration for IPIP tunneling for this pool. If not specified, then this is defaulted to "Never" (i.e. IPIP tunneling is disabled).</summary>
    [JsonPropertyName("ipipMode")]
    public string? IpipMode { get; set; }

    /// <summary>Deprecated: this field is only used for APIv1 backwards compatibility. Setting this field is not allowed, this field is for internal use only.</summary>
    [JsonPropertyName("nat-outgoing")]
    public bool? NatOutgoing { get; set; }

    /// <summary>When natOutgoing is true, packets sent from Calico networked containers in this pool to destinations outside of this pool will be masqueraded.</summary>
    [JsonPropertyName("natOutgoing1")]
    public bool? NatOutgoing1 { get; set; }

    /// <summary>Allows IPPool to allocate for a specific node by label selector.</summary>
    [JsonPropertyName("nodeSelector")]
    public string? NodeSelector { get; set; }

    /// <summary>Contains configuration for VXLAN tunneling for this pool. If not specified, then this is defaulted to "Never" (i.e. VXLAN tunneling is disabled).</summary>
    [JsonPropertyName("vxlanMode")]
    public string? VxlanMode { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1IPPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1IPPoolSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPPool";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ippools";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IPPoolSpec contains the specification for an IPPool resource.</summary>
    [JsonPropertyName("spec")]
    public V1IPPoolSpec? Spec { get; set; }
}