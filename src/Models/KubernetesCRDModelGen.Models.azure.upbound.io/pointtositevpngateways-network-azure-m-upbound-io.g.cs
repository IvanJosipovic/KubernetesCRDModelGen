using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.m.upbound.io;
#nullable enable
/// <summary>PointToSiteVPNGateway is the Schema for the PointToSiteVPNGateways API. Manages a Point-to-Site VPN Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PointToSiteVPNGatewayList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PointToSiteVPNGateway>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PointToSiteVPNGatewayList";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "pointtositevpngateways";
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
    public IList<V1beta1PointToSiteVPNGateway> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A propagated_route_table block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderConnectionConfigurationRoutePropagatedRouteTable
{
    /// <summary>The list of Virtual Hub Route Table resource id which the routes will be propagated to.</summary>
    [JsonPropertyName("ids")]
    public IList<string>? Ids { get; set; }

    /// <summary>The list of labels to logically group Virtual Hub Route Tables which the routes will be propagated to.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A route block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderConnectionConfigurationRoute
{
    /// <summary>The Virtual Hub Route Table resource id associated with this Routing Configuration.</summary>
    [JsonPropertyName("associatedRouteTableId")]
    public string? AssociatedRouteTableId { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for inbound learned routes.</summary>
    [JsonPropertyName("inboundRouteMapId")]
    public string? InboundRouteMapId { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for outbound advertised routes.</summary>
    [JsonPropertyName("outboundRouteMapId")]
    public string? OutboundRouteMapId { get; set; }

    /// <summary>A propagated_route_table block as defined below.</summary>
    [JsonPropertyName("propagatedRouteTable")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderConnectionConfigurationRoutePropagatedRouteTable? PropagatedRouteTable { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A vpn_client_address_pool block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderConnectionConfigurationVpnClientAddressPool
{
    /// <summary>A list of CIDR Ranges which should be used as Address Prefixes.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderConnectionConfiguration
{
    /// <summary>Should Internet Security be enabled to secure internet traffic? Changing this forces a new resource to be created. Defaults to false.</summary>
    [JsonPropertyName("internetSecurityEnabled")]
    public bool? InternetSecurityEnabled { get; set; }

    /// <summary>The Name which should be used for this Connection Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A route block as defined below.</summary>
    [JsonPropertyName("route")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderConnectionConfigurationRoute? Route { get; set; }

    /// <summary>A vpn_client_address_pool block as defined below.</summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderConnectionConfigurationVpnClientAddressPool? VpnClientAddressPool { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a VirtualHub in network to populate virtualHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a VirtualHub in network to populate virtualHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a VPNServerConfiguration in network to populate vpnServerConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a VPNServerConfiguration in network to populate vpnServerConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProvider
{
    /// <summary>A connection_configuration block as defined below.</summary>
    [JsonPropertyName("connectionConfiguration")]
    public IList<V1beta1PointToSiteVPNGatewaySpecForProviderConnectionConfiguration>? ConnectionConfiguration { get; set; }

    /// <summary>A list of IP Addresses of DNS Servers for the Point-to-Site VPN Gateway.</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the resource group in which to create the Point-to-Site VPN Gateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Is the Routing Preference for the Public IP Interface of the VPN Gateway enabled? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("routingPreferenceInternetEnabled")]
    public bool? RoutingPreferenceInternetEnabled { get; set; }

    /// <summary>The Scale Unit for this Point-to-Site VPN Gateway.</summary>
    [JsonPropertyName("scaleUnit")]
    public double? ScaleUnit { get; set; }

    /// <summary>A mapping of tags to assign to the Point-to-Site VPN Gateway.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Hub where this Point-to-Site VPN Gateway should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualHubId")]
    public string? VirtualHubId { get; set; }

    /// <summary>Reference to a VirtualHub in network to populate virtualHubId.</summary>
    [JsonPropertyName("virtualHubIdRef")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdRef? VirtualHubIdRef { get; set; }

    /// <summary>Selector for a VirtualHub in network to populate virtualHubId.</summary>
    [JsonPropertyName("virtualHubIdSelector")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdSelector? VirtualHubIdSelector { get; set; }

    /// <summary>The ID of the VPN Server Configuration which this Point-to-Site VPN Gateway should use. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vpnServerConfigurationId")]
    public string? VpnServerConfigurationId { get; set; }

    /// <summary>Reference to a VPNServerConfiguration in network to populate vpnServerConfigurationId.</summary>
    [JsonPropertyName("vpnServerConfigurationIdRef")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdRef? VpnServerConfigurationIdRef { get; set; }

    /// <summary>Selector for a VPNServerConfiguration in network to populate vpnServerConfigurationId.</summary>
    [JsonPropertyName("vpnServerConfigurationIdSelector")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdSelector? VpnServerConfigurationIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A propagated_route_table block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderConnectionConfigurationRoutePropagatedRouteTable
{
    /// <summary>The list of Virtual Hub Route Table resource id which the routes will be propagated to.</summary>
    [JsonPropertyName("ids")]
    public IList<string>? Ids { get; set; }

    /// <summary>The list of labels to logically group Virtual Hub Route Tables which the routes will be propagated to.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A route block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderConnectionConfigurationRoute
{
    /// <summary>The Virtual Hub Route Table resource id associated with this Routing Configuration.</summary>
    [JsonPropertyName("associatedRouteTableId")]
    public string? AssociatedRouteTableId { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for inbound learned routes.</summary>
    [JsonPropertyName("inboundRouteMapId")]
    public string? InboundRouteMapId { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for outbound advertised routes.</summary>
    [JsonPropertyName("outboundRouteMapId")]
    public string? OutboundRouteMapId { get; set; }

    /// <summary>A propagated_route_table block as defined below.</summary>
    [JsonPropertyName("propagatedRouteTable")]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderConnectionConfigurationRoutePropagatedRouteTable? PropagatedRouteTable { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A vpn_client_address_pool block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderConnectionConfigurationVpnClientAddressPool
{
    /// <summary>A list of CIDR Ranges which should be used as Address Prefixes.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderConnectionConfiguration
{
    /// <summary>Should Internet Security be enabled to secure internet traffic? Changing this forces a new resource to be created. Defaults to false.</summary>
    [JsonPropertyName("internetSecurityEnabled")]
    public bool? InternetSecurityEnabled { get; set; }

    /// <summary>The Name which should be used for this Connection Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A route block as defined below.</summary>
    [JsonPropertyName("route")]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderConnectionConfigurationRoute? Route { get; set; }

    /// <summary>A vpn_client_address_pool block as defined below.</summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderConnectionConfigurationVpnClientAddressPool? VpnClientAddressPool { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a VirtualHub in network to populate virtualHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a VirtualHub in network to populate virtualHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a VPNServerConfiguration in network to populate vpnServerConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a VPNServerConfiguration in network to populate vpnServerConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProvider
{
    /// <summary>A connection_configuration block as defined below.</summary>
    [JsonPropertyName("connectionConfiguration")]
    public IList<V1beta1PointToSiteVPNGatewaySpecInitProviderConnectionConfiguration>? ConnectionConfiguration { get; set; }

    /// <summary>A list of IP Addresses of DNS Servers for the Point-to-Site VPN Gateway.</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Is the Routing Preference for the Public IP Interface of the VPN Gateway enabled? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("routingPreferenceInternetEnabled")]
    public bool? RoutingPreferenceInternetEnabled { get; set; }

    /// <summary>The Scale Unit for this Point-to-Site VPN Gateway.</summary>
    [JsonPropertyName("scaleUnit")]
    public double? ScaleUnit { get; set; }

    /// <summary>A mapping of tags to assign to the Point-to-Site VPN Gateway.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Hub where this Point-to-Site VPN Gateway should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualHubId")]
    public string? VirtualHubId { get; set; }

    /// <summary>Reference to a VirtualHub in network to populate virtualHubId.</summary>
    [JsonPropertyName("virtualHubIdRef")]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdRef? VirtualHubIdRef { get; set; }

    /// <summary>Selector for a VirtualHub in network to populate virtualHubId.</summary>
    [JsonPropertyName("virtualHubIdSelector")]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdSelector? VirtualHubIdSelector { get; set; }

    /// <summary>The ID of the VPN Server Configuration which this Point-to-Site VPN Gateway should use. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vpnServerConfigurationId")]
    public string? VpnServerConfigurationId { get; set; }

    /// <summary>Reference to a VPNServerConfiguration in network to populate vpnServerConfigurationId.</summary>
    [JsonPropertyName("vpnServerConfigurationIdRef")]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdRef? VpnServerConfigurationIdRef { get; set; }

    /// <summary>Selector for a VPNServerConfiguration in network to populate vpnServerConfigurationId.</summary>
    [JsonPropertyName("vpnServerConfigurationIdSelector")]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdSelector? VpnServerConfigurationIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PointToSiteVPNGatewaySpec defines the desired state of PointToSiteVPNGateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PointToSiteVPNGatewaySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PointToSiteVPNGatewaySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PointToSiteVPNGatewaySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PointToSiteVPNGatewaySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A propagated_route_table block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewayStatusAtProviderConnectionConfigurationRoutePropagatedRouteTable
{
    /// <summary>The list of Virtual Hub Route Table resource id which the routes will be propagated to.</summary>
    [JsonPropertyName("ids")]
    public IList<string>? Ids { get; set; }

    /// <summary>The list of labels to logically group Virtual Hub Route Tables which the routes will be propagated to.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A route block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewayStatusAtProviderConnectionConfigurationRoute
{
    /// <summary>The Virtual Hub Route Table resource id associated with this Routing Configuration.</summary>
    [JsonPropertyName("associatedRouteTableId")]
    public string? AssociatedRouteTableId { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for inbound learned routes.</summary>
    [JsonPropertyName("inboundRouteMapId")]
    public string? InboundRouteMapId { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for outbound advertised routes.</summary>
    [JsonPropertyName("outboundRouteMapId")]
    public string? OutboundRouteMapId { get; set; }

    /// <summary>A propagated_route_table block as defined below.</summary>
    [JsonPropertyName("propagatedRouteTable")]
    public V1beta1PointToSiteVPNGatewayStatusAtProviderConnectionConfigurationRoutePropagatedRouteTable? PropagatedRouteTable { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A vpn_client_address_pool block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewayStatusAtProviderConnectionConfigurationVpnClientAddressPool
{
    /// <summary>A list of CIDR Ranges which should be used as Address Prefixes.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewayStatusAtProviderConnectionConfiguration
{
    /// <summary>Should Internet Security be enabled to secure internet traffic? Changing this forces a new resource to be created. Defaults to false.</summary>
    [JsonPropertyName("internetSecurityEnabled")]
    public bool? InternetSecurityEnabled { get; set; }

    /// <summary>The Name which should be used for this Connection Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A route block as defined below.</summary>
    [JsonPropertyName("route")]
    public V1beta1PointToSiteVPNGatewayStatusAtProviderConnectionConfigurationRoute? Route { get; set; }

    /// <summary>A vpn_client_address_pool block as defined below.</summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public V1beta1PointToSiteVPNGatewayStatusAtProviderConnectionConfigurationVpnClientAddressPool? VpnClientAddressPool { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewayStatusAtProvider
{
    /// <summary>A connection_configuration block as defined below.</summary>
    [JsonPropertyName("connectionConfiguration")]
    public IList<V1beta1PointToSiteVPNGatewayStatusAtProviderConnectionConfiguration>? ConnectionConfiguration { get; set; }

    /// <summary>A list of IP Addresses of DNS Servers for the Point-to-Site VPN Gateway.</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }

    /// <summary>The ID of the Point-to-Site VPN Gateway.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the resource group in which to create the Point-to-Site VPN Gateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Is the Routing Preference for the Public IP Interface of the VPN Gateway enabled? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("routingPreferenceInternetEnabled")]
    public bool? RoutingPreferenceInternetEnabled { get; set; }

    /// <summary>The Scale Unit for this Point-to-Site VPN Gateway.</summary>
    [JsonPropertyName("scaleUnit")]
    public double? ScaleUnit { get; set; }

    /// <summary>A mapping of tags to assign to the Point-to-Site VPN Gateway.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Hub where this Point-to-Site VPN Gateway should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualHubId")]
    public string? VirtualHubId { get; set; }

    /// <summary>The ID of the VPN Server Configuration which this Point-to-Site VPN Gateway should use. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vpnServerConfigurationId")]
    public string? VpnServerConfigurationId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewayStatusConditions
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
#nullable disable

#nullable enable
/// <summary>PointToSiteVPNGatewayStatus defines the observed state of PointToSiteVPNGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewayStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PointToSiteVPNGatewayStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PointToSiteVPNGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PointToSiteVPNGateway is the Schema for the PointToSiteVPNGateways API. Manages a Point-to-Site VPN Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PointToSiteVPNGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PointToSiteVPNGatewaySpec>, IStatus<V1beta1PointToSiteVPNGatewayStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PointToSiteVPNGateway";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "pointtositevpngateways";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PointToSiteVPNGatewaySpec defines the desired state of PointToSiteVPNGateway</summary>
    [JsonPropertyName("spec")]
    public V1beta1PointToSiteVPNGatewaySpec Spec { get; set; }

    /// <summary>PointToSiteVPNGatewayStatus defines the observed state of PointToSiteVPNGateway.</summary>
    [JsonPropertyName("status")]
    public V1beta1PointToSiteVPNGatewayStatus? Status { get; set; }
}
#nullable disable
