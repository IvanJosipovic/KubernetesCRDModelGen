using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
public enum V1beta1VirtualHubConnectionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdRefPolicyResolutionEnum>))]
    public V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdRefPolicyResolveEnum>))]
    public V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdSelectorPolicyResolveEnum>))]
    public V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdRefPolicyResolutionEnum>))]
    public V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdRefPolicyResolveEnum>))]
    public V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdSelectorPolicyResolveEnum>))]
    public V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecForProviderRoutingPropagatedRouteTable
{
    /// <summary>The list of labels to assign to this route table.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>A list of Route Table IDs to associated with this Virtual Hub Connection.</summary>
    [JsonPropertyName("routeTableIds")]
    public IList<string>? RouteTableIds { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecForProviderRoutingStaticVnetRoute
{
    /// <summary>A list of CIDR Ranges which should be used as Address Prefixes.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>The name which should be used for this Static Route.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The IP Address which should be used for the Next Hop.</summary>
    [JsonPropertyName("nextHopIpAddress")]
    public string? NextHopIpAddress { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecForProviderRouting
{
    /// <summary>The ID of the route table associated with this Virtual Hub connection.</summary>
    [JsonPropertyName("associatedRouteTableId")]
    public string? AssociatedRouteTableId { get; set; }

    /// <summary>Reference to a VirtualHubRouteTable in network to populate associatedRouteTableId.</summary>
    [JsonPropertyName("associatedRouteTableIdRef")]
    public V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdRef? AssociatedRouteTableIdRef { get; set; }

    /// <summary>Selector for a VirtualHubRouteTable in network to populate associatedRouteTableId.</summary>
    [JsonPropertyName("associatedRouteTableIdSelector")]
    public V1beta1VirtualHubConnectionSpecForProviderRoutingAssociatedRouteTableIdSelector? AssociatedRouteTableIdSelector { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for inbound learned routes.</summary>
    [JsonPropertyName("inboundRouteMapId")]
    public string? InboundRouteMapId { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for outbound advertised routes.</summary>
    [JsonPropertyName("outboundRouteMapId")]
    public string? OutboundRouteMapId { get; set; }

    /// <summary>A propagated_route_table block as defined below.</summary>
    [JsonPropertyName("propagatedRouteTable")]
    public IList<V1beta1VirtualHubConnectionSpecForProviderRoutingPropagatedRouteTable>? PropagatedRouteTable { get; set; }

    /// <summary>The static VNet local route override criteria that is used to determine whether NVA in spoke VNet is bypassed for traffic with destination in spoke VNet. Possible values are Contains and Equal. Defaults to Contains. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("staticVnetLocalRouteOverrideCriteria")]
    public string? StaticVnetLocalRouteOverrideCriteria { get; set; }

    /// <summary>A static_vnet_route block as defined below.</summary>
    [JsonPropertyName("staticVnetRoute")]
    public IList<V1beta1VirtualHubConnectionSpecForProviderRoutingStaticVnetRoute>? StaticVnetRoute { get; set; }
}

public enum V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdRefPolicyResolutionEnum>))]
    public V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdRefPolicyResolveEnum>))]
    public V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdSelectorPolicyResolveEnum>))]
    public V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecForProvider
{
    /// <summary>Should Internet Security be enabled to secure internet traffic? Defaults to false.</summary>
    [JsonPropertyName("internetSecurityEnabled")]
    public bool? InternetSecurityEnabled { get; set; }

    /// <summary>The ID of the Virtual Network which the Virtual Hub should be connected to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("remoteVirtualNetworkId")]
    public string? RemoteVirtualNetworkId { get; set; }

    /// <summary>Reference to a VirtualNetwork in network to populate remoteVirtualNetworkId.</summary>
    [JsonPropertyName("remoteVirtualNetworkIdRef")]
    public V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdRef? RemoteVirtualNetworkIdRef { get; set; }

    /// <summary>Selector for a VirtualNetwork in network to populate remoteVirtualNetworkId.</summary>
    [JsonPropertyName("remoteVirtualNetworkIdSelector")]
    public V1beta1VirtualHubConnectionSpecForProviderRemoteVirtualNetworkIdSelector? RemoteVirtualNetworkIdSelector { get; set; }

    /// <summary>A routing block as defined below.</summary>
    [JsonPropertyName("routing")]
    public IList<V1beta1VirtualHubConnectionSpecForProviderRouting>? Routing { get; set; }

    /// <summary>The ID of the Virtual Hub within which this connection should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualHubId")]
    public string? VirtualHubId { get; set; }

    /// <summary>Reference to a VirtualHub in network to populate virtualHubId.</summary>
    [JsonPropertyName("virtualHubIdRef")]
    public V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdRef? VirtualHubIdRef { get; set; }

    /// <summary>Selector for a VirtualHub in network to populate virtualHubId.</summary>
    [JsonPropertyName("virtualHubIdSelector")]
    public V1beta1VirtualHubConnectionSpecForProviderVirtualHubIdSelector? VirtualHubIdSelector { get; set; }
}

public enum V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdRefPolicyResolutionEnum>))]
    public V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdRefPolicyResolveEnum>))]
    public V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdSelectorPolicyResolveEnum>))]
    public V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdRefPolicyResolutionEnum>))]
    public V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdRefPolicyResolveEnum>))]
    public V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdSelectorPolicyResolutionEnum>))]
    public V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdSelectorPolicyResolveEnum>))]
    public V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecInitProviderRoutingPropagatedRouteTable
{
    /// <summary>The list of labels to assign to this route table.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>A list of Route Table IDs to associated with this Virtual Hub Connection.</summary>
    [JsonPropertyName("routeTableIds")]
    public IList<string>? RouteTableIds { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecInitProviderRoutingStaticVnetRoute
{
    /// <summary>A list of CIDR Ranges which should be used as Address Prefixes.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>The name which should be used for this Static Route.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The IP Address which should be used for the Next Hop.</summary>
    [JsonPropertyName("nextHopIpAddress")]
    public string? NextHopIpAddress { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecInitProviderRouting
{
    /// <summary>The ID of the route table associated with this Virtual Hub connection.</summary>
    [JsonPropertyName("associatedRouteTableId")]
    public string? AssociatedRouteTableId { get; set; }

    /// <summary>Reference to a VirtualHubRouteTable in network to populate associatedRouteTableId.</summary>
    [JsonPropertyName("associatedRouteTableIdRef")]
    public V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdRef? AssociatedRouteTableIdRef { get; set; }

    /// <summary>Selector for a VirtualHubRouteTable in network to populate associatedRouteTableId.</summary>
    [JsonPropertyName("associatedRouteTableIdSelector")]
    public V1beta1VirtualHubConnectionSpecInitProviderRoutingAssociatedRouteTableIdSelector? AssociatedRouteTableIdSelector { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for inbound learned routes.</summary>
    [JsonPropertyName("inboundRouteMapId")]
    public string? InboundRouteMapId { get; set; }

    /// <summary>The resource ID of the Route Map associated with this Routing Configuration for outbound advertised routes.</summary>
    [JsonPropertyName("outboundRouteMapId")]
    public string? OutboundRouteMapId { get; set; }

    /// <summary>A propagated_route_table block as defined below.</summary>
    [JsonPropertyName("propagatedRouteTable")]
    public IList<V1beta1VirtualHubConnectionSpecInitProviderRoutingPropagatedRouteTable>? PropagatedRouteTable { get; set; }

    /// <summary>The static VNet local route override criteria that is used to determine whether NVA in spoke VNet is bypassed for traffic with destination in spoke VNet. Possible values are Contains and Equal. Defaults to Contains. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("staticVnetLocalRouteOverrideCriteria")]
    public string? StaticVnetLocalRouteOverrideCriteria { get; set; }

    /// <summary>A static_vnet_route block as defined below.</summary>
    [JsonPropertyName("staticVnetRoute")]
    public IList<V1beta1VirtualHubConnectionSpecInitProviderRoutingStaticVnetRoute>? StaticVnetRoute { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecInitProvider
{
    /// <summary>Should Internet Security be enabled to secure internet traffic? Defaults to false.</summary>
    [JsonPropertyName("internetSecurityEnabled")]
    public bool? InternetSecurityEnabled { get; set; }

    /// <summary>The ID of the Virtual Network which the Virtual Hub should be connected to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("remoteVirtualNetworkId")]
    public string? RemoteVirtualNetworkId { get; set; }

    /// <summary>Reference to a VirtualNetwork in network to populate remoteVirtualNetworkId.</summary>
    [JsonPropertyName("remoteVirtualNetworkIdRef")]
    public V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdRef? RemoteVirtualNetworkIdRef { get; set; }

    /// <summary>Selector for a VirtualNetwork in network to populate remoteVirtualNetworkId.</summary>
    [JsonPropertyName("remoteVirtualNetworkIdSelector")]
    public V1beta1VirtualHubConnectionSpecInitProviderRemoteVirtualNetworkIdSelector? RemoteVirtualNetworkIdSelector { get; set; }

    /// <summary>A routing block as defined below.</summary>
    [JsonPropertyName("routing")]
    public IList<V1beta1VirtualHubConnectionSpecInitProviderRouting>? Routing { get; set; }
}

public enum V1beta1VirtualHubConnectionSpecManagementPoliciesEnum
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

public enum V1beta1VirtualHubConnectionSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubConnectionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubConnectionSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1VirtualHubConnectionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1VirtualHubConnectionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubConnectionSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1VirtualHubConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VirtualHubConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1VirtualHubConnectionSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1VirtualHubConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1VirtualHubConnectionSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualHubConnectionSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1VirtualHubConnectionSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VirtualHubConnectionSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VirtualHubConnectionSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1VirtualHubConnectionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualHubConnectionSpecDeletionPolicyEnum>))]
    public V1beta1VirtualHubConnectionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VirtualHubConnectionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VirtualHubConnectionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VirtualHubConnectionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VirtualHubConnectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VirtualHubConnectionSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VirtualHubConnectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1VirtualHubConnectionStatusAtProviderRoutingPropagatedRouteTable
{
    /// <summary>The list of labels to assign to this route table.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>A list of Route Table IDs to associated with this Virtual Hub Connection.</summary>
    [JsonPropertyName("routeTableIds")]
    public IList<string>? RouteTableIds { get; set; }
}

public partial class V1beta1VirtualHubConnectionStatusAtProviderRoutingStaticVnetRoute
{
    /// <summary>A list of CIDR Ranges which should be used as Address Prefixes.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>The name which should be used for this Static Route.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The IP Address which should be used for the Next Hop.</summary>
    [JsonPropertyName("nextHopIpAddress")]
    public string? NextHopIpAddress { get; set; }
}

public partial class V1beta1VirtualHubConnectionStatusAtProviderRouting
{
    /// <summary>The ID of the route table associated with this Virtual Hub connection.</summary>
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
    public IList<V1beta1VirtualHubConnectionStatusAtProviderRoutingPropagatedRouteTable>? PropagatedRouteTable { get; set; }

    /// <summary>The static VNet local route override criteria that is used to determine whether NVA in spoke VNet is bypassed for traffic with destination in spoke VNet. Possible values are Contains and Equal. Defaults to Contains. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("staticVnetLocalRouteOverrideCriteria")]
    public string? StaticVnetLocalRouteOverrideCriteria { get; set; }

    /// <summary>A static_vnet_route block as defined below.</summary>
    [JsonPropertyName("staticVnetRoute")]
    public IList<V1beta1VirtualHubConnectionStatusAtProviderRoutingStaticVnetRoute>? StaticVnetRoute { get; set; }
}

public partial class V1beta1VirtualHubConnectionStatusAtProvider
{
    /// <summary>The ID of the Virtual Hub Connection.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Should Internet Security be enabled to secure internet traffic? Defaults to false.</summary>
    [JsonPropertyName("internetSecurityEnabled")]
    public bool? InternetSecurityEnabled { get; set; }

    /// <summary>The ID of the Virtual Network which the Virtual Hub should be connected to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("remoteVirtualNetworkId")]
    public string? RemoteVirtualNetworkId { get; set; }

    /// <summary>A routing block as defined below.</summary>
    [JsonPropertyName("routing")]
    public IList<V1beta1VirtualHubConnectionStatusAtProviderRouting>? Routing { get; set; }

    /// <summary>The ID of the Virtual Hub within which this connection should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualHubId")]
    public string? VirtualHubId { get; set; }
}

public partial class V1beta1VirtualHubConnectionStatusConditions
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

public partial class V1beta1VirtualHubConnectionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VirtualHubConnectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VirtualHubConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualHubConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VirtualHubConnectionSpec>, IStatus<V1beta1VirtualHubConnectionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualHubConnection";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "virtualhubconnections";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VirtualHubConnectionSpec defines the desired state of VirtualHubConnection</summary>
    [JsonPropertyName("spec")]
    public V1beta1VirtualHubConnectionSpec Spec { get; set; }

    /// <summary>VirtualHubConnectionStatus defines the observed state of VirtualHubConnection.</summary>
    [JsonPropertyName("status")]
    public V1beta1VirtualHubConnectionStatus? Status { get; set; }
}