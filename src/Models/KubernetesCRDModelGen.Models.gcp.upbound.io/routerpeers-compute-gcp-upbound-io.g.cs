using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary>RouterPeer is the Schema for the RouterPeers API. BGP information that must be configured into the routing stack to establish BGP peering.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RouterPeerList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RouterPeer>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RouterPeerList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "routerpeers";
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
    public IList<V1beta1RouterPeer> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderAdvertisedIpRanges
{
    /// <summary>User-specified description for the IP range.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The IP range to advertise. The value must be a CIDR-formatted string.</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderBfd
{
    /// <summary>The minimum interval, in milliseconds, between BFD control packets received from the peer router. The actual value is negotiated between the two routers and is equal to the greater of this value and the transmit interval of the other router. If set, this value must be between 1000 and 30000.</summary>
    [JsonPropertyName("minReceiveInterval")]
    public double? MinReceiveInterval { get; set; }

    /// <summary>The minimum interval, in milliseconds, between BFD control packets transmitted to the peer router. The actual value is negotiated between the two routers and is equal to the greater of this value and the corresponding receive interval of the other router. If set, this value must be between 1000 and 30000.</summary>
    [JsonPropertyName("minTransmitInterval")]
    public double? MinTransmitInterval { get; set; }

    /// <summary>The number of consecutive BFD packets that must be missed before BFD declares that a peer is unavailable. If set, the value must be a value between 5 and 16.</summary>
    [JsonPropertyName("multiplier")]
    public double? Multiplier { get; set; }

    /// <summary>The BFD session initialization mode for this BGP peer. If set to ACTIVE, the Cloud Router will initiate the BFD session for this BGP peer. If set to PASSIVE, the Cloud Router will wait for the peer router to initiate the BFD session for this BGP peer. If set to DISABLED, BFD is disabled for this BGP peer. Possible values are: ACTIVE, DISABLED, PASSIVE.</summary>
    [JsonPropertyName("sessionInitializationMode")]
    public string? SessionInitializationMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderCustomLearnedIpRanges
{
    /// <summary>The IP range to advertise. The value must be a CIDR-formatted string.</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderInterfaceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RouterInterface in compute to populate interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderInterfaceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecForProviderInterfaceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderInterfaceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RouterInterface in compute to populate interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderInterfaceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecForProviderInterfaceSelectorPolicy? Policy { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderMd5AuthenticationKeyKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderMd5AuthenticationKey
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta1RouterPeerSpecForProviderMd5AuthenticationKeyKeySecretRef KeySecretRef { get; set; }

    /// <summary>Name of this BGP peer. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])? which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderPeerIpAddressRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Address in compute to populate peerIpAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderPeerIpAddressRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecForProviderPeerIpAddressRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderPeerIpAddressSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Address in compute to populate peerIpAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderPeerIpAddressSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecForProviderPeerIpAddressSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderRegionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Router in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderRegionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecForProviderRegionRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderRegionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Router in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderRegionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecForProviderRegionSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderRouterApplianceInstanceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Instance in compute to populate routerApplianceInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderRouterApplianceInstanceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecForProviderRouterApplianceInstanceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderRouterApplianceInstanceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Instance in compute to populate routerApplianceInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderRouterApplianceInstanceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecForProviderRouterApplianceInstanceSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderRouterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Router in compute to populate router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderRouterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecForProviderRouterRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderRouterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Router in compute to populate router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProviderRouterSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecForProviderRouterSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecForProvider
{
    /// <summary>User-specified flag to indicate which mode to use for advertisement. Valid values of this enum field are: DEFAULT, CUSTOM Default value is DEFAULT. Possible values are: DEFAULT, CUSTOM.</summary>
    [JsonPropertyName("advertiseMode")]
    public string? AdvertiseMode { get; set; }

    /// <summary>User-specified list of prefix groups to advertise in custom mode, which currently supports the following option:</summary>
    [JsonPropertyName("advertisedGroups")]
    public IList<string>? AdvertisedGroups { get; set; }

    /// <summary>User-specified list of individual IP ranges to advertise in custom mode. This field can only be populated if advertiseMode is CUSTOM and is advertised to all peers of the router. These IP ranges will be advertised in addition to any specified groups. Leave this field blank to advertise no custom IP ranges. Structure is documented below.</summary>
    [JsonPropertyName("advertisedIpRanges")]
    public IList<V1beta1RouterPeerSpecForProviderAdvertisedIpRanges>? AdvertisedIpRanges { get; set; }

    /// <summary>The priority of routes advertised to this BGP peer. Where there is more than one matching route of maximum length, the routes with the lowest priority value win.</summary>
    [JsonPropertyName("advertisedRoutePriority")]
    public double? AdvertisedRoutePriority { get; set; }

    /// <summary>BFD configuration for the BGP peering. Structure is documented below.</summary>
    [JsonPropertyName("bfd")]
    public IList<V1beta1RouterPeerSpecForProviderBfd>? Bfd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customLearnedIpRanges")]
    public IList<V1beta1RouterPeerSpecForProviderCustomLearnedIpRanges>? CustomLearnedIpRanges { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customLearnedRoutePriority")]
    public double? CustomLearnedRoutePriority { get; set; }

    /// <summary>The status of the BGP peer connection. If set to false, any active session with the peer is terminated and all associated routing information is removed. If set to true, the peer connection can be established with routing information. The default is true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Enable IPv4 traffic over BGP Peer. It is enabled by default if the peerIpAddress is version 4.</summary>
    [JsonPropertyName("enableIpv4")]
    public bool? EnableIpv4 { get; set; }

    /// <summary>Enable IPv6 traffic over BGP Peer. If not specified, it is disabled by default.</summary>
    [JsonPropertyName("enableIpv6")]
    public bool? EnableIpv6 { get; set; }

    /// <summary>routers.list of export policies applied to this peer, in the order they must be evaluated. The name must correspond to an existing policy that has ROUTE_POLICY_TYPE_EXPORT type.</summary>
    [JsonPropertyName("exportPolicies")]
    public IList<string>? ExportPolicies { get; set; }

    /// <summary>routers.list of import policies applied to this peer, in the order they must be evaluated. The name must correspond to an existing policy that has ROUTE_POLICY_TYPE_IMPORT type.</summary>
    [JsonPropertyName("importPolicies")]
    public IList<string>? ImportPolicies { get; set; }

    /// <summary>Name of the interface the BGP peer is associated with.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>Reference to a RouterInterface in compute to populate interface.</summary>
    [JsonPropertyName("interfaceRef")]
    public V1beta1RouterPeerSpecForProviderInterfaceRef? InterfaceRef { get; set; }

    /// <summary>Selector for a RouterInterface in compute to populate interface.</summary>
    [JsonPropertyName("interfaceSelector")]
    public V1beta1RouterPeerSpecForProviderInterfaceSelector? InterfaceSelector { get; set; }

    /// <summary>IP address of the interface inside Google Cloud Platform. Only IPv4 is supported.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>IPv4 address of the interface inside Google Cloud Platform.</summary>
    [JsonPropertyName("ipv4NexthopAddress")]
    public string? Ipv4NexthopAddress { get; set; }

    /// <summary>IPv6 address of the interface inside Google Cloud Platform. The address must be in the range 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64. If you do not specify the next hop addresses, Google Cloud automatically assigns unused addresses from the 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64 range for you.</summary>
    [JsonPropertyName("ipv6NexthopAddress")]
    public string? Ipv6NexthopAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("md5AuthenticationKey")]
    public IList<V1beta1RouterPeerSpecForProviderMd5AuthenticationKey>? Md5AuthenticationKey { get; set; }

    /// <summary>Peer BGP Autonomous System Number (ASN). Each BGP interface may use a different value.</summary>
    [JsonPropertyName("peerAsn")]
    public double? PeerAsn { get; set; }

    /// <summary>IP address of the BGP interface outside Google Cloud Platform. Only IPv4 is supported. Required if ip_address is set.</summary>
    [JsonPropertyName("peerIpAddress")]
    public string? PeerIpAddress { get; set; }

    /// <summary>Reference to a Address in compute to populate peerIpAddress.</summary>
    [JsonPropertyName("peerIpAddressRef")]
    public V1beta1RouterPeerSpecForProviderPeerIpAddressRef? PeerIpAddressRef { get; set; }

    /// <summary>Selector for a Address in compute to populate peerIpAddress.</summary>
    [JsonPropertyName("peerIpAddressSelector")]
    public V1beta1RouterPeerSpecForProviderPeerIpAddressSelector? PeerIpAddressSelector { get; set; }

    /// <summary>IPv4 address of the BGP interface outside Google Cloud Platform.</summary>
    [JsonPropertyName("peerIpv4NexthopAddress")]
    public string? PeerIpv4NexthopAddress { get; set; }

    /// <summary>IPv6 address of the BGP interface outside Google Cloud Platform. The address must be in the range 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64. If you do not specify the next hop addresses, Google Cloud automatically assigns unused addresses from the 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64 range for you.</summary>
    [JsonPropertyName("peerIpv6NexthopAddress")]
    public string? PeerIpv6NexthopAddress { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where the router and BgpPeer reside. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Reference to a Router in compute to populate region.</summary>
    [JsonPropertyName("regionRef")]
    public V1beta1RouterPeerSpecForProviderRegionRef? RegionRef { get; set; }

    /// <summary>Selector for a Router in compute to populate region.</summary>
    [JsonPropertyName("regionSelector")]
    public V1beta1RouterPeerSpecForProviderRegionSelector? RegionSelector { get; set; }

    /// <summary>The name of the Cloud Router in which this BgpPeer will be configured.</summary>
    [JsonPropertyName("router")]
    public string? Router { get; set; }

    /// <summary>The URI of the VM instance that is used as third-party router appliances such as Next Gen Firewalls, Virtual Routers, or Router Appliances. The VM instance must be located in zones contained in the same region as this Cloud Router. The VM instance is the peer side of the BGP session.</summary>
    [JsonPropertyName("routerApplianceInstance")]
    public string? RouterApplianceInstance { get; set; }

    /// <summary>Reference to a Instance in compute to populate routerApplianceInstance.</summary>
    [JsonPropertyName("routerApplianceInstanceRef")]
    public V1beta1RouterPeerSpecForProviderRouterApplianceInstanceRef? RouterApplianceInstanceRef { get; set; }

    /// <summary>Selector for a Instance in compute to populate routerApplianceInstance.</summary>
    [JsonPropertyName("routerApplianceInstanceSelector")]
    public V1beta1RouterPeerSpecForProviderRouterApplianceInstanceSelector? RouterApplianceInstanceSelector { get; set; }

    /// <summary>Reference to a Router in compute to populate router.</summary>
    [JsonPropertyName("routerRef")]
    public V1beta1RouterPeerSpecForProviderRouterRef? RouterRef { get; set; }

    /// <summary>Selector for a Router in compute to populate router.</summary>
    [JsonPropertyName("routerSelector")]
    public V1beta1RouterPeerSpecForProviderRouterSelector? RouterSelector { get; set; }

    /// <summary>The user-defined zero-advertised-route-priority for a advertised-route-priority in BGP session. This value has to be set true to force the advertised_route_priority to be 0.</summary>
    [JsonPropertyName("zeroAdvertisedRoutePriority")]
    public bool? ZeroAdvertisedRoutePriority { get; set; }

    /// <summary>The user-defined zero-custom-learned-route-priority for a custom-learned-route-priority in BGP session. This value has to be set true to force the custom_learned_route_priority to be 0.</summary>
    [JsonPropertyName("zeroCustomLearnedRoutePriority")]
    public bool? ZeroCustomLearnedRoutePriority { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderAdvertisedIpRanges
{
    /// <summary>User-specified description for the IP range.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The IP range to advertise. The value must be a CIDR-formatted string.</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderBfd
{
    /// <summary>The minimum interval, in milliseconds, between BFD control packets received from the peer router. The actual value is negotiated between the two routers and is equal to the greater of this value and the transmit interval of the other router. If set, this value must be between 1000 and 30000.</summary>
    [JsonPropertyName("minReceiveInterval")]
    public double? MinReceiveInterval { get; set; }

    /// <summary>The minimum interval, in milliseconds, between BFD control packets transmitted to the peer router. The actual value is negotiated between the two routers and is equal to the greater of this value and the corresponding receive interval of the other router. If set, this value must be between 1000 and 30000.</summary>
    [JsonPropertyName("minTransmitInterval")]
    public double? MinTransmitInterval { get; set; }

    /// <summary>The number of consecutive BFD packets that must be missed before BFD declares that a peer is unavailable. If set, the value must be a value between 5 and 16.</summary>
    [JsonPropertyName("multiplier")]
    public double? Multiplier { get; set; }

    /// <summary>The BFD session initialization mode for this BGP peer. If set to ACTIVE, the Cloud Router will initiate the BFD session for this BGP peer. If set to PASSIVE, the Cloud Router will wait for the peer router to initiate the BFD session for this BGP peer. If set to DISABLED, BFD is disabled for this BGP peer. Possible values are: ACTIVE, DISABLED, PASSIVE.</summary>
    [JsonPropertyName("sessionInitializationMode")]
    public string? SessionInitializationMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderCustomLearnedIpRanges
{
    /// <summary>The IP range to advertise. The value must be a CIDR-formatted string.</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderInterfaceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a RouterInterface in compute to populate interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderInterfaceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecInitProviderInterfaceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderInterfaceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a RouterInterface in compute to populate interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderInterfaceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecInitProviderInterfaceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderMd5AuthenticationKey
{
    /// <summary>Name of this BGP peer. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])? which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderPeerIpAddressRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Address in compute to populate peerIpAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderPeerIpAddressRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecInitProviderPeerIpAddressRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderPeerIpAddressSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Address in compute to populate peerIpAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderPeerIpAddressSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecInitProviderPeerIpAddressSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderRegionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Router in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderRegionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecInitProviderRegionRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderRegionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Router in compute to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderRegionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecInitProviderRegionSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderRouterApplianceInstanceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Instance in compute to populate routerApplianceInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderRouterApplianceInstanceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecInitProviderRouterApplianceInstanceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderRouterApplianceInstanceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Instance in compute to populate routerApplianceInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProviderRouterApplianceInstanceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecInitProviderRouterApplianceInstanceSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecInitProvider
{
    /// <summary>User-specified flag to indicate which mode to use for advertisement. Valid values of this enum field are: DEFAULT, CUSTOM Default value is DEFAULT. Possible values are: DEFAULT, CUSTOM.</summary>
    [JsonPropertyName("advertiseMode")]
    public string? AdvertiseMode { get; set; }

    /// <summary>User-specified list of prefix groups to advertise in custom mode, which currently supports the following option:</summary>
    [JsonPropertyName("advertisedGroups")]
    public IList<string>? AdvertisedGroups { get; set; }

    /// <summary>User-specified list of individual IP ranges to advertise in custom mode. This field can only be populated if advertiseMode is CUSTOM and is advertised to all peers of the router. These IP ranges will be advertised in addition to any specified groups. Leave this field blank to advertise no custom IP ranges. Structure is documented below.</summary>
    [JsonPropertyName("advertisedIpRanges")]
    public IList<V1beta1RouterPeerSpecInitProviderAdvertisedIpRanges>? AdvertisedIpRanges { get; set; }

    /// <summary>The priority of routes advertised to this BGP peer. Where there is more than one matching route of maximum length, the routes with the lowest priority value win.</summary>
    [JsonPropertyName("advertisedRoutePriority")]
    public double? AdvertisedRoutePriority { get; set; }

    /// <summary>BFD configuration for the BGP peering. Structure is documented below.</summary>
    [JsonPropertyName("bfd")]
    public IList<V1beta1RouterPeerSpecInitProviderBfd>? Bfd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customLearnedIpRanges")]
    public IList<V1beta1RouterPeerSpecInitProviderCustomLearnedIpRanges>? CustomLearnedIpRanges { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customLearnedRoutePriority")]
    public double? CustomLearnedRoutePriority { get; set; }

    /// <summary>The status of the BGP peer connection. If set to false, any active session with the peer is terminated and all associated routing information is removed. If set to true, the peer connection can be established with routing information. The default is true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Enable IPv4 traffic over BGP Peer. It is enabled by default if the peerIpAddress is version 4.</summary>
    [JsonPropertyName("enableIpv4")]
    public bool? EnableIpv4 { get; set; }

    /// <summary>Enable IPv6 traffic over BGP Peer. If not specified, it is disabled by default.</summary>
    [JsonPropertyName("enableIpv6")]
    public bool? EnableIpv6 { get; set; }

    /// <summary>routers.list of export policies applied to this peer, in the order they must be evaluated. The name must correspond to an existing policy that has ROUTE_POLICY_TYPE_EXPORT type.</summary>
    [JsonPropertyName("exportPolicies")]
    public IList<string>? ExportPolicies { get; set; }

    /// <summary>routers.list of import policies applied to this peer, in the order they must be evaluated. The name must correspond to an existing policy that has ROUTE_POLICY_TYPE_IMPORT type.</summary>
    [JsonPropertyName("importPolicies")]
    public IList<string>? ImportPolicies { get; set; }

    /// <summary>Name of the interface the BGP peer is associated with.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>Reference to a RouterInterface in compute to populate interface.</summary>
    [JsonPropertyName("interfaceRef")]
    public V1beta1RouterPeerSpecInitProviderInterfaceRef? InterfaceRef { get; set; }

    /// <summary>Selector for a RouterInterface in compute to populate interface.</summary>
    [JsonPropertyName("interfaceSelector")]
    public V1beta1RouterPeerSpecInitProviderInterfaceSelector? InterfaceSelector { get; set; }

    /// <summary>IP address of the interface inside Google Cloud Platform. Only IPv4 is supported.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>IPv4 address of the interface inside Google Cloud Platform.</summary>
    [JsonPropertyName("ipv4NexthopAddress")]
    public string? Ipv4NexthopAddress { get; set; }

    /// <summary>IPv6 address of the interface inside Google Cloud Platform. The address must be in the range 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64. If you do not specify the next hop addresses, Google Cloud automatically assigns unused addresses from the 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64 range for you.</summary>
    [JsonPropertyName("ipv6NexthopAddress")]
    public string? Ipv6NexthopAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("md5AuthenticationKey")]
    public IList<V1beta1RouterPeerSpecInitProviderMd5AuthenticationKey>? Md5AuthenticationKey { get; set; }

    /// <summary>Peer BGP Autonomous System Number (ASN). Each BGP interface may use a different value.</summary>
    [JsonPropertyName("peerAsn")]
    public double? PeerAsn { get; set; }

    /// <summary>IP address of the BGP interface outside Google Cloud Platform. Only IPv4 is supported. Required if ip_address is set.</summary>
    [JsonPropertyName("peerIpAddress")]
    public string? PeerIpAddress { get; set; }

    /// <summary>Reference to a Address in compute to populate peerIpAddress.</summary>
    [JsonPropertyName("peerIpAddressRef")]
    public V1beta1RouterPeerSpecInitProviderPeerIpAddressRef? PeerIpAddressRef { get; set; }

    /// <summary>Selector for a Address in compute to populate peerIpAddress.</summary>
    [JsonPropertyName("peerIpAddressSelector")]
    public V1beta1RouterPeerSpecInitProviderPeerIpAddressSelector? PeerIpAddressSelector { get; set; }

    /// <summary>IPv4 address of the BGP interface outside Google Cloud Platform.</summary>
    [JsonPropertyName("peerIpv4NexthopAddress")]
    public string? PeerIpv4NexthopAddress { get; set; }

    /// <summary>IPv6 address of the BGP interface outside Google Cloud Platform. The address must be in the range 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64. If you do not specify the next hop addresses, Google Cloud automatically assigns unused addresses from the 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64 range for you.</summary>
    [JsonPropertyName("peerIpv6NexthopAddress")]
    public string? PeerIpv6NexthopAddress { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where the router and BgpPeer reside. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Reference to a Router in compute to populate region.</summary>
    [JsonPropertyName("regionRef")]
    public V1beta1RouterPeerSpecInitProviderRegionRef? RegionRef { get; set; }

    /// <summary>Selector for a Router in compute to populate region.</summary>
    [JsonPropertyName("regionSelector")]
    public V1beta1RouterPeerSpecInitProviderRegionSelector? RegionSelector { get; set; }

    /// <summary>The URI of the VM instance that is used as third-party router appliances such as Next Gen Firewalls, Virtual Routers, or Router Appliances. The VM instance must be located in zones contained in the same region as this Cloud Router. The VM instance is the peer side of the BGP session.</summary>
    [JsonPropertyName("routerApplianceInstance")]
    public string? RouterApplianceInstance { get; set; }

    /// <summary>Reference to a Instance in compute to populate routerApplianceInstance.</summary>
    [JsonPropertyName("routerApplianceInstanceRef")]
    public V1beta1RouterPeerSpecInitProviderRouterApplianceInstanceRef? RouterApplianceInstanceRef { get; set; }

    /// <summary>Selector for a Instance in compute to populate routerApplianceInstance.</summary>
    [JsonPropertyName("routerApplianceInstanceSelector")]
    public V1beta1RouterPeerSpecInitProviderRouterApplianceInstanceSelector? RouterApplianceInstanceSelector { get; set; }

    /// <summary>The user-defined zero-advertised-route-priority for a advertised-route-priority in BGP session. This value has to be set true to force the advertised_route_priority to be 0.</summary>
    [JsonPropertyName("zeroAdvertisedRoutePriority")]
    public bool? ZeroAdvertisedRoutePriority { get; set; }

    /// <summary>The user-defined zero-custom-learned-route-priority for a custom-learned-route-priority in BGP session. This value has to be set true to force the custom_learned_route_priority to be 0.</summary>
    [JsonPropertyName("zeroCustomLearnedRoutePriority")]
    public bool? ZeroCustomLearnedRoutePriority { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouterPeerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>RouterPeerSpec defines the desired state of RouterPeer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RouterPeerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RouterPeerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RouterPeerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RouterPeerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerStatusAtProviderAdvertisedIpRanges
{
    /// <summary>User-specified description for the IP range.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The IP range to advertise. The value must be a CIDR-formatted string.</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerStatusAtProviderBfd
{
    /// <summary>The minimum interval, in milliseconds, between BFD control packets received from the peer router. The actual value is negotiated between the two routers and is equal to the greater of this value and the transmit interval of the other router. If set, this value must be between 1000 and 30000.</summary>
    [JsonPropertyName("minReceiveInterval")]
    public double? MinReceiveInterval { get; set; }

    /// <summary>The minimum interval, in milliseconds, between BFD control packets transmitted to the peer router. The actual value is negotiated between the two routers and is equal to the greater of this value and the corresponding receive interval of the other router. If set, this value must be between 1000 and 30000.</summary>
    [JsonPropertyName("minTransmitInterval")]
    public double? MinTransmitInterval { get; set; }

    /// <summary>The number of consecutive BFD packets that must be missed before BFD declares that a peer is unavailable. If set, the value must be a value between 5 and 16.</summary>
    [JsonPropertyName("multiplier")]
    public double? Multiplier { get; set; }

    /// <summary>The BFD session initialization mode for this BGP peer. If set to ACTIVE, the Cloud Router will initiate the BFD session for this BGP peer. If set to PASSIVE, the Cloud Router will wait for the peer router to initiate the BFD session for this BGP peer. If set to DISABLED, BFD is disabled for this BGP peer. Possible values are: ACTIVE, DISABLED, PASSIVE.</summary>
    [JsonPropertyName("sessionInitializationMode")]
    public string? SessionInitializationMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerStatusAtProviderCustomLearnedIpRanges
{
    /// <summary>The IP range to advertise. The value must be a CIDR-formatted string.</summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerStatusAtProviderMd5AuthenticationKey
{
    /// <summary>Name of this BGP peer. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])? which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerStatusAtProvider
{
    /// <summary>User-specified flag to indicate which mode to use for advertisement. Valid values of this enum field are: DEFAULT, CUSTOM Default value is DEFAULT. Possible values are: DEFAULT, CUSTOM.</summary>
    [JsonPropertyName("advertiseMode")]
    public string? AdvertiseMode { get; set; }

    /// <summary>User-specified list of prefix groups to advertise in custom mode, which currently supports the following option:</summary>
    [JsonPropertyName("advertisedGroups")]
    public IList<string>? AdvertisedGroups { get; set; }

    /// <summary>User-specified list of individual IP ranges to advertise in custom mode. This field can only be populated if advertiseMode is CUSTOM and is advertised to all peers of the router. These IP ranges will be advertised in addition to any specified groups. Leave this field blank to advertise no custom IP ranges. Structure is documented below.</summary>
    [JsonPropertyName("advertisedIpRanges")]
    public IList<V1beta1RouterPeerStatusAtProviderAdvertisedIpRanges>? AdvertisedIpRanges { get; set; }

    /// <summary>The priority of routes advertised to this BGP peer. Where there is more than one matching route of maximum length, the routes with the lowest priority value win.</summary>
    [JsonPropertyName("advertisedRoutePriority")]
    public double? AdvertisedRoutePriority { get; set; }

    /// <summary>BFD configuration for the BGP peering. Structure is documented below.</summary>
    [JsonPropertyName("bfd")]
    public IList<V1beta1RouterPeerStatusAtProviderBfd>? Bfd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customLearnedIpRanges")]
    public IList<V1beta1RouterPeerStatusAtProviderCustomLearnedIpRanges>? CustomLearnedIpRanges { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customLearnedRoutePriority")]
    public double? CustomLearnedRoutePriority { get; set; }

    /// <summary>The status of the BGP peer connection. If set to false, any active session with the peer is terminated and all associated routing information is removed. If set to true, the peer connection can be established with routing information. The default is true.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Enable IPv4 traffic over BGP Peer. It is enabled by default if the peerIpAddress is version 4.</summary>
    [JsonPropertyName("enableIpv4")]
    public bool? EnableIpv4 { get; set; }

    /// <summary>Enable IPv6 traffic over BGP Peer. If not specified, it is disabled by default.</summary>
    [JsonPropertyName("enableIpv6")]
    public bool? EnableIpv6 { get; set; }

    /// <summary>routers.list of export policies applied to this peer, in the order they must be evaluated. The name must correspond to an existing policy that has ROUTE_POLICY_TYPE_EXPORT type.</summary>
    [JsonPropertyName("exportPolicies")]
    public IList<string>? ExportPolicies { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/routers/{{router}}/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>routers.list of import policies applied to this peer, in the order they must be evaluated. The name must correspond to an existing policy that has ROUTE_POLICY_TYPE_IMPORT type.</summary>
    [JsonPropertyName("importPolicies")]
    public IList<string>? ImportPolicies { get; set; }

    /// <summary>Name of the interface the BGP peer is associated with.</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>IP address of the interface inside Google Cloud Platform. Only IPv4 is supported.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>IPv4 address of the interface inside Google Cloud Platform.</summary>
    [JsonPropertyName("ipv4NexthopAddress")]
    public string? Ipv4NexthopAddress { get; set; }

    /// <summary>IPv6 address of the interface inside Google Cloud Platform. The address must be in the range 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64. If you do not specify the next hop addresses, Google Cloud automatically assigns unused addresses from the 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64 range for you.</summary>
    [JsonPropertyName("ipv6NexthopAddress")]
    public string? Ipv6NexthopAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAdvertisedRoutePrioritySet")]
    public bool? IsAdvertisedRoutePrioritySet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isCustomLearnedPrioritySet")]
    public bool? IsCustomLearnedPrioritySet { get; set; }

    /// <summary>The resource that configures and manages this BGP peer.</summary>
    [JsonPropertyName("managementType")]
    public string? ManagementType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("md5AuthenticationKey")]
    public IList<V1beta1RouterPeerStatusAtProviderMd5AuthenticationKey>? Md5AuthenticationKey { get; set; }

    /// <summary>Peer BGP Autonomous System Number (ASN). Each BGP interface may use a different value.</summary>
    [JsonPropertyName("peerAsn")]
    public double? PeerAsn { get; set; }

    /// <summary>IP address of the BGP interface outside Google Cloud Platform. Only IPv4 is supported. Required if ip_address is set.</summary>
    [JsonPropertyName("peerIpAddress")]
    public string? PeerIpAddress { get; set; }

    /// <summary>IPv4 address of the BGP interface outside Google Cloud Platform.</summary>
    [JsonPropertyName("peerIpv4NexthopAddress")]
    public string? PeerIpv4NexthopAddress { get; set; }

    /// <summary>IPv6 address of the BGP interface outside Google Cloud Platform. The address must be in the range 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64. If you do not specify the next hop addresses, Google Cloud automatically assigns unused addresses from the 2600:2d00:0:2::/64 or 2600:2d00:0:3::/64 range for you.</summary>
    [JsonPropertyName("peerIpv6NexthopAddress")]
    public string? PeerIpv6NexthopAddress { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where the router and BgpPeer reside. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The name of the Cloud Router in which this BgpPeer will be configured.</summary>
    [JsonPropertyName("router")]
    public string? Router { get; set; }

    /// <summary>The URI of the VM instance that is used as third-party router appliances such as Next Gen Firewalls, Virtual Routers, or Router Appliances. The VM instance must be located in zones contained in the same region as this Cloud Router. The VM instance is the peer side of the BGP session.</summary>
    [JsonPropertyName("routerApplianceInstance")]
    public string? RouterApplianceInstance { get; set; }

    /// <summary>The user-defined zero-advertised-route-priority for a advertised-route-priority in BGP session. This value has to be set true to force the advertised_route_priority to be 0.</summary>
    [JsonPropertyName("zeroAdvertisedRoutePriority")]
    public bool? ZeroAdvertisedRoutePriority { get; set; }

    /// <summary>The user-defined zero-custom-learned-route-priority for a custom-learned-route-priority in BGP session. This value has to be set true to force the custom_learned_route_priority to be 0.</summary>
    [JsonPropertyName("zeroCustomLearnedRoutePriority")]
    public bool? ZeroCustomLearnedRoutePriority { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>RouterPeerStatus defines the observed state of RouterPeer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouterPeerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RouterPeerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RouterPeerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RouterPeer is the Schema for the RouterPeers API. BGP information that must be configured into the routing stack to establish BGP peering.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RouterPeer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RouterPeerSpec>, IStatus<V1beta1RouterPeerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RouterPeer";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "routerpeers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RouterPeerSpec defines the desired state of RouterPeer</summary>
    [JsonPropertyName("spec")]
    public V1beta1RouterPeerSpec Spec { get; set; }

    /// <summary>RouterPeerStatus defines the observed state of RouterPeer.</summary>
    [JsonPropertyName("status")]
    public V1beta1RouterPeerStatus? Status { get; set; }
}