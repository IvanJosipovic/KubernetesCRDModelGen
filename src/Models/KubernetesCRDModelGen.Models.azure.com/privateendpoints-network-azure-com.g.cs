using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.com;
/// <summary>Reference: Resource ID.</summary>
public partial class V1api20220701storagePrivateEndpointSpecApplicationSecurityGroupsReference
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

/// <summary>Storage version of v1api20220701.ApplicationSecurityGroupSpec_PrivateEndpoint_SubResourceEmbedded An application security group in a resource group.</summary>
public partial class V1api20220701storagePrivateEndpointSpecApplicationSecurityGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storagePrivateEndpointSpecApplicationSecurityGroupsReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220701.ExtendedLocation ExtendedLocation complex type.</summary>
public partial class V1api20220701storagePrivateEndpointSpecExtendedLocation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20220701.PrivateEndpointIPConfiguration An IP Configuration of the private endpoint.</summary>
public partial class V1api20220701storagePrivateEndpointSpecIpConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("memberName")]
    public string? MemberName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }
}

/// <summary>Storage version of v1api20220701.PrivateLinkServiceConnectionState A collection of information about the state of the connection between service consumer and provider.</summary>
public partial class V1api20220701storagePrivateEndpointSpecManualPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("actionsRequired")]
    public string? ActionsRequired { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>PrivateLinkServiceReference: The resource id of private link service.</summary>
public partial class V1api20220701storagePrivateEndpointSpecManualPrivateLinkServiceConnectionsPrivateLinkServiceReference
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

/// <summary>Storage version of v1api20220701.PrivateLinkServiceConnection PrivateLinkServiceConnection resource.</summary>
public partial class V1api20220701storagePrivateEndpointSpecManualPrivateLinkServiceConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupIds")]
    public IList<string>? GroupIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20220701.PrivateLinkServiceConnectionState A collection of information about the state of the connection between service consumer and provider.</summary>
    [JsonPropertyName("privateLinkServiceConnectionState")]
    public V1api20220701storagePrivateEndpointSpecManualPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState? PrivateLinkServiceConnectionState { get; set; }

    /// <summary>PrivateLinkServiceReference: The resource id of private link service.</summary>
    [JsonPropertyName("privateLinkServiceReference")]
    public V1api20220701storagePrivateEndpointSpecManualPrivateLinkServiceConnectionsPrivateLinkServiceReference? PrivateLinkServiceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }
}

/// <summary>ConfigMapDestination describes the location to store a single configmap value Note: This is similar to SecretDestination in secrets.go. Changes to one should likely also be made to the other.</summary>
public partial class V1api20220701storagePrivateEndpointSpecOperatorSpecConfigMapsPrimaryNicPrivateIpAddress
{
    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes ConfigMap being referenced. The ConfigMap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20220701.PrivateEndpointOperatorConfigMaps</summary>
public partial class V1api20220701storagePrivateEndpointSpecOperatorSpecConfigMaps
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ConfigMapDestination describes the location to store a single configmap value Note: This is similar to SecretDestination in secrets.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("primaryNicPrivateIpAddress")]
    public V1api20220701storagePrivateEndpointSpecOperatorSpecConfigMapsPrimaryNicPrivateIpAddress? PrimaryNicPrivateIpAddress { get; set; }
}

/// <summary>Storage version of v1api20220701.PrivateEndpointOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
public partial class V1api20220701storagePrivateEndpointSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220701.PrivateEndpointOperatorConfigMaps</summary>
    [JsonPropertyName("configMaps")]
    public V1api20220701storagePrivateEndpointSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
public partial class V1api20220701storagePrivateEndpointSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220701.PrivateLinkServiceConnectionState A collection of information about the state of the connection between service consumer and provider.</summary>
public partial class V1api20220701storagePrivateEndpointSpecPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("actionsRequired")]
    public string? ActionsRequired { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>PrivateLinkServiceReference: The resource id of private link service.</summary>
public partial class V1api20220701storagePrivateEndpointSpecPrivateLinkServiceConnectionsPrivateLinkServiceReference
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

/// <summary>Storage version of v1api20220701.PrivateLinkServiceConnection PrivateLinkServiceConnection resource.</summary>
public partial class V1api20220701storagePrivateEndpointSpecPrivateLinkServiceConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupIds")]
    public IList<string>? GroupIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20220701.PrivateLinkServiceConnectionState A collection of information about the state of the connection between service consumer and provider.</summary>
    [JsonPropertyName("privateLinkServiceConnectionState")]
    public V1api20220701storagePrivateEndpointSpecPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState? PrivateLinkServiceConnectionState { get; set; }

    /// <summary>PrivateLinkServiceReference: The resource id of private link service.</summary>
    [JsonPropertyName("privateLinkServiceReference")]
    public V1api20220701storagePrivateEndpointSpecPrivateLinkServiceConnectionsPrivateLinkServiceReference? PrivateLinkServiceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
public partial class V1api20220701storagePrivateEndpointSpecSubnetReference
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

/// <summary>Storage version of v1api20220701.Subnet_PrivateEndpoint_SubResourceEmbedded Subnet in a virtual network resource.</summary>
public partial class V1api20220701storagePrivateEndpointSpecSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701storagePrivateEndpointSpecSubnetReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220701.PrivateEndpoint_Spec</summary>
public partial class V1api20220701storagePrivateEndpointSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V1api20220701storagePrivateEndpointSpecApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customNetworkInterfaceName")]
    public string? CustomNetworkInterfaceName { get; set; }

    /// <summary>Storage version of v1api20220701.ExtendedLocation ExtendedLocation complex type.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20220701storagePrivateEndpointSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20220701storagePrivateEndpointSpecIpConfigurations>? IpConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("manualPrivateLinkServiceConnections")]
    public IList<V1api20220701storagePrivateEndpointSpecManualPrivateLinkServiceConnections>? ManualPrivateLinkServiceConnections { get; set; }

    /// <summary>Storage version of v1api20220701.PrivateEndpointOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220701storagePrivateEndpointSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20220701storagePrivateEndpointSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkServiceConnections")]
    public IList<V1api20220701storagePrivateEndpointSpecPrivateLinkServiceConnections>? PrivateLinkServiceConnections { get; set; }

    /// <summary>Storage version of v1api20220701.Subnet_PrivateEndpoint_SubResourceEmbedded Subnet in a virtual network resource.</summary>
    [JsonPropertyName("subnet")]
    public V1api20220701storagePrivateEndpointSpecSubnet? Subnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Storage version of v1api20220701.ApplicationSecurityGroup_STATUS_PrivateEndpoint_SubResourceEmbedded An application security group in a resource group.</summary>
public partial class V1api20220701storagePrivateEndpointStatusApplicationSecurityGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20220701storagePrivateEndpointStatusConditions
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

/// <summary>Storage version of v1api20220701.CustomDnsConfigPropertiesFormat_STATUS Contains custom Dns resolution configuration from customer.</summary>
public partial class V1api20220701storagePrivateEndpointStatusCustomDnsConfigs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}

/// <summary>Storage version of v1api20220701.ExtendedLocation_STATUS ExtendedLocation complex type.</summary>
public partial class V1api20220701storagePrivateEndpointStatusExtendedLocation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20220701.PrivateEndpointIPConfiguration_STATUS An IP Configuration of the private endpoint.</summary>
public partial class V1api20220701storagePrivateEndpointStatusIpConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("memberName")]
    public string? MemberName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20220701.PrivateLinkServiceConnectionState_STATUS A collection of information about the state of the connection between service consumer and provider.</summary>
public partial class V1api20220701storagePrivateEndpointStatusManualPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("actionsRequired")]
    public string? ActionsRequired { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20220701.PrivateLinkServiceConnection_STATUS PrivateLinkServiceConnection resource.</summary>
public partial class V1api20220701storagePrivateEndpointStatusManualPrivateLinkServiceConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupIds")]
    public IList<string>? GroupIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20220701.PrivateLinkServiceConnectionState_STATUS A collection of information about the state of the connection between service consumer and provider.</summary>
    [JsonPropertyName("privateLinkServiceConnectionState")]
    public V1api20220701storagePrivateEndpointStatusManualPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState? PrivateLinkServiceConnectionState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkServiceId")]
    public string? PrivateLinkServiceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20220701.NetworkInterface_STATUS_PrivateEndpoint_SubResourceEmbedded A network interface in a resource group.</summary>
public partial class V1api20220701storagePrivateEndpointStatusNetworkInterfaces
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220701.PrivateLinkServiceConnectionState_STATUS A collection of information about the state of the connection between service consumer and provider.</summary>
public partial class V1api20220701storagePrivateEndpointStatusPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("actionsRequired")]
    public string? ActionsRequired { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20220701.PrivateLinkServiceConnection_STATUS PrivateLinkServiceConnection resource.</summary>
public partial class V1api20220701storagePrivateEndpointStatusPrivateLinkServiceConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupIds")]
    public IList<string>? GroupIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20220701.PrivateLinkServiceConnectionState_STATUS A collection of information about the state of the connection between service consumer and provider.</summary>
    [JsonPropertyName("privateLinkServiceConnectionState")]
    public V1api20220701storagePrivateEndpointStatusPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState? PrivateLinkServiceConnectionState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkServiceId")]
    public string? PrivateLinkServiceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20220701.Subnet_STATUS_PrivateEndpoint_SubResourceEmbedded Subnet in a virtual network resource.</summary>
public partial class V1api20220701storagePrivateEndpointStatusSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220701.PrivateEndpoint_STATUS_PrivateEndpoint_SubResourceEmbedded Private endpoint resource.</summary>
public partial class V1api20220701storagePrivateEndpointStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V1api20220701storagePrivateEndpointStatusApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220701storagePrivateEndpointStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customDnsConfigs")]
    public IList<V1api20220701storagePrivateEndpointStatusCustomDnsConfigs>? CustomDnsConfigs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customNetworkInterfaceName")]
    public string? CustomNetworkInterfaceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Storage version of v1api20220701.ExtendedLocation_STATUS ExtendedLocation complex type.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20220701storagePrivateEndpointStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20220701storagePrivateEndpointStatusIpConfigurations>? IpConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("manualPrivateLinkServiceConnections")]
    public IList<V1api20220701storagePrivateEndpointStatusManualPrivateLinkServiceConnections>? ManualPrivateLinkServiceConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1api20220701storagePrivateEndpointStatusNetworkInterfaces>? NetworkInterfaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkServiceConnections")]
    public IList<V1api20220701storagePrivateEndpointStatusPrivateLinkServiceConnections>? PrivateLinkServiceConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Storage version of v1api20220701.Subnet_STATUS_PrivateEndpoint_SubResourceEmbedded Subnet in a virtual network resource.</summary>
    [JsonPropertyName("subnet")]
    public V1api20220701storagePrivateEndpointStatusSubnet? Subnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20220701.PrivateEndpoint Generator information: - Generated from: /network/resource-manager/Microsoft.Network/stable/2022-07-01/privateEndpoint.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}</summary>
public partial class V1api20220701storagePrivateEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220701storagePrivateEndpointSpec>, IStatus<V1api20220701storagePrivateEndpointStatus>
{
    public const string KubeApiVersion = "v1api20220701storage";
    public const string KubeKind = "PrivateEndpoint";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "privateendpoints";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20220701.PrivateEndpoint_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20220701storagePrivateEndpointSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20220701.PrivateEndpoint_STATUS_PrivateEndpoint_SubResourceEmbedded Private endpoint resource.</summary>
    [JsonPropertyName("status")]
    public V1api20220701storagePrivateEndpointStatus? Status { get; set; }
}