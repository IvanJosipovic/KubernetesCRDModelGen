using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storagecache.azure.upbound.io;
public enum V1beta1HPCCacheBlobNFSTargetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameRefPolicyResolutionEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameRefPolicyResolveEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HPCCache in storagecache to populate cacheName.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameRefPolicy? Policy { get; set; }
}

public enum V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameSelectorPolicyResolutionEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameSelectorPolicyResolveEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HPCCache in storagecache to populate cacheName.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecForProvider
{
    /// <summary>The name of the access policy applied to this target. Defaults to default.</summary>
    [JsonPropertyName("accessPolicyName")]
    public string? AccessPolicyName { get; set; }

    /// <summary>The name of the HPC Cache, which the HPC Cache Blob NFS Target will be added to. Changing this forces a new HPC Cache Blob NFS Target to be created.</summary>
    [JsonPropertyName("cacheName")]
    public string? CacheName { get; set; }

    /// <summary>Reference to a HPCCache in storagecache to populate cacheName.</summary>
    [JsonPropertyName("cacheNameRef")]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameRef? CacheNameRef { get; set; }

    /// <summary>Selector for a HPCCache in storagecache to populate cacheName.</summary>
    [JsonPropertyName("cacheNameSelector")]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderCacheNameSelector? CacheNameSelector { get; set; }

    /// <summary>The client-facing file path of the HPC Cache Blob NFS Target.</summary>
    [JsonPropertyName("namespacePath")]
    public string? NamespacePath { get; set; }

    /// <summary>The name of the Resource Group where the HPC Cache Blob NFS Target should exist. Changing this forces a new HPC Cache Blob NFS Target to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1HPCCacheBlobNFSTargetSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The Resource Manager ID of the Storage Container used as the HPC Cache Blob NFS Target. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageContainerId")]
    public string? StorageContainerId { get; set; }

    /// <summary>The type of usage of the HPC Cache Blob NFS Target. Possible values are: READ_HEAVY_INFREQ, READ_HEAVY_CHECK_180, READ_ONLY, READ_WRITE, WRITE_WORKLOAD_15, WRITE_AROUND, WRITE_WORKLOAD_CHECK_30, WRITE_WORKLOAD_CHECK_60 and WRITE_WORKLOAD_CLOUDWS.</summary>
    [JsonPropertyName("usageModel")]
    public string? UsageModel { get; set; }

    /// <summary>The amount of time the cache waits before it checks the back-end storage for file updates. Possible values are between 1 and 31536000.</summary>
    [JsonPropertyName("verificationTimerInSeconds")]
    public double? VerificationTimerInSeconds { get; set; }

    /// <summary>The amount of time the cache waits after the last file change before it copies the changed file to back-end storage. Possible values are between 1 and 31536000.</summary>
    [JsonPropertyName("writeBackTimerInSeconds")]
    public double? WriteBackTimerInSeconds { get; set; }
}

public enum V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameRefPolicyResolutionEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameRefPolicyResolveEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HPCCache in storagecache to populate cacheName.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameRefPolicy? Policy { get; set; }
}

public enum V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameSelectorPolicyResolutionEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameSelectorPolicyResolveEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HPCCache in storagecache to populate cacheName.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecInitProvider
{
    /// <summary>The name of the access policy applied to this target. Defaults to default.</summary>
    [JsonPropertyName("accessPolicyName")]
    public string? AccessPolicyName { get; set; }

    /// <summary>The name of the HPC Cache, which the HPC Cache Blob NFS Target will be added to. Changing this forces a new HPC Cache Blob NFS Target to be created.</summary>
    [JsonPropertyName("cacheName")]
    public string? CacheName { get; set; }

    /// <summary>Reference to a HPCCache in storagecache to populate cacheName.</summary>
    [JsonPropertyName("cacheNameRef")]
    public V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameRef? CacheNameRef { get; set; }

    /// <summary>Selector for a HPCCache in storagecache to populate cacheName.</summary>
    [JsonPropertyName("cacheNameSelector")]
    public V1beta1HPCCacheBlobNFSTargetSpecInitProviderCacheNameSelector? CacheNameSelector { get; set; }

    /// <summary>The client-facing file path of the HPC Cache Blob NFS Target.</summary>
    [JsonPropertyName("namespacePath")]
    public string? NamespacePath { get; set; }

    /// <summary>The Resource Manager ID of the Storage Container used as the HPC Cache Blob NFS Target. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageContainerId")]
    public string? StorageContainerId { get; set; }

    /// <summary>The type of usage of the HPC Cache Blob NFS Target. Possible values are: READ_HEAVY_INFREQ, READ_HEAVY_CHECK_180, READ_ONLY, READ_WRITE, WRITE_WORKLOAD_15, WRITE_AROUND, WRITE_WORKLOAD_CHECK_30, WRITE_WORKLOAD_CHECK_60 and WRITE_WORKLOAD_CLOUDWS.</summary>
    [JsonPropertyName("usageModel")]
    public string? UsageModel { get; set; }

    /// <summary>The amount of time the cache waits before it checks the back-end storage for file updates. Possible values are between 1 and 31536000.</summary>
    [JsonPropertyName("verificationTimerInSeconds")]
    public double? VerificationTimerInSeconds { get; set; }

    /// <summary>The amount of time the cache waits after the last file change before it copies the changed file to back-end storage. Possible values are between 1 and 31536000.</summary>
    [JsonPropertyName("writeBackTimerInSeconds")]
    public double? WriteBackTimerInSeconds { get; set; }
}

public enum V1beta1HPCCacheBlobNFSTargetSpecManagementPoliciesEnum
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

public enum V1beta1HPCCacheBlobNFSTargetSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HPCCacheBlobNFSTargetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheBlobNFSTargetSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1HPCCacheBlobNFSTargetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1HPCCacheBlobNFSTargetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1HPCCacheBlobNFSTargetSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1HPCCacheBlobNFSTargetSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1HPCCacheBlobNFSTargetSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1HPCCacheBlobNFSTargetSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>HPCCacheBlobNFSTargetSpec defines the desired state of HPCCacheBlobNFSTarget</summary>
public partial class V1beta1HPCCacheBlobNFSTargetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1HPCCacheBlobNFSTargetSpecDeletionPolicyEnum>))]
    public V1beta1HPCCacheBlobNFSTargetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1HPCCacheBlobNFSTargetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1HPCCacheBlobNFSTargetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1HPCCacheBlobNFSTargetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1HPCCacheBlobNFSTargetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1HPCCacheBlobNFSTargetSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1HPCCacheBlobNFSTargetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1HPCCacheBlobNFSTargetStatusAtProvider
{
    /// <summary>The name of the access policy applied to this target. Defaults to default.</summary>
    [JsonPropertyName("accessPolicyName")]
    public string? AccessPolicyName { get; set; }

    /// <summary>The name of the HPC Cache, which the HPC Cache Blob NFS Target will be added to. Changing this forces a new HPC Cache Blob NFS Target to be created.</summary>
    [JsonPropertyName("cacheName")]
    public string? CacheName { get; set; }

    /// <summary>The ID of the HPC Cache Blob NFS Target.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The client-facing file path of the HPC Cache Blob NFS Target.</summary>
    [JsonPropertyName("namespacePath")]
    public string? NamespacePath { get; set; }

    /// <summary>The name of the Resource Group where the HPC Cache Blob NFS Target should exist. Changing this forces a new HPC Cache Blob NFS Target to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The Resource Manager ID of the Storage Container used as the HPC Cache Blob NFS Target. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageContainerId")]
    public string? StorageContainerId { get; set; }

    /// <summary>The type of usage of the HPC Cache Blob NFS Target. Possible values are: READ_HEAVY_INFREQ, READ_HEAVY_CHECK_180, READ_ONLY, READ_WRITE, WRITE_WORKLOAD_15, WRITE_AROUND, WRITE_WORKLOAD_CHECK_30, WRITE_WORKLOAD_CHECK_60 and WRITE_WORKLOAD_CLOUDWS.</summary>
    [JsonPropertyName("usageModel")]
    public string? UsageModel { get; set; }

    /// <summary>The amount of time the cache waits before it checks the back-end storage for file updates. Possible values are between 1 and 31536000.</summary>
    [JsonPropertyName("verificationTimerInSeconds")]
    public double? VerificationTimerInSeconds { get; set; }

    /// <summary>The amount of time the cache waits after the last file change before it copies the changed file to back-end storage. Possible values are between 1 and 31536000.</summary>
    [JsonPropertyName("writeBackTimerInSeconds")]
    public double? WriteBackTimerInSeconds { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetStatusConditions
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

/// <summary>HPCCacheBlobNFSTargetStatus defines the observed state of HPCCacheBlobNFSTarget.</summary>
public partial class V1beta1HPCCacheBlobNFSTargetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1HPCCacheBlobNFSTargetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1HPCCacheBlobNFSTargetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>HPCCacheBlobNFSTarget is the Schema for the HPCCacheBlobNFSTargets API. Manages a Blob NFSv3 Target within a HPC Cache.</summary>
public partial class V1beta1HPCCacheBlobNFSTarget : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1HPCCacheBlobNFSTargetSpec>, IStatus<V1beta1HPCCacheBlobNFSTargetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HPCCacheBlobNFSTarget";
    public const string KubeGroup = "storagecache.azure.upbound.io";
    public const string KubePluralName = "hpccacheblobnfstargets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HPCCacheBlobNFSTargetSpec defines the desired state of HPCCacheBlobNFSTarget</summary>
    [JsonPropertyName("spec")]
    public V1beta1HPCCacheBlobNFSTargetSpec Spec { get; set; }

    /// <summary>HPCCacheBlobNFSTargetStatus defines the observed state of HPCCacheBlobNFSTarget.</summary>
    [JsonPropertyName("status")]
    public V1beta1HPCCacheBlobNFSTargetStatus? Status { get; set; }
}