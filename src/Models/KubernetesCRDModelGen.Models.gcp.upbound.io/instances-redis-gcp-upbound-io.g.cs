using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.redis.gcp.upbound.io;
#nullable enable
/// <summary>Instance is the Schema for the Instances API. A Google Cloud Redis instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Instance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstanceList";
    public const string KubeGroup = "redis.gcp.upbound.io";
    public const string KubePluralName = "instances";
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
    public IList<V1beta1Instance> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderAuthorizedNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Network in compute to populate authorizedNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderAuthorizedNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderAuthorizedNetworkRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderAuthorizedNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Network in compute to populate authorizedNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderAuthorizedNetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderAuthorizedNetworkSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderCustomerManagedKeyRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a CryptoKey in kms to populate customerManagedKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderCustomerManagedKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderCustomerManagedKeyRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderCustomerManagedKeySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a CryptoKey in kms to populate customerManagedKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderCustomerManagedKeySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecForProviderCustomerManagedKeySelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderMaintenancePolicyWeeklyMaintenanceWindow
{
    /// <summary>Required. The day of week that maintenance updates occur.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>Required. Start time of the window in UTC time. Structure is documented below.</summary>
    [JsonPropertyName("startTime")]
    public IList<V1beta1InstanceSpecForProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime>? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderMaintenancePolicy
{
    /// <summary>Optional. Description of what this policy is for. Create/Update methods return INVALID_ARGUMENT if the length is greater than 512.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Maintenance window that is applied to resources covered by this policy. Minimum 1. For the current version, the maximum number of weekly_window is expected to be one. Structure is documented below.</summary>
    [JsonPropertyName("weeklyMaintenanceWindow")]
    public IList<V1beta1InstanceSpecForProviderMaintenancePolicyWeeklyMaintenanceWindow>? WeeklyMaintenanceWindow { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderPersistenceConfig
{
    /// <summary>Optional. Controls whether Persistence features are enabled. If not provided, the existing value will be used.</summary>
    [JsonPropertyName("persistenceMode")]
    public string? PersistenceMode { get; set; }

    /// <summary>Optional. Available snapshot periods for scheduling.</summary>
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
public partial class V1beta1InstanceSpecForProvider
{
    /// <summary>Only applicable to STANDARD_HA tier which protects the instance against zonal failures by provisioning it across two zones. If provided, it must be a different zone from the one provided in [locationId].</summary>
    [JsonPropertyName("alternativeLocationId")]
    public string? AlternativeLocationId { get; set; }

    /// <summary>Optional. Indicates whether OSS Redis AUTH is enabled for the instance. If set to "true" AUTH is enabled on the instance. Default value is "false" meaning AUTH is disabled.</summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>The full name of the Google Compute Engine network to which the instance is connected. If left unspecified, the default network will be used.</summary>
    [JsonPropertyName("authorizedNetwork")]
    public string? AuthorizedNetwork { get; set; }

    /// <summary>Reference to a Network in compute to populate authorizedNetwork.</summary>
    [JsonPropertyName("authorizedNetworkRef")]
    public V1beta1InstanceSpecForProviderAuthorizedNetworkRef? AuthorizedNetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate authorizedNetwork.</summary>
    [JsonPropertyName("authorizedNetworkSelector")]
    public V1beta1InstanceSpecForProviderAuthorizedNetworkSelector? AuthorizedNetworkSelector { get; set; }

    /// <summary>The connection mode of the Redis instance. Default value is DIRECT_PEERING. Possible values are: DIRECT_PEERING, PRIVATE_SERVICE_ACCESS.</summary>
    [JsonPropertyName("connectMode")]
    public string? ConnectMode { get; set; }

    /// <summary>Optional. The KMS key reference that you want to use to encrypt the data at rest for this Redis instance. If this is provided, CMEK is enabled.</summary>
    [JsonPropertyName("customerManagedKey")]
    public string? CustomerManagedKey { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate customerManagedKey.</summary>
    [JsonPropertyName("customerManagedKeyRef")]
    public V1beta1InstanceSpecForProviderCustomerManagedKeyRef? CustomerManagedKeyRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate customerManagedKey.</summary>
    [JsonPropertyName("customerManagedKeySelector")]
    public V1beta1InstanceSpecForProviderCustomerManagedKeySelector? CustomerManagedKeySelector { get; set; }

    /// <summary>An arbitrary and optional user-provided name for the instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Resource labels to represent user provided metadata. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The zone where the instance will be provisioned. If not provided, the service will choose a zone for the instance. For STANDARD_HA tier, instances will be created across two zones for protection against zonal failures. If [alternativeLocationId] is also provided, it must be different from [locationId].</summary>
    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    /// <summary>Maintenance policy for an instance. Structure is documented below.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public IList<V1beta1InstanceSpecForProviderMaintenancePolicy>? MaintenancePolicy { get; set; }

    /// <summary>The self service update maintenance version.</summary>
    [JsonPropertyName("maintenanceVersion")]
    public string? MaintenanceVersion { get; set; }

    /// <summary>Redis memory size in GiB.</summary>
    [JsonPropertyName("memorySizeGb")]
    public double? MemorySizeGb { get; set; }

    /// <summary>Persistence configuration for an instance. Structure is documented below.</summary>
    [JsonPropertyName("persistenceConfig")]
    public IList<V1beta1InstanceSpecForProviderPersistenceConfig>? PersistenceConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Optional. Read replica mode. Can only be specified when trying to create the instance. If not set, Memorystore Redis backend will default to READ_REPLICAS_DISABLED.</summary>
    [JsonPropertyName("readReplicasMode")]
    public string? ReadReplicasMode { get; set; }

    /// <summary>Redis configuration parameters, according to http://redis.io/topics/config. Please check Memorystore documentation for the list of supported parameters: https://cloud.google.com/memorystore/docs/redis/reference/rest/v1/projects.locations.instances#Instance.FIELDS.redis_configs</summary>
    [JsonPropertyName("redisConfigs")]
    public IDictionary<string, string>? RedisConfigs { get; set; }

    /// <summary>The version of Redis software. If not provided, latest supported version will be used. Please check the API documentation linked at the top for the latest valid values.</summary>
    [JsonPropertyName("redisVersion")]
    public string? RedisVersion { get; set; }

    /// <summary>The name of the Redis region of the instance.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Optional. The number of replica nodes. The valid range for the Standard Tier with read replicas enabled is [1-5] and defaults to 2. If read replicas are not enabled for a Standard Tier instance, the only valid value is 1 and the default is 1. The valid value for basic tier is 0 and the default is also 0.</summary>
    [JsonPropertyName("replicaCount")]
    public double? ReplicaCount { get; set; }

    /// <summary>The CIDR range of internal addresses that are reserved for this instance. If not provided, the service will choose an unused /29 block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be unique and non-overlapping with existing subnets in an authorized network.</summary>
    [JsonPropertyName("reservedIpRange")]
    public string? ReservedIpRange { get; set; }

    /// <summary>Optional. Additional IP range for node placement. Required when enabling read replicas on an existing instance. For DIRECT_PEERING mode value must be a CIDR range of size /28, or "auto". For PRIVATE_SERVICE_ACCESS mode value must be the name of an allocated address range associated with the private service access connection, or "auto".</summary>
    [JsonPropertyName("secondaryIpRange")]
    public string? SecondaryIpRange { get; set; }

    /// <summary>The service tier of the instance. Must be one of these values:</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The TLS mode of the Redis instance, If not provided, TLS is disabled for the instance.</summary>
    [JsonPropertyName("transitEncryptionMode")]
    public string? TransitEncryptionMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderAuthorizedNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Network in compute to populate authorizedNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderAuthorizedNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderAuthorizedNetworkRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderAuthorizedNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Network in compute to populate authorizedNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderAuthorizedNetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderAuthorizedNetworkSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderCustomerManagedKeyRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a CryptoKey in kms to populate customerManagedKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderCustomerManagedKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderCustomerManagedKeyRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderCustomerManagedKeySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a CryptoKey in kms to populate customerManagedKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderCustomerManagedKeySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecInitProviderCustomerManagedKeySelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindow
{
    /// <summary>Required. The day of week that maintenance updates occur.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>Required. Start time of the window in UTC time. Structure is documented below.</summary>
    [JsonPropertyName("startTime")]
    public IList<V1beta1InstanceSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime>? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderMaintenancePolicy
{
    /// <summary>Optional. Description of what this policy is for. Create/Update methods return INVALID_ARGUMENT if the length is greater than 512.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Maintenance window that is applied to resources covered by this policy. Minimum 1. For the current version, the maximum number of weekly_window is expected to be one. Structure is documented below.</summary>
    [JsonPropertyName("weeklyMaintenanceWindow")]
    public IList<V1beta1InstanceSpecInitProviderMaintenancePolicyWeeklyMaintenanceWindow>? WeeklyMaintenanceWindow { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderPersistenceConfig
{
    /// <summary>Optional. Controls whether Persistence features are enabled. If not provided, the existing value will be used.</summary>
    [JsonPropertyName("persistenceMode")]
    public string? PersistenceMode { get; set; }

    /// <summary>Optional. Available snapshot periods for scheduling.</summary>
    [JsonPropertyName("rdbSnapshotPeriod")]
    public string? RdbSnapshotPeriod { get; set; }

    /// <summary>Optional. Date and time that the first snapshot was/will be attempted, and to which future snapshots will be aligned. If not provided, the current time will be used. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("rdbSnapshotStartTime")]
    public string? RdbSnapshotStartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProvider
{
    /// <summary>Only applicable to STANDARD_HA tier which protects the instance against zonal failures by provisioning it across two zones. If provided, it must be a different zone from the one provided in [locationId].</summary>
    [JsonPropertyName("alternativeLocationId")]
    public string? AlternativeLocationId { get; set; }

    /// <summary>Optional. Indicates whether OSS Redis AUTH is enabled for the instance. If set to "true" AUTH is enabled on the instance. Default value is "false" meaning AUTH is disabled.</summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>The full name of the Google Compute Engine network to which the instance is connected. If left unspecified, the default network will be used.</summary>
    [JsonPropertyName("authorizedNetwork")]
    public string? AuthorizedNetwork { get; set; }

    /// <summary>Reference to a Network in compute to populate authorizedNetwork.</summary>
    [JsonPropertyName("authorizedNetworkRef")]
    public V1beta1InstanceSpecInitProviderAuthorizedNetworkRef? AuthorizedNetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate authorizedNetwork.</summary>
    [JsonPropertyName("authorizedNetworkSelector")]
    public V1beta1InstanceSpecInitProviderAuthorizedNetworkSelector? AuthorizedNetworkSelector { get; set; }

    /// <summary>The connection mode of the Redis instance. Default value is DIRECT_PEERING. Possible values are: DIRECT_PEERING, PRIVATE_SERVICE_ACCESS.</summary>
    [JsonPropertyName("connectMode")]
    public string? ConnectMode { get; set; }

    /// <summary>Optional. The KMS key reference that you want to use to encrypt the data at rest for this Redis instance. If this is provided, CMEK is enabled.</summary>
    [JsonPropertyName("customerManagedKey")]
    public string? CustomerManagedKey { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate customerManagedKey.</summary>
    [JsonPropertyName("customerManagedKeyRef")]
    public V1beta1InstanceSpecInitProviderCustomerManagedKeyRef? CustomerManagedKeyRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate customerManagedKey.</summary>
    [JsonPropertyName("customerManagedKeySelector")]
    public V1beta1InstanceSpecInitProviderCustomerManagedKeySelector? CustomerManagedKeySelector { get; set; }

    /// <summary>An arbitrary and optional user-provided name for the instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Resource labels to represent user provided metadata. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The zone where the instance will be provisioned. If not provided, the service will choose a zone for the instance. For STANDARD_HA tier, instances will be created across two zones for protection against zonal failures. If [alternativeLocationId] is also provided, it must be different from [locationId].</summary>
    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    /// <summary>Maintenance policy for an instance. Structure is documented below.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public IList<V1beta1InstanceSpecInitProviderMaintenancePolicy>? MaintenancePolicy { get; set; }

    /// <summary>The self service update maintenance version.</summary>
    [JsonPropertyName("maintenanceVersion")]
    public string? MaintenanceVersion { get; set; }

    /// <summary>Redis memory size in GiB.</summary>
    [JsonPropertyName("memorySizeGb")]
    public double? MemorySizeGb { get; set; }

    /// <summary>Persistence configuration for an instance. Structure is documented below.</summary>
    [JsonPropertyName("persistenceConfig")]
    public IList<V1beta1InstanceSpecInitProviderPersistenceConfig>? PersistenceConfig { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Optional. Read replica mode. Can only be specified when trying to create the instance. If not set, Memorystore Redis backend will default to READ_REPLICAS_DISABLED.</summary>
    [JsonPropertyName("readReplicasMode")]
    public string? ReadReplicasMode { get; set; }

    /// <summary>Redis configuration parameters, according to http://redis.io/topics/config. Please check Memorystore documentation for the list of supported parameters: https://cloud.google.com/memorystore/docs/redis/reference/rest/v1/projects.locations.instances#Instance.FIELDS.redis_configs</summary>
    [JsonPropertyName("redisConfigs")]
    public IDictionary<string, string>? RedisConfigs { get; set; }

    /// <summary>The version of Redis software. If not provided, latest supported version will be used. Please check the API documentation linked at the top for the latest valid values.</summary>
    [JsonPropertyName("redisVersion")]
    public string? RedisVersion { get; set; }

    /// <summary>Optional. The number of replica nodes. The valid range for the Standard Tier with read replicas enabled is [1-5] and defaults to 2. If read replicas are not enabled for a Standard Tier instance, the only valid value is 1 and the default is 1. The valid value for basic tier is 0 and the default is also 0.</summary>
    [JsonPropertyName("replicaCount")]
    public double? ReplicaCount { get; set; }

    /// <summary>The CIDR range of internal addresses that are reserved for this instance. If not provided, the service will choose an unused /29 block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be unique and non-overlapping with existing subnets in an authorized network.</summary>
    [JsonPropertyName("reservedIpRange")]
    public string? ReservedIpRange { get; set; }

    /// <summary>Optional. Additional IP range for node placement. Required when enabling read replicas on an existing instance. For DIRECT_PEERING mode value must be a CIDR range of size /28, or "auto". For PRIVATE_SERVICE_ACCESS mode value must be the name of an allocated address range associated with the private service access connection, or "auto".</summary>
    [JsonPropertyName("secondaryIpRange")]
    public string? SecondaryIpRange { get; set; }

    /// <summary>The service tier of the instance. Must be one of these values:</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The TLS mode of the Redis instance, If not provided, TLS is disabled for the instance.</summary>
    [JsonPropertyName("transitEncryptionMode")]
    public string? TransitEncryptionMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>InstanceSpec defines the desired state of Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InstanceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InstanceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindow
{
    /// <summary>Required. The day of week that maintenance updates occur.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>(Output) Output only. Duration of the maintenance window. The current window is fixed at 1 hour. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Required. Start time of the window in UTC time. Structure is documented below.</summary>
    [JsonPropertyName("startTime")]
    public IList<V1beta1InstanceStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindowStartTime>? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderMaintenancePolicy
{
    /// <summary>(Output) Output only. The time when the policy was created. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. Description of what this policy is for. Create/Update methods return INVALID_ARGUMENT if the length is greater than 512.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>(Output) Output only. The time when the policy was last updated. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Optional. Maintenance window that is applied to resources covered by this policy. Minimum 1. For the current version, the maximum number of weekly_window is expected to be one. Structure is documented below.</summary>
    [JsonPropertyName("weeklyMaintenanceWindow")]
    public IList<V1beta1InstanceStatusAtProviderMaintenancePolicyWeeklyMaintenanceWindow>? WeeklyMaintenanceWindow { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderMaintenanceSchedule
{
    /// <summary>(Output) Output only. The end time of any upcoming scheduled maintenance for this instance. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>(Output) Output only. The deadline that the maintenance schedule start time can not go beyond, including reschedule. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("scheduleDeadlineTime")]
    public string? ScheduleDeadlineTime { get; set; }

    /// <summary>(Output) Output only. The start time of any upcoming scheduled maintenance for this instance. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderNodes
{
    /// <summary>(Output) Node identifying string. e.g. 'node-0', 'node-1'</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>(Output) Location of the node.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderPersistenceConfig
{
    /// <summary>Optional. Controls whether Persistence features are enabled. If not provided, the existing value will be used.</summary>
    [JsonPropertyName("persistenceMode")]
    public string? PersistenceMode { get; set; }

    /// <summary>(Output) Output only. The next time that a snapshot attempt is scheduled to occur. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("rdbNextSnapshotTime")]
    public string? RdbNextSnapshotTime { get; set; }

    /// <summary>Optional. Available snapshot periods for scheduling.</summary>
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
public partial class V1beta1InstanceStatusAtProviderServerCaCerts
{
    /// <summary>(Output) The certificate data in PEM format.</summary>
    [JsonPropertyName("cert")]
    public string? Cert { get; set; }

    /// <summary>(Output) The time when the certificate was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>(Output) The time when the certificate expires.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>(Output) Serial number, as extracted from the certificate.</summary>
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    /// <summary>(Output) Sha1 Fingerprint of the certificate.</summary>
    [JsonPropertyName("sha1Fingerprint")]
    public string? Sha1Fingerprint { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProvider
{
    /// <summary>Only applicable to STANDARD_HA tier which protects the instance against zonal failures by provisioning it across two zones. If provided, it must be a different zone from the one provided in [locationId].</summary>
    [JsonPropertyName("alternativeLocationId")]
    public string? AlternativeLocationId { get; set; }

    /// <summary>Optional. Indicates whether OSS Redis AUTH is enabled for the instance. If set to "true" AUTH is enabled on the instance. Default value is "false" meaning AUTH is disabled.</summary>
    [JsonPropertyName("authEnabled")]
    public bool? AuthEnabled { get; set; }

    /// <summary>The full name of the Google Compute Engine network to which the instance is connected. If left unspecified, the default network will be used.</summary>
    [JsonPropertyName("authorizedNetwork")]
    public string? AuthorizedNetwork { get; set; }

    /// <summary>The connection mode of the Redis instance. Default value is DIRECT_PEERING. Possible values are: DIRECT_PEERING, PRIVATE_SERVICE_ACCESS.</summary>
    [JsonPropertyName("connectMode")]
    public string? ConnectMode { get; set; }

    /// <summary>The time the instance was created in RFC3339 UTC "Zulu" format, accurate to nanoseconds.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The current zone where the Redis endpoint is placed. For Basic Tier instances, this will always be the same as the [locationId] provided by the user at creation time. For Standard Tier instances, this can be either [locationId] or [alternativeLocationId] and can change after a failover event.</summary>
    [JsonPropertyName("currentLocationId")]
    public string? CurrentLocationId { get; set; }

    /// <summary>Optional. The KMS key reference that you want to use to encrypt the data at rest for this Redis instance. If this is provided, CMEK is enabled.</summary>
    [JsonPropertyName("customerManagedKey")]
    public string? CustomerManagedKey { get; set; }

    /// <summary>An arbitrary and optional user-provided name for the instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>The CIDR range of internal addresses that are reserved for this instance. If not provided, the service will choose an unused /29 block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be unique and non-overlapping with existing subnets in an authorized network.</summary>
    [JsonPropertyName("effectiveReservedIpRange")]
    public string? EffectiveReservedIpRange { get; set; }

    /// <summary>Hostname or IP address of the exposed Redis endpoint used by clients to connect to the service.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{region}}/instances/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Resource labels to represent user provided metadata. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The zone where the instance will be provisioned. If not provided, the service will choose a zone for the instance. For STANDARD_HA tier, instances will be created across two zones for protection against zonal failures. If [alternativeLocationId] is also provided, it must be different from [locationId].</summary>
    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    /// <summary>Maintenance policy for an instance. Structure is documented below.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public IList<V1beta1InstanceStatusAtProviderMaintenancePolicy>? MaintenancePolicy { get; set; }

    /// <summary>Upcoming maintenance schedule. Structure is documented below.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta1InstanceStatusAtProviderMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>The self service update maintenance version.</summary>
    [JsonPropertyName("maintenanceVersion")]
    public string? MaintenanceVersion { get; set; }

    /// <summary>Redis memory size in GiB.</summary>
    [JsonPropertyName("memorySizeGb")]
    public double? MemorySizeGb { get; set; }

    /// <summary>Output only. Info per node. Structure is documented below.</summary>
    [JsonPropertyName("nodes")]
    public IList<V1beta1InstanceStatusAtProviderNodes>? Nodes { get; set; }

    /// <summary>Persistence configuration for an instance. Structure is documented below.</summary>
    [JsonPropertyName("persistenceConfig")]
    public IList<V1beta1InstanceStatusAtProviderPersistenceConfig>? PersistenceConfig { get; set; }

    /// <summary>Output only. Cloud IAM identity used by import / export operations to transfer data to/from Cloud Storage. Format is "serviceAccount:". The value may change over time for a given instance so should be checked before each import/export operation.</summary>
    [JsonPropertyName("persistenceIamIdentity")]
    public string? PersistenceIamIdentity { get; set; }

    /// <summary>The port number of the exposed Redis endpoint.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Output only. Hostname or IP address of the exposed readonly Redis endpoint. Standard tier only. Targets all healthy replica nodes in instance. Replication is asynchronous and replica nodes will exhibit some lag behind the primary. Write requests must target 'host'.</summary>
    [JsonPropertyName("readEndpoint")]
    public string? ReadEndpoint { get; set; }

    /// <summary>Output only. The port number of the exposed readonly redis endpoint. Standard tier only. Write requests should target 'port'.</summary>
    [JsonPropertyName("readEndpointPort")]
    public double? ReadEndpointPort { get; set; }

    /// <summary>Optional. Read replica mode. Can only be specified when trying to create the instance. If not set, Memorystore Redis backend will default to READ_REPLICAS_DISABLED.</summary>
    [JsonPropertyName("readReplicasMode")]
    public string? ReadReplicasMode { get; set; }

    /// <summary>Redis configuration parameters, according to http://redis.io/topics/config. Please check Memorystore documentation for the list of supported parameters: https://cloud.google.com/memorystore/docs/redis/reference/rest/v1/projects.locations.instances#Instance.FIELDS.redis_configs</summary>
    [JsonPropertyName("redisConfigs")]
    public IDictionary<string, string>? RedisConfigs { get; set; }

    /// <summary>The version of Redis software. If not provided, latest supported version will be used. Please check the API documentation linked at the top for the latest valid values.</summary>
    [JsonPropertyName("redisVersion")]
    public string? RedisVersion { get; set; }

    /// <summary>The name of the Redis region of the instance.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Optional. The number of replica nodes. The valid range for the Standard Tier with read replicas enabled is [1-5] and defaults to 2. If read replicas are not enabled for a Standard Tier instance, the only valid value is 1 and the default is 1. The valid value for basic tier is 0 and the default is also 0.</summary>
    [JsonPropertyName("replicaCount")]
    public double? ReplicaCount { get; set; }

    /// <summary>The CIDR range of internal addresses that are reserved for this instance. If not provided, the service will choose an unused /29 block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be unique and non-overlapping with existing subnets in an authorized network.</summary>
    [JsonPropertyName("reservedIpRange")]
    public string? ReservedIpRange { get; set; }

    /// <summary>Optional. Additional IP range for node placement. Required when enabling read replicas on an existing instance. For DIRECT_PEERING mode value must be a CIDR range of size /28, or "auto". For PRIVATE_SERVICE_ACCESS mode value must be the name of an allocated address range associated with the private service access connection, or "auto".</summary>
    [JsonPropertyName("secondaryIpRange")]
    public string? SecondaryIpRange { get; set; }

    /// <summary>List of server CA certificates for the instance. Structure is documented below.</summary>
    [JsonPropertyName("serverCaCerts")]
    public IList<V1beta1InstanceStatusAtProviderServerCaCerts>? ServerCaCerts { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The service tier of the instance. Must be one of these values:</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The TLS mode of the Redis instance, If not provided, TLS is disabled for the instance.</summary>
    [JsonPropertyName("transitEncryptionMode")]
    public string? TransitEncryptionMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusConditions
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
#nullable disable

#nullable enable
/// <summary>InstanceStatus defines the observed state of Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InstanceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Instance is the Schema for the Instances API. A Google Cloud Redis instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstanceSpec>, IStatus<V1beta1InstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "redis.gcp.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceSpec defines the desired state of Instance</summary>
    [JsonPropertyName("spec")]
    public V1beta1InstanceSpec Spec { get; set; }

    /// <summary>InstanceStatus defines the observed state of Instance.</summary>
    [JsonPropertyName("status")]
    public V1beta1InstanceStatus? Status { get; set; }
}
#nullable disable
