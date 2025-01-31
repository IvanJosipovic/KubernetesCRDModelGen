using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.redis.cnrm.cloud.google.com;
/// <summary>Optional. AOF configuration. This field will be ignored if mode is not AOF.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterSpecPersistenceConfigAofConfig
{
    /// <summary>Optional. fsync configuration.</summary>
    [JsonPropertyName("appendFsync")]
    public string? AppendFsync { get; set; }
}

/// <summary>Optional. RDB configuration. This field will be ignored if mode is not RDB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterSpecPersistenceConfigRdbConfig
{
    /// <summary>Optional. Period between RDB snapshots.</summary>
    [JsonPropertyName("rdbSnapshotPeriod")]
    public string? RdbSnapshotPeriod { get; set; }

    /// <summary>Optional. The time that the first snapshot was/will be attempted, and to which future snapshots will be aligned. If not provided, the current time will be used.</summary>
    [JsonPropertyName("rdbSnapshotStartTime")]
    public string? RdbSnapshotStartTime { get; set; }
}

/// <summary>Optional. Persistence config (RDB, AOF) for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterSpecPersistenceConfig
{
    /// <summary>Optional. AOF configuration. This field will be ignored if mode is not AOF.</summary>
    [JsonPropertyName("aofConfig")]
    public V1beta1RedisClusterSpecPersistenceConfigAofConfig? AofConfig { get; set; }

    /// <summary>Optional. The mode of persistence.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Optional. RDB configuration. This field will be ignored if mode is not RDB.</summary>
    [JsonPropertyName("rdbConfig")]
    public V1beta1RedisClusterSpecPersistenceConfigRdbConfig? RdbConfig { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. The network where the IP address of the discovery endpoint will be reserved, in the form of projects/{network_project}/global/networks/{network_id}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterSpecPscConfigsNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterSpecPscConfigs
{
    /// <summary>Required. The network where the IP address of the discovery endpoint will be reserved, in the form of projects/{network_project}/global/networks/{network_id}.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1RedisClusterSpecPscConfigsNetworkRef NetworkRef { get; set; }
}

/// <summary>Optional. This config will be used to determine how the customer wants us to distribute cluster resources within the region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterSpecZoneDistributionConfig
{
    /// <summary>Optional. The mode of zone distribution. Defaults to MULTI_ZONE, when not specified.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Optional. When SINGLE ZONE distribution is selected, zone field would be used to allocate all resources in that zone. This is not applicable to MULTI_ZONE, and would be ignored for MULTI_ZONE clusters.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>RedisClusterSpec defines the desired state of RedisCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterSpec
{
    /// <summary>Optional. The authorization mode of the Redis cluster. If not provided, auth feature is disabled for the cluster.</summary>
    [JsonPropertyName("authorizationMode")]
    public string? AuthorizationMode { get; set; }

    /// <summary>Optional. The delete operation will fail when the value is set to true.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>Immutable. Location of the resource.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Optional. The type of a redis node in the cluster. NodeType determines the underlying machine-type of a redis node.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>Optional. Persistence config (RDB, AOF) for the cluster.</summary>
    [JsonPropertyName("persistenceConfig")]
    public V1beta1RedisClusterSpecPersistenceConfig? PersistenceConfig { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1RedisClusterSpecProjectRef ProjectRef { get; set; }

    /// <summary>Required. Each PscConfig configures the consumer network where IPs will be designated to the cluster for client access through Private Service Connect Automation. Currently, only one PscConfig is supported.</summary>
    [JsonPropertyName("pscConfigs")]
    public IList<V1beta1RedisClusterSpecPscConfigs>? PscConfigs { get; set; }

    /// <summary>Optional. Key/Value pairs of customer overrides for mutable Redis Configs</summary>
    [JsonPropertyName("redisConfigs")]
    public IDictionary<string, string>? RedisConfigs { get; set; }

    /// <summary>Optional. The number of replica nodes per shard.</summary>
    [JsonPropertyName("replicaCount")]
    public int? ReplicaCount { get; set; }

    /// <summary>The RedisCluster name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Number of shards for the Redis cluster.</summary>
    [JsonPropertyName("shardCount")]
    public int? ShardCount { get; set; }

    /// <summary>Optional. The in-transit encryption for the Redis cluster. If not provided, encryption  is disabled for the cluster.</summary>
    [JsonPropertyName("transitEncryptionMode")]
    public string? TransitEncryptionMode { get; set; }

    /// <summary>Optional. This config will be used to determine how the customer wants us to distribute cluster resources within the region.</summary>
    [JsonPropertyName("zoneDistributionConfig")]
    public V1beta1RedisClusterSpecZoneDistributionConfig? ZoneDistributionConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterStatusConditions
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

/// <summary>Output only. Customer configuration for where the endpoint is created and accessed from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterStatusObservedStateDiscoveryEndpointsPscConfig
{
    /// <summary>Required. The network where the IP address of the discovery endpoint will be reserved, in the form of projects/{network_project}/global/networks/{network_id}.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterStatusObservedStateDiscoveryEndpoints
{
    /// <summary>Output only. Address of the exposed Redis endpoint used by clients to connect to the service. The address could be either IP or hostname.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Output only. The port number of the exposed Redis endpoint.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Output only. Customer configuration for where the endpoint is created and accessed from.</summary>
    [JsonPropertyName("pscConfig")]
    public V1beta1RedisClusterStatusObservedStateDiscoveryEndpointsPscConfig? PscConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterStatusObservedStatePscConnections
{
    /// <summary>Output only. The IP allocated on the consumer network for the PSC forwarding rule.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Output only. The URI of the consumer side forwarding rule. Example: projects/{projectNumOrId}/regions/us-east1/forwardingRules/{resourceId}.</summary>
    [JsonPropertyName("forwardingRule")]
    public string? ForwardingRule { get; set; }

    /// <summary>The consumer network where the IP address resides, in the form of projects/{project_id}/global/networks/{network_id}.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Output only. The consumer project_id where the forwarding rule is created from.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }

    /// <summary>Output only. The PSC connection id of the forwarding rule connected to the service attachment.</summary>
    [JsonPropertyName("pscConnectionID")]
    public string? PscConnectionID { get; set; }
}

/// <summary>Describes ongoing update on the cluster when cluster state is UPDATING.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterStatusObservedStateStateInfoUpdateInfo
{
    /// <summary>Target number of replica nodes per shard.</summary>
    [JsonPropertyName("targetReplicaCount")]
    public int? TargetReplicaCount { get; set; }

    /// <summary>Target number of shards for redis cluster</summary>
    [JsonPropertyName("targetShardCount")]
    public int? TargetShardCount { get; set; }
}

/// <summary>Output only. Additional information about the current state of the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterStatusObservedStateStateInfo
{
    /// <summary>Describes ongoing update on the cluster when cluster state is UPDATING.</summary>
    [JsonPropertyName("updateInfo")]
    public V1beta1RedisClusterStatusObservedStateStateInfoUpdateInfo? UpdateInfo { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterStatusObservedState
{
    /// <summary>Output only. The timestamp associated with the cluster creation request.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Endpoints created on each given network, for Redis clients to connect to the cluster. Currently only one discovery endpoint is supported.</summary>
    [JsonPropertyName("discoveryEndpoints")]
    public IList<V1beta1RedisClusterStatusObservedStateDiscoveryEndpoints>? DiscoveryEndpoints { get; set; }

    /// <summary>Output only. Precise value of redis memory size in GB for the entire cluster.</summary>
    [JsonPropertyName("preciseSizeGb")]
    public double? PreciseSizeGb { get; set; }

    /// <summary>Output only. PSC connections for discovery of the cluster topology and accessing the cluster.</summary>
    [JsonPropertyName("pscConnections")]
    public IList<V1beta1RedisClusterStatusObservedStatePscConnections>? PscConnections { get; set; }

    /// <summary>Output only. Redis memory size in GB for the entire cluster rounded up to the next integer.</summary>
    [JsonPropertyName("sizeGb")]
    public int? SizeGb { get; set; }

    /// <summary>Output only. The current state of this cluster. Can be CREATING, READY, UPDATING, DELETING and SUSPENDED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Additional information about the current state of the cluster.</summary>
    [JsonPropertyName("stateInfo")]
    public V1beta1RedisClusterStatusObservedStateStateInfo? StateInfo { get; set; }

    /// <summary>Output only. System assigned, unique identifier for the cluster.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>RedisClusterStatus defines the config connector machine state of RedisCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisClusterStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RedisClusterStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the RedisCluster resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1RedisClusterStatusObservedState? ObservedState { get; set; }
}

/// <summary>RedisCluster is the Schema for the RedisCluster API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RedisCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RedisClusterSpec>, IStatus<V1beta1RedisClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RedisCluster";
    public const string KubeGroup = "redis.cnrm.cloud.google.com";
    public const string KubePluralName = "redisclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RedisClusterSpec defines the desired state of RedisCluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1RedisClusterSpec? Spec { get; set; }

    /// <summary>RedisClusterStatus defines the config connector machine state of RedisCluster</summary>
    [JsonPropertyName("status")]
    public V1beta1RedisClusterStatus? Status { get; set; }
}