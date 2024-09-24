using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.azure.upbound.io;
public enum V1beta1DataLakeGen2PathSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1DataLakeGen2PathSpecForProviderAce
{
    /// <summary>Specifies the Object ID of the Azure Active Directory User or Group that the entry relates to. Only valid for user or group entries.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the permissions for the entry in rwx form. For example, rwx gives full permissions but r-- only gives read permissions.</summary>
    [JsonPropertyName("permissions")]
    public string? Permissions { get; set; }

    /// <summary>Specifies whether the ACE represents an access entry or a default entry. Default value is access.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Specifies the type of entry. Can be user, group, mask or other.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1DataLakeGen2PathSpecForProviderFilesystemNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DataLakeGen2PathSpecForProviderFilesystemNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DataLakeGen2PathSpecForProviderFilesystemNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecForProviderFilesystemNameRefPolicyResolutionEnum>))]
    public V1beta1DataLakeGen2PathSpecForProviderFilesystemNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecForProviderFilesystemNameRefPolicyResolveEnum>))]
    public V1beta1DataLakeGen2PathSpecForProviderFilesystemNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DataLakeGen2FileSystem in storage to populate filesystemName.</summary>
public partial class V1beta1DataLakeGen2PathSpecForProviderFilesystemNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataLakeGen2PathSpecForProviderFilesystemNameRefPolicy? Policy { get; set; }
}

public enum V1beta1DataLakeGen2PathSpecForProviderFilesystemNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DataLakeGen2PathSpecForProviderFilesystemNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DataLakeGen2PathSpecForProviderFilesystemNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecForProviderFilesystemNameSelectorPolicyResolutionEnum>))]
    public V1beta1DataLakeGen2PathSpecForProviderFilesystemNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecForProviderFilesystemNameSelectorPolicyResolveEnum>))]
    public V1beta1DataLakeGen2PathSpecForProviderFilesystemNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DataLakeGen2FileSystem in storage to populate filesystemName.</summary>
public partial class V1beta1DataLakeGen2PathSpecForProviderFilesystemNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataLakeGen2PathSpecForProviderFilesystemNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdRefPolicyResolutionEnum>))]
    public V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdRefPolicyResolveEnum>))]
    public V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
public partial class V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdSelectorPolicyResolutionEnum>))]
    public V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdSelectorPolicyResolveEnum>))]
    public V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
public partial class V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1DataLakeGen2PathSpecForProvider
{
    /// <summary>One or more ace blocks as defined below to specify the entries for the ACL for the path.</summary>
    [JsonPropertyName("ace")]
    public IList<V1beta1DataLakeGen2PathSpecForProviderAce>? Ace { get; set; }

    /// <summary>The name of the Data Lake Gen2 File System which should be created within the Storage Account. Must be unique within the storage account the queue is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("filesystemName")]
    public string? FilesystemName { get; set; }

    /// <summary>Reference to a DataLakeGen2FileSystem in storage to populate filesystemName.</summary>
    [JsonPropertyName("filesystemNameRef")]
    public V1beta1DataLakeGen2PathSpecForProviderFilesystemNameRef? FilesystemNameRef { get; set; }

    /// <summary>Selector for a DataLakeGen2FileSystem in storage to populate filesystemName.</summary>
    [JsonPropertyName("filesystemNameSelector")]
    public V1beta1DataLakeGen2PathSpecForProviderFilesystemNameSelector? FilesystemNameSelector { get; set; }

    /// <summary>Specifies the Object ID of the Azure Active Directory Group to make the owning group. Possible values also include $superuser.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Specifies the Object ID of the Azure Active Directory User to make the owning user. Possible values also include $superuser.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The path which should be created within the Data Lake Gen2 File System in the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the type for path to create. Currently only directory is supported. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>Specifies the ID of the Storage Account in which the Data Lake Gen2 File System should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta1DataLakeGen2PathSpecForProviderStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1DataLakeGen2PathSpecInitProviderAce
{
    /// <summary>Specifies the Object ID of the Azure Active Directory User or Group that the entry relates to. Only valid for user or group entries.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the permissions for the entry in rwx form. For example, rwx gives full permissions but r-- only gives read permissions.</summary>
    [JsonPropertyName("permissions")]
    public string? Permissions { get; set; }

    /// <summary>Specifies whether the ACE represents an access entry or a default entry. Default value is access.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Specifies the type of entry. Can be user, group, mask or other.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameRefPolicyResolutionEnum>))]
    public V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameRefPolicyResolveEnum>))]
    public V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DataLakeGen2FileSystem in storage to populate filesystemName.</summary>
public partial class V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameRefPolicy? Policy { get; set; }
}

public enum V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameSelectorPolicyResolutionEnum>))]
    public V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameSelectorPolicyResolveEnum>))]
    public V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DataLakeGen2FileSystem in storage to populate filesystemName.</summary>
public partial class V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdRefPolicyResolutionEnum>))]
    public V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdRefPolicyResolveEnum>))]
    public V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
public partial class V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdRefPolicy? Policy { get; set; }
}

public enum V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdSelectorPolicyResolutionEnum>))]
    public V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdSelectorPolicyResolveEnum>))]
    public V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
public partial class V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1DataLakeGen2PathSpecInitProvider
{
    /// <summary>One or more ace blocks as defined below to specify the entries for the ACL for the path.</summary>
    [JsonPropertyName("ace")]
    public IList<V1beta1DataLakeGen2PathSpecInitProviderAce>? Ace { get; set; }

    /// <summary>The name of the Data Lake Gen2 File System which should be created within the Storage Account. Must be unique within the storage account the queue is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("filesystemName")]
    public string? FilesystemName { get; set; }

    /// <summary>Reference to a DataLakeGen2FileSystem in storage to populate filesystemName.</summary>
    [JsonPropertyName("filesystemNameRef")]
    public V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameRef? FilesystemNameRef { get; set; }

    /// <summary>Selector for a DataLakeGen2FileSystem in storage to populate filesystemName.</summary>
    [JsonPropertyName("filesystemNameSelector")]
    public V1beta1DataLakeGen2PathSpecInitProviderFilesystemNameSelector? FilesystemNameSelector { get; set; }

    /// <summary>Specifies the Object ID of the Azure Active Directory Group to make the owning group. Possible values also include $superuser.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Specifies the Object ID of the Azure Active Directory User to make the owning user. Possible values also include $superuser.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The path which should be created within the Data Lake Gen2 File System in the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the type for path to create. Currently only directory is supported. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>Specifies the ID of the Storage Account in which the Data Lake Gen2 File System should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta1DataLakeGen2PathSpecInitProviderStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

public enum V1beta1DataLakeGen2PathSpecManagementPoliciesEnum
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

public enum V1beta1DataLakeGen2PathSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DataLakeGen2PathSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DataLakeGen2PathSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DataLakeGen2PathSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DataLakeGen2PathSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1DataLakeGen2PathSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataLakeGen2PathSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1DataLakeGen2PathSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DataLakeGen2PathSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1DataLakeGen2PathSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DataLakeGen2PathSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DataLakeGen2PathSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1DataLakeGen2PathSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataLakeGen2PathSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1DataLakeGen2PathSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1DataLakeGen2PathSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DataLakeGen2PathSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DataLakeGen2PathSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1DataLakeGen2PathSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DataLakeGen2PathSpec defines the desired state of DataLakeGen2Path</summary>
public partial class V1beta1DataLakeGen2PathSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataLakeGen2PathSpecDeletionPolicyEnum>))]
    public V1beta1DataLakeGen2PathSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DataLakeGen2PathSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DataLakeGen2PathSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DataLakeGen2PathSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DataLakeGen2PathSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DataLakeGen2PathSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DataLakeGen2PathSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1DataLakeGen2PathStatusAtProviderAce
{
    /// <summary>Specifies the Object ID of the Azure Active Directory User or Group that the entry relates to. Only valid for user or group entries.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the permissions for the entry in rwx form. For example, rwx gives full permissions but r-- only gives read permissions.</summary>
    [JsonPropertyName("permissions")]
    public string? Permissions { get; set; }

    /// <summary>Specifies whether the ACE represents an access entry or a default entry. Default value is access.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Specifies the type of entry. Can be user, group, mask or other.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1DataLakeGen2PathStatusAtProvider
{
    /// <summary>One or more ace blocks as defined below to specify the entries for the ACL for the path.</summary>
    [JsonPropertyName("ace")]
    public IList<V1beta1DataLakeGen2PathStatusAtProviderAce>? Ace { get; set; }

    /// <summary>The name of the Data Lake Gen2 File System which should be created within the Storage Account. Must be unique within the storage account the queue is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("filesystemName")]
    public string? FilesystemName { get; set; }

    /// <summary>Specifies the Object ID of the Azure Active Directory Group to make the owning group. Possible values also include $superuser.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>The ID of the Data Lake Gen2 File System.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the Object ID of the Azure Active Directory User to make the owning user. Possible values also include $superuser.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The path which should be created within the Data Lake Gen2 File System in the Storage Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the type for path to create. Currently only directory is supported. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>Specifies the ID of the Storage Account in which the Data Lake Gen2 File System should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1DataLakeGen2PathStatusConditions
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

/// <summary>DataLakeGen2PathStatus defines the observed state of DataLakeGen2Path.</summary>
public partial class V1beta1DataLakeGen2PathStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DataLakeGen2PathStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataLakeGen2PathStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>DataLakeGen2Path is the Schema for the DataLakeGen2Paths API. Manages a Data Lake Gen2 Path in a File System within an Azure Storage Account.</summary>
public partial class V1beta1DataLakeGen2Path : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataLakeGen2PathSpec>, IStatus<V1beta1DataLakeGen2PathStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataLakeGen2Path";
    public const string KubeGroup = "storage.azure.upbound.io";
    public const string KubePluralName = "datalakegen2paths";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataLakeGen2PathSpec defines the desired state of DataLakeGen2Path</summary>
    [JsonPropertyName("spec")]
    public V1beta1DataLakeGen2PathSpec Spec { get; set; }

    /// <summary>DataLakeGen2PathStatus defines the observed state of DataLakeGen2Path.</summary>
    [JsonPropertyName("status")]
    public V1beta1DataLakeGen2PathStatus? Status { get; set; }
}