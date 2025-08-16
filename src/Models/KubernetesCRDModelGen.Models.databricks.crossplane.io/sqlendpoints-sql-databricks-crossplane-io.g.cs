using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.databricks.crossplane.io;
/// <summary>SQLEndpoint is the Schema for the SQLEndpoints API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SQLEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SQLEndpoint>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SQLEndpointList";
    public const string KubeGroup = "sql.databricks.crossplane.io";
    public const string KubePluralName = "sqlendpoints";
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
    public IList<V1alpha1SQLEndpoint> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointSpecForProviderChannel
{
    /// <summary></summary>
    [JsonPropertyName("dbsqlVersion")]
    public string? DbsqlVersion { get; set; }

    /// <summary>Name of the Databricks SQL release channel. Possible values are: CHANNEL_NAME_PREVIEW and CHANNEL_NAME_CURRENT. Default is CHANNEL_NAME_CURRENT.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointSpecForProviderTagsCustomTags
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointSpecForProviderTags
{
    /// <summary>Databricks tags all endpoint resources with these tags.</summary>
    [JsonPropertyName("customTags")]
    public IList<V1alpha1SQLEndpointSpecForProviderTagsCustomTags>? CustomTags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointSpecForProvider
{
    /// <summary>Time in minutes until an idle SQL warehouse terminates all clusters and stops. This field is optional. The default is 120, set to 0 to disable the auto stop.</summary>
    [JsonPropertyName("autoStopMins")]
    public double? AutoStopMins { get; set; }

    /// <summary>block, consisting of following fields:</summary>
    [JsonPropertyName("channel")]
    public IList<V1alpha1SQLEndpointSpecForProviderChannel>? Channel { get; set; }

    /// <summary>The size of the clusters allocated to the endpoint: "2X-Small", "X-Small", "Small", "Medium", "Large", "X-Large", "2X-Large", "3X-Large", "4X-Large".</summary>
    [JsonPropertyName("clusterSize")]
    public string? ClusterSize { get; set; }

    /// <summary>ID of the data source for this endpoint. This is used to bind an Databricks SQL query to an endpoint.</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>Whether to enable Photon. This field is optional and is enabled by default.</summary>
    [JsonPropertyName("enablePhoton")]
    public bool? EnablePhoton { get; set; }

    /// <summary>Whether this SQL warehouse is a serverless endpoint. See below for details about the default values. To avoid ambiguity, especially for organizations with many workspaces, Databricks recommends that you always set this field explicitly.</summary>
    [JsonPropertyName("enableServerlessCompute")]
    public bool? EnableServerlessCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>Maximum number of clusters available when a SQL warehouse is running. This field is required. If multi-cluster load balancing is not enabled, this is default to 1.</summary>
    [JsonPropertyName("maxNumClusters")]
    public double? MaxNumClusters { get; set; }

    /// <summary>Minimum number of clusters available when a SQL warehouse is running. The default is 1.</summary>
    [JsonPropertyName("minNumClusters")]
    public double? MinNumClusters { get; set; }

    /// <summary>Name of the SQL warehouse. Must be unique.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The spot policy to use for allocating instances to clusters: COST_OPTIMIZED or RELIABILITY_OPTIMIZED. This field is optional. Default is COST_OPTIMIZED.</summary>
    [JsonPropertyName("spotInstancePolicy")]
    public string? SpotInstancePolicy { get; set; }

    /// <summary>Databricks tags all endpoint resources with these tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1SQLEndpointSpecForProviderTags>? Tags { get; set; }

    /// <summary>SQL warehouse type. See for AWS or Azure. Set to PRO or CLASSIC. If the field enable_serverless_compute has the value true either explicitly or through the default logic (see that field above for details), the default is PRO, which is required for serverless SQL warehouses. Otherwise, the default is CLASSIC.</summary>
    [JsonPropertyName("warehouseType")]
    public string? WarehouseType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointSpecInitProviderChannel
{
    /// <summary></summary>
    [JsonPropertyName("dbsqlVersion")]
    public string? DbsqlVersion { get; set; }

    /// <summary>Name of the Databricks SQL release channel. Possible values are: CHANNEL_NAME_PREVIEW and CHANNEL_NAME_CURRENT. Default is CHANNEL_NAME_CURRENT.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointSpecInitProviderTagsCustomTags
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointSpecInitProviderTags
{
    /// <summary>Databricks tags all endpoint resources with these tags.</summary>
    [JsonPropertyName("customTags")]
    public IList<V1alpha1SQLEndpointSpecInitProviderTagsCustomTags>? CustomTags { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointSpecInitProvider
{
    /// <summary>Time in minutes until an idle SQL warehouse terminates all clusters and stops. This field is optional. The default is 120, set to 0 to disable the auto stop.</summary>
    [JsonPropertyName("autoStopMins")]
    public double? AutoStopMins { get; set; }

    /// <summary>block, consisting of following fields:</summary>
    [JsonPropertyName("channel")]
    public IList<V1alpha1SQLEndpointSpecInitProviderChannel>? Channel { get; set; }

    /// <summary>The size of the clusters allocated to the endpoint: "2X-Small", "X-Small", "Small", "Medium", "Large", "X-Large", "2X-Large", "3X-Large", "4X-Large".</summary>
    [JsonPropertyName("clusterSize")]
    public string? ClusterSize { get; set; }

    /// <summary>ID of the data source for this endpoint. This is used to bind an Databricks SQL query to an endpoint.</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>Whether to enable Photon. This field is optional and is enabled by default.</summary>
    [JsonPropertyName("enablePhoton")]
    public bool? EnablePhoton { get; set; }

    /// <summary>Whether this SQL warehouse is a serverless endpoint. See below for details about the default values. To avoid ambiguity, especially for organizations with many workspaces, Databricks recommends that you always set this field explicitly.</summary>
    [JsonPropertyName("enableServerlessCompute")]
    public bool? EnableServerlessCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>Maximum number of clusters available when a SQL warehouse is running. This field is required. If multi-cluster load balancing is not enabled, this is default to 1.</summary>
    [JsonPropertyName("maxNumClusters")]
    public double? MaxNumClusters { get; set; }

    /// <summary>Minimum number of clusters available when a SQL warehouse is running. The default is 1.</summary>
    [JsonPropertyName("minNumClusters")]
    public double? MinNumClusters { get; set; }

    /// <summary>Name of the SQL warehouse. Must be unique.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The spot policy to use for allocating instances to clusters: COST_OPTIMIZED or RELIABILITY_OPTIMIZED. This field is optional. Default is COST_OPTIMIZED.</summary>
    [JsonPropertyName("spotInstancePolicy")]
    public string? SpotInstancePolicy { get; set; }

    /// <summary>Databricks tags all endpoint resources with these tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1SQLEndpointSpecInitProviderTags>? Tags { get; set; }

    /// <summary>SQL warehouse type. See for AWS or Azure. Set to PRO or CLASSIC. If the field enable_serverless_compute has the value true either explicitly or through the default logic (see that field above for details), the default is PRO, which is required for serverless SQL warehouses. Otherwise, the default is CLASSIC.</summary>
    [JsonPropertyName("warehouseType")]
    public string? WarehouseType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointSpecProviderConfigRefPolicy
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
public partial class V1alpha1SQLEndpointSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLEndpointSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1alpha1SQLEndpointSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLEndpointSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointSpecPublishConnectionDetailsToMetadata
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
public partial class V1alpha1SQLEndpointSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1SQLEndpointSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1SQLEndpointSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SQLEndpointSpec defines the desired state of SQLEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1SQLEndpointSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1SQLEndpointSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SQLEndpointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1SQLEndpointSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SQLEndpointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointStatusAtProviderChannel
{
    /// <summary></summary>
    [JsonPropertyName("dbsqlVersion")]
    public string? DbsqlVersion { get; set; }

    /// <summary>Name of the Databricks SQL release channel. Possible values are: CHANNEL_NAME_PREVIEW and CHANNEL_NAME_CURRENT. Default is CHANNEL_NAME_CURRENT.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointStatusAtProviderHealthFailureReason
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointStatusAtProviderHealth
{
    /// <summary></summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureReason")]
    public IList<V1alpha1SQLEndpointStatusAtProviderHealthFailureReason>? FailureReason { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointStatusAtProviderOdbcParams
{
    /// <summary>Name of the SQL warehouse. Must be unique.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointStatusAtProviderTagsCustomTags
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointStatusAtProviderTags
{
    /// <summary>Databricks tags all endpoint resources with these tags.</summary>
    [JsonPropertyName("customTags")]
    public IList<V1alpha1SQLEndpointStatusAtProviderTagsCustomTags>? CustomTags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointStatusAtProvider
{
    /// <summary>Time in minutes until an idle SQL warehouse terminates all clusters and stops. This field is optional. The default is 120, set to 0 to disable the auto stop.</summary>
    [JsonPropertyName("autoStopMins")]
    public double? AutoStopMins { get; set; }

    /// <summary>block, consisting of following fields:</summary>
    [JsonPropertyName("channel")]
    public IList<V1alpha1SQLEndpointStatusAtProviderChannel>? Channel { get; set; }

    /// <summary>The size of the clusters allocated to the endpoint: "2X-Small", "X-Small", "Small", "Medium", "Large", "X-Large", "2X-Large", "3X-Large", "4X-Large".</summary>
    [JsonPropertyName("clusterSize")]
    public string? ClusterSize { get; set; }

    /// <summary>The username of the user who created the endpoint.</summary>
    [JsonPropertyName("creatorName")]
    public string? CreatorName { get; set; }

    /// <summary>ID of the data source for this endpoint. This is used to bind an Databricks SQL query to an endpoint.</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>Whether to enable Photon. This field is optional and is enabled by default.</summary>
    [JsonPropertyName("enablePhoton")]
    public bool? EnablePhoton { get; set; }

    /// <summary>Whether this SQL warehouse is a serverless endpoint. See below for details about the default values. To avoid ambiguity, especially for organizations with many workspaces, Databricks recommends that you always set this field explicitly.</summary>
    [JsonPropertyName("enableServerlessCompute")]
    public bool? EnableServerlessCompute { get; set; }

    /// <summary>Health status of the endpoint.</summary>
    [JsonPropertyName("health")]
    public IList<V1alpha1SQLEndpointStatusAtProviderHealth>? Health { get; set; }

    /// <summary>the unique ID of the SQL warehouse.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>JDBC connection string.</summary>
    [JsonPropertyName("jdbcUrl")]
    public string? JdbcUrl { get; set; }

    /// <summary>Maximum number of clusters available when a SQL warehouse is running. This field is required. If multi-cluster load balancing is not enabled, this is default to 1.</summary>
    [JsonPropertyName("maxNumClusters")]
    public double? MaxNumClusters { get; set; }

    /// <summary>Minimum number of clusters available when a SQL warehouse is running. The default is 1.</summary>
    [JsonPropertyName("minNumClusters")]
    public double? MinNumClusters { get; set; }

    /// <summary>Name of the SQL warehouse. Must be unique.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The current number of clusters used by the endpoint.</summary>
    [JsonPropertyName("numActiveSessions")]
    public double? NumActiveSessions { get; set; }

    /// <summary>The current number of clusters used by the endpoint.</summary>
    [JsonPropertyName("numClusters")]
    public double? NumClusters { get; set; }

    /// <summary>ODBC connection params: odbc_params.hostname, odbc_params.path, odbc_params.protocol, and odbc_params.port.</summary>
    [JsonPropertyName("odbcParams")]
    public IList<V1alpha1SQLEndpointStatusAtProviderOdbcParams>? OdbcParams { get; set; }

    /// <summary>The spot policy to use for allocating instances to clusters: COST_OPTIMIZED or RELIABILITY_OPTIMIZED. This field is optional. Default is COST_OPTIMIZED.</summary>
    [JsonPropertyName("spotInstancePolicy")]
    public string? SpotInstancePolicy { get; set; }

    /// <summary>The current state of the endpoint.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Databricks tags all endpoint resources with these tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1SQLEndpointStatusAtProviderTags>? Tags { get; set; }

    /// <summary>SQL warehouse type. See for AWS or Azure. Set to PRO or CLASSIC. If the field enable_serverless_compute has the value true either explicitly or through the default logic (see that field above for details), the default is PRO, which is required for serverless SQL warehouses. Otherwise, the default is CLASSIC.</summary>
    [JsonPropertyName("warehouseType")]
    public string? WarehouseType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointStatusConditions
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

/// <summary>SQLEndpointStatus defines the observed state of SQLEndpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLEndpointStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1SQLEndpointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SQLEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SQLEndpoint is the Schema for the SQLEndpoints API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SQLEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SQLEndpointSpec>, IStatus<V1alpha1SQLEndpointStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SQLEndpoint";
    public const string KubeGroup = "sql.databricks.crossplane.io";
    public const string KubePluralName = "sqlendpoints";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SQLEndpointSpec defines the desired state of SQLEndpoint</summary>
    [JsonPropertyName("spec")]
    public V1alpha1SQLEndpointSpec Spec { get; set; }

    /// <summary>SQLEndpointStatus defines the observed state of SQLEndpoint.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SQLEndpointStatus? Status { get; set; }
}