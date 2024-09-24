using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
public partial class V1beta1ComputeRouterSpecBgpAdvertisedIpRanges
{
    /// <summary>User-specified description for the IP range.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The IP range to advertise. The value must be a CIDR-formatted string.</summary>
    [JsonPropertyName("range")]
    public string Range { get; set; }
}

public partial class V1beta1ComputeRouterSpecBgp
{
    /// <summary>User-specified flag to indicate which mode to use for advertisement. Default value: "DEFAULT" Possible values: ["DEFAULT", "CUSTOM"].</summary>
    [JsonPropertyName("advertiseMode")]
    public string? AdvertiseMode { get; set; }

    /// <summary>User-specified list of prefix groups to advertise in custom mode. This field can only be populated if advertiseMode is CUSTOM and is advertised to all peers of the router. These groups will be advertised in addition to any specified prefixes. Leave this field blank to advertise no custom groups.  This enum field has the one valid value: ALL_SUBNETS.</summary>
    [JsonPropertyName("advertisedGroups")]
    public IList<string>? AdvertisedGroups { get; set; }

    /// <summary>User-specified list of individual IP ranges to advertise in custom mode. This field can only be populated if advertiseMode is CUSTOM and is advertised to all peers of the router. These IP ranges will be advertised in addition to any specified groups. Leave this field blank to advertise no custom IP ranges.</summary>
    [JsonPropertyName("advertisedIpRanges")]
    public IList<V1beta1ComputeRouterSpecBgpAdvertisedIpRanges>? AdvertisedIpRanges { get; set; }

    /// <summary>Local BGP Autonomous System Number (ASN). Must be an RFC6996 private ASN, either 16-bit or 32-bit. The value will be fixed for this router resource. All VPN tunnels that link to this router will have the same local ASN.</summary>
    [JsonPropertyName("asn")]
    public int Asn { get; set; }

    /// <summary>The interval in seconds between BGP keepalive messages that are sent to the peer. Hold time is three times the interval at which keepalive messages are sent, and the hold time is the maximum number of seconds allowed to elapse between successive keepalive messages that BGP receives from a peer.  BGP will use the smaller of either the local hold time value or the peer's hold time value as the hold time for the BGP connection between the two peers. If set, this value must be between 20 and 60. The default is 20.</summary>
    [JsonPropertyName("keepaliveInterval")]
    public int? KeepaliveInterval { get; set; }
}

public partial class V1beta1ComputeRouterSpecNetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ComputeRouterSpec
{
    /// <summary>BGP information specific to this router.</summary>
    [JsonPropertyName("bgp")]
    public V1beta1ComputeRouterSpecBgp? Bgp { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Indicates if a router is dedicated for use with encrypted VLAN attachments (interconnectAttachments).</summary>
    [JsonPropertyName("encryptedInterconnectRouter")]
    public bool? EncryptedInterconnectRouter { get; set; }

    /// <summary>A reference to the network to which this router belongs.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ComputeRouterSpecNetworkRef NetworkRef { get; set; }

    /// <summary>Immutable. Region where the router resides.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

public partial class V1beta1ComputeRouterStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1ComputeRouterStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeRouterStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeRouter : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeRouterSpec>, IStatus<V1beta1ComputeRouterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeRouter";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computerouters";
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
    public V1beta1ComputeRouterSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeRouterStatus? Status { get; set; }
}