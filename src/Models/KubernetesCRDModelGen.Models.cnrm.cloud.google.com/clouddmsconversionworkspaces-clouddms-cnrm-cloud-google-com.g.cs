using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.clouddms.cnrm.cloud.google.com;
#nullable enable
/// <summary>CloudDMSConversionWorkspace is the Schema for the CloudDMSConversionWorkspace API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDMSConversionWorkspaceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudDMSConversionWorkspace>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDMSConversionWorkspaceList";
    public const string KubeGroup = "clouddms.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddmsconversionworkspaces";
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
    public IList<V1alpha1CloudDMSConversionWorkspace> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. The destination engine details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSConversionWorkspaceSpecDestination
{
    /// <summary>Required. Engine type.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>Required. Engine named version, for example 12.c.1.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSConversionWorkspaceSpecProjectRef
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
/// <summary>Required. The source engine details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSConversionWorkspaceSpecSource
{
    /// <summary>Required. Engine type.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>Required. Engine named version, for example 12.c.1.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CloudDMSConversionWorkspaceSpec defines the desired state of CloudDMSConversionWorkspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSConversionWorkspaceSpec
{
    /// <summary>Required. The destination engine details.</summary>
    [JsonPropertyName("destination")]
    public V1alpha1CloudDMSConversionWorkspaceSpecDestination? Destination { get; set; }

    /// <summary>Optional. The display name for the workspace.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. A generic list of settings for the workspace. The settings are database pair dependant and can indicate default behavior for the mapping rules engine or turn on or off specific features. Such examples can be: convert_foreign_key_to_interleave=true, skip_triggers=false, ignore_non_table_synonyms=true</summary>
    [JsonPropertyName("globalSettings")]
    public IDictionary<string, string>? GlobalSettings { get; set; }

    /// <summary>Immutable. The location where the alloydb cluster should reside.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1CloudDMSConversionWorkspaceSpecProjectRef ProjectRef { get; set; }

    /// <summary>The CloudDMSConversionWorkspace name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. The source engine details.</summary>
    [JsonPropertyName("source")]
    public V1alpha1CloudDMSConversionWorkspaceSpecSource? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSConversionWorkspaceStatusConditions
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
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSConversionWorkspaceStatusObservedState
{
    /// <summary>Output only. The timestamp when the workspace resource was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Whether the workspace has uncommitted changes (changes which were made after the workspace was committed).</summary>
    [JsonPropertyName("hasUncommittedChanges")]
    public bool? HasUncommittedChanges { get; set; }

    /// <summary>Output only. The latest commit ID.</summary>
    [JsonPropertyName("latestCommitID")]
    public string? LatestCommitID { get; set; }

    /// <summary>Output only. The timestamp when the workspace was committed.</summary>
    [JsonPropertyName("latestCommitTime")]
    public string? LatestCommitTime { get; set; }

    /// <summary>Output only. The timestamp when the workspace resource was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CloudDMSConversionWorkspaceStatus defines the config connector machine state of CloudDMSConversionWorkspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSConversionWorkspaceStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudDMSConversionWorkspaceStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CloudDMSConversionWorkspace resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudDMSConversionWorkspaceStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CloudDMSConversionWorkspace is the Schema for the CloudDMSConversionWorkspace API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDMSConversionWorkspace : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudDMSConversionWorkspaceSpec>, IStatus<V1alpha1CloudDMSConversionWorkspaceStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDMSConversionWorkspace";
    public const string KubeGroup = "clouddms.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddmsconversionworkspaces";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudDMSConversionWorkspaceSpec defines the desired state of CloudDMSConversionWorkspace</summary>
    [JsonPropertyName("spec")]
    public V1alpha1CloudDMSConversionWorkspaceSpec Spec { get; set; }

    /// <summary>CloudDMSConversionWorkspaceStatus defines the config connector machine state of CloudDMSConversionWorkspace</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudDMSConversionWorkspaceStatus? Status { get; set; }
}
#nullable disable
