using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.azure.upbound.io;
public enum V1beta1BlobInventoryPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1BlobInventoryPolicySpecForProviderRulesFilter
{
    /// <summary>A set of blob types. Possible values are blockBlob, appendBlob, and pageBlob. The storage account with is_hns_enabled is true doesn't support pageBlob.</summary>
    [JsonPropertyName("blobTypes")]
    public IList<string>? BlobTypes { get; set; }

    /// <summary>A set of strings for blob prefixes to be excluded. Maximum of 10 blob prefixes.</summary>
    [JsonPropertyName("excludePrefixes")]
    public IList<string>? ExcludePrefixes { get; set; }

    /// <summary>Includes blob versions in blob inventory or not? Defaults to false.</summary>
    [JsonPropertyName("includeBlobVersions")]
    public bool? IncludeBlobVersions { get; set; }

    /// <summary>Includes deleted blobs in blob inventory or not? Defaults to false.</summary>
    [JsonPropertyName("includeDeleted")]
    public bool? IncludeDeleted { get; set; }

    /// <summary>Includes blob snapshots in blob inventory or not? Defaults to false.</summary>
    [JsonPropertyName("includeSnapshots")]
    public bool? IncludeSnapshots { get; set; }

    /// <summary>A set of strings for blob prefixes to be matched. Maximum of 10 blob prefixes.</summary>
    [JsonPropertyName("prefixMatch")]
    public IList<string>? PrefixMatch { get; set; }
}

public enum V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameRefPolicyResolutionEnum>))]
    public V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameRefPolicyResolveEnum>))]
    public V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate storageContainerName.</summary>
public partial class V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameRefPolicy? Policy { get; set; }
}

public enum V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameSelectorPolicyResolutionEnum>))]
    public V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameSelectorPolicyResolveEnum>))]
    public V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate storageContainerName.</summary>
public partial class V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BlobInventoryPolicySpecForProviderRules
{
    /// <summary>A filter block as defined above. Can only be set when the scope is Blob.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1BlobInventoryPolicySpecForProviderRulesFilter>? Filter { get; set; }

    /// <summary>The format of the inventory files. Possible values are Csv and Parquet.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The name which should be used for this Blob Inventory Policy Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The inventory schedule applied by this rule. Possible values are Daily and Weekly.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>A list of fields to be included in the inventory. See the Azure API reference for all the supported fields.</summary>
    [JsonPropertyName("schemaFields")]
    public IList<string>? SchemaFields { get; set; }

    /// <summary>The scope of the inventory for this rule. Possible values are Blob and Container.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The storage container name to store the blob inventory files for this rule.</summary>
    [JsonPropertyName("storageContainerName")]
    public string? StorageContainerName { get; set; }

    /// <summary>Reference to a Container in storage to populate storageContainerName.</summary>
    [JsonPropertyName("storageContainerNameRef")]
    public V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameRef? StorageContainerNameRef { get; set; }

    /// <summary>Selector for a Container in storage to populate storageContainerName.</summary>
    [JsonPropertyName("storageContainerNameSelector")]
    public V1beta1BlobInventoryPolicySpecForProviderRulesStorageContainerNameSelector? StorageContainerNameSelector { get; set; }
}

public enum V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdRefPolicyResolutionEnum>))]
    public V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdRefPolicyResolveEnum>))]
    public V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
public partial class V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdRefPolicy? Policy { get; set; }
}

public enum V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdSelectorPolicyResolutionEnum>))]
    public V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdSelectorPolicyResolveEnum>))]
    public V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
public partial class V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BlobInventoryPolicySpecForProvider
{
    /// <summary>One or more rules blocks as defined below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1BlobInventoryPolicySpecForProviderRules>? Rules { get; set; }

    /// <summary>The ID of the storage account to apply this Blob Inventory Policy to. Changing this forces a new Storage Blob Inventory Policy to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta1BlobInventoryPolicySpecForProviderStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1BlobInventoryPolicySpecInitProviderRulesFilter
{
    /// <summary>A set of blob types. Possible values are blockBlob, appendBlob, and pageBlob. The storage account with is_hns_enabled is true doesn't support pageBlob.</summary>
    [JsonPropertyName("blobTypes")]
    public IList<string>? BlobTypes { get; set; }

    /// <summary>A set of strings for blob prefixes to be excluded. Maximum of 10 blob prefixes.</summary>
    [JsonPropertyName("excludePrefixes")]
    public IList<string>? ExcludePrefixes { get; set; }

    /// <summary>Includes blob versions in blob inventory or not? Defaults to false.</summary>
    [JsonPropertyName("includeBlobVersions")]
    public bool? IncludeBlobVersions { get; set; }

    /// <summary>Includes deleted blobs in blob inventory or not? Defaults to false.</summary>
    [JsonPropertyName("includeDeleted")]
    public bool? IncludeDeleted { get; set; }

    /// <summary>Includes blob snapshots in blob inventory or not? Defaults to false.</summary>
    [JsonPropertyName("includeSnapshots")]
    public bool? IncludeSnapshots { get; set; }

    /// <summary>A set of strings for blob prefixes to be matched. Maximum of 10 blob prefixes.</summary>
    [JsonPropertyName("prefixMatch")]
    public IList<string>? PrefixMatch { get; set; }
}

public enum V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameRefPolicyResolutionEnum>))]
    public V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameRefPolicyResolveEnum>))]
    public V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Container in storage to populate storageContainerName.</summary>
public partial class V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameRefPolicy? Policy { get; set; }
}

public enum V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameSelectorPolicyResolutionEnum>))]
    public V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameSelectorPolicyResolveEnum>))]
    public V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Container in storage to populate storageContainerName.</summary>
public partial class V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BlobInventoryPolicySpecInitProviderRules
{
    /// <summary>A filter block as defined above. Can only be set when the scope is Blob.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1BlobInventoryPolicySpecInitProviderRulesFilter>? Filter { get; set; }

    /// <summary>The format of the inventory files. Possible values are Csv and Parquet.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The name which should be used for this Blob Inventory Policy Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The inventory schedule applied by this rule. Possible values are Daily and Weekly.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>A list of fields to be included in the inventory. See the Azure API reference for all the supported fields.</summary>
    [JsonPropertyName("schemaFields")]
    public IList<string>? SchemaFields { get; set; }

    /// <summary>The scope of the inventory for this rule. Possible values are Blob and Container.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The storage container name to store the blob inventory files for this rule.</summary>
    [JsonPropertyName("storageContainerName")]
    public string? StorageContainerName { get; set; }

    /// <summary>Reference to a Container in storage to populate storageContainerName.</summary>
    [JsonPropertyName("storageContainerNameRef")]
    public V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameRef? StorageContainerNameRef { get; set; }

    /// <summary>Selector for a Container in storage to populate storageContainerName.</summary>
    [JsonPropertyName("storageContainerNameSelector")]
    public V1beta1BlobInventoryPolicySpecInitProviderRulesStorageContainerNameSelector? StorageContainerNameSelector { get; set; }
}

public enum V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdRefPolicyResolutionEnum>))]
    public V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdRefPolicyResolveEnum>))]
    public V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
public partial class V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdRefPolicy? Policy { get; set; }
}

public enum V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdSelectorPolicyResolutionEnum>))]
    public V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdSelectorPolicyResolveEnum>))]
    public V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
public partial class V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1BlobInventoryPolicySpecInitProvider
{
    /// <summary>One or more rules blocks as defined below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1BlobInventoryPolicySpecInitProviderRules>? Rules { get; set; }

    /// <summary>The ID of the storage account to apply this Blob Inventory Policy to. Changing this forces a new Storage Blob Inventory Policy to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta1BlobInventoryPolicySpecInitProviderStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

public enum V1beta1BlobInventoryPolicySpecManagementPoliciesEnum
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

public enum V1beta1BlobInventoryPolicySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BlobInventoryPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BlobInventoryPolicySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1BlobInventoryPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1BlobInventoryPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1BlobInventoryPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BlobInventoryPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1BlobInventoryPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BlobInventoryPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BlobInventoryPolicySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1BlobInventoryPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1BlobInventoryPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1BlobInventoryPolicySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BlobInventoryPolicySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1BlobInventoryPolicySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1BlobInventoryPolicySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BlobInventoryPolicySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BlobInventoryPolicySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1BlobInventoryPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>BlobInventoryPolicySpec defines the desired state of BlobInventoryPolicy</summary>
public partial class V1beta1BlobInventoryPolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BlobInventoryPolicySpecDeletionPolicyEnum>))]
    public V1beta1BlobInventoryPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BlobInventoryPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BlobInventoryPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1BlobInventoryPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BlobInventoryPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BlobInventoryPolicySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BlobInventoryPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1BlobInventoryPolicyStatusAtProviderRulesFilter
{
    /// <summary>A set of blob types. Possible values are blockBlob, appendBlob, and pageBlob. The storage account with is_hns_enabled is true doesn't support pageBlob.</summary>
    [JsonPropertyName("blobTypes")]
    public IList<string>? BlobTypes { get; set; }

    /// <summary>A set of strings for blob prefixes to be excluded. Maximum of 10 blob prefixes.</summary>
    [JsonPropertyName("excludePrefixes")]
    public IList<string>? ExcludePrefixes { get; set; }

    /// <summary>Includes blob versions in blob inventory or not? Defaults to false.</summary>
    [JsonPropertyName("includeBlobVersions")]
    public bool? IncludeBlobVersions { get; set; }

    /// <summary>Includes deleted blobs in blob inventory or not? Defaults to false.</summary>
    [JsonPropertyName("includeDeleted")]
    public bool? IncludeDeleted { get; set; }

    /// <summary>Includes blob snapshots in blob inventory or not? Defaults to false.</summary>
    [JsonPropertyName("includeSnapshots")]
    public bool? IncludeSnapshots { get; set; }

    /// <summary>A set of strings for blob prefixes to be matched. Maximum of 10 blob prefixes.</summary>
    [JsonPropertyName("prefixMatch")]
    public IList<string>? PrefixMatch { get; set; }
}

/// <summary></summary>
public partial class V1beta1BlobInventoryPolicyStatusAtProviderRules
{
    /// <summary>A filter block as defined above. Can only be set when the scope is Blob.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1BlobInventoryPolicyStatusAtProviderRulesFilter>? Filter { get; set; }

    /// <summary>The format of the inventory files. Possible values are Csv and Parquet.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The name which should be used for this Blob Inventory Policy Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The inventory schedule applied by this rule. Possible values are Daily and Weekly.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>A list of fields to be included in the inventory. See the Azure API reference for all the supported fields.</summary>
    [JsonPropertyName("schemaFields")]
    public IList<string>? SchemaFields { get; set; }

    /// <summary>The scope of the inventory for this rule. Possible values are Blob and Container.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The storage container name to store the blob inventory files for this rule.</summary>
    [JsonPropertyName("storageContainerName")]
    public string? StorageContainerName { get; set; }
}

/// <summary></summary>
public partial class V1beta1BlobInventoryPolicyStatusAtProvider
{
    /// <summary>The ID of the Storage Blob Inventory Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more rules blocks as defined below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1BlobInventoryPolicyStatusAtProviderRules>? Rules { get; set; }

    /// <summary>The ID of the storage account to apply this Blob Inventory Policy to. Changing this forces a new Storage Blob Inventory Policy to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1BlobInventoryPolicyStatusConditions
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

/// <summary>BlobInventoryPolicyStatus defines the observed state of BlobInventoryPolicy.</summary>
public partial class V1beta1BlobInventoryPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BlobInventoryPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BlobInventoryPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>BlobInventoryPolicy is the Schema for the BlobInventoryPolicys API. Manages a Storage Blob Inventory Policy.</summary>
public partial class V1beta1BlobInventoryPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BlobInventoryPolicySpec>, IStatus<V1beta1BlobInventoryPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BlobInventoryPolicy";
    public const string KubeGroup = "storage.azure.upbound.io";
    public const string KubePluralName = "blobinventorypolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BlobInventoryPolicySpec defines the desired state of BlobInventoryPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1BlobInventoryPolicySpec Spec { get; set; }

    /// <summary>BlobInventoryPolicyStatus defines the observed state of BlobInventoryPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1BlobInventoryPolicyStatus? Status { get; set; }
}