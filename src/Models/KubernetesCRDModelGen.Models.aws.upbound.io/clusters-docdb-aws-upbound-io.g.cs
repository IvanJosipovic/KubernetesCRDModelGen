using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.docdb.aws.upbound.io;
public enum V1beta1ClusterSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1ClusterSpecForProviderDbClusterParameterGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterSpecForProviderDbClusterParameterGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterSpecForProviderDbClusterParameterGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderDbClusterParameterGroupNameRefPolicyResolutionEnum>))]
    public V1beta1ClusterSpecForProviderDbClusterParameterGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderDbClusterParameterGroupNameRefPolicyResolveEnum>))]
    public V1beta1ClusterSpecForProviderDbClusterParameterGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterSpecForProviderDbClusterParameterGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderDbClusterParameterGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterSpecForProviderDbClusterParameterGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderDbClusterParameterGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ClusterSpecForProviderKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterSpecForProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterSpecForProviderKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1ClusterSpecForProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1ClusterSpecForProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterSpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterSpecForProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterSpecForProviderKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1ClusterSpecForProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterSpecForProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ClusterSpecForProviderMasterPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1ClusterSpecForProviderRestoreToPointInTime
{
    /// <summary>The date and time to restore from. Value must be a time in Universal Coordinated Time (UTC) format and must be before the latest restorable time for the DB instance. Cannot be specified with use_latest_restorable_time.</summary>
    [JsonPropertyName("restoreToTime")]
    public string? RestoreToTime { get; set; }

    /// <summary>The type of restore to be performed. Valid values are full-copy, copy-on-write.</summary>
    [JsonPropertyName("restoreType")]
    public string? RestoreType { get; set; }

    /// <summary>The identifier of the source DB cluster from which to restore. Must match the identifier of an existing DB cluster.</summary>
    [JsonPropertyName("sourceClusterIdentifier")]
    public string? SourceClusterIdentifier { get; set; }

    /// <summary>A boolean value that indicates whether the DB cluster is restored from the latest backup time. Defaults to false. Cannot be specified with restore_to_time.</summary>
    [JsonPropertyName("useLatestRestorableTime")]
    public bool? UseLatestRestorableTime { get; set; }
}

public enum V1beta1ClusterSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterSpecForProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1ClusterSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1ClusterSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterSpecForProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterSpecForProviderVpcSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ClusterSpecForProvider
{
    /// <summary>A value that indicates whether major version upgrades are allowed. Constraints: You must allow major version upgrades when specifying a value for the EngineVersion parameter that is a different major version than the DB cluster's current version.</summary>
    [JsonPropertyName("allowMajorVersionUpgrade")]
    public bool? AllowMajorVersionUpgrade { get; set; }

    /// <summary>Specifies whether any cluster modifications are applied immediately, or during the next maintenance window. Default is false.</summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>If true, the password will be auto-generated and stored in the Secret referenced by the masterPasswordSecretRef field.</summary>
    [JsonPropertyName("autoGeneratePassword")]
    public bool? AutoGeneratePassword { get; set; }

    /// <summary>A list of EC2 Availability Zones that instances in the DB cluster can be created in.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>The days to retain backups for. Default 1</summary>
    [JsonPropertyName("backupRetentionPeriod")]
    public double? BackupRetentionPeriod { get; set; }

    /// <summary>A cluster parameter group to associate with the cluster.</summary>
    [JsonPropertyName("dbClusterParameterGroupName")]
    public string? DbClusterParameterGroupName { get; set; }

    /// <summary>Reference to a ClusterParameterGroup in docdb to populate dbClusterParameterGroupName.</summary>
    [JsonPropertyName("dbClusterParameterGroupNameRef")]
    public V1beta1ClusterSpecForProviderDbClusterParameterGroupNameRef? DbClusterParameterGroupNameRef { get; set; }

    /// <summary>Selector for a ClusterParameterGroup in docdb to populate dbClusterParameterGroupName.</summary>
    [JsonPropertyName("dbClusterParameterGroupNameSelector")]
    public V1beta1ClusterSpecForProviderDbClusterParameterGroupNameSelector? DbClusterParameterGroupNameSelector { get; set; }

    /// <summary>A DB subnet group to associate with this DB instance.</summary>
    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    /// <summary>A value that indicates whether the DB cluster has deletion protection enabled. The database can't be deleted when deletion protection is enabled. By default, deletion protection is disabled.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>List of log types to export to cloudwatch. If omitted, no logs will be exported. The following log types are supported: audit, profiler.</summary>
    [JsonPropertyName("enabledCloudwatchLogsExports")]
    public IList<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>The name of the database engine to be used for this DB cluster. Defaults to docdb. Valid values: docdb.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The database engine version. Updating this argument results in an outage.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>The name of your final DB snapshot when this DB cluster is deleted. If omitted, no final snapshot will be made.</summary>
    [JsonPropertyName("finalSnapshotIdentifier")]
    public string? FinalSnapshotIdentifier { get; set; }

    /// <summary>The global cluster identifier specified on aws_docdb_global_cluster.</summary>
    [JsonPropertyName("globalClusterIdentifier")]
    public string? GlobalClusterIdentifier { get; set; }

    /// <summary>The ARN for the KMS encryption key. When specifying kms_key_id, storage_encrypted needs to be set to true.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1ClusterSpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1ClusterSpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Password for the master DB user. Note that this may show up in logs, and it will be stored in the state file. Please refer to the DocumentDB Naming Constraints. Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.</summary>
    [JsonPropertyName("masterPasswordSecretRef")]
    public V1beta1ClusterSpecForProviderMasterPasswordSecretRef? MasterPasswordSecretRef { get; set; }

    /// <summary>Username for the master DB user.</summary>
    [JsonPropertyName("masterUsername")]
    public string? MasterUsername { get; set; }

    /// <summary>The port on which the DB accepts connections</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The daily time range during which automated backups are created if automated backups are enabled using the BackupRetentionPeriod parameter.Time in UTC Default: A 30-minute window selected at random from an 8-hour block of time per regionE.g., 04:00-09:00</summary>
    [JsonPropertyName("preferredBackupWindow")]
    public string? PreferredBackupWindow { get; set; }

    /// <summary>The weekly time range during which system maintenance can occur, in (UTC) e.g., wed:04:00-wed:04:30</summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A configuration block for restoring a DB instance to an arbitrary point in time. Requires the identifier argument to be set with the name of the new DB instance to be created. See Restore To Point In Time below for details.</summary>
    [JsonPropertyName("restoreToPointInTime")]
    public V1beta1ClusterSpecForProviderRestoreToPointInTime? RestoreToPointInTime { get; set; }

    /// <summary>Determines whether a final DB snapshot is created before the DB cluster is deleted. If true is specified, no DB snapshot is created. If false is specified, a DB snapshot is created before the DB cluster is deleted, using the value from final_snapshot_identifier. Default is false.</summary>
    [JsonPropertyName("skipFinalSnapshot")]
    public bool? SkipFinalSnapshot { get; set; }

    /// <summary>Specifies whether or not to create this cluster from a snapshot. You can use either the name or ARN when specifying a DB cluster snapshot, or the ARN when specifying a DB snapshot. Automated snapshots should not be used for this attribute, unless from a different cluster. Automated snapshots are deleted as part of cluster destruction when the resource is replaced.</summary>
    [JsonPropertyName("snapshotIdentifier")]
    public string? SnapshotIdentifier { get; set; }

    /// <summary>Specifies whether the DB cluster is encrypted. The default is false.</summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    /// <summary>The storage type to associate with the DB cluster. Valid values: standard, iopt1.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta1ClusterSpecForProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta1ClusterSpecForProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>List of VPC security groups to associate with the Cluster</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

public enum V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicyResolutionEnum>))]
    public V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicyResolveEnum>))]
    public V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ClusterSpecInitProviderKmsKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterSpecInitProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterSpecInitProviderKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderKmsKeyIdRefPolicyResolutionEnum>))]
    public V1beta1ClusterSpecInitProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderKmsKeyIdRefPolicyResolveEnum>))]
    public V1beta1ClusterSpecInitProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterSpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterSpecInitProviderKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1ClusterSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterSpecInitProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ClusterSpecInitProviderMasterPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1ClusterSpecInitProviderRestoreToPointInTime
{
    /// <summary>The date and time to restore from. Value must be a time in Universal Coordinated Time (UTC) format and must be before the latest restorable time for the DB instance. Cannot be specified with use_latest_restorable_time.</summary>
    [JsonPropertyName("restoreToTime")]
    public string? RestoreToTime { get; set; }

    /// <summary>The type of restore to be performed. Valid values are full-copy, copy-on-write.</summary>
    [JsonPropertyName("restoreType")]
    public string? RestoreType { get; set; }

    /// <summary>The identifier of the source DB cluster from which to restore. Must match the identifier of an existing DB cluster.</summary>
    [JsonPropertyName("sourceClusterIdentifier")]
    public string? SourceClusterIdentifier { get; set; }

    /// <summary>A boolean value that indicates whether the DB cluster is restored from the latest backup time. Defaults to false. Cannot be specified with restore_to_time.</summary>
    [JsonPropertyName("useLatestRestorableTime")]
    public bool? UseLatestRestorableTime { get; set; }
}

public enum V1beta1ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
    public V1beta1ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
    public V1beta1ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterSpecInitProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

public enum V1beta1ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterSpecInitProviderVpcSecurityGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1ClusterSpecInitProvider
{
    /// <summary>A value that indicates whether major version upgrades are allowed. Constraints: You must allow major version upgrades when specifying a value for the EngineVersion parameter that is a different major version than the DB cluster's current version.</summary>
    [JsonPropertyName("allowMajorVersionUpgrade")]
    public bool? AllowMajorVersionUpgrade { get; set; }

    /// <summary>Specifies whether any cluster modifications are applied immediately, or during the next maintenance window. Default is false.</summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>A list of EC2 Availability Zones that instances in the DB cluster can be created in.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>The days to retain backups for. Default 1</summary>
    [JsonPropertyName("backupRetentionPeriod")]
    public double? BackupRetentionPeriod { get; set; }

    /// <summary>A cluster parameter group to associate with the cluster.</summary>
    [JsonPropertyName("dbClusterParameterGroupName")]
    public string? DbClusterParameterGroupName { get; set; }

    /// <summary>Reference to a ClusterParameterGroup in docdb to populate dbClusterParameterGroupName.</summary>
    [JsonPropertyName("dbClusterParameterGroupNameRef")]
    public V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameRef? DbClusterParameterGroupNameRef { get; set; }

    /// <summary>Selector for a ClusterParameterGroup in docdb to populate dbClusterParameterGroupName.</summary>
    [JsonPropertyName("dbClusterParameterGroupNameSelector")]
    public V1beta1ClusterSpecInitProviderDbClusterParameterGroupNameSelector? DbClusterParameterGroupNameSelector { get; set; }

    /// <summary>A DB subnet group to associate with this DB instance.</summary>
    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    /// <summary>A value that indicates whether the DB cluster has deletion protection enabled. The database can't be deleted when deletion protection is enabled. By default, deletion protection is disabled.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>List of log types to export to cloudwatch. If omitted, no logs will be exported. The following log types are supported: audit, profiler.</summary>
    [JsonPropertyName("enabledCloudwatchLogsExports")]
    public IList<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>The name of the database engine to be used for this DB cluster. Defaults to docdb. Valid values: docdb.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The database engine version. Updating this argument results in an outage.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>The name of your final DB snapshot when this DB cluster is deleted. If omitted, no final snapshot will be made.</summary>
    [JsonPropertyName("finalSnapshotIdentifier")]
    public string? FinalSnapshotIdentifier { get; set; }

    /// <summary>The global cluster identifier specified on aws_docdb_global_cluster.</summary>
    [JsonPropertyName("globalClusterIdentifier")]
    public string? GlobalClusterIdentifier { get; set; }

    /// <summary>The ARN for the KMS encryption key. When specifying kms_key_id, storage_encrypted needs to be set to true.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1ClusterSpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1ClusterSpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Password for the master DB user. Note that this may show up in logs, and it will be stored in the state file. Please refer to the DocumentDB Naming Constraints. Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.</summary>
    [JsonPropertyName("masterPasswordSecretRef")]
    public V1beta1ClusterSpecInitProviderMasterPasswordSecretRef? MasterPasswordSecretRef { get; set; }

    /// <summary>Username for the master DB user.</summary>
    [JsonPropertyName("masterUsername")]
    public string? MasterUsername { get; set; }

    /// <summary>The port on which the DB accepts connections</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The daily time range during which automated backups are created if automated backups are enabled using the BackupRetentionPeriod parameter.Time in UTC Default: A 30-minute window selected at random from an 8-hour block of time per regionE.g., 04:00-09:00</summary>
    [JsonPropertyName("preferredBackupWindow")]
    public string? PreferredBackupWindow { get; set; }

    /// <summary>The weekly time range during which system maintenance can occur, in (UTC) e.g., wed:04:00-wed:04:30</summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>A configuration block for restoring a DB instance to an arbitrary point in time. Requires the identifier argument to be set with the name of the new DB instance to be created. See Restore To Point In Time below for details.</summary>
    [JsonPropertyName("restoreToPointInTime")]
    public V1beta1ClusterSpecInitProviderRestoreToPointInTime? RestoreToPointInTime { get; set; }

    /// <summary>Determines whether a final DB snapshot is created before the DB cluster is deleted. If true is specified, no DB snapshot is created. If false is specified, a DB snapshot is created before the DB cluster is deleted, using the value from final_snapshot_identifier. Default is false.</summary>
    [JsonPropertyName("skipFinalSnapshot")]
    public bool? SkipFinalSnapshot { get; set; }

    /// <summary>Specifies whether or not to create this cluster from a snapshot. You can use either the name or ARN when specifying a DB cluster snapshot, or the ARN when specifying a DB snapshot. Automated snapshots should not be used for this attribute, unless from a different cluster. Automated snapshots are deleted as part of cluster destruction when the resource is replaced.</summary>
    [JsonPropertyName("snapshotIdentifier")]
    public string? SnapshotIdentifier { get; set; }

    /// <summary>Specifies whether the DB cluster is encrypted. The default is false.</summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    /// <summary>The storage type to associate with the DB cluster. Valid values: standard, iopt1.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta1ClusterSpecInitProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta1ClusterSpecInitProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>List of VPC security groups to associate with the Cluster</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

public enum V1beta1ClusterSpecManagementPoliciesEnum
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

public enum V1beta1ClusterSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ClusterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ClusterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1ClusterSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1ClusterSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1ClusterSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ClusterSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ClusterSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1ClusterSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecDeletionPolicyEnum>))]
    public V1beta1ClusterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ClusterSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1ClusterStatusAtProviderRestoreToPointInTime
{
    /// <summary>The date and time to restore from. Value must be a time in Universal Coordinated Time (UTC) format and must be before the latest restorable time for the DB instance. Cannot be specified with use_latest_restorable_time.</summary>
    [JsonPropertyName("restoreToTime")]
    public string? RestoreToTime { get; set; }

    /// <summary>The type of restore to be performed. Valid values are full-copy, copy-on-write.</summary>
    [JsonPropertyName("restoreType")]
    public string? RestoreType { get; set; }

    /// <summary>The identifier of the source DB cluster from which to restore. Must match the identifier of an existing DB cluster.</summary>
    [JsonPropertyName("sourceClusterIdentifier")]
    public string? SourceClusterIdentifier { get; set; }

    /// <summary>A boolean value that indicates whether the DB cluster is restored from the latest backup time. Defaults to false. Cannot be specified with restore_to_time.</summary>
    [JsonPropertyName("useLatestRestorableTime")]
    public bool? UseLatestRestorableTime { get; set; }
}

public partial class V1beta1ClusterStatusAtProvider
{
    /// <summary>A value that indicates whether major version upgrades are allowed. Constraints: You must allow major version upgrades when specifying a value for the EngineVersion parameter that is a different major version than the DB cluster's current version.</summary>
    [JsonPropertyName("allowMajorVersionUpgrade")]
    public bool? AllowMajorVersionUpgrade { get; set; }

    /// <summary>Specifies whether any cluster modifications are applied immediately, or during the next maintenance window. Default is false.</summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>Amazon Resource Name (ARN) of cluster</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A list of EC2 Availability Zones that instances in the DB cluster can be created in.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>The days to retain backups for. Default 1</summary>
    [JsonPropertyName("backupRetentionPeriod")]
    public double? BackupRetentionPeriod { get; set; }

    /// <summary>– List of DocumentDB Instances that are a part of this cluster</summary>
    [JsonPropertyName("clusterMembers")]
    public IList<string>? ClusterMembers { get; set; }

    /// <summary>The DocumentDB Cluster Resource ID</summary>
    [JsonPropertyName("clusterResourceId")]
    public string? ClusterResourceId { get; set; }

    /// <summary>A cluster parameter group to associate with the cluster.</summary>
    [JsonPropertyName("dbClusterParameterGroupName")]
    public string? DbClusterParameterGroupName { get; set; }

    /// <summary>A DB subnet group to associate with this DB instance.</summary>
    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    /// <summary>A value that indicates whether the DB cluster has deletion protection enabled. The database can't be deleted when deletion protection is enabled. By default, deletion protection is disabled.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>List of log types to export to cloudwatch. If omitted, no logs will be exported. The following log types are supported: audit, profiler.</summary>
    [JsonPropertyName("enabledCloudwatchLogsExports")]
    public IList<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>The DNS address of the DocumentDB instance</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The name of the database engine to be used for this DB cluster. Defaults to docdb. Valid values: docdb.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The database engine version. Updating this argument results in an outage.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>The name of your final DB snapshot when this DB cluster is deleted. If omitted, no final snapshot will be made.</summary>
    [JsonPropertyName("finalSnapshotIdentifier")]
    public string? FinalSnapshotIdentifier { get; set; }

    /// <summary>The global cluster identifier specified on aws_docdb_global_cluster.</summary>
    [JsonPropertyName("globalClusterIdentifier")]
    public string? GlobalClusterIdentifier { get; set; }

    /// <summary>The Route53 Hosted Zone ID of the endpoint</summary>
    [JsonPropertyName("hostedZoneId")]
    public string? HostedZoneId { get; set; }

    /// <summary>The DocumentDB Cluster Identifier</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ARN for the KMS encryption key. When specifying kms_key_id, storage_encrypted needs to be set to true.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Username for the master DB user.</summary>
    [JsonPropertyName("masterUsername")]
    public string? MasterUsername { get; set; }

    /// <summary>The port on which the DB accepts connections</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The daily time range during which automated backups are created if automated backups are enabled using the BackupRetentionPeriod parameter.Time in UTC Default: A 30-minute window selected at random from an 8-hour block of time per regionE.g., 04:00-09:00</summary>
    [JsonPropertyName("preferredBackupWindow")]
    public string? PreferredBackupWindow { get; set; }

    /// <summary>The weekly time range during which system maintenance can occur, in (UTC) e.g., wed:04:00-wed:04:30</summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>A read-only endpoint for the DocumentDB cluster, automatically load-balanced across replicas</summary>
    [JsonPropertyName("readerEndpoint")]
    public string? ReaderEndpoint { get; set; }

    /// <summary>A configuration block for restoring a DB instance to an arbitrary point in time. Requires the identifier argument to be set with the name of the new DB instance to be created. See Restore To Point In Time below for details.</summary>
    [JsonPropertyName("restoreToPointInTime")]
    public V1beta1ClusterStatusAtProviderRestoreToPointInTime? RestoreToPointInTime { get; set; }

    /// <summary>Determines whether a final DB snapshot is created before the DB cluster is deleted. If true is specified, no DB snapshot is created. If false is specified, a DB snapshot is created before the DB cluster is deleted, using the value from final_snapshot_identifier. Default is false.</summary>
    [JsonPropertyName("skipFinalSnapshot")]
    public bool? SkipFinalSnapshot { get; set; }

    /// <summary>Specifies whether or not to create this cluster from a snapshot. You can use either the name or ARN when specifying a DB cluster snapshot, or the ARN when specifying a DB snapshot. Automated snapshots should not be used for this attribute, unless from a different cluster. Automated snapshots are deleted as part of cluster destruction when the resource is replaced.</summary>
    [JsonPropertyName("snapshotIdentifier")]
    public string? SnapshotIdentifier { get; set; }

    /// <summary>Specifies whether the DB cluster is encrypted. The default is false.</summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    /// <summary>The storage type to associate with the DB cluster. Valid values: standard, iopt1.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>List of VPC security groups to associate with the Cluster</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

public partial class V1beta1ClusterStatusConditions
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

public partial class V1beta1ClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterSpec>, IStatus<V1beta1ClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "docdb.aws.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClusterStatus? Status { get; set; }
}