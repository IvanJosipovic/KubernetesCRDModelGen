using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.netapp.cnrm.cloud.google.com;
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetAppBackupPolicySpecProjectRef
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

/// <summary>NetAppBackupPolicySpec defines the desired state of NetAppBackupPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetAppBackupPolicySpec
{
    /// <summary>Number of daily backups to keep. Note that the minimum daily backup limit is 2.</summary>
    [JsonPropertyName("dailyBackupLimit")]
    public int? DailyBackupLimit { get; set; }

    /// <summary>Description of the backup policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If enabled, make backups automatically according to the schedules. This will be applied to all volumes that have this policy attached and enforced on volume level. If not specified, default is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Number of monthly backups to keep. Note that the sum of daily, weekly and monthly backups should be greater than 1.</summary>
    [JsonPropertyName("monthlyBackupLimit")]
    public int? MonthlyBackupLimit { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1NetAppBackupPolicySpecProjectRef ProjectRef { get; set; }

    /// <summary>The GCP resource identifier. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Number of weekly backups to keep. Note that the sum of daily, weekly and monthly backups should be greater than 1.</summary>
    [JsonPropertyName("weeklyBackupLimit")]
    public int? WeeklyBackupLimit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetAppBackupPolicyStatusConditions
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
public partial class V1alpha1NetAppBackupPolicyStatusObservedState
{
    /// <summary>Output only. The total number of volumes assigned by this backup policy.</summary>
    [JsonPropertyName("assignedVolumeCount")]
    public int? AssignedVolumeCount { get; set; }

    /// <summary>Output only. The time when the backup policy was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The backup policy state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>NetAppBackupPolicyStatus defines the config connector machine state of NetAppBackupPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetAppBackupPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetAppBackupPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the NetAppBackupPolicy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1NetAppBackupPolicyStatusObservedState? ObservedState { get; set; }
}

/// <summary>NetAppBackupPolicy is the Schema for the NetAppBackupPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetAppBackupPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetAppBackupPolicySpec>, IStatus<V1alpha1NetAppBackupPolicyStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetAppBackupPolicy";
    public const string KubeGroup = "netapp.cnrm.cloud.google.com";
    public const string KubePluralName = "netappbackuppolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetAppBackupPolicySpec defines the desired state of NetAppBackupPolicy</summary>
    [JsonPropertyName("spec")]
    public V1alpha1NetAppBackupPolicySpec Spec { get; set; }

    /// <summary>NetAppBackupPolicyStatus defines the config connector machine state of NetAppBackupPolicy</summary>
    [JsonPropertyName("status")]
    public V1alpha1NetAppBackupPolicyStatus? Status { get; set; }
}

/// <summary>NetAppBackupPolicy is the Schema for the NetAppBackupPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetAppBackupPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NetAppBackupPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetAppBackupPolicyList";
    public const string KubeGroup = "netapp.cnrm.cloud.google.com";
    public const string KubePluralName = "netappbackuppolicies";
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
    public IList<V1alpha1NetAppBackupPolicy> Items { get; set; }
}