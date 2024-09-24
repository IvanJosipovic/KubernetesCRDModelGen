using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.com;
/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a network.azure.com/PrivateDnsZone resource</summary>
public partial class V1api20200601storagePrivateDnsZonesVirtualNetworkLinkSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
public partial class V1api20200601storagePrivateDnsZonesVirtualNetworkLinkSpecVirtualNetworkReference
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

/// <summary>Storage version of v1api20200601.SubResource Reference to another subresource.</summary>
public partial class V1api20200601storagePrivateDnsZonesVirtualNetworkLinkSpecVirtualNetwork
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20200601storagePrivateDnsZonesVirtualNetworkLinkSpecVirtualNetworkReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20200601.PrivateDnsZones_VirtualNetworkLink_Spec</summary>
public partial class V1api20200601storagePrivateDnsZonesVirtualNetworkLinkSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a network.azure.com/PrivateDnsZone resource</summary>
    [JsonPropertyName("owner")]
    public V1api20200601storagePrivateDnsZonesVirtualNetworkLinkSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("registrationEnabled")]
    public bool? RegistrationEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Storage version of v1api20200601.SubResource Reference to another subresource.</summary>
    [JsonPropertyName("virtualNetwork")]
    public V1api20200601storagePrivateDnsZonesVirtualNetworkLinkSpecVirtualNetwork? VirtualNetwork { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20200601storagePrivateDnsZonesVirtualNetworkLinkStatusConditions
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

/// <summary>Storage version of v1api20200601.SubResource_STATUS Reference to another subresource.</summary>
public partial class V1api20200601storagePrivateDnsZonesVirtualNetworkLinkStatusVirtualNetwork
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20200601.PrivateDnsZones_VirtualNetworkLink_STATUS</summary>
public partial class V1api20200601storagePrivateDnsZonesVirtualNetworkLinkStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20200601storagePrivateDnsZonesVirtualNetworkLinkStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("registrationEnabled")]
    public bool? RegistrationEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Storage version of v1api20200601.SubResource_STATUS Reference to another subresource.</summary>
    [JsonPropertyName("virtualNetwork")]
    public V1api20200601storagePrivateDnsZonesVirtualNetworkLinkStatusVirtualNetwork? VirtualNetwork { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualNetworkLinkState")]
    public string? VirtualNetworkLinkState { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20200601.PrivateDnsZonesVirtualNetworkLink Generator information: - Generated from: /privatedns/resource-manager/Microsoft.Network/stable/2020-06-01/privatedns.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}/virtualNetworkLinks/{virtualNetworkLinkName}</summary>
public partial class V1api20200601storagePrivateDnsZonesVirtualNetworkLink : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20200601storagePrivateDnsZonesVirtualNetworkLinkSpec>, IStatus<V1api20200601storagePrivateDnsZonesVirtualNetworkLinkStatus>
{
    public const string KubeApiVersion = "v1api20200601storage";
    public const string KubeKind = "PrivateDnsZonesVirtualNetworkLink";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "privatednszonesvirtualnetworklinks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20200601.PrivateDnsZones_VirtualNetworkLink_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20200601storagePrivateDnsZonesVirtualNetworkLinkSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20200601.PrivateDnsZones_VirtualNetworkLink_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20200601storagePrivateDnsZonesVirtualNetworkLinkStatus? Status { get; set; }
}