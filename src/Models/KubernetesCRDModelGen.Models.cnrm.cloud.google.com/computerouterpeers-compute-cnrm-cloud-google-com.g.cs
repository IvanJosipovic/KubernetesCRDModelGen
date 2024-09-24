using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterPeerSpecAdvertisedIpRanges
{
    /// <summary>User-specified description for the IP range.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The IP range to advertise. The value must be a CIDR-formatted string.</summary>
    [JsonPropertyName("range")]
    public string Range { get; set; }
}

/// <summary>BFD configuration for the BGP peering.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterPeerSpecBfd
{
    /// <summary>The minimum interval, in milliseconds, between BFD control packets received from the peer router. The actual value is negotiated between the two routers and is equal to the greater of this value and the transmit interval of the other router. If set, this value must be between 1000 and 30000.</summary>
    [JsonPropertyName("minReceiveInterval")]
    public int? MinReceiveInterval { get; set; }

    /// <summary>The minimum interval, in milliseconds, between BFD control packets transmitted to the peer router. The actual value is negotiated between the two routers and is equal to the greater of this value and the corresponding receive interval of the other router. If set, this value must be between 1000 and 30000.</summary>
    [JsonPropertyName("minTransmitInterval")]
    public int? MinTransmitInterval { get; set; }

    /// <summary>The number of consecutive BFD packets that must be missed before BFD declares that a peer is unavailable. If set, the value must be a value between 5 and 16.</summary>
    [JsonPropertyName("multiplier")]
    public int? Multiplier { get; set; }

    /// <summary>The BFD session initialization mode for this BGP peer. If set to 'ACTIVE', the Cloud Router will initiate the BFD session for this BGP peer. If set to 'PASSIVE', the Cloud Router will wait for the peer router to initiate the BFD session for this BGP peer. If set to 'DISABLED', BFD is disabled for this BGP peer. Possible values: ["ACTIVE", "DISABLED", "PASSIVE"].</summary>
    [JsonPropertyName("sessionInitializationMode")]
    public string SessionInitializationMode { get; set; }
}

/// <summary>IP address of the interface inside Google Cloud Platform. Only IPv4 is supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterPeerSpecIpAddress
{
    /// <summary></summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }
}

/// <summary>The URI of the VM instance that is used as third-party router appliances such as Next Gen Firewalls, Virtual Routers, or Router Appliances. The VM instance must be located in zones contained in the same region as this Cloud Router. The VM instance is the peer side of the BGP session.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterPeerSpecRouterApplianceInstanceRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeInstance` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The interface the BGP peer is associated with.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterPeerSpecRouterInterfaceRef
{
    /// <summary>Allowed value: The `name` field of a `ComputeRouterInterface` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Cloud Router in which this BGP peer will be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterPeerSpecRouterRef
{
    /// <summary>Allowed value: The `name` field of a `ComputeRouter` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterPeerSpec
{
    /// <summary>User-specified flag to indicate which mode to use for advertisement. Valid values of this enum field are: 'DEFAULT', 'CUSTOM' Default value: "DEFAULT" Possible values: ["DEFAULT", "CUSTOM"].</summary>
    [JsonPropertyName("advertiseMode")]
    public string? AdvertiseMode { get; set; }

    /// <summary>User-specified list of prefix groups to advertise in custom mode, which currently supports the following option:  * 'ALL_SUBNETS': Advertises all of the router's own VPC subnets. This excludes any routes learned for subnets that use VPC Network Peering.   Note that this field can only be populated if advertiseMode is 'CUSTOM' and overrides the list defined for the router (in the "bgp" message). These groups are advertised in addition to any specified prefixes. Leave this field blank to advertise no custom groups.</summary>
    [JsonPropertyName("advertisedGroups")]
    public IList<string>? AdvertisedGroups { get; set; }

    /// <summary>User-specified list of individual IP ranges to advertise in custom mode. This field can only be populated if advertiseMode is 'CUSTOM' and is advertised to all peers of the router. These IP ranges will be advertised in addition to any specified groups. Leave this field blank to advertise no custom IP ranges.</summary>
    [JsonPropertyName("advertisedIpRanges")]
    public IList<V1beta1ComputeRouterPeerSpecAdvertisedIpRanges>? AdvertisedIpRanges { get; set; }

    /// <summary>The priority of routes advertised to this BGP peer. Where there is more than one matching route of maximum length, the routes with the lowest priority value win.</summary>
    [JsonPropertyName("advertisedRoutePriority")]
    public int? AdvertisedRoutePriority { get; set; }

    /// <summary>BFD configuration for the BGP peering.</summary>
    [JsonPropertyName("bfd")]
    public V1beta1ComputeRouterPeerSpecBfd? Bfd { get; set; }

    /// <summary>The status of the BGP peer connection. If set to false, any active session with the peer is terminated and all associated routing information is removed. If set to true, the peer connection can be established with routing information. The default is true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Enable IPv6 traffic over BGP Peer. If not specified, it is disabled by default.</summary>
    [JsonPropertyName("enableIpv6")]
    public bool? EnableIpv6 { get; set; }

    /// <summary>IP address of the interface inside Google Cloud Platform. Only IPv4 is supported.</summary>
    [JsonPropertyName("ipAddress")]
    public V1beta1ComputeRouterPeerSpecIpAddress? IpAddress { get; set; }

    /// <summary>IPv6 address of the interface inside Google Cloud Platform. The address must be in the range 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64. If you do not specify the next hop addresses, Google Cloud automatically assigns unused addresses from the 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64 range for you.</summary>
    [JsonPropertyName("ipv6NexthopAddress")]
    public string? Ipv6NexthopAddress { get; set; }

    /// <summary>Peer BGP Autonomous System Number (ASN). Each BGP interface may use a different value.</summary>
    [JsonPropertyName("peerAsn")]
    public int PeerAsn { get; set; }

    /// <summary>IP address of the BGP interface outside Google Cloud Platform. Only IPv4 is supported. Required if 'ip_address' is set.</summary>
    [JsonPropertyName("peerIpAddress")]
    public string? PeerIpAddress { get; set; }

    /// <summary>IPv6 address of the BGP interface outside Google Cloud Platform. The address must be in the range 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64. If you do not specify the next hop addresses, Google Cloud automatically assigns unused addresses from the 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64 range for you.</summary>
    [JsonPropertyName("peerIpv6NexthopAddress")]
    public string? PeerIpv6NexthopAddress { get; set; }

    /// <summary>Immutable. Region where the router and BgpPeer reside. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The URI of the VM instance that is used as third-party router appliances such as Next Gen Firewalls, Virtual Routers, or Router Appliances. The VM instance must be located in zones contained in the same region as this Cloud Router. The VM instance is the peer side of the BGP session.</summary>
    [JsonPropertyName("routerApplianceInstanceRef")]
    public V1beta1ComputeRouterPeerSpecRouterApplianceInstanceRef? RouterApplianceInstanceRef { get; set; }

    /// <summary>The interface the BGP peer is associated with.</summary>
    [JsonPropertyName("routerInterfaceRef")]
    public V1beta1ComputeRouterPeerSpecRouterInterfaceRef RouterInterfaceRef { get; set; }

    /// <summary>The Cloud Router in which this BGP peer will be configured.</summary>
    [JsonPropertyName("routerRef")]
    public V1beta1ComputeRouterPeerSpecRouterRef RouterRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterPeerStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeRouterPeerStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeRouterPeerStatusConditions>? Conditions { get; set; }

    /// <summary>The resource that configures and manages this BGP peer.  * 'MANAGED_BY_USER' is the default value and can be managed by you or other users * 'MANAGED_BY_ATTACHMENT' is a BGP peer that is configured and managed by Cloud Interconnect, specifically by an InterconnectAttachment of type PARTNER. Google automatically creates, updates, and deletes this type of BGP peer when the PARTNER InterconnectAttachment is created, updated, or deleted.</summary>
    [JsonPropertyName("managementType")]
    public string? ManagementType { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeRouterPeer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeRouterPeerSpec>, IStatus<V1beta1ComputeRouterPeerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeRouterPeer";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computerouterpeers";
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
    public V1beta1ComputeRouterPeerSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeRouterPeerStatus? Status { get; set; }
}