using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
public enum V1beta1VPNGatewayConnectionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdRefPolicyResolutionEnum>))]
    public V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdRefPolicyResolveEnum>))]
    public V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdSelectorPolicyResolutionEnum>))]
    public V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdSelectorPolicyResolveEnum>))]
    public V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecForProviderRoutingPropagatedRouteTable
{
    /// <summary>A list of labels to assign to this route table.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>A list of Route Table IDs to associated with this VPN Gateway Connection.</summary>
    [JsonPropertyName("routeTableIds")]
    public IList<string>? RouteTableIds { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecForProviderRouting
{
    /// <summary>The ID of the Route Table associated with this VPN Connection.</summary>
    [JsonPropertyName("associatedRouteTable")]
    public string? AssociatedRouteTable { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for inbound learned routes.</summary>
    [JsonPropertyName("inboundRouteMapId")]
    public string? InboundRouteMapId { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for outbound advertised routes.</summary>
    [JsonPropertyName("outboundRouteMapId")]
    public string? OutboundRouteMapId { get; set; }

    /// <summary>A propagated_route_table block as defined below.</summary>
    [JsonPropertyName("propagatedRouteTable")]
    public IList<V1beta1VPNGatewayConnectionSpecForProviderRoutingPropagatedRouteTable>? PropagatedRouteTable { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecForProviderTrafficSelectorPolicy
{
    /// <summary>A list of local address spaces in CIDR format for this VPN Gateway Connection.</summary>
    [JsonPropertyName("localAddressRanges")]
    public IList<string>? LocalAddressRanges { get; set; }

    /// <summary>A list of remote address spaces in CIDR format for this VPN Gateway Connection.</summary>
    [JsonPropertyName("remoteAddressRanges")]
    public IList<string>? RemoteAddressRanges { get; set; }
}

public enum V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdRefPolicyResolutionEnum>))]
    public V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdRefPolicyResolveEnum>))]
    public V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdSelectorPolicyResolutionEnum>))]
    public V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdSelectorPolicyResolveEnum>))]
    public V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecForProviderVpnLinkCustomBgpAddress
{
    /// <summary>The custom bgp ip address which belongs to the IP Configuration.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The ID of the IP Configuration which belongs to the VPN Gateway.</summary>
    [JsonPropertyName("ipConfigurationId")]
    public string? IpConfigurationId { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecForProviderVpnLinkIpsecPolicy
{
    /// <summary>The DH Group used in IKE Phase 1 for initial SA. Possible values are None, DHGroup1, DHGroup2, DHGroup14, DHGroup24, DHGroup2048, ECP256, ECP384.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IPSec encryption algorithm (IKE phase 1). Possible values are AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256, None.</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary>The IKE encryption algorithm (IKE phase 2). Possible values are DES, DES3, AES128, AES192, AES256, GCMAES128, GCMAES256.</summary>
    [JsonPropertyName("ikeEncryptionAlgorithm")]
    public string? IkeEncryptionAlgorithm { get; set; }

    /// <summary>The IKE integrity algorithm (IKE phase 2). Possible values are MD5, SHA1, SHA256, SHA384, GCMAES128, GCMAES256.</summary>
    [JsonPropertyName("ikeIntegrityAlgorithm")]
    public string? IkeIntegrityAlgorithm { get; set; }

    /// <summary>The IPSec integrity algorithm (IKE phase 1). Possible values are MD5, SHA1, SHA256, GCMAES128, GCMAES192, GCMAES256.</summary>
    [JsonPropertyName("integrityAlgorithm")]
    public string? IntegrityAlgorithm { get; set; }

    /// <summary>The Pfs Group used in IKE Phase 2 for the new child SA. Possible values are None, PFS1, PFS2, PFS14, PFS24, PFS2048, PFSMM, ECP256, ECP384.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for the site to site VPN tunnel.</summary>
    [JsonPropertyName("saDataSizeKb")]
    public double? SaDataSizeKb { get; set; }

    /// <summary>The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for the site to site VPN tunnel.</summary>
    [JsonPropertyName("saLifetimeSec")]
    public double? SaLifetimeSec { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecForProviderVpnLink
{
    /// <summary>The expected connection bandwidth in MBPS. Defaults to 10.</summary>
    [JsonPropertyName("bandwidthMbps")]
    public double? BandwidthMbps { get; set; }

    /// <summary>Should the BGP be enabled? Defaults to false. Changing this forces a new VPN Gateway Connection to be created.</summary>
    [JsonPropertyName("bgpEnabled")]
    public bool? BgpEnabled { get; set; }

    /// <summary>The connection mode of this VPN Link. Possible values are Default, InitiatorOnly and ResponderOnly. Defaults to Default.</summary>
    [JsonPropertyName("connectionMode")]
    public string? ConnectionMode { get; set; }

    /// <summary>One or more custom_bgp_address blocks as defined below.</summary>
    [JsonPropertyName("customBgpAddress")]
    public IList<V1beta1VPNGatewayConnectionSpecForProviderVpnLinkCustomBgpAddress>? CustomBgpAddress { get; set; }

    /// <summary>A list of the egress NAT Rule Ids.</summary>
    [JsonPropertyName("egressNatRuleIds")]
    public IList<string>? EgressNatRuleIds { get; set; }

    /// <summary>A list of the ingress NAT Rule Ids.</summary>
    [JsonPropertyName("ingressNatRuleIds")]
    public IList<string>? IngressNatRuleIds { get; set; }

    /// <summary>One or more ipsec_policy blocks as defined above.</summary>
    [JsonPropertyName("ipsecPolicy")]
    public IList<V1beta1VPNGatewayConnectionSpecForProviderVpnLinkIpsecPolicy>? IpsecPolicy { get; set; }

    /// <summary>Whether to use local Azure IP to initiate connection? Defaults to false.</summary>
    [JsonPropertyName("localAzureIpAddressEnabled")]
    public bool? LocalAzureIpAddressEnabled { get; set; }

    /// <summary>The name which should be used for this VPN Link Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to enable policy-based traffic selectors? Defaults to false.</summary>
    [JsonPropertyName("policyBasedTrafficSelectorEnabled")]
    public bool? PolicyBasedTrafficSelectorEnabled { get; set; }

    /// <summary>The protocol used for this VPN Link Connection. Possible values are IKEv1 and IKEv2. Defaults to IKEv2.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Should the rate limit be enabled? Defaults to false.</summary>
    [JsonPropertyName("ratelimitEnabled")]
    public bool? RatelimitEnabled { get; set; }

    /// <summary>Routing weight for this VPN Link Connection. Defaults to 0.</summary>
    [JsonPropertyName("routeWeight")]
    public double? RouteWeight { get; set; }

    /// <summary>SharedKey for this VPN Link Connection.</summary>
    [JsonPropertyName("sharedKey")]
    public string? SharedKey { get; set; }

    /// <summary>The ID of the connected VPN Site Link. Changing this forces a new VPN Gateway Connection to be created.</summary>
    [JsonPropertyName("vpnSiteLinkId")]
    public string? VpnSiteLinkId { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecForProvider
{
    /// <summary>Whether Internet Security is enabled for this VPN Connection. Defaults to false.</summary>
    [JsonPropertyName("internetSecurityEnabled")]
    public bool? InternetSecurityEnabled { get; set; }

    /// <summary>The ID of the remote VPN Site, which will connect to the VPN Gateway. Changing this forces a new VPN Gateway Connection to be created.</summary>
    [JsonPropertyName("remoteVpnSiteId")]
    public string? RemoteVpnSiteId { get; set; }

    /// <summary>Reference to a VPNSite in network to populate remoteVpnSiteId.</summary>
    [JsonPropertyName("remoteVpnSiteIdRef")]
    public V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdRef? RemoteVpnSiteIdRef { get; set; }

    /// <summary>Selector for a VPNSite in network to populate remoteVpnSiteId.</summary>
    [JsonPropertyName("remoteVpnSiteIdSelector")]
    public V1beta1VPNGatewayConnectionSpecForProviderRemoteVpnSiteIdSelector? RemoteVpnSiteIdSelector { get; set; }

    /// <summary>A routing block as defined below. If this is not specified, there will be a default route table created implicitly.</summary>
    [JsonPropertyName("routing")]
    public IList<V1beta1VPNGatewayConnectionSpecForProviderRouting>? Routing { get; set; }

    /// <summary>One or more traffic_selector_policy blocks as defined below.</summary>
    [JsonPropertyName("trafficSelectorPolicy")]
    public IList<V1beta1VPNGatewayConnectionSpecForProviderTrafficSelectorPolicy>? TrafficSelectorPolicy { get; set; }

    /// <summary>The ID of the VPN Gateway that this VPN Gateway Connection belongs to. Changing this forces a new VPN Gateway Connection to be created.</summary>
    [JsonPropertyName("vpnGatewayId")]
    public string? VpnGatewayId { get; set; }

    /// <summary>Reference to a VPNGateway in network to populate vpnGatewayId.</summary>
    [JsonPropertyName("vpnGatewayIdRef")]
    public V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdRef? VpnGatewayIdRef { get; set; }

    /// <summary>Selector for a VPNGateway in network to populate vpnGatewayId.</summary>
    [JsonPropertyName("vpnGatewayIdSelector")]
    public V1beta1VPNGatewayConnectionSpecForProviderVpnGatewayIdSelector? VpnGatewayIdSelector { get; set; }

    /// <summary>One or more vpn_link blocks as defined below.</summary>
    [JsonPropertyName("vpnLink")]
    public IList<V1beta1VPNGatewayConnectionSpecForProviderVpnLink>? VpnLink { get; set; }
}

public enum V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdRefPolicyResolutionEnum>))]
    public V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdRefPolicyResolveEnum>))]
    public V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdSelectorPolicyResolutionEnum>))]
    public V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdSelectorPolicyResolveEnum>))]
    public V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecInitProviderRoutingPropagatedRouteTable
{
    /// <summary>A list of labels to assign to this route table.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>A list of Route Table IDs to associated with this VPN Gateway Connection.</summary>
    [JsonPropertyName("routeTableIds")]
    public IList<string>? RouteTableIds { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecInitProviderRouting
{
    /// <summary>The ID of the Route Table associated with this VPN Connection.</summary>
    [JsonPropertyName("associatedRouteTable")]
    public string? AssociatedRouteTable { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for inbound learned routes.</summary>
    [JsonPropertyName("inboundRouteMapId")]
    public string? InboundRouteMapId { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for outbound advertised routes.</summary>
    [JsonPropertyName("outboundRouteMapId")]
    public string? OutboundRouteMapId { get; set; }

    /// <summary>A propagated_route_table block as defined below.</summary>
    [JsonPropertyName("propagatedRouteTable")]
    public IList<V1beta1VPNGatewayConnectionSpecInitProviderRoutingPropagatedRouteTable>? PropagatedRouteTable { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecInitProviderTrafficSelectorPolicy
{
    /// <summary>A list of local address spaces in CIDR format for this VPN Gateway Connection.</summary>
    [JsonPropertyName("localAddressRanges")]
    public IList<string>? LocalAddressRanges { get; set; }

    /// <summary>A list of remote address spaces in CIDR format for this VPN Gateway Connection.</summary>
    [JsonPropertyName("remoteAddressRanges")]
    public IList<string>? RemoteAddressRanges { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecInitProviderVpnLinkCustomBgpAddress
{
    /// <summary>The custom bgp ip address which belongs to the IP Configuration.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The ID of the IP Configuration which belongs to the VPN Gateway.</summary>
    [JsonPropertyName("ipConfigurationId")]
    public string? IpConfigurationId { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecInitProviderVpnLinkIpsecPolicy
{
    /// <summary>The DH Group used in IKE Phase 1 for initial SA. Possible values are None, DHGroup1, DHGroup2, DHGroup14, DHGroup24, DHGroup2048, ECP256, ECP384.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IPSec encryption algorithm (IKE phase 1). Possible values are AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256, None.</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary>The IKE encryption algorithm (IKE phase 2). Possible values are DES, DES3, AES128, AES192, AES256, GCMAES128, GCMAES256.</summary>
    [JsonPropertyName("ikeEncryptionAlgorithm")]
    public string? IkeEncryptionAlgorithm { get; set; }

    /// <summary>The IKE integrity algorithm (IKE phase 2). Possible values are MD5, SHA1, SHA256, SHA384, GCMAES128, GCMAES256.</summary>
    [JsonPropertyName("ikeIntegrityAlgorithm")]
    public string? IkeIntegrityAlgorithm { get; set; }

    /// <summary>The IPSec integrity algorithm (IKE phase 1). Possible values are MD5, SHA1, SHA256, GCMAES128, GCMAES192, GCMAES256.</summary>
    [JsonPropertyName("integrityAlgorithm")]
    public string? IntegrityAlgorithm { get; set; }

    /// <summary>The Pfs Group used in IKE Phase 2 for the new child SA. Possible values are None, PFS1, PFS2, PFS14, PFS24, PFS2048, PFSMM, ECP256, ECP384.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for the site to site VPN tunnel.</summary>
    [JsonPropertyName("saDataSizeKb")]
    public double? SaDataSizeKb { get; set; }

    /// <summary>The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for the site to site VPN tunnel.</summary>
    [JsonPropertyName("saLifetimeSec")]
    public double? SaLifetimeSec { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecInitProviderVpnLink
{
    /// <summary>The expected connection bandwidth in MBPS. Defaults to 10.</summary>
    [JsonPropertyName("bandwidthMbps")]
    public double? BandwidthMbps { get; set; }

    /// <summary>Should the BGP be enabled? Defaults to false. Changing this forces a new VPN Gateway Connection to be created.</summary>
    [JsonPropertyName("bgpEnabled")]
    public bool? BgpEnabled { get; set; }

    /// <summary>The connection mode of this VPN Link. Possible values are Default, InitiatorOnly and ResponderOnly. Defaults to Default.</summary>
    [JsonPropertyName("connectionMode")]
    public string? ConnectionMode { get; set; }

    /// <summary>One or more custom_bgp_address blocks as defined below.</summary>
    [JsonPropertyName("customBgpAddress")]
    public IList<V1beta1VPNGatewayConnectionSpecInitProviderVpnLinkCustomBgpAddress>? CustomBgpAddress { get; set; }

    /// <summary>A list of the egress NAT Rule Ids.</summary>
    [JsonPropertyName("egressNatRuleIds")]
    public IList<string>? EgressNatRuleIds { get; set; }

    /// <summary>A list of the ingress NAT Rule Ids.</summary>
    [JsonPropertyName("ingressNatRuleIds")]
    public IList<string>? IngressNatRuleIds { get; set; }

    /// <summary>One or more ipsec_policy blocks as defined above.</summary>
    [JsonPropertyName("ipsecPolicy")]
    public IList<V1beta1VPNGatewayConnectionSpecInitProviderVpnLinkIpsecPolicy>? IpsecPolicy { get; set; }

    /// <summary>Whether to use local Azure IP to initiate connection? Defaults to false.</summary>
    [JsonPropertyName("localAzureIpAddressEnabled")]
    public bool? LocalAzureIpAddressEnabled { get; set; }

    /// <summary>The name which should be used for this VPN Link Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to enable policy-based traffic selectors? Defaults to false.</summary>
    [JsonPropertyName("policyBasedTrafficSelectorEnabled")]
    public bool? PolicyBasedTrafficSelectorEnabled { get; set; }

    /// <summary>The protocol used for this VPN Link Connection. Possible values are IKEv1 and IKEv2. Defaults to IKEv2.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Should the rate limit be enabled? Defaults to false.</summary>
    [JsonPropertyName("ratelimitEnabled")]
    public bool? RatelimitEnabled { get; set; }

    /// <summary>Routing weight for this VPN Link Connection. Defaults to 0.</summary>
    [JsonPropertyName("routeWeight")]
    public double? RouteWeight { get; set; }

    /// <summary>SharedKey for this VPN Link Connection.</summary>
    [JsonPropertyName("sharedKey")]
    public string? SharedKey { get; set; }

    /// <summary>The ID of the connected VPN Site Link. Changing this forces a new VPN Gateway Connection to be created.</summary>
    [JsonPropertyName("vpnSiteLinkId")]
    public string? VpnSiteLinkId { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecInitProvider
{
    /// <summary>Whether Internet Security is enabled for this VPN Connection. Defaults to false.</summary>
    [JsonPropertyName("internetSecurityEnabled")]
    public bool? InternetSecurityEnabled { get; set; }

    /// <summary>The ID of the remote VPN Site, which will connect to the VPN Gateway. Changing this forces a new VPN Gateway Connection to be created.</summary>
    [JsonPropertyName("remoteVpnSiteId")]
    public string? RemoteVpnSiteId { get; set; }

    /// <summary>Reference to a VPNSite in network to populate remoteVpnSiteId.</summary>
    [JsonPropertyName("remoteVpnSiteIdRef")]
    public V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdRef? RemoteVpnSiteIdRef { get; set; }

    /// <summary>Selector for a VPNSite in network to populate remoteVpnSiteId.</summary>
    [JsonPropertyName("remoteVpnSiteIdSelector")]
    public V1beta1VPNGatewayConnectionSpecInitProviderRemoteVpnSiteIdSelector? RemoteVpnSiteIdSelector { get; set; }

    /// <summary>A routing block as defined below. If this is not specified, there will be a default route table created implicitly.</summary>
    [JsonPropertyName("routing")]
    public IList<V1beta1VPNGatewayConnectionSpecInitProviderRouting>? Routing { get; set; }

    /// <summary>One or more traffic_selector_policy blocks as defined below.</summary>
    [JsonPropertyName("trafficSelectorPolicy")]
    public IList<V1beta1VPNGatewayConnectionSpecInitProviderTrafficSelectorPolicy>? TrafficSelectorPolicy { get; set; }

    /// <summary>One or more vpn_link blocks as defined below.</summary>
    [JsonPropertyName("vpnLink")]
    public IList<V1beta1VPNGatewayConnectionSpecInitProviderVpnLink>? VpnLink { get; set; }
}

public enum V1beta1VPNGatewayConnectionSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1VPNGatewayConnectionSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNGatewayConnectionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPNGatewayConnectionSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1VPNGatewayConnectionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1VPNGatewayConnectionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNGatewayConnectionSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1VPNGatewayConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNGatewayConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VPNGatewayConnectionSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1VPNGatewayConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1VPNGatewayConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNGatewayConnectionSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VPNGatewayConnectionSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VPNGatewayConnectionSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1VPNGatewayConnectionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNGatewayConnectionSpecDeletionPolicyEnum>))]
    public V1beta1VPNGatewayConnectionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VPNGatewayConnectionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VPNGatewayConnectionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VPNGatewayConnectionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VPNGatewayConnectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VPNGatewayConnectionSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VPNGatewayConnectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1VPNGatewayConnectionStatusAtProviderRoutingPropagatedRouteTable
{
    /// <summary>A list of labels to assign to this route table.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>A list of Route Table IDs to associated with this VPN Gateway Connection.</summary>
    [JsonPropertyName("routeTableIds")]
    public IList<string>? RouteTableIds { get; set; }
}

public partial class V1beta1VPNGatewayConnectionStatusAtProviderRouting
{
    /// <summary>The ID of the Route Table associated with this VPN Connection.</summary>
    [JsonPropertyName("associatedRouteTable")]
    public string? AssociatedRouteTable { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for inbound learned routes.</summary>
    [JsonPropertyName("inboundRouteMapId")]
    public string? InboundRouteMapId { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for outbound advertised routes.</summary>
    [JsonPropertyName("outboundRouteMapId")]
    public string? OutboundRouteMapId { get; set; }

    /// <summary>A propagated_route_table block as defined below.</summary>
    [JsonPropertyName("propagatedRouteTable")]
    public IList<V1beta1VPNGatewayConnectionStatusAtProviderRoutingPropagatedRouteTable>? PropagatedRouteTable { get; set; }
}

public partial class V1beta1VPNGatewayConnectionStatusAtProviderTrafficSelectorPolicy
{
    /// <summary>A list of local address spaces in CIDR format for this VPN Gateway Connection.</summary>
    [JsonPropertyName("localAddressRanges")]
    public IList<string>? LocalAddressRanges { get; set; }

    /// <summary>A list of remote address spaces in CIDR format for this VPN Gateway Connection.</summary>
    [JsonPropertyName("remoteAddressRanges")]
    public IList<string>? RemoteAddressRanges { get; set; }
}

public partial class V1beta1VPNGatewayConnectionStatusAtProviderVpnLinkCustomBgpAddress
{
    /// <summary>The custom bgp ip address which belongs to the IP Configuration.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The ID of the IP Configuration which belongs to the VPN Gateway.</summary>
    [JsonPropertyName("ipConfigurationId")]
    public string? IpConfigurationId { get; set; }
}

public partial class V1beta1VPNGatewayConnectionStatusAtProviderVpnLinkIpsecPolicy
{
    /// <summary>The DH Group used in IKE Phase 1 for initial SA. Possible values are None, DHGroup1, DHGroup2, DHGroup14, DHGroup24, DHGroup2048, ECP256, ECP384.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IPSec encryption algorithm (IKE phase 1). Possible values are AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256, None.</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary>The IKE encryption algorithm (IKE phase 2). Possible values are DES, DES3, AES128, AES192, AES256, GCMAES128, GCMAES256.</summary>
    [JsonPropertyName("ikeEncryptionAlgorithm")]
    public string? IkeEncryptionAlgorithm { get; set; }

    /// <summary>The IKE integrity algorithm (IKE phase 2). Possible values are MD5, SHA1, SHA256, SHA384, GCMAES128, GCMAES256.</summary>
    [JsonPropertyName("ikeIntegrityAlgorithm")]
    public string? IkeIntegrityAlgorithm { get; set; }

    /// <summary>The IPSec integrity algorithm (IKE phase 1). Possible values are MD5, SHA1, SHA256, GCMAES128, GCMAES192, GCMAES256.</summary>
    [JsonPropertyName("integrityAlgorithm")]
    public string? IntegrityAlgorithm { get; set; }

    /// <summary>The Pfs Group used in IKE Phase 2 for the new child SA. Possible values are None, PFS1, PFS2, PFS14, PFS24, PFS2048, PFSMM, ECP256, ECP384.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for the site to site VPN tunnel.</summary>
    [JsonPropertyName("saDataSizeKb")]
    public double? SaDataSizeKb { get; set; }

    /// <summary>The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for the site to site VPN tunnel.</summary>
    [JsonPropertyName("saLifetimeSec")]
    public double? SaLifetimeSec { get; set; }
}

public partial class V1beta1VPNGatewayConnectionStatusAtProviderVpnLink
{
    /// <summary>The expected connection bandwidth in MBPS. Defaults to 10.</summary>
    [JsonPropertyName("bandwidthMbps")]
    public double? BandwidthMbps { get; set; }

    /// <summary>Should the BGP be enabled? Defaults to false. Changing this forces a new VPN Gateway Connection to be created.</summary>
    [JsonPropertyName("bgpEnabled")]
    public bool? BgpEnabled { get; set; }

    /// <summary>The connection mode of this VPN Link. Possible values are Default, InitiatorOnly and ResponderOnly. Defaults to Default.</summary>
    [JsonPropertyName("connectionMode")]
    public string? ConnectionMode { get; set; }

    /// <summary>One or more custom_bgp_address blocks as defined below.</summary>
    [JsonPropertyName("customBgpAddress")]
    public IList<V1beta1VPNGatewayConnectionStatusAtProviderVpnLinkCustomBgpAddress>? CustomBgpAddress { get; set; }

    /// <summary>A list of the egress NAT Rule Ids.</summary>
    [JsonPropertyName("egressNatRuleIds")]
    public IList<string>? EgressNatRuleIds { get; set; }

    /// <summary>A list of the ingress NAT Rule Ids.</summary>
    [JsonPropertyName("ingressNatRuleIds")]
    public IList<string>? IngressNatRuleIds { get; set; }

    /// <summary>One or more ipsec_policy blocks as defined above.</summary>
    [JsonPropertyName("ipsecPolicy")]
    public IList<V1beta1VPNGatewayConnectionStatusAtProviderVpnLinkIpsecPolicy>? IpsecPolicy { get; set; }

    /// <summary>Whether to use local Azure IP to initiate connection? Defaults to false.</summary>
    [JsonPropertyName("localAzureIpAddressEnabled")]
    public bool? LocalAzureIpAddressEnabled { get; set; }

    /// <summary>The name which should be used for this VPN Link Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to enable policy-based traffic selectors? Defaults to false.</summary>
    [JsonPropertyName("policyBasedTrafficSelectorEnabled")]
    public bool? PolicyBasedTrafficSelectorEnabled { get; set; }

    /// <summary>The protocol used for this VPN Link Connection. Possible values are IKEv1 and IKEv2. Defaults to IKEv2.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Should the rate limit be enabled? Defaults to false.</summary>
    [JsonPropertyName("ratelimitEnabled")]
    public bool? RatelimitEnabled { get; set; }

    /// <summary>Routing weight for this VPN Link Connection. Defaults to 0.</summary>
    [JsonPropertyName("routeWeight")]
    public double? RouteWeight { get; set; }

    /// <summary>SharedKey for this VPN Link Connection.</summary>
    [JsonPropertyName("sharedKey")]
    public string? SharedKey { get; set; }

    /// <summary>The ID of the connected VPN Site Link. Changing this forces a new VPN Gateway Connection to be created.</summary>
    [JsonPropertyName("vpnSiteLinkId")]
    public string? VpnSiteLinkId { get; set; }
}

public partial class V1beta1VPNGatewayConnectionStatusAtProvider
{
    /// <summary>The ID of the VPN Gateway Connection.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether Internet Security is enabled for this VPN Connection. Defaults to false.</summary>
    [JsonPropertyName("internetSecurityEnabled")]
    public bool? InternetSecurityEnabled { get; set; }

    /// <summary>The ID of the remote VPN Site, which will connect to the VPN Gateway. Changing this forces a new VPN Gateway Connection to be created.</summary>
    [JsonPropertyName("remoteVpnSiteId")]
    public string? RemoteVpnSiteId { get; set; }

    /// <summary>A routing block as defined below. If this is not specified, there will be a default route table created implicitly.</summary>
    [JsonPropertyName("routing")]
    public IList<V1beta1VPNGatewayConnectionStatusAtProviderRouting>? Routing { get; set; }

    /// <summary>One or more traffic_selector_policy blocks as defined below.</summary>
    [JsonPropertyName("trafficSelectorPolicy")]
    public IList<V1beta1VPNGatewayConnectionStatusAtProviderTrafficSelectorPolicy>? TrafficSelectorPolicy { get; set; }

    /// <summary>The ID of the VPN Gateway that this VPN Gateway Connection belongs to. Changing this forces a new VPN Gateway Connection to be created.</summary>
    [JsonPropertyName("vpnGatewayId")]
    public string? VpnGatewayId { get; set; }

    /// <summary>One or more vpn_link blocks as defined below.</summary>
    [JsonPropertyName("vpnLink")]
    public IList<V1beta1VPNGatewayConnectionStatusAtProviderVpnLink>? VpnLink { get; set; }
}

public partial class V1beta1VPNGatewayConnectionStatusConditions
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

public partial class V1beta1VPNGatewayConnectionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VPNGatewayConnectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VPNGatewayConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPNGatewayConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VPNGatewayConnectionSpec>, IStatus<V1beta1VPNGatewayConnectionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPNGatewayConnection";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "vpngatewayconnections";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VPNGatewayConnectionSpec defines the desired state of VPNGatewayConnection</summary>
    [JsonPropertyName("spec")]
    public V1beta1VPNGatewayConnectionSpec Spec { get; set; }

    /// <summary>VPNGatewayConnectionStatus defines the observed state of VPNGatewayConnection.</summary>
    [JsonPropertyName("status")]
    public V1beta1VPNGatewayConnectionStatus? Status { get; set; }
}