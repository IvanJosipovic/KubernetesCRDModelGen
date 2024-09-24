using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gkebackup.cnrm.cloud.google.com;
public partial class V1alpha1GKEBackupBackupPlanSpecBackupConfigEncryptionKey
{
    /// <summary>Google Cloud KMS encryption key. Format: projects/*/locations/*/keyRings/*/cryptoKeys/*.</summary>
    [JsonPropertyName("gcpKmsEncryptionKey")]
    public string GcpKmsEncryptionKey { get; set; }
}

public partial class V1alpha1GKEBackupBackupPlanSpecBackupConfigSelectedApplicationsNamespacedNames
{
    /// <summary>The name of a Kubernetes Resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The namespace of a Kubernetes Resource.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1alpha1GKEBackupBackupPlanSpecBackupConfigSelectedApplications
{
    /// <summary>A list of namespaced Kubernetes resources.</summary>
    [JsonPropertyName("namespacedNames")]
    public IList<V1alpha1GKEBackupBackupPlanSpecBackupConfigSelectedApplicationsNamespacedNames> NamespacedNames { get; set; }
}

public partial class V1alpha1GKEBackupBackupPlanSpecBackupConfigSelectedNamespaces
{
    /// <summary>A list of Kubernetes Namespaces.</summary>
    [JsonPropertyName("namespaces")]
    public IList<string> Namespaces { get; set; }
}

public partial class V1alpha1GKEBackupBackupPlanSpecBackupConfig
{
    /// <summary>If True, include all namespaced resources.</summary>
    [JsonPropertyName("allNamespaces")]
    public bool? AllNamespaces { get; set; }

    /// <summary>This defines a customer managed encryption key that will be used to encrypt the "config" portion (the Kubernetes resources) of Backups created via this plan.</summary>
    [JsonPropertyName("encryptionKey")]
    public V1alpha1GKEBackupBackupPlanSpecBackupConfigEncryptionKey? EncryptionKey { get; set; }

    /// <summary>This flag specifies whether Kubernetes Secret resources should be included when they fall into the scope of Backups.</summary>
    [JsonPropertyName("includeSecrets")]
    public bool? IncludeSecrets { get; set; }

    /// <summary>This flag specifies whether volume data should be backed up when PVCs are included in the scope of a Backup.</summary>
    [JsonPropertyName("includeVolumeData")]
    public bool? IncludeVolumeData { get; set; }

    /// <summary>A list of namespaced Kubernetes Resources.</summary>
    [JsonPropertyName("selectedApplications")]
    public V1alpha1GKEBackupBackupPlanSpecBackupConfigSelectedApplications? SelectedApplications { get; set; }

    /// <summary>If set, include just the resources in the listed namespaces.</summary>
    [JsonPropertyName("selectedNamespaces")]
    public V1alpha1GKEBackupBackupPlanSpecBackupConfigSelectedNamespaces? SelectedNamespaces { get; set; }
}

public partial class V1alpha1GKEBackupBackupPlanSpecBackupSchedule
{
    /// <summary>A standard cron string that defines a repeating schedule for creating Backups via this BackupPlan. If this is defined, then backupRetainDays must also be defined.</summary>
    [JsonPropertyName("cronSchedule")]
    public string? CronSchedule { get; set; }

    /// <summary>This flag denotes whether automatic Backup creation is paused for this BackupPlan.</summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }
}

public partial class V1alpha1GKEBackupBackupPlanSpecProjectRef
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

public partial class V1alpha1GKEBackupBackupPlanSpecRetentionPolicy
{
    /// <summary>Minimum age for a Backup created via this BackupPlan (in days). Must be an integer value between 0-90 (inclusive). A Backup created under this BackupPlan will not be deletable until it reaches Backup's (create time + backup_delete_lock_days). Updating this field of a BackupPlan does not affect existing Backups. Backups created after a successful update will inherit this new value.</summary>
    [JsonPropertyName("backupDeleteLockDays")]
    public int? BackupDeleteLockDays { get; set; }

    /// <summary>The default maximum age of a Backup created via this BackupPlan. This field MUST be an integer value >= 0 and <= 365. If specified, a Backup created under this BackupPlan will be automatically deleted after its age reaches (createTime + backupRetainDays). If not specified, Backups created under this BackupPlan will NOT be subject to automatic deletion. Updating this field does NOT affect existing Backups under it. Backups created AFTER a successful update will automatically pick up the new value. NOTE: backupRetainDays must be >= backupDeleteLockDays. If cronSchedule is defined, then this must be <= 360 * the creation interval.].</summary>
    [JsonPropertyName("backupRetainDays")]
    public int? BackupRetainDays { get; set; }

    /// <summary>This flag denotes whether the retention policy of this BackupPlan is locked. If set to True, no further update is allowed on this policy, including the locked field itself.</summary>
    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }
}

public partial class V1alpha1GKEBackupBackupPlanSpec
{
    /// <summary>Defines the configuration of Backups created via this BackupPlan.</summary>
    [JsonPropertyName("backupConfig")]
    public V1alpha1GKEBackupBackupPlanSpecBackupConfig? BackupConfig { get; set; }

    /// <summary>Defines a schedule for automatic Backup creation via this BackupPlan.</summary>
    [JsonPropertyName("backupSchedule")]
    public V1alpha1GKEBackupBackupPlanSpecBackupSchedule? BackupSchedule { get; set; }

    /// <summary>Immutable. The source cluster from which Backups will be created via this BackupPlan.</summary>
    [JsonPropertyName("cluster")]
    public string Cluster { get; set; }

    /// <summary>This flag indicates whether this BackupPlan has been deactivated. Setting this field to True locks the BackupPlan such that no further updates will be allowed (except deletes), including the deactivated field itself. It also prevents any new Backups from being created via this BackupPlan (including scheduled Backups).</summary>
    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    /// <summary>User specified descriptive string for this BackupPlan.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The region of the Backup Plan.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1GKEBackupBackupPlanSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>RetentionPolicy governs lifecycle of Backups created under this plan.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1alpha1GKEBackupBackupPlanSpecRetentionPolicy? RetentionPolicy { get; set; }
}

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

public partial class V1alpha1GKEBackupBackupPlanStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1GKEBackupBackupPlanStatusConditions>? Conditions { get; set; }

    /// <summary>etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a backup plan from overwriting each other. It is strongly suggested that systems make use of the 'etag' in the read-modify-write cycle to perform BackupPlan updates in order to avoid race conditions: An etag is returned in the response to backupPlans.get, and systems are expected to put that etag in the request to backupPlans.patch or backupPlans.delete to ensure that their change will be applied to the same version of the resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The number of Kubernetes Pods backed up in the last successful Backup created via this BackupPlan.</summary>
    [JsonPropertyName("protectedPodCount")]
    public int? ProtectedPodCount { get; set; }

    /// <summary>The State of the BackupPlan.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Detailed description of why BackupPlan is in its current state.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>Server generated, unique identifier of UUID format.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

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

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1GKEBackupBackupPlanSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1GKEBackupBackupPlanStatus? Status { get; set; }
}