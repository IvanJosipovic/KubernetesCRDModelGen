using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cosmosdb.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderAnalyticalStorage
{
    /// <summary>The schema type of the Analytical Storage for this Cosmos DB account. Possible values are FullFidelity and WellDefined.</summary>
    [JsonPropertyName("schemaType")]
    public string? SchemaType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderBackup
{
    /// <summary>The interval in minutes between two backups. Possible values are between 60 and 1440. Defaults to 240.</summary>
    [JsonPropertyName("intervalInMinutes")]
    public double? IntervalInMinutes { get; set; }

    /// <summary>The time in hours that each backup is retained. Possible values are between 8 and 720. Defaults to 8.</summary>
    [JsonPropertyName("retentionInHours")]
    public double? RetentionInHours { get; set; }

    /// <summary>The storage redundancy is used to indicate the type of backup residency. Possible values are Geo, Local and Zone. Defaults to Geo.</summary>
    [JsonPropertyName("storageRedundancy")]
    public string? StorageRedundancy { get; set; }

    /// <summary>The continuous backup tier. Possible values are Continuous7Days and Continuous30Days.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The type of the backup. Possible values are Continuous and Periodic.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderCapabilities
{
    /// <summary>The capability to enable - Possible values are AllowSelfServeUpgradeToMongo36, DisableRateLimitingResponses, EnableAggregationPipeline, EnableCassandra, EnableGremlin, EnableMongo, EnableMongo16MBDocumentSupport, EnableMongoRetryableWrites, EnableMongoRoleBasedAccessControl, EnablePartialUniqueIndex, EnableServerless, EnableTable, EnableTtlOnCustomPath, EnableUniqueCompoundNestedDocs, MongoDBv3.4 and mongoEnableDocLevelTTL.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderCapacity
{
    /// <summary>The total throughput limit imposed on this Cosmos DB account (RU/s). Possible values are at least -1. -1 means no limit.</summary>
    [JsonPropertyName("totalThroughputLimit")]
    public double? TotalThroughputLimit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderConsistencyPolicy
{
    /// <summary>The Consistency Level to use for this CosmosDB Account - can be either BoundedStaleness, Eventual, Session, Strong or ConsistentPrefix.</summary>
    [JsonPropertyName("consistencyLevel")]
    public string? ConsistencyLevel { get; set; }

    /// <summary>When used with the Bounded Staleness consistency level, this value represents the time amount of staleness (in seconds) tolerated. The accepted range for this value is 5 - 86400 (1 day). Defaults to 5. Required when consistency_level is set to BoundedStaleness.</summary>
    [JsonPropertyName("maxIntervalInSeconds")]
    public double? MaxIntervalInSeconds { get; set; }

    /// <summary>When used with the Bounded Staleness consistency level, this value represents the number of stale requests tolerated. The accepted range for this value is 10 – 2147483647. Defaults to 100. Required when consistency_level is set to BoundedStaleness.</summary>
    [JsonPropertyName("maxStalenessPrefix")]
    public double? MaxStalenessPrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderCorsRule
{
    /// <summary>A list of headers that are allowed to be a part of the cross-origin request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of HTTP headers that are allowed to be executed by the origin. Valid options are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PUT or PATCH.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of origin domains that will be allowed by CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>A list of response headers that are exposed to CORS clients.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>The number of seconds the client should cache a preflight response. Possible values are between 1 and 2147483647.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderGeoLocation
{
    /// <summary>The failover priority of the region. A failover priority of 0 indicates a write region. The maximum value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the regions in which the database account exists. Changing this causes the location to be re-provisioned and cannot be changed for the location with failover priority 0.</summary>
    [JsonPropertyName("failoverPriority")]
    public double? FailoverPriority { get; set; }

    /// <summary>The name of the Azure region to host replicated data.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Should zone redundancy be enabled for this region? Defaults to false.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderIdentityIdentityIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderIdentityIdentityIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecForProviderIdentityIdentityIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderIdentityIdentityIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderIdentityIdentityIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecForProviderIdentityIdentityIdsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Cosmos Account.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>References to UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsRefs")]
    public IList<V1beta1AccountSpecForProviderIdentityIdentityIdsRefs>? IdentityIdsRefs { get; set; }

    /// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsSelector")]
    public V1beta1AccountSpecForProviderIdentityIdentityIdsSelector? IdentityIdsSelector { get; set; }

    /// <summary>The Type of Managed Identity assigned to this Cosmos account. Possible values are SystemAssigned, UserAssigned and SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1AccountSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1AccountSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderRestoreDatabase
{
    /// <summary>A list of the collection names for the restore request. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("collectionNames")]
    public IList<string>? CollectionNames { get; set; }

    /// <summary>Specifies the name of the CosmosDB Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderRestoreGremlinDatabase
{
    /// <summary>A list of the Graph names for the restore request. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("graphNames")]
    public IList<string>? GraphNames { get; set; }

    /// <summary>Specifies the name of the CosmosDB Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderRestoreSourceCosmosdbAccountIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Account in cosmosdb to populate sourceCosmosdbAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderRestoreSourceCosmosdbAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecForProviderRestoreSourceCosmosdbAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderRestoreSourceCosmosdbAccountIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Account in cosmosdb to populate sourceCosmosdbAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderRestoreSourceCosmosdbAccountIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecForProviderRestoreSourceCosmosdbAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderRestore
{
    /// <summary>A database block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("database")]
    public IList<V1beta1AccountSpecForProviderRestoreDatabase>? Database { get; set; }

    /// <summary>One or more gremlin_database blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("gremlinDatabase")]
    public IList<V1beta1AccountSpecForProviderRestoreGremlinDatabase>? GremlinDatabase { get; set; }

    /// <summary>The creation time of the database or the collection (Datetime Format RFC 3339). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }

    /// <summary>The resource ID of the restorable database account from which the restore has to be initiated. The example is /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{restorableDatabaseAccountName}. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceCosmosdbAccountId")]
    public string? SourceCosmosdbAccountId { get; set; }

    /// <summary>Reference to a Account in cosmosdb to populate sourceCosmosdbAccountId.</summary>
    [JsonPropertyName("sourceCosmosdbAccountIdRef")]
    public V1beta1AccountSpecForProviderRestoreSourceCosmosdbAccountIdRef? SourceCosmosdbAccountIdRef { get; set; }

    /// <summary>Selector for a Account in cosmosdb to populate sourceCosmosdbAccountId.</summary>
    [JsonPropertyName("sourceCosmosdbAccountIdSelector")]
    public V1beta1AccountSpecForProviderRestoreSourceCosmosdbAccountIdSelector? SourceCosmosdbAccountIdSelector { get; set; }

    /// <summary>A list of specific tables available for restore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tablesToRestore")]
    public IList<string>? TablesToRestore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProviderVirtualNetworkRule
{
    /// <summary>The ID of the virtual network subnet.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>If set to true, the specified subnet will be added as a virtual network rule even if its CosmosDB service endpoint is not active. Defaults to false.</summary>
    [JsonPropertyName("ignoreMissingVnetServiceEndpoint")]
    public bool? IgnoreMissingVnetServiceEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecForProvider
{
    /// <summary>Is write operations on metadata resources (databases, containers, throughput) via account keys enabled? Defaults to true.</summary>
    [JsonPropertyName("accessKeyMetadataWritesEnabled")]
    public bool? AccessKeyMetadataWritesEnabled { get; set; }

    /// <summary>An analytical_storage block as defined below.</summary>
    [JsonPropertyName("analyticalStorage")]
    public IList<V1beta1AccountSpecForProviderAnalyticalStorage>? AnalyticalStorage { get; set; }

    /// <summary>Enable Analytical Storage option for this Cosmos DB account. Defaults to false. Enabling and then disabling analytical storage forces a new resource to be created.</summary>
    [JsonPropertyName("analyticalStorageEnabled")]
    public bool? AnalyticalStorageEnabled { get; set; }

    /// <summary>Enable automatic failover for this Cosmos DB account.</summary>
    [JsonPropertyName("automaticFailoverEnabled")]
    public bool? AutomaticFailoverEnabled { get; set; }

    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public IList<V1beta1AccountSpecForProviderBackup>? Backup { get; set; }

    /// <summary>Enable burst capacity for this Cosmos DB account. Defaults to false.</summary>
    [JsonPropertyName("burstCapacityEnabled")]
    public bool? BurstCapacityEnabled { get; set; }

    /// <summary>The capabilities which should be enabled for this Cosmos DB account. Value is a capabilities block as defined below.</summary>
    [JsonPropertyName("capabilities")]
    public IList<V1beta1AccountSpecForProviderCapabilities>? Capabilities { get; set; }

    /// <summary>A capacity block as defined below.</summary>
    [JsonPropertyName("capacity")]
    public IList<V1beta1AccountSpecForProviderCapacity>? Capacity { get; set; }

    /// <summary>Specifies one consistency_policy block as defined below, used to define the consistency policy for this CosmosDB account.</summary>
    [JsonPropertyName("consistencyPolicy")]
    public IList<V1beta1AccountSpecForProviderConsistencyPolicy>? ConsistencyPolicy { get; set; }

    /// <summary>A cors_rule block as defined below.</summary>
    [JsonPropertyName("corsRule")]
    public IList<V1beta1AccountSpecForProviderCorsRule>? CorsRule { get; set; }

    /// <summary>The creation mode for the CosmosDB Account. Possible values are Default and Restore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>The default identity for accessing Key Vault. Possible values are FirstPartyIdentity, SystemAssignedIdentity or UserAssignedIdentity. Defaults to FirstPartyIdentity.</summary>
    [JsonPropertyName("defaultIdentityType")]
    public string? DefaultIdentityType { get; set; }

    /// <summary>Enable automatic failover for this Cosmos DB account.</summary>
    [JsonPropertyName("enableAutomaticFailover")]
    public bool? EnableAutomaticFailover { get; set; }

    /// <summary>Enable the Free Tier pricing option for this Cosmos DB account. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enableFreeTier")]
    public bool? EnableFreeTier { get; set; }

    /// <summary>Enable multiple write locations for this Cosmos DB account.</summary>
    [JsonPropertyName("enableMultipleWriteLocations")]
    public bool? EnableMultipleWriteLocations { get; set; }

    /// <summary>Enable the Free Tier pricing option for this Cosmos DB account. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("freeTierEnabled")]
    public bool? FreeTierEnabled { get; set; }

    /// <summary>Specifies a geo_location resource, used to define where data should be replicated with the failover_priority 0 specifying the primary location. Value is a geo_location block as defined below.</summary>
    [JsonPropertyName("geoLocation")]
    public IList<V1beta1AccountSpecForProviderGeoLocation>? GeoLocation { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1AccountSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>CosmosDB Firewall Support: This value specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma separated and must not contain any spaces.</summary>
    [JsonPropertyName("ipRangeFilter")]
    public string? IpRangeFilter { get; set; }

    /// <summary>Enables virtual network filtering for this Cosmos DB account.</summary>
    [JsonPropertyName("isVirtualNetworkFilterEnabled")]
    public bool? IsVirtualNetworkFilterEnabled { get; set; }

    /// <summary>A versionless Key Vault Key ID for CMK encryption. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Specifies the Kind of CosmosDB to create - possible values are GlobalDocumentDB, MongoDB and Parse. Defaults to GlobalDocumentDB. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Disable local authentication and ensure only MSI and AAD can be used exclusively for authentication. Defaults to false. Can be set only when using the SQL API.</summary>
    [JsonPropertyName("localAuthenticationDisabled")]
    public bool? LocalAuthenticationDisabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the minimal TLS version for the CosmosDB account. Possible values are: Tls, Tls11, and Tls12. Defaults to Tls12.</summary>
    [JsonPropertyName("minimalTlsVersion")]
    public string? MinimalTlsVersion { get; set; }

    /// <summary>The Server Version of a MongoDB account. Possible values are 4.2, 4.0, 3.6, and 3.2.</summary>
    [JsonPropertyName("mongoServerVersion")]
    public string? MongoServerVersion { get; set; }

    /// <summary>Enable multiple write locations for this Cosmos DB account.</summary>
    [JsonPropertyName("multipleWriteLocationsEnabled")]
    public bool? MultipleWriteLocationsEnabled { get; set; }

    /// <summary>If Azure services can bypass ACLs. Defaults to false.</summary>
    [JsonPropertyName("networkAclBypassForAzureServices")]
    public bool? NetworkAclBypassForAzureServices { get; set; }

    /// <summary>The list of resource Ids for Network Acl Bypass for this Cosmos DB account.</summary>
    [JsonPropertyName("networkAclBypassIds")]
    public IList<string>? NetworkAclBypassIds { get; set; }

    /// <summary>Specifies the Offer Type to use for this CosmosDB Account; currently, this can only be set to Standard.</summary>
    [JsonPropertyName("offerType")]
    public string? OfferType { get; set; }

    /// <summary>Is partition merge on the Cosmos DB account enabled? Defaults to false.</summary>
    [JsonPropertyName("partitionMergeEnabled")]
    public bool? PartitionMergeEnabled { get; set; }

    /// <summary>Whether or not public network access is allowed for this CosmosDB account. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which the CosmosDB Account is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1AccountSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1AccountSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A restore block as defined below.</summary>
    [JsonPropertyName("restore")]
    public IList<V1beta1AccountSpecForProviderRestore>? Restore { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a virtual_network_rule block as defined below, used to define which subnets are allowed to access this CosmosDB account.</summary>
    [JsonPropertyName("virtualNetworkRule")]
    public IList<V1beta1AccountSpecForProviderVirtualNetworkRule>? VirtualNetworkRule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderAnalyticalStorage
{
    /// <summary>The schema type of the Analytical Storage for this Cosmos DB account. Possible values are FullFidelity and WellDefined.</summary>
    [JsonPropertyName("schemaType")]
    public string? SchemaType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderBackup
{
    /// <summary>The interval in minutes between two backups. Possible values are between 60 and 1440. Defaults to 240.</summary>
    [JsonPropertyName("intervalInMinutes")]
    public double? IntervalInMinutes { get; set; }

    /// <summary>The time in hours that each backup is retained. Possible values are between 8 and 720. Defaults to 8.</summary>
    [JsonPropertyName("retentionInHours")]
    public double? RetentionInHours { get; set; }

    /// <summary>The storage redundancy is used to indicate the type of backup residency. Possible values are Geo, Local and Zone. Defaults to Geo.</summary>
    [JsonPropertyName("storageRedundancy")]
    public string? StorageRedundancy { get; set; }

    /// <summary>The continuous backup tier. Possible values are Continuous7Days and Continuous30Days.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The type of the backup. Possible values are Continuous and Periodic.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderCapabilities
{
    /// <summary>The capability to enable - Possible values are AllowSelfServeUpgradeToMongo36, DisableRateLimitingResponses, EnableAggregationPipeline, EnableCassandra, EnableGremlin, EnableMongo, EnableMongo16MBDocumentSupport, EnableMongoRetryableWrites, EnableMongoRoleBasedAccessControl, EnablePartialUniqueIndex, EnableServerless, EnableTable, EnableTtlOnCustomPath, EnableUniqueCompoundNestedDocs, MongoDBv3.4 and mongoEnableDocLevelTTL.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderCapacity
{
    /// <summary>The total throughput limit imposed on this Cosmos DB account (RU/s). Possible values are at least -1. -1 means no limit.</summary>
    [JsonPropertyName("totalThroughputLimit")]
    public double? TotalThroughputLimit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderConsistencyPolicy
{
    /// <summary>The Consistency Level to use for this CosmosDB Account - can be either BoundedStaleness, Eventual, Session, Strong or ConsistentPrefix.</summary>
    [JsonPropertyName("consistencyLevel")]
    public string? ConsistencyLevel { get; set; }

    /// <summary>When used with the Bounded Staleness consistency level, this value represents the time amount of staleness (in seconds) tolerated. The accepted range for this value is 5 - 86400 (1 day). Defaults to 5. Required when consistency_level is set to BoundedStaleness.</summary>
    [JsonPropertyName("maxIntervalInSeconds")]
    public double? MaxIntervalInSeconds { get; set; }

    /// <summary>When used with the Bounded Staleness consistency level, this value represents the number of stale requests tolerated. The accepted range for this value is 10 – 2147483647. Defaults to 100. Required when consistency_level is set to BoundedStaleness.</summary>
    [JsonPropertyName("maxStalenessPrefix")]
    public double? MaxStalenessPrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderCorsRule
{
    /// <summary>A list of headers that are allowed to be a part of the cross-origin request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of HTTP headers that are allowed to be executed by the origin. Valid options are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PUT or PATCH.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of origin domains that will be allowed by CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>A list of response headers that are exposed to CORS clients.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>The number of seconds the client should cache a preflight response. Possible values are between 1 and 2147483647.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderGeoLocation
{
    /// <summary>The failover priority of the region. A failover priority of 0 indicates a write region. The maximum value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the regions in which the database account exists. Changing this causes the location to be re-provisioned and cannot be changed for the location with failover priority 0.</summary>
    [JsonPropertyName("failoverPriority")]
    public double? FailoverPriority { get; set; }

    /// <summary>The name of the Azure region to host replicated data.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Should zone redundancy be enabled for this region? Defaults to false.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderIdentityIdentityIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderIdentityIdentityIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecInitProviderIdentityIdentityIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderIdentityIdentityIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderIdentityIdentityIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecInitProviderIdentityIdentityIdsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Cosmos Account.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>References to UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsRefs")]
    public IList<V1beta1AccountSpecInitProviderIdentityIdentityIdsRefs>? IdentityIdsRefs { get; set; }

    /// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsSelector")]
    public V1beta1AccountSpecInitProviderIdentityIdentityIdsSelector? IdentityIdsSelector { get; set; }

    /// <summary>The Type of Managed Identity assigned to this Cosmos account. Possible values are SystemAssigned, UserAssigned and SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderRestoreDatabase
{
    /// <summary>A list of the collection names for the restore request. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("collectionNames")]
    public IList<string>? CollectionNames { get; set; }

    /// <summary>Specifies the name of the CosmosDB Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderRestoreGremlinDatabase
{
    /// <summary>A list of the Graph names for the restore request. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("graphNames")]
    public IList<string>? GraphNames { get; set; }

    /// <summary>Specifies the name of the CosmosDB Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderRestoreSourceCosmosdbAccountIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Account in cosmosdb to populate sourceCosmosdbAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderRestoreSourceCosmosdbAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecInitProviderRestoreSourceCosmosdbAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderRestoreSourceCosmosdbAccountIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Account in cosmosdb to populate sourceCosmosdbAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderRestoreSourceCosmosdbAccountIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecInitProviderRestoreSourceCosmosdbAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderRestore
{
    /// <summary>A database block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("database")]
    public IList<V1beta1AccountSpecInitProviderRestoreDatabase>? Database { get; set; }

    /// <summary>One or more gremlin_database blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("gremlinDatabase")]
    public IList<V1beta1AccountSpecInitProviderRestoreGremlinDatabase>? GremlinDatabase { get; set; }

    /// <summary>The creation time of the database or the collection (Datetime Format RFC 3339). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }

    /// <summary>The resource ID of the restorable database account from which the restore has to be initiated. The example is /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{restorableDatabaseAccountName}. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceCosmosdbAccountId")]
    public string? SourceCosmosdbAccountId { get; set; }

    /// <summary>Reference to a Account in cosmosdb to populate sourceCosmosdbAccountId.</summary>
    [JsonPropertyName("sourceCosmosdbAccountIdRef")]
    public V1beta1AccountSpecInitProviderRestoreSourceCosmosdbAccountIdRef? SourceCosmosdbAccountIdRef { get; set; }

    /// <summary>Selector for a Account in cosmosdb to populate sourceCosmosdbAccountId.</summary>
    [JsonPropertyName("sourceCosmosdbAccountIdSelector")]
    public V1beta1AccountSpecInitProviderRestoreSourceCosmosdbAccountIdSelector? SourceCosmosdbAccountIdSelector { get; set; }

    /// <summary>A list of specific tables available for restore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tablesToRestore")]
    public IList<string>? TablesToRestore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProviderVirtualNetworkRule
{
    /// <summary>The ID of the virtual network subnet.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>If set to true, the specified subnet will be added as a virtual network rule even if its CosmosDB service endpoint is not active. Defaults to false.</summary>
    [JsonPropertyName("ignoreMissingVnetServiceEndpoint")]
    public bool? IgnoreMissingVnetServiceEndpoint { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecInitProvider
{
    /// <summary>Is write operations on metadata resources (databases, containers, throughput) via account keys enabled? Defaults to true.</summary>
    [JsonPropertyName("accessKeyMetadataWritesEnabled")]
    public bool? AccessKeyMetadataWritesEnabled { get; set; }

    /// <summary>An analytical_storage block as defined below.</summary>
    [JsonPropertyName("analyticalStorage")]
    public IList<V1beta1AccountSpecInitProviderAnalyticalStorage>? AnalyticalStorage { get; set; }

    /// <summary>Enable Analytical Storage option for this Cosmos DB account. Defaults to false. Enabling and then disabling analytical storage forces a new resource to be created.</summary>
    [JsonPropertyName("analyticalStorageEnabled")]
    public bool? AnalyticalStorageEnabled { get; set; }

    /// <summary>Enable automatic failover for this Cosmos DB account.</summary>
    [JsonPropertyName("automaticFailoverEnabled")]
    public bool? AutomaticFailoverEnabled { get; set; }

    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public IList<V1beta1AccountSpecInitProviderBackup>? Backup { get; set; }

    /// <summary>Enable burst capacity for this Cosmos DB account. Defaults to false.</summary>
    [JsonPropertyName("burstCapacityEnabled")]
    public bool? BurstCapacityEnabled { get; set; }

    /// <summary>The capabilities which should be enabled for this Cosmos DB account. Value is a capabilities block as defined below.</summary>
    [JsonPropertyName("capabilities")]
    public IList<V1beta1AccountSpecInitProviderCapabilities>? Capabilities { get; set; }

    /// <summary>A capacity block as defined below.</summary>
    [JsonPropertyName("capacity")]
    public IList<V1beta1AccountSpecInitProviderCapacity>? Capacity { get; set; }

    /// <summary>Specifies one consistency_policy block as defined below, used to define the consistency policy for this CosmosDB account.</summary>
    [JsonPropertyName("consistencyPolicy")]
    public IList<V1beta1AccountSpecInitProviderConsistencyPolicy>? ConsistencyPolicy { get; set; }

    /// <summary>A cors_rule block as defined below.</summary>
    [JsonPropertyName("corsRule")]
    public IList<V1beta1AccountSpecInitProviderCorsRule>? CorsRule { get; set; }

    /// <summary>The creation mode for the CosmosDB Account. Possible values are Default and Restore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>The default identity for accessing Key Vault. Possible values are FirstPartyIdentity, SystemAssignedIdentity or UserAssignedIdentity. Defaults to FirstPartyIdentity.</summary>
    [JsonPropertyName("defaultIdentityType")]
    public string? DefaultIdentityType { get; set; }

    /// <summary>Enable automatic failover for this Cosmos DB account.</summary>
    [JsonPropertyName("enableAutomaticFailover")]
    public bool? EnableAutomaticFailover { get; set; }

    /// <summary>Enable the Free Tier pricing option for this Cosmos DB account. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enableFreeTier")]
    public bool? EnableFreeTier { get; set; }

    /// <summary>Enable multiple write locations for this Cosmos DB account.</summary>
    [JsonPropertyName("enableMultipleWriteLocations")]
    public bool? EnableMultipleWriteLocations { get; set; }

    /// <summary>Enable the Free Tier pricing option for this Cosmos DB account. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("freeTierEnabled")]
    public bool? FreeTierEnabled { get; set; }

    /// <summary>Specifies a geo_location resource, used to define where data should be replicated with the failover_priority 0 specifying the primary location. Value is a geo_location block as defined below.</summary>
    [JsonPropertyName("geoLocation")]
    public IList<V1beta1AccountSpecInitProviderGeoLocation>? GeoLocation { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1AccountSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>CosmosDB Firewall Support: This value specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma separated and must not contain any spaces.</summary>
    [JsonPropertyName("ipRangeFilter")]
    public string? IpRangeFilter { get; set; }

    /// <summary>Enables virtual network filtering for this Cosmos DB account.</summary>
    [JsonPropertyName("isVirtualNetworkFilterEnabled")]
    public bool? IsVirtualNetworkFilterEnabled { get; set; }

    /// <summary>A versionless Key Vault Key ID for CMK encryption. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Specifies the Kind of CosmosDB to create - possible values are GlobalDocumentDB, MongoDB and Parse. Defaults to GlobalDocumentDB. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Disable local authentication and ensure only MSI and AAD can be used exclusively for authentication. Defaults to false. Can be set only when using the SQL API.</summary>
    [JsonPropertyName("localAuthenticationDisabled")]
    public bool? LocalAuthenticationDisabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the minimal TLS version for the CosmosDB account. Possible values are: Tls, Tls11, and Tls12. Defaults to Tls12.</summary>
    [JsonPropertyName("minimalTlsVersion")]
    public string? MinimalTlsVersion { get; set; }

    /// <summary>The Server Version of a MongoDB account. Possible values are 4.2, 4.0, 3.6, and 3.2.</summary>
    [JsonPropertyName("mongoServerVersion")]
    public string? MongoServerVersion { get; set; }

    /// <summary>Enable multiple write locations for this Cosmos DB account.</summary>
    [JsonPropertyName("multipleWriteLocationsEnabled")]
    public bool? MultipleWriteLocationsEnabled { get; set; }

    /// <summary>If Azure services can bypass ACLs. Defaults to false.</summary>
    [JsonPropertyName("networkAclBypassForAzureServices")]
    public bool? NetworkAclBypassForAzureServices { get; set; }

    /// <summary>The list of resource Ids for Network Acl Bypass for this Cosmos DB account.</summary>
    [JsonPropertyName("networkAclBypassIds")]
    public IList<string>? NetworkAclBypassIds { get; set; }

    /// <summary>Specifies the Offer Type to use for this CosmosDB Account; currently, this can only be set to Standard.</summary>
    [JsonPropertyName("offerType")]
    public string? OfferType { get; set; }

    /// <summary>Is partition merge on the Cosmos DB account enabled? Defaults to false.</summary>
    [JsonPropertyName("partitionMergeEnabled")]
    public bool? PartitionMergeEnabled { get; set; }

    /// <summary>Whether or not public network access is allowed for this CosmosDB account. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A restore block as defined below.</summary>
    [JsonPropertyName("restore")]
    public IList<V1beta1AccountSpecInitProviderRestore>? Restore { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a virtual_network_rule block as defined below, used to define which subnets are allowed to access this CosmosDB account.</summary>
    [JsonPropertyName("virtualNetworkRule")]
    public IList<V1beta1AccountSpecInitProviderVirtualNetworkRule>? VirtualNetworkRule { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecProviderConfigRefPolicy
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
public partial class V1beta1AccountSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1AccountSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1AccountSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AccountSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AccountSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AccountSpec defines the desired state of Account</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AccountSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AccountSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AccountSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AccountSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AccountSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderAnalyticalStorage
{
    /// <summary>The schema type of the Analytical Storage for this Cosmos DB account. Possible values are FullFidelity and WellDefined.</summary>
    [JsonPropertyName("schemaType")]
    public string? SchemaType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderBackup
{
    /// <summary>The interval in minutes between two backups. Possible values are between 60 and 1440. Defaults to 240.</summary>
    [JsonPropertyName("intervalInMinutes")]
    public double? IntervalInMinutes { get; set; }

    /// <summary>The time in hours that each backup is retained. Possible values are between 8 and 720. Defaults to 8.</summary>
    [JsonPropertyName("retentionInHours")]
    public double? RetentionInHours { get; set; }

    /// <summary>The storage redundancy is used to indicate the type of backup residency. Possible values are Geo, Local and Zone. Defaults to Geo.</summary>
    [JsonPropertyName("storageRedundancy")]
    public string? StorageRedundancy { get; set; }

    /// <summary>The continuous backup tier. Possible values are Continuous7Days and Continuous30Days.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The type of the backup. Possible values are Continuous and Periodic.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderCapabilities
{
    /// <summary>The capability to enable - Possible values are AllowSelfServeUpgradeToMongo36, DisableRateLimitingResponses, EnableAggregationPipeline, EnableCassandra, EnableGremlin, EnableMongo, EnableMongo16MBDocumentSupport, EnableMongoRetryableWrites, EnableMongoRoleBasedAccessControl, EnablePartialUniqueIndex, EnableServerless, EnableTable, EnableTtlOnCustomPath, EnableUniqueCompoundNestedDocs, MongoDBv3.4 and mongoEnableDocLevelTTL.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderCapacity
{
    /// <summary>The total throughput limit imposed on this Cosmos DB account (RU/s). Possible values are at least -1. -1 means no limit.</summary>
    [JsonPropertyName("totalThroughputLimit")]
    public double? TotalThroughputLimit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderConsistencyPolicy
{
    /// <summary>The Consistency Level to use for this CosmosDB Account - can be either BoundedStaleness, Eventual, Session, Strong or ConsistentPrefix.</summary>
    [JsonPropertyName("consistencyLevel")]
    public string? ConsistencyLevel { get; set; }

    /// <summary>When used with the Bounded Staleness consistency level, this value represents the time amount of staleness (in seconds) tolerated. The accepted range for this value is 5 - 86400 (1 day). Defaults to 5. Required when consistency_level is set to BoundedStaleness.</summary>
    [JsonPropertyName("maxIntervalInSeconds")]
    public double? MaxIntervalInSeconds { get; set; }

    /// <summary>When used with the Bounded Staleness consistency level, this value represents the number of stale requests tolerated. The accepted range for this value is 10 – 2147483647. Defaults to 100. Required when consistency_level is set to BoundedStaleness.</summary>
    [JsonPropertyName("maxStalenessPrefix")]
    public double? MaxStalenessPrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderCorsRule
{
    /// <summary>A list of headers that are allowed to be a part of the cross-origin request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>A list of HTTP headers that are allowed to be executed by the origin. Valid options are DELETE, GET, HEAD, MERGE, POST, OPTIONS, PUT or PATCH.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>A list of origin domains that will be allowed by CORS.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>A list of response headers that are exposed to CORS clients.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>The number of seconds the client should cache a preflight response. Possible values are between 1 and 2147483647.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderGeoLocation
{
    /// <summary>The failover priority of the region. A failover priority of 0 indicates a write region. The maximum value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the regions in which the database account exists. Changing this causes the location to be re-provisioned and cannot be changed for the location with failover priority 0.</summary>
    [JsonPropertyName("failoverPriority")]
    public double? FailoverPriority { get; set; }

    /// <summary>The ID of the virtual network subnet.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Azure region to host replicated data.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Should zone redundancy be enabled for this region? Defaults to false.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Cosmos Account.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The Type of Managed Identity assigned to this Cosmos account. Possible values are SystemAssigned, UserAssigned and SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderRestoreDatabase
{
    /// <summary>A list of the collection names for the restore request. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("collectionNames")]
    public IList<string>? CollectionNames { get; set; }

    /// <summary>Specifies the name of the CosmosDB Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderRestoreGremlinDatabase
{
    /// <summary>A list of the Graph names for the restore request. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("graphNames")]
    public IList<string>? GraphNames { get; set; }

    /// <summary>Specifies the name of the CosmosDB Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderRestore
{
    /// <summary>A database block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("database")]
    public IList<V1beta1AccountStatusAtProviderRestoreDatabase>? Database { get; set; }

    /// <summary>One or more gremlin_database blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("gremlinDatabase")]
    public IList<V1beta1AccountStatusAtProviderRestoreGremlinDatabase>? GremlinDatabase { get; set; }

    /// <summary>The creation time of the database or the collection (Datetime Format RFC 3339). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }

    /// <summary>The resource ID of the restorable database account from which the restore has to be initiated. The example is /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{restorableDatabaseAccountName}. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceCosmosdbAccountId")]
    public string? SourceCosmosdbAccountId { get; set; }

    /// <summary>A list of specific tables available for restore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tablesToRestore")]
    public IList<string>? TablesToRestore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProviderVirtualNetworkRule
{
    /// <summary>The ID of the virtual network subnet.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>If set to true, the specified subnet will be added as a virtual network rule even if its CosmosDB service endpoint is not active. Defaults to false.</summary>
    [JsonPropertyName("ignoreMissingVnetServiceEndpoint")]
    public bool? IgnoreMissingVnetServiceEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusAtProvider
{
    /// <summary>Is write operations on metadata resources (databases, containers, throughput) via account keys enabled? Defaults to true.</summary>
    [JsonPropertyName("accessKeyMetadataWritesEnabled")]
    public bool? AccessKeyMetadataWritesEnabled { get; set; }

    /// <summary>An analytical_storage block as defined below.</summary>
    [JsonPropertyName("analyticalStorage")]
    public IList<V1beta1AccountStatusAtProviderAnalyticalStorage>? AnalyticalStorage { get; set; }

    /// <summary>Enable Analytical Storage option for this Cosmos DB account. Defaults to false. Enabling and then disabling analytical storage forces a new resource to be created.</summary>
    [JsonPropertyName("analyticalStorageEnabled")]
    public bool? AnalyticalStorageEnabled { get; set; }

    /// <summary>Enable automatic failover for this Cosmos DB account.</summary>
    [JsonPropertyName("automaticFailoverEnabled")]
    public bool? AutomaticFailoverEnabled { get; set; }

    /// <summary>A backup block as defined below.</summary>
    [JsonPropertyName("backup")]
    public IList<V1beta1AccountStatusAtProviderBackup>? Backup { get; set; }

    /// <summary>Enable burst capacity for this Cosmos DB account. Defaults to false.</summary>
    [JsonPropertyName("burstCapacityEnabled")]
    public bool? BurstCapacityEnabled { get; set; }

    /// <summary>The capabilities which should be enabled for this Cosmos DB account. Value is a capabilities block as defined below.</summary>
    [JsonPropertyName("capabilities")]
    public IList<V1beta1AccountStatusAtProviderCapabilities>? Capabilities { get; set; }

    /// <summary>A capacity block as defined below.</summary>
    [JsonPropertyName("capacity")]
    public IList<V1beta1AccountStatusAtProviderCapacity>? Capacity { get; set; }

    /// <summary>Specifies one consistency_policy block as defined below, used to define the consistency policy for this CosmosDB account.</summary>
    [JsonPropertyName("consistencyPolicy")]
    public IList<V1beta1AccountStatusAtProviderConsistencyPolicy>? ConsistencyPolicy { get; set; }

    /// <summary>A cors_rule block as defined below.</summary>
    [JsonPropertyName("corsRule")]
    public IList<V1beta1AccountStatusAtProviderCorsRule>? CorsRule { get; set; }

    /// <summary>The creation mode for the CosmosDB Account. Possible values are Default and Restore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>The default identity for accessing Key Vault. Possible values are FirstPartyIdentity, SystemAssignedIdentity or UserAssignedIdentity. Defaults to FirstPartyIdentity.</summary>
    [JsonPropertyName("defaultIdentityType")]
    public string? DefaultIdentityType { get; set; }

    /// <summary>Enable automatic failover for this Cosmos DB account.</summary>
    [JsonPropertyName("enableAutomaticFailover")]
    public bool? EnableAutomaticFailover { get; set; }

    /// <summary>Enable the Free Tier pricing option for this Cosmos DB account. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enableFreeTier")]
    public bool? EnableFreeTier { get; set; }

    /// <summary>Enable multiple write locations for this Cosmos DB account.</summary>
    [JsonPropertyName("enableMultipleWriteLocations")]
    public bool? EnableMultipleWriteLocations { get; set; }

    /// <summary>The endpoint used to connect to the CosmosDB account.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Enable the Free Tier pricing option for this Cosmos DB account. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("freeTierEnabled")]
    public bool? FreeTierEnabled { get; set; }

    /// <summary>Specifies a geo_location resource, used to define where data should be replicated with the failover_priority 0 specifying the primary location. Value is a geo_location block as defined below.</summary>
    [JsonPropertyName("geoLocation")]
    public IList<V1beta1AccountStatusAtProviderGeoLocation>? GeoLocation { get; set; }

    /// <summary>The CosmosDB Account ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1AccountStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>CosmosDB Firewall Support: This value specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma separated and must not contain any spaces.</summary>
    [JsonPropertyName("ipRangeFilter")]
    public string? IpRangeFilter { get; set; }

    /// <summary>Enables virtual network filtering for this Cosmos DB account.</summary>
    [JsonPropertyName("isVirtualNetworkFilterEnabled")]
    public bool? IsVirtualNetworkFilterEnabled { get; set; }

    /// <summary>A versionless Key Vault Key ID for CMK encryption. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Specifies the Kind of CosmosDB to create - possible values are GlobalDocumentDB, MongoDB and Parse. Defaults to GlobalDocumentDB. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Disable local authentication and ensure only MSI and AAD can be used exclusively for authentication. Defaults to false. Can be set only when using the SQL API.</summary>
    [JsonPropertyName("localAuthenticationDisabled")]
    public bool? LocalAuthenticationDisabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the minimal TLS version for the CosmosDB account. Possible values are: Tls, Tls11, and Tls12. Defaults to Tls12.</summary>
    [JsonPropertyName("minimalTlsVersion")]
    public string? MinimalTlsVersion { get; set; }

    /// <summary>The Server Version of a MongoDB account. Possible values are 4.2, 4.0, 3.6, and 3.2.</summary>
    [JsonPropertyName("mongoServerVersion")]
    public string? MongoServerVersion { get; set; }

    /// <summary>Enable multiple write locations for this Cosmos DB account.</summary>
    [JsonPropertyName("multipleWriteLocationsEnabled")]
    public bool? MultipleWriteLocationsEnabled { get; set; }

    /// <summary>If Azure services can bypass ACLs. Defaults to false.</summary>
    [JsonPropertyName("networkAclBypassForAzureServices")]
    public bool? NetworkAclBypassForAzureServices { get; set; }

    /// <summary>The list of resource Ids for Network Acl Bypass for this Cosmos DB account.</summary>
    [JsonPropertyName("networkAclBypassIds")]
    public IList<string>? NetworkAclBypassIds { get; set; }

    /// <summary>Specifies the Offer Type to use for this CosmosDB Account; currently, this can only be set to Standard.</summary>
    [JsonPropertyName("offerType")]
    public string? OfferType { get; set; }

    /// <summary>Is partition merge on the Cosmos DB account enabled? Defaults to false.</summary>
    [JsonPropertyName("partitionMergeEnabled")]
    public bool? PartitionMergeEnabled { get; set; }

    /// <summary>Whether or not public network access is allowed for this CosmosDB account. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A list of read endpoints available for this CosmosDB account.</summary>
    [JsonPropertyName("readEndpoints")]
    public IList<string>? ReadEndpoints { get; set; }

    /// <summary>The name of the resource group in which the CosmosDB Account is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A restore block as defined below.</summary>
    [JsonPropertyName("restore")]
    public IList<V1beta1AccountStatusAtProviderRestore>? Restore { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies a virtual_network_rule block as defined below, used to define which subnets are allowed to access this CosmosDB account.</summary>
    [JsonPropertyName("virtualNetworkRule")]
    public IList<V1beta1AccountStatusAtProviderVirtualNetworkRule>? VirtualNetworkRule { get; set; }

    /// <summary>A list of write endpoints available for this CosmosDB account.</summary>
    [JsonPropertyName("writeEndpoints")]
    public IList<string>? WriteEndpoints { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatusConditions
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

/// <summary>AccountStatus defines the observed state of Account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AccountStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccountStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Account is the Schema for the Accounts API. Manages a CosmosDB (formally DocumentDB) Account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Account : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccountSpec>, IStatus<V1beta1AccountStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Account";
    public const string KubeGroup = "cosmosdb.azure.upbound.io";
    public const string KubePluralName = "accounts";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccountSpec defines the desired state of Account</summary>
    [JsonPropertyName("spec")]
    public V1beta1AccountSpec Spec { get; set; }

    /// <summary>AccountStatus defines the observed state of Account.</summary>
    [JsonPropertyName("status")]
    public V1beta1AccountStatus? Status { get; set; }
}