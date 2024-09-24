using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dms.aws.upbound.io;
public enum V1beta1ReplicationTaskSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnRefPolicyResolutionEnum>))]
    public V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnRefPolicyResolveEnum>))]
    public V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ReplicationInstance in dms to populate replicationInstanceArn.</summary>
public partial class V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnSelectorPolicyResolutionEnum>))]
    public V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnSelectorPolicyResolveEnum>))]
    public V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ReplicationInstance in dms to populate replicationInstanceArn.</summary>
public partial class V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ReplicationTaskSpecForProviderSourceEndpointArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ReplicationTaskSpecForProviderSourceEndpointArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ReplicationTaskSpecForProviderSourceEndpointArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecForProviderSourceEndpointArnRefPolicyResolutionEnum>))]
    public V1beta1ReplicationTaskSpecForProviderSourceEndpointArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecForProviderSourceEndpointArnRefPolicyResolveEnum>))]
    public V1beta1ReplicationTaskSpecForProviderSourceEndpointArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Endpoint in dms to populate sourceEndpointArn.</summary>
public partial class V1beta1ReplicationTaskSpecForProviderSourceEndpointArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationTaskSpecForProviderSourceEndpointArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ReplicationTaskSpecForProviderSourceEndpointArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ReplicationTaskSpecForProviderSourceEndpointArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ReplicationTaskSpecForProviderSourceEndpointArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecForProviderSourceEndpointArnSelectorPolicyResolutionEnum>))]
    public V1beta1ReplicationTaskSpecForProviderSourceEndpointArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecForProviderSourceEndpointArnSelectorPolicyResolveEnum>))]
    public V1beta1ReplicationTaskSpecForProviderSourceEndpointArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Endpoint in dms to populate sourceEndpointArn.</summary>
public partial class V1beta1ReplicationTaskSpecForProviderSourceEndpointArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationTaskSpecForProviderSourceEndpointArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ReplicationTaskSpecForProviderTargetEndpointArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ReplicationTaskSpecForProviderTargetEndpointArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ReplicationTaskSpecForProviderTargetEndpointArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecForProviderTargetEndpointArnRefPolicyResolutionEnum>))]
    public V1beta1ReplicationTaskSpecForProviderTargetEndpointArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecForProviderTargetEndpointArnRefPolicyResolveEnum>))]
    public V1beta1ReplicationTaskSpecForProviderTargetEndpointArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Endpoint in dms to populate targetEndpointArn.</summary>
public partial class V1beta1ReplicationTaskSpecForProviderTargetEndpointArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationTaskSpecForProviderTargetEndpointArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ReplicationTaskSpecForProviderTargetEndpointArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ReplicationTaskSpecForProviderTargetEndpointArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ReplicationTaskSpecForProviderTargetEndpointArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecForProviderTargetEndpointArnSelectorPolicyResolutionEnum>))]
    public V1beta1ReplicationTaskSpecForProviderTargetEndpointArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecForProviderTargetEndpointArnSelectorPolicyResolveEnum>))]
    public V1beta1ReplicationTaskSpecForProviderTargetEndpointArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Endpoint in dms to populate targetEndpointArn.</summary>
public partial class V1beta1ReplicationTaskSpecForProviderTargetEndpointArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationTaskSpecForProviderTargetEndpointArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ReplicationTaskSpecForProvider
{
    /// <summary>Indicates when you want a change data capture (CDC) operation to start. The value can be a RFC3339 formatted date, a checkpoint, or a LSN/SCN format depending on the source engine. For more information see Determining a CDC native start point.</summary>
    [JsonPropertyName("cdcStartPosition")]
    public string? CdcStartPosition { get; set; }

    /// <summary>RFC3339 formatted date string or UNIX timestamp for the start of the Change Data Capture (CDC) operation.</summary>
    [JsonPropertyName("cdcStartTime")]
    public string? CdcStartTime { get; set; }

    /// <summary>Migration type. Can be one of full-load | cdc | full-load-and-cdc.</summary>
    [JsonPropertyName("migrationType")]
    public string? MigrationType { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>ARN of the replication instance.</summary>
    [JsonPropertyName("replicationInstanceArn")]
    public string? ReplicationInstanceArn { get; set; }

    /// <summary>Reference to a ReplicationInstance in dms to populate replicationInstanceArn.</summary>
    [JsonPropertyName("replicationInstanceArnRef")]
    public V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnRef? ReplicationInstanceArnRef { get; set; }

    /// <summary>Selector for a ReplicationInstance in dms to populate replicationInstanceArn.</summary>
    [JsonPropertyName("replicationInstanceArnSelector")]
    public V1beta1ReplicationTaskSpecForProviderReplicationInstanceArnSelector? ReplicationInstanceArnSelector { get; set; }

    /// <summary>Escaped JSON string that contains the task settings. For a complete list of task settings, see Task Settings for AWS Database Migration Service Tasks. Note that Logging.CloudWatchLogGroup and Logging.CloudWatchLogStream are read only and should not be defined, even as null, in the configuration since AWS provides a value for these settings.</summary>
    [JsonPropertyName("replicationTaskSettings")]
    public string? ReplicationTaskSettings { get; set; }

    /// <summary>A friendly name for the resource identifier at the end of the EndpointArn response parameter that is returned in the created Endpoint object.</summary>
    [JsonPropertyName("resourceIdentifier")]
    public string? ResourceIdentifier { get; set; }

    /// <summary>ARN that uniquely identifies the source endpoint.</summary>
    [JsonPropertyName("sourceEndpointArn")]
    public string? SourceEndpointArn { get; set; }

    /// <summary>Reference to a Endpoint in dms to populate sourceEndpointArn.</summary>
    [JsonPropertyName("sourceEndpointArnRef")]
    public V1beta1ReplicationTaskSpecForProviderSourceEndpointArnRef? SourceEndpointArnRef { get; set; }

    /// <summary>Selector for a Endpoint in dms to populate sourceEndpointArn.</summary>
    [JsonPropertyName("sourceEndpointArnSelector")]
    public V1beta1ReplicationTaskSpecForProviderSourceEndpointArnSelector? SourceEndpointArnSelector { get; set; }

    /// <summary>Whether to run or stop the replication task.</summary>
    [JsonPropertyName("startReplicationTask")]
    public bool? StartReplicationTask { get; set; }

    /// <summary>Escaped JSON string that contains the table mappings. For information on table mapping see Using Table Mapping with an AWS Database Migration Service Task to Select and Filter Data</summary>
    [JsonPropertyName("tableMappings")]
    public string? TableMappings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ARN that uniquely identifies the target endpoint.</summary>
    [JsonPropertyName("targetEndpointArn")]
    public string? TargetEndpointArn { get; set; }

    /// <summary>Reference to a Endpoint in dms to populate targetEndpointArn.</summary>
    [JsonPropertyName("targetEndpointArnRef")]
    public V1beta1ReplicationTaskSpecForProviderTargetEndpointArnRef? TargetEndpointArnRef { get; set; }

    /// <summary>Selector for a Endpoint in dms to populate targetEndpointArn.</summary>
    [JsonPropertyName("targetEndpointArnSelector")]
    public V1beta1ReplicationTaskSpecForProviderTargetEndpointArnSelector? TargetEndpointArnSelector { get; set; }
}

public enum V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnRefPolicyResolutionEnum>))]
    public V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnRefPolicyResolveEnum>))]
    public V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ReplicationInstance in dms to populate replicationInstanceArn.</summary>
public partial class V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnSelectorPolicyResolutionEnum>))]
    public V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnSelectorPolicyResolveEnum>))]
    public V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ReplicationInstance in dms to populate replicationInstanceArn.</summary>
public partial class V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnRefPolicyResolutionEnum>))]
    public V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnRefPolicyResolveEnum>))]
    public V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Endpoint in dms to populate sourceEndpointArn.</summary>
public partial class V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnSelectorPolicyResolutionEnum>))]
    public V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnSelectorPolicyResolveEnum>))]
    public V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Endpoint in dms to populate sourceEndpointArn.</summary>
public partial class V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnRefPolicyResolutionEnum>))]
    public V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnRefPolicyResolveEnum>))]
    public V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Endpoint in dms to populate targetEndpointArn.</summary>
public partial class V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnSelectorPolicyResolutionEnum>))]
    public V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnSelectorPolicyResolveEnum>))]
    public V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Endpoint in dms to populate targetEndpointArn.</summary>
public partial class V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1ReplicationTaskSpecInitProvider
{
    /// <summary>Indicates when you want a change data capture (CDC) operation to start. The value can be a RFC3339 formatted date, a checkpoint, or a LSN/SCN format depending on the source engine. For more information see Determining a CDC native start point.</summary>
    [JsonPropertyName("cdcStartPosition")]
    public string? CdcStartPosition { get; set; }

    /// <summary>RFC3339 formatted date string or UNIX timestamp for the start of the Change Data Capture (CDC) operation.</summary>
    [JsonPropertyName("cdcStartTime")]
    public string? CdcStartTime { get; set; }

    /// <summary>Migration type. Can be one of full-load | cdc | full-load-and-cdc.</summary>
    [JsonPropertyName("migrationType")]
    public string? MigrationType { get; set; }

    /// <summary>ARN of the replication instance.</summary>
    [JsonPropertyName("replicationInstanceArn")]
    public string? ReplicationInstanceArn { get; set; }

    /// <summary>Reference to a ReplicationInstance in dms to populate replicationInstanceArn.</summary>
    [JsonPropertyName("replicationInstanceArnRef")]
    public V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnRef? ReplicationInstanceArnRef { get; set; }

    /// <summary>Selector for a ReplicationInstance in dms to populate replicationInstanceArn.</summary>
    [JsonPropertyName("replicationInstanceArnSelector")]
    public V1beta1ReplicationTaskSpecInitProviderReplicationInstanceArnSelector? ReplicationInstanceArnSelector { get; set; }

    /// <summary>Escaped JSON string that contains the task settings. For a complete list of task settings, see Task Settings for AWS Database Migration Service Tasks. Note that Logging.CloudWatchLogGroup and Logging.CloudWatchLogStream are read only and should not be defined, even as null, in the configuration since AWS provides a value for these settings.</summary>
    [JsonPropertyName("replicationTaskSettings")]
    public string? ReplicationTaskSettings { get; set; }

    /// <summary>A friendly name for the resource identifier at the end of the EndpointArn response parameter that is returned in the created Endpoint object.</summary>
    [JsonPropertyName("resourceIdentifier")]
    public string? ResourceIdentifier { get; set; }

    /// <summary>ARN that uniquely identifies the source endpoint.</summary>
    [JsonPropertyName("sourceEndpointArn")]
    public string? SourceEndpointArn { get; set; }

    /// <summary>Reference to a Endpoint in dms to populate sourceEndpointArn.</summary>
    [JsonPropertyName("sourceEndpointArnRef")]
    public V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnRef? SourceEndpointArnRef { get; set; }

    /// <summary>Selector for a Endpoint in dms to populate sourceEndpointArn.</summary>
    [JsonPropertyName("sourceEndpointArnSelector")]
    public V1beta1ReplicationTaskSpecInitProviderSourceEndpointArnSelector? SourceEndpointArnSelector { get; set; }

    /// <summary>Whether to run or stop the replication task.</summary>
    [JsonPropertyName("startReplicationTask")]
    public bool? StartReplicationTask { get; set; }

    /// <summary>Escaped JSON string that contains the table mappings. For information on table mapping see Using Table Mapping with an AWS Database Migration Service Task to Select and Filter Data</summary>
    [JsonPropertyName("tableMappings")]
    public string? TableMappings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ARN that uniquely identifies the target endpoint.</summary>
    [JsonPropertyName("targetEndpointArn")]
    public string? TargetEndpointArn { get; set; }

    /// <summary>Reference to a Endpoint in dms to populate targetEndpointArn.</summary>
    [JsonPropertyName("targetEndpointArnRef")]
    public V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnRef? TargetEndpointArnRef { get; set; }

    /// <summary>Selector for a Endpoint in dms to populate targetEndpointArn.</summary>
    [JsonPropertyName("targetEndpointArnSelector")]
    public V1beta1ReplicationTaskSpecInitProviderTargetEndpointArnSelector? TargetEndpointArnSelector { get; set; }
}

public enum V1beta1ReplicationTaskSpecManagementPoliciesEnum
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

public enum V1beta1ReplicationTaskSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ReplicationTaskSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ReplicationTaskSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ReplicationTaskSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ReplicationTaskSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1ReplicationTaskSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationTaskSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ReplicationTaskSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ReplicationTaskSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ReplicationTaskSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ReplicationTaskSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ReplicationTaskSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1ReplicationTaskSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReplicationTaskSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1ReplicationTaskSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ReplicationTaskSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ReplicationTaskSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ReplicationTaskSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1ReplicationTaskSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ReplicationTaskSpec defines the desired state of ReplicationTask</summary>
public partial class V1beta1ReplicationTaskSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReplicationTaskSpecDeletionPolicyEnum>))]
    public V1beta1ReplicationTaskSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ReplicationTaskSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ReplicationTaskSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ReplicationTaskSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ReplicationTaskSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ReplicationTaskSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ReplicationTaskSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ReplicationTaskStatusAtProvider
{
    /// <summary>Indicates when you want a change data capture (CDC) operation to start. The value can be a RFC3339 formatted date, a checkpoint, or a LSN/SCN format depending on the source engine. For more information see Determining a CDC native start point.</summary>
    [JsonPropertyName("cdcStartPosition")]
    public string? CdcStartPosition { get; set; }

    /// <summary>RFC3339 formatted date string or UNIX timestamp for the start of the Change Data Capture (CDC) operation.</summary>
    [JsonPropertyName("cdcStartTime")]
    public string? CdcStartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Migration type. Can be one of full-load | cdc | full-load-and-cdc.</summary>
    [JsonPropertyName("migrationType")]
    public string? MigrationType { get; set; }

    /// <summary>ARN of the replication instance.</summary>
    [JsonPropertyName("replicationInstanceArn")]
    public string? ReplicationInstanceArn { get; set; }

    /// <summary>ARN for the replication task.</summary>
    [JsonPropertyName("replicationTaskArn")]
    public string? ReplicationTaskArn { get; set; }

    /// <summary>Escaped JSON string that contains the task settings. For a complete list of task settings, see Task Settings for AWS Database Migration Service Tasks. Note that Logging.CloudWatchLogGroup and Logging.CloudWatchLogStream are read only and should not be defined, even as null, in the configuration since AWS provides a value for these settings.</summary>
    [JsonPropertyName("replicationTaskSettings")]
    public string? ReplicationTaskSettings { get; set; }

    /// <summary>A friendly name for the resource identifier at the end of the EndpointArn response parameter that is returned in the created Endpoint object.</summary>
    [JsonPropertyName("resourceIdentifier")]
    public string? ResourceIdentifier { get; set; }

    /// <summary>ARN that uniquely identifies the source endpoint.</summary>
    [JsonPropertyName("sourceEndpointArn")]
    public string? SourceEndpointArn { get; set; }

    /// <summary>Whether to run or stop the replication task.</summary>
    [JsonPropertyName("startReplicationTask")]
    public bool? StartReplicationTask { get; set; }

    /// <summary>Replication Task status.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Escaped JSON string that contains the table mappings. For information on table mapping see Using Table Mapping with an AWS Database Migration Service Task to Select and Filter Data</summary>
    [JsonPropertyName("tableMappings")]
    public string? TableMappings { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>ARN that uniquely identifies the target endpoint.</summary>
    [JsonPropertyName("targetEndpointArn")]
    public string? TargetEndpointArn { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1ReplicationTaskStatusConditions
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

/// <summary>ReplicationTaskStatus defines the observed state of ReplicationTask.</summary>
public partial class V1beta1ReplicationTaskStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ReplicationTaskStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ReplicationTaskStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>ReplicationTask is the Schema for the ReplicationTasks API. Provides a DMS (Data Migration Service) replication task resource.</summary>
public partial class V1beta1ReplicationTask : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ReplicationTaskSpec>, IStatus<V1beta1ReplicationTaskStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReplicationTask";
    public const string KubeGroup = "dms.aws.upbound.io";
    public const string KubePluralName = "replicationtasks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReplicationTaskSpec defines the desired state of ReplicationTask</summary>
    [JsonPropertyName("spec")]
    public V1beta1ReplicationTaskSpec Spec { get; set; }

    /// <summary>ReplicationTaskStatus defines the observed state of ReplicationTask.</summary>
    [JsonPropertyName("status")]
    public V1beta1ReplicationTaskStatus? Status { get; set; }
}