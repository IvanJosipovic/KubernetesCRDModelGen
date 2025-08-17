using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.alloydb.cnrm.cloud.google.com;
#nullable enable
/// <summary>AlloyDBCluster is the Schema for the AlloyDBCluster API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AlloyDBClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AlloyDBCluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AlloyDBClusterList";
    public const string KubeGroup = "alloydb.cnrm.cloud.google.com";
    public const string KubePluralName = "alloydbclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1alpha1AlloyDBCluster> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME]</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecAutomatedBackupPolicyEncryptionConfigKmsKeyNameRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The encryption config can be specified to encrypt the backups with a customer-managed encryption key (CMEK). When this field is not specified, the backup will then use default encryption scheme to protect the user data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecAutomatedBackupPolicyEncryptionConfig
{
    /// <summary>The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME]</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1alpha1AlloyDBClusterSpecAutomatedBackupPolicyEncryptionConfigKmsKeyNameRef? KmsKeyNameRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Quantity-based Backup retention policy to retain recent backups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecAutomatedBackupPolicyQuantityBasedRetention
{
    /// <summary>The number of backups to retain.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Time-based Backup retention policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecAutomatedBackupPolicyTimeBasedRetention
{
    /// <summary>The retention period.</summary>
    [JsonPropertyName("retentionPeriod")]
    public string? RetentionPeriod { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecAutomatedBackupPolicyWeeklyScheduleStartTimes
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public int? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public int? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Weekly schedule for the Backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecAutomatedBackupPolicyWeeklySchedule
{
    /// <summary>The days of the week to perform a backup.   If this field is left empty, the default of every day of the week is  used.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>The times during the day to start a backup. The start times are assumed  to be in UTC and to be an exact hour (e.g., 04:00:00).   If no start times are provided, a single fixed start time is chosen  arbitrarily.</summary>
    [JsonPropertyName("startTimes")]
    public IList<V1alpha1AlloyDBClusterSpecAutomatedBackupPolicyWeeklyScheduleStartTimes> StartTimes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The automated backup policy for this cluster.   If no policy is provided then the default policy will be used. If backups  are supported for the cluster, the default policy takes one backup a day,  has a backup window of 1 hour, and retains backups for 14 days.  For more information on the defaults, consult the  documentation for the message type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecAutomatedBackupPolicy
{
    /// <summary>The length of the time window during which a backup can be  taken. If a backup does not succeed within this time window, it will be  canceled and considered failed.   The backup window must be at least 5 minutes long. There is no upper bound  on the window. If not set, it defaults to 1 hour.</summary>
    [JsonPropertyName("backupWindow")]
    public string? BackupWindow { get; set; }

    /// <summary>Whether automated automated backups are enabled. If not set, defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional. The encryption config can be specified to encrypt the backups with a customer-managed encryption key (CMEK). When this field is not specified, the backup will then use default encryption scheme to protect the user data.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1alpha1AlloyDBClusterSpecAutomatedBackupPolicyEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>Labels to apply to backups created using this configuration.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location where the backup will be stored. Currently, the only supported  option is to store the backup in the same region as the cluster.   If empty, defaults to the region of the cluster.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Quantity-based Backup retention policy to retain recent backups.</summary>
    [JsonPropertyName("quantityBasedRetention")]
    public V1alpha1AlloyDBClusterSpecAutomatedBackupPolicyQuantityBasedRetention? QuantityBasedRetention { get; set; }

    /// <summary>Time-based Backup retention policy.</summary>
    [JsonPropertyName("timeBasedRetention")]
    public V1alpha1AlloyDBClusterSpecAutomatedBackupPolicyTimeBasedRetention? TimeBasedRetention { get; set; }

    /// <summary>Weekly schedule for the Backup.</summary>
    [JsonPropertyName("weeklySchedule")]
    public V1alpha1AlloyDBClusterSpecAutomatedBackupPolicyWeeklySchedule? WeeklySchedule { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME]</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecContinuousBackupConfigEncryptionConfigKmsKeyNameRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The encryption config can be specified to encrypt the backups with a customer-managed encryption key (CMEK). When this field is not specified, the backup will then use default encryption scheme to protect the user data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecContinuousBackupConfigEncryptionConfig
{
    /// <summary>The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME]</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1alpha1AlloyDBClusterSpecContinuousBackupConfigEncryptionConfigKmsKeyNameRef? KmsKeyNameRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Continuous backup configuration for this cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecContinuousBackupConfig
{
    /// <summary>Whether ContinuousBackup is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The encryption config can be specified to encrypt the backups with a customer-managed encryption key (CMEK). When this field is not specified, the backup will then use default encryption scheme to protect the user data.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1alpha1AlloyDBClusterSpecContinuousBackupConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>The number of days that are eligible to restore from using PITR. To support the entire recovery window, backups and logs are retained for one day more than the recovery window. If not set, defaults to 14 days.</summary>
    [JsonPropertyName("recoveryWindowDays")]
    public int? RecoveryWindowDays { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME]</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecEncryptionConfigKmsKeyNameRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The encryption config can be specified to encrypt the data disks and other persistent data resources of a cluster with a customer-managed encryption key (CMEK). When this field is not specified, the cluster will then use default encryption scheme to protect the user data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecEncryptionConfig
{
    /// <summary>The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME]</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1alpha1AlloyDBClusterSpecEncryptionConfigKmsKeyNameRef? KmsKeyNameRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecInitialUserPasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecInitialUserPasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1AlloyDBClusterSpecInitialUserPasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The initial password for the user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecInitialUserPassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1AlloyDBClusterSpecInitialUserPasswordValueFrom? ValueFrom { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Input only. Initial user to setup during cluster creation. Required. If used in `RestoreCluster` this is ignored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecInitialUser
{
    /// <summary>The initial password for the user.</summary>
    [JsonPropertyName("password")]
    public V1alpha1AlloyDBClusterSpecInitialUserPassword Password { get; set; }

    /// <summary>The database username.</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Preferred time to start the maintenance operation on the specified day. Maintenance will start within 1 hour of this time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecMaintenanceUpdatePolicyMaintenanceWindowsStartTime
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public int? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public int? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecMaintenanceUpdatePolicyMaintenanceWindows
{
    /// <summary>Preferred day of the week for maintenance, e.g. MONDAY, TUESDAY, etc.</summary>
    [JsonPropertyName("day")]
    public string Day { get; set; }

    /// <summary>Preferred time to start the maintenance operation on the specified day. Maintenance will start within 1 hour of this time.</summary>
    [JsonPropertyName("startTime")]
    public V1alpha1AlloyDBClusterSpecMaintenanceUpdatePolicyMaintenanceWindowsStartTime StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The maintenance update policy determines when to allow or deny updates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecMaintenanceUpdatePolicy
{
    /// <summary>Preferred windows to perform maintenance. Currently limited to 1.</summary>
    [JsonPropertyName("maintenanceWindows")]
    public IList<V1alpha1AlloyDBClusterSpecMaintenanceUpdatePolicyMaintenanceWindows>? MaintenanceWindows { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The resource link for the VPC network in which cluster resources are created and from which they are accessible via Private IP. The network must belong to the same project as the cluster. It is specified in the form: `projects/{project_number}/global/networks/{network_id}`. This is required to create a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecNetworkConfigNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecNetworkConfig
{
    /// <summary>Optional. Name of the allocated IP range for the private IP AlloyDB cluster, for example: "google-managed-services-default". If set, the instance IPs for this cluster will be created in the allocated range. The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?`. Field name is intended to be consistent with Cloud SQL.</summary>
    [JsonPropertyName("allocatedIpRange")]
    public string? AllocatedIpRange { get; set; }

    /// <summary>Optional. The resource link for the VPC network in which cluster resources are created and from which they are accessible via Private IP. The network must belong to the same project as the cluster. It is specified in the form: `projects/{project_number}/global/networks/{network_id}`. This is required to create a cluster.</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1AlloyDBClusterSpecNetworkConfigNetworkRef? NetworkRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. The resource link for the VPC network in which cluster resources are created and from which they are accessible via Private IP. The network must belong to the same project as the cluster. It is specified in the form: `projects/{project}/global/networks/{network_id}`. This is required to create a cluster. Deprecated, use network_config.network instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. The name of the backup resource with the format: * projects/{project}/locations/{region}/backups/{backup_id}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecRestoreBackupSourceBackupNameRef
{
    /// <summary>If provided must be in the format `projects/[projectId]/locations/[location]/backups/[backupId]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `metadata.name` field of a `AlloyDBBackup` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `AlloyDBBackup` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. The source when restoring from a backup. Conflicts with 'restoreContinuousBackupSource', both can't be set together.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecRestoreBackupSource
{
    /// <summary>Required. The name of the backup resource with the format: * projects/{project}/locations/{region}/backups/{backup_id}</summary>
    [JsonPropertyName("backupNameRef")]
    public V1alpha1AlloyDBClusterSpecRestoreBackupSourceBackupNameRef BackupNameRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>(Required) The name of the source cluster that this cluster is restored from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecRestoreContinuousBackupSourceClusterRef
{
    /// <summary>A reference to an externally managed AlloyDBCluster resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/clusters/{{clusterID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a AlloyDBCluster resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a AlloyDBCluster resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. The source when restoring via point in time recovery (PITR). Conflicts with 'restoreBackupSource', both can't be set together.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecRestoreContinuousBackupSource
{
    /// <summary>(Required) The name of the source cluster that this cluster is restored from.</summary>
    [JsonPropertyName("clusterRef")]
    public V1alpha1AlloyDBClusterSpecRestoreContinuousBackupSourceClusterRef ClusterRef { get; set; }

    /// <summary>Immutable. The point in time that this cluster is restored to, in RFC 3339 format.</summary>
    [JsonPropertyName("pointInTime")]
    public string PointInTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The name of the primary cluster name with the format: * projects/{project}/locations/{region}/clusters/{cluster_id}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecSecondaryConfigPrimaryClusterNameRef
{
    /// <summary>A reference to an externally managed AlloyDBCluster resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/clusters/{{clusterID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a AlloyDBCluster resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a AlloyDBCluster resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Cross Region replication config specific to SECONDARY cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpecSecondaryConfig
{
    /// <summary>The name of the primary cluster name with the format: * projects/{project}/locations/{region}/clusters/{cluster_id}</summary>
    [JsonPropertyName("primaryClusterNameRef")]
    public V1alpha1AlloyDBClusterSpecSecondaryConfigPrimaryClusterNameRef PrimaryClusterNameRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>AlloyDBClusterSpec defines the desired state of AlloyDBCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterSpec
{
    /// <summary>The automated backup policy for this cluster.   If no policy is provided then the default policy will be used. If backups  are supported for the cluster, the default policy takes one backup a day,  has a backup window of 1 hour, and retains backups for 14 days.  For more information on the defaults, consult the  documentation for the message type.</summary>
    [JsonPropertyName("automatedBackupPolicy")]
    public V1alpha1AlloyDBClusterSpecAutomatedBackupPolicy? AutomatedBackupPolicy { get; set; }

    /// <summary>The type of cluster. If not set, defaults to PRIMARY. Default value: "PRIMARY" Possible values: ["PRIMARY", "SECONDARY"].</summary>
    [JsonPropertyName("clusterType")]
    public string? ClusterType { get; set; }

    /// <summary>Optional. Continuous backup configuration for this cluster.</summary>
    [JsonPropertyName("continuousBackupConfig")]
    public V1alpha1AlloyDBClusterSpecContinuousBackupConfig? ContinuousBackupConfig { get; set; }

    /// <summary>Policy to determine if the cluster should be deleted forcefully. Deleting a cluster forcefully, deletes the cluster and all its associated instances within the cluster. Deleting a Secondary cluster with a secondary instance REQUIRES setting deletion_policy = "FORCE" otherwise an error is returned. This is needed as there is no support to delete just the secondary instance, and the only way to delete secondary instance is to delete the associated secondary cluster forcefully which also deletes the secondary instance.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>User-settable and human-readable display name for the Cluster.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. The encryption config can be specified to encrypt the data disks and other persistent data resources of a cluster with a customer-managed encryption key (CMEK). When this field is not specified, the cluster will then use default encryption scheme to protect the user data.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1alpha1AlloyDBClusterSpecEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>Input only. Initial user to setup during cluster creation. Required. If used in `RestoreCluster` this is ignored.</summary>
    [JsonPropertyName("initialUser")]
    public V1alpha1AlloyDBClusterSpecInitialUser? InitialUser { get; set; }

    /// <summary>Immutable. The location where the alloydb cluster should reside.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Optional. The maintenance update policy determines when to allow or deny updates.</summary>
    [JsonPropertyName("maintenanceUpdatePolicy")]
    public V1alpha1AlloyDBClusterSpecMaintenanceUpdatePolicy? MaintenanceUpdatePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkConfig")]
    public V1alpha1AlloyDBClusterSpecNetworkConfig? NetworkConfig { get; set; }

    /// <summary>Required. The resource link for the VPC network in which cluster resources are created and from which they are accessible via Private IP. The network must belong to the same project as the cluster. It is specified in the form: `projects/{project}/global/networks/{network_id}`. This is required to create a cluster. Deprecated, use network_config.network instead.</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1AlloyDBClusterSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1AlloyDBClusterSpecProjectRef ProjectRef { get; set; }

    /// <summary>The AlloyDBCluster name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The source when restoring from a backup. Conflicts with 'restoreContinuousBackupSource', both can't be set together.</summary>
    [JsonPropertyName("restoreBackupSource")]
    public V1alpha1AlloyDBClusterSpecRestoreBackupSource? RestoreBackupSource { get; set; }

    /// <summary>Immutable. The source when restoring via point in time recovery (PITR). Conflicts with 'restoreBackupSource', both can't be set together.</summary>
    [JsonPropertyName("restoreContinuousBackupSource")]
    public V1alpha1AlloyDBClusterSpecRestoreContinuousBackupSource? RestoreContinuousBackupSource { get; set; }

    /// <summary>Cross Region replication config specific to SECONDARY cluster.</summary>
    [JsonPropertyName("secondaryConfig")]
    public V1alpha1AlloyDBClusterSpecSecondaryConfig? SecondaryConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterStatusBackupSource
{
    /// <summary>The name of the backup resource.</summary>
    [JsonPropertyName("backupName")]
    public string? BackupName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterStatusContinuousBackupInfoEncryptionInfo
{
    /// <summary>Output only. Type of encryption.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Output only. Cloud KMS key versions that are being used to protect the database or the backup.</summary>
    [JsonPropertyName("kmsKeyVersions")]
    public IList<string>? KmsKeyVersions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterStatusContinuousBackupInfo
{
    /// <summary>Output only. The earliest restorable time that can be restored to. Output only field.</summary>
    [JsonPropertyName("earliestRestorableTime")]
    public string? EarliestRestorableTime { get; set; }

    /// <summary>Output only. When ContinuousBackup was most recently enabled. Set to null if ContinuousBackup is not enabled.</summary>
    [JsonPropertyName("enabledTime")]
    public string? EnabledTime { get; set; }

    /// <summary>Output only. The encryption information for the WALs and backups required for ContinuousBackup.</summary>
    [JsonPropertyName("encryptionInfo")]
    public IList<V1alpha1AlloyDBClusterStatusContinuousBackupInfoEncryptionInfo>? EncryptionInfo { get; set; }

    /// <summary>Output only. Days of the week on which a continuous backup is taken. Output only field. Ignored if passed into the request.</summary>
    [JsonPropertyName("schedule")]
    public IList<string>? Schedule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterStatusEncryptionInfo
{
    /// <summary>Output only. Type of encryption.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Output only. Cloud KMS key versions that are being used to protect the database or the backup.</summary>
    [JsonPropertyName("kmsKeyVersions")]
    public IList<string>? KmsKeyVersions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterStatusMigrationSource
{
    /// <summary>Output only. The host and port of the on-premises instance in host:port format</summary>
    [JsonPropertyName("hostPort")]
    public string? HostPort { get; set; }

    /// <summary>Output only. Place holder for the external source identifier(e.g DMS job name) that created the cluster.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>Output only. Type of migration source.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterStatusObservedState
{
    /// <summary>Output only. The type of the cluster. This is an output-only field and it's populated at the Cluster creation time or the Cluster promotion time. The cluster type is determined by which RPC was used to create the cluster (i.e. `CreateCluster` vs. `CreateSecondaryCluster`</summary>
    [JsonPropertyName("clusterType")]
    public string? ClusterType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>AlloyDBClusterStatus defines the config connector machine state of AlloyDBCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AlloyDBClusterStatus
{
    /// <summary>Output only. Cluster created from backup.</summary>
    [JsonPropertyName("backupSource")]
    public IList<V1alpha1AlloyDBClusterStatusBackupSource>? BackupSource { get; set; }

    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AlloyDBClusterStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. Continuous backup properties for this cluster.</summary>
    [JsonPropertyName("continuousBackupInfo")]
    public IList<V1alpha1AlloyDBClusterStatusContinuousBackupInfo>? ContinuousBackupInfo { get; set; }

    /// <summary>The database engine major version. This is an output-only field and it's populated at the Cluster creation time. This field cannot be changed after cluster creation.</summary>
    [JsonPropertyName("databaseVersion")]
    public string? DatabaseVersion { get; set; }

    /// <summary>Output only. The encryption information for the cluster.</summary>
    [JsonPropertyName("encryptionInfo")]
    public IList<V1alpha1AlloyDBClusterStatusEncryptionInfo>? EncryptionInfo { get; set; }

    /// <summary>A unique specifier for the AlloyDBCluster resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>Output only. Cluster created via DMS migration.</summary>
    [JsonPropertyName("migrationSource")]
    public IList<V1alpha1AlloyDBClusterStatusMigrationSource>? MigrationSource { get; set; }

    /// <summary>Output only. The name of the cluster resource with the format: * projects/{project}/locations/{region}/clusters/{cluster_id} where the cluster ID segment should satisfy the regex expression `[a-z0-9-]+`. For more details see https://google.aip.dev/122. The prefix of the cluster resource name is the name of the parent resource: * projects/{project}/locations/{region}</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1AlloyDBClusterStatusObservedState? ObservedState { get; set; }

    /// <summary>Output only. The system-generated UID of the resource. The UID is assigned when the resource is created, and it is retained until it is deleted.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}
#nullable disable

#nullable enable
/// <summary>AlloyDBCluster is the Schema for the AlloyDBCluster API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AlloyDBCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AlloyDBClusterSpec>, IStatus<V1alpha1AlloyDBClusterStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AlloyDBCluster";
    public const string KubeGroup = "alloydb.cnrm.cloud.google.com";
    public const string KubePluralName = "alloydbclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AlloyDBClusterSpec defines the desired state of AlloyDBCluster</summary>
    [JsonPropertyName("spec")]
    public V1alpha1AlloyDBClusterSpec Spec { get; set; }

    /// <summary>AlloyDBClusterStatus defines the config connector machine state of AlloyDBCluster</summary>
    [JsonPropertyName("status")]
    public V1alpha1AlloyDBClusterStatus? Status { get; set; }
}
#nullable disable
