using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.notebooks.cnrm.cloud.google.com;
/// <summary>Use a container image to start the notebook instance.</summary>
public partial class V1alpha1NotebooksEnvironmentSpecContainerImage
{
    /// <summary>The path to the container image repository. For example: gcr.io/{project_id}/{imageName}.</summary>
    [JsonPropertyName("repository")]
    public string Repository { get; set; }

    /// <summary>The tag of the container image. If not specified, this defaults to the latest tag.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
public partial class V1alpha1NotebooksEnvironmentSpecLocationRef
{
    /// <summary>Allowed value: The `name` field of a `NotebooksLocation` resource.</summary>
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
public partial class V1alpha1NotebooksEnvironmentSpecProjectRef
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

/// <summary>Use a Compute Engine VM image to start the notebook instance.</summary>
public partial class V1alpha1NotebooksEnvironmentSpecVmImage
{
    /// <summary>Use this VM image family to find the image; the newest image in this family will be used.</summary>
    [JsonPropertyName("imageFamily")]
    public string? ImageFamily { get; set; }

    /// <summary>Use VM image name to find the image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The name of the Google Cloud project that this VM image belongs to. Format: projects/{project_id}.</summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }
}

/// <summary></summary>
public partial class V1alpha1NotebooksEnvironmentSpec
{
    /// <summary>Use a container image to start the notebook instance.</summary>
    [JsonPropertyName("containerImage")]
    public V1alpha1NotebooksEnvironmentSpecContainerImage? ContainerImage { get; set; }

    /// <summary>A brief description of this environment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name of this environment for the UI.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locationRef")]
    public V1alpha1NotebooksEnvironmentSpecLocationRef LocationRef { get; set; }

    /// <summary>Path to a Bash script that automatically runs after a notebook instance fully boots up. The path must be a URL or Cloud Storage path. Example: "gs://path-to-file/file-name".</summary>
    [JsonPropertyName("postStartupScript")]
    public string? PostStartupScript { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1NotebooksEnvironmentSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Use a Compute Engine VM image to start the notebook instance.</summary>
    [JsonPropertyName("vmImage")]
    public V1alpha1NotebooksEnvironmentSpecVmImage? VmImage { get; set; }
}

/// <summary></summary>
public partial class V1alpha1NotebooksEnvironmentStatusConditions
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
public partial class V1alpha1NotebooksEnvironmentStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NotebooksEnvironmentStatusConditions>? Conditions { get; set; }

    /// <summary>Instance creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1alpha1NotebooksEnvironment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NotebooksEnvironmentSpec>, IStatus<V1alpha1NotebooksEnvironmentStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NotebooksEnvironment";
    public const string KubeGroup = "notebooks.cnrm.cloud.google.com";
    public const string KubePluralName = "notebooksenvironments";
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
    public V1alpha1NotebooksEnvironmentSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1NotebooksEnvironmentStatus? Status { get; set; }
}