using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.azure.com;
public partial class V1api20230101storageStorageAccountsFileServicesShareSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20230101storageStorageAccountsFileServicesShareSpecSignedIdentifiersAccessPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

public partial class V1api20230101storageStorageAccountsFileServicesShareSpecSignedIdentifiersReference
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

public partial class V1api20230101storageStorageAccountsFileServicesShareSpecSignedIdentifiers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.AccessPolicy</summary>
    [JsonPropertyName("accessPolicy")]
    public V1api20230101storageStorageAccountsFileServicesShareSpecSignedIdentifiersAccessPolicy? AccessPolicy { get; set; }

    /// <summary>Reference: An unique identifier of the stored access policy.</summary>
    [JsonPropertyName("reference")]
    public V1api20230101storageStorageAccountsFileServicesShareSpecSignedIdentifiersReference? Reference { get; set; }
}

public partial class V1api20230101storageStorageAccountsFileServicesShareSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accessTier")]
    public string? AccessTier { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledProtocols")]
    public string? EnabledProtocols { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a storage.azure.com/StorageAccountsFileService resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230101storageStorageAccountsFileServicesShareSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootSquash")]
    public string? RootSquash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("shareQuota")]
    public int? ShareQuota { get; set; }

    /// <summary></summary>
    [JsonPropertyName("signedIdentifiers")]
    public IList<V1api20230101storageStorageAccountsFileServicesShareSpecSignedIdentifiers>? SignedIdentifiers { get; set; }
}

public partial class V1api20230101storageStorageAccountsFileServicesShareStatusConditions
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

public partial class V1api20230101storageStorageAccountsFileServicesShareStatusSignedIdentifiersAccessPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

public partial class V1api20230101storageStorageAccountsFileServicesShareStatusSignedIdentifiers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230101.AccessPolicy_STATUS</summary>
    [JsonPropertyName("accessPolicy")]
    public V1api20230101storageStorageAccountsFileServicesShareStatusSignedIdentifiersAccessPolicy? AccessPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20230101storageStorageAccountsFileServicesShareStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accessTier")]
    public string? AccessTier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accessTierChangeTime")]
    public string? AccessTierChangeTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accessTierStatus")]
    public string? AccessTierStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230101storageStorageAccountsFileServicesShareStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deletedTime")]
    public string? DeletedTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabledProtocols")]
    public string? EnabledProtocols { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("leaseDuration")]
    public string? LeaseDuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("leaseState")]
    public string? LeaseState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("leaseStatus")]
    public string? LeaseStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remainingRetentionDays")]
    public int? RemainingRetentionDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootSquash")]
    public string? RootSquash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("shareQuota")]
    public int? ShareQuota { get; set; }

    /// <summary></summary>
    [JsonPropertyName("shareUsageBytes")]
    public int? ShareUsageBytes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("signedIdentifiers")]
    public IList<V1api20230101storageStorageAccountsFileServicesShareStatusSignedIdentifiers>? SignedIdentifiers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("snapshotTime")]
    public string? SnapshotTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230101storageStorageAccountsFileServicesShare : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230101storageStorageAccountsFileServicesShareSpec>, IStatus<V1api20230101storageStorageAccountsFileServicesShareStatus>
{
    public const string KubeApiVersion = "v1api20230101storage";
    public const string KubeKind = "StorageAccountsFileServicesShare";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsfileservicesshares";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230101.StorageAccounts_FileServices_Share_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230101storageStorageAccountsFileServicesShareSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230101.StorageAccounts_FileServices_Share_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20230101storageStorageAccountsFileServicesShareStatus? Status { get; set; }
}