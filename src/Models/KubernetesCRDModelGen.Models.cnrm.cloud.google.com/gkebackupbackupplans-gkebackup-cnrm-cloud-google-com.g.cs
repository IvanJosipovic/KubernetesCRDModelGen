using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gkebackup.cnrm.cloud.google.com;
#nullable enable
/// <summary>GKEBackupBackupPlan is the Schema for the GKEBackupBackupPlan API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GKEBackupBackupPlanList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1GKEBackupBackupPlan>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GKEBackupBackupPlanList";
    public const string KubeGroup = "gkebackup.cnrm.cloud.google.com";
    public const string KubePluralName = "gkebackupbackupplans";
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
    public IList<V1alpha1GKEBackupBackupPlan> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Google Cloud KMS encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanSpecBackupConfigEncryptionKeyKmsKeyRef
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
/// <summary>Optional. This defines a customer managed encryption key that will be  used to encrypt the "config" portion (the Kubernetes resources) of  Backups created via this plan.   Default (empty): Config backup artifacts will not be encrypted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanSpecBackupConfigEncryptionKey
{
    /// <summary>Optional. Google Cloud KMS encryption key.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1GKEBackupBackupPlanSpecBackupConfigEncryptionKeyKmsKeyRef? KmsKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanSpecBackupConfigSelectedApplicationsNamespacedNames
{
    /// <summary>Optional. The name of the Kubernetes resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. The Namespace of the Kubernetes resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>If set, include just the resources referenced by the listed ProtectedApplications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanSpecBackupConfigSelectedApplications
{
    /// <summary>Optional. A list of namespaced Kubernetes resources.</summary>
    [JsonPropertyName("namespacedNames")]
    public IList<V1alpha1GKEBackupBackupPlanSpecBackupConfigSelectedApplicationsNamespacedNames>? NamespacedNames { get; set; }
}
#nullable disable

#nullable enable
/// <summary>If set, include just the resources in the listed namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanSpecBackupConfigSelectedNamespaces
{
    /// <summary>Optional. A list of Kubernetes Namespaces</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Defines the configuration of Backups created via this BackupPlan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanSpecBackupConfig
{
    /// <summary>If True, include all namespaced resources</summary>
    [JsonPropertyName("allNamespaces")]
    public bool? AllNamespaces { get; set; }

    /// <summary>Optional. This defines a customer managed encryption key that will be  used to encrypt the "config" portion (the Kubernetes resources) of  Backups created via this plan.   Default (empty): Config backup artifacts will not be encrypted.</summary>
    [JsonPropertyName("encryptionKey")]
    public V1alpha1GKEBackupBackupPlanSpecBackupConfigEncryptionKey? EncryptionKey { get; set; }

    /// <summary>Optional. This flag specifies whether Kubernetes Secret resources should  be included when they fall into the scope of Backups.   Default: False</summary>
    [JsonPropertyName("includeSecrets")]
    public bool? IncludeSecrets { get; set; }

    /// <summary>Optional. This flag specifies whether volume data should be backed up  when PVCs are included in the scope of a Backup.   Default: False</summary>
    [JsonPropertyName("includeVolumeData")]
    public bool? IncludeVolumeData { get; set; }

    /// <summary>Optional. If false, Backups will fail when Backup for GKE detects  Kubernetes configuration that is non-standard or  requires additional setup to restore.   Default: False</summary>
    [JsonPropertyName("permissiveMode")]
    public bool? PermissiveMode { get; set; }

    /// <summary>If set, include just the resources referenced by the listed ProtectedApplications.</summary>
    [JsonPropertyName("selectedApplications")]
    public V1alpha1GKEBackupBackupPlanSpecBackupConfigSelectedApplications? SelectedApplications { get; set; }

    /// <summary>If set, include just the resources in the listed namespaces.</summary>
    [JsonPropertyName("selectedNamespaces")]
    public V1alpha1GKEBackupBackupPlanSpecBackupConfigSelectedNamespaces? SelectedNamespaces { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The exclusion window occurs on these days of each week in UTC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanSpecBackupScheduleRpoConfigExclusionWindowsDaysOfWeek
{
    /// <summary>Optional. A list of days of week.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }
}
#nullable disable

#nullable enable
/// <summary>No recurrence. The exclusion window occurs only once and on this date in UTC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanSpecBackupScheduleRpoConfigExclusionWindowsSingleOccurrenceDate
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public int? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public int? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public int? Year { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Specifies the start time of the window using time of the day in UTC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanSpecBackupScheduleRpoConfigExclusionWindowsStartTime
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
public partial class V1alpha1GKEBackupBackupPlanSpecBackupScheduleRpoConfigExclusionWindows
{
    /// <summary>The exclusion window occurs every day if set to "True". Specifying this field to "False" is an error.</summary>
    [JsonPropertyName("daily")]
    public bool? Daily { get; set; }

    /// <summary>The exclusion window occurs on these days of each week in UTC.</summary>
    [JsonPropertyName("daysOfWeek")]
    public V1alpha1GKEBackupBackupPlanSpecBackupScheduleRpoConfigExclusionWindowsDaysOfWeek? DaysOfWeek { get; set; }

    /// <summary>Required. Specifies duration of the window. Duration must be &gt;= 5 minutes and &lt; (target RPO - 20 minutes). Additional restrictions based on the recurrence type to allow some time for backup to happen: - single_occurrence_date:  no restriction, but UI may warn about this when duration &gt;= target RPO - daily window: duration &lt; 24 hours - weekly window: - days of week includes all seven days of a week: duration &lt; 24 hours - all other weekly window: duration &lt; 168 hours (i.e., 24 * 7 hours)</summary>
    [JsonPropertyName("duration")]
    public string Duration { get; set; }

    /// <summary>No recurrence. The exclusion window occurs only once and on this date in UTC.</summary>
    [JsonPropertyName("singleOccurrenceDate")]
    public V1alpha1GKEBackupBackupPlanSpecBackupScheduleRpoConfigExclusionWindowsSingleOccurrenceDate? SingleOccurrenceDate { get; set; }

    /// <summary>Required. Specifies the start time of the window using time of the day in UTC.</summary>
    [JsonPropertyName("startTime")]
    public V1alpha1GKEBackupBackupPlanSpecBackupScheduleRpoConfigExclusionWindowsStartTime StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Defines the RPO schedule configuration for this BackupPlan.  This is mutually exclusive with the  [cron_schedule][google.cloud.gkebackup.v1.BackupPlan.Schedule.cron_schedule]  field since at most one schedule can be defined for a BackupPLan. If this  is defined, then  [backup_retain_days][google.cloud.gkebackup.v1.BackupPlan.RetentionPolicy.backup_retain_days]  must also be defined.   Default (empty): no automatic backup creation will occur.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanSpecBackupScheduleRpoConfig
{
    /// <summary>Optional. User specified time windows during which backup can NOT happen for this BackupPlan - backups should start and finish outside of any given exclusion window. Note: backup jobs will be scheduled to start and finish outside the duration of the window as much as possible, but running jobs will not get canceled when it runs into the window. All the time and date values in exclusion_windows entry in the API are in UTC. We only allow &lt;=1 recurrence (daily or weekly) exclusion window for a BackupPlan while no restriction on number of single occurrence windows.</summary>
    [JsonPropertyName("exclusionWindows")]
    public IList<V1alpha1GKEBackupBackupPlanSpecBackupScheduleRpoConfigExclusionWindows>? ExclusionWindows { get; set; }

    /// <summary>Required. Defines the target RPO for the BackupPlan in minutes, which means the target maximum data loss in time that is acceptable for this BackupPlan. This must be at least 60, i.e., 1 hour, and at most 86400, i.e., 60 days.</summary>
    [JsonPropertyName("targetRPOMinutes")]
    public int? TargetRPOMinutes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Defines a schedule for automatic Backup creation via this BackupPlan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanSpecBackupSchedule
{
    /// <summary>Optional. A standard [cron](https://wikipedia.com/wiki/cron) string that  defines a repeating schedule for creating Backups via this BackupPlan.  This is mutually exclusive with the  [rpo_config][google.cloud.gkebackup.v1.BackupPlan.Schedule.rpo_config]  field since at most one schedule can be defined for a BackupPlan. If this  is defined, then  [backup_retain_days][google.cloud.gkebackup.v1.BackupPlan.RetentionPolicy.backup_retain_days]  must also be defined.   Default (empty): no automatic backup creation will occur.</summary>
    [JsonPropertyName("cronSchedule")]
    public string? CronSchedule { get; set; }

    /// <summary>Optional. This flag denotes whether automatic Backup creation is paused  for this BackupPlan.   Default: False</summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }

    /// <summary>Optional. Defines the RPO schedule configuration for this BackupPlan.  This is mutually exclusive with the  [cron_schedule][google.cloud.gkebackup.v1.BackupPlan.Schedule.cron_schedule]  field since at most one schedule can be defined for a BackupPLan. If this  is defined, then  [backup_retain_days][google.cloud.gkebackup.v1.BackupPlan.RetentionPolicy.backup_retain_days]  must also be defined.   Default (empty): no automatic backup creation will occur.</summary>
    [JsonPropertyName("rpoConfig")]
    public V1alpha1GKEBackupBackupPlanSpecBackupScheduleRpoConfig? RpoConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Immutable. The source cluster from which Backups will be created via this BackupPlan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanSpecClusterRef
{
    /// <summary>The GKE cluster. Valid formats: `projects/{projectID}/locations/{location}/clusters/{clusterID}` `projects/{projectID}/zones/{zone}/clusters/{clusterID}`</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the project resource. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names */</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the project resource. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/ */</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanSpecProjectRef
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
/// <summary>Optional. RetentionPolicy governs lifecycle of Backups created under this plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanSpecRetentionPolicy
{
    /// <summary>Optional. Minimum age for Backups created via this BackupPlan (in days).  This field MUST be an integer value between 0-90 (inclusive).  A Backup created under this BackupPlan will NOT be deletable until it  reaches Backup's (create_time + backup_delete_lock_days).  Updating this field of a BackupPlan does NOT affect existing Backups  under it. Backups created AFTER a successful update will inherit  the new value.   Default: 0 (no delete blocking)</summary>
    [JsonPropertyName("backupDeleteLockDays")]
    public int? BackupDeleteLockDays { get; set; }

    /// <summary>Optional. The default maximum age of a Backup created via this  BackupPlan. This field MUST be an integer value &gt;= 0 and &lt;= 365. If  specified, a Backup created under this BackupPlan will be automatically  deleted after its age reaches (create_time + backup_retain_days). If not  specified, Backups created under this BackupPlan will NOT be subject to  automatic deletion. Updating this field does NOT affect existing Backups  under it. Backups created AFTER a successful update will automatically  pick up the new value. NOTE: backup_retain_days must be &gt;=  [backup_delete_lock_days][google.cloud.gkebackup.v1.BackupPlan.RetentionPolicy.backup_delete_lock_days].  If  [cron_schedule][google.cloud.gkebackup.v1.BackupPlan.Schedule.cron_schedule]  is defined, then this must be  &lt;= 360 * the creation interval. If  [rpo_config][google.cloud.gkebackup.v1.BackupPlan.Schedule.rpo_config] is  defined, then this must be  &lt;= 360 * [target_rpo_minutes][Schedule.rpo_config.target_rpo_minutes] /  (1440minutes/day).   Default: 0 (no automatic deletion)</summary>
    [JsonPropertyName("backupRetainDays")]
    public int? BackupRetainDays { get; set; }

    /// <summary>Optional. This flag denotes whether the retention policy of this  BackupPlan is locked.  If set to True, no further update is allowed on  this policy, including the `locked` field itself.   Default: False</summary>
    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }
}
#nullable disable

#nullable enable
/// <summary>GKEBackupBackupPlanSpec defines the desired state of GKEBackupBackupPlan</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanSpec
{
    /// <summary>Optional. Defines the configuration of Backups created via this BackupPlan.</summary>
    [JsonPropertyName("backupConfig")]
    public V1alpha1GKEBackupBackupPlanSpecBackupConfig? BackupConfig { get; set; }

    /// <summary>Optional. Defines a schedule for automatic Backup creation via this BackupPlan.</summary>
    [JsonPropertyName("backupSchedule")]
    public V1alpha1GKEBackupBackupPlanSpecBackupSchedule? BackupSchedule { get; set; }

    /// <summary>Required. Immutable. The source cluster from which Backups will be created via this BackupPlan.</summary>
    [JsonPropertyName("clusterRef")]
    public V1alpha1GKEBackupBackupPlanSpecClusterRef ClusterRef { get; set; }

    /// <summary>Optional. This flag indicates whether this BackupPlan has been deactivated.  Setting this field to True locks the BackupPlan such that no further  updates will be allowed (except deletes), including the deactivated field  itself. It also prevents any new Backups from being created via this  BackupPlan (including scheduled Backups).   Default: False</summary>
    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    /// <summary>Optional. User specified descriptive string for this BackupPlan.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. A set of custom labels supplied by user.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1GKEBackupBackupPlanSpecProjectRef ProjectRef { get; set; }

    /// <summary>The GKEBackupBackupPlan name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. RetentionPolicy governs lifecycle of Backups created under this plan.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1alpha1GKEBackupBackupPlanSpecRetentionPolicy? RetentionPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanStatusConditions
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
/// <summary>Optional. Defines a schedule for automatic Backup creation via this BackupPlan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanStatusObservedStateBackupSchedule
{
    /// <summary>Output only. Start time of next scheduled backup under this BackupPlan by either cron_schedule or rpo config.</summary>
    [JsonPropertyName("nextScheduledBackupTime")]
    public string? NextScheduledBackupTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanStatusObservedState
{
    /// <summary>Optional. Defines a schedule for automatic Backup creation via this BackupPlan.</summary>
    [JsonPropertyName("backupSchedule")]
    public V1alpha1GKEBackupBackupPlanStatusObservedStateBackupSchedule? BackupSchedule { get; set; }

    /// <summary>Output only. The timestamp when this BackupPlan resource was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a backup plan from overwriting each other. It is strongly suggested that systems make use of the 'etag' in the read-modify-write cycle to perform BackupPlan updates in order to avoid race conditions: An `etag` is returned in the response to `GetBackupPlan`, and systems are expected to put that etag in the request to `UpdateBackupPlan` or `DeleteBackupPlan` to ensure that their change will be applied to the same version of the resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. The number of Kubernetes Pods backed up in the last successful Backup created via this BackupPlan.</summary>
    [JsonPropertyName("protectedPodCount")]
    public int? ProtectedPodCount { get; set; }

    /// <summary>Output only. A number that represents the current risk level of this BackupPlan from RPO perspective with 1 being no risk and 5 being highest risk.</summary>
    [JsonPropertyName("rpoRiskLevel")]
    public int? RpoRiskLevel { get; set; }

    /// <summary>Output only. Human-readable description of why the BackupPlan is in the current rpo_risk_level and action items if any.</summary>
    [JsonPropertyName("rpoRiskReason")]
    public string? RpoRiskReason { get; set; }

    /// <summary>Output only. State of the BackupPlan. This State field reflects the various stages a BackupPlan can be in during the Create operation. It will be set to "DEACTIVATED" if the BackupPlan is deactivated on an Update</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Human-readable description of why BackupPlan is in the current `state`</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>Output only. Server generated global unique identifier of [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier) format.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The timestamp when this BackupPlan resource was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>GKEBackupBackupPlanStatus defines the config connector machine state of GKEBackupBackupPlan</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupPlanStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1GKEBackupBackupPlanStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the GKEBackupBackupPlan resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1GKEBackupBackupPlanStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>GKEBackupBackupPlan is the Schema for the GKEBackupBackupPlan API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GKEBackupBackupPlan : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1GKEBackupBackupPlanSpec>, IStatus<V1alpha1GKEBackupBackupPlanStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GKEBackupBackupPlan";
    public const string KubeGroup = "gkebackup.cnrm.cloud.google.com";
    public const string KubePluralName = "gkebackupbackupplans";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GKEBackupBackupPlanSpec defines the desired state of GKEBackupBackupPlan</summary>
    [JsonPropertyName("spec")]
    public V1alpha1GKEBackupBackupPlanSpec Spec { get; set; }

    /// <summary>GKEBackupBackupPlanStatus defines the config connector machine state of GKEBackupBackupPlan</summary>
    [JsonPropertyName("status")]
    public V1alpha1GKEBackupBackupPlanStatus? Status { get; set; }
}
#nullable disable
