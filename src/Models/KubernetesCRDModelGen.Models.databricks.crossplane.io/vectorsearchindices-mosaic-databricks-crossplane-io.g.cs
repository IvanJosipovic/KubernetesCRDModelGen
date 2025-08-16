using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.mosaic.databricks.crossplane.io;
/// <summary>VectorSearchIndex is the Schema for the VectorSearchIndexs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VectorSearchIndexList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VectorSearchIndex>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VectorSearchIndexList";
    public const string KubeGroup = "mosaic.databricks.crossplane.io";
    public const string KubePluralName = "vectorsearchindices";
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
    public IList<V1alpha1VectorSearchIndex> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumns
{
    /// <summary>The name of the embedding model endpoint</summary>
    [JsonPropertyName("embeddingModelEndpointName")]
    public string? EmbeddingModelEndpointName { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>Automatically sync the vector index contents and computed embeddings to the specified Delta table. The only supported table name is the index name with the suffix _writeback_table.</summary>
    [JsonPropertyName("embeddingWritebackTable")]
    public string? EmbeddingWritebackTable { get; set; }

    /// <summary>Pipeline execution mode. Possible values are:</summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

    /// <summary>The name of the source table.</summary>
    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingSourceColumns
{
    /// <summary>The name of the embedding model endpoint</summary>
    [JsonPropertyName("embeddingModelEndpointName")]
    public string? EmbeddingModelEndpointName { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecForProviderDirectAccessIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1alpha1VectorSearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1alpha1VectorSearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>The schema of the index in JSON format.  Check the API documentation for a list of supported data types.</summary>
    [JsonPropertyName("schemaJson")]
    public string? SchemaJson { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecForProvider
{
    /// <summary>(object) Specification for Delta Sync Index. Required if index_type is DELTA_SYNC. This field is a block and is documented below.</summary>
    [JsonPropertyName("deltaSyncIndexSpec")]
    public IList<V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpec>? DeltaSyncIndexSpec { get; set; }

    /// <summary>(object) Specification for Direct Vector Access Index. Required if index_type is DIRECT_ACCESS. This field is a block and is documented below.</summary>
    [JsonPropertyName("directAccessIndexSpec")]
    public IList<V1alpha1VectorSearchIndexSpecForProviderDirectAccessIndexSpec>? DirectAccessIndexSpec { get; set; }

    /// <summary>The name of the Mosaic AI Vector Search Endpoint that will be used for indexing the data.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>Mosaic AI Vector Search index type. Currently supported values are:</summary>
    [JsonPropertyName("indexType")]
    public string? IndexType { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The column name that will be used as a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public string? PrimaryKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumns
{
    /// <summary>The name of the embedding model endpoint</summary>
    [JsonPropertyName("embeddingModelEndpointName")]
    public string? EmbeddingModelEndpointName { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>Automatically sync the vector index contents and computed embeddings to the specified Delta table. The only supported table name is the index name with the suffix _writeback_table.</summary>
    [JsonPropertyName("embeddingWritebackTable")]
    public string? EmbeddingWritebackTable { get; set; }

    /// <summary>Pipeline execution mode. Possible values are:</summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

    /// <summary>The name of the source table.</summary>
    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingSourceColumns
{
    /// <summary>The name of the embedding model endpoint</summary>
    [JsonPropertyName("embeddingModelEndpointName")]
    public string? EmbeddingModelEndpointName { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDirectAccessIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1alpha1VectorSearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1alpha1VectorSearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>The schema of the index in JSON format.  Check the API documentation for a list of supported data types.</summary>
    [JsonPropertyName("schemaJson")]
    public string? SchemaJson { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecInitProvider
{
    /// <summary>(object) Specification for Delta Sync Index. Required if index_type is DELTA_SYNC. This field is a block and is documented below.</summary>
    [JsonPropertyName("deltaSyncIndexSpec")]
    public IList<V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpec>? DeltaSyncIndexSpec { get; set; }

    /// <summary>(object) Specification for Direct Vector Access Index. Required if index_type is DIRECT_ACCESS. This field is a block and is documented below.</summary>
    [JsonPropertyName("directAccessIndexSpec")]
    public IList<V1alpha1VectorSearchIndexSpecInitProviderDirectAccessIndexSpec>? DirectAccessIndexSpec { get; set; }

    /// <summary>The name of the Mosaic AI Vector Search Endpoint that will be used for indexing the data.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>Mosaic AI Vector Search index type. Currently supported values are:</summary>
    [JsonPropertyName("indexType")]
    public string? IndexType { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The column name that will be used as a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public string? PrimaryKey { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1VectorSearchIndexSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1VectorSearchIndexSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1VectorSearchIndexSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1VectorSearchIndexSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VectorSearchIndexSpec defines the desired state of VectorSearchIndex</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1VectorSearchIndexSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1VectorSearchIndexSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1VectorSearchIndexSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1VectorSearchIndexSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1VectorSearchIndexSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingSourceColumns
{
    /// <summary>The name of the embedding model endpoint</summary>
    [JsonPropertyName("embeddingModelEndpointName")]
    public string? EmbeddingModelEndpointName { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1alpha1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1alpha1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>Automatically sync the vector index contents and computed embeddings to the specified Delta table. The only supported table name is the index name with the suffix _writeback_table.</summary>
    [JsonPropertyName("embeddingWritebackTable")]
    public string? EmbeddingWritebackTable { get; set; }

    /// <summary>ID of the associated Delta Live Table pipeline.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }

    /// <summary>Pipeline execution mode. Possible values are:</summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

    /// <summary>The name of the source table.</summary>
    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingSourceColumns
{
    /// <summary>The name of the embedding model endpoint</summary>
    [JsonPropertyName("embeddingModelEndpointName")]
    public string? EmbeddingModelEndpointName { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexStatusAtProviderDirectAccessIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1alpha1VectorSearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1alpha1VectorSearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>The schema of the index in JSON format.  Check the API documentation for a list of supported data types.</summary>
    [JsonPropertyName("schemaJson")]
    public string? SchemaJson { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexStatusAtProviderStatus
{
    /// <summary>Index API Url to be used to perform operations on the index</summary>
    [JsonPropertyName("indexUrl")]
    public string? IndexUrl { get; set; }

    /// <summary>Number of rows indexed</summary>
    [JsonPropertyName("indexedRowCount")]
    public double? IndexedRowCount { get; set; }

    /// <summary>Message associated with the index status</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Whether the index is ready for search</summary>
    [JsonPropertyName("ready")]
    public bool? Ready { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexStatusAtProvider
{
    /// <summary>Creator of the endpoint.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>(object) Specification for Delta Sync Index. Required if index_type is DELTA_SYNC. This field is a block and is documented below.</summary>
    [JsonPropertyName("deltaSyncIndexSpec")]
    public IList<V1alpha1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpec>? DeltaSyncIndexSpec { get; set; }

    /// <summary>(object) Specification for Direct Vector Access Index. Required if index_type is DIRECT_ACCESS. This field is a block and is documented below.</summary>
    [JsonPropertyName("directAccessIndexSpec")]
    public IList<V1alpha1VectorSearchIndexStatusAtProviderDirectAccessIndexSpec>? DirectAccessIndexSpec { get; set; }

    /// <summary>The name of the Mosaic AI Vector Search Endpoint that will be used for indexing the data.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>The same as the name of the index.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Mosaic AI Vector Search index type. Currently supported values are:</summary>
    [JsonPropertyName("indexType")]
    public string? IndexType { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The column name that will be used as a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public string? PrimaryKey { get; set; }

    /// <summary>Object describing the current status of the index consisting of the following fields:</summary>
    [JsonPropertyName("status")]
    public IList<V1alpha1VectorSearchIndexStatusAtProviderStatus>? Status { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>VectorSearchIndexStatus defines the observed state of VectorSearchIndex.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VectorSearchIndexStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1VectorSearchIndexStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VectorSearchIndexStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VectorSearchIndex is the Schema for the VectorSearchIndexs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VectorSearchIndex : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VectorSearchIndexSpec>, IStatus<V1alpha1VectorSearchIndexStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VectorSearchIndex";
    public const string KubeGroup = "mosaic.databricks.crossplane.io";
    public const string KubePluralName = "vectorsearchindices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VectorSearchIndexSpec defines the desired state of VectorSearchIndex</summary>
    [JsonPropertyName("spec")]
    public V1alpha1VectorSearchIndexSpec Spec { get; set; }

    /// <summary>VectorSearchIndexStatus defines the observed state of VectorSearchIndex.</summary>
    [JsonPropertyName("status")]
    public V1alpha1VectorSearchIndexStatus? Status { get; set; }
}