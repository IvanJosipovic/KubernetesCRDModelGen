using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elasticache.aws.upbound.io;
public enum V1beta1GlobalReplicationGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdRefPolicyResolutionEnum>))]
    public V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdRefPolicyResolveEnum>))]
    public V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ReplicationGroup in elasticache to populate primaryReplicationGroupId.</summary>
public partial class V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ReplicationGroup in elasticache to populate primaryReplicationGroupId.</summary>
public partial class V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1GlobalReplicationGroupSpecForProvider
{
    /// <summary>Specifies whether read-only replicas will be automatically promoted to read/write primary if the existing primary fails. When creating, by default the Global Replication Group inherits the automatic failover setting of the primary replication group.</summary>
    [JsonPropertyName("automaticFailoverEnabled")]
    public bool? AutomaticFailoverEnabled { get; set; }

    /// <summary>The instance class used. See AWS documentation for information on supported node types and guidance on selecting node types. When creating, by default the Global Replication Group inherits the node type of the primary replication group.</summary>
    [JsonPropertyName("cacheNodeType")]
    public string? CacheNodeType { get; set; }

    /// <summary>Redis version to use for the Global Replication Group. When creating, by default the Global Replication Group inherits the version of the primary replication group. If a version is specified, the Global Replication Group and all member replication groups will be upgraded to this version. Cannot be downgraded without replacing the Global Replication Group and all member replication groups. When the version is 7 or higher, the major and minor version should be set, e.g., 7.2. When the version is 6, the major and minor version can be set, e.g., 6.2, or the minor version can be unspecified which will use the latest version at creation time, e.g., 6.x. The actual engine version used is returned in the attribute engine_version_actual, see Attribute Reference below.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>created description for the global replication group.</summary>
    [JsonPropertyName("globalReplicationGroupDescription")]
    public string? GlobalReplicationGroupDescription { get; set; }

    /// <summary>–  The suffix name of a Global Datastore. If global_replication_group_id_suffix is changed, creates a new resource.</summary>
    [JsonPropertyName("globalReplicationGroupIdSuffix")]
    public string? GlobalReplicationGroupIdSuffix { get; set; }

    /// <summary>The number of node groups (shards) on the global replication group.</summary>
    [JsonPropertyName("numNodeGroups")]
    public double? NumNodeGroups { get; set; }

    /// <summary>An ElastiCache Parameter Group to use for the Global Replication Group. Required when upgrading a major engine version, but will be ignored if left configured after the upgrade is complete. Specifying without a major version upgrade will fail. Note that ElastiCache creates a copy of this parameter group for each member replication group.</summary>
    [JsonPropertyName("parameterGroupName")]
    public string? ParameterGroupName { get; set; }

    /// <summary>–  The ID of the primary cluster that accepts writes and will replicate updates to the secondary cluster. If primary_replication_group_id is changed, creates a new resource.</summary>
    [JsonPropertyName("primaryReplicationGroupId")]
    public string? PrimaryReplicationGroupId { get; set; }

    /// <summary>Reference to a ReplicationGroup in elasticache to populate primaryReplicationGroupId.</summary>
    [JsonPropertyName("primaryReplicationGroupIdRef")]
    public V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdRef? PrimaryReplicationGroupIdRef { get; set; }

    /// <summary>Selector for a ReplicationGroup in elasticache to populate primaryReplicationGroupId.</summary>
    [JsonPropertyName("primaryReplicationGroupIdSelector")]
    public V1beta1GlobalReplicationGroupSpecForProviderPrimaryReplicationGroupIdSelector? PrimaryReplicationGroupIdSelector { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

public enum V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdRefPolicyResolutionEnum>))]
    public V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdRefPolicyResolveEnum>))]
    public V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ReplicationGroup in elasticache to populate primaryReplicationGroupId.</summary>
public partial class V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ReplicationGroup in elasticache to populate primaryReplicationGroupId.</summary>
public partial class V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1GlobalReplicationGroupSpecInitProvider
{
    /// <summary>Specifies whether read-only replicas will be automatically promoted to read/write primary if the existing primary fails. When creating, by default the Global Replication Group inherits the automatic failover setting of the primary replication group.</summary>
    [JsonPropertyName("automaticFailoverEnabled")]
    public bool? AutomaticFailoverEnabled { get; set; }

    /// <summary>The instance class used. See AWS documentation for information on supported node types and guidance on selecting node types. When creating, by default the Global Replication Group inherits the node type of the primary replication group.</summary>
    [JsonPropertyName("cacheNodeType")]
    public string? CacheNodeType { get; set; }

    /// <summary>Redis version to use for the Global Replication Group. When creating, by default the Global Replication Group inherits the version of the primary replication group. If a version is specified, the Global Replication Group and all member replication groups will be upgraded to this version. Cannot be downgraded without replacing the Global Replication Group and all member replication groups. When the version is 7 or higher, the major and minor version should be set, e.g., 7.2. When the version is 6, the major and minor version can be set, e.g., 6.2, or the minor version can be unspecified which will use the latest version at creation time, e.g., 6.x. The actual engine version used is returned in the attribute engine_version_actual, see Attribute Reference below.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>created description for the global replication group.</summary>
    [JsonPropertyName("globalReplicationGroupDescription")]
    public string? GlobalReplicationGroupDescription { get; set; }

    /// <summary>–  The suffix name of a Global Datastore. If global_replication_group_id_suffix is changed, creates a new resource.</summary>
    [JsonPropertyName("globalReplicationGroupIdSuffix")]
    public string? GlobalReplicationGroupIdSuffix { get; set; }

    /// <summary>The number of node groups (shards) on the global replication group.</summary>
    [JsonPropertyName("numNodeGroups")]
    public double? NumNodeGroups { get; set; }

    /// <summary>An ElastiCache Parameter Group to use for the Global Replication Group. Required when upgrading a major engine version, but will be ignored if left configured after the upgrade is complete. Specifying without a major version upgrade will fail. Note that ElastiCache creates a copy of this parameter group for each member replication group.</summary>
    [JsonPropertyName("parameterGroupName")]
    public string? ParameterGroupName { get; set; }

    /// <summary>–  The ID of the primary cluster that accepts writes and will replicate updates to the secondary cluster. If primary_replication_group_id is changed, creates a new resource.</summary>
    [JsonPropertyName("primaryReplicationGroupId")]
    public string? PrimaryReplicationGroupId { get; set; }

    /// <summary>Reference to a ReplicationGroup in elasticache to populate primaryReplicationGroupId.</summary>
    [JsonPropertyName("primaryReplicationGroupIdRef")]
    public V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdRef? PrimaryReplicationGroupIdRef { get; set; }

    /// <summary>Selector for a ReplicationGroup in elasticache to populate primaryReplicationGroupId.</summary>
    [JsonPropertyName("primaryReplicationGroupIdSelector")]
    public V1beta1GlobalReplicationGroupSpecInitProviderPrimaryReplicationGroupIdSelector? PrimaryReplicationGroupIdSelector { get; set; }
}

public enum V1beta1GlobalReplicationGroupSpecManagementPoliciesEnum
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

public enum V1beta1GlobalReplicationGroupSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GlobalReplicationGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1GlobalReplicationGroupSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GlobalReplicationGroupSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1GlobalReplicationGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GlobalReplicationGroupSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1GlobalReplicationGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1GlobalReplicationGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GlobalReplicationGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1GlobalReplicationGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1GlobalReplicationGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1GlobalReplicationGroupSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GlobalReplicationGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1GlobalReplicationGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GlobalReplicationGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1GlobalReplicationGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1GlobalReplicationGroupSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GlobalReplicationGroupSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1GlobalReplicationGroupSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1GlobalReplicationGroupSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1GlobalReplicationGroupSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1GlobalReplicationGroupSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1GlobalReplicationGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>GlobalReplicationGroupSpec defines the desired state of GlobalReplicationGroup</summary>
public partial class V1beta1GlobalReplicationGroupSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1GlobalReplicationGroupSpecDeletionPolicyEnum>))]
    public V1beta1GlobalReplicationGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1GlobalReplicationGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1GlobalReplicationGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1GlobalReplicationGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1GlobalReplicationGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1GlobalReplicationGroupSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1GlobalReplicationGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1GlobalReplicationGroupStatusAtProviderGlobalNodeGroups
{
    /// <summary>The ID of the global node group.</summary>
    [JsonPropertyName("globalNodeGroupId")]
    public string? GlobalNodeGroupId { get; set; }

    /// <summary>The keyspace for this node group.</summary>
    [JsonPropertyName("slots")]
    public string? Slots { get; set; }
}

/// <summary></summary>
public partial class V1beta1GlobalReplicationGroupStatusAtProvider
{
    /// <summary>The ARN of the ElastiCache Global Replication Group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A flag that indicate whether the encryption at rest is enabled.</summary>
    [JsonPropertyName("atRestEncryptionEnabled")]
    public bool? AtRestEncryptionEnabled { get; set; }

    /// <summary>A flag that indicate whether AuthToken (password) is enabled.</summary>
    [JsonPropertyName("authTokenEnabled")]
    public bool? AuthTokenEnabled { get; set; }

    /// <summary>Specifies whether read-only replicas will be automatically promoted to read/write primary if the existing primary fails. When creating, by default the Global Replication Group inherits the automatic failover setting of the primary replication group.</summary>
    [JsonPropertyName("automaticFailoverEnabled")]
    public bool? AutomaticFailoverEnabled { get; set; }

    /// <summary>The instance class used. See AWS documentation for information on supported node types and guidance on selecting node types. When creating, by default the Global Replication Group inherits the node type of the primary replication group.</summary>
    [JsonPropertyName("cacheNodeType")]
    public string? CacheNodeType { get; set; }

    /// <summary>Indicates whether the Global Datastore is cluster enabled.</summary>
    [JsonPropertyName("clusterEnabled")]
    public bool? ClusterEnabled { get; set; }

    /// <summary>The name of the cache engine to be used for the clusters in this global replication group.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>Redis version to use for the Global Replication Group. When creating, by default the Global Replication Group inherits the version of the primary replication group. If a version is specified, the Global Replication Group and all member replication groups will be upgraded to this version. Cannot be downgraded without replacing the Global Replication Group and all member replication groups. When the version is 7 or higher, the major and minor version should be set, e.g., 7.2. When the version is 6, the major and minor version can be set, e.g., 6.2, or the minor version can be unspecified which will use the latest version at creation time, e.g., 6.x. The actual engine version used is returned in the attribute engine_version_actual, see Attribute Reference below.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>The full version number of the cache engine running on the members of this global replication group.</summary>
    [JsonPropertyName("engineVersionActual")]
    public string? EngineVersionActual { get; set; }

    /// <summary>Set of node groups (shards) on the global replication group. Has the values:</summary>
    [JsonPropertyName("globalNodeGroups")]
    public IList<V1beta1GlobalReplicationGroupStatusAtProviderGlobalNodeGroups>? GlobalNodeGroups { get; set; }

    /// <summary>created description for the global replication group.</summary>
    [JsonPropertyName("globalReplicationGroupDescription")]
    public string? GlobalReplicationGroupDescription { get; set; }

    /// <summary>The full ID of the global replication group.</summary>
    [JsonPropertyName("globalReplicationGroupId")]
    public string? GlobalReplicationGroupId { get; set; }

    /// <summary>–  The suffix name of a Global Datastore. If global_replication_group_id_suffix is changed, creates a new resource.</summary>
    [JsonPropertyName("globalReplicationGroupIdSuffix")]
    public string? GlobalReplicationGroupIdSuffix { get; set; }

    /// <summary>The ID of the ElastiCache Global Replication Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The number of node groups (shards) on the global replication group.</summary>
    [JsonPropertyName("numNodeGroups")]
    public double? NumNodeGroups { get; set; }

    /// <summary>An ElastiCache Parameter Group to use for the Global Replication Group. Required when upgrading a major engine version, but will be ignored if left configured after the upgrade is complete. Specifying without a major version upgrade will fail. Note that ElastiCache creates a copy of this parameter group for each member replication group.</summary>
    [JsonPropertyName("parameterGroupName")]
    public string? ParameterGroupName { get; set; }

    /// <summary>–  The ID of the primary cluster that accepts writes and will replicate updates to the secondary cluster. If primary_replication_group_id is changed, creates a new resource.</summary>
    [JsonPropertyName("primaryReplicationGroupId")]
    public string? PrimaryReplicationGroupId { get; set; }

    /// <summary>A flag that indicates whether the encryption in transit is enabled.</summary>
    [JsonPropertyName("transitEncryptionEnabled")]
    public bool? TransitEncryptionEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1GlobalReplicationGroupStatusConditions
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

/// <summary>GlobalReplicationGroupStatus defines the observed state of GlobalReplicationGroup.</summary>
public partial class V1beta1GlobalReplicationGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1GlobalReplicationGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GlobalReplicationGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>GlobalReplicationGroup is the Schema for the GlobalReplicationGroups API. Provides an ElastiCache Global Replication Group resource.</summary>
public partial class V1beta1GlobalReplicationGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GlobalReplicationGroupSpec>, IStatus<V1beta1GlobalReplicationGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GlobalReplicationGroup";
    public const string KubeGroup = "elasticache.aws.upbound.io";
    public const string KubePluralName = "globalreplicationgroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GlobalReplicationGroupSpec defines the desired state of GlobalReplicationGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1GlobalReplicationGroupSpec Spec { get; set; }

    /// <summary>GlobalReplicationGroupStatus defines the observed state of GlobalReplicationGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1GlobalReplicationGroupStatus? Status { get; set; }
}