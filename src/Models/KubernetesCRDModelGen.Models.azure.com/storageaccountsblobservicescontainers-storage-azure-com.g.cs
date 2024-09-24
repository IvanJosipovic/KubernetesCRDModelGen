using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.azure.com;
public partial class V1api20230101storageStorageAccountsBlobServicesContainerSpecImmutableStorageWithVersioning
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1api20230101storageStorageAccountsBlobServicesContainerSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20230101storageStorageAccountsBlobServicesContainerSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultEncryptionScope")]
    public string? DefaultEncryptionScope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("denyEncryptionScopeOverride")]
    public bool? DenyEncryptionScopeOverride { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableNfsV3AllSquash")]
    public bool? EnableNfsV3AllSquash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableNfsV3RootSquash")]
    public bool? EnableNfsV3RootSquash { get; set; }

    /// <summary>Storage version of v1api20230101.ImmutableStorageWithVersioning Object level immutability properties of the container.</summary>
    [JsonPropertyName("immutableStorageWithVersioning")]
    public V1api20230101storageStorageAccountsBlobServicesContainerSpecImmutableStorageWithVersioning? ImmutableStorageWithVersioning { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a storage.azure.com/StorageAccountsBlobService resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230101storageStorageAccountsBlobServicesContainerSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicAccess")]
    public string? PublicAccess { get; set; }
}

public partial class V1api20230101storageStorageAccountsBlobServicesContainerStatusConditions
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

public partial class V1api20230101storageStorageAccountsBlobServicesContainerStatusImmutabilityPolicyUpdateHistory
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowProtectedAppendWrites")]
    public bool? AllowProtectedAppendWrites { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowProtectedAppendWritesAll")]
    public bool? AllowProtectedAppendWritesAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("immutabilityPeriodSinceCreationInDays")]
    public int? ImmutabilityPeriodSinceCreationInDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectIdentifier")]
    public string? ObjectIdentifier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("update")]
    public string? Update { get; set; }

    /// <summary></summary>
    [JsonPropertyName("upn")]
    public string? Upn { get; set; }
}

public partial class V1api20230101storageStorageAccountsBlobServicesContainerStatusImmutabilityPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowProtectedAppendWrites")]
    public bool? AllowProtectedAppendWrites { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowProtectedAppendWritesAll")]
    public bool? AllowProtectedAppendWritesAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("immutabilityPeriodSinceCreationInDays")]
    public int? ImmutabilityPeriodSinceCreationInDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updateHistory")]
    public IList<V1api20230101storageStorageAccountsBlobServicesContainerStatusImmutabilityPolicyUpdateHistory>? UpdateHistory { get; set; }
}

public partial class V1api20230101storageStorageAccountsBlobServicesContainerStatusImmutableStorageWithVersioning
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("migrationState")]
    public string? MigrationState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeStamp")]
    public string? TimeStamp { get; set; }
}

public partial class V1api20230101storageStorageAccountsBlobServicesContainerStatusLegalHoldProtectedAppendWritesHistory
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowProtectedAppendWritesAll")]
    public bool? AllowProtectedAppendWritesAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }
}

public partial class V1api20230101storageStorageAccountsBlobServicesContainerStatusLegalHoldTags
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectIdentifier")]
    public string? ObjectIdentifier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("upn")]
    public string? Upn { get; set; }
}

public partial class V1api20230101storageStorageAccountsBlobServicesContainerStatusLegalHold
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hasLegalHold")]
    public bool? HasLegalHold { get; set; }

    /// <summary>Storage version of v1api20230101.ProtectedAppendWritesHistory_STATUS Protected append writes history setting for the blob container with Legal holds.</summary>
    [JsonPropertyName("protectedAppendWritesHistory")]
    public V1api20230101storageStorageAccountsBlobServicesContainerStatusLegalHoldProtectedAppendWritesHistory? ProtectedAppendWritesHistory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IList<V1api20230101storageStorageAccountsBlobServicesContainerStatusLegalHoldTags>? Tags { get; set; }
}

public partial class V1api20230101storageStorageAccountsBlobServicesContainerStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230101storageStorageAccountsBlobServicesContainerStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultEncryptionScope")]
    public string? DefaultEncryptionScope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deletedTime")]
    public string? DeletedTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("denyEncryptionScopeOverride")]
    public bool? DenyEncryptionScopeOverride { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableNfsV3AllSquash")]
    public bool? EnableNfsV3AllSquash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableNfsV3RootSquash")]
    public bool? EnableNfsV3RootSquash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hasImmutabilityPolicy")]
    public bool? HasImmutabilityPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hasLegalHold")]
    public bool? HasLegalHold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20230101.ImmutabilityPolicyProperties_STATUS The properties of an ImmutabilityPolicy of a blob container.</summary>
    [JsonPropertyName("immutabilityPolicy")]
    public V1api20230101storageStorageAccountsBlobServicesContainerStatusImmutabilityPolicy? ImmutabilityPolicy { get; set; }

    /// <summary>Storage version of v1api20230101.ImmutableStorageWithVersioning_STATUS Object level immutability properties of the container.</summary>
    [JsonPropertyName("immutableStorageWithVersioning")]
    public V1api20230101storageStorageAccountsBlobServicesContainerStatusImmutableStorageWithVersioning? ImmutableStorageWithVersioning { get; set; }

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

    /// <summary>Storage version of v1api20230101.LegalHoldProperties_STATUS The LegalHold property of a blob container.</summary>
    [JsonPropertyName("legalHold")]
    public V1api20230101storageStorageAccountsBlobServicesContainerStatusLegalHold? LegalHold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicAccess")]
    public string? PublicAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remainingRetentionDays")]
    public int? RemainingRetentionDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230101storageStorageAccountsBlobServicesContainer : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230101storageStorageAccountsBlobServicesContainerSpec>, IStatus<V1api20230101storageStorageAccountsBlobServicesContainerStatus>
{
    public const string KubeApiVersion = "v1api20230101storage";
    public const string KubeKind = "StorageAccountsBlobServicesContainer";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsblobservicescontainers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230101.StorageAccounts_BlobServices_Container_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230101storageStorageAccountsBlobServicesContainerSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230101.StorageAccounts_BlobServices_Container_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20230101storageStorageAccountsBlobServicesContainerStatus? Status { get; set; }
}