using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.metastore.cnrm.cloud.google.com;
/// <summary>MetastoreBackup is the Schema for the MetastoreBackup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MetastoreBackupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MetastoreBackup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MetastoreBackupList";
    public const string KubeGroup = "metastore.cnrm.cloud.google.com";
    public const string KubePluralName = "metastorebackups";
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
    public IList<V1alpha1MetastoreBackup> Items { get; set; }
}

/// <summary>The MetastoreService that the backup belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreBackupSpecServiceRef
{
    /// <summary>A reference to an externally managed MetastoreService resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/services/{{serviceID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a MetastoreService resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a MetastoreService resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>MetastoreBackupSpec defines the desired state of MetastoreBackup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreBackupSpec
{
    /// <summary>The description of the backup.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The MetastoreBackup name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The MetastoreService that the backup belongs to.</summary>
    [JsonPropertyName("serviceRef")]
    public V1alpha1MetastoreBackupSpecServiceRef ServiceRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreBackupStatusConditions
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
public partial class V1alpha1MetastoreBackupStatusObservedState
{
    /// <summary>Output only. The time when the backup was started.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The time when the backup finished creating.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Output only. Services that are restoring from the backup.</summary>
    [JsonPropertyName("restoringServices")]
    public IList<string>? RestoringServices { get; set; }

    /// <summary>Output only. The revision of the service at the time of backup.</summary>
    [JsonPropertyName("serviceRevision")]
    public JsonNode? ServiceRevision { get; set; }

    /// <summary>Output only. The current state of the backup.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>MetastoreBackupStatus defines the config connector machine state of MetastoreBackup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreBackupStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MetastoreBackupStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the MetastoreBackup resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1MetastoreBackupStatusObservedState? ObservedState { get; set; }
}

/// <summary>MetastoreBackup is the Schema for the MetastoreBackup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MetastoreBackup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MetastoreBackupSpec>, IStatus<V1alpha1MetastoreBackupStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MetastoreBackup";
    public const string KubeGroup = "metastore.cnrm.cloud.google.com";
    public const string KubePluralName = "metastorebackups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MetastoreBackupSpec defines the desired state of MetastoreBackup</summary>
    [JsonPropertyName("spec")]
    public V1alpha1MetastoreBackupSpec Spec { get; set; }

    /// <summary>MetastoreBackupStatus defines the config connector machine state of MetastoreBackup</summary>
    [JsonPropertyName("status")]
    public V1alpha1MetastoreBackupStatus? Status { get; set; }
}