using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vertexai.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIFeaturestoreEntityTypeFeatureList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VertexAIFeaturestoreEntityTypeFeature>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIFeaturestoreEntityTypeFeatureList";
    public const string KubeGroup = "vertexai.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaifeaturestoreentitytypefeatures";
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
    public IList<V1alpha1VertexAIFeaturestoreEntityTypeFeature> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeaturestoreEntityTypeFeatureSpec
{
    /// <summary>Description of the feature.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The name of the Featurestore to use, in the format projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entitytype}.</summary>
    [JsonPropertyName("entitytype")]
    public string Entitytype { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Type of Feature value. Immutable. https://cloud.google.com/vertex-ai/docs/reference/rest/v1/projects.locations.featurestores.entityTypes.features#ValueType.</summary>
    [JsonPropertyName("valueType")]
    public string ValueType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIFeaturestoreEntityTypeFeatureStatusConditions
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
public partial class V1alpha1VertexAIFeaturestoreEntityTypeFeatureStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VertexAIFeaturestoreEntityTypeFeatureStatusConditions>? Conditions { get; set; }

    /// <summary>The timestamp of when the entity type was created in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Used to perform consistent read-modify-write updates.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The region of the feature.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The timestamp when the entity type was most recently updated in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIFeaturestoreEntityTypeFeature : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VertexAIFeaturestoreEntityTypeFeatureSpec>, IStatus<V1alpha1VertexAIFeaturestoreEntityTypeFeatureStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIFeaturestoreEntityTypeFeature";
    public const string KubeGroup = "vertexai.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaifeaturestoreentitytypefeatures";
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
    public V1alpha1VertexAIFeaturestoreEntityTypeFeatureSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1VertexAIFeaturestoreEntityTypeFeatureStatus? Status { get; set; }
}