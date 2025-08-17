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
/// <summary>GKEBackupBackup is the Schema for the GKEBackupBackup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GKEBackupBackupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1GKEBackupBackup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GKEBackupBackupList";
    public const string KubeGroup = "gkebackup.cnrm.cloud.google.com";
    public const string KubePluralName = "gkebackupbackups";
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
    public IList<V1alpha1GKEBackupBackup> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. The BackupPlan from which this Backup is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupSpecBackupPlanRef
{
    /// <summary>A reference to an externally managed GKEBackupBackupPlan resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/backupPlans/{{backupplanID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a GKEBackupBackupPlan resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a GKEBackupBackupPlan resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>GKEBackupBackupSpec defines the desired state of GKEBackupBackup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupSpec
{
    /// <summary>Required. The BackupPlan from which this Backup is created.</summary>
    [JsonPropertyName("backupPlanRef")]
    public V1alpha1GKEBackupBackupSpecBackupPlanRef BackupPlanRef { get; set; }

    /// <summary>Optional. Minimum age for this Backup (in days). If this field is set to a  non-zero value, the Backup will be "locked" against deletion (either manual  or automatic deletion) for the number of days provided (measured from the  creation time of the Backup).  MUST be an integer value between 0-90  (inclusive).   Defaults to parent BackupPlan's  [backup_delete_lock_days][google.cloud.gkebackup.v1.BackupPlan.RetentionPolicy.backup_delete_lock_days]  setting and may only be increased  (either at creation time or in a subsequent update).</summary>
    [JsonPropertyName("deleteLockDays")]
    public int? DeleteLockDays { get; set; }

    /// <summary>Optional. User specified descriptive string for this Backup.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. A set of custom labels supplied by user.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The GKEBackupBackup name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The age (in days) after which this Backup will be automatically  deleted. Must be an integer value &gt;= 0:   - If 0, no automatic deletion will occur for this Backup.  - If not 0, this must be &gt;=  [delete_lock_days][google.cloud.gkebackup.v1.Backup.delete_lock_days] and  &lt;= 365.   Once a Backup is created, this value may only be increased.   Defaults to the parent BackupPlan's  [backup_retain_days][google.cloud.gkebackup.v1.BackupPlan.RetentionPolicy.backup_retain_days]  value.</summary>
    [JsonPropertyName("retainDays")]
    public int? RetainDays { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupStatusConditions
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
/// <summary>Output only. Information about the GKE cluster from which this Backup was created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupStatusObservedStateClusterMetadata
{
    /// <summary>Output only. Anthos version</summary>
    [JsonPropertyName("anthosVersion")]
    public string? AnthosVersion { get; set; }

    /// <summary>Output only. A list of the Backup for GKE CRD versions found in the cluster.</summary>
    [JsonPropertyName("backupCRDVersions")]
    public IDictionary<string, string>? BackupCRDVersions { get; set; }

    /// <summary>Output only. The source cluster from which this Backup was created.  Valid formats:     - `projects/*/locations/*/clusters/*`    - `projects/*/zones/*/clusters/*`   This is inherited from the parent BackupPlan's  [cluster][google.cloud.gkebackup.v1.BackupPlan.cluster] field.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Output only. GKE version</summary>
    [JsonPropertyName("gkeVersion")]
    public string? GkeVersion { get; set; }

    /// <summary>Output only. The Kubernetes server version of the source cluster.</summary>
    [JsonPropertyName("k8sVersion")]
    public string? K8sVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. The customer managed encryption key that was used to encrypt the Backup's artifacts.  Inherited from the parent BackupPlan's [encryption_key][google.cloud.gkebackup.v1.BackupPlan.BackupConfig.encryption_key] value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupStatusObservedStateEncryptionKey
{
    /// <summary>Optional. Google Cloud KMS encryption key. Format: `projects/*/locations/*/keyRings/*/cryptoKeys/*`</summary>
    [JsonPropertyName("gcpKMSEncryptionKey")]
    public string? GcpKMSEncryptionKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupStatusObservedStateSelectedApplicationsNamespacedNames
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
/// <summary>Output only. If set, the list of ProtectedApplications whose resources were included in the Backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupStatusObservedStateSelectedApplications
{
    /// <summary>Optional. A list of namespaced Kubernetes resources.</summary>
    [JsonPropertyName("namespacedNames")]
    public IList<V1alpha1GKEBackupBackupStatusObservedStateSelectedApplicationsNamespacedNames>? NamespacedNames { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Output only. If set, the list of namespaces that were included in the Backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupStatusObservedStateSelectedNamespaces
{
    /// <summary>Optional. A list of Kubernetes Namespaces</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupStatusObservedState
{
    /// <summary>Output only. If True, all namespaces were included in the Backup.</summary>
    [JsonPropertyName("allNamespaces")]
    public bool? AllNamespaces { get; set; }

    /// <summary>Output only. Information about the GKE cluster from which this Backup was created.</summary>
    [JsonPropertyName("clusterMetadata")]
    public V1alpha1GKEBackupBackupStatusObservedStateClusterMetadata? ClusterMetadata { get; set; }

    /// <summary>Output only. Completion time of the Backup</summary>
    [JsonPropertyName("completeTime")]
    public string? CompleteTime { get; set; }

    /// <summary>Output only. The size of the config backup in bytes.</summary>
    [JsonPropertyName("configBackupSizeBytes")]
    public long? ConfigBackupSizeBytes { get; set; }

    /// <summary>Output only. Whether or not the Backup contains Kubernetes Secrets. Controlled by the parent BackupPlan's [include_secrets][google.cloud.gkebackup.v1.BackupPlan.BackupConfig.include_secrets] value.</summary>
    [JsonPropertyName("containsSecrets")]
    public bool? ContainsSecrets { get; set; }

    /// <summary>Output only. Whether or not the Backup contains volume data.  Controlled by the parent BackupPlan's [include_volume_data][google.cloud.gkebackup.v1.BackupPlan.BackupConfig.include_volume_data] value.</summary>
    [JsonPropertyName("containsVolumeData")]
    public bool? ContainsVolumeData { get; set; }

    /// <summary>Output only. The timestamp when this Backup resource was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The time at which an existing delete lock will expire for this backup (calculated from create_time + [delete_lock_days][google.cloud.gkebackup.v1.Backup.delete_lock_days]).</summary>
    [JsonPropertyName("deleteLockExpireTime")]
    public string? DeleteLockExpireTime { get; set; }

    /// <summary>Output only. The customer managed encryption key that was used to encrypt the Backup's artifacts.  Inherited from the parent BackupPlan's [encryption_key][google.cloud.gkebackup.v1.BackupPlan.BackupConfig.encryption_key] value.</summary>
    [JsonPropertyName("encryptionKey")]
    public V1alpha1GKEBackupBackupStatusObservedStateEncryptionKey? EncryptionKey { get; set; }

    /// <summary>Output only. `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a backup from overwriting each other. It is strongly suggested that systems make use of the `etag` in the read-modify-write cycle to perform backup updates in order to avoid race conditions: An `etag` is returned in the response to `GetBackup`, and systems are expected to put that etag in the request to `UpdateBackup` or `DeleteBackup` to ensure that their change will be applied to the same version of the resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. This flag indicates whether this Backup resource was created manually by a user or via a schedule in the BackupPlan. A value of True means that the Backup was created manually.</summary>
    [JsonPropertyName("manual")]
    public bool? Manual { get; set; }

    /// <summary>Output only. If false, Backup will fail when Backup for GKE detects  Kubernetes configuration that is non-standard or  requires additional setup to restore.   Inherited from the parent BackupPlan's  [permissive_mode][google.cloud.gkebackup.v1.BackupPlan.BackupConfig.permissive_mode]  value.</summary>
    [JsonPropertyName("permissiveMode")]
    public bool? PermissiveMode { get; set; }

    /// <summary>Output only. The total number of Kubernetes Pods contained in the Backup.</summary>
    [JsonPropertyName("podCount")]
    public int? PodCount { get; set; }

    /// <summary>Output only. The total number of Kubernetes resources included in the Backup.</summary>
    [JsonPropertyName("resourceCount")]
    public int? ResourceCount { get; set; }

    /// <summary>Output only. The time at which this Backup will be automatically deleted (calculated from create_time + [retain_days][google.cloud.gkebackup.v1.Backup.retain_days]).</summary>
    [JsonPropertyName("retainExpireTime")]
    public string? RetainExpireTime { get; set; }

    /// <summary>Output only. If set, the list of ProtectedApplications whose resources were included in the Backup.</summary>
    [JsonPropertyName("selectedApplications")]
    public V1alpha1GKEBackupBackupStatusObservedStateSelectedApplications? SelectedApplications { get; set; }

    /// <summary>Output only. If set, the list of namespaces that were included in the Backup.</summary>
    [JsonPropertyName("selectedNamespaces")]
    public V1alpha1GKEBackupBackupStatusObservedStateSelectedNamespaces? SelectedNamespaces { get; set; }

    /// <summary>Output only. The total size of the Backup in bytes = config backup size + sum(volume backup sizes)</summary>
    [JsonPropertyName("sizeBytes")]
    public long? SizeBytes { get; set; }

    /// <summary>Output only. Current state of the Backup</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Human-readable description of why the backup is in the current `state`.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>Output only. Server generated global unique identifier of [UUID4](https://en.wikipedia.org/wiki/Universally_unique_identifier)</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The timestamp when this Backup resource was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. The total number of volume backups contained in the Backup.</summary>
    [JsonPropertyName("volumeCount")]
    public int? VolumeCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>GKEBackupBackupStatus defines the config connector machine state of GKEBackupBackup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEBackupBackupStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1GKEBackupBackupStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the GKEBackupBackup resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1GKEBackupBackupStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>GKEBackupBackup is the Schema for the GKEBackupBackup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GKEBackupBackup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1GKEBackupBackupSpec>, IStatus<V1alpha1GKEBackupBackupStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GKEBackupBackup";
    public const string KubeGroup = "gkebackup.cnrm.cloud.google.com";
    public const string KubePluralName = "gkebackupbackups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GKEBackupBackupSpec defines the desired state of GKEBackupBackup</summary>
    [JsonPropertyName("spec")]
    public V1alpha1GKEBackupBackupSpec Spec { get; set; }

    /// <summary>GKEBackupBackupStatus defines the config connector machine state of GKEBackupBackup</summary>
    [JsonPropertyName("status")]
    public V1alpha1GKEBackupBackupStatus? Status { get; set; }
}
#nullable disable
