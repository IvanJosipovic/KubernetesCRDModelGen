using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.azure.com;
/// <summary>Storage version of v1api20230101.ChangeFeed The blob service properties for change feed events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceSpecChangeFeed
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retentionInDays")]
    public int? RetentionInDays { get; set; }
}

/// <summary>Storage version of v1api20230101.DeleteRetentionPolicy The service properties for soft delete.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceSpecContainerDeleteRetentionPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowPermanentDelete")]
    public bool? AllowPermanentDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20230101.CorsRule Specifies a CORS rule for the Blob service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceSpecCorsCorsRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public int? MaxAgeInSeconds { get; set; }
}

/// <summary>Storage version of v1api20230101.CorsRules Sets the CORS rules. You can include up to five CorsRule elements in the request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceSpecCors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("corsRules")]
    public IList<V1api20230101storageStorageAccountsBlobServiceSpecCorsCorsRules>? CorsRules { get; set; }
}

/// <summary>Storage version of v1api20230101.DeleteRetentionPolicy The service properties for soft delete.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceSpecDeleteRetentionPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowPermanentDelete")]
    public bool? AllowPermanentDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20230101.LastAccessTimeTrackingPolicy The blob service properties for Last access time based tracking policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceSpecLastAccessTimeTrackingPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("blobType")]
    public IList<string>? BlobType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trackingGranularityInDays")]
    public int? TrackingGranularityInDays { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a storage.azure.com/StorageAccount resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230101.RestorePolicyProperties The blob service properties for blob restore policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceSpecRestorePolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20230101.StorageAccounts_BlobService_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("automaticSnapshotPolicyEnabled")]
    public bool? AutomaticSnapshotPolicyEnabled { get; set; }

    /// <summary>Storage version of v1api20230101.ChangeFeed The blob service properties for change feed events.</summary>
    [JsonPropertyName("changeFeed")]
    public V1api20230101storageStorageAccountsBlobServiceSpecChangeFeed? ChangeFeed { get; set; }

    /// <summary>Storage version of v1api20230101.DeleteRetentionPolicy The service properties for soft delete.</summary>
    [JsonPropertyName("containerDeleteRetentionPolicy")]
    public V1api20230101storageStorageAccountsBlobServiceSpecContainerDeleteRetentionPolicy? ContainerDeleteRetentionPolicy { get; set; }

    /// <summary>Storage version of v1api20230101.CorsRules Sets the CORS rules. You can include up to five CorsRule elements in the request.</summary>
    [JsonPropertyName("cors")]
    public V1api20230101storageStorageAccountsBlobServiceSpecCors? Cors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultServiceVersion")]
    public string? DefaultServiceVersion { get; set; }

    /// <summary>Storage version of v1api20230101.DeleteRetentionPolicy The service properties for soft delete.</summary>
    [JsonPropertyName("deleteRetentionPolicy")]
    public V1api20230101storageStorageAccountsBlobServiceSpecDeleteRetentionPolicy? DeleteRetentionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isVersioningEnabled")]
    public bool? IsVersioningEnabled { get; set; }

    /// <summary>Storage version of v1api20230101.LastAccessTimeTrackingPolicy The blob service properties for Last access time based tracking policy.</summary>
    [JsonPropertyName("lastAccessTimeTrackingPolicy")]
    public V1api20230101storageStorageAccountsBlobServiceSpecLastAccessTimeTrackingPolicy? LastAccessTimeTrackingPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a storage.azure.com/StorageAccount resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230101storageStorageAccountsBlobServiceSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20230101.RestorePolicyProperties The blob service properties for blob restore policy</summary>
    [JsonPropertyName("restorePolicy")]
    public V1api20230101storageStorageAccountsBlobServiceSpecRestorePolicy? RestorePolicy { get; set; }
}

/// <summary>Storage version of v1api20230101.ChangeFeed_STATUS The blob service properties for change feed events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceStatusChangeFeed
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retentionInDays")]
    public int? RetentionInDays { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceStatusConditions
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

/// <summary>Storage version of v1api20230101.DeleteRetentionPolicy_STATUS The service properties for soft delete.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceStatusContainerDeleteRetentionPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowPermanentDelete")]
    public bool? AllowPermanentDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20230101.CorsRule_STATUS Specifies a CORS rule for the Blob service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceStatusCorsCorsRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public int? MaxAgeInSeconds { get; set; }
}

/// <summary>Storage version of v1api20230101.CorsRules_STATUS Sets the CORS rules. You can include up to five CorsRule elements in the request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceStatusCors
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("corsRules")]
    public IList<V1api20230101storageStorageAccountsBlobServiceStatusCorsCorsRules>? CorsRules { get; set; }
}

/// <summary>Storage version of v1api20230101.DeleteRetentionPolicy_STATUS The service properties for soft delete.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceStatusDeleteRetentionPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowPermanentDelete")]
    public bool? AllowPermanentDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20230101.LastAccessTimeTrackingPolicy_STATUS The blob service properties for Last access time based tracking policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceStatusLastAccessTimeTrackingPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("blobType")]
    public IList<string>? BlobType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trackingGranularityInDays")]
    public int? TrackingGranularityInDays { get; set; }
}

/// <summary>Storage version of v1api20230101.RestorePolicyProperties_STATUS The blob service properties for blob restore policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceStatusRestorePolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastEnabledTime")]
    public string? LastEnabledTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minRestoreTime")]
    public string? MinRestoreTime { get; set; }
}

/// <summary>Storage version of v1api20230101.Sku_STATUS The SKU of the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceStatusSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20230101.StorageAccounts_BlobService_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountsBlobServiceStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("automaticSnapshotPolicyEnabled")]
    public bool? AutomaticSnapshotPolicyEnabled { get; set; }

    /// <summary>Storage version of v1api20230101.ChangeFeed_STATUS The blob service properties for change feed events.</summary>
    [JsonPropertyName("changeFeed")]
    public V1api20230101storageStorageAccountsBlobServiceStatusChangeFeed? ChangeFeed { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230101storageStorageAccountsBlobServiceStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20230101.DeleteRetentionPolicy_STATUS The service properties for soft delete.</summary>
    [JsonPropertyName("containerDeleteRetentionPolicy")]
    public V1api20230101storageStorageAccountsBlobServiceStatusContainerDeleteRetentionPolicy? ContainerDeleteRetentionPolicy { get; set; }

    /// <summary>Storage version of v1api20230101.CorsRules_STATUS Sets the CORS rules. You can include up to five CorsRule elements in the request.</summary>
    [JsonPropertyName("cors")]
    public V1api20230101storageStorageAccountsBlobServiceStatusCors? Cors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultServiceVersion")]
    public string? DefaultServiceVersion { get; set; }

    /// <summary>Storage version of v1api20230101.DeleteRetentionPolicy_STATUS The service properties for soft delete.</summary>
    [JsonPropertyName("deleteRetentionPolicy")]
    public V1api20230101storageStorageAccountsBlobServiceStatusDeleteRetentionPolicy? DeleteRetentionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isVersioningEnabled")]
    public bool? IsVersioningEnabled { get; set; }

    /// <summary>Storage version of v1api20230101.LastAccessTimeTrackingPolicy_STATUS The blob service properties for Last access time based tracking policy.</summary>
    [JsonPropertyName("lastAccessTimeTrackingPolicy")]
    public V1api20230101storageStorageAccountsBlobServiceStatusLastAccessTimeTrackingPolicy? LastAccessTimeTrackingPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230101.RestorePolicyProperties_STATUS The blob service properties for blob restore policy</summary>
    [JsonPropertyName("restorePolicy")]
    public V1api20230101storageStorageAccountsBlobServiceStatusRestorePolicy? RestorePolicy { get; set; }

    /// <summary>Storage version of v1api20230101.Sku_STATUS The SKU of the storage account.</summary>
    [JsonPropertyName("sku")]
    public V1api20230101storageStorageAccountsBlobServiceStatusSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230101.StorageAccountsBlobService Generator information: - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2023-01-01/blob.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230101storageStorageAccountsBlobService : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230101storageStorageAccountsBlobServiceSpec>, IStatus<V1api20230101storageStorageAccountsBlobServiceStatus>
{
    public const string KubeApiVersion = "v1api20230101storage";
    public const string KubeKind = "StorageAccountsBlobService";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsblobservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230101.StorageAccounts_BlobService_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230101storageStorageAccountsBlobServiceSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230101.StorageAccounts_BlobService_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20230101storageStorageAccountsBlobServiceStatus? Status { get; set; }
}