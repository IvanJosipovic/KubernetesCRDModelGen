using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gke.gcp.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeyRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate gcpKmsEncryptionKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupBackupPlanSpecForProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeyRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate gcpKmsEncryptionKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupBackupPlanSpecForProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeySelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderBackupConfigEncryptionKey
{
    /// <summary>Google Cloud KMS encryption key. Format: projects//locations//keyRings//cryptoKeys/</summary>
    [JsonPropertyName("gcpKmsEncryptionKey")]
    public string? GcpKmsEncryptionKey { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate gcpKmsEncryptionKey.</summary>
    [JsonPropertyName("gcpKmsEncryptionKeyRef")]
    public V1beta1BackupBackupPlanSpecForProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeyRef? GcpKmsEncryptionKeyRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate gcpKmsEncryptionKey.</summary>
    [JsonPropertyName("gcpKmsEncryptionKeySelector")]
    public V1beta1BackupBackupPlanSpecForProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeySelector? GcpKmsEncryptionKeySelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderBackupConfigSelectedApplicationsNamespacedNames
{
    /// <summary>The name of a Kubernetes Resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a Kubernetes Resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderBackupConfigSelectedApplications
{
    /// <summary>A list of namespaced Kubernetes resources. Structure is documented below.</summary>
    [JsonPropertyName("namespacedNames")]
    public IList<V1beta1BackupBackupPlanSpecForProviderBackupConfigSelectedApplicationsNamespacedNames>? NamespacedNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderBackupConfigSelectedNamespaces
{
    /// <summary>A list of Kubernetes Namespaces.</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderBackupConfig
{
    /// <summary>If True, include all namespaced resources.</summary>
    [JsonPropertyName("allNamespaces")]
    public bool? AllNamespaces { get; set; }

    /// <summary>This defines a customer managed encryption key that will be used to encrypt the "config" portion (the Kubernetes resources) of Backups created via this plan. Structure is documented below.</summary>
    [JsonPropertyName("encryptionKey")]
    public IList<V1beta1BackupBackupPlanSpecForProviderBackupConfigEncryptionKey>? EncryptionKey { get; set; }

    /// <summary>This flag specifies whether Kubernetes Secret resources should be included when they fall into the scope of Backups.</summary>
    [JsonPropertyName("includeSecrets")]
    public bool? IncludeSecrets { get; set; }

    /// <summary>This flag specifies whether volume data should be backed up when PVCs are included in the scope of a Backup.</summary>
    [JsonPropertyName("includeVolumeData")]
    public bool? IncludeVolumeData { get; set; }

    /// <summary>This flag specifies whether Backups will not fail when Backup for GKE detects Kubernetes configuration that is non-standard or requires additional setup to restore.</summary>
    [JsonPropertyName("permissiveMode")]
    public bool? PermissiveMode { get; set; }

    /// <summary>A list of namespaced Kubernetes Resources. Structure is documented below.</summary>
    [JsonPropertyName("selectedApplications")]
    public IList<V1beta1BackupBackupPlanSpecForProviderBackupConfigSelectedApplications>? SelectedApplications { get; set; }

    /// <summary>If set, include just the resources in the listed namespaces. Structure is documented below.</summary>
    [JsonPropertyName("selectedNamespaces")]
    public IList<V1beta1BackupBackupPlanSpecForProviderBackupConfigSelectedNamespaces>? SelectedNamespaces { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderBackupScheduleRpoConfigExclusionWindowsDaysOfWeek
{
    /// <summary>The exclusion window occurs on these days of each week in UTC. Only one of singleOccurrenceDate, daily and daysOfWeek may be set. Structure is documented below.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderBackupScheduleRpoConfigExclusionWindowsSingleOccurrenceDate
{
    /// <summary>Day of a month.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of a year.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of the date.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderBackupScheduleRpoConfigExclusionWindowsStartTime
{
    /// <summary>Hours of day in 24 hour format.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderBackupScheduleRpoConfigExclusionWindows
{
    /// <summary>The exclusion window occurs every day if set to "True". Specifying this field to "False" is an error. Only one of singleOccurrenceDate, daily and daysOfWeek may be set.</summary>
    [JsonPropertyName("daily")]
    public bool? Daily { get; set; }

    /// <summary>The exclusion window occurs on these days of each week in UTC. Only one of singleOccurrenceDate, daily and daysOfWeek may be set. Structure is documented below.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<V1beta1BackupBackupPlanSpecForProviderBackupScheduleRpoConfigExclusionWindowsDaysOfWeek>? DaysOfWeek { get; set; }

    /// <summary>Specifies duration of the window in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s". Restrictions for duration based on the recurrence type to allow some time for backup to happen:</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>No recurrence. The exclusion window occurs only once and on this date in UTC. Only one of singleOccurrenceDate, daily and daysOfWeek may be set. Structure is documented below.</summary>
    [JsonPropertyName("singleOccurrenceDate")]
    public IList<V1beta1BackupBackupPlanSpecForProviderBackupScheduleRpoConfigExclusionWindowsSingleOccurrenceDate>? SingleOccurrenceDate { get; set; }

    /// <summary>Specifies the start time of the window using time of the day in UTC. Structure is documented below.</summary>
    [JsonPropertyName("startTime")]
    public IList<V1beta1BackupBackupPlanSpecForProviderBackupScheduleRpoConfigExclusionWindowsStartTime>? StartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderBackupScheduleRpoConfig
{
    /// <summary>User specified time windows during which backup can NOT happen for this BackupPlan. Backups should start and finish outside of any given exclusion window. Note: backup jobs will be scheduled to start and finish outside the duration of the window as much as possible, but running jobs will not get canceled when it runs into the window. All the time and date values in exclusionWindows entry in the API are in UTC. We only allow &lt;=1 recurrence (daily or weekly) exclusion window for a BackupPlan while no restriction on number of single occurrence windows. Structure is documented below.</summary>
    [JsonPropertyName("exclusionWindows")]
    public IList<V1beta1BackupBackupPlanSpecForProviderBackupScheduleRpoConfigExclusionWindows>? ExclusionWindows { get; set; }

    /// <summary>Defines the target RPO for the BackupPlan in minutes, which means the target maximum data loss in time that is acceptable for this BackupPlan. This must be at least 60, i.e., 1 hour, and at most 86400, i.e., 60 days.</summary>
    [JsonPropertyName("targetRpoMinutes")]
    public double? TargetRpoMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderBackupSchedule
{
    /// <summary>A standard cron string that defines a repeating schedule for creating Backups via this BackupPlan. If this is defined, then backupRetainDays must also be defined.</summary>
    [JsonPropertyName("cronSchedule")]
    public string? CronSchedule { get; set; }

    /// <summary>This flag denotes whether automatic Backup creation is paused for this BackupPlan.</summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }

    /// <summary>Defines the RPO schedule configuration for this BackupPlan. This is mutually exclusive with the cronSchedule field since at most one schedule can be defined for a BackupPLan. If this is defined, then backupRetainDays must also be defined. Structure is documented below.</summary>
    [JsonPropertyName("rpoConfig")]
    public IList<V1beta1BackupBackupPlanSpecForProviderBackupScheduleRpoConfig>? RpoConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderClusterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in container to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupBackupPlanSpecForProviderClusterRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderClusterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in container to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderClusterSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupBackupPlanSpecForProviderClusterSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProviderRetentionPolicy
{
    /// <summary>Minimum age for a Backup created via this BackupPlan (in days). Must be an integer value between 0-90 (inclusive). A Backup created under this BackupPlan will not be deletable until it reaches Backup's (create time + backup_delete_lock_days). Updating this field of a BackupPlan does not affect existing Backups. Backups created after a successful update will inherit this new value.</summary>
    [JsonPropertyName("backupDeleteLockDays")]
    public double? BackupDeleteLockDays { get; set; }

    /// <summary>The default maximum age of a Backup created via this BackupPlan. This field MUST be an integer value &gt;= 0 and &lt;= 365. If specified, a Backup created under this BackupPlan will be automatically deleted after its age reaches (createTime + backupRetainDays). If not specified, Backups created under this BackupPlan will NOT be subject to automatic deletion. Updating this field does NOT affect existing Backups under it. Backups created AFTER a successful update will automatically pick up the new value. NOTE: backupRetainDays must be &gt;= backupDeleteLockDays. If cronSchedule is defined, then this must be &lt;= 360 * the creation interval.]</summary>
    [JsonPropertyName("backupRetainDays")]
    public double? BackupRetainDays { get; set; }

    /// <summary>This flag denotes whether the retention policy of this BackupPlan is locked. If set to True, no further update is allowed on this policy, including the locked field itself.</summary>
    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecForProvider
{
    /// <summary>Defines the configuration of Backups created via this BackupPlan. Structure is documented below.</summary>
    [JsonPropertyName("backupConfig")]
    public IList<V1beta1BackupBackupPlanSpecForProviderBackupConfig>? BackupConfig { get; set; }

    /// <summary>Defines a schedule for automatic Backup creation via this BackupPlan. Structure is documented below.</summary>
    [JsonPropertyName("backupSchedule")]
    public IList<V1beta1BackupBackupPlanSpecForProviderBackupSchedule>? BackupSchedule { get; set; }

    /// <summary>The source cluster from which Backups will be created via this BackupPlan.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Reference to a Cluster in container to populate cluster.</summary>
    [JsonPropertyName("clusterRef")]
    public V1beta1BackupBackupPlanSpecForProviderClusterRef? ClusterRef { get; set; }

    /// <summary>Selector for a Cluster in container to populate cluster.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta1BackupBackupPlanSpecForProviderClusterSelector? ClusterSelector { get; set; }

    /// <summary>This flag indicates whether this BackupPlan has been deactivated. Setting this field to True locks the BackupPlan such that no further updates will be allowed (except deletes), including the deactivated field itself. It also prevents any new Backups from being created via this BackupPlan (including scheduled Backups).</summary>
    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    /// <summary>User specified descriptive string for this BackupPlan.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Description: A set of custom labels supplied by the user. A list of key-&gt;value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The region of the Backup Plan.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>RetentionPolicy governs lifecycle of Backups created under this plan. Structure is documented below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public IList<V1beta1BackupBackupPlanSpecForProviderRetentionPolicy>? RetentionPolicy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeyRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate gcpKmsEncryptionKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupBackupPlanSpecInitProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeyRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate gcpKmsEncryptionKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupBackupPlanSpecInitProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeySelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderBackupConfigEncryptionKey
{
    /// <summary>Google Cloud KMS encryption key. Format: projects//locations//keyRings//cryptoKeys/</summary>
    [JsonPropertyName("gcpKmsEncryptionKey")]
    public string? GcpKmsEncryptionKey { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate gcpKmsEncryptionKey.</summary>
    [JsonPropertyName("gcpKmsEncryptionKeyRef")]
    public V1beta1BackupBackupPlanSpecInitProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeyRef? GcpKmsEncryptionKeyRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate gcpKmsEncryptionKey.</summary>
    [JsonPropertyName("gcpKmsEncryptionKeySelector")]
    public V1beta1BackupBackupPlanSpecInitProviderBackupConfigEncryptionKeyGcpKmsEncryptionKeySelector? GcpKmsEncryptionKeySelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderBackupConfigSelectedApplicationsNamespacedNames
{
    /// <summary>The name of a Kubernetes Resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a Kubernetes Resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderBackupConfigSelectedApplications
{
    /// <summary>A list of namespaced Kubernetes resources. Structure is documented below.</summary>
    [JsonPropertyName("namespacedNames")]
    public IList<V1beta1BackupBackupPlanSpecInitProviderBackupConfigSelectedApplicationsNamespacedNames>? NamespacedNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderBackupConfigSelectedNamespaces
{
    /// <summary>A list of Kubernetes Namespaces.</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderBackupConfig
{
    /// <summary>If True, include all namespaced resources.</summary>
    [JsonPropertyName("allNamespaces")]
    public bool? AllNamespaces { get; set; }

    /// <summary>This defines a customer managed encryption key that will be used to encrypt the "config" portion (the Kubernetes resources) of Backups created via this plan. Structure is documented below.</summary>
    [JsonPropertyName("encryptionKey")]
    public IList<V1beta1BackupBackupPlanSpecInitProviderBackupConfigEncryptionKey>? EncryptionKey { get; set; }

    /// <summary>This flag specifies whether Kubernetes Secret resources should be included when they fall into the scope of Backups.</summary>
    [JsonPropertyName("includeSecrets")]
    public bool? IncludeSecrets { get; set; }

    /// <summary>This flag specifies whether volume data should be backed up when PVCs are included in the scope of a Backup.</summary>
    [JsonPropertyName("includeVolumeData")]
    public bool? IncludeVolumeData { get; set; }

    /// <summary>This flag specifies whether Backups will not fail when Backup for GKE detects Kubernetes configuration that is non-standard or requires additional setup to restore.</summary>
    [JsonPropertyName("permissiveMode")]
    public bool? PermissiveMode { get; set; }

    /// <summary>A list of namespaced Kubernetes Resources. Structure is documented below.</summary>
    [JsonPropertyName("selectedApplications")]
    public IList<V1beta1BackupBackupPlanSpecInitProviderBackupConfigSelectedApplications>? SelectedApplications { get; set; }

    /// <summary>If set, include just the resources in the listed namespaces. Structure is documented below.</summary>
    [JsonPropertyName("selectedNamespaces")]
    public IList<V1beta1BackupBackupPlanSpecInitProviderBackupConfigSelectedNamespaces>? SelectedNamespaces { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderBackupScheduleRpoConfigExclusionWindowsDaysOfWeek
{
    /// <summary>The exclusion window occurs on these days of each week in UTC. Only one of singleOccurrenceDate, daily and daysOfWeek may be set. Structure is documented below.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderBackupScheduleRpoConfigExclusionWindowsSingleOccurrenceDate
{
    /// <summary>Day of a month.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of a year.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of the date.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderBackupScheduleRpoConfigExclusionWindowsStartTime
{
    /// <summary>Hours of day in 24 hour format.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderBackupScheduleRpoConfigExclusionWindows
{
    /// <summary>The exclusion window occurs every day if set to "True". Specifying this field to "False" is an error. Only one of singleOccurrenceDate, daily and daysOfWeek may be set.</summary>
    [JsonPropertyName("daily")]
    public bool? Daily { get; set; }

    /// <summary>The exclusion window occurs on these days of each week in UTC. Only one of singleOccurrenceDate, daily and daysOfWeek may be set. Structure is documented below.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<V1beta1BackupBackupPlanSpecInitProviderBackupScheduleRpoConfigExclusionWindowsDaysOfWeek>? DaysOfWeek { get; set; }

    /// <summary>Specifies duration of the window in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s". Restrictions for duration based on the recurrence type to allow some time for backup to happen:</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>No recurrence. The exclusion window occurs only once and on this date in UTC. Only one of singleOccurrenceDate, daily and daysOfWeek may be set. Structure is documented below.</summary>
    [JsonPropertyName("singleOccurrenceDate")]
    public IList<V1beta1BackupBackupPlanSpecInitProviderBackupScheduleRpoConfigExclusionWindowsSingleOccurrenceDate>? SingleOccurrenceDate { get; set; }

    /// <summary>Specifies the start time of the window using time of the day in UTC. Structure is documented below.</summary>
    [JsonPropertyName("startTime")]
    public IList<V1beta1BackupBackupPlanSpecInitProviderBackupScheduleRpoConfigExclusionWindowsStartTime>? StartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderBackupScheduleRpoConfig
{
    /// <summary>User specified time windows during which backup can NOT happen for this BackupPlan. Backups should start and finish outside of any given exclusion window. Note: backup jobs will be scheduled to start and finish outside the duration of the window as much as possible, but running jobs will not get canceled when it runs into the window. All the time and date values in exclusionWindows entry in the API are in UTC. We only allow &lt;=1 recurrence (daily or weekly) exclusion window for a BackupPlan while no restriction on number of single occurrence windows. Structure is documented below.</summary>
    [JsonPropertyName("exclusionWindows")]
    public IList<V1beta1BackupBackupPlanSpecInitProviderBackupScheduleRpoConfigExclusionWindows>? ExclusionWindows { get; set; }

    /// <summary>Defines the target RPO for the BackupPlan in minutes, which means the target maximum data loss in time that is acceptable for this BackupPlan. This must be at least 60, i.e., 1 hour, and at most 86400, i.e., 60 days.</summary>
    [JsonPropertyName("targetRpoMinutes")]
    public double? TargetRpoMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderBackupSchedule
{
    /// <summary>A standard cron string that defines a repeating schedule for creating Backups via this BackupPlan. If this is defined, then backupRetainDays must also be defined.</summary>
    [JsonPropertyName("cronSchedule")]
    public string? CronSchedule { get; set; }

    /// <summary>This flag denotes whether automatic Backup creation is paused for this BackupPlan.</summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }

    /// <summary>Defines the RPO schedule configuration for this BackupPlan. This is mutually exclusive with the cronSchedule field since at most one schedule can be defined for a BackupPLan. If this is defined, then backupRetainDays must also be defined. Structure is documented below.</summary>
    [JsonPropertyName("rpoConfig")]
    public IList<V1beta1BackupBackupPlanSpecInitProviderBackupScheduleRpoConfig>? RpoConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderClusterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in container to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupBackupPlanSpecInitProviderClusterRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderClusterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in container to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderClusterSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupBackupPlanSpecInitProviderClusterSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProviderRetentionPolicy
{
    /// <summary>Minimum age for a Backup created via this BackupPlan (in days). Must be an integer value between 0-90 (inclusive). A Backup created under this BackupPlan will not be deletable until it reaches Backup's (create time + backup_delete_lock_days). Updating this field of a BackupPlan does not affect existing Backups. Backups created after a successful update will inherit this new value.</summary>
    [JsonPropertyName("backupDeleteLockDays")]
    public double? BackupDeleteLockDays { get; set; }

    /// <summary>The default maximum age of a Backup created via this BackupPlan. This field MUST be an integer value &gt;= 0 and &lt;= 365. If specified, a Backup created under this BackupPlan will be automatically deleted after its age reaches (createTime + backupRetainDays). If not specified, Backups created under this BackupPlan will NOT be subject to automatic deletion. Updating this field does NOT affect existing Backups under it. Backups created AFTER a successful update will automatically pick up the new value. NOTE: backupRetainDays must be &gt;= backupDeleteLockDays. If cronSchedule is defined, then this must be &lt;= 360 * the creation interval.]</summary>
    [JsonPropertyName("backupRetainDays")]
    public double? BackupRetainDays { get; set; }

    /// <summary>This flag denotes whether the retention policy of this BackupPlan is locked. If set to True, no further update is allowed on this policy, including the locked field itself.</summary>
    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecInitProvider
{
    /// <summary>Defines the configuration of Backups created via this BackupPlan. Structure is documented below.</summary>
    [JsonPropertyName("backupConfig")]
    public IList<V1beta1BackupBackupPlanSpecInitProviderBackupConfig>? BackupConfig { get; set; }

    /// <summary>Defines a schedule for automatic Backup creation via this BackupPlan. Structure is documented below.</summary>
    [JsonPropertyName("backupSchedule")]
    public IList<V1beta1BackupBackupPlanSpecInitProviderBackupSchedule>? BackupSchedule { get; set; }

    /// <summary>The source cluster from which Backups will be created via this BackupPlan.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Reference to a Cluster in container to populate cluster.</summary>
    [JsonPropertyName("clusterRef")]
    public V1beta1BackupBackupPlanSpecInitProviderClusterRef? ClusterRef { get; set; }

    /// <summary>Selector for a Cluster in container to populate cluster.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta1BackupBackupPlanSpecInitProviderClusterSelector? ClusterSelector { get; set; }

    /// <summary>This flag indicates whether this BackupPlan has been deactivated. Setting this field to True locks the BackupPlan such that no further updates will be allowed (except deletes), including the deactivated field itself. It also prevents any new Backups from being created via this BackupPlan (including scheduled Backups).</summary>
    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    /// <summary>User specified descriptive string for this BackupPlan.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Description: A set of custom labels supplied by the user. A list of key-&gt;value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>RetentionPolicy governs lifecycle of Backups created under this plan. Structure is documented below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public IList<V1beta1BackupBackupPlanSpecInitProviderRetentionPolicy>? RetentionPolicy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupBackupPlanSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupBackupPlanSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecPublishConnectionDetailsToMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BackupBackupPlanSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BackupBackupPlanSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>BackupBackupPlanSpec defines the desired state of BackupBackupPlan</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BackupBackupPlanSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BackupBackupPlanSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BackupBackupPlanSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BackupBackupPlanSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BackupBackupPlanSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanStatusAtProviderBackupConfigEncryptionKey
{
    /// <summary>Google Cloud KMS encryption key. Format: projects//locations//keyRings//cryptoKeys/</summary>
    [JsonPropertyName("gcpKmsEncryptionKey")]
    public string? GcpKmsEncryptionKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanStatusAtProviderBackupConfigSelectedApplicationsNamespacedNames
{
    /// <summary>The name of a Kubernetes Resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a Kubernetes Resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanStatusAtProviderBackupConfigSelectedApplications
{
    /// <summary>A list of namespaced Kubernetes resources. Structure is documented below.</summary>
    [JsonPropertyName("namespacedNames")]
    public IList<V1beta1BackupBackupPlanStatusAtProviderBackupConfigSelectedApplicationsNamespacedNames>? NamespacedNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanStatusAtProviderBackupConfigSelectedNamespaces
{
    /// <summary>A list of Kubernetes Namespaces.</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanStatusAtProviderBackupConfig
{
    /// <summary>If True, include all namespaced resources.</summary>
    [JsonPropertyName("allNamespaces")]
    public bool? AllNamespaces { get; set; }

    /// <summary>This defines a customer managed encryption key that will be used to encrypt the "config" portion (the Kubernetes resources) of Backups created via this plan. Structure is documented below.</summary>
    [JsonPropertyName("encryptionKey")]
    public IList<V1beta1BackupBackupPlanStatusAtProviderBackupConfigEncryptionKey>? EncryptionKey { get; set; }

    /// <summary>This flag specifies whether Kubernetes Secret resources should be included when they fall into the scope of Backups.</summary>
    [JsonPropertyName("includeSecrets")]
    public bool? IncludeSecrets { get; set; }

    /// <summary>This flag specifies whether volume data should be backed up when PVCs are included in the scope of a Backup.</summary>
    [JsonPropertyName("includeVolumeData")]
    public bool? IncludeVolumeData { get; set; }

    /// <summary>This flag specifies whether Backups will not fail when Backup for GKE detects Kubernetes configuration that is non-standard or requires additional setup to restore.</summary>
    [JsonPropertyName("permissiveMode")]
    public bool? PermissiveMode { get; set; }

    /// <summary>A list of namespaced Kubernetes Resources. Structure is documented below.</summary>
    [JsonPropertyName("selectedApplications")]
    public IList<V1beta1BackupBackupPlanStatusAtProviderBackupConfigSelectedApplications>? SelectedApplications { get; set; }

    /// <summary>If set, include just the resources in the listed namespaces. Structure is documented below.</summary>
    [JsonPropertyName("selectedNamespaces")]
    public IList<V1beta1BackupBackupPlanStatusAtProviderBackupConfigSelectedNamespaces>? SelectedNamespaces { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanStatusAtProviderBackupScheduleRpoConfigExclusionWindowsDaysOfWeek
{
    /// <summary>The exclusion window occurs on these days of each week in UTC. Only one of singleOccurrenceDate, daily and daysOfWeek may be set. Structure is documented below.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanStatusAtProviderBackupScheduleRpoConfigExclusionWindowsSingleOccurrenceDate
{
    /// <summary>Day of a month.</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of a year.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of the date.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanStatusAtProviderBackupScheduleRpoConfigExclusionWindowsStartTime
{
    /// <summary>Hours of day in 24 hour format.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanStatusAtProviderBackupScheduleRpoConfigExclusionWindows
{
    /// <summary>The exclusion window occurs every day if set to "True". Specifying this field to "False" is an error. Only one of singleOccurrenceDate, daily and daysOfWeek may be set.</summary>
    [JsonPropertyName("daily")]
    public bool? Daily { get; set; }

    /// <summary>The exclusion window occurs on these days of each week in UTC. Only one of singleOccurrenceDate, daily and daysOfWeek may be set. Structure is documented below.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<V1beta1BackupBackupPlanStatusAtProviderBackupScheduleRpoConfigExclusionWindowsDaysOfWeek>? DaysOfWeek { get; set; }

    /// <summary>Specifies duration of the window in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s". Restrictions for duration based on the recurrence type to allow some time for backup to happen:</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>No recurrence. The exclusion window occurs only once and on this date in UTC. Only one of singleOccurrenceDate, daily and daysOfWeek may be set. Structure is documented below.</summary>
    [JsonPropertyName("singleOccurrenceDate")]
    public IList<V1beta1BackupBackupPlanStatusAtProviderBackupScheduleRpoConfigExclusionWindowsSingleOccurrenceDate>? SingleOccurrenceDate { get; set; }

    /// <summary>Specifies the start time of the window using time of the day in UTC. Structure is documented below.</summary>
    [JsonPropertyName("startTime")]
    public IList<V1beta1BackupBackupPlanStatusAtProviderBackupScheduleRpoConfigExclusionWindowsStartTime>? StartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanStatusAtProviderBackupScheduleRpoConfig
{
    /// <summary>User specified time windows during which backup can NOT happen for this BackupPlan. Backups should start and finish outside of any given exclusion window. Note: backup jobs will be scheduled to start and finish outside the duration of the window as much as possible, but running jobs will not get canceled when it runs into the window. All the time and date values in exclusionWindows entry in the API are in UTC. We only allow &lt;=1 recurrence (daily or weekly) exclusion window for a BackupPlan while no restriction on number of single occurrence windows. Structure is documented below.</summary>
    [JsonPropertyName("exclusionWindows")]
    public IList<V1beta1BackupBackupPlanStatusAtProviderBackupScheduleRpoConfigExclusionWindows>? ExclusionWindows { get; set; }

    /// <summary>Defines the target RPO for the BackupPlan in minutes, which means the target maximum data loss in time that is acceptable for this BackupPlan. This must be at least 60, i.e., 1 hour, and at most 86400, i.e., 60 days.</summary>
    [JsonPropertyName("targetRpoMinutes")]
    public double? TargetRpoMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanStatusAtProviderBackupSchedule
{
    /// <summary>A standard cron string that defines a repeating schedule for creating Backups via this BackupPlan. If this is defined, then backupRetainDays must also be defined.</summary>
    [JsonPropertyName("cronSchedule")]
    public string? CronSchedule { get; set; }

    /// <summary>This flag denotes whether automatic Backup creation is paused for this BackupPlan.</summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }

    /// <summary>Defines the RPO schedule configuration for this BackupPlan. This is mutually exclusive with the cronSchedule field since at most one schedule can be defined for a BackupPLan. If this is defined, then backupRetainDays must also be defined. Structure is documented below.</summary>
    [JsonPropertyName("rpoConfig")]
    public IList<V1beta1BackupBackupPlanStatusAtProviderBackupScheduleRpoConfig>? RpoConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanStatusAtProviderRetentionPolicy
{
    /// <summary>Minimum age for a Backup created via this BackupPlan (in days). Must be an integer value between 0-90 (inclusive). A Backup created under this BackupPlan will not be deletable until it reaches Backup's (create time + backup_delete_lock_days). Updating this field of a BackupPlan does not affect existing Backups. Backups created after a successful update will inherit this new value.</summary>
    [JsonPropertyName("backupDeleteLockDays")]
    public double? BackupDeleteLockDays { get; set; }

    /// <summary>The default maximum age of a Backup created via this BackupPlan. This field MUST be an integer value &gt;= 0 and &lt;= 365. If specified, a Backup created under this BackupPlan will be automatically deleted after its age reaches (createTime + backupRetainDays). If not specified, Backups created under this BackupPlan will NOT be subject to automatic deletion. Updating this field does NOT affect existing Backups under it. Backups created AFTER a successful update will automatically pick up the new value. NOTE: backupRetainDays must be &gt;= backupDeleteLockDays. If cronSchedule is defined, then this must be &lt;= 360 * the creation interval.]</summary>
    [JsonPropertyName("backupRetainDays")]
    public double? BackupRetainDays { get; set; }

    /// <summary>This flag denotes whether the retention policy of this BackupPlan is locked. If set to True, no further update is allowed on this policy, including the locked field itself.</summary>
    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanStatusAtProvider
{
    /// <summary>Defines the configuration of Backups created via this BackupPlan. Structure is documented below.</summary>
    [JsonPropertyName("backupConfig")]
    public IList<V1beta1BackupBackupPlanStatusAtProviderBackupConfig>? BackupConfig { get; set; }

    /// <summary>Defines a schedule for automatic Backup creation via this BackupPlan. Structure is documented below.</summary>
    [JsonPropertyName("backupSchedule")]
    public IList<V1beta1BackupBackupPlanStatusAtProviderBackupSchedule>? BackupSchedule { get; set; }

    /// <summary>The source cluster from which Backups will be created via this BackupPlan.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>This flag indicates whether this BackupPlan has been deactivated. Setting this field to True locks the BackupPlan such that no further updates will be allowed (except deletes), including the deactivated field itself. It also prevents any new Backups from being created via this BackupPlan (including scheduled Backups).</summary>
    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    /// <summary>User specified descriptive string for this BackupPlan.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a backup plan from overwriting each other. It is strongly suggested that systems make use of the 'etag' in the read-modify-write cycle to perform BackupPlan updates in order to avoid race conditions: An etag is returned in the response to backupPlans.get, and systems are expected to put that etag in the request to backupPlans.patch or backupPlans.delete to ensure that their change will be applied to the same version of the resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/backupPlans/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Description: A set of custom labels supplied by the user. A list of key-&gt;value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The region of the Backup Plan.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The number of Kubernetes Pods backed up in the last successful Backup created via this BackupPlan.</summary>
    [JsonPropertyName("protectedPodCount")]
    public double? ProtectedPodCount { get; set; }

    /// <summary>RetentionPolicy governs lifecycle of Backups created under this plan. Structure is documented below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public IList<V1beta1BackupBackupPlanStatusAtProviderRetentionPolicy>? RetentionPolicy { get; set; }

    /// <summary>The State of the BackupPlan.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Detailed description of why BackupPlan is in its current state.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Server generated, unique identifier of UUID format.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanStatusConditions
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

/// <summary>BackupBackupPlanStatus defines the observed state of BackupBackupPlan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupBackupPlanStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BackupBackupPlanStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BackupBackupPlanStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BackupBackupPlan is the Schema for the BackupBackupPlans API. Represents a Backup Plan instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackupBackupPlan : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BackupBackupPlanSpec>, IStatus<V1beta1BackupBackupPlanStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackupBackupPlan";
    public const string KubeGroup = "gke.gcp.upbound.io";
    public const string KubePluralName = "backupbackupplans";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupBackupPlanSpec defines the desired state of BackupBackupPlan</summary>
    [JsonPropertyName("spec")]
    public V1beta1BackupBackupPlanSpec Spec { get; set; }

    /// <summary>BackupBackupPlanStatus defines the observed state of BackupBackupPlan.</summary>
    [JsonPropertyName("status")]
    public V1beta1BackupBackupPlanStatus? Status { get; set; }
}