using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.deploymentmanager.cnrm.cloud.google.com;
/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeploymentManagerDeploymentSpecProjectRef
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

/// <summary>The root configuration file to use for this deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeploymentManagerDeploymentSpecTargetConfig
{
    /// <summary>The full YAML contents of your configuration file.</summary>
    [JsonPropertyName("content")]
    public string Content { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeploymentManagerDeploymentSpecTargetImports
{
    /// <summary>The full contents of the template that you want to import.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The name of the template to import, as declared in the YAML configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Parameters that define your deployment, including the deployment configuration and relevant templates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeploymentManagerDeploymentSpecTarget
{
    /// <summary>The root configuration file to use for this deployment.</summary>
    [JsonPropertyName("config")]
    public V1alpha1DeploymentManagerDeploymentSpecTargetConfig Config { get; set; }

    /// <summary>Specifies import files for this configuration. This can be used to import templates or other files. For example, you might import a text file in order to use the file in a template.</summary>
    [JsonPropertyName("imports")]
    public IList<V1alpha1DeploymentManagerDeploymentSpecTargetImports>? Imports { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeploymentManagerDeploymentSpec
{
    /// <summary>Immutable. Set the policy to use for creating new resources. Only used on create and update. Valid values are 'CREATE_OR_ACQUIRE' (default) or 'ACQUIRE'. If set to 'ACQUIRE' and resources do not already exist, the deployment will fail. Note that updating this field does not actually affect the deployment, just how it is updated. Default value: "CREATE_OR_ACQUIRE" Possible values: ["ACQUIRE", "CREATE_OR_ACQUIRE"].</summary>
    [JsonPropertyName("createPolicy")]
    public string? CreatePolicy { get; set; }

    /// <summary>Immutable. Set the policy to use for deleting new resources on update/delete. Valid values are 'DELETE' (default) or 'ABANDON'. If 'DELETE', resource is deleted after removal from Deployment Manager. If 'ABANDON', the resource is only removed from Deployment Manager and is not actually deleted. Note that updating this field does not actually change the deployment, just how it is updated. Default value: "DELETE" Possible values: ["ABANDON", "DELETE"].</summary>
    [JsonPropertyName("deletePolicy")]
    public string? DeletePolicy { get; set; }

    /// <summary>Optional user-provided description of deployment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preview")]
    public bool? Preview { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DeploymentManagerDeploymentSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Parameters that define your deployment, including the deployment configuration and relevant templates.</summary>
    [JsonPropertyName("target")]
    public V1alpha1DeploymentManagerDeploymentSpecTarget Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeploymentManagerDeploymentStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeploymentManagerDeploymentStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DeploymentManagerDeploymentStatusConditions>? Conditions { get; set; }

    /// <summary>Unique identifier for deployment. Output only.</summary>
    [JsonPropertyName("deploymentId")]
    public string? DeploymentId { get; set; }

    /// <summary>Output only. URL of the manifest representing the last manifest that was successfully deployed.</summary>
    [JsonPropertyName("manifest")]
    public string? Manifest { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. Server defined URL for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DeploymentManagerDeployment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DeploymentManagerDeploymentSpec>, IStatus<V1alpha1DeploymentManagerDeploymentStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DeploymentManagerDeployment";
    public const string KubeGroup = "deploymentmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "deploymentmanagerdeployments";
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
    public V1alpha1DeploymentManagerDeploymentSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1DeploymentManagerDeploymentStatus? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DeploymentManagerDeploymentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DeploymentManagerDeployment>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DeploymentManagerDeploymentList";
    public const string KubeGroup = "deploymentmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "deploymentmanagerdeployments";
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
    public IList<V1alpha1DeploymentManagerDeployment> Items { get; set; }
}