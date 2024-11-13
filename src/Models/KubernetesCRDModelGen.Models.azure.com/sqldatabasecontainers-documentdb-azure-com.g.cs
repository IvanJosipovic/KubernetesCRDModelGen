using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.documentdb.azure.com;
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecOperatorSpecConfigMapExpressions
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

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecOperatorSpecSecretExpressions
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

/// <summary>Storage version of v1api20231115.SqlDatabaseContainerOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20231115storageSqlDatabaseContainerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20231115storageSqlDatabaseContainerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Storage version of v1api20231115.AutoscaleSettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecOptionsAutoscaleSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }
}

/// <summary>Storage version of v1api20231115.CreateUpdateOptions CreateUpdateOptions are a list of key-value pairs that describe the resource. Supported keys are "If-Match", "If-None-Match", "Session-Token" and "Throughput"</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecOptions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.AutoscaleSettings</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20231115storageSqlDatabaseContainerSpecOptionsAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a documentdb.azure.com/SqlDatabase resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20231115.ClientEncryptionIncludedPath .</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecResourceClientEncryptionPolicyIncludedPaths
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

/// <summary>Storage version of v1api20231115.ClientEncryptionPolicy Cosmos DB client encryption policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecResourceClientEncryptionPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includedPaths")]
    public IList<V1api20231115storageSqlDatabaseContainerSpecResourceClientEncryptionPolicyIncludedPaths>? IncludedPaths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyFormatVersion")]
    public int? PolicyFormatVersion { get; set; }
}

/// <summary>Storage version of v1api20231115.ComputedProperty The definition of a computed property</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecResourceComputedProperties
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

/// <summary>Storage version of v1api20231115.ConflictResolutionPolicy The conflict resolution policy for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecResourceConflictResolutionPolicy
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

/// <summary>Storage version of v1api20231115.CompositePath</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecResourceIndexingPolicyCompositeIndexes
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

/// <summary>Storage version of v1api20231115.ExcludedPath</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecResourceIndexingPolicyExcludedPaths
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Storage version of v1api20231115.Indexes The indexes for the path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecResourceIndexingPolicyIncludedPathsIndexes
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

/// <summary>Storage version of v1api20231115.IncludedPath The paths that are included in indexing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecResourceIndexingPolicyIncludedPaths
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("indexes")]
    public IList<V1api20231115storageSqlDatabaseContainerSpecResourceIndexingPolicyIncludedPathsIndexes>? Indexes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Storage version of v1api20231115.SpatialSpec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecResourceIndexingPolicySpatialIndexes
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

/// <summary>Storage version of v1api20231115.IndexingPolicy Cosmos DB indexing policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecResourceIndexingPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("automatic")]
    public bool? Automatic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compositeIndexes")]
    public IList<IList<V1api20231115storageSqlDatabaseContainerSpecResourceIndexingPolicyCompositeIndexes>>? CompositeIndexes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("excludedPaths")]
    public IList<V1api20231115storageSqlDatabaseContainerSpecResourceIndexingPolicyExcludedPaths>? ExcludedPaths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includedPaths")]
    public IList<V1api20231115storageSqlDatabaseContainerSpecResourceIndexingPolicyIncludedPaths>? IncludedPaths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("indexingMode")]
    public string? IndexingMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spatialIndexes")]
    public IList<V1api20231115storageSqlDatabaseContainerSpecResourceIndexingPolicySpatialIndexes>? SpatialIndexes { get; set; }
}

/// <summary>Storage version of v1api20231115.ContainerPartitionKey The configuration of the partition key to be used for partitioning data into multiple partitions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecResourcePartitionKey
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

/// <summary>Storage version of v1api20231115.RestoreParametersBase Parameters to indicate the information about the restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecResourceRestoreParameters
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
}

/// <summary>Storage version of v1api20231115.UniqueKey The unique key on that enforces uniqueness constraint on documents in the collection in the Azure Cosmos DB service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecResourceUniqueKeyPolicyUniqueKeys
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary>Storage version of v1api20231115.UniqueKeyPolicy The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecResourceUniqueKeyPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uniqueKeys")]
    public IList<V1api20231115storageSqlDatabaseContainerSpecResourceUniqueKeyPolicyUniqueKeys>? UniqueKeys { get; set; }
}

/// <summary>Storage version of v1api20231115.SqlContainerResource Cosmos DB SQL container resource object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpecResource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public int? AnalyticalStorageTtl { get; set; }

    /// <summary>Storage version of v1api20231115.ClientEncryptionPolicy Cosmos DB client encryption policy.</summary>
    [JsonPropertyName("clientEncryptionPolicy")]
    public V1api20231115storageSqlDatabaseContainerSpecResourceClientEncryptionPolicy? ClientEncryptionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computedProperties")]
    public IList<V1api20231115storageSqlDatabaseContainerSpecResourceComputedProperties>? ComputedProperties { get; set; }

    /// <summary>Storage version of v1api20231115.ConflictResolutionPolicy The conflict resolution policy for the container.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1api20231115storageSqlDatabaseContainerSpecResourceConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultTtl")]
    public int? DefaultTtl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20231115.IndexingPolicy Cosmos DB indexing policy</summary>
    [JsonPropertyName("indexingPolicy")]
    public V1api20231115storageSqlDatabaseContainerSpecResourceIndexingPolicy? IndexingPolicy { get; set; }

    /// <summary>Storage version of v1api20231115.ContainerPartitionKey The configuration of the partition key to be used for partitioning data into multiple partitions</summary>
    [JsonPropertyName("partitionKey")]
    public V1api20231115storageSqlDatabaseContainerSpecResourcePartitionKey? PartitionKey { get; set; }

    /// <summary>Storage version of v1api20231115.RestoreParametersBase Parameters to indicate the information about the restore.</summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20231115storageSqlDatabaseContainerSpecResourceRestoreParameters? RestoreParameters { get; set; }

    /// <summary>Storage version of v1api20231115.UniqueKeyPolicy The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service.</summary>
    [JsonPropertyName("uniqueKeyPolicy")]
    public V1api20231115storageSqlDatabaseContainerSpecResourceUniqueKeyPolicy? UniqueKeyPolicy { get; set; }
}

/// <summary>Storage version of v1api20231115.SqlDatabaseContainer_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerSpec
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

    /// <summary>Storage version of v1api20231115.SqlDatabaseContainerOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231115storageSqlDatabaseContainerSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>Storage version of v1api20231115.CreateUpdateOptions CreateUpdateOptions are a list of key-value pairs that describe the resource. Supported keys are "If-Match", "If-None-Match", "Session-Token" and "Throughput"</summary>
    [JsonPropertyName("options")]
    public V1api20231115storageSqlDatabaseContainerSpecOptions? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a documentdb.azure.com/SqlDatabase resource</summary>
    [JsonPropertyName("owner")]
    public V1api20231115storageSqlDatabaseContainerSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20231115.SqlContainerResource Cosmos DB SQL container resource object</summary>
    [JsonPropertyName("resource")]
    public V1api20231115storageSqlDatabaseContainerSpecResource? Resource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusConditions
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

/// <summary>Storage version of v1api20231115.AutoscaleSettings_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusOptionsAutoscaleSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }
}

/// <summary>Storage version of v1api20231115.OptionsResource_STATUS Cosmos DB options resource object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusOptions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.AutoscaleSettings_STATUS</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20231115storageSqlDatabaseContainerStatusOptionsAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}

/// <summary>Storage version of v1api20231115.ClientEncryptionIncludedPath_STATUS .</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusResourceClientEncryptionPolicyIncludedPaths
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

/// <summary>Storage version of v1api20231115.ClientEncryptionPolicy_STATUS Cosmos DB client encryption policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusResourceClientEncryptionPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includedPaths")]
    public IList<V1api20231115storageSqlDatabaseContainerStatusResourceClientEncryptionPolicyIncludedPaths>? IncludedPaths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyFormatVersion")]
    public int? PolicyFormatVersion { get; set; }
}

/// <summary>Storage version of v1api20231115.ComputedProperty_STATUS The definition of a computed property</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusResourceComputedProperties
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

/// <summary>Storage version of v1api20231115.ConflictResolutionPolicy_STATUS The conflict resolution policy for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusResourceConflictResolutionPolicy
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

/// <summary>Storage version of v1api20231115.CompositePath_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusResourceIndexingPolicyCompositeIndexes
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

/// <summary>Storage version of v1api20231115.ExcludedPath_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusResourceIndexingPolicyExcludedPaths
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Storage version of v1api20231115.Indexes_STATUS The indexes for the path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusResourceIndexingPolicyIncludedPathsIndexes
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

/// <summary>Storage version of v1api20231115.IncludedPath_STATUS The paths that are included in indexing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusResourceIndexingPolicyIncludedPaths
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("indexes")]
    public IList<V1api20231115storageSqlDatabaseContainerStatusResourceIndexingPolicyIncludedPathsIndexes>? Indexes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Storage version of v1api20231115.SpatialSpec_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusResourceIndexingPolicySpatialIndexes
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

/// <summary>Storage version of v1api20231115.IndexingPolicy_STATUS Cosmos DB indexing policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusResourceIndexingPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("automatic")]
    public bool? Automatic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compositeIndexes")]
    public IList<IList<V1api20231115storageSqlDatabaseContainerStatusResourceIndexingPolicyCompositeIndexes>>? CompositeIndexes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("excludedPaths")]
    public IList<V1api20231115storageSqlDatabaseContainerStatusResourceIndexingPolicyExcludedPaths>? ExcludedPaths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includedPaths")]
    public IList<V1api20231115storageSqlDatabaseContainerStatusResourceIndexingPolicyIncludedPaths>? IncludedPaths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("indexingMode")]
    public string? IndexingMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spatialIndexes")]
    public IList<V1api20231115storageSqlDatabaseContainerStatusResourceIndexingPolicySpatialIndexes>? SpatialIndexes { get; set; }
}

/// <summary>Storage version of v1api20231115.ContainerPartitionKey_STATUS The configuration of the partition key to be used for partitioning data into multiple partitions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusResourcePartitionKey
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

/// <summary>Storage version of v1api20231115.RestoreParametersBase_STATUS Parameters to indicate the information about the restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusResourceRestoreParameters
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
}

/// <summary>Storage version of v1api20231115.UniqueKey_STATUS The unique key on that enforces uniqueness constraint on documents in the collection in the Azure Cosmos DB service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusResourceUniqueKeyPolicyUniqueKeys
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary>Storage version of v1api20231115.UniqueKeyPolicy_STATUS The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusResourceUniqueKeyPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uniqueKeys")]
    public IList<V1api20231115storageSqlDatabaseContainerStatusResourceUniqueKeyPolicyUniqueKeys>? UniqueKeys { get; set; }
}

/// <summary>Storage version of v1api20231115.SqlContainerGetProperties_Resource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatusResource
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

    /// <summary>Storage version of v1api20231115.ClientEncryptionPolicy_STATUS Cosmos DB client encryption policy.</summary>
    [JsonPropertyName("clientEncryptionPolicy")]
    public V1api20231115storageSqlDatabaseContainerStatusResourceClientEncryptionPolicy? ClientEncryptionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computedProperties")]
    public IList<V1api20231115storageSqlDatabaseContainerStatusResourceComputedProperties>? ComputedProperties { get; set; }

    /// <summary>Storage version of v1api20231115.ConflictResolutionPolicy_STATUS The conflict resolution policy for the container.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1api20231115storageSqlDatabaseContainerStatusResourceConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultTtl")]
    public int? DefaultTtl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20231115.IndexingPolicy_STATUS Cosmos DB indexing policy</summary>
    [JsonPropertyName("indexingPolicy")]
    public V1api20231115storageSqlDatabaseContainerStatusResourceIndexingPolicy? IndexingPolicy { get; set; }

    /// <summary>Storage version of v1api20231115.ContainerPartitionKey_STATUS The configuration of the partition key to be used for partitioning data into multiple partitions</summary>
    [JsonPropertyName("partitionKey")]
    public V1api20231115storageSqlDatabaseContainerStatusResourcePartitionKey? PartitionKey { get; set; }

    /// <summary>Storage version of v1api20231115.RestoreParametersBase_STATUS Parameters to indicate the information about the restore.</summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20231115storageSqlDatabaseContainerStatusResourceRestoreParameters? RestoreParameters { get; set; }

    /// <summary>Storage version of v1api20231115.UniqueKeyPolicy_STATUS The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service.</summary>
    [JsonPropertyName("uniqueKeyPolicy")]
    public V1api20231115storageSqlDatabaseContainerStatusResourceUniqueKeyPolicy? UniqueKeyPolicy { get; set; }
}

/// <summary>Storage version of v1api20231115.SqlDatabaseContainer_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageSqlDatabaseContainerStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231115storageSqlDatabaseContainerStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20231115.OptionsResource_STATUS Cosmos DB options resource object</summary>
    [JsonPropertyName("options")]
    public V1api20231115storageSqlDatabaseContainerStatusOptions? Options { get; set; }

    /// <summary>Storage version of v1api20231115.SqlContainerGetProperties_Resource_STATUS</summary>
    [JsonPropertyName("resource")]
    public V1api20231115storageSqlDatabaseContainerStatusResource? Resource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20231115.SqlDatabaseContainer Generator information: - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2023-11-15/cosmos-db.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231115storageSqlDatabaseContainer : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231115storageSqlDatabaseContainerSpec>, IStatus<V1api20231115storageSqlDatabaseContainerStatus>
{
    public const string KubeApiVersion = "v1api20231115storage";
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

    /// <summary>Storage version of v1api20231115.SqlDatabaseContainer_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20231115storageSqlDatabaseContainerSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20231115.SqlDatabaseContainer_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20231115storageSqlDatabaseContainerStatus? Status { get; set; }
}