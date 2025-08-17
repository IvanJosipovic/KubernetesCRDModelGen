using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.documentdb.azure.com;
#nullable enable
/// <summary>Storage version of v1api20240815.SqlDatabaseContainer Generator information: - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2024-08-15/cosmos-db.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240815storageSqlDatabaseContainerList : IKubernetesObject<V1ListMeta>, IItems<V1api20240815storageSqlDatabaseContainer>
{
    public const string KubeApiVersion = "v1api20240815storage";
    public const string KubeKind = "SqlDatabaseContainerList";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "sqldatabasecontainers";
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
    public IList<V1api20240815storageSqlDatabaseContainer> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecOperatorSpecSecretExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.SqlDatabaseContainerOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240815storageSqlDatabaseContainerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240815storageSqlDatabaseContainerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.AutoscaleSettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecOptionsAutoscaleSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.CreateUpdateOptions CreateUpdateOptions are a list of key-value pairs that describe the resource. Supported keys are "If-Match", "If-None-Match", "Session-Token" and "Throughput"</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecOptions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240815.AutoscaleSettings</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20240815storageSqlDatabaseContainerSpecOptionsAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a documentdb.azure.com/SqlDatabase resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.ClientEncryptionIncludedPath .</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecResourceClientEncryptionPolicyIncludedPaths
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientEncryptionKeyId")]
    public string? ClientEncryptionKeyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.ClientEncryptionPolicy Cosmos DB client encryption policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecResourceClientEncryptionPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includedPaths")]
    public IList<V1api20240815storageSqlDatabaseContainerSpecResourceClientEncryptionPolicyIncludedPaths>? IncludedPaths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyFormatVersion")]
    public int? PolicyFormatVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.ComputedProperty The definition of a computed property</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecResourceComputedProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.ConflictResolutionPolicy The conflict resolution policy for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecResourceConflictResolutionPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conflictResolutionPath")]
    public string? ConflictResolutionPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conflictResolutionProcedure")]
    public string? ConflictResolutionProcedure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.CompositePath</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecResourceIndexingPolicyCompositeIndexes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.ExcludedPath</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecResourceIndexingPolicyExcludedPaths
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.Indexes The indexes for the path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecResourceIndexingPolicyIncludedPathsIndexes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.IncludedPath The paths that are included in indexing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecResourceIndexingPolicyIncludedPaths
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("indexes")]
    public IList<V1api20240815storageSqlDatabaseContainerSpecResourceIndexingPolicyIncludedPathsIndexes>? Indexes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.SpatialSpec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecResourceIndexingPolicySpatialIndexes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.IndexingPolicy Cosmos DB indexing policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecResourceIndexingPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("automatic")]
    public bool? Automatic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compositeIndexes")]
    public IList<IList<V1api20240815storageSqlDatabaseContainerSpecResourceIndexingPolicyCompositeIndexes>>? CompositeIndexes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("excludedPaths")]
    public IList<V1api20240815storageSqlDatabaseContainerSpecResourceIndexingPolicyExcludedPaths>? ExcludedPaths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includedPaths")]
    public IList<V1api20240815storageSqlDatabaseContainerSpecResourceIndexingPolicyIncludedPaths>? IncludedPaths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("indexingMode")]
    public string? IndexingMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spatialIndexes")]
    public IList<V1api20240815storageSqlDatabaseContainerSpecResourceIndexingPolicySpatialIndexes>? SpatialIndexes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.ContainerPartitionKey The configuration of the partition key to be used for partitioning data into multiple partitions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecResourcePartitionKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.RestoreParametersBase Parameters to indicate the information about the restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecResourceRestoreParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreSource")]
    public string? RestoreSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreWithTtlDisabled")]
    public bool? RestoreWithTtlDisabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.UniqueKey The unique key on that enforces uniqueness constraint on documents in the collection in the Azure Cosmos DB service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecResourceUniqueKeyPolicyUniqueKeys
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.UniqueKeyPolicy The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecResourceUniqueKeyPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uniqueKeys")]
    public IList<V1api20240815storageSqlDatabaseContainerSpecResourceUniqueKeyPolicyUniqueKeys>? UniqueKeys { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.SqlContainerResource Cosmos DB SQL container resource object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpecResource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public int? AnalyticalStorageTtl { get; set; }

    /// <summary>Storage version of v1api20240815.ClientEncryptionPolicy Cosmos DB client encryption policy.</summary>
    [JsonPropertyName("clientEncryptionPolicy")]
    public V1api20240815storageSqlDatabaseContainerSpecResourceClientEncryptionPolicy? ClientEncryptionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computedProperties")]
    public IList<V1api20240815storageSqlDatabaseContainerSpecResourceComputedProperties>? ComputedProperties { get; set; }

    /// <summary>Storage version of v1api20240815.ConflictResolutionPolicy The conflict resolution policy for the container.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1api20240815storageSqlDatabaseContainerSpecResourceConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultTtl")]
    public int? DefaultTtl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20240815.IndexingPolicy Cosmos DB indexing policy</summary>
    [JsonPropertyName("indexingPolicy")]
    public V1api20240815storageSqlDatabaseContainerSpecResourceIndexingPolicy? IndexingPolicy { get; set; }

    /// <summary>Storage version of v1api20240815.ContainerPartitionKey The configuration of the partition key to be used for partitioning data into multiple partitions</summary>
    [JsonPropertyName("partitionKey")]
    public V1api20240815storageSqlDatabaseContainerSpecResourcePartitionKey? PartitionKey { get; set; }

    /// <summary>Storage version of v1api20240815.RestoreParametersBase Parameters to indicate the information about the restore.</summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20240815storageSqlDatabaseContainerSpecResourceRestoreParameters? RestoreParameters { get; set; }

    /// <summary>Storage version of v1api20240815.UniqueKeyPolicy The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service.</summary>
    [JsonPropertyName("uniqueKeyPolicy")]
    public V1api20240815storageSqlDatabaseContainerSpecResourceUniqueKeyPolicy? UniqueKeyPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.SqlDatabaseContainer_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20240815.SqlDatabaseContainerOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240815storageSqlDatabaseContainerSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>Storage version of v1api20240815.CreateUpdateOptions CreateUpdateOptions are a list of key-value pairs that describe the resource. Supported keys are "If-Match", "If-None-Match", "Session-Token" and "Throughput"</summary>
    [JsonPropertyName("options")]
    public V1api20240815storageSqlDatabaseContainerSpecOptions? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a documentdb.azure.com/SqlDatabase resource</summary>
    [JsonPropertyName("owner")]
    public V1api20240815storageSqlDatabaseContainerSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20240815.SqlContainerResource Cosmos DB SQL container resource object</summary>
    [JsonPropertyName("resource")]
    public V1api20240815storageSqlDatabaseContainerSpecResource? Resource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.AutoscaleSettings_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusOptionsAutoscaleSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.OptionsResource_STATUS Cosmos DB options resource object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusOptions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240815.AutoscaleSettings_STATUS</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20240815storageSqlDatabaseContainerStatusOptionsAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.ClientEncryptionIncludedPath_STATUS .</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusResourceClientEncryptionPolicyIncludedPaths
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientEncryptionKeyId")]
    public string? ClientEncryptionKeyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionAlgorithm")]
    public string? EncryptionAlgorithm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.ClientEncryptionPolicy_STATUS Cosmos DB client encryption policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusResourceClientEncryptionPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includedPaths")]
    public IList<V1api20240815storageSqlDatabaseContainerStatusResourceClientEncryptionPolicyIncludedPaths>? IncludedPaths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyFormatVersion")]
    public int? PolicyFormatVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.ComputedProperty_STATUS The definition of a computed property</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusResourceComputedProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.ConflictResolutionPolicy_STATUS The conflict resolution policy for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusResourceConflictResolutionPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conflictResolutionPath")]
    public string? ConflictResolutionPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conflictResolutionProcedure")]
    public string? ConflictResolutionProcedure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.CompositePath_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusResourceIndexingPolicyCompositeIndexes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.ExcludedPath_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusResourceIndexingPolicyExcludedPaths
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.Indexes_STATUS The indexes for the path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusResourceIndexingPolicyIncludedPathsIndexes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.IncludedPath_STATUS The paths that are included in indexing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusResourceIndexingPolicyIncludedPaths
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("indexes")]
    public IList<V1api20240815storageSqlDatabaseContainerStatusResourceIndexingPolicyIncludedPathsIndexes>? Indexes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.SpatialSpec_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusResourceIndexingPolicySpatialIndexes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.IndexingPolicy_STATUS Cosmos DB indexing policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusResourceIndexingPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("automatic")]
    public bool? Automatic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compositeIndexes")]
    public IList<IList<V1api20240815storageSqlDatabaseContainerStatusResourceIndexingPolicyCompositeIndexes>>? CompositeIndexes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("excludedPaths")]
    public IList<V1api20240815storageSqlDatabaseContainerStatusResourceIndexingPolicyExcludedPaths>? ExcludedPaths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includedPaths")]
    public IList<V1api20240815storageSqlDatabaseContainerStatusResourceIndexingPolicyIncludedPaths>? IncludedPaths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("indexingMode")]
    public string? IndexingMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spatialIndexes")]
    public IList<V1api20240815storageSqlDatabaseContainerStatusResourceIndexingPolicySpatialIndexes>? SpatialIndexes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.ContainerPartitionKey_STATUS The configuration of the partition key to be used for partitioning data into multiple partitions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusResourcePartitionKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("systemKey")]
    public bool? SystemKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.RestoreParametersBase_STATUS Parameters to indicate the information about the restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusResourceRestoreParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreSource")]
    public string? RestoreSource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreWithTtlDisabled")]
    public bool? RestoreWithTtlDisabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.UniqueKey_STATUS The unique key on that enforces uniqueness constraint on documents in the collection in the Azure Cosmos DB service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusResourceUniqueKeyPolicyUniqueKeys
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.UniqueKeyPolicy_STATUS The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusResourceUniqueKeyPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uniqueKeys")]
    public IList<V1api20240815storageSqlDatabaseContainerStatusResourceUniqueKeyPolicyUniqueKeys>? UniqueKeys { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.SqlContainerGetProperties_Resource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatusResource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("_etag")]
    public string? etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("_rid")]
    public string? rid { get; set; }

    /// <summary></summary>
    [JsonPropertyName("_ts")]
    public double? ts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public int? AnalyticalStorageTtl { get; set; }

    /// <summary>Storage version of v1api20240815.ClientEncryptionPolicy_STATUS Cosmos DB client encryption policy.</summary>
    [JsonPropertyName("clientEncryptionPolicy")]
    public V1api20240815storageSqlDatabaseContainerStatusResourceClientEncryptionPolicy? ClientEncryptionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computedProperties")]
    public IList<V1api20240815storageSqlDatabaseContainerStatusResourceComputedProperties>? ComputedProperties { get; set; }

    /// <summary>Storage version of v1api20240815.ConflictResolutionPolicy_STATUS The conflict resolution policy for the container.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1api20240815storageSqlDatabaseContainerStatusResourceConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultTtl")]
    public int? DefaultTtl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20240815.IndexingPolicy_STATUS Cosmos DB indexing policy</summary>
    [JsonPropertyName("indexingPolicy")]
    public V1api20240815storageSqlDatabaseContainerStatusResourceIndexingPolicy? IndexingPolicy { get; set; }

    /// <summary>Storage version of v1api20240815.ContainerPartitionKey_STATUS The configuration of the partition key to be used for partitioning data into multiple partitions</summary>
    [JsonPropertyName("partitionKey")]
    public V1api20240815storageSqlDatabaseContainerStatusResourcePartitionKey? PartitionKey { get; set; }

    /// <summary>Storage version of v1api20240815.RestoreParametersBase_STATUS Parameters to indicate the information about the restore.</summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20240815storageSqlDatabaseContainerStatusResourceRestoreParameters? RestoreParameters { get; set; }

    /// <summary>Storage version of v1api20240815.UniqueKeyPolicy_STATUS The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service.</summary>
    [JsonPropertyName("uniqueKeyPolicy")]
    public V1api20240815storageSqlDatabaseContainerStatusResourceUniqueKeyPolicy? UniqueKeyPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.SqlDatabaseContainer_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815storageSqlDatabaseContainerStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240815storageSqlDatabaseContainerStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20240815.OptionsResource_STATUS Cosmos DB options resource object</summary>
    [JsonPropertyName("options")]
    public V1api20240815storageSqlDatabaseContainerStatusOptions? Options { get; set; }

    /// <summary>Storage version of v1api20240815.SqlContainerGetProperties_Resource_STATUS</summary>
    [JsonPropertyName("resource")]
    public V1api20240815storageSqlDatabaseContainerStatusResource? Resource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240815.SqlDatabaseContainer Generator information: - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2024-08-15/cosmos-db.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240815storageSqlDatabaseContainer : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240815storageSqlDatabaseContainerSpec>, IStatus<V1api20240815storageSqlDatabaseContainerStatus>
{
    public const string KubeApiVersion = "v1api20240815storage";
    public const string KubeKind = "SqlDatabaseContainer";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "sqldatabasecontainers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240815.SqlDatabaseContainer_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240815storageSqlDatabaseContainerSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240815.SqlDatabaseContainer_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240815storageSqlDatabaseContainerStatus? Status { get; set; }
}
#nullable disable
