using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.redis.cnrm.cloud.google.com;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RedisInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RedisInstance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RedisInstanceList";
    public const string KubeGroup = "redis.cnrm.cloud.google.com";
    public const string KubePluralName = "redisinstances";
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
    public IList<V1beta1RedisInstance> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The network to which the instance is connected. If left unspecified, the default network will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisInstanceSpecAuthorizedNetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Optional. The KMS key reference that you want to use to encrypt the data at rest for this Redis instance. If this is provided, CMEK is enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisInstanceSpecCustomerManagedKeyRef
{
    /// <summary>Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Start time of the window in UTC time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisInstanceSpecMaintenancePolicyWeeklyMaintenanceWindowStartTime
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public int? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public int? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisInstanceSpecMaintenancePolicyWeeklyMaintenanceWindow
{
    /// <summary>Required. The day of week that maintenance updates occur.  - DAY_OF_WEEK_UNSPECIFIED: The day of the week is unspecified. - MONDAY: Monday - TUESDAY: Tuesday - WEDNESDAY: Wednesday - THURSDAY: Thursday - FRIDAY: Friday - SATURDAY: Saturday - SUNDAY: Sunday Possible values: ["DAY_OF_WEEK_UNSPECIFIED", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"].</summary>
    [JsonPropertyName("day")]
    public string Day { get; set; }

    /// <summary>Output only. Duration of the maintenance window. The current window is fixed at 1 hour. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Required. Start time of the window in UTC time.</summary>
    [JsonPropertyName("startTime")]
    public V1beta1RedisInstanceSpecMaintenancePolicyWeeklyMaintenanceWindowStartTime StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Maintenance policy for an instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisInstanceSpecMaintenancePolicy
{
    /// <summary>Output only. The time when the policy was created. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. Description of what this policy is for. Create/Update methods return INVALID_ARGUMENT if the length is greater than 512.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Output only. The time when the policy was last updated. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Optional. Maintenance window that is applied to resources covered by this policy. Minimum 1. For the current version, the maximum number of weekly_window is expected to be one.</summary>
    [JsonPropertyName("weeklyMaintenanceWindow")]
    public IList<V1beta1RedisInstanceSpecMaintenancePolicyWeeklyMaintenanceWindow>? WeeklyMaintenanceWindow { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisInstanceSpecMaintenanceSchedule
{
    /// <summary>Output only. The end time of any upcoming scheduled maintenance for this instance. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Output only. The deadline that the maintenance schedule start time can not go beyond, including reschedule. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("scheduleDeadlineTime")]
    public string? ScheduleDeadlineTime { get; set; }

    /// <summary>Output only. The start time of any upcoming scheduled maintenance for this instance. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Persistence configuration for an instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisInstanceSpecPersistenceConfig
{
    /// <summary>Optional. Controls whether Persistence features are enabled. If not provided, the existing value will be used.  - DISABLED: 	Persistence is disabled for the instance, and any existing snapshots are deleted. - RDB: RDB based Persistence is enabled. Possible values: ["DISABLED", "RDB"].</summary>
    [JsonPropertyName("persistenceMode")]
    public string? PersistenceMode { get; set; }

    /// <summary>Output only. The next time that a snapshot attempt is scheduled to occur. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("rdbNextSnapshotTime")]
    public string? RdbNextSnapshotTime { get; set; }

    /// <summary>Optional. Available snapshot periods for scheduling.  - ONE_HOUR:	Snapshot every 1 hour. - SIX_HOURS:	Snapshot every 6 hours. - TWELVE_HOURS:	Snapshot every 12 hours. - TWENTY_FOUR_HOURS:	Snapshot every 24 hours. Possible values: ["ONE_HOUR", "SIX_HOURS", "TWELVE_HOURS", "TWENTY_FOUR_HOURS"].</summary>
    [JsonPropertyName("rdbSnapshotPeriod")]
    public string? RdbSnapshotPeriod { get; set; }

    /// <summary>Optional. Date and time that the first snapshot was/will be attempted, and to which future snapshots will be aligned. If not provided, the current time will be used. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("rdbSnapshotStartTime")]
    public string? RdbSnapshotStartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisInstanceSpec
{
    /// <summary>Immutable. Only applicable to STANDARD_HA tier which protects the instance against zonal failures by provisioning it across two zones. If provided, it must be a different zone from the one provided in [locationId].</summary>
    [JsonPropertyName("alternativeLocationId")]
    public string? AlternativeLocationId { get; set; }

    /// <summary>Optional. Indicates whether OSS Redis AUTH is enabled for the instance. If set to "true" AUTH is enabled on the instance. Default value is "false" meaning AUTH is disabled.</summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>Output only. AUTH String set on the instance. This field will only be populated if auth_enabled is true.</summary>
    [JsonPropertyName("authString")]
    public string? AuthString { get; set; }

    /// <summary>The network to which the instance is connected. If left unspecified, the default network will be used.</summary>
    [JsonPropertyName("authorizedNetworkRef")]
    public V1beta1RedisInstanceSpecAuthorizedNetworkRef? AuthorizedNetworkRef { get; set; }

    /// <summary>Immutable. The connection mode of the Redis instance. Default value: "DIRECT_PEERING" Possible values: ["DIRECT_PEERING", "PRIVATE_SERVICE_ACCESS"].</summary>
    [JsonPropertyName("connectMode")]
    public string? ConnectMode { get; set; }

    /// <summary>Immutable. Optional. The KMS key reference that you want to use to encrypt the data at rest for this Redis instance. If this is provided, CMEK is enabled.</summary>
    [JsonPropertyName("customerManagedKeyRef")]
    public V1beta1RedisInstanceSpecCustomerManagedKeyRef? CustomerManagedKeyRef { get; set; }

    /// <summary>An arbitrary and optional user-provided name for the instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable. The zone where the instance will be provisioned. If not provided, the service will choose a zone for the instance. For STANDARD_HA tier, instances will be created across two zones for protection against zonal failures. If [alternativeLocationId] is also provided, it must be different from [locationId].</summary>
    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    /// <summary>Maintenance policy for an instance.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta1RedisInstanceSpecMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>Upcoming maintenance schedule.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta1RedisInstanceSpecMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>Redis memory size in GiB.</summary>
    [JsonPropertyName("memorySizeGb")]
    public int MemorySizeGb { get; set; }

    /// <summary>Persistence configuration for an instance.</summary>
    [JsonPropertyName("persistenceConfig")]
    public V1beta1RedisInstanceSpecPersistenceConfig? PersistenceConfig { get; set; }

    /// <summary>Optional. Read replica mode. Can only be specified when trying to create the instance. If not set, Memorystore Redis backend will default to READ_REPLICAS_DISABLED. - READ_REPLICAS_DISABLED: If disabled, read endpoint will not be provided and the instance cannot scale up or down the number of replicas. - READ_REPLICAS_ENABLED: If enabled, read endpoint will be provided and the instance can scale up and down the number of replicas. Possible values: ["READ_REPLICAS_DISABLED", "READ_REPLICAS_ENABLED"].</summary>
    [JsonPropertyName("readReplicasMode")]
    public string? ReadReplicasMode { get; set; }

    /// <summary>Redis configuration parameters, according to http://redis.io/topics/config. Please check Memorystore documentation for the list of supported parameters: https://cloud.google.com/memorystore/docs/redis/reference/rest/v1/projects.locations.instances#Instance.FIELDS.redis_configs.</summary>
    [JsonPropertyName("redisConfigs")]
    public IDictionary<string, string>? RedisConfigs { get; set; }

    /// <summary>The version of Redis software. If not provided, latest supported version will be used. Please check the API documentation linked at the top for the latest valid values.</summary>
    [JsonPropertyName("redisVersion")]
    public string? RedisVersion { get; set; }

    /// <summary>Immutable. The name of the Redis region of the instance.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Optional. The number of replica nodes. The valid range for the Standard Tier with read replicas enabled is [1-5] and defaults to 2. If read replicas are not enabled for a Standard Tier instance, the only valid value is 1 and the default is 1. The valid value for basic tier is 0 and the default is also 0.</summary>
    [JsonPropertyName("replicaCount")]
    public int? ReplicaCount { get; set; }

    /// <summary>Immutable. The CIDR range of internal addresses that are reserved for this instance. If not provided, the service will choose an unused /29 block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be unique and non-overlapping with existing subnets in an authorized network.</summary>
    [JsonPropertyName("reservedIpRange")]
    public string? ReservedIpRange { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Additional IP range for node placement. Required when enabling read replicas on an existing instance. For DIRECT_PEERING mode value must be a CIDR range of size /28, or "auto". For PRIVATE_SERVICE_ACCESS mode value must be the name of an allocated address range associated with the private service access connection, or "auto".</summary>
    [JsonPropertyName("secondaryIpRange")]
    public string? SecondaryIpRange { get; set; }

    /// <summary>Immutable. The service tier of the instance. Must be one of these values:  - BASIC: standalone instance - STANDARD_HA: highly available primary/replica instances Default value: "BASIC" Possible values: ["BASIC", "STANDARD_HA"].</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Immutable. The TLS mode of the Redis instance, If not provided, TLS is disabled for the instance.  - SERVER_AUTHENTICATION: Client to Server traffic encryption enabled with server authentication Default value: "DISABLED" Possible values: ["SERVER_AUTHENTICATION", "DISABLED"].</summary>
    [JsonPropertyName("transitEncryptionMode")]
    public string? TransitEncryptionMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisInstanceStatusConditions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisInstanceStatusMaintenanceSchedule
{
    /// <summary>Output only. The end time of any upcoming scheduled maintenance for this instance. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Output only. The deadline that the maintenance schedule start time can not go beyond, including reschedule. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("scheduleDeadlineTime")]
    public string? ScheduleDeadlineTime { get; set; }

    /// <summary>Output only. The start time of any upcoming scheduled maintenance for this instance. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisInstanceStatusNodes
{
    /// <summary>Node identifying string. e.g. 'node-0', 'node-1'.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location of the node.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The observed state of the underlying GCP resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisInstanceStatusObservedState
{
    /// <summary>Output only. AUTH String set on the instance. This field will only be populated if auth_enabled is true.</summary>
    [JsonPropertyName("authString")]
    public string? AuthString { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisInstanceStatusServerCaCerts
{
    /// <summary>The certificate data in PEM format.</summary>
    [JsonPropertyName("cert")]
    public string? Cert { get; set; }

    /// <summary>The time when the certificate was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The time when the certificate expires.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Serial number, as extracted from the certificate.</summary>
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    /// <summary>Sha1 Fingerprint of the certificate.</summary>
    [JsonPropertyName("sha1Fingerprint")]
    public string? Sha1Fingerprint { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RedisInstanceStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RedisInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>The time the instance was created in RFC3339 UTC "Zulu" format, accurate to nanoseconds.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The current zone where the Redis endpoint is placed. For Basic Tier instances, this will always be the same as the [locationId] provided by the user at creation time. For Standard Tier instances, this can be either [locationId] or [alternativeLocationId] and can change after a failover event.</summary>
    [JsonPropertyName("currentLocationId")]
    public string? CurrentLocationId { get; set; }

    /// <summary>Hostname or IP address of the exposed Redis endpoint used by clients to connect to the service.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Upcoming maintenance schedule.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta1RedisInstanceStatusMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>Output only. Info per node.</summary>
    [JsonPropertyName("nodes")]
    public IList<V1beta1RedisInstanceStatusNodes>? Nodes { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The observed state of the underlying GCP resource.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1RedisInstanceStatusObservedState? ObservedState { get; set; }

    /// <summary>Output only. Cloud IAM identity used by import / export operations to transfer data to/from Cloud Storage. Format is "serviceAccount:". The value may change over time for a given instance so should be checked before each import/export operation.</summary>
    [JsonPropertyName("persistenceIamIdentity")]
    public string? PersistenceIamIdentity { get; set; }

    /// <summary>The port number of the exposed Redis endpoint.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Output only. Hostname or IP address of the exposed readonly Redis endpoint. Standard tier only. Targets all healthy replica nodes in instance. Replication is asynchronous and replica nodes will exhibit some lag behind the primary. Write requests must target 'host'.</summary>
    [JsonPropertyName("readEndpoint")]
    public string? ReadEndpoint { get; set; }

    /// <summary>Output only. The port number of the exposed readonly redis endpoint. Standard tier only. Write requests should target 'port'.</summary>
    [JsonPropertyName("readEndpointPort")]
    public int? ReadEndpointPort { get; set; }

    /// <summary>List of server CA certificates for the instance.</summary>
    [JsonPropertyName("serverCaCerts")]
    public IList<V1beta1RedisInstanceStatusServerCaCerts>? ServerCaCerts { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RedisInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RedisInstanceSpec>, IStatus<V1beta1RedisInstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RedisInstance";
    public const string KubeGroup = "redis.cnrm.cloud.google.com";
    public const string KubePluralName = "redisinstances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1RedisInstanceSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1RedisInstanceStatus? Status { get; set; }
}
#nullable disable
