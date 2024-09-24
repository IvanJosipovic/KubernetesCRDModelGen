using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.alloydb.cnrm.cloud.google.com;
/// <summary></summary>
public partial class V1alpha1AlloyDBInstanceSpecClusterRef
{
    /// <summary>Allowed value: The `name` field of an `AlloyDBCluster` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The type of instance. Possible values: ["PRIMARY", "READ_POOL", "SECONDARY"] For PRIMARY and SECONDARY instances, set the value to refer to the name of the associated cluster. This is recommended because the instance type of primary and secondary instances is tied to the cluster type of the associated cluster. If the secondary cluster is promoted to primary cluster, then the associated secondary instance also becomes primary instance. Example: instanceTypeRef:   name: clusterName For instances of type READ_POOL, set the value using external keyword. Example: instanceTypeRef:   external: READ_POOL If the instance type is SECONDARY, the delete instance operation does not delete the secondary instance but abandons it instead. Use deletionPolicy = "FORCE" in the associated secondary cluster and delete the cluster forcefully to delete the secondary cluster as well its associated secondary instance.</summary>
public partial class V1alpha1AlloyDBInstanceSpecInstanceTypeRef
{
    /// <summary>Allowed value: The `clusterType` field of an `AlloyDBCluster` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Configurations for the machines that host the underlying database engine.</summary>
public partial class V1alpha1AlloyDBInstanceSpecMachineConfig
{
    /// <summary>The number of CPU's in the VM instance.</summary>
    [JsonPropertyName("cpuCount")]
    public int? CpuCount { get; set; }
}

/// <summary></summary>
public partial class V1alpha1AlloyDBInstanceSpecNetworkConfigAuthorizedExternalNetworks
{
    /// <summary>CIDR range for one authorized network of the instance.</summary>
    [JsonPropertyName("cidrRange")]
    public string? CidrRange { get; set; }
}

/// <summary>Instance level network configuration.</summary>
public partial class V1alpha1AlloyDBInstanceSpecNetworkConfig
{
    /// <summary>A list of external networks authorized to access this instance. This field is only allowed to be set when 'enable_public_ip' is set to true.</summary>
    [JsonPropertyName("authorizedExternalNetworks")]
    public IList<V1alpha1AlloyDBInstanceSpecNetworkConfigAuthorizedExternalNetworks>? AuthorizedExternalNetworks { get; set; }

    /// <summary>Enabling public ip for the instance. If a user wishes to disable this, please also clear the list of the authorized external networks set on the same instance.</summary>
    [JsonPropertyName("enablePublicIp")]
    public bool? EnablePublicIp { get; set; }
}

/// <summary>Read pool specific config. If the instance type is READ_POOL, this configuration must be provided.</summary>
public partial class V1alpha1AlloyDBInstanceSpecReadPoolConfig
{
    /// <summary>Read capacity, i.e. number of nodes in a read pool instance.</summary>
    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }
}

/// <summary></summary>
public partial class V1alpha1AlloyDBInstanceSpec
{
    /// <summary>Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>'Availability type of an Instance. Defaults to REGIONAL for both primary and read instances. Note that primary and read instances can have different availability types. Only READ_POOL instance supports ZONAL type. Users can't specify the zone for READ_POOL instance. Zone is automatically chosen from the list of zones in the region specified. Read pool of size 1 can only have zonal availability. Read pools with node count of 2 or more can have regional availability (nodes are present in 2 or more zones in a region).' Possible values: ["AVAILABILITY_TYPE_UNSPECIFIED", "ZONAL", "REGIONAL"].</summary>
    [JsonPropertyName("availabilityType")]
    public string? AvailabilityType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterRef")]
    public V1alpha1AlloyDBInstanceSpecClusterRef ClusterRef { get; set; }

    /// <summary>Database flags. Set at instance level. * They are copied from primary instance on read instance creation. * Read instances can set new or override existing flags that are relevant for reads, e.g. for enabling columnar cache on a read instance. Flags set on read instance may or may not be present on primary.</summary>
    [JsonPropertyName("databaseFlags")]
    public IDictionary<string, string>? DatabaseFlags { get; set; }

    /// <summary>User-settable and human-readable display name for the Instance.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The Compute Engine zone that the instance should serve from, per https://cloud.google.com/compute/docs/regions-zones This can ONLY be specified for ZONAL instances. If present for a REGIONAL instance, an error will be thrown. If this is absent for a ZONAL instance, instance is created in a random zone with available capacity.</summary>
    [JsonPropertyName("gceZone")]
    public string? GceZone { get; set; }

    /// <summary>We recommend that you use `instanceTypeRef` instead. The type of the instance. Possible values: [PRIMARY, READ_POOL, SECONDARY]</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The type of instance. Possible values: ["PRIMARY", "READ_POOL", "SECONDARY"] For PRIMARY and SECONDARY instances, set the value to refer to the name of the associated cluster. This is recommended because the instance type of primary and secondary instances is tied to the cluster type of the associated cluster. If the secondary cluster is promoted to primary cluster, then the associated secondary instance also becomes primary instance. Example: instanceTypeRef:   name: clusterName For instances of type READ_POOL, set the value using external keyword. Example: instanceTypeRef:   external: READ_POOL If the instance type is SECONDARY, the delete instance operation does not delete the secondary instance but abandons it instead. Use deletionPolicy = "FORCE" in the associated secondary cluster and delete the cluster forcefully to delete the secondary cluster as well its associated secondary instance.</summary>
    [JsonPropertyName("instanceTypeRef")]
    public V1alpha1AlloyDBInstanceSpecInstanceTypeRef? InstanceTypeRef { get; set; }

    /// <summary>Configurations for the machines that host the underlying database engine.</summary>
    [JsonPropertyName("machineConfig")]
    public V1alpha1AlloyDBInstanceSpecMachineConfig? MachineConfig { get; set; }

    /// <summary>Instance level network configuration.</summary>
    [JsonPropertyName("networkConfig")]
    public V1alpha1AlloyDBInstanceSpecNetworkConfig? NetworkConfig { get; set; }

    /// <summary>Read pool specific config. If the instance type is READ_POOL, this configuration must be provided.</summary>
    [JsonPropertyName("readPoolConfig")]
    public V1alpha1AlloyDBInstanceSpecReadPoolConfig? ReadPoolConfig { get; set; }

    /// <summary>Immutable. Optional. The instanceId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
public partial class V1alpha1AlloyDBInstanceStatusConditions
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

/// <summary></summary>
public partial class V1alpha1AlloyDBInstanceStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AlloyDBInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>Time the Instance was created in UTC.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The IP address for the Instance. This is the connection endpoint for an end-user application.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name of the instance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The public IP addresses for the Instance. This is available ONLY when networkConfig.enablePublicIp is set to true. This is the connection endpoint for an end-user application.</summary>
    [JsonPropertyName("publicIpAddress")]
    public string? PublicIpAddress { get; set; }

    /// <summary>Set to true if the current state of Instance does not match the user's intended state, and the service is actively updating the resource to reconcile them. This can happen due to user-triggered updates or system actions like failover or maintenance.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>The current state of the alloydb instance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The system-generated UID of the resource.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Time the Instance was updated in UTC.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1alpha1AlloyDBInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AlloyDBInstanceSpec>, IStatus<V1alpha1AlloyDBInstanceStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AlloyDBInstance";
    public const string KubeGroup = "alloydb.cnrm.cloud.google.com";
    public const string KubePluralName = "alloydbinstances";
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
    public V1alpha1AlloyDBInstanceSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1AlloyDBInstanceStatus? Status { get; set; }
}