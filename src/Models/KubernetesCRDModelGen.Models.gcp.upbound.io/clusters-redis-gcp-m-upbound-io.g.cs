using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.redis.gcp.m.upbound.io;
/// <summary>Cluster is the Schema for the Clusters API. A Google Cloud Redis Cluster instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Cluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "redis.gcp.m.upbound.io";
    public const string KubePluralName = "clusters";
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
    public IList<V1beta1Cluster> Items { get; set; }
}

/// <summary>Required. Start time of the window in UTC time. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAutomatedBackupConfigFixedFrequencyScheduleStartTime
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }
}

/// <summary>Trigger automated backups at a fixed frequency. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAutomatedBackupConfigFixedFrequencySchedule
{
    /// <summary>Required. Start time of the window in UTC time. Structure is documented below.</summary>
    [JsonPropertyName("startTime")]
    public V1beta1ClusterSpecForProviderAutomatedBackupConfigFixedFrequencyScheduleStartTime? StartTime { get; set; }
}

/// <summary>The automated backup config for a instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAutomatedBackupConfig
{
    /// <summary>Trigger automated backups at a fixed frequency. Structure is documented below.</summary>
    [JsonPropertyName("fixedFrequencySchedule")]
    public V1beta1ClusterSpecForProviderAutomatedBackupConfigFixedFrequencySchedule? FixedFrequencySchedule { get; set; }

    /// <summary>How long to keep automated backups before the backups are deleted. The value should be between 1 day and 365 days. If not specified, the default value is 35 days. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("retention")]
    public string? Retention { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderCrossClusterReplicationConfigPrimaryClusterClusterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in redis to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderCrossClusterReplicationConfigPrimaryClusterClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderCrossClusterReplicationConfigPrimaryClusterClusterRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderCrossClusterReplicationConfigPrimaryClusterClusterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in redis to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderCrossClusterReplicationConfigPrimaryClusterClusterSelector
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
    public V1beta1ClusterSpecForProviderCrossClusterReplicationConfigPrimaryClusterClusterSelectorPolicy? Policy { get; set; }
}

/// <summary>field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderCrossClusterReplicationConfigPrimaryCluster
{
    /// <summary>The full resource path of the secondary cluster in the format: projects/{project}/locations/{region}/clusters/{cluster-id}</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Reference to a Cluster in redis to populate cluster.</summary>
    [JsonPropertyName("clusterRef")]
    public V1beta1ClusterSpecForProviderCrossClusterReplicationConfigPrimaryClusterClusterRef? ClusterRef { get; set; }

    /// <summary>Selector for a Cluster in redis to populate cluster.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta1ClusterSpecForProviderCrossClusterReplicationConfigPrimaryClusterClusterSelector? ClusterSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderCrossClusterReplicationConfigSecondaryClusters
{
    /// <summary>The full resource path of the secondary cluster in the format: projects/{project}/locations/{region}/clusters/{cluster-id}</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }
}

/// <summary>field to the configuration file to match the latest value in the state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderCrossClusterReplicationConfig
{
    /// <summary>from SECONDARY to PRIMARY.</summary>
    [JsonPropertyName("clusterRole")]
    public string? ClusterRole { get; set; }

    /// <summary>field.</summary>
    [JsonPropertyName("primaryCluster")]
    public V1beta1ClusterSpecForProviderCrossClusterReplicationConfigPrimaryCluster? PrimaryCluster { get; set; }

    /// <summary>list with the new secondaries. The new secondaries are the current primary and other secondary clusters(if any).</summary>
    [JsonPropertyName("secondaryClusters")]
    public IList<V1beta1ClusterSpecForProviderCrossClusterReplicationConfigSecondaryClusters>? SecondaryClusters { get; set; }
}

/// <summary>Backups stored in Cloud Storage buckets. The Cloud Storage buckets need to be the same region as the clusters. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderGcsSource
{
    /// <summary>URIs of the GCS objects to import. Example: gs://bucket1/object1, gs://bucket2/folder2/object2</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary>Required. Start time of the window in UTC time. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMaintenancePolicyWeeklyMaintenanceWindow
{
    /// <summary>Required. The day of week that maintenance updates occur.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>Required. Start time of the window in UTC time. Structure is documented below.</summary>
    [JsonPropertyName("startTime")]
    public V1beta1ClusterSpecForProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime? StartTime { get; set; }
}

/// <summary>Maintenance policy for a cluster Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMaintenancePolicy
{
    /// <summary>Optional. Maintenance window that is applied to resources covered by this policy. Minimum 1. For the current version, the maximum number of weekly_window is expected to be one. Structure is documented below.</summary>
    [JsonPropertyName("weeklyMaintenanceWindow")]
    public IList<V1beta1ClusterSpecForProviderMaintenancePolicyWeeklyMaintenanceWindow>? WeeklyMaintenanceWindow { get; set; }
}

/// <summary>Backups that generated and managed by memorystore. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderManagedBackupSource
{
    /// <summary>Example: projects/{project}/locations/{location}/backupCollections/{collection}/backups/{backup}.</summary>
    [JsonPropertyName("backup")]
    public string? Backup { get; set; }
}

/// <summary>AOF configuration. This field will be ignored if mode is not AOF. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderPersistenceConfigAofConfig
{
    /// <summary>Optional. Available fsync modes.</summary>
    [JsonPropertyName("appendFsync")]
    public string? AppendFsync { get; set; }
}

/// <summary>RDB configuration. This field will be ignored if mode is not RDB. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderPersistenceConfigRdbConfig
{
    /// <summary>Optional. Available snapshot periods for scheduling.</summary>
    [JsonPropertyName("rdbSnapshotPeriod")]
    public string? RdbSnapshotPeriod { get; set; }

    /// <summary>The time that the first snapshot was/will be attempted, and to which future snapshots will be aligned. If not provided, the current time will be used.</summary>
    [JsonPropertyName("rdbSnapshotStartTime")]
    public string? RdbSnapshotStartTime { get; set; }
}

/// <summary>Persistence config (RDB, AOF) for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderPersistenceConfig
{
    /// <summary>AOF configuration. This field will be ignored if mode is not AOF. Structure is documented below.</summary>
    [JsonPropertyName("aofConfig")]
    public V1beta1ClusterSpecForProviderPersistenceConfigAofConfig? AofConfig { get; set; }

    /// <summary>Optional. Controls whether Persistence features are enabled. If not provided, the existing value will be used.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>RDB configuration. This field will be ignored if mode is not RDB. Structure is documented below.</summary>
    [JsonPropertyName("rdbConfig")]
    public V1beta1ClusterSpecForProviderPersistenceConfigRdbConfig? RdbConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderPscConfigsNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderPscConfigsNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderPscConfigsNetworkRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderPscConfigsNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderPscConfigsNetworkSelector
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
    public V1beta1ClusterSpecForProviderPscConfigsNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderPscConfigs
{
    /// <summary>Required. The consumer network where the network address of the discovery endpoint will be reserved, in the form of projects/{network_project_id_or_number}/global/networks/{network_id}.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ClusterSpecForProviderPscConfigsNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1ClusterSpecForProviderPscConfigsNetworkSelector? NetworkSelector { get; set; }
}

/// <summary>Immutable. Zone distribution config for Memorystore Redis cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderZoneDistributionConfig
{
    /// <summary>Immutable. The mode for zone distribution for Memorystore Redis cluster. If not provided, MULTI_ZONE will be used as default Possible values are: MULTI_ZONE, SINGLE_ZONE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Immutable. The zone for single zone Memorystore Redis cluster.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProvider
{
    /// <summary>Optional. The authorization mode of the Redis cluster. If not provided, auth feature is disabled for the cluster. Default value is AUTH_MODE_DISABLED. Possible values are: AUTH_MODE_UNSPECIFIED, AUTH_MODE_IAM_AUTH, AUTH_MODE_DISABLED.</summary>
    [JsonPropertyName("authorizationMode")]
    public string? AuthorizationMode { get; set; }

    /// <summary>The automated backup config for a instance. Structure is documented below.</summary>
    [JsonPropertyName("automatedBackupConfig")]
    public V1beta1ClusterSpecForProviderAutomatedBackupConfig? AutomatedBackupConfig { get; set; }

    /// <summary>field to the configuration file to match the latest value in the state.</summary>
    [JsonPropertyName("crossClusterReplicationConfig")]
    public V1beta1ClusterSpecForProviderCrossClusterReplicationConfig? CrossClusterReplicationConfig { get; set; }

    /// <summary>Optional. Indicates if the cluster is deletion protected or not. If the value if set to true, any delete cluster operation will fail. Default value is true.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>Backups stored in Cloud Storage buckets. The Cloud Storage buckets need to be the same region as the clusters. Structure is documented below.</summary>
    [JsonPropertyName("gcsSource")]
    public V1beta1ClusterSpecForProviderGcsSource? GcsSource { get; set; }

    /// <summary>The KMS key used to encrypt the at-rest data of the cluster.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Maintenance policy for a cluster Structure is documented below.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta1ClusterSpecForProviderMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>Backups that generated and managed by memorystore. Structure is documented below.</summary>
    [JsonPropertyName("managedBackupSource")]
    public V1beta1ClusterSpecForProviderManagedBackupSource? ManagedBackupSource { get; set; }

    /// <summary>The nodeType for the Redis cluster. If not provided, REDIS_HIGHMEM_MEDIUM will be used as default Possible values are: REDIS_SHARED_CORE_NANO, REDIS_HIGHMEM_MEDIUM, REDIS_HIGHMEM_XLARGE, REDIS_STANDARD_SMALL.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>Persistence config (RDB, AOF) for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("persistenceConfig")]
    public V1beta1ClusterSpecForProviderPersistenceConfig? PersistenceConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Required. Each PscConfig configures the consumer network where two network addresses will be designated to the cluster for client access. Currently, only one PscConfig is supported. Structure is documented below.</summary>
    [JsonPropertyName("pscConfigs")]
    public IList<V1beta1ClusterSpecForProviderPscConfigs>? PscConfigs { get; set; }

    /// <summary>Configure Redis Cluster behavior using a subset of native Redis configuration parameters. Please check Memorystore documentation for the list of supported parameters: https://cloud.google.com/memorystore/docs/cluster/supported-instance-configurations</summary>
    [JsonPropertyName("redisConfigs")]
    public IDictionary<string, string>? RedisConfigs { get; set; }

    /// <summary>The name of the region of the Redis cluster.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Optional. The number of replica nodes per shard.</summary>
    [JsonPropertyName("replicaCount")]
    public double? ReplicaCount { get; set; }

    /// <summary>Required. Number of shards for the Redis cluster.</summary>
    [JsonPropertyName("shardCount")]
    public double? ShardCount { get; set; }

    /// <summary>Optional. The in-transit encryption for the Redis cluster. If not provided, encryption is disabled for the cluster. Default value is TRANSIT_ENCRYPTION_MODE_DISABLED. Possible values are: TRANSIT_ENCRYPTION_MODE_UNSPECIFIED, TRANSIT_ENCRYPTION_MODE_DISABLED, TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION.</summary>
    [JsonPropertyName("transitEncryptionMode")]
    public string? TransitEncryptionMode { get; set; }

    /// <summary>Immutable. Zone distribution config for Memorystore Redis cluster. Structure is documented below.</summary>
    [JsonPropertyName("zoneDistributionConfig")]
    public V1beta1ClusterSpecForProviderZoneDistributionConfig? ZoneDistributionConfig { get; set; }
}

/// <summary>Required. Start time of the window in UTC time. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAutomatedBackupConfigFixedFrequencyScheduleStartTime
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }
}

/// <summary>Trigger automated backups at a fixed frequency. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAutomatedBackupConfigFixedFrequencySchedule
{
    /// <summary>Required. Start time of the window in UTC time. Structure is documented below.</summary>
    [JsonPropertyName("startTime")]
    public V1beta1ClusterSpecInitProviderAutomatedBackupConfigFixedFrequencyScheduleStartTime? StartTime { get; set; }
}

/// <summary>The automated backup config for a instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAutomatedBackupConfig
{
    /// <summary>Trigger automated backups at a fixed frequency. Structure is documented below.</summary>
    [JsonPropertyName("fixedFrequencySchedule")]
    public V1beta1ClusterSpecInitProviderAutomatedBackupConfigFixedFrequencySchedule? FixedFrequencySchedule { get; set; }

    /// <summary>How long to keep automated backups before the backups are deleted. The value should be between 1 day and 365 days. If not specified, the default value is 35 days. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("retention")]
    public string? Retention { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderCrossClusterReplicationConfigPrimaryClusterClusterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in redis to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderCrossClusterReplicationConfigPrimaryClusterClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderCrossClusterReplicationConfigPrimaryClusterClusterRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderCrossClusterReplicationConfigPrimaryClusterClusterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in redis to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderCrossClusterReplicationConfigPrimaryClusterClusterSelector
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
    public V1beta1ClusterSpecInitProviderCrossClusterReplicationConfigPrimaryClusterClusterSelectorPolicy? Policy { get; set; }
}

/// <summary>field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderCrossClusterReplicationConfigPrimaryCluster
{
    /// <summary>The full resource path of the secondary cluster in the format: projects/{project}/locations/{region}/clusters/{cluster-id}</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Reference to a Cluster in redis to populate cluster.</summary>
    [JsonPropertyName("clusterRef")]
    public V1beta1ClusterSpecInitProviderCrossClusterReplicationConfigPrimaryClusterClusterRef? ClusterRef { get; set; }

    /// <summary>Selector for a Cluster in redis to populate cluster.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta1ClusterSpecInitProviderCrossClusterReplicationConfigPrimaryClusterClusterSelector? ClusterSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderCrossClusterReplicationConfigSecondaryClusters
{
    /// <summary>The full resource path of the secondary cluster in the format: projects/{project}/locations/{region}/clusters/{cluster-id}</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }
}

/// <summary>field to the configuration file to match the latest value in the state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderCrossClusterReplicationConfig
{
    /// <summary>from SECONDARY to PRIMARY.</summary>
    [JsonPropertyName("clusterRole")]
    public string? ClusterRole { get; set; }

    /// <summary>field.</summary>
    [JsonPropertyName("primaryCluster")]
    public V1beta1ClusterSpecInitProviderCrossClusterReplicationConfigPrimaryCluster? PrimaryCluster { get; set; }

    /// <summary>list with the new secondaries. The new secondaries are the current primary and other secondary clusters(if any).</summary>
    [JsonPropertyName("secondaryClusters")]
    public IList<V1beta1ClusterSpecInitProviderCrossClusterReplicationConfigSecondaryClusters>? SecondaryClusters { get; set; }
}

/// <summary>Backups stored in Cloud Storage buckets. The Cloud Storage buckets need to be the same region as the clusters. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderGcsSource
{
    /// <summary>URIs of the GCS objects to import. Example: gs://bucket1/object1, gs://bucket2/folder2/object2</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary>Required. Start time of the window in UTC time. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindow
{
    /// <summary>Required. The day of week that maintenance updates occur.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>Required. Start time of the window in UTC time. Structure is documented below.</summary>
    [JsonPropertyName("startTime")]
    public V1beta1ClusterSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime? StartTime { get; set; }
}

/// <summary>Maintenance policy for a cluster Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMaintenancePolicy
{
    /// <summary>Optional. Maintenance window that is applied to resources covered by this policy. Minimum 1. For the current version, the maximum number of weekly_window is expected to be one. Structure is documented below.</summary>
    [JsonPropertyName("weeklyMaintenanceWindow")]
    public IList<V1beta1ClusterSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindow>? WeeklyMaintenanceWindow { get; set; }
}

/// <summary>Backups that generated and managed by memorystore. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderManagedBackupSource
{
    /// <summary>Example: projects/{project}/locations/{location}/backupCollections/{collection}/backups/{backup}.</summary>
    [JsonPropertyName("backup")]
    public string? Backup { get; set; }
}

/// <summary>AOF configuration. This field will be ignored if mode is not AOF. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderPersistenceConfigAofConfig
{
    /// <summary>Optional. Available fsync modes.</summary>
    [JsonPropertyName("appendFsync")]
    public string? AppendFsync { get; set; }
}

/// <summary>RDB configuration. This field will be ignored if mode is not RDB. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderPersistenceConfigRdbConfig
{
    /// <summary>Optional. Available snapshot periods for scheduling.</summary>
    [JsonPropertyName("rdbSnapshotPeriod")]
    public string? RdbSnapshotPeriod { get; set; }

    /// <summary>The time that the first snapshot was/will be attempted, and to which future snapshots will be aligned. If not provided, the current time will be used.</summary>
    [JsonPropertyName("rdbSnapshotStartTime")]
    public string? RdbSnapshotStartTime { get; set; }
}

/// <summary>Persistence config (RDB, AOF) for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderPersistenceConfig
{
    /// <summary>AOF configuration. This field will be ignored if mode is not AOF. Structure is documented below.</summary>
    [JsonPropertyName("aofConfig")]
    public V1beta1ClusterSpecInitProviderPersistenceConfigAofConfig? AofConfig { get; set; }

    /// <summary>Optional. Controls whether Persistence features are enabled. If not provided, the existing value will be used.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>RDB configuration. This field will be ignored if mode is not RDB. Structure is documented below.</summary>
    [JsonPropertyName("rdbConfig")]
    public V1beta1ClusterSpecInitProviderPersistenceConfigRdbConfig? RdbConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderPscConfigsNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderPscConfigsNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderPscConfigsNetworkRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderPscConfigsNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderPscConfigsNetworkSelector
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
    public V1beta1ClusterSpecInitProviderPscConfigsNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderPscConfigs
{
    /// <summary>Required. The consumer network where the network address of the discovery endpoint will be reserved, in the form of projects/{network_project_id_or_number}/global/networks/{network_id}.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ClusterSpecInitProviderPscConfigsNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1ClusterSpecInitProviderPscConfigsNetworkSelector? NetworkSelector { get; set; }
}

/// <summary>Immutable. Zone distribution config for Memorystore Redis cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderZoneDistributionConfig
{
    /// <summary>Immutable. The mode for zone distribution for Memorystore Redis cluster. If not provided, MULTI_ZONE will be used as default Possible values are: MULTI_ZONE, SINGLE_ZONE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Immutable. The zone for single zone Memorystore Redis cluster.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProvider
{
    /// <summary>Optional. The authorization mode of the Redis cluster. If not provided, auth feature is disabled for the cluster. Default value is AUTH_MODE_DISABLED. Possible values are: AUTH_MODE_UNSPECIFIED, AUTH_MODE_IAM_AUTH, AUTH_MODE_DISABLED.</summary>
    [JsonPropertyName("authorizationMode")]
    public string? AuthorizationMode { get; set; }

    /// <summary>The automated backup config for a instance. Structure is documented below.</summary>
    [JsonPropertyName("automatedBackupConfig")]
    public V1beta1ClusterSpecInitProviderAutomatedBackupConfig? AutomatedBackupConfig { get; set; }

    /// <summary>field to the configuration file to match the latest value in the state.</summary>
    [JsonPropertyName("crossClusterReplicationConfig")]
    public V1beta1ClusterSpecInitProviderCrossClusterReplicationConfig? CrossClusterReplicationConfig { get; set; }

    /// <summary>Optional. Indicates if the cluster is deletion protected or not. If the value if set to true, any delete cluster operation will fail. Default value is true.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>Backups stored in Cloud Storage buckets. The Cloud Storage buckets need to be the same region as the clusters. Structure is documented below.</summary>
    [JsonPropertyName("gcsSource")]
    public V1beta1ClusterSpecInitProviderGcsSource? GcsSource { get; set; }

    /// <summary>The KMS key used to encrypt the at-rest data of the cluster.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Maintenance policy for a cluster Structure is documented below.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta1ClusterSpecInitProviderMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>Backups that generated and managed by memorystore. Structure is documented below.</summary>
    [JsonPropertyName("managedBackupSource")]
    public V1beta1ClusterSpecInitProviderManagedBackupSource? ManagedBackupSource { get; set; }

    /// <summary>The nodeType for the Redis cluster. If not provided, REDIS_HIGHMEM_MEDIUM will be used as default Possible values are: REDIS_SHARED_CORE_NANO, REDIS_HIGHMEM_MEDIUM, REDIS_HIGHMEM_XLARGE, REDIS_STANDARD_SMALL.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>Persistence config (RDB, AOF) for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("persistenceConfig")]
    public V1beta1ClusterSpecInitProviderPersistenceConfig? PersistenceConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Required. Each PscConfig configures the consumer network where two network addresses will be designated to the cluster for client access. Currently, only one PscConfig is supported. Structure is documented below.</summary>
    [JsonPropertyName("pscConfigs")]
    public IList<V1beta1ClusterSpecInitProviderPscConfigs>? PscConfigs { get; set; }

    /// <summary>Configure Redis Cluster behavior using a subset of native Redis configuration parameters. Please check Memorystore documentation for the list of supported parameters: https://cloud.google.com/memorystore/docs/cluster/supported-instance-configurations</summary>
    [JsonPropertyName("redisConfigs")]
    public IDictionary<string, string>? RedisConfigs { get; set; }

    /// <summary>Optional. The number of replica nodes per shard.</summary>
    [JsonPropertyName("replicaCount")]
    public double? ReplicaCount { get; set; }

    /// <summary>Required. Number of shards for the Redis cluster.</summary>
    [JsonPropertyName("shardCount")]
    public double? ShardCount { get; set; }

    /// <summary>Optional. The in-transit encryption for the Redis cluster. If not provided, encryption is disabled for the cluster. Default value is TRANSIT_ENCRYPTION_MODE_DISABLED. Possible values are: TRANSIT_ENCRYPTION_MODE_UNSPECIFIED, TRANSIT_ENCRYPTION_MODE_DISABLED, TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION.</summary>
    [JsonPropertyName("transitEncryptionMode")]
    public string? TransitEncryptionMode { get; set; }

    /// <summary>Immutable. Zone distribution config for Memorystore Redis cluster. Structure is documented below.</summary>
    [JsonPropertyName("zoneDistributionConfig")]
    public V1beta1ClusterSpecInitProviderZoneDistributionConfig? ZoneDistributionConfig { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecProviderConfigRef
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
public partial class V1beta1ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Required. Start time of the window in UTC time. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAutomatedBackupConfigFixedFrequencyScheduleStartTime
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }
}

/// <summary>Trigger automated backups at a fixed frequency. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAutomatedBackupConfigFixedFrequencySchedule
{
    /// <summary>Required. Start time of the window in UTC time. Structure is documented below.</summary>
    [JsonPropertyName("startTime")]
    public V1beta1ClusterStatusAtProviderAutomatedBackupConfigFixedFrequencyScheduleStartTime? StartTime { get; set; }
}

/// <summary>The automated backup config for a instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAutomatedBackupConfig
{
    /// <summary>Trigger automated backups at a fixed frequency. Structure is documented below.</summary>
    [JsonPropertyName("fixedFrequencySchedule")]
    public V1beta1ClusterStatusAtProviderAutomatedBackupConfigFixedFrequencySchedule? FixedFrequencySchedule { get; set; }

    /// <summary>How long to keep automated backups before the backups are deleted. The value should be between 1 day and 365 days. If not specified, the default value is 35 days. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("retention")]
    public string? Retention { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderCrossClusterReplicationConfigMembershipPrimaryCluster
{
    /// <summary>The full resource path of the secondary cluster in the format: projects/{project}/locations/{region}/clusters/{cluster-id}</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>System assigned, unique identifier for the cluster.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderCrossClusterReplicationConfigMembershipSecondaryClusters
{
    /// <summary>The full resource path of the secondary cluster in the format: projects/{project}/locations/{region}/clusters/{cluster-id}</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>System assigned, unique identifier for the cluster.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderCrossClusterReplicationConfigMembership
{
    /// <summary>(Output) Details of the primary cluster that is used as the replication source for all the secondary clusters. Structure is documented below.</summary>
    [JsonPropertyName("primaryCluster")]
    public IList<V1beta1ClusterStatusAtProviderCrossClusterReplicationConfigMembershipPrimaryCluster>? PrimaryCluster { get; set; }

    /// <summary>(Output) List of secondary clusters that are replicating from the primary cluster. Structure is documented below.</summary>
    [JsonPropertyName("secondaryClusters")]
    public IList<V1beta1ClusterStatusAtProviderCrossClusterReplicationConfigMembershipSecondaryClusters>? SecondaryClusters { get; set; }
}

/// <summary>field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderCrossClusterReplicationConfigPrimaryCluster
{
    /// <summary>The full resource path of the secondary cluster in the format: projects/{project}/locations/{region}/clusters/{cluster-id}</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>System assigned, unique identifier for the cluster.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderCrossClusterReplicationConfigSecondaryClusters
{
    /// <summary>The full resource path of the secondary cluster in the format: projects/{project}/locations/{region}/clusters/{cluster-id}</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>System assigned, unique identifier for the cluster.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>field to the configuration file to match the latest value in the state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderCrossClusterReplicationConfig
{
    /// <summary>from SECONDARY to PRIMARY.</summary>
    [JsonPropertyName("clusterRole")]
    public string? ClusterRole { get; set; }

    /// <summary>(Output) An output only view of all the member clusters participating in cross cluster replication. This field is populated for all the member clusters irrespective of their cluster role. Structure is documented below.</summary>
    [JsonPropertyName("membership")]
    public IList<V1beta1ClusterStatusAtProviderCrossClusterReplicationConfigMembership>? Membership { get; set; }

    /// <summary>field.</summary>
    [JsonPropertyName("primaryCluster")]
    public V1beta1ClusterStatusAtProviderCrossClusterReplicationConfigPrimaryCluster? PrimaryCluster { get; set; }

    /// <summary>list with the new secondaries. The new secondaries are the current primary and other secondary clusters(if any).</summary>
    [JsonPropertyName("secondaryClusters")]
    public IList<V1beta1ClusterStatusAtProviderCrossClusterReplicationConfigSecondaryClusters>? SecondaryClusters { get; set; }

    /// <summary>(Output) The last time cross cluster replication config was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>Output only. Customer configuration for where the endpoint is created and accessed from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderDiscoveryEndpointsPscConfig
{
    /// <summary>The consumer network where the IP address resides, in the form of projects/{projectId}/global/networks/{network_id}.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderDiscoveryEndpoints
{
    /// <summary>Output only. Network address of the exposed Redis endpoint used by clients to connect to the service.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Output only. The port number of the exposed Redis endpoint.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Output only. Customer configuration for where the endpoint is created and accessed from. Structure is documented below.</summary>
    [JsonPropertyName("pscConfig")]
    public V1beta1ClusterStatusAtProviderDiscoveryEndpointsPscConfig? PscConfig { get; set; }
}

/// <summary>Backups stored in Cloud Storage buckets. The Cloud Storage buckets need to be the same region as the clusters. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderGcsSource
{
    /// <summary>URIs of the GCS objects to import. Example: gs://bucket1/object1, gs://bucket2/folder2/object2</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary>Required. Start time of the window in UTC time. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindow
{
    /// <summary>Required. The day of week that maintenance updates occur.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>(Output) Output only. Duration of the maintenance window. The current window is fixed at 1 hour. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Required. Start time of the window in UTC time. Structure is documented below.</summary>
    [JsonPropertyName("startTime")]
    public V1beta1ClusterStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime? StartTime { get; set; }
}

/// <summary>Maintenance policy for a cluster Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMaintenancePolicy
{
    /// <summary>(Output) Output only. The time when the policy was created. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>(Output) Output only. The time when the policy was last updated. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Optional. Maintenance window that is applied to resources covered by this policy. Minimum 1. For the current version, the maximum number of weekly_window is expected to be one. Structure is documented below.</summary>
    [JsonPropertyName("weeklyMaintenanceWindow")]
    public IList<V1beta1ClusterStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindow>? WeeklyMaintenanceWindow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMaintenanceSchedule
{
    /// <summary>(Output) Output only. The end time of any upcoming scheduled maintenance for this cluster. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>(Output) Output only. The deadline that the maintenance schedule start time can not go beyond, including reschedule. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("scheduleDeadlineTime")]
    public string? ScheduleDeadlineTime { get; set; }

    /// <summary>(Output) Output only. The start time of any upcoming scheduled maintenance for this cluster. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>Backups that generated and managed by memorystore. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderManagedBackupSource
{
    /// <summary>Example: projects/{project}/locations/{location}/backupCollections/{collection}/backups/{backup}.</summary>
    [JsonPropertyName("backup")]
    public string? Backup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderManagedServerCaCaCerts
{
    /// <summary>(Output) The certificates that form the CA chain, from leaf to root order</summary>
    [JsonPropertyName("certificates")]
    public IList<string>? Certificates { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderManagedServerCa
{
    /// <summary>(Output) The PEM encoded CA certificate chains for redis managed server authentication Structure is documented below.</summary>
    [JsonPropertyName("caCerts")]
    public IList<V1beta1ClusterStatusAtProviderManagedServerCaCaCerts>? CaCerts { get; set; }
}

/// <summary>AOF configuration. This field will be ignored if mode is not AOF. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderPersistenceConfigAofConfig
{
    /// <summary>Optional. Available fsync modes.</summary>
    [JsonPropertyName("appendFsync")]
    public string? AppendFsync { get; set; }
}

/// <summary>RDB configuration. This field will be ignored if mode is not RDB. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderPersistenceConfigRdbConfig
{
    /// <summary>Optional. Available snapshot periods for scheduling.</summary>
    [JsonPropertyName("rdbSnapshotPeriod")]
    public string? RdbSnapshotPeriod { get; set; }

    /// <summary>The time that the first snapshot was/will be attempted, and to which future snapshots will be aligned. If not provided, the current time will be used.</summary>
    [JsonPropertyName("rdbSnapshotStartTime")]
    public string? RdbSnapshotStartTime { get; set; }
}

/// <summary>Persistence config (RDB, AOF) for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderPersistenceConfig
{
    /// <summary>AOF configuration. This field will be ignored if mode is not AOF. Structure is documented below.</summary>
    [JsonPropertyName("aofConfig")]
    public V1beta1ClusterStatusAtProviderPersistenceConfigAofConfig? AofConfig { get; set; }

    /// <summary>Optional. Controls whether Persistence features are enabled. If not provided, the existing value will be used.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>RDB configuration. This field will be ignored if mode is not RDB. Structure is documented below.</summary>
    [JsonPropertyName("rdbConfig")]
    public V1beta1ClusterStatusAtProviderPersistenceConfigRdbConfig? RdbConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderPscConfigs
{
    /// <summary>Required. The consumer network where the network address of the discovery endpoint will be reserved, in the form of projects/{network_project_id_or_number}/global/networks/{network_id}.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderPscConnections
{
    /// <summary>Output only. The IP allocated on the consumer network for the PSC forwarding rule.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Output only. The URI of the consumer side forwarding rule. Example: projects/{projectNumOrId}/regions/us-east1/forwardingRules/{resourceId}.</summary>
    [JsonPropertyName("forwardingRule")]
    public string? ForwardingRule { get; set; }

    /// <summary>The consumer network where the IP address resides, in the form of projects/{projectId}/global/networks/{network_id}.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Output only. The consumer projectId where the forwarding rule is created from.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Output only. The PSC connection id of the forwarding rule connected to the service attachment.</summary>
    [JsonPropertyName("pscConnectionId")]
    public string? PscConnectionId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderPscServiceAttachments
{
    /// <summary>(Output) Type of a PSC connection targeting this service attachment.</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>(Output) Service attachment URI which your self-created PscConnection should use as</summary>
    [JsonPropertyName("serviceAttachment")]
    public string? ServiceAttachment { get; set; }
}

/// <summary>A nested object resource. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderStateInfoUpdateInfo
{
    /// <summary>Target number of replica nodes per shard.</summary>
    [JsonPropertyName("targetReplicaCount")]
    public double? TargetReplicaCount { get; set; }

    /// <summary>Target number of shards for redis cluster.</summary>
    [JsonPropertyName("targetShardCount")]
    public double? TargetShardCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderStateInfo
{
    /// <summary>A nested object resource. Structure is documented below.</summary>
    [JsonPropertyName("updateInfo")]
    public V1beta1ClusterStatusAtProviderStateInfoUpdateInfo? UpdateInfo { get; set; }
}

/// <summary>Immutable. Zone distribution config for Memorystore Redis cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderZoneDistributionConfig
{
    /// <summary>Immutable. The mode for zone distribution for Memorystore Redis cluster. If not provided, MULTI_ZONE will be used as default Possible values are: MULTI_ZONE, SINGLE_ZONE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Immutable. The zone for single zone Memorystore Redis cluster.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProvider
{
    /// <summary>Optional. The authorization mode of the Redis cluster. If not provided, auth feature is disabled for the cluster. Default value is AUTH_MODE_DISABLED. Possible values are: AUTH_MODE_UNSPECIFIED, AUTH_MODE_IAM_AUTH, AUTH_MODE_DISABLED.</summary>
    [JsonPropertyName("authorizationMode")]
    public string? AuthorizationMode { get; set; }

    /// <summary>The automated backup config for a instance. Structure is documented below.</summary>
    [JsonPropertyName("automatedBackupConfig")]
    public V1beta1ClusterStatusAtProviderAutomatedBackupConfig? AutomatedBackupConfig { get; set; }

    /// <summary>The backup collection full resource name. Example: projects/{project}/locations/{location}/backupCollections/{collection}</summary>
    [JsonPropertyName("backupCollection")]
    public string? BackupCollection { get; set; }

    /// <summary>The timestamp associated with the cluster creation request. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>field to the configuration file to match the latest value in the state.</summary>
    [JsonPropertyName("crossClusterReplicationConfig")]
    public V1beta1ClusterStatusAtProviderCrossClusterReplicationConfig? CrossClusterReplicationConfig { get; set; }

    /// <summary>Optional. Indicates if the cluster is deletion protected or not. If the value if set to true, any delete cluster operation will fail. Default value is true.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>Output only. Endpoints created on each given network, for Redis clients to connect to the cluster. Currently only one endpoint is supported. Structure is documented below.</summary>
    [JsonPropertyName("discoveryEndpoints")]
    public IList<V1beta1ClusterStatusAtProviderDiscoveryEndpoints>? DiscoveryEndpoints { get; set; }

    /// <summary>Backups stored in Cloud Storage buckets. The Cloud Storage buckets need to be the same region as the clusters. Structure is documented below.</summary>
    [JsonPropertyName("gcsSource")]
    public V1beta1ClusterStatusAtProviderGcsSource? GcsSource { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{region}}/clusters/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The KMS key used to encrypt the at-rest data of the cluster.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Maintenance policy for a cluster Structure is documented below.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta1ClusterStatusAtProviderMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>Upcoming maintenance schedule. Structure is documented below.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta1ClusterStatusAtProviderMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>Backups that generated and managed by memorystore. Structure is documented below.</summary>
    [JsonPropertyName("managedBackupSource")]
    public V1beta1ClusterStatusAtProviderManagedBackupSource? ManagedBackupSource { get; set; }

    /// <summary>Cluster's Certificate Authority. This field will only be populated if Redis Cluster's transit_encryption_mode is TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION Structure is documented below.</summary>
    [JsonPropertyName("managedServerCa")]
    public IList<V1beta1ClusterStatusAtProviderManagedServerCa>? ManagedServerCa { get; set; }

    /// <summary>The nodeType for the Redis cluster. If not provided, REDIS_HIGHMEM_MEDIUM will be used as default Possible values are: REDIS_SHARED_CORE_NANO, REDIS_HIGHMEM_MEDIUM, REDIS_HIGHMEM_XLARGE, REDIS_STANDARD_SMALL.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>Persistence config (RDB, AOF) for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("persistenceConfig")]
    public V1beta1ClusterStatusAtProviderPersistenceConfig? PersistenceConfig { get; set; }

    /// <summary>Output only. Redis memory precise size in GB for the entire cluster.</summary>
    [JsonPropertyName("preciseSizeGb")]
    public double? PreciseSizeGb { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Required. Each PscConfig configures the consumer network where two network addresses will be designated to the cluster for client access. Currently, only one PscConfig is supported. Structure is documented below.</summary>
    [JsonPropertyName("pscConfigs")]
    public IList<V1beta1ClusterStatusAtProviderPscConfigs>? PscConfigs { get; set; }

    /// <summary>Output only. PSC connections for discovery of the cluster topology and accessing the cluster. Structure is documented below.</summary>
    [JsonPropertyName("pscConnections")]
    public IList<V1beta1ClusterStatusAtProviderPscConnections>? PscConnections { get; set; }

    /// <summary>Service attachment details to configure Psc connections. Structure is documented below.</summary>
    [JsonPropertyName("pscServiceAttachments")]
    public IList<V1beta1ClusterStatusAtProviderPscServiceAttachments>? PscServiceAttachments { get; set; }

    /// <summary>Configure Redis Cluster behavior using a subset of native Redis configuration parameters. Please check Memorystore documentation for the list of supported parameters: https://cloud.google.com/memorystore/docs/cluster/supported-instance-configurations</summary>
    [JsonPropertyName("redisConfigs")]
    public IDictionary<string, string>? RedisConfigs { get; set; }

    /// <summary>The name of the region of the Redis cluster.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Optional. The number of replica nodes per shard.</summary>
    [JsonPropertyName("replicaCount")]
    public double? ReplicaCount { get; set; }

    /// <summary>Required. Number of shards for the Redis cluster.</summary>
    [JsonPropertyName("shardCount")]
    public double? ShardCount { get; set; }

    /// <summary>Output only. Redis memory size in GB for the entire cluster.</summary>
    [JsonPropertyName("sizeGb")]
    public double? SizeGb { get; set; }

    /// <summary>The current state of this cluster. Can be CREATING, READY, UPDATING, DELETING and SUSPENDED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Additional information about the current state of the cluster. Structure is documented below.</summary>
    [JsonPropertyName("stateInfo")]
    public IList<V1beta1ClusterStatusAtProviderStateInfo>? StateInfo { get; set; }

    /// <summary>Optional. The in-transit encryption for the Redis cluster. If not provided, encryption is disabled for the cluster. Default value is TRANSIT_ENCRYPTION_MODE_DISABLED. Possible values are: TRANSIT_ENCRYPTION_MODE_UNSPECIFIED, TRANSIT_ENCRYPTION_MODE_DISABLED, TRANSIT_ENCRYPTION_MODE_SERVER_AUTHENTICATION.</summary>
    [JsonPropertyName("transitEncryptionMode")]
    public string? TransitEncryptionMode { get; set; }

    /// <summary>System assigned, unique identifier for the cluster.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Immutable. Zone distribution config for Memorystore Redis cluster. Structure is documented below.</summary>
    [JsonPropertyName("zoneDistributionConfig")]
    public V1beta1ClusterStatusAtProviderZoneDistributionConfig? ZoneDistributionConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusConditions
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

/// <summary>ClusterStatus defines the observed state of Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API. A Google Cloud Redis Cluster instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterSpec>, IStatus<V1beta1ClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "redis.gcp.m.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClusterStatus? Status { get; set; }
}