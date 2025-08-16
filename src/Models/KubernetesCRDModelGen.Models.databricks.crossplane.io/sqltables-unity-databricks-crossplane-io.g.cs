using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.unity.databricks.crossplane.io;
/// <summary>SQLTable is the Schema for the SQLTables API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SQLTableList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SQLTable>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SQLTableList";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "sqltables";
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
    public IList<V1alpha1SQLTable> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecForProviderClusterIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in compute to populate clusterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecForProviderClusterIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLTableSpecForProviderClusterIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecForProviderClusterIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in compute to populate clusterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecForProviderClusterIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLTableSpecForProviderClusterIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecForProviderColumn
{
    /// <summary>User-supplied free-form text. Changing the comment is not currently supported on the VIEW table type.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Whether the field is an identity column. Can be default, always, or unset. It is unset by default.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>Name of table relative to parent catalog and schema. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether field is nullable (Default: true)</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>Column type spec (with metadata) as SQL text. Not supported for VIEW table_type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeJson")]
    public string? TypeJson { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecForProviderWarehouseIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SQLEndpoint in sql to populate warehouseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecForProviderWarehouseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLTableSpecForProviderWarehouseIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecForProviderWarehouseIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SQLEndpoint in sql to populate warehouseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecForProviderWarehouseIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLTableSpecForProviderWarehouseIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecForProvider
{
    /// <summary>Name of parent catalog. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>All table CRUD operations must be executed on a running cluster or SQL warehouse. If a cluster_id is specified, it will be used to execute SQL commands to manage this table. Conflicts with warehouse_id.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>Reference to a Cluster in compute to populate clusterId.</summary>
    [JsonPropertyName("clusterIdRef")]
    public V1alpha1SQLTableSpecForProviderClusterIdRef? ClusterIdRef { get; set; }

    /// <summary>Selector for a Cluster in compute to populate clusterId.</summary>
    [JsonPropertyName("clusterIdSelector")]
    public V1alpha1SQLTableSpecForProviderClusterIdSelector? ClusterIdSelector { get; set; }

    /// <summary>a subset of columns to liquid cluster the table by. For automatic clustering, set cluster_keys to ["AUTO"]. To turn off clustering, set it to ["NONE"]. Conflicts with partitions.</summary>
    [JsonPropertyName("clusterKeys")]
    public IList<string>? ClusterKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("column")]
    public IList<V1alpha1SQLTableSpecForProviderColumn>? Column { get; set; }

    /// <summary>User-supplied free-form text. Changing the comment is not currently supported on the VIEW table type.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>External tables are supported in multiple data source formats. The string constants identifying these formats are DELTA, CSV, JSON, AVRO, PARQUET, ORC, and TEXT. Change forces the creation of a new resource. Not supported for MANAGED tables or VIEW.</summary>
    [JsonPropertyName("dataSourceFormat")]
    public string? DataSourceFormat { get; set; }

    /// <summary>Name of table relative to parent catalog and schema. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Map of user defined table options. Change forces creation of a new resource.</summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>User name/group name/sp application_id of the table owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>a subset of columns to partition the table by. Change forces the creation of a new resource. Conflicts with cluster_keys.</summary>
    [JsonPropertyName("partitions")]
    public IList<string>? Partitions { get; set; }

    /// <summary>A map of table properties.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Name of parent Schema relative to parent Catalog. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>For EXTERNAL Tables only: the name of storage credential to use. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("storageCredentialName")]
    public string? StorageCredentialName { get; set; }

    /// <summary>URL of storage location for Table data . Not supported for VIEW or MANAGED table_type.</summary>
    [JsonPropertyName("storageLocation")]
    public string? StorageLocation { get; set; }

    /// <summary>Distinguishes a view vs. managed/external Table. MANAGED, EXTERNAL, or VIEW. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("tableType")]
    public string? TableType { get; set; }

    /// <summary>SQL text defining the view (for table_type == "VIEW"). Not supported for MANAGED or EXTERNAL table_type.</summary>
    [JsonPropertyName("viewDefinition")]
    public string? ViewDefinition { get; set; }

    /// <summary>All table CRUD operations must be executed on a running cluster or SQL warehouse. If a warehouse_id is specified, that SQL warehouse will be used to execute SQL commands to manage this table. Conflicts with cluster_id.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    /// <summary>Reference to a SQLEndpoint in sql to populate warehouseId.</summary>
    [JsonPropertyName("warehouseIdRef")]
    public V1alpha1SQLTableSpecForProviderWarehouseIdRef? WarehouseIdRef { get; set; }

    /// <summary>Selector for a SQLEndpoint in sql to populate warehouseId.</summary>
    [JsonPropertyName("warehouseIdSelector")]
    public V1alpha1SQLTableSpecForProviderWarehouseIdSelector? WarehouseIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecInitProviderClusterIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in compute to populate clusterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecInitProviderClusterIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLTableSpecInitProviderClusterIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecInitProviderClusterIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in compute to populate clusterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecInitProviderClusterIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLTableSpecInitProviderClusterIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecInitProviderColumn
{
    /// <summary>User-supplied free-form text. Changing the comment is not currently supported on the VIEW table type.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Whether the field is an identity column. Can be default, always, or unset. It is unset by default.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>Name of table relative to parent catalog and schema. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether field is nullable (Default: true)</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>Column type spec (with metadata) as SQL text. Not supported for VIEW table_type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeJson")]
    public string? TypeJson { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecInitProviderWarehouseIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SQLEndpoint in sql to populate warehouseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecInitProviderWarehouseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLTableSpecInitProviderWarehouseIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecInitProviderWarehouseIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SQLEndpoint in sql to populate warehouseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecInitProviderWarehouseIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLTableSpecInitProviderWarehouseIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecInitProvider
{
    /// <summary>Name of parent catalog. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>All table CRUD operations must be executed on a running cluster or SQL warehouse. If a cluster_id is specified, it will be used to execute SQL commands to manage this table. Conflicts with warehouse_id.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>Reference to a Cluster in compute to populate clusterId.</summary>
    [JsonPropertyName("clusterIdRef")]
    public V1alpha1SQLTableSpecInitProviderClusterIdRef? ClusterIdRef { get; set; }

    /// <summary>Selector for a Cluster in compute to populate clusterId.</summary>
    [JsonPropertyName("clusterIdSelector")]
    public V1alpha1SQLTableSpecInitProviderClusterIdSelector? ClusterIdSelector { get; set; }

    /// <summary>a subset of columns to liquid cluster the table by. For automatic clustering, set cluster_keys to ["AUTO"]. To turn off clustering, set it to ["NONE"]. Conflicts with partitions.</summary>
    [JsonPropertyName("clusterKeys")]
    public IList<string>? ClusterKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("column")]
    public IList<V1alpha1SQLTableSpecInitProviderColumn>? Column { get; set; }

    /// <summary>User-supplied free-form text. Changing the comment is not currently supported on the VIEW table type.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>External tables are supported in multiple data source formats. The string constants identifying these formats are DELTA, CSV, JSON, AVRO, PARQUET, ORC, and TEXT. Change forces the creation of a new resource. Not supported for MANAGED tables or VIEW.</summary>
    [JsonPropertyName("dataSourceFormat")]
    public string? DataSourceFormat { get; set; }

    /// <summary>Name of table relative to parent catalog and schema. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Map of user defined table options. Change forces creation of a new resource.</summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>User name/group name/sp application_id of the table owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>a subset of columns to partition the table by. Change forces the creation of a new resource. Conflicts with cluster_keys.</summary>
    [JsonPropertyName("partitions")]
    public IList<string>? Partitions { get; set; }

    /// <summary>A map of table properties.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Name of parent Schema relative to parent Catalog. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>For EXTERNAL Tables only: the name of storage credential to use. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("storageCredentialName")]
    public string? StorageCredentialName { get; set; }

    /// <summary>URL of storage location for Table data . Not supported for VIEW or MANAGED table_type.</summary>
    [JsonPropertyName("storageLocation")]
    public string? StorageLocation { get; set; }

    /// <summary>Distinguishes a view vs. managed/external Table. MANAGED, EXTERNAL, or VIEW. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("tableType")]
    public string? TableType { get; set; }

    /// <summary>SQL text defining the view (for table_type == "VIEW"). Not supported for MANAGED or EXTERNAL table_type.</summary>
    [JsonPropertyName("viewDefinition")]
    public string? ViewDefinition { get; set; }

    /// <summary>All table CRUD operations must be executed on a running cluster or SQL warehouse. If a warehouse_id is specified, that SQL warehouse will be used to execute SQL commands to manage this table. Conflicts with cluster_id.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    /// <summary>Reference to a SQLEndpoint in sql to populate warehouseId.</summary>
    [JsonPropertyName("warehouseIdRef")]
    public V1alpha1SQLTableSpecInitProviderWarehouseIdRef? WarehouseIdRef { get; set; }

    /// <summary>Selector for a SQLEndpoint in sql to populate warehouseId.</summary>
    [JsonPropertyName("warehouseIdSelector")]
    public V1alpha1SQLTableSpecInitProviderWarehouseIdSelector? WarehouseIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecProviderConfigRefPolicy
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
public partial class V1alpha1SQLTableSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLTableSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1alpha1SQLTableSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SQLTableSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecPublishConnectionDetailsToMetadata
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
public partial class V1alpha1SQLTableSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1SQLTableSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1SQLTableSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SQLTableSpec defines the desired state of SQLTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1SQLTableSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1SQLTableSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SQLTableSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1SQLTableSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SQLTableSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableStatusAtProviderColumn
{
    /// <summary>User-supplied free-form text. Changing the comment is not currently supported on the VIEW table type.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Whether the field is an identity column. Can be default, always, or unset. It is unset by default.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>Name of table relative to parent catalog and schema. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether field is nullable (Default: true)</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>Column type spec (with metadata) as SQL text. Not supported for VIEW table_type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeJson")]
    public string? TypeJson { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableStatusAtProvider
{
    /// <summary>Name of parent catalog. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>All table CRUD operations must be executed on a running cluster or SQL warehouse. If a cluster_id is specified, it will be used to execute SQL commands to manage this table. Conflicts with warehouse_id.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>a subset of columns to liquid cluster the table by. For automatic clustering, set cluster_keys to ["AUTO"]. To turn off clustering, set it to ["NONE"]. Conflicts with partitions.</summary>
    [JsonPropertyName("clusterKeys")]
    public IList<string>? ClusterKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("column")]
    public IList<V1alpha1SQLTableStatusAtProviderColumn>? Column { get; set; }

    /// <summary>User-supplied free-form text. Changing the comment is not currently supported on the VIEW table type.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>External tables are supported in multiple data source formats. The string constants identifying these formats are DELTA, CSV, JSON, AVRO, PARQUET, ORC, and TEXT. Change forces the creation of a new resource. Not supported for MANAGED tables or VIEW.</summary>
    [JsonPropertyName("dataSourceFormat")]
    public string? DataSourceFormat { get; set; }

    /// <summary>A map of table properties.</summary>
    [JsonPropertyName("effectiveProperties")]
    public IDictionary<string, string>? EffectiveProperties { get; set; }

    /// <summary>ID of this table in the form of &lt;catalog_name&gt;.&lt;schema_name&gt;.&lt;name&gt;.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of table relative to parent catalog and schema. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Map of user defined table options. Change forces creation of a new resource.</summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>User name/group name/sp application_id of the table owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>a subset of columns to partition the table by. Change forces the creation of a new resource. Conflicts with cluster_keys.</summary>
    [JsonPropertyName("partitions")]
    public IList<string>? Partitions { get; set; }

    /// <summary>A map of table properties.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Name of parent Schema relative to parent Catalog. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>For EXTERNAL Tables only: the name of storage credential to use. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("storageCredentialName")]
    public string? StorageCredentialName { get; set; }

    /// <summary>URL of storage location for Table data . Not supported for VIEW or MANAGED table_type.</summary>
    [JsonPropertyName("storageLocation")]
    public string? StorageLocation { get; set; }

    /// <summary>Distinguishes a view vs. managed/external Table. MANAGED, EXTERNAL, or VIEW. Change forces the creation of a new resource.</summary>
    [JsonPropertyName("tableType")]
    public string? TableType { get; set; }

    /// <summary>SQL text defining the view (for table_type == "VIEW"). Not supported for MANAGED or EXTERNAL table_type.</summary>
    [JsonPropertyName("viewDefinition")]
    public string? ViewDefinition { get; set; }

    /// <summary>All table CRUD operations must be executed on a running cluster or SQL warehouse. If a warehouse_id is specified, that SQL warehouse will be used to execute SQL commands to manage this table. Conflicts with cluster_id.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableStatusConditions
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

/// <summary>SQLTableStatus defines the observed state of SQLTable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SQLTableStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1SQLTableStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SQLTableStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SQLTable is the Schema for the SQLTables API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SQLTable : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SQLTableSpec>, IStatus<V1alpha1SQLTableStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SQLTable";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "sqltables";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SQLTableSpec defines the desired state of SQLTable</summary>
    [JsonPropertyName("spec")]
    public V1alpha1SQLTableSpec Spec { get; set; }

    /// <summary>SQLTableStatus defines the observed state of SQLTable.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SQLTableStatus? Status { get; set; }
}