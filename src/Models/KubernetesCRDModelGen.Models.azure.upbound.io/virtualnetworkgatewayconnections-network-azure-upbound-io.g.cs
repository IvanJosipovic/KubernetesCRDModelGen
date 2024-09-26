using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
/// <summary>The authorization key associated with the Express Route Circuit. This field is required only if the type is an ExpressRoute connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderAuthorizationKeySecretRef
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
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderCustomBgpAddresses
{
    /// <summary>single IP address that is part of the azurerm_virtual_network_gateway ip_configuration (first one)</summary>
    [JsonPropertyName("primary")]
    public string? Primary { get; set; }

    /// <summary>single IP address that is part of the azurerm_virtual_network_gateway ip_configuration (second one)</summary>
    [JsonPropertyName("secondary")]
    public string? Secondary { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderIpsecPolicy
{
    /// <summary>The DH group used in IKE phase 1 for initial SA. Valid options are DHGroup1, DHGroup14, DHGroup2, DHGroup2048, DHGroup24, ECP256, ECP384, or None.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IKE encryption algorithm. Valid options are AES128, AES192, AES256, DES, DES3, GCMAES128, or GCMAES256.</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>The IKE integrity algorithm. Valid options are GCMAES128, GCMAES256, MD5, SHA1, SHA256, or SHA384.</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>The IPSec encryption algorithm. Valid options are AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256, or None.</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>The IPSec integrity algorithm. Valid options are GCMAES128, GCMAES192, GCMAES256, MD5, SHA1, or SHA256.</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>The DH group used in IKE phase 2 for new child SA. Valid options are ECP256, ECP384, PFS1, PFS14, PFS2, PFS2048, PFS24, PFSMM, or None.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec SA payload size in KB. Must be at least 1024 KB. Defaults to 102400000 KB.</summary>
    [JsonPropertyName("saDatasize")]
    public double? SaDatasize { get; set; }

    /// <summary>The IPSec SA lifetime in seconds. Must be at least 300 seconds. Defaults to 27000 seconds.</summary>
    [JsonPropertyName("saLifetime")]
    public double? SaLifetime { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>The shared IPSec key. A key could be provided if a Site-to-Site, VNet-to-VNet or ExpressRoute connection is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderSharedKeySecretRef
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
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderTrafficSelectorPolicy
{
    /// <summary>List of local CIDRs.</summary>
    [JsonPropertyName("localAddressCidrs")]
    public IList<string>? LocalAddressCidrs { get; set; }

    /// <summary>List of remote CIDRs.</summary>
    [JsonPropertyName("remoteAddressCidrs")]
    public IList<string>? RemoteAddressCidrs { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecForProvider
{
    /// <summary>The authorization key associated with the Express Route Circuit. This field is required only if the type is an ExpressRoute connection.</summary>
    [JsonPropertyName("authorizationKeySecretRef")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderAuthorizationKeySecretRef? AuthorizationKeySecretRef { get; set; }

    /// <summary>Connection mode to use. Possible values are Default, InitiatorOnly and ResponderOnly. Defaults to Default. Changing this value will force a resource to be created.</summary>
    [JsonPropertyName("connectionMode")]
    public string? ConnectionMode { get; set; }

    /// <summary>The IKE protocol version to use. Possible values are IKEv1 and IKEv2, values are IKEv1 and IKEv2. Defaults to IKEv2. Changing this forces a new resource to be created. -&gt; Note: Only valid for IPSec connections on virtual network gateways with SKU VpnGw1, VpnGw2, VpnGw3, VpnGw1AZ, VpnGw2AZ or VpnGw3AZ.</summary>
    [JsonPropertyName("connectionProtocol")]
    public string? ConnectionProtocol { get; set; }

    /// <summary>A custom_bgp_addresses block which is documented below. The block can only be used on IPSec / activeactive connections, For details about see the relevant section in the Azure documentation.</summary>
    [JsonPropertyName("customBgpAddresses")]
    public IList<V1beta1VirtualNetworkGatewayConnectionSpecForProviderCustomBgpAddresses>? CustomBgpAddresses { get; set; }

    /// <summary>The dead peer detection timeout of this connection in seconds. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dpdTimeoutSeconds")]
    public double? DpdTimeoutSeconds { get; set; }

    /// <summary>A list of the egress NAT Rule Ids.</summary>
    [JsonPropertyName("egressNatRuleIds")]
    public IList<string>? EgressNatRuleIds { get; set; }

    /// <summary>If true, BGP (Border Gateway Protocol) is enabled for this connection. Defaults to false.</summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary>The ID of the Express Route Circuit when creating an ExpressRoute connection (i.e. when type is ExpressRoute). The Express Route Circuit can be in the same or in a different subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expressRouteCircuitId")]
    public string? ExpressRouteCircuitId { get; set; }

    /// <summary>If true, data packets will bypass ExpressRoute Gateway for data forwarding This is only valid for ExpressRoute connections.</summary>
    [JsonPropertyName("expressRouteGatewayBypass")]
    public bool? ExpressRouteGatewayBypass { get; set; }

    /// <summary>A list of the ingress NAT Rule Ids.</summary>
    [JsonPropertyName("ingressNatRuleIds")]
    public IList<string>? IngressNatRuleIds { get; set; }

    /// <summary>A ipsec_policy block which is documented below. Only a single policy can be defined for a connection. For details on custom policies refer to the relevant section in the Azure documentation.</summary>
    [JsonPropertyName("ipsecPolicy")]
    public IList<V1beta1VirtualNetworkGatewayConnectionSpecForProviderIpsecPolicy>? IpsecPolicy { get; set; }

    /// <summary>Use private local Azure IP for the connection. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("localAzureIpAddressEnabled")]
    public bool? LocalAzureIpAddressEnabled { get; set; }

    /// <summary>The ID of the local network gateway when creating Site-to-Site connection (i.e. when type is IPsec).</summary>
    [JsonPropertyName("localNetworkGatewayId")]
    public string? LocalNetworkGatewayId { get; set; }

    /// <summary>Reference to a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
    [JsonPropertyName("localNetworkGatewayIdRef")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdRef? LocalNetworkGatewayIdRef { get; set; }

    /// <summary>Selector for a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
    [JsonPropertyName("localNetworkGatewayIdSelector")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdSelector? LocalNetworkGatewayIdSelector { get; set; }

    /// <summary>The location/region where the connection is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the peer virtual network gateway when creating a VNet-to-VNet connection (i.e. when type is Vnet2Vnet). The peer Virtual Network Gateway can be in the same or in a different subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("peerVirtualNetworkGatewayId")]
    public string? PeerVirtualNetworkGatewayId { get; set; }

    /// <summary>Reference to a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
    [JsonPropertyName("peerVirtualNetworkGatewayIdRef")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdRef? PeerVirtualNetworkGatewayIdRef { get; set; }

    /// <summary>Selector for a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
    [JsonPropertyName("peerVirtualNetworkGatewayIdSelector")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdSelector? PeerVirtualNetworkGatewayIdSelector { get; set; }

    /// <summary>The name of the resource group in which to create the connection Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The routing weight. Defaults to 10.</summary>
    [JsonPropertyName("routingWeight")]
    public double? RoutingWeight { get; set; }

    /// <summary>The shared IPSec key. A key could be provided if a Site-to-Site, VNet-to-VNet or ExpressRoute connection is created.</summary>
    [JsonPropertyName("sharedKeySecretRef")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderSharedKeySecretRef? SharedKeySecretRef { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more traffic_selector_policy blocks which are documented below. A traffic_selector_policy allows to specify a traffic selector policy proposal to be used in a virtual network gateway connection. For details about traffic selectors refer to the relevant section in the Azure documentation.</summary>
    [JsonPropertyName("trafficSelectorPolicy")]
    public IList<V1beta1VirtualNetworkGatewayConnectionSpecForProviderTrafficSelectorPolicy>? TrafficSelectorPolicy { get; set; }

    /// <summary>The type of connection. Valid options are IPsec (Site-to-Site), ExpressRoute (ExpressRoute), and Vnet2Vnet (VNet-to-VNet). Each connection type requires different mandatory arguments (refer to the examples above). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>If true, policy-based traffic selectors are enabled for this connection. Enabling policy-based traffic selectors requires an ipsec_policy block. Defaults to false.</summary>
    [JsonPropertyName("usePolicyBasedTrafficSelectors")]
    public bool? UsePolicyBasedTrafficSelectors { get; set; }

    /// <summary>The ID of the Virtual Network Gateway in which the connection will be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkGatewayId")]
    public string? VirtualNetworkGatewayId { get; set; }

    /// <summary>Reference to a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
    [JsonPropertyName("virtualNetworkGatewayIdRef")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdRef? VirtualNetworkGatewayIdRef { get; set; }

    /// <summary>Selector for a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
    [JsonPropertyName("virtualNetworkGatewayIdSelector")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdSelector? VirtualNetworkGatewayIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProviderCustomBgpAddresses
{
    /// <summary>single IP address that is part of the azurerm_virtual_network_gateway ip_configuration (first one)</summary>
    [JsonPropertyName("primary")]
    public string? Primary { get; set; }

    /// <summary>single IP address that is part of the azurerm_virtual_network_gateway ip_configuration (second one)</summary>
    [JsonPropertyName("secondary")]
    public string? Secondary { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProviderIpsecPolicy
{
    /// <summary>The DH group used in IKE phase 1 for initial SA. Valid options are DHGroup1, DHGroup14, DHGroup2, DHGroup2048, DHGroup24, ECP256, ECP384, or None.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IKE encryption algorithm. Valid options are AES128, AES192, AES256, DES, DES3, GCMAES128, or GCMAES256.</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>The IKE integrity algorithm. Valid options are GCMAES128, GCMAES256, MD5, SHA1, SHA256, or SHA384.</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>The IPSec encryption algorithm. Valid options are AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256, or None.</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>The IPSec integrity algorithm. Valid options are GCMAES128, GCMAES192, GCMAES256, MD5, SHA1, or SHA256.</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>The DH group used in IKE phase 2 for new child SA. Valid options are ECP256, ECP384, PFS1, PFS14, PFS2, PFS2048, PFS24, PFSMM, or None.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec SA payload size in KB. Must be at least 1024 KB. Defaults to 102400000 KB.</summary>
    [JsonPropertyName("saDatasize")]
    public double? SaDatasize { get; set; }

    /// <summary>The IPSec SA lifetime in seconds. Must be at least 300 seconds. Defaults to 27000 seconds.</summary>
    [JsonPropertyName("saLifetime")]
    public double? SaLifetime { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProviderTrafficSelectorPolicy
{
    /// <summary>List of local CIDRs.</summary>
    [JsonPropertyName("localAddressCidrs")]
    public IList<string>? LocalAddressCidrs { get; set; }

    /// <summary>List of remote CIDRs.</summary>
    [JsonPropertyName("remoteAddressCidrs")]
    public IList<string>? RemoteAddressCidrs { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecInitProvider
{
    /// <summary>Connection mode to use. Possible values are Default, InitiatorOnly and ResponderOnly. Defaults to Default. Changing this value will force a resource to be created.</summary>
    [JsonPropertyName("connectionMode")]
    public string? ConnectionMode { get; set; }

    /// <summary>The IKE protocol version to use. Possible values are IKEv1 and IKEv2, values are IKEv1 and IKEv2. Defaults to IKEv2. Changing this forces a new resource to be created. -&gt; Note: Only valid for IPSec connections on virtual network gateways with SKU VpnGw1, VpnGw2, VpnGw3, VpnGw1AZ, VpnGw2AZ or VpnGw3AZ.</summary>
    [JsonPropertyName("connectionProtocol")]
    public string? ConnectionProtocol { get; set; }

    /// <summary>A custom_bgp_addresses block which is documented below. The block can only be used on IPSec / activeactive connections, For details about see the relevant section in the Azure documentation.</summary>
    [JsonPropertyName("customBgpAddresses")]
    public IList<V1beta1VirtualNetworkGatewayConnectionSpecInitProviderCustomBgpAddresses>? CustomBgpAddresses { get; set; }

    /// <summary>The dead peer detection timeout of this connection in seconds. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dpdTimeoutSeconds")]
    public double? DpdTimeoutSeconds { get; set; }

    /// <summary>A list of the egress NAT Rule Ids.</summary>
    [JsonPropertyName("egressNatRuleIds")]
    public IList<string>? EgressNatRuleIds { get; set; }

    /// <summary>If true, BGP (Border Gateway Protocol) is enabled for this connection. Defaults to false.</summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary>The ID of the Express Route Circuit when creating an ExpressRoute connection (i.e. when type is ExpressRoute). The Express Route Circuit can be in the same or in a different subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expressRouteCircuitId")]
    public string? ExpressRouteCircuitId { get; set; }

    /// <summary>If true, data packets will bypass ExpressRoute Gateway for data forwarding This is only valid for ExpressRoute connections.</summary>
    [JsonPropertyName("expressRouteGatewayBypass")]
    public bool? ExpressRouteGatewayBypass { get; set; }

    /// <summary>A list of the ingress NAT Rule Ids.</summary>
    [JsonPropertyName("ingressNatRuleIds")]
    public IList<string>? IngressNatRuleIds { get; set; }

    /// <summary>A ipsec_policy block which is documented below. Only a single policy can be defined for a connection. For details on custom policies refer to the relevant section in the Azure documentation.</summary>
    [JsonPropertyName("ipsecPolicy")]
    public IList<V1beta1VirtualNetworkGatewayConnectionSpecInitProviderIpsecPolicy>? IpsecPolicy { get; set; }

    /// <summary>Use private local Azure IP for the connection. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("localAzureIpAddressEnabled")]
    public bool? LocalAzureIpAddressEnabled { get; set; }

    /// <summary>The ID of the local network gateway when creating Site-to-Site connection (i.e. when type is IPsec).</summary>
    [JsonPropertyName("localNetworkGatewayId")]
    public string? LocalNetworkGatewayId { get; set; }

    /// <summary>Reference to a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
    [JsonPropertyName("localNetworkGatewayIdRef")]
    public V1beta1VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdRef? LocalNetworkGatewayIdRef { get; set; }

    /// <summary>Selector for a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
    [JsonPropertyName("localNetworkGatewayIdSelector")]
    public V1beta1VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdSelector? LocalNetworkGatewayIdSelector { get; set; }

    /// <summary>The location/region where the connection is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the peer virtual network gateway when creating a VNet-to-VNet connection (i.e. when type is Vnet2Vnet). The peer Virtual Network Gateway can be in the same or in a different subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("peerVirtualNetworkGatewayId")]
    public string? PeerVirtualNetworkGatewayId { get; set; }

    /// <summary>Reference to a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
    [JsonPropertyName("peerVirtualNetworkGatewayIdRef")]
    public V1beta1VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdRef? PeerVirtualNetworkGatewayIdRef { get; set; }

    /// <summary>Selector for a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
    [JsonPropertyName("peerVirtualNetworkGatewayIdSelector")]
    public V1beta1VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdSelector? PeerVirtualNetworkGatewayIdSelector { get; set; }

    /// <summary>The routing weight. Defaults to 10.</summary>
    [JsonPropertyName("routingWeight")]
    public double? RoutingWeight { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more traffic_selector_policy blocks which are documented below. A traffic_selector_policy allows to specify a traffic selector policy proposal to be used in a virtual network gateway connection. For details about traffic selectors refer to the relevant section in the Azure documentation.</summary>
    [JsonPropertyName("trafficSelectorPolicy")]
    public IList<V1beta1VirtualNetworkGatewayConnectionSpecInitProviderTrafficSelectorPolicy>? TrafficSelectorPolicy { get; set; }

    /// <summary>The type of connection. Valid options are IPsec (Site-to-Site), ExpressRoute (ExpressRoute), and Vnet2Vnet (VNet-to-VNet). Each connection type requires different mandatory arguments (refer to the examples above). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>If true, policy-based traffic selectors are enabled for this connection. Enabling policy-based traffic selectors requires an ipsec_policy block. Defaults to false.</summary>
    [JsonPropertyName("usePolicyBasedTrafficSelectors")]
    public bool? UsePolicyBasedTrafficSelectors { get; set; }

    /// <summary>The ID of the Virtual Network Gateway in which the connection will be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkGatewayId")]
    public string? VirtualNetworkGatewayId { get; set; }

    /// <summary>Reference to a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
    [JsonPropertyName("virtualNetworkGatewayIdRef")]
    public V1beta1VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdRef? VirtualNetworkGatewayIdRef { get; set; }

    /// <summary>Selector for a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
    [JsonPropertyName("virtualNetworkGatewayIdSelector")]
    public V1beta1VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdSelector? VirtualNetworkGatewayIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecProviderConfigRefPolicy
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
public partial class V1beta1VirtualNetworkGatewayConnectionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewayConnectionSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecPublishConnectionDetailsToMetadata
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

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VirtualNetworkGatewayConnectionSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VirtualNetworkGatewayConnectionSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VirtualNetworkGatewayConnectionSpec defines the desired state of VirtualNetworkGatewayConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VirtualNetworkGatewayConnectionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VirtualNetworkGatewayConnectionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VirtualNetworkGatewayConnectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VirtualNetworkGatewayConnectionSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VirtualNetworkGatewayConnectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionStatusAtProviderCustomBgpAddresses
{
    /// <summary>single IP address that is part of the azurerm_virtual_network_gateway ip_configuration (first one)</summary>
    [JsonPropertyName("primary")]
    public string? Primary { get; set; }

    /// <summary>single IP address that is part of the azurerm_virtual_network_gateway ip_configuration (second one)</summary>
    [JsonPropertyName("secondary")]
    public string? Secondary { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionStatusAtProviderIpsecPolicy
{
    /// <summary>The DH group used in IKE phase 1 for initial SA. Valid options are DHGroup1, DHGroup14, DHGroup2, DHGroup2048, DHGroup24, ECP256, ECP384, or None.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IKE encryption algorithm. Valid options are AES128, AES192, AES256, DES, DES3, GCMAES128, or GCMAES256.</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>The IKE integrity algorithm. Valid options are GCMAES128, GCMAES256, MD5, SHA1, SHA256, or SHA384.</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>The IPSec encryption algorithm. Valid options are AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256, or None.</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>The IPSec integrity algorithm. Valid options are GCMAES128, GCMAES192, GCMAES256, MD5, SHA1, or SHA256.</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>The DH group used in IKE phase 2 for new child SA. Valid options are ECP256, ECP384, PFS1, PFS14, PFS2, PFS2048, PFS24, PFSMM, or None.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec SA payload size in KB. Must be at least 1024 KB. Defaults to 102400000 KB.</summary>
    [JsonPropertyName("saDatasize")]
    public double? SaDatasize { get; set; }

    /// <summary>The IPSec SA lifetime in seconds. Must be at least 300 seconds. Defaults to 27000 seconds.</summary>
    [JsonPropertyName("saLifetime")]
    public double? SaLifetime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionStatusAtProviderTrafficSelectorPolicy
{
    /// <summary>List of local CIDRs.</summary>
    [JsonPropertyName("localAddressCidrs")]
    public IList<string>? LocalAddressCidrs { get; set; }

    /// <summary>List of remote CIDRs.</summary>
    [JsonPropertyName("remoteAddressCidrs")]
    public IList<string>? RemoteAddressCidrs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionStatusAtProvider
{
    /// <summary>Connection mode to use. Possible values are Default, InitiatorOnly and ResponderOnly. Defaults to Default. Changing this value will force a resource to be created.</summary>
    [JsonPropertyName("connectionMode")]
    public string? ConnectionMode { get; set; }

    /// <summary>The IKE protocol version to use. Possible values are IKEv1 and IKEv2, values are IKEv1 and IKEv2. Defaults to IKEv2. Changing this forces a new resource to be created. -&gt; Note: Only valid for IPSec connections on virtual network gateways with SKU VpnGw1, VpnGw2, VpnGw3, VpnGw1AZ, VpnGw2AZ or VpnGw3AZ.</summary>
    [JsonPropertyName("connectionProtocol")]
    public string? ConnectionProtocol { get; set; }

    /// <summary>A custom_bgp_addresses block which is documented below. The block can only be used on IPSec / activeactive connections, For details about see the relevant section in the Azure documentation.</summary>
    [JsonPropertyName("customBgpAddresses")]
    public IList<V1beta1VirtualNetworkGatewayConnectionStatusAtProviderCustomBgpAddresses>? CustomBgpAddresses { get; set; }

    /// <summary>The dead peer detection timeout of this connection in seconds. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dpdTimeoutSeconds")]
    public double? DpdTimeoutSeconds { get; set; }

    /// <summary>A list of the egress NAT Rule Ids.</summary>
    [JsonPropertyName("egressNatRuleIds")]
    public IList<string>? EgressNatRuleIds { get; set; }

    /// <summary>If true, BGP (Border Gateway Protocol) is enabled for this connection. Defaults to false.</summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary>The ID of the Express Route Circuit when creating an ExpressRoute connection (i.e. when type is ExpressRoute). The Express Route Circuit can be in the same or in a different subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expressRouteCircuitId")]
    public string? ExpressRouteCircuitId { get; set; }

    /// <summary>If true, data packets will bypass ExpressRoute Gateway for data forwarding This is only valid for ExpressRoute connections.</summary>
    [JsonPropertyName("expressRouteGatewayBypass")]
    public bool? ExpressRouteGatewayBypass { get; set; }

    /// <summary>The ID of the Virtual Network Gateway Connection.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of the ingress NAT Rule Ids.</summary>
    [JsonPropertyName("ingressNatRuleIds")]
    public IList<string>? IngressNatRuleIds { get; set; }

    /// <summary>A ipsec_policy block which is documented below. Only a single policy can be defined for a connection. For details on custom policies refer to the relevant section in the Azure documentation.</summary>
    [JsonPropertyName("ipsecPolicy")]
    public IList<V1beta1VirtualNetworkGatewayConnectionStatusAtProviderIpsecPolicy>? IpsecPolicy { get; set; }

    /// <summary>Use private local Azure IP for the connection. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("localAzureIpAddressEnabled")]
    public bool? LocalAzureIpAddressEnabled { get; set; }

    /// <summary>The ID of the local network gateway when creating Site-to-Site connection (i.e. when type is IPsec).</summary>
    [JsonPropertyName("localNetworkGatewayId")]
    public string? LocalNetworkGatewayId { get; set; }

    /// <summary>The location/region where the connection is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the peer virtual network gateway when creating a VNet-to-VNet connection (i.e. when type is Vnet2Vnet). The peer Virtual Network Gateway can be in the same or in a different subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("peerVirtualNetworkGatewayId")]
    public string? PeerVirtualNetworkGatewayId { get; set; }

    /// <summary>The name of the resource group in which to create the connection Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The routing weight. Defaults to 10.</summary>
    [JsonPropertyName("routingWeight")]
    public double? RoutingWeight { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more traffic_selector_policy blocks which are documented below. A traffic_selector_policy allows to specify a traffic selector policy proposal to be used in a virtual network gateway connection. For details about traffic selectors refer to the relevant section in the Azure documentation.</summary>
    [JsonPropertyName("trafficSelectorPolicy")]
    public IList<V1beta1VirtualNetworkGatewayConnectionStatusAtProviderTrafficSelectorPolicy>? TrafficSelectorPolicy { get; set; }

    /// <summary>The type of connection. Valid options are IPsec (Site-to-Site), ExpressRoute (ExpressRoute), and Vnet2Vnet (VNet-to-VNet). Each connection type requires different mandatory arguments (refer to the examples above). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>If true, policy-based traffic selectors are enabled for this connection. Enabling policy-based traffic selectors requires an ipsec_policy block. Defaults to false.</summary>
    [JsonPropertyName("usePolicyBasedTrafficSelectors")]
    public bool? UsePolicyBasedTrafficSelectors { get; set; }

    /// <summary>The ID of the Virtual Network Gateway in which the connection will be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkGatewayId")]
    public string? VirtualNetworkGatewayId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionStatusConditions
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

/// <summary>VirtualNetworkGatewayConnectionStatus defines the observed state of VirtualNetworkGatewayConnection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkGatewayConnectionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VirtualNetworkGatewayConnectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VirtualNetworkGatewayConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VirtualNetworkGatewayConnection is the Schema for the VirtualNetworkGatewayConnections API. Manages a connection in an existing Virtual Network Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualNetworkGatewayConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VirtualNetworkGatewayConnectionSpec>, IStatus<V1beta1VirtualNetworkGatewayConnectionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualNetworkGatewayConnection";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "virtualnetworkgatewayconnections";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VirtualNetworkGatewayConnectionSpec defines the desired state of VirtualNetworkGatewayConnection</summary>
    [JsonPropertyName("spec")]
    public V1beta1VirtualNetworkGatewayConnectionSpec Spec { get; set; }

    /// <summary>VirtualNetworkGatewayConnectionStatus defines the observed state of VirtualNetworkGatewayConnection.</summary>
    [JsonPropertyName("status")]
    public V1beta1VirtualNetworkGatewayConnectionStatus? Status { get; set; }
}