using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.alloydb.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterMetadata
{
}

/// <summary>(Optional) The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecAutomatedBackupPolicyEncryptionConfigKmsKeyNameRef
{
    /// <summary>Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>EncryptionConfig describes the encryption config of a cluster or a backup that is encrypted with a CMEK (customer-managed encryption key).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecAutomatedBackupPolicyEncryptionConfig
{
    /// <summary>(Optional) The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME].</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public AlloyDBClusterSpecAutomatedBackupPolicyEncryptionConfigKmsKeyNameRef? KmsKeyNameRef { get; set; }
}

/// <summary>Quantity-based Backup retention policy to retain recent backups. Conflicts with 'time_based_retention', both can't be set together.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecAutomatedBackupPolicyQuantityBasedRetention
{
    /// <summary>The number of backups to retain.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

/// <summary>Time-based Backup retention policy. Conflicts with 'quantity_based_retention', both can't be set together.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecAutomatedBackupPolicyTimeBasedRetention
{
    /// <summary>The retention period. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("retentionPeriod")]
    public string? RetentionPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecAutomatedBackupPolicyWeeklyScheduleStartTimes
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public int? Hours { get; set; }

    /// <summary>Minutes of hour of day. Currently, only the value 0 is supported.</summary>
    [JsonPropertyName("minutes")]
    public int? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Currently, only the value 0 is supported.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Currently, only the value 0 is supported.</summary>
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }
}

/// <summary>Weekly schedule for the Backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecAutomatedBackupPolicyWeeklySchedule
{
    /// <summary>The days of the week to perform a backup. At least one day of the week must be provided. Possible values: ["MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"].</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>The times during the day to start a backup. At least one start time must be provided. The start times are assumed to be in UTC and to be an exact hour (e.g., 04:00:00).</summary>
    [JsonPropertyName("startTimes")]
    public IList<AlloyDBClusterSpecAutomatedBackupPolicyWeeklyScheduleStartTimes> StartTimes { get; set; }
}

/// <summary>The automated backup policy for this cluster. AutomatedBackupPolicy is disabled by default.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecAutomatedBackupPolicy
{
    /// <summary>The length of the time window during which a backup can be taken. If a backup does not succeed within this time window, it will be canceled and considered failed.  The backup window must be at least 5 minutes long. There is no upper bound on the window. If not set, it will default to 1 hour.  A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("backupWindow")]
    public string? BackupWindow { get; set; }

    /// <summary>Whether automated backups are enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>EncryptionConfig describes the encryption config of a cluster or a backup that is encrypted with a CMEK (customer-managed encryption key).</summary>
    [JsonPropertyName("encryptionConfig")]
    public AlloyDBClusterSpecAutomatedBackupPolicyEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>Labels to apply to backups created using this configuration.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location where the backup will be stored. Currently, the only supported option is to store the backup in the same region as the cluster.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Quantity-based Backup retention policy to retain recent backups. Conflicts with 'time_based_retention', both can't be set together.</summary>
    [JsonPropertyName("quantityBasedRetention")]
    public AlloyDBClusterSpecAutomatedBackupPolicyQuantityBasedRetention? QuantityBasedRetention { get; set; }

    /// <summary>Time-based Backup retention policy. Conflicts with 'quantity_based_retention', both can't be set together.</summary>
    [JsonPropertyName("timeBasedRetention")]
    public AlloyDBClusterSpecAutomatedBackupPolicyTimeBasedRetention? TimeBasedRetention { get; set; }

    /// <summary>Weekly schedule for the Backup.</summary>
    [JsonPropertyName("weeklySchedule")]
    public AlloyDBClusterSpecAutomatedBackupPolicyWeeklySchedule? WeeklySchedule { get; set; }
}

/// <summary>(Optional) The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecContinuousBackupConfigEncryptionConfigKmsKeyNameRef
{
    /// <summary>Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>EncryptionConfig describes the encryption config of a cluster or a backup that is encrypted with a CMEK (customer-managed encryption key).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecContinuousBackupConfigEncryptionConfig
{
    /// <summary>(Optional) The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME].</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public AlloyDBClusterSpecContinuousBackupConfigEncryptionConfigKmsKeyNameRef? KmsKeyNameRef { get; set; }
}

/// <summary>The continuous backup config for this cluster.  If no policy is provided then the default policy will be used. The default policy takes one backup a day and retains backups for 14 days.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecContinuousBackupConfig
{
    /// <summary>Whether continuous backup recovery is enabled. If not set, defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>EncryptionConfig describes the encryption config of a cluster or a backup that is encrypted with a CMEK (customer-managed encryption key).</summary>
    [JsonPropertyName("encryptionConfig")]
    public AlloyDBClusterSpecContinuousBackupConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>The numbers of days that are eligible to restore from using PITR. To support the entire recovery window, backups and logs are retained for one day more than the recovery window.  If not set, defaults to 14 days.</summary>
    [JsonPropertyName("recoveryWindowDays")]
    public int? RecoveryWindowDays { get; set; }
}

/// <summary>(Optional) The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecEncryptionConfigKmsKeyNameRef
{
    /// <summary>Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>EncryptionConfig describes the encryption config of a cluster or a backup that is encrypted with a CMEK (customer-managed encryption key).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecEncryptionConfig
{
    /// <summary>(Optional) The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME].</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public AlloyDBClusterSpecEncryptionConfigKmsKeyNameRef? KmsKeyNameRef { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecInitialUserPasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecInitialUserPasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public AlloyDBClusterSpecInitialUserPasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>The initial password for the user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecInitialUserPassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public AlloyDBClusterSpecInitialUserPasswordValueFrom? ValueFrom { get; set; }
}

/// <summary>Initial user to setup during cluster creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecInitialUser
{
    /// <summary>The initial password for the user.</summary>
    [JsonPropertyName("password")]
    public AlloyDBClusterSpecInitialUserPassword Password { get; set; }

    /// <summary>The database username.</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>Preferred time to start the maintenance operation on the specified day. Maintenance will start within 1 hour of this time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecMaintenanceUpdatePolicyMaintenanceWindowsStartTime
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public int Hours { get; set; }

    /// <summary>Minutes of hour of day. Currently, only the value 0 is supported.</summary>
    [JsonPropertyName("minutes")]
    public int? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Currently, only the value 0 is supported.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Currently, only the value 0 is supported.</summary>
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecMaintenanceUpdatePolicyMaintenanceWindows
{
    /// <summary>Preferred day of the week for maintenance, e.g. MONDAY, TUESDAY, etc. Possible values: ["MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"].</summary>
    [JsonPropertyName("day")]
    public string Day { get; set; }

    /// <summary>Preferred time to start the maintenance operation on the specified day. Maintenance will start within 1 hour of this time.</summary>
    [JsonPropertyName("startTime")]
    public AlloyDBClusterSpecMaintenanceUpdatePolicyMaintenanceWindowsStartTime StartTime { get; set; }
}

/// <summary>MaintenanceUpdatePolicy defines the policy for system updates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecMaintenanceUpdatePolicy
{
    /// <summary>Preferred windows to perform maintenance. Currently limited to 1.</summary>
    [JsonPropertyName("maintenanceWindows")]
    public IList<AlloyDBClusterSpecMaintenanceUpdatePolicyMaintenanceWindows>? MaintenanceWindows { get; set; }
}

/// <summary>(Required) The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form: projects/{project}/global/networks/{network_id}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecNetworkConfigNetworkRef
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/global/networks/{{value}}`, where {{value}} is the `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Metadata related to network configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecNetworkConfig
{
    /// <summary>The name of the allocated IP range for the private IP AlloyDB cluster. For example: "google-managed-services-default". If set, the instance IPs for this cluster will be created in the allocated range.</summary>
    [JsonPropertyName("allocatedIpRange")]
    public string? AllocatedIpRange { get; set; }

    /// <summary>(Required) The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form: projects/{project}/global/networks/{network_id}.</summary>
    [JsonPropertyName("networkRef")]
    public AlloyDBClusterSpecNetworkConfigNetworkRef? NetworkRef { get; set; }
}

/// <summary>(Required) The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form: projects/{project}/global/networks/{network_id}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecNetworkRef
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/global/networks/{{value}}`, where {{value}} is the `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>(Required) The name of the backup that this cluster is restored from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecRestoreBackupSourceBackupNameRef
{
    /// <summary>Allowed value: The `name` field of an `AlloyDBBackup` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The source when restoring from a backup. Conflicts with 'restore_continuous_backup_source', both can't be set together.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecRestoreBackupSource
{
    /// <summary>(Required) The name of the backup that this cluster is restored from.</summary>
    [JsonPropertyName("backupNameRef")]
    public AlloyDBClusterSpecRestoreBackupSourceBackupNameRef BackupNameRef { get; set; }
}

/// <summary>(Required) The name of the source cluster that this cluster is restored from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecRestoreContinuousBackupSourceClusterRef
{
    /// <summary>Allowed value: The `name` field of an `AlloyDBCluster` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The source when restoring via point in time recovery (PITR). Conflicts with 'restore_backup_source', both can't be set together.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecRestoreContinuousBackupSource
{
    /// <summary>(Required) The name of the source cluster that this cluster is restored from.</summary>
    [JsonPropertyName("clusterRef")]
    public AlloyDBClusterSpecRestoreContinuousBackupSourceClusterRef ClusterRef { get; set; }

    /// <summary>Immutable. The point in time that this cluster is restored to, in RFC 3339 format.</summary>
    [JsonPropertyName("pointInTime")]
    public string PointInTime { get; set; }
}

/// <summary>Name of the primary cluster must be in the format 'projects/{project}/locations/{location}/clusters/{cluster_id}'</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecSecondaryConfigPrimaryClusterNameRef
{
    /// <summary>Allowed value: The `name` field of an `AlloyDBCluster` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Configuration of the secondary cluster for Cross Region Replication. This should be set if and only if the cluster is of type SECONDARY.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpecSecondaryConfig
{
    /// <summary>Name of the primary cluster must be in the format 'projects/{project}/locations/{location}/clusters/{cluster_id}'</summary>
    [JsonPropertyName("primaryClusterNameRef")]
    public AlloyDBClusterSpecSecondaryConfigPrimaryClusterNameRef PrimaryClusterNameRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterSpec
{
    /// <summary>The automated backup policy for this cluster. AutomatedBackupPolicy is disabled by default.</summary>
    [JsonPropertyName("automatedBackupPolicy")]
    public AlloyDBClusterSpecAutomatedBackupPolicy? AutomatedBackupPolicy { get; set; }

    /// <summary>The type of cluster. If not set, defaults to PRIMARY. Default value: "PRIMARY" Possible values: ["PRIMARY", "SECONDARY"].</summary>
    [JsonPropertyName("clusterType")]
    public string? ClusterType { get; set; }

    /// <summary>The continuous backup config for this cluster.  If no policy is provided then the default policy will be used. The default policy takes one backup a day and retains backups for 14 days.</summary>
    [JsonPropertyName("continuousBackupConfig")]
    public AlloyDBClusterSpecContinuousBackupConfig? ContinuousBackupConfig { get; set; }

    /// <summary>Policy to determine if the cluster should be deleted forcefully. Deleting a cluster forcefully, deletes the cluster and all its associated instances within the cluster. Deleting a Secondary cluster with a secondary instance REQUIRES setting deletion_policy = "FORCE" otherwise an error is returned. This is needed as there is no support to delete just the secondary instance, and the only way to delete secondary instance is to delete the associated secondary cluster forcefully which also deletes the secondary instance.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>User-settable and human-readable display name for the Cluster.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>EncryptionConfig describes the encryption config of a cluster or a backup that is encrypted with a CMEK (customer-managed encryption key).</summary>
    [JsonPropertyName("encryptionConfig")]
    public AlloyDBClusterSpecEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>Initial user to setup during cluster creation.</summary>
    [JsonPropertyName("initialUser")]
    public AlloyDBClusterSpecInitialUser? InitialUser { get; set; }

    /// <summary>Immutable. The location where the alloydb cluster should reside.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>MaintenanceUpdatePolicy defines the policy for system updates.</summary>
    [JsonPropertyName("maintenanceUpdatePolicy")]
    public AlloyDBClusterSpecMaintenanceUpdatePolicy? MaintenanceUpdatePolicy { get; set; }

    /// <summary>Metadata related to network configuration.</summary>
    [JsonPropertyName("networkConfig")]
    public AlloyDBClusterSpecNetworkConfig? NetworkConfig { get; set; }

    /// <summary>(Required) The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form: projects/{project}/global/networks/{network_id}.</summary>
    [JsonPropertyName("networkRef")]
    public AlloyDBClusterSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public AlloyDBClusterSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The clusterId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The source when restoring from a backup. Conflicts with 'restore_continuous_backup_source', both can't be set together.</summary>
    [JsonPropertyName("restoreBackupSource")]
    public AlloyDBClusterSpecRestoreBackupSource? RestoreBackupSource { get; set; }

    /// <summary>Immutable. The source when restoring via point in time recovery (PITR). Conflicts with 'restore_backup_source', both can't be set together.</summary>
    [JsonPropertyName("restoreContinuousBackupSource")]
    public AlloyDBClusterSpecRestoreContinuousBackupSource? RestoreContinuousBackupSource { get; set; }

    /// <summary>Configuration of the secondary cluster for Cross Region Replication. This should be set if and only if the cluster is of type SECONDARY.</summary>
    [JsonPropertyName("secondaryConfig")]
    public AlloyDBClusterSpecSecondaryConfig? SecondaryConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterStatusBackupSource
{
    /// <summary>The name of the backup resource.</summary>
    [JsonPropertyName("backupName")]
    public string? BackupName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterStatusContinuousBackupInfoEncryptionInfo
{
    /// <summary>Output only. Type of encryption.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Output only. Cloud KMS key versions that are being used to protect the database or the backup.</summary>
    [JsonPropertyName("kmsKeyVersions")]
    public IList<string>? KmsKeyVersions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterStatusContinuousBackupInfo
{
    /// <summary>The earliest restorable time that can be restored to. Output only field.</summary>
    [JsonPropertyName("earliestRestorableTime")]
    public string? EarliestRestorableTime { get; set; }

    /// <summary>When ContinuousBackup was most recently enabled. Set to null if ContinuousBackup is not enabled.</summary>
    [JsonPropertyName("enabledTime")]
    public string? EnabledTime { get; set; }

    /// <summary>Output only. The encryption information for the WALs and backups required for ContinuousBackup.</summary>
    [JsonPropertyName("encryptionInfo")]
    public IList<AlloyDBClusterStatusContinuousBackupInfoEncryptionInfo>? EncryptionInfo { get; set; }

    /// <summary>Days of the week on which a continuous backup is taken. Output only field. Ignored if passed into the request.</summary>
    [JsonPropertyName("schedule")]
    public IList<string>? Schedule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterStatusEncryptionInfo
{
    /// <summary>Output only. Type of encryption.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Output only. Cloud KMS key versions that are being used to protect the database or the backup.</summary>
    [JsonPropertyName("kmsKeyVersions")]
    public IList<string>? KmsKeyVersions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterStatusMigrationSource
{
    /// <summary>The host and port of the on-premises instance in host:port format.</summary>
    [JsonPropertyName("hostPort")]
    public string? HostPort { get; set; }

    /// <summary>Place holder for the external source identifier(e.g DMS job name) that created the cluster.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>Type of migration source.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

/// <summary>The observed state of the underlying GCP resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterStatusObservedState
{
    /// <summary>The type of cluster. If not set, defaults to PRIMARY. Default value: "PRIMARY" Possible values: ["PRIMARY", "SECONDARY"].</summary>
    [JsonPropertyName("clusterType")]
    public string? ClusterType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBClusterStatus
{
    /// <summary>Cluster created from backup.</summary>
    [JsonPropertyName("backupSource")]
    public IList<AlloyDBClusterStatusBackupSource>? BackupSource { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<AlloyDBClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ContinuousBackupInfo describes the continuous backup properties of a cluster.</summary>
    [JsonPropertyName("continuousBackupInfo")]
    public IList<AlloyDBClusterStatusContinuousBackupInfo>? ContinuousBackupInfo { get; set; }

    /// <summary>The database engine major version. This is an output-only field and it's populated at the Cluster creation time. This field cannot be changed after cluster creation.</summary>
    [JsonPropertyName("databaseVersion")]
    public string? DatabaseVersion { get; set; }

    /// <summary>EncryptionInfo describes the encryption information of a cluster or a backup.</summary>
    [JsonPropertyName("encryptionInfo")]
    public IList<AlloyDBClusterStatusEncryptionInfo>? EncryptionInfo { get; set; }

    /// <summary>Cluster created via DMS migration.</summary>
    [JsonPropertyName("migrationSource")]
    public IList<AlloyDBClusterStatusMigrationSource>? MigrationSource { get; set; }

    /// <summary>The name of the cluster resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The observed state of the underlying GCP resource.</summary>
    [JsonPropertyName("observedState")]
    public AlloyDBClusterStatusObservedState? ObservedState { get; set; }

    /// <summary>The system-generated UID of the resource.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AlloyDBCluster
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public AlloyDBClusterMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public AlloyDBClusterSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public AlloyDBClusterStatus? Status { get; set; }
}