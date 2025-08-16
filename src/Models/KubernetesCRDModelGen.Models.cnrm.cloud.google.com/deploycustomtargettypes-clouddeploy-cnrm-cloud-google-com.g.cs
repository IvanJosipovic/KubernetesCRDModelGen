using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.clouddeploy.cnrm.cloud.google.com;
/// <summary>DeployCustomTargetType is the Schema for the DeployCustomTargetType API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DeployCustomTargetTypeList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DeployCustomTargetType>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DeployCustomTargetTypeList";
    public const string KubeGroup = "clouddeploy.cnrm.cloud.google.com";
    public const string KubePluralName = "deploycustomtargettypes";
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
    public IList<V1alpha1DeployCustomTargetType> Items { get; set; }
}

/// <summary>Remote git repository containing the Skaffold Config modules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGit
{
    /// <summary>Optional. Relative path from the repository root to the Skaffold file.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Optional. Git branch or tag to use when cloning the repository.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>Required. Git repository the package should be cloned from.</summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary>Required. Name of the Cloud Build V2 RepositoryRef. Format is projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGoogleCloudBuildRepoRepositoryRef
{
    /// <summary>A reference to an externally managed CloudBuildRepository resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/connections/{{connectionID}}/repositories/{{RepositoryID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudBuildRepository resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudBuildRepository resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Cloud Build V2 repository containing the Skaffold Config modules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGoogleCloudBuildRepo
{
    /// <summary>Optional. Relative path from the repository root to the Skaffold Config file.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Optional. Branch or tag to use when cloning the repository.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>Required. Name of the Cloud Build V2 RepositoryRef. Format is projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1alpha1DeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGoogleCloudBuildRepoRepositoryRef? RepositoryRef { get; set; }
}

/// <summary>Cloud Storage bucket containing the Skaffold Config modules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGoogleCloudStorage
{
    /// <summary>Optional. Relative path from the source to the Skaffold file.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Required. Cloud Storage source paths to copy recursively. For example, providing "gs://my-bucket/dir/configs/*" will result in Skaffold copying all files within the "dir/configs" directory in the bucket "my-bucket".</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModules
{
    /// <summary>Optional. The Skaffold Config modules to use from the specified source.</summary>
    [JsonPropertyName("configs")]
    public IList<string>? Configs { get; set; }

    /// <summary>Remote git repository containing the Skaffold Config modules.</summary>
    [JsonPropertyName("git")]
    public V1alpha1DeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGit? Git { get; set; }

    /// <summary>Cloud Build V2 repository containing the Skaffold Config modules.</summary>
    [JsonPropertyName("googleCloudBuildRepo")]
    public V1alpha1DeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGoogleCloudBuildRepo? GoogleCloudBuildRepo { get; set; }

    /// <summary>Cloud Storage bucket containing the Skaffold Config modules.</summary>
    [JsonPropertyName("googleCloudStorage")]
    public V1alpha1DeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGoogleCloudStorage? GoogleCloudStorage { get; set; }
}

/// <summary>Configures render and deploy for the `CustomTargetType` using Skaffold custom actions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeployCustomTargetTypeSpecCustomActions
{
    /// <summary>Required. The Skaffold custom action responsible for deploy operations.</summary>
    [JsonPropertyName("deployAction")]
    public string? DeployAction { get; set; }

    /// <summary>Optional. List of Skaffold modules Cloud Deploy will include in the Skaffold Config as required before performing diagnose.</summary>
    [JsonPropertyName("includeSkaffoldModules")]
    public IList<V1alpha1DeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModules>? IncludeSkaffoldModules { get; set; }

    /// <summary>Optional. The Skaffold custom action responsible for render operations. If not provided then Cloud Deploy will perform the render operations via `skaffold render`.</summary>
    [JsonPropertyName("renderAction")]
    public string? RenderAction { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeployCustomTargetTypeSpecProjectRef
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

/// <summary>CustomTargetTypeSpec defines the desired state of DeployCustomTargetType</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeployCustomTargetTypeSpec
{
    /// <summary>Configures render and deploy for the `CustomTargetType` using Skaffold custom actions.</summary>
    [JsonPropertyName("customActions")]
    public V1alpha1DeployCustomTargetTypeSpecCustomActions? CustomActions { get; set; }

    /// <summary>Optional. Description of the `CustomTargetType`. Max length is 255 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DeployCustomTargetTypeSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DeployCustomTargetType name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeployCustomTargetTypeStatusConditions
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
public partial class V1alpha1DeployCustomTargetTypeStatusObservedState
{
    /// <summary>Output only. Time at which the `CustomTargetType` was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Resource id of the `CustomTargetType`.</summary>
    [JsonPropertyName("customTargetTypeID")]
    public string? CustomTargetTypeID { get; set; }

    /// <summary>Output only. Unique identifier of the `CustomTargetType`.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Most recent time at which the `CustomTargetType` was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>CustomTargetTypeStatus defines the config connector machine state of DeployCustomTargetType</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeployCustomTargetTypeStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DeployCustomTargetTypeStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DeployCustomTargetType resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DeployCustomTargetTypeStatusObservedState? ObservedState { get; set; }
}

/// <summary>DeployCustomTargetType is the Schema for the DeployCustomTargetType API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DeployCustomTargetType : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DeployCustomTargetTypeSpec>, IStatus<V1alpha1DeployCustomTargetTypeStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DeployCustomTargetType";
    public const string KubeGroup = "clouddeploy.cnrm.cloud.google.com";
    public const string KubePluralName = "deploycustomtargettypes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CustomTargetTypeSpec defines the desired state of DeployCustomTargetType</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DeployCustomTargetTypeSpec Spec { get; set; }

    /// <summary>CustomTargetTypeStatus defines the config connector machine state of DeployCustomTargetType</summary>
    [JsonPropertyName("status")]
    public V1alpha1DeployCustomTargetTypeStatus? Status { get; set; }
}