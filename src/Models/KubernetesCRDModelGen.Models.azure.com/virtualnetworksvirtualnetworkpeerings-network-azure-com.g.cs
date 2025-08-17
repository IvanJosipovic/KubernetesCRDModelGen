using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.com;
#nullable enable
/// <summary>Storage version of v1api20240301.VirtualNetworksVirtualNetworkPeering Generator information: - Generated from: /network/resource-manager/Microsoft.Network/stable/2024-03-01/virtualNetwork.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringList : IKubernetesObject<V1ListMeta>, IItems<V1api20240301storageVirtualNetworksVirtualNetworkPeering>
{
    public const string KubeApiVersion = "v1api20240301storage";
    public const string KubeKind = "VirtualNetworksVirtualNetworkPeeringList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworksvirtualnetworkpeerings";
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
    public IList<V1api20240301storageVirtualNetworksVirtualNetworkPeering> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecLocalAddressSpace
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecLocalVirtualNetworkAddressSpace
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecOperatorSpecSecretExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.VirtualNetworksVirtualNetworkPeeringOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a network.azure.com/VirtualNetwork resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpace
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.VirtualNetworkBgpCommunities Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteBgpCommunities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualNetworkCommunity")]
    public string? VirtualNetworkCommunity { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SubResource Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetwork
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkAddressSpace
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.VirtualNetworksVirtualNetworkPeering_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowForwardedTraffic")]
    public bool? AllowForwardedTraffic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowGatewayTransit")]
    public bool? AllowGatewayTransit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowVirtualNetworkAccess")]
    public bool? AllowVirtualNetworkAccess { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("doNotVerifyRemoteGateways")]
    public bool? DoNotVerifyRemoteGateways { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableOnlyIPv6Peering")]
    public bool? EnableOnlyIPv6Peering { get; set; }

    /// <summary>Storage version of v1api20240301.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("localAddressSpace")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecLocalAddressSpace? LocalAddressSpace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSubnetNames")]
    public IList<string>? LocalSubnetNames { get; set; }

    /// <summary>Storage version of v1api20240301.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("localVirtualNetworkAddressSpace")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecLocalVirtualNetworkAddressSpace? LocalVirtualNetworkAddressSpace { get; set; }

    /// <summary>Storage version of v1api20240301.VirtualNetworksVirtualNetworkPeeringOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a network.azure.com/VirtualNetwork resource</summary>
    [JsonPropertyName("owner")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("peerCompleteVnets")]
    public bool? PeerCompleteVnets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("peeringState")]
    public string? PeeringState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("peeringSyncLevel")]
    public string? PeeringSyncLevel { get; set; }

    /// <summary>Storage version of v1api20240301.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("remoteAddressSpace")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpace? RemoteAddressSpace { get; set; }

    /// <summary>Storage version of v1api20240301.VirtualNetworkBgpCommunities Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET.</summary>
    [JsonPropertyName("remoteBgpCommunities")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteBgpCommunities? RemoteBgpCommunities { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteSubnetNames")]
    public IList<string>? RemoteSubnetNames { get; set; }

    /// <summary>Storage version of v1api20240301.SubResource Reference to another subresource.</summary>
    [JsonPropertyName("remoteVirtualNetwork")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetwork? RemoteVirtualNetwork { get; set; }

    /// <summary>Storage version of v1api20240301.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("remoteVirtualNetworkAddressSpace")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkAddressSpace? RemoteVirtualNetworkAddressSpace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useRemoteGateways")]
    public bool? UseRemoteGateways { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusLocalAddressSpace
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusLocalVirtualNetworkAddressSpace
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteAddressSpace
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.VirtualNetworkBgpCommunities_STATUS Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteBgpCommunities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("regionalCommunity")]
    public string? RegionalCommunity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualNetworkCommunity")]
    public string? VirtualNetworkCommunity { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.SubResource_STATUS Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetwork
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkAddressSpace
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.VirtualNetworkEncryption_STATUS Indicates if encryption is enabled on virtual network and if VM without encryption is allowed in encrypted VNet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkEncryption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enforcement")]
    public string? Enforcement { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.VirtualNetworksVirtualNetworkPeering_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowForwardedTraffic")]
    public bool? AllowForwardedTraffic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowGatewayTransit")]
    public bool? AllowGatewayTransit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowVirtualNetworkAccess")]
    public bool? AllowVirtualNetworkAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("doNotVerifyRemoteGateways")]
    public bool? DoNotVerifyRemoteGateways { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableOnlyIPv6Peering")]
    public bool? EnableOnlyIPv6Peering { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20240301.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("localAddressSpace")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusLocalAddressSpace? LocalAddressSpace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSubnetNames")]
    public IList<string>? LocalSubnetNames { get; set; }

    /// <summary>Storage version of v1api20240301.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("localVirtualNetworkAddressSpace")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusLocalVirtualNetworkAddressSpace? LocalVirtualNetworkAddressSpace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("peerCompleteVnets")]
    public bool? PeerCompleteVnets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("peeringState")]
    public string? PeeringState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("peeringSyncLevel")]
    public string? PeeringSyncLevel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Storage version of v1api20240301.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("remoteAddressSpace")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteAddressSpace? RemoteAddressSpace { get; set; }

    /// <summary>Storage version of v1api20240301.VirtualNetworkBgpCommunities_STATUS Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET.</summary>
    [JsonPropertyName("remoteBgpCommunities")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteBgpCommunities? RemoteBgpCommunities { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteSubnetNames")]
    public IList<string>? RemoteSubnetNames { get; set; }

    /// <summary>Storage version of v1api20240301.SubResource_STATUS Reference to another subresource.</summary>
    [JsonPropertyName("remoteVirtualNetwork")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetwork? RemoteVirtualNetwork { get; set; }

    /// <summary>Storage version of v1api20240301.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("remoteVirtualNetworkAddressSpace")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkAddressSpace? RemoteVirtualNetworkAddressSpace { get; set; }

    /// <summary>Storage version of v1api20240301.VirtualNetworkEncryption_STATUS Indicates if encryption is enabled on virtual network and if VM without encryption is allowed in encrypted VNet.</summary>
    [JsonPropertyName("remoteVirtualNetworkEncryption")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkEncryption? RemoteVirtualNetworkEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useRemoteGateways")]
    public bool? UseRemoteGateways { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240301.VirtualNetworksVirtualNetworkPeering Generator information: - Generated from: /network/resource-manager/Microsoft.Network/stable/2024-03-01/virtualNetwork.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301storageVirtualNetworksVirtualNetworkPeering : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpec>, IStatus<V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatus>
{
    public const string KubeApiVersion = "v1api20240301storage";
    public const string KubeKind = "VirtualNetworksVirtualNetworkPeering";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworksvirtualnetworkpeerings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240301.VirtualNetworksVirtualNetworkPeering_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240301.VirtualNetworksVirtualNetworkPeering_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240301storageVirtualNetworksVirtualNetworkPeeringStatus? Status { get; set; }
}
#nullable disable
