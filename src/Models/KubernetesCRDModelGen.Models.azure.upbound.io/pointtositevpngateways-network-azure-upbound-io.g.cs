using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
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

/// <summary></summary>
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
    public IList<V1beta1PointToSiteVPNGatewaySpecForProviderConnectionConfigurationRoutePropagatedRouteTable>? PropagatedRouteTable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderConnectionConfigurationVpnClientAddressPool
{
    /// <summary>A list of CIDR Ranges which should be used as Address Prefixes.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

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
    public IList<V1beta1PointToSiteVPNGatewaySpecForProviderConnectionConfigurationRoute>? Route { get; set; }

    /// <summary>A vpn_client_address_pool block as defined below.</summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public IList<V1beta1PointToSiteVPNGatewaySpecForProviderConnectionConfigurationVpnClientAddressPool>? VpnClientAddressPool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdRefPolicyResolutionEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdRefPolicyResolveEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualHub in network to populate virtualHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdSelectorPolicyResolutionEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdSelectorPolicyResolveEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVirtualHubIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdRefPolicyResolutionEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdRefPolicyResolveEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPNServerConfiguration in network to populate vpnServerConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdSelectorPolicyResolutionEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdSelectorPolicyResolveEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecForProviderVpnServerConfigurationIdSelectorPolicy? Policy { get; set; }
}

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

/// <summary></summary>
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

/// <summary></summary>
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
    public IList<V1beta1PointToSiteVPNGatewaySpecInitProviderConnectionConfigurationRoutePropagatedRouteTable>? PropagatedRouteTable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderConnectionConfigurationVpnClientAddressPool
{
    /// <summary>A list of CIDR Ranges which should be used as Address Prefixes.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

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
    public IList<V1beta1PointToSiteVPNGatewaySpecInitProviderConnectionConfigurationRoute>? Route { get; set; }

    /// <summary>A vpn_client_address_pool block as defined below.</summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public IList<V1beta1PointToSiteVPNGatewaySpecInitProviderConnectionConfigurationVpnClientAddressPool>? VpnClientAddressPool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdRefPolicyResolutionEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdRefPolicyResolveEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualHub in network to populate virtualHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdSelectorPolicyResolutionEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdSelectorPolicyResolveEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVirtualHubIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdRefPolicyResolutionEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdRefPolicyResolveEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VPNServerConfiguration in network to populate vpnServerConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdSelectorPolicyResolutionEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdSelectorPolicyResolveEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecInitProviderVpnServerConfigurationIdSelectorPolicy? Policy { get; set; }
}

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PointToSiteVPNGatewaySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PointToSiteVPNGatewaySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1PointToSiteVPNGatewaySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PointToSiteVPNGatewaySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PointToSiteVPNGatewaySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PointToSiteVPNGatewaySpec defines the desired state of PointToSiteVPNGateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewaySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PointToSiteVPNGatewaySpecDeletionPolicyEnum>))]
    public V1beta1PointToSiteVPNGatewaySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PointToSiteVPNGatewaySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PointToSiteVPNGatewaySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PointToSiteVPNGatewaySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PointToSiteVPNGatewaySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PointToSiteVPNGatewaySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PointToSiteVPNGatewaySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
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

/// <summary></summary>
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
    public IList<V1beta1PointToSiteVPNGatewayStatusAtProviderConnectionConfigurationRoutePropagatedRouteTable>? PropagatedRouteTable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PointToSiteVPNGatewayStatusAtProviderConnectionConfigurationVpnClientAddressPool
{
    /// <summary>A list of CIDR Ranges which should be used as Address Prefixes.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

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
    public IList<V1beta1PointToSiteVPNGatewayStatusAtProviderConnectionConfigurationRoute>? Route { get; set; }

    /// <summary>A vpn_client_address_pool block as defined below.</summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public IList<V1beta1PointToSiteVPNGatewayStatusAtProviderConnectionConfigurationVpnClientAddressPool>? VpnClientAddressPool { get; set; }
}

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

/// <summary>PointToSiteVPNGateway is the Schema for the PointToSiteVPNGateways API. Manages a Point-to-Site VPN Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PointToSiteVPNGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PointToSiteVPNGatewaySpec>, IStatus<V1beta1PointToSiteVPNGatewayStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PointToSiteVPNGateway";
    public const string KubeGroup = "network.azure.upbound.io";
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