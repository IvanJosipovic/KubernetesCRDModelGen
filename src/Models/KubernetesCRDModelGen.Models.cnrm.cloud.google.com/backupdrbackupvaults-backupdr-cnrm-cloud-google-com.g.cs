using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.backupdr.cnrm.cloud.google.com;
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupVaultSpecProjectRef
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

/// <summary>BackupDRBackupVaultSpec defines the desired state of BackupDRBackupVault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupVaultSpec
{
    /// <summary>Optional. Note: This field is added for future use case and will not be  supported in the current release.   Access restriction for the backup vault.  Default value is WITHIN_ORGANIZATION if not provided during creation.</summary>
    [JsonPropertyName("accessRestriction")]
    public string? AccessRestriction { get; set; }

    /// <summary>Optional. User annotations. See https://google.aip.dev/128#annotations Stores small amounts of arbitrary data.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Required. The default and minimum enforced retention for each backup within the backup vault.  The enforced retention for each backup can be extended.</summary>
    [JsonPropertyName("backupMinimumEnforcedRetentionDuration")]
    public string BackupMinimumEnforcedRetentionDuration { get; set; }

    /// <summary>Optional. The description of the BackupVault instance (2048 characters or less).</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Time after which the BackupVault resource is locked.</summary>
    [JsonPropertyName("effectiveTime")]
    public string? EffectiveTime { get; set; }

    /// <summary>Optional. Server specified ETag for the backup vault resource to prevent simultaneous updates from overwiting each other.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Optional. If set to true, allows deletion of a backup vault even when it contains inactive data sources. This overrides the default restriction that prevents deletion of backup vaults with any data sources, even if those data sources are inactive.</summary>
    [JsonPropertyName("ignoreInactiveDatasources")]
    public bool? IgnoreInactiveDatasources { get; set; }

    /// <summary>Optional. Resource labels to represent user provided metadata. No labels currently defined:</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BackupDRBackupVaultSpecProjectRef ProjectRef { get; set; }

    /// <summary>The BackupDRBackupVault name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupVaultStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupVaultStatusObservedState
{
    /// <summary>Output only. The number of backups in this backup vault.</summary>
    [JsonPropertyName("backupCount")]
    public long? BackupCount { get; set; }

    /// <summary>Output only. The time when the instance was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Set to true when there are no backups nested under this resource.</summary>
    [JsonPropertyName("deletable")]
    public bool? Deletable { get; set; }

    /// <summary>Output only. Service account used by the BackupVault Service for this BackupVault.  The user should grant this account permissions in their workload project to enable the service to run backups and restores there.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Output only. The BackupVault resource instance state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Total size of the storage used by all backup resources.</summary>
    [JsonPropertyName("totalStoredBytes")]
    public long? TotalStoredBytes { get; set; }

    /// <summary>Output only. Immutable after resource creation until resource deletion.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time when the instance was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>BackupDRBackupVaultStatus defines the config connector machine state of BackupDRBackupVault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupVaultStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BackupDRBackupVaultStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BackupDRBackupVault resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BackupDRBackupVaultStatusObservedState? ObservedState { get; set; }
}

/// <summary>BackupDRBackupVault is the Schema for the BackupDRBackupVault API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BackupDRBackupVault : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BackupDRBackupVaultSpec>, IStatus<V1alpha1BackupDRBackupVaultStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BackupDRBackupVault";
    public const string KubeGroup = "backupdr.cnrm.cloud.google.com";
    public const string KubePluralName = "backupdrbackupvaults";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupDRBackupVaultSpec defines the desired state of BackupDRBackupVault</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BackupDRBackupVaultSpec Spec { get; set; }

    /// <summary>BackupDRBackupVaultStatus defines the config connector machine state of BackupDRBackupVault</summary>
    [JsonPropertyName("status")]
    public V1alpha1BackupDRBackupVaultStatus? Status { get; set; }
}

/// <summary>BackupDRBackupVault is the Schema for the BackupDRBackupVault API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BackupDRBackupVaultList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BackupDRBackupVault>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BackupDRBackupVaultList";
    public const string KubeGroup = "backupdr.cnrm.cloud.google.com";
    public const string KubePluralName = "backupdrbackupvaults";
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
    public IList<V1alpha1BackupDRBackupVault> Items { get; set; }
}