using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cache.azure.upbound.io;
public enum V1beta1RedisEnterpriseDatabaseSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdRefPolicyResolutionEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdRefPolicyResolveEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RedisEnterpriseCluster in cache to populate clusterId.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdRefPolicy? Policy { get; set; }
}

public enum V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdSelectorPolicyResolutionEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdSelectorPolicyResolveEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RedisEnterpriseCluster in cache to populate clusterId.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecForProviderModule
{
    /// <summary>Configuration options for the module (e.g. ERROR_RATE 0.00 INITIAL_SIZE 400). Changing this forces a new resource to be created. Defaults to "".</summary>
    [JsonPropertyName("args")]
    public string? Args { get; set; }

    /// <summary>The name which should be used for this module. Possible values are RedisBloom, RedisTimeSeries, RediSearch and RedisJSON. Changing this forces a new Redis Enterprise Database to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public enum V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecForProvider
{
    /// <summary>Specifies whether redis clients can connect using TLS-encrypted or plaintext redis protocols. Possible values are Encrypted and Plaintext. Defaults to Encrypted. Changing this forces a new Redis Enterprise Database to be created.</summary>
    [JsonPropertyName("clientProtocol")]
    public string? ClientProtocol { get; set; }

    /// <summary>The resource id of the Redis Enterprise Cluster to deploy this Redis Enterprise Database. Changing this forces a new Redis Enterprise Database to be created.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>Reference to a RedisEnterpriseCluster in cache to populate clusterId.</summary>
    [JsonPropertyName("clusterIdRef")]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdRef? ClusterIdRef { get; set; }

    /// <summary>Selector for a RedisEnterpriseCluster in cache to populate clusterId.</summary>
    [JsonPropertyName("clusterIdSelector")]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderClusterIdSelector? ClusterIdSelector { get; set; }

    /// <summary>Clustering policy Specified at create time. Possible values are EnterpriseCluster and OSSCluster. Defaults to OSSCluster. Changing this forces a new Redis Enterprise Database to be created.</summary>
    [JsonPropertyName("clusteringPolicy")]
    public string? ClusteringPolicy { get; set; }

    /// <summary>Redis eviction policy possible values are AllKeysLFU, AllKeysLRU, AllKeysRandom, VolatileLRU, VolatileLFU, VolatileTTL, VolatileRandom and NoEviction. Changing this forces a new Redis Enterprise Database to be created. Defaults to VolatileLRU.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>Nickname of the group of linked databases. Changing this force a new Redis Enterprise Geo Database to be created.</summary>
    [JsonPropertyName("linkedDatabaseGroupNickname")]
    public string? LinkedDatabaseGroupNickname { get; set; }

    /// <summary>A list of database resources to link with this database with a maximum of 5.</summary>
    [JsonPropertyName("linkedDatabaseId")]
    public IList<string>? LinkedDatabaseId { get; set; }

    /// <summary>A module block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("module")]
    public IList<V1beta1RedisEnterpriseDatabaseSpecForProviderModule>? Module { get; set; }

    /// <summary>TCP port of the database endpoint. Specified at create time. Defaults to an available port. Changing this forces a new Redis Enterprise Database to be created. Defaults to 10000.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of the Resource Group where the Redis Enterprise Database should exist. Changing this forces a new Redis Enterprise Database to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1RedisEnterpriseDatabaseSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecInitProviderModule
{
    /// <summary>Configuration options for the module (e.g. ERROR_RATE 0.00 INITIAL_SIZE 400). Changing this forces a new resource to be created. Defaults to "".</summary>
    [JsonPropertyName("args")]
    public string? Args { get; set; }

    /// <summary>The name which should be used for this module. Possible values are RedisBloom, RedisTimeSeries, RediSearch and RedisJSON. Changing this forces a new Redis Enterprise Database to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public enum V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecInitProvider
{
    /// <summary>Specifies whether redis clients can connect using TLS-encrypted or plaintext redis protocols. Possible values are Encrypted and Plaintext. Defaults to Encrypted. Changing this forces a new Redis Enterprise Database to be created.</summary>
    [JsonPropertyName("clientProtocol")]
    public string? ClientProtocol { get; set; }

    /// <summary>Clustering policy Specified at create time. Possible values are EnterpriseCluster and OSSCluster. Defaults to OSSCluster. Changing this forces a new Redis Enterprise Database to be created.</summary>
    [JsonPropertyName("clusteringPolicy")]
    public string? ClusteringPolicy { get; set; }

    /// <summary>Redis eviction policy possible values are AllKeysLFU, AllKeysLRU, AllKeysRandom, VolatileLRU, VolatileLFU, VolatileTTL, VolatileRandom and NoEviction. Changing this forces a new Redis Enterprise Database to be created. Defaults to VolatileLRU.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>Nickname of the group of linked databases. Changing this force a new Redis Enterprise Geo Database to be created.</summary>
    [JsonPropertyName("linkedDatabaseGroupNickname")]
    public string? LinkedDatabaseGroupNickname { get; set; }

    /// <summary>A list of database resources to link with this database with a maximum of 5.</summary>
    [JsonPropertyName("linkedDatabaseId")]
    public IList<string>? LinkedDatabaseId { get; set; }

    /// <summary>A module block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("module")]
    public IList<V1beta1RedisEnterpriseDatabaseSpecInitProviderModule>? Module { get; set; }

    /// <summary>TCP port of the database endpoint. Specified at create time. Defaults to an available port. Changing this forces a new Redis Enterprise Database to be created. Defaults to 10000.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of the Resource Group where the Redis Enterprise Database should exist. Changing this forces a new Redis Enterprise Database to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1RedisEnterpriseDatabaseSpecInitProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }
}

public enum V1beta1RedisEnterpriseDatabaseSpecManagementPoliciesEnum
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

public enum V1beta1RedisEnterpriseDatabaseSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisEnterpriseDatabaseSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisEnterpriseDatabaseSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1RedisEnterpriseDatabaseSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RedisEnterpriseDatabaseSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RedisEnterpriseDatabaseSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1RedisEnterpriseDatabaseSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RedisEnterpriseDatabaseSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RedisEnterpriseDatabaseSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>RedisEnterpriseDatabaseSpec defines the desired state of RedisEnterpriseDatabase</summary>
public partial class V1beta1RedisEnterpriseDatabaseSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RedisEnterpriseDatabaseSpecDeletionPolicyEnum>))]
    public V1beta1RedisEnterpriseDatabaseSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RedisEnterpriseDatabaseSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RedisEnterpriseDatabaseSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RedisEnterpriseDatabaseSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RedisEnterpriseDatabaseSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RedisEnterpriseDatabaseSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RedisEnterpriseDatabaseSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1RedisEnterpriseDatabaseStatusAtProviderModule
{
    /// <summary>Configuration options for the module (e.g. ERROR_RATE 0.00 INITIAL_SIZE 400). Changing this forces a new resource to be created. Defaults to "".</summary>
    [JsonPropertyName("args")]
    public string? Args { get; set; }

    /// <summary>The name which should be used for this module. Possible values are RedisBloom, RedisTimeSeries, RediSearch and RedisJSON. Changing this forces a new Redis Enterprise Database to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1RedisEnterpriseDatabaseStatusAtProvider
{
    /// <summary>Specifies whether redis clients can connect using TLS-encrypted or plaintext redis protocols. Possible values are Encrypted and Plaintext. Defaults to Encrypted. Changing this forces a new Redis Enterprise Database to be created.</summary>
    [JsonPropertyName("clientProtocol")]
    public string? ClientProtocol { get; set; }

    /// <summary>The resource id of the Redis Enterprise Cluster to deploy this Redis Enterprise Database. Changing this forces a new Redis Enterprise Database to be created.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>Clustering policy Specified at create time. Possible values are EnterpriseCluster and OSSCluster. Defaults to OSSCluster. Changing this forces a new Redis Enterprise Database to be created.</summary>
    [JsonPropertyName("clusteringPolicy")]
    public string? ClusteringPolicy { get; set; }

    /// <summary>Redis eviction policy possible values are AllKeysLFU, AllKeysLRU, AllKeysRandom, VolatileLRU, VolatileLFU, VolatileTTL, VolatileRandom and NoEviction. Changing this forces a new Redis Enterprise Database to be created. Defaults to VolatileLRU.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>The ID of the Redis Enterprise Database.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Nickname of the group of linked databases. Changing this force a new Redis Enterprise Geo Database to be created.</summary>
    [JsonPropertyName("linkedDatabaseGroupNickname")]
    public string? LinkedDatabaseGroupNickname { get; set; }

    /// <summary>A list of database resources to link with this database with a maximum of 5.</summary>
    [JsonPropertyName("linkedDatabaseId")]
    public IList<string>? LinkedDatabaseId { get; set; }

    /// <summary>A module block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("module")]
    public IList<V1beta1RedisEnterpriseDatabaseStatusAtProviderModule>? Module { get; set; }

    /// <summary>TCP port of the database endpoint. Specified at create time. Defaults to an available port. Changing this forces a new Redis Enterprise Database to be created. Defaults to 10000.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of the Resource Group where the Redis Enterprise Database should exist. Changing this forces a new Redis Enterprise Database to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1RedisEnterpriseDatabaseStatusConditions
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

/// <summary>RedisEnterpriseDatabaseStatus defines the observed state of RedisEnterpriseDatabase.</summary>
public partial class V1beta1RedisEnterpriseDatabaseStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RedisEnterpriseDatabaseStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RedisEnterpriseDatabaseStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>RedisEnterpriseDatabase is the Schema for the RedisEnterpriseDatabases API. Manages a Redis Enterprise Database.</summary>
public partial class V1beta1RedisEnterpriseDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RedisEnterpriseDatabaseSpec>, IStatus<V1beta1RedisEnterpriseDatabaseStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RedisEnterpriseDatabase";
    public const string KubeGroup = "cache.azure.upbound.io";
    public const string KubePluralName = "redisenterprisedatabases";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RedisEnterpriseDatabaseSpec defines the desired state of RedisEnterpriseDatabase</summary>
    [JsonPropertyName("spec")]
    public V1beta1RedisEnterpriseDatabaseSpec Spec { get; set; }

    /// <summary>RedisEnterpriseDatabaseStatus defines the observed state of RedisEnterpriseDatabase.</summary>
    [JsonPropertyName("status")]
    public V1beta1RedisEnterpriseDatabaseStatus? Status { get; set; }
}