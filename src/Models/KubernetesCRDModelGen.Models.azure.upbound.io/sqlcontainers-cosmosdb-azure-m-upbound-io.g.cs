using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cosmosdb.azure.m.upbound.io;
/// <summary>SQLContainer is the Schema for the SQLContainers API. Manages a SQL Container within a Cosmos DB Account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLContainerList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SQLContainer>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLContainerList";
    public const string KubeGroup = "cosmosdb.azure.m.upbound.io";
    public const string KubePluralName = "sqlcontainers";
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
    public IList<V1beta1SQLContainer> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderAccountNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Account in cosmosdb to populate accountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SQLContainerSpecForProviderAccountNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderAccountNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Account in cosmosdb to populate accountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderAccountNameSelector
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
    public V1beta1SQLContainerSpecForProviderAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary>An autoscale_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderAutoscaleSettings
{
    /// <summary>The maximum throughput of the SQL container (RU/s). Must be between 1,000 and 1,000,000. Must be set in increments of 1,000. Conflicts with throughput.</summary>
    [JsonPropertyName("maxThroughput")]
    public double? MaxThroughput { get; set; }
}

/// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderConflictResolutionPolicy
{
    /// <summary>The conflict resolution path in the case of LastWriterWins mode.</summary>
    [JsonPropertyName("conflictResolutionPath")]
    public string? ConflictResolutionPath { get; set; }

    /// <summary>The procedure to resolve conflicts in the case of Custom mode.</summary>
    [JsonPropertyName("conflictResolutionProcedure")]
    public string? ConflictResolutionProcedure { get; set; }

    /// <summary>Indicates the conflict resolution mode. Possible values include: LastWriterWins, Custom.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderDatabaseNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SQLDatabase in cosmosdb to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SQLContainerSpecForProviderDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderDatabaseNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SQLDatabase in cosmosdb to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderDatabaseNameSelector
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
    public V1beta1SQLContainerSpecForProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderIndexingPolicyCompositeIndexIndex
{
    /// <summary>Order of the index. Possible values are Ascending or Descending.</summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderIndexingPolicyCompositeIndex
{
    /// <summary>One or more index blocks as defined below.</summary>
    [JsonPropertyName("index")]
    public IList<V1beta1SQLContainerSpecForProviderIndexingPolicyCompositeIndexIndex>? Index { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderIndexingPolicyExcludedPath
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderIndexingPolicyIncludedPath
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderIndexingPolicySpatialIndex
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>An indexing_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderIndexingPolicy
{
    /// <summary>One or more composite_index blocks as defined below.</summary>
    [JsonPropertyName("compositeIndex")]
    public IList<V1beta1SQLContainerSpecForProviderIndexingPolicyCompositeIndex>? CompositeIndex { get; set; }

    /// <summary>One or more excluded_path blocks as defined below. Either included_path or excluded_path must contain the path /*</summary>
    [JsonPropertyName("excludedPath")]
    public IList<V1beta1SQLContainerSpecForProviderIndexingPolicyExcludedPath>? ExcludedPath { get; set; }

    /// <summary>One or more included_path blocks as defined below. Either included_path or excluded_path must contain the path /*</summary>
    [JsonPropertyName("includedPath")]
    public IList<V1beta1SQLContainerSpecForProviderIndexingPolicyIncludedPath>? IncludedPath { get; set; }

    /// <summary>Indicates the indexing mode. Possible values include: consistent and none. Defaults to consistent.</summary>
    [JsonPropertyName("indexingMode")]
    public string? IndexingMode { get; set; }

    /// <summary>One or more spatial_index blocks as defined below.</summary>
    [JsonPropertyName("spatialIndex")]
    public IList<V1beta1SQLContainerSpecForProviderIndexingPolicySpatialIndex>? SpatialIndex { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SQLContainerSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderResourceGroupNameSelector
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
    public V1beta1SQLContainerSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProviderUniqueKey
{
    /// <summary>A list of paths to use for this unique key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecForProvider
{
    /// <summary>The name of the Cosmos DB Account to create the container within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Reference to a Account in cosmosdb to populate accountName.</summary>
    [JsonPropertyName("accountNameRef")]
    public V1beta1SQLContainerSpecForProviderAccountNameRef? AccountNameRef { get; set; }

    /// <summary>Selector for a Account in cosmosdb to populate accountName.</summary>
    [JsonPropertyName("accountNameSelector")]
    public V1beta1SQLContainerSpecForProviderAccountNameSelector? AccountNameSelector { get; set; }

    /// <summary>The default time to live of Analytical Storage for this SQL container. If present and the value is set to -1, it is equal to infinity, and items don’t expire by default. If present and the value is set to some number n – items will expire n seconds after their last modified time.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public double? AnalyticalStorageTtl { get; set; }

    /// <summary>An autoscale_settings block as defined below.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1beta1SQLContainerSpecForProviderAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1beta1SQLContainerSpecForProviderConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary>The name of the Cosmos DB SQL Database to create the container within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a SQLDatabase in cosmosdb to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta1SQLContainerSpecForProviderDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a SQLDatabase in cosmosdb to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta1SQLContainerSpecForProviderDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>The default time to live of SQL container. If missing, items are not expired automatically. If present and the value is set to -1, it is equal to infinity, and items don’t expire by default. If present and the value is set to some number n – items will expire n seconds after their last modified time.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>An indexing_policy block as defined below.</summary>
    [JsonPropertyName("indexingPolicy")]
    public V1beta1SQLContainerSpecForProviderIndexingPolicy? IndexingPolicy { get; set; }

    /// <summary>Define a partition key kind. Possible values are Hash and MultiHash. Defaults to Hash. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partitionKeyKind")]
    public string? PartitionKeyKind { get; set; }

    /// <summary>A list of partition key paths. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partitionKeyPaths")]
    public IList<string>? PartitionKeyPaths { get; set; }

    /// <summary>Define a partition key version. Possible values are 1and 2. This should be set to 2 in order to use large partition keys.</summary>
    [JsonPropertyName("partitionKeyVersion")]
    public double? PartitionKeyVersion { get; set; }

    /// <summary>The name of the resource group in which the Cosmos DB SQL Container is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1SQLContainerSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1SQLContainerSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The throughput of SQL container (RU/s). Must be set in increments of 100. The minimum value is 400.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>One or more unique_key blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uniqueKey")]
    public IList<V1beta1SQLContainerSpecForProviderUniqueKey>? UniqueKey { get; set; }
}

/// <summary>An autoscale_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecInitProviderAutoscaleSettings
{
    /// <summary>The maximum throughput of the SQL container (RU/s). Must be between 1,000 and 1,000,000. Must be set in increments of 1,000. Conflicts with throughput.</summary>
    [JsonPropertyName("maxThroughput")]
    public double? MaxThroughput { get; set; }
}

/// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecInitProviderConflictResolutionPolicy
{
    /// <summary>The conflict resolution path in the case of LastWriterWins mode.</summary>
    [JsonPropertyName("conflictResolutionPath")]
    public string? ConflictResolutionPath { get; set; }

    /// <summary>The procedure to resolve conflicts in the case of Custom mode.</summary>
    [JsonPropertyName("conflictResolutionProcedure")]
    public string? ConflictResolutionProcedure { get; set; }

    /// <summary>Indicates the conflict resolution mode. Possible values include: LastWriterWins, Custom.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecInitProviderIndexingPolicyCompositeIndexIndex
{
    /// <summary>Order of the index. Possible values are Ascending or Descending.</summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecInitProviderIndexingPolicyCompositeIndex
{
    /// <summary>One or more index blocks as defined below.</summary>
    [JsonPropertyName("index")]
    public IList<V1beta1SQLContainerSpecInitProviderIndexingPolicyCompositeIndexIndex>? Index { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecInitProviderIndexingPolicyExcludedPath
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecInitProviderIndexingPolicyIncludedPath
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecInitProviderIndexingPolicySpatialIndex
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>An indexing_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecInitProviderIndexingPolicy
{
    /// <summary>One or more composite_index blocks as defined below.</summary>
    [JsonPropertyName("compositeIndex")]
    public IList<V1beta1SQLContainerSpecInitProviderIndexingPolicyCompositeIndex>? CompositeIndex { get; set; }

    /// <summary>One or more excluded_path blocks as defined below. Either included_path or excluded_path must contain the path /*</summary>
    [JsonPropertyName("excludedPath")]
    public IList<V1beta1SQLContainerSpecInitProviderIndexingPolicyExcludedPath>? ExcludedPath { get; set; }

    /// <summary>One or more included_path blocks as defined below. Either included_path or excluded_path must contain the path /*</summary>
    [JsonPropertyName("includedPath")]
    public IList<V1beta1SQLContainerSpecInitProviderIndexingPolicyIncludedPath>? IncludedPath { get; set; }

    /// <summary>Indicates the indexing mode. Possible values include: consistent and none. Defaults to consistent.</summary>
    [JsonPropertyName("indexingMode")]
    public string? IndexingMode { get; set; }

    /// <summary>One or more spatial_index blocks as defined below.</summary>
    [JsonPropertyName("spatialIndex")]
    public IList<V1beta1SQLContainerSpecInitProviderIndexingPolicySpatialIndex>? SpatialIndex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecInitProviderUniqueKey
{
    /// <summary>A list of paths to use for this unique key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecInitProvider
{
    /// <summary>The default time to live of Analytical Storage for this SQL container. If present and the value is set to -1, it is equal to infinity, and items don’t expire by default. If present and the value is set to some number n – items will expire n seconds after their last modified time.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public double? AnalyticalStorageTtl { get; set; }

    /// <summary>An autoscale_settings block as defined below.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1beta1SQLContainerSpecInitProviderAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1beta1SQLContainerSpecInitProviderConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary>The default time to live of SQL container. If missing, items are not expired automatically. If present and the value is set to -1, it is equal to infinity, and items don’t expire by default. If present and the value is set to some number n – items will expire n seconds after their last modified time.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>An indexing_policy block as defined below.</summary>
    [JsonPropertyName("indexingPolicy")]
    public V1beta1SQLContainerSpecInitProviderIndexingPolicy? IndexingPolicy { get; set; }

    /// <summary>Define a partition key kind. Possible values are Hash and MultiHash. Defaults to Hash. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partitionKeyKind")]
    public string? PartitionKeyKind { get; set; }

    /// <summary>A list of partition key paths. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partitionKeyPaths")]
    public IList<string>? PartitionKeyPaths { get; set; }

    /// <summary>Define a partition key version. Possible values are 1and 2. This should be set to 2 in order to use large partition keys.</summary>
    [JsonPropertyName("partitionKeyVersion")]
    public double? PartitionKeyVersion { get; set; }

    /// <summary>The throughput of SQL container (RU/s). Must be set in increments of 100. The minimum value is 400.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>One or more unique_key blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uniqueKey")]
    public IList<V1beta1SQLContainerSpecInitProviderUniqueKey>? UniqueKey { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpecProviderConfigRef
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
public partial class V1beta1SQLContainerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SQLContainerSpec defines the desired state of SQLContainer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SQLContainerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SQLContainerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SQLContainerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SQLContainerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An autoscale_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerStatusAtProviderAutoscaleSettings
{
    /// <summary>The maximum throughput of the SQL container (RU/s). Must be between 1,000 and 1,000,000. Must be set in increments of 1,000. Conflicts with throughput.</summary>
    [JsonPropertyName("maxThroughput")]
    public double? MaxThroughput { get; set; }
}

/// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerStatusAtProviderConflictResolutionPolicy
{
    /// <summary>The conflict resolution path in the case of LastWriterWins mode.</summary>
    [JsonPropertyName("conflictResolutionPath")]
    public string? ConflictResolutionPath { get; set; }

    /// <summary>The procedure to resolve conflicts in the case of Custom mode.</summary>
    [JsonPropertyName("conflictResolutionProcedure")]
    public string? ConflictResolutionProcedure { get; set; }

    /// <summary>Indicates the conflict resolution mode. Possible values include: LastWriterWins, Custom.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerStatusAtProviderIndexingPolicyCompositeIndexIndex
{
    /// <summary>Order of the index. Possible values are Ascending or Descending.</summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerStatusAtProviderIndexingPolicyCompositeIndex
{
    /// <summary>One or more index blocks as defined below.</summary>
    [JsonPropertyName("index")]
    public IList<V1beta1SQLContainerStatusAtProviderIndexingPolicyCompositeIndexIndex>? Index { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerStatusAtProviderIndexingPolicyExcludedPath
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerStatusAtProviderIndexingPolicyIncludedPath
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerStatusAtProviderIndexingPolicySpatialIndex
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A set of spatial types of the path.</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary>An indexing_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerStatusAtProviderIndexingPolicy
{
    /// <summary>One or more composite_index blocks as defined below.</summary>
    [JsonPropertyName("compositeIndex")]
    public IList<V1beta1SQLContainerStatusAtProviderIndexingPolicyCompositeIndex>? CompositeIndex { get; set; }

    /// <summary>One or more excluded_path blocks as defined below. Either included_path or excluded_path must contain the path /*</summary>
    [JsonPropertyName("excludedPath")]
    public IList<V1beta1SQLContainerStatusAtProviderIndexingPolicyExcludedPath>? ExcludedPath { get; set; }

    /// <summary>One or more included_path blocks as defined below. Either included_path or excluded_path must contain the path /*</summary>
    [JsonPropertyName("includedPath")]
    public IList<V1beta1SQLContainerStatusAtProviderIndexingPolicyIncludedPath>? IncludedPath { get; set; }

    /// <summary>Indicates the indexing mode. Possible values include: consistent and none. Defaults to consistent.</summary>
    [JsonPropertyName("indexingMode")]
    public string? IndexingMode { get; set; }

    /// <summary>One or more spatial_index blocks as defined below.</summary>
    [JsonPropertyName("spatialIndex")]
    public IList<V1beta1SQLContainerStatusAtProviderIndexingPolicySpatialIndex>? SpatialIndex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerStatusAtProviderUniqueKey
{
    /// <summary>A list of paths to use for this unique key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerStatusAtProvider
{
    /// <summary>The name of the Cosmos DB Account to create the container within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>The default time to live of Analytical Storage for this SQL container. If present and the value is set to -1, it is equal to infinity, and items don’t expire by default. If present and the value is set to some number n – items will expire n seconds after their last modified time.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public double? AnalyticalStorageTtl { get; set; }

    /// <summary>An autoscale_settings block as defined below.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1beta1SQLContainerStatusAtProviderAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1beta1SQLContainerStatusAtProviderConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary>The name of the Cosmos DB SQL Database to create the container within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The default time to live of SQL container. If missing, items are not expired automatically. If present and the value is set to -1, it is equal to infinity, and items don’t expire by default. If present and the value is set to some number n – items will expire n seconds after their last modified time.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>The ID of the CosmosDB SQL Container.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An indexing_policy block as defined below.</summary>
    [JsonPropertyName("indexingPolicy")]
    public V1beta1SQLContainerStatusAtProviderIndexingPolicy? IndexingPolicy { get; set; }

    /// <summary>Define a partition key kind. Possible values are Hash and MultiHash. Defaults to Hash. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partitionKeyKind")]
    public string? PartitionKeyKind { get; set; }

    /// <summary>A list of partition key paths. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partitionKeyPaths")]
    public IList<string>? PartitionKeyPaths { get; set; }

    /// <summary>Define a partition key version. Possible values are 1and 2. This should be set to 2 in order to use large partition keys.</summary>
    [JsonPropertyName("partitionKeyVersion")]
    public double? PartitionKeyVersion { get; set; }

    /// <summary>The name of the resource group in which the Cosmos DB SQL Container is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The throughput of SQL container (RU/s). Must be set in increments of 100. The minimum value is 400.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>One or more unique_key blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uniqueKey")]
    public IList<V1beta1SQLContainerStatusAtProviderUniqueKey>? UniqueKey { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerStatusConditions
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

/// <summary>SQLContainerStatus defines the observed state of SQLContainer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLContainerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SQLContainerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SQLContainerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SQLContainer is the Schema for the SQLContainers API. Manages a SQL Container within a Cosmos DB Account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLContainer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SQLContainerSpec>, IStatus<V1beta1SQLContainerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLContainer";
    public const string KubeGroup = "cosmosdb.azure.m.upbound.io";
    public const string KubePluralName = "sqlcontainers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SQLContainerSpec defines the desired state of SQLContainer</summary>
    [JsonPropertyName("spec")]
    public V1beta1SQLContainerSpec Spec { get; set; }

    /// <summary>SQLContainerStatus defines the observed state of SQLContainer.</summary>
    [JsonPropertyName("status")]
    public V1beta1SQLContainerStatus? Status { get; set; }
}