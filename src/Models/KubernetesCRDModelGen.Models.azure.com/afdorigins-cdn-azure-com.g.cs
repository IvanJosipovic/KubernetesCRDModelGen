using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.com;
/// <summary>Reference: Resource ID.</summary>
public partial class V1api20230501storageAfdOriginSpecAzureOriginReference
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

/// <summary>Storage version of v1api20230501.ResourceReference Reference to another resource.</summary>
public partial class V1api20230501storageAfdOriginSpecAzureOrigin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501storageAfdOriginSpecAzureOriginReference? Reference { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a cdn.azure.com/AfdOriginGroup resource</summary>
public partial class V1api20230501storageAfdOriginSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
public partial class V1api20230501storageAfdOriginSpecSharedPrivateLinkResourcePrivateLinkReference
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

/// <summary>Storage version of v1api20230501.ResourceReference Reference to another resource.</summary>
public partial class V1api20230501storageAfdOriginSpecSharedPrivateLinkResourcePrivateLink
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501storageAfdOriginSpecSharedPrivateLinkResourcePrivateLinkReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20230501.SharedPrivateLinkResourceProperties Describes the properties of an existing Shared Private Link Resource to use when connecting to a private origin.</summary>
public partial class V1api20230501storageAfdOriginSpecSharedPrivateLinkResource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Storage version of v1api20230501.ResourceReference Reference to another resource.</summary>
    [JsonPropertyName("privateLink")]
    public V1api20230501storageAfdOriginSpecSharedPrivateLinkResourcePrivateLink? PrivateLink { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkLocation")]
    public string? PrivateLinkLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20230501.Profiles_OriginGroups_Origin_Spec</summary>
public partial class V1api20230501storageAfdOriginSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20230501.ResourceReference Reference to another resource.</summary>
    [JsonPropertyName("azureOrigin")]
    public V1api20230501storageAfdOriginSpecAzureOrigin? AzureOrigin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enforceCertificateNameCheck")]
    public bool? EnforceCertificateNameCheck { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpPort")]
    public int? HttpPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpsPort")]
    public int? HttpsPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a cdn.azure.com/AfdOriginGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230501storageAfdOriginSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Storage version of v1api20230501.SharedPrivateLinkResourceProperties Describes the properties of an existing Shared Private Link Resource to use when connecting to a private origin.</summary>
    [JsonPropertyName("sharedPrivateLinkResource")]
    public V1api20230501storageAfdOriginSpecSharedPrivateLinkResource? SharedPrivateLinkResource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
public partial class V1api20230501storageAfdOriginStatusAzureOrigin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20230501storageAfdOriginStatusConditions
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

/// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
public partial class V1api20230501storageAfdOriginStatusSharedPrivateLinkResourcePrivateLink
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20230501.SharedPrivateLinkResourceProperties_STATUS Describes the properties of an existing Shared Private Link Resource to use when connecting to a private origin.</summary>
public partial class V1api20230501storageAfdOriginStatusSharedPrivateLinkResource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
    [JsonPropertyName("privateLink")]
    public V1api20230501storageAfdOriginStatusSharedPrivateLinkResourcePrivateLink? PrivateLink { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkLocation")]
    public string? PrivateLinkLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20230501.SystemData_STATUS Read only system data</summary>
public partial class V1api20230501storageAfdOriginStatusSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20230501.Profiles_OriginGroups_Origin_STATUS</summary>
public partial class V1api20230501storageAfdOriginStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230501.ResourceReference_STATUS Reference to another resource.</summary>
    [JsonPropertyName("azureOrigin")]
    public V1api20230501storageAfdOriginStatusAzureOrigin? AzureOrigin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230501storageAfdOriginStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deploymentStatus")]
    public string? DeploymentStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enforceCertificateNameCheck")]
    public bool? EnforceCertificateNameCheck { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpPort")]
    public int? HttpPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpsPort")]
    public int? HttpsPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originGroupName")]
    public string? OriginGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Storage version of v1api20230501.SharedPrivateLinkResourceProperties_STATUS Describes the properties of an existing Shared Private Link Resource to use when connecting to a private origin.</summary>
    [JsonPropertyName("sharedPrivateLinkResource")]
    public V1api20230501storageAfdOriginStatusSharedPrivateLinkResource? SharedPrivateLinkResource { get; set; }

    /// <summary>Storage version of v1api20230501.SystemData_STATUS Read only system data</summary>
    [JsonPropertyName("systemData")]
    public V1api20230501storageAfdOriginStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20230501.AfdOrigin Generator information: - Generated from: /cdn/resource-manager/Microsoft.Cdn/stable/2023-05-01/afdx.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/origins/{originName}</summary>
public partial class V1api20230501storageAfdOrigin : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230501storageAfdOriginSpec>, IStatus<V1api20230501storageAfdOriginStatus>
{
    public const string KubeApiVersion = "v1api20230501storage";
    public const string KubeKind = "AfdOrigin";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "afdorigins";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230501.Profiles_OriginGroups_Origin_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230501storageAfdOriginSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230501.Profiles_OriginGroups_Origin_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20230501storageAfdOriginStatus? Status { get; set; }
}