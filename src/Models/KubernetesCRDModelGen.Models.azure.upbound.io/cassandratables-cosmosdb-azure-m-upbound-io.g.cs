using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cosmosdb.azure.m.upbound.io;
/// <summary>An autoscale_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecForProviderAutoscaleSettings
{
    /// <summary>The maximum throughput of the Cassandra Table (RU/s). Must be between 1,000 and 1,000,000. Must be set in increments of 1,000. Conflicts with throughput.</summary>
    [JsonPropertyName("maxThroughput")]
    public double? MaxThroughput { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecForProviderCassandraKeyspaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CassandraKeySpace in cosmosdb to populate cassandraKeyspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecForProviderCassandraKeyspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CassandraTableSpecForProviderCassandraKeyspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecForProviderCassandraKeyspaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CassandraKeySpace in cosmosdb to populate cassandraKeyspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecForProviderCassandraKeyspaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CassandraTableSpecForProviderCassandraKeyspaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecForProviderSchemaClusterKey
{
    /// <summary>Name of the column to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Order of the key. Currently supported values are Asc and Desc.</summary>
    [JsonPropertyName("orderBy")]
    public string? OrderBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecForProviderSchemaColumn
{
    /// <summary>Name of the column to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of the column to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecForProviderSchemaPartitionKey
{
    /// <summary>Name of the column to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A schema block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecForProviderSchema
{
    /// <summary>One or more cluster_key blocks as defined below.</summary>
    [JsonPropertyName("clusterKey")]
    public IList<V1beta1CassandraTableSpecForProviderSchemaClusterKey>? ClusterKey { get; set; }

    /// <summary>One or more column blocks as defined below.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta1CassandraTableSpecForProviderSchemaColumn>? Column { get; set; }

    /// <summary>One or more partition_key blocks as defined below.</summary>
    [JsonPropertyName("partitionKey")]
    public IList<V1beta1CassandraTableSpecForProviderSchemaPartitionKey>? PartitionKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecForProvider
{
    /// <summary>Time to live of the Analytical Storage. Possible values are between -1 and 2147483647 except 0. -1 means the Analytical Storage never expires. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public double? AnalyticalStorageTtl { get; set; }

    /// <summary>An autoscale_settings block as defined below.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1beta1CassandraTableSpecForProviderAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>The ID of the Cosmos DB Cassandra Keyspace to create the table within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cassandraKeyspaceId")]
    public string? CassandraKeyspaceId { get; set; }

    /// <summary>Reference to a CassandraKeySpace in cosmosdb to populate cassandraKeyspaceId.</summary>
    [JsonPropertyName("cassandraKeyspaceIdRef")]
    public V1beta1CassandraTableSpecForProviderCassandraKeyspaceIdRef? CassandraKeyspaceIdRef { get; set; }

    /// <summary>Selector for a CassandraKeySpace in cosmosdb to populate cassandraKeyspaceId.</summary>
    [JsonPropertyName("cassandraKeyspaceIdSelector")]
    public V1beta1CassandraTableSpecForProviderCassandraKeyspaceIdSelector? CassandraKeyspaceIdSelector { get; set; }

    /// <summary>Time to live of the Cosmos DB Cassandra table. Possible values are at least -1. -1 means the Cassandra table never expires.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>A schema block as defined below.</summary>
    [JsonPropertyName("schema")]
    public V1beta1CassandraTableSpecForProviderSchema? Schema { get; set; }

    /// <summary>The throughput of Cassandra KeySpace (RU/s). Must be set in increments of 100. The minimum value is 400.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }
}

/// <summary>An autoscale_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecInitProviderAutoscaleSettings
{
    /// <summary>The maximum throughput of the Cassandra Table (RU/s). Must be between 1,000 and 1,000,000. Must be set in increments of 1,000. Conflicts with throughput.</summary>
    [JsonPropertyName("maxThroughput")]
    public double? MaxThroughput { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecInitProviderSchemaClusterKey
{
    /// <summary>Name of the column to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Order of the key. Currently supported values are Asc and Desc.</summary>
    [JsonPropertyName("orderBy")]
    public string? OrderBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecInitProviderSchemaColumn
{
    /// <summary>Name of the column to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of the column to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecInitProviderSchemaPartitionKey
{
    /// <summary>Name of the column to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A schema block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecInitProviderSchema
{
    /// <summary>One or more cluster_key blocks as defined below.</summary>
    [JsonPropertyName("clusterKey")]
    public IList<V1beta1CassandraTableSpecInitProviderSchemaClusterKey>? ClusterKey { get; set; }

    /// <summary>One or more column blocks as defined below.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta1CassandraTableSpecInitProviderSchemaColumn>? Column { get; set; }

    /// <summary>One or more partition_key blocks as defined below.</summary>
    [JsonPropertyName("partitionKey")]
    public IList<V1beta1CassandraTableSpecInitProviderSchemaPartitionKey>? PartitionKey { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecInitProvider
{
    /// <summary>Time to live of the Analytical Storage. Possible values are between -1 and 2147483647 except 0. -1 means the Analytical Storage never expires. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public double? AnalyticalStorageTtl { get; set; }

    /// <summary>An autoscale_settings block as defined below.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1beta1CassandraTableSpecInitProviderAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>Time to live of the Cosmos DB Cassandra table. Possible values are at least -1. -1 means the Cassandra table never expires.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>A schema block as defined below.</summary>
    [JsonPropertyName("schema")]
    public V1beta1CassandraTableSpecInitProviderSchema? Schema { get; set; }

    /// <summary>The throughput of Cassandra KeySpace (RU/s). Must be set in increments of 100. The minimum value is 400.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>CassandraTableSpec defines the desired state of CassandraTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CassandraTableSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CassandraTableSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CassandraTableSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CassandraTableSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An autoscale_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableStatusAtProviderAutoscaleSettings
{
    /// <summary>The maximum throughput of the Cassandra Table (RU/s). Must be between 1,000 and 1,000,000. Must be set in increments of 1,000. Conflicts with throughput.</summary>
    [JsonPropertyName("maxThroughput")]
    public double? MaxThroughput { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableStatusAtProviderSchemaClusterKey
{
    /// <summary>Name of the column to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Order of the key. Currently supported values are Asc and Desc.</summary>
    [JsonPropertyName("orderBy")]
    public string? OrderBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableStatusAtProviderSchemaColumn
{
    /// <summary>Name of the column to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of the column to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableStatusAtProviderSchemaPartitionKey
{
    /// <summary>Name of the column to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A schema block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableStatusAtProviderSchema
{
    /// <summary>One or more cluster_key blocks as defined below.</summary>
    [JsonPropertyName("clusterKey")]
    public IList<V1beta1CassandraTableStatusAtProviderSchemaClusterKey>? ClusterKey { get; set; }

    /// <summary>One or more column blocks as defined below.</summary>
    [JsonPropertyName("column")]
    public IList<V1beta1CassandraTableStatusAtProviderSchemaColumn>? Column { get; set; }

    /// <summary>One or more partition_key blocks as defined below.</summary>
    [JsonPropertyName("partitionKey")]
    public IList<V1beta1CassandraTableStatusAtProviderSchemaPartitionKey>? PartitionKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableStatusAtProvider
{
    /// <summary>Time to live of the Analytical Storage. Possible values are between -1 and 2147483647 except 0. -1 means the Analytical Storage never expires. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public double? AnalyticalStorageTtl { get; set; }

    /// <summary>An autoscale_settings block as defined below.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1beta1CassandraTableStatusAtProviderAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>The ID of the Cosmos DB Cassandra Keyspace to create the table within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cassandraKeyspaceId")]
    public string? CassandraKeyspaceId { get; set; }

    /// <summary>Time to live of the Cosmos DB Cassandra table. Possible values are at least -1. -1 means the Cassandra table never expires.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>the ID of the CosmosDB Cassandra Table.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A schema block as defined below.</summary>
    [JsonPropertyName("schema")]
    public V1beta1CassandraTableStatusAtProviderSchema? Schema { get; set; }

    /// <summary>The throughput of Cassandra KeySpace (RU/s). Must be set in increments of 100. The minimum value is 400.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableStatusConditions
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

/// <summary>CassandraTableStatus defines the observed state of CassandraTable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CassandraTableStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CassandraTableStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CassandraTableStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CassandraTable is the Schema for the CassandraTables API. Manages a Cassandra Table within a Cosmos DB Cassandra Keyspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CassandraTable : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CassandraTableSpec>, IStatus<V1beta1CassandraTableStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CassandraTable";
    public const string KubeGroup = "cosmosdb.azure.m.upbound.io";
    public const string KubePluralName = "cassandratables";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CassandraTableSpec defines the desired state of CassandraTable</summary>
    [JsonPropertyName("spec")]
    public V1beta1CassandraTableSpec Spec { get; set; }

    /// <summary>CassandraTableStatus defines the observed state of CassandraTable.</summary>
    [JsonPropertyName("status")]
    public V1beta1CassandraTableStatus? Status { get; set; }
}

/// <summary>CassandraTable is the Schema for the CassandraTables API. Manages a Cassandra Table within a Cosmos DB Cassandra Keyspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CassandraTableList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CassandraTable>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CassandraTableList";
    public const string KubeGroup = "cosmosdb.azure.m.upbound.io";
    public const string KubePluralName = "cassandratables";
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
    public IList<V1beta1CassandraTable> Items { get; set; }
}