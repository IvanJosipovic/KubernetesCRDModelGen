using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.com;
public partial class V1api20201101storageVirtualNetworksSubnetSpecApplicationGatewayIpConfigurationsReference
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

public partial class V1api20201101storageVirtualNetworksSubnetSpecApplicationGatewayIpConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageVirtualNetworksSubnetSpecApplicationGatewayIpConfigurationsReference? Reference { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetSpecDelegations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetSpecIpAllocationsReference
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

public partial class V1api20201101storageVirtualNetworksSubnetSpecIpAllocations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageVirtualNetworksSubnetSpecIpAllocationsReference? Reference { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetSpecNatGatewayReference
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

public partial class V1api20201101storageVirtualNetworksSubnetSpecNatGateway
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageVirtualNetworksSubnetSpecNatGatewayReference? Reference { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetSpecNetworkSecurityGroupReference
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

public partial class V1api20201101storageVirtualNetworksSubnetSpecNetworkSecurityGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageVirtualNetworksSubnetSpecNetworkSecurityGroupReference? Reference { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetSpecRouteTableReference
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

public partial class V1api20201101storageVirtualNetworksSubnetSpecRouteTable
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageVirtualNetworksSubnetSpecRouteTableReference? Reference { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetSpecServiceEndpointPoliciesReference
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

public partial class V1api20201101storageVirtualNetworksSubnetSpecServiceEndpointPolicies
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageVirtualNetworksSubnetSpecServiceEndpointPoliciesReference? Reference { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetSpecServiceEndpoints
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefix")]
    public string? AddressPrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationGatewayIpConfigurations")]
    public IList<V1api20201101storageVirtualNetworksSubnetSpecApplicationGatewayIpConfigurations>? ApplicationGatewayIpConfigurations { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("delegations")]
    public IList<V1api20201101storageVirtualNetworksSubnetSpecDelegations>? Delegations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipAllocations")]
    public IList<V1api20201101storageVirtualNetworksSubnetSpecIpAllocations>? IpAllocations { get; set; }

    /// <summary>Storage version of v1api20201101.SubResource Reference to another subresource.</summary>
    [JsonPropertyName("natGateway")]
    public V1api20201101storageVirtualNetworksSubnetSpecNatGateway? NatGateway { get; set; }

    /// <summary>Storage version of v1api20201101.NetworkSecurityGroupSpec_VirtualNetworks_Subnet_SubResourceEmbedded NetworkSecurityGroup resource.</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V1api20201101storageVirtualNetworksSubnetSpecNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a network.azure.com/VirtualNetwork resource</summary>
    [JsonPropertyName("owner")]
    public V1api20201101storageVirtualNetworksSubnetSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointNetworkPolicies")]
    public string? PrivateEndpointNetworkPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkServiceNetworkPolicies")]
    public string? PrivateLinkServiceNetworkPolicies { get; set; }

    /// <summary>Storage version of v1api20201101.RouteTableSpec_VirtualNetworks_Subnet_SubResourceEmbedded Route table resource.</summary>
    [JsonPropertyName("routeTable")]
    public V1api20201101storageVirtualNetworksSubnetSpecRouteTable? RouteTable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceEndpointPolicies")]
    public IList<V1api20201101storageVirtualNetworksSubnetSpecServiceEndpointPolicies>? ServiceEndpointPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceEndpoints")]
    public IList<V1api20201101storageVirtualNetworksSubnetSpecServiceEndpoints>? ServiceEndpoints { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetStatusApplicationGatewayIpConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetStatusConditions
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

public partial class V1api20201101storageVirtualNetworksSubnetStatusDelegations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetStatusIpAllocations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetStatusIpConfigurationProfiles
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetStatusIpConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetStatusNatGateway
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetStatusNetworkSecurityGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetStatusPrivateEndpoints
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetStatusResourceNavigationLinks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetStatusRouteTable
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetStatusServiceAssociationLinks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetStatusServiceEndpointPolicies
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetStatusServiceEndpoints
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

public partial class V1api20201101storageVirtualNetworksSubnetStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefix")]
    public string? AddressPrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationGatewayIpConfigurations")]
    public IList<V1api20201101storageVirtualNetworksSubnetStatusApplicationGatewayIpConfigurations>? ApplicationGatewayIpConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20201101storageVirtualNetworksSubnetStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("delegations")]
    public IList<V1api20201101storageVirtualNetworksSubnetStatusDelegations>? Delegations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipAllocations")]
    public IList<V1api20201101storageVirtualNetworksSubnetStatusIpAllocations>? IpAllocations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfigurationProfiles")]
    public IList<V1api20201101storageVirtualNetworksSubnetStatusIpConfigurationProfiles>? IpConfigurationProfiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20201101storageVirtualNetworksSubnetStatusIpConfigurations>? IpConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20201101.SubResource_STATUS Reference to another subresource.</summary>
    [JsonPropertyName("natGateway")]
    public V1api20201101storageVirtualNetworksSubnetStatusNatGateway? NatGateway { get; set; }

    /// <summary>Storage version of v1api20201101.NetworkSecurityGroup_STATUS_VirtualNetworks_Subnet_SubResourceEmbedded NetworkSecurityGroup resource.</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V1api20201101storageVirtualNetworksSubnetStatusNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointNetworkPolicies")]
    public string? PrivateEndpointNetworkPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpoints")]
    public IList<V1api20201101storageVirtualNetworksSubnetStatusPrivateEndpoints>? PrivateEndpoints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkServiceNetworkPolicies")]
    public string? PrivateLinkServiceNetworkPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceNavigationLinks")]
    public IList<V1api20201101storageVirtualNetworksSubnetStatusResourceNavigationLinks>? ResourceNavigationLinks { get; set; }

    /// <summary>Storage version of v1api20201101.RouteTable_STATUS_SubResourceEmbedded Route table resource.</summary>
    [JsonPropertyName("routeTable")]
    public V1api20201101storageVirtualNetworksSubnetStatusRouteTable? RouteTable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAssociationLinks")]
    public IList<V1api20201101storageVirtualNetworksSubnetStatusServiceAssociationLinks>? ServiceAssociationLinks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceEndpointPolicies")]
    public IList<V1api20201101storageVirtualNetworksSubnetStatusServiceEndpointPolicies>? ServiceEndpointPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceEndpoints")]
    public IList<V1api20201101storageVirtualNetworksSubnetStatusServiceEndpoints>? ServiceEndpoints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201101storageVirtualNetworksSubnet : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20201101storageVirtualNetworksSubnetSpec>, IStatus<V1api20201101storageVirtualNetworksSubnetStatus>
{
    public const string KubeApiVersion = "v1api20201101storage";
    public const string KubeKind = "VirtualNetworksSubnet";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworkssubnets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20201101.VirtualNetworks_Subnet_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20201101storageVirtualNetworksSubnetSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20201101.VirtualNetworks_Subnet_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20201101storageVirtualNetworksSubnetStatus? Status { get; set; }
}