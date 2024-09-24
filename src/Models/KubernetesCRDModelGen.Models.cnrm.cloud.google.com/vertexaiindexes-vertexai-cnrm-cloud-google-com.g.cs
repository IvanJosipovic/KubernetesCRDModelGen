using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vertexai.cnrm.cloud.google.com;
/// <summary>Configuration options for using brute force search, which simply implements the standard linear search in the database for each query.</summary>
public partial class V1alpha1VertexAIIndexSpecMetadataConfigAlgorithmConfigBruteForceConfig
{
}

/// <summary>Configuration options for using the tree-AH algorithm (Shallow tree + Asymmetric Hashing). Please refer to this paper for more details: https://arxiv.org/abs/1908.10396.</summary>
public partial class V1alpha1VertexAIIndexSpecMetadataConfigAlgorithmConfigTreeAhConfig
{
    /// <summary>Number of embeddings on each leaf node. The default value is 1000 if not set.</summary>
    [JsonPropertyName("leafNodeEmbeddingCount")]
    public int? LeafNodeEmbeddingCount { get; set; }

    /// <summary>The default percentage of leaf nodes that any query may be searched. Must be in range 1-100, inclusive. The default value is 10 (means 10%) if not set.</summary>
    [JsonPropertyName("leafNodesToSearchPercent")]
    public int? LeafNodesToSearchPercent { get; set; }
}

/// <summary>The configuration with regard to the algorithms used for efficient search.</summary>
public partial class V1alpha1VertexAIIndexSpecMetadataConfigAlgorithmConfig
{
    /// <summary>Configuration options for using brute force search, which simply implements the standard linear search in the database for each query.</summary>
    [JsonPropertyName("bruteForceConfig")]
    public V1alpha1VertexAIIndexSpecMetadataConfigAlgorithmConfigBruteForceConfig? BruteForceConfig { get; set; }

    /// <summary>Configuration options for using the tree-AH algorithm (Shallow tree + Asymmetric Hashing). Please refer to this paper for more details: https://arxiv.org/abs/1908.10396.</summary>
    [JsonPropertyName("treeAhConfig")]
    public V1alpha1VertexAIIndexSpecMetadataConfigAlgorithmConfigTreeAhConfig? TreeAhConfig { get; set; }
}

/// <summary>Immutable. The configuration of the Matching Engine Index.</summary>
public partial class V1alpha1VertexAIIndexSpecMetadataConfig
{
    /// <summary>The configuration with regard to the algorithms used for efficient search.</summary>
    [JsonPropertyName("algorithmConfig")]
    public V1alpha1VertexAIIndexSpecMetadataConfigAlgorithmConfig? AlgorithmConfig { get; set; }

    /// <summary>The default number of neighbors to find via approximate search before exact reordering is performed. Exact reordering is a procedure where results returned by an approximate search algorithm are reordered via a more expensive distance computation. Required if tree-AH algorithm is used.</summary>
    [JsonPropertyName("approximateNeighborsCount")]
    public int? ApproximateNeighborsCount { get; set; }

    /// <summary>The number of dimensions of the input vectors.</summary>
    [JsonPropertyName("dimensions")]
    public int Dimensions { get; set; }

    /// <summary>The distance measure used in nearest neighbor search. The value must be one of the followings: * SQUARED_L2_DISTANCE: Euclidean (L_2) Distance * L1_DISTANCE: Manhattan (L_1) Distance * COSINE_DISTANCE: Cosine Distance. Defined as 1 - cosine similarity. * DOT_PRODUCT_DISTANCE: Dot Product Distance. Defined as a negative of the dot product.</summary>
    [JsonPropertyName("distanceMeasureType")]
    public string? DistanceMeasureType { get; set; }

    /// <summary>Type of normalization to be carried out on each vector. The value must be one of the followings: * UNIT_L2_NORM: Unit L2 normalization type * NONE: No normalization type is specified.</summary>
    [JsonPropertyName("featureNormType")]
    public string? FeatureNormType { get; set; }

    /// <summary>Immutable. Index data is split into equal parts to be processed. These are called "shards". The shard size must be specified when creating an index. The value must be one of the followings: * SHARD_SIZE_SMALL: Small (2GB) * SHARD_SIZE_MEDIUM: Medium (20GB) * SHARD_SIZE_LARGE: Large (50GB).</summary>
    [JsonPropertyName("shardSize")]
    public string? ShardSize { get; set; }
}

/// <summary>An additional information about the Index.</summary>
public partial class V1alpha1VertexAIIndexSpecMetadata
{
    /// <summary>Immutable. The configuration of the Matching Engine Index.</summary>
    [JsonPropertyName("config")]
    public V1alpha1VertexAIIndexSpecMetadataConfig? Config { get; set; }

    /// <summary>Allows creating or replacing the contents of the Matching Engine Index. When being updated, the existing content of the Index will be replaced by the data from the latest contentsDeltaUri. The string must be a valid Cloud Storage directory path. If this field is set when calling IndexService.UpdateIndex, then no other Index field can be also updated as part of the same call. The expected structure and format of the files this URI points to is described at https://cloud.google.com/vertex-ai/docs/matching-engine/using-matching-engine#input-data-format.</summary>
    [JsonPropertyName("contentsDeltaUri")]
    public string? ContentsDeltaUri { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
public partial class V1alpha1VertexAIIndexSpecProjectRef
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

/// <summary></summary>
public partial class V1alpha1VertexAIIndexSpec
{
    /// <summary>The description of the Index.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the Index. The name can be up to 128 characters long and can consist of any UTF-8 characters.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Immutable. The update method to use with this Index. The value must be the followings. If not set, BATCH_UPDATE will be used by default. * BATCH_UPDATE: user can call indexes.patch with files on Cloud Storage of datapoints to update. * STREAM_UPDATE: user can call indexes.upsertDatapoints/DeleteDatapoints to update the Index and the updates will be applied in corresponding DeployedIndexes in nearly real-time.</summary>
    [JsonPropertyName("indexUpdateMethod")]
    public string? IndexUpdateMethod { get; set; }

    /// <summary>An additional information about the Index.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1VertexAIIndexSpecMetadata? Metadata { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1VertexAIIndexSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. The region of the index. eg us-central1.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
public partial class V1alpha1VertexAIIndexStatusConditions
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
public partial class V1alpha1VertexAIIndexStatusObservedStateIndexStats
{
    /// <summary>The number of shards in the Index.</summary>
    [JsonPropertyName("shardsCount")]
    public int? ShardsCount { get; set; }

    /// <summary>The number of vectors in the Index.</summary>
    [JsonPropertyName("vectorsCount")]
    public string? VectorsCount { get; set; }
}

/// <summary>The observed state of the underlying GCP resource.</summary>
public partial class V1alpha1VertexAIIndexStatusObservedState
{
    /// <summary>The timestamp of when the Index was created in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Stats of the index resource.</summary>
    [JsonPropertyName("indexStats")]
    public IList<V1alpha1VertexAIIndexStatusObservedStateIndexStats>? IndexStats { get; set; }

    /// <summary>Points to a YAML file stored on Google Cloud Storage describing additional information about the Index, that is specific to it. Unset if the Index does not have any additional information.</summary>
    [JsonPropertyName("metadataSchemaUri")]
    public string? MetadataSchemaUri { get; set; }

    /// <summary>The resource name of the Index.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
public partial class V1alpha1VertexAIIndexStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VertexAIIndexStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The observed state of the underlying GCP resource.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VertexAIIndexStatusObservedState? ObservedState { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1alpha1VertexAIIndex : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VertexAIIndexSpec>, IStatus<V1alpha1VertexAIIndexStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIIndex";
    public const string KubeGroup = "vertexai.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaiindexes";
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
    public V1alpha1VertexAIIndexSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1VertexAIIndexStatus? Status { get; set; }
}