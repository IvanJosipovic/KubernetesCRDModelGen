using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cache.azure.com;
public partial class V1api20230401storageRedisSpecIdentityUserAssignedIdentitiesReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20230401storageRedisSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20230401storageRedisSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

public partial class V1api20230401storageRedisSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20230401storageRedisSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

public partial class V1api20230401storageRedisSpecOperatorSpecSecretsHostName
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1api20230401storageRedisSpecOperatorSpecSecretsPort
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1api20230401storageRedisSpecOperatorSpecSecretsPrimaryKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1api20230401storageRedisSpecOperatorSpecSecretsSecondaryKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1api20230401storageRedisSpecOperatorSpecSecretsSslPort
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1api20230401storageRedisSpecOperatorSpecSecrets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("hostName")]
    public V1api20230401storageRedisSpecOperatorSpecSecretsHostName? HostName { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("port")]
    public V1api20230401storageRedisSpecOperatorSpecSecretsPort? Port { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("primaryKey")]
    public V1api20230401storageRedisSpecOperatorSpecSecretsPrimaryKey? PrimaryKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("secondaryKey")]
    public V1api20230401storageRedisSpecOperatorSpecSecretsSecondaryKey? SecondaryKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("sslPort")]
    public V1api20230401storageRedisSpecOperatorSpecSecretsSslPort? SslPort { get; set; }
}

public partial class V1api20230401storageRedisSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230401.RedisOperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V1api20230401storageRedisSpecOperatorSpecSecrets? Secrets { get; set; }
}

public partial class V1api20230401storageRedisSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20230401storageRedisSpecRedisConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aof-backup-enabled")]
    public string? AofBackupEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aof-storage-connection-string-0")]
    public string? AofStorageConnectionString0 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aof-storage-connection-string-1")]
    public string? AofStorageConnectionString1 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authnotrequired")]
    public string? Authnotrequired { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxfragmentationmemory-reserved")]
    public string? MaxfragmentationmemoryReserved { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxmemory-delta")]
    public string? MaxmemoryDelta { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxmemory-policy")]
    public string? MaxmemoryPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxmemory-reserved")]
    public string? MaxmemoryReserved { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preferred-data-persistence-auth-method")]
    public string? PreferredDataPersistenceAuthMethod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rdb-backup-enabled")]
    public string? RdbBackupEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rdb-backup-frequency")]
    public string? RdbBackupFrequency { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rdb-backup-max-snapshot-count")]
    public string? RdbBackupMaxSnapshotCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rdb-storage-connection-string")]
    public string? RdbStorageConnectionString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storage-subscription-id")]
    public string? StorageSubscriptionId { get; set; }
}

public partial class V1api20230401storageRedisSpecSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20230401storageRedisSpecSubnetReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20230401storageRedisSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableNonSslPort")]
    public bool? EnableNonSslPort { get; set; }

    /// <summary>Storage version of v1api20230401.ManagedServiceIdentity Managed service identity (system assigned and/or user assigned identities)</summary>
    [JsonPropertyName("identity")]
    public V1api20230401storageRedisSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Storage version of v1api20230401.RedisOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230401storageRedisSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230401storageRedisSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20230401.RedisCreateProperties_RedisConfiguration</summary>
    [JsonPropertyName("redisConfiguration")]
    public V1api20230401storageRedisSpecRedisConfiguration? RedisConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redisVersion")]
    public string? RedisVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicasPerMaster")]
    public int? ReplicasPerMaster { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicasPerPrimary")]
    public int? ReplicasPerPrimary { get; set; }

    /// <summary></summary>
    [JsonPropertyName("shardCount")]
    public int? ShardCount { get; set; }

    /// <summary>Storage version of v1api20230401.Sku SKU parameters supplied to the create Redis operation.</summary>
    [JsonPropertyName("sku")]
    public V1api20230401storageRedisSpecSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("staticIP")]
    public string? StaticIP { get; set; }

    /// <summary>SubnetReference: The full resource ID of a subnet in a virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1</summary>
    [JsonPropertyName("subnetReference")]
    public V1api20230401storageRedisSpecSubnetReference? SubnetReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantSettings")]
    public IDictionary<string, string>? TenantSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

public partial class V1api20230401storageRedisStatusConditions
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

public partial class V1api20230401storageRedisStatusIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

public partial class V1api20230401storageRedisStatusIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20230401storageRedisStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

public partial class V1api20230401storageRedisStatusInstances
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isMaster")]
    public bool? IsMaster { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isPrimary")]
    public bool? IsPrimary { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nonSslPort")]
    public int? NonSslPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("shardId")]
    public int? ShardId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sslPort")]
    public int? SslPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public partial class V1api20230401storageRedisStatusLinkedServers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20230401storageRedisStatusPrivateEndpointConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20230401storageRedisStatusRedisConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aof-backup-enabled")]
    public string? AofBackupEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aof-storage-connection-string-0")]
    public string? AofStorageConnectionString0 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aof-storage-connection-string-1")]
    public string? AofStorageConnectionString1 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authnotrequired")]
    public string? Authnotrequired { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxclients")]
    public string? Maxclients { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxfragmentationmemory-reserved")]
    public string? MaxfragmentationmemoryReserved { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxmemory-delta")]
    public string? MaxmemoryDelta { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxmemory-policy")]
    public string? MaxmemoryPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxmemory-reserved")]
    public string? MaxmemoryReserved { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preferred-data-archive-auth-method")]
    public string? PreferredDataArchiveAuthMethod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preferred-data-persistence-auth-method")]
    public string? PreferredDataPersistenceAuthMethod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rdb-backup-enabled")]
    public string? RdbBackupEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rdb-backup-frequency")]
    public string? RdbBackupFrequency { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rdb-backup-max-snapshot-count")]
    public string? RdbBackupMaxSnapshotCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rdb-storage-connection-string")]
    public string? RdbStorageConnectionString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storage-subscription-id")]
    public string? StorageSubscriptionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zonal-configuration")]
    public string? ZonalConfiguration { get; set; }
}

public partial class V1api20230401storageRedisStatusSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20230401storageRedisStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230401storageRedisStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableNonSslPort")]
    public bool? EnableNonSslPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20230401.ManagedServiceIdentity_STATUS Managed service identity (system assigned and/or user assigned identities)</summary>
    [JsonPropertyName("identity")]
    public V1api20230401storageRedisStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instances")]
    public IList<V1api20230401storageRedisStatusInstances>? Instances { get; set; }

    /// <summary></summary>
    [JsonPropertyName("linkedServers")]
    public IList<V1api20230401storageRedisStatusLinkedServers>? LinkedServers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20230401storageRedisStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20230401.RedisProperties_RedisConfiguration_STATUS</summary>
    [JsonPropertyName("redisConfiguration")]
    public V1api20230401storageRedisStatusRedisConfiguration? RedisConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redisVersion")]
    public string? RedisVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicasPerMaster")]
    public int? ReplicasPerMaster { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicasPerPrimary")]
    public int? ReplicasPerPrimary { get; set; }

    /// <summary></summary>
    [JsonPropertyName("shardCount")]
    public int? ShardCount { get; set; }

    /// <summary>Storage version of v1api20230401.Sku_STATUS SKU parameters supplied to the create Redis operation.</summary>
    [JsonPropertyName("sku")]
    public V1api20230401storageRedisStatusSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sslPort")]
    public int? SslPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("staticIP")]
    public string? StaticIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantSettings")]
    public IDictionary<string, string>? TenantSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230401storageRedis : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230401storageRedisSpec>, IStatus<V1api20230401storageRedisStatus>
{
    public const string KubeApiVersion = "v1api20230401storage";
    public const string KubeKind = "Redis";
    public const string KubeGroup = "cache.azure.com";
    public const string KubePluralName = "redis";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230401.Redis_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230401storageRedisSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230401.Redis_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20230401storageRedisStatus? Status { get; set; }
}