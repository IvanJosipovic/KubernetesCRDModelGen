using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigtable.cnrm.cloud.google.com;
/// <summary>A list of Autoscaling configurations. Only one element is used and allowed.</summary>
public partial class V1beta1BigtableInstanceSpecClusterAutoscalingConfig
{
    /// <summary>The target CPU utilization for autoscaling. Value must be between 10 and 80.</summary>
    [JsonPropertyName("cpuTarget")]
    public long CpuTarget { get; set; }

    /// <summary>The maximum number of nodes for autoscaling.</summary>
    [JsonPropertyName("maxNodes")]
    public long MaxNodes { get; set; }

    /// <summary>The minimum number of nodes for autoscaling.</summary>
    [JsonPropertyName("minNodes")]
    public long MinNodes { get; set; }

    /// <summary>The target storage utilization for autoscaling, in GB, for each node in a cluster. This number is limited between 2560 (2.5TiB) and 5120 (5TiB) for a SSD cluster and between 8192 (8TiB) and 16384 (16 TiB) for an HDD cluster. If not set, whatever is already set for the cluster will not change, or if the cluster is just being created, it will use the default value of 2560 for SSD clusters and 8192 for HDD clusters.</summary>
    [JsonPropertyName("storageTarget")]
    public long? StorageTarget { get; set; }
}

/// <summary>Describes the Cloud KMS encryption key that will be used to protect the destination Bigtable cluster. The requirements for this key are:  1) The Cloud Bigtable service account associated with the project that contains this cluster must be granted the cloudkms.cryptoKeyEncrypterDecrypter role on the CMEK key. 2) Only regional keys can be used and the region of the CMEK key must match the region of the cluster. 3) All clusters within an instance must use the same CMEK key access to this encryption key.</summary>
public partial class V1beta1BigtableInstanceSpecClusterKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
public partial class V1beta1BigtableInstanceSpecCluster
{
    /// <summary>A list of Autoscaling configurations. Only one element is used and allowed.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public V1beta1BigtableInstanceSpecClusterAutoscalingConfig? AutoscalingConfig { get; set; }

    /// <summary>The ID of the Cloud Bigtable cluster. Must be 6-30 characters and must only contain hyphens, lowercase letters and numbers.</summary>
    [JsonPropertyName("clusterId")]
    public string ClusterId { get; set; }

    /// <summary>Describes the Cloud KMS encryption key that will be used to protect the destination Bigtable cluster. The requirements for this key are:  1) The Cloud Bigtable service account associated with the project that contains this cluster must be granted the cloudkms.cryptoKeyEncrypterDecrypter role on the CMEK key. 2) Only regional keys can be used and the region of the CMEK key must match the region of the cluster. 3) All clusters within an instance must use the same CMEK key access to this encryption key.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1BigtableInstanceSpecClusterKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>The number of nodes in the cluster. If no value is set, Cloud Bigtable automatically allocates nodes based on your data footprint and optimized for 50% storage utilization.</summary>
    [JsonPropertyName("numNodes")]
    public long? NumNodes { get; set; }

    /// <summary>The storage type to use. One of "SSD" or "HDD". Defaults to "SSD".</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>The zone to create the Cloud Bigtable cluster in. Each cluster must have a different zone in the same region. Zones that support Bigtable instances are noted on the Cloud Bigtable locations page.</summary>
    [JsonPropertyName("zone")]
    public string Zone { get; set; }
}

/// <summary>BigtableInstanceSpec defines the desired state of BigtableInstance</summary>
public partial class V1beta1BigtableInstanceSpec
{
    /// <summary>A block of cluster configuration options. This can be specified at least once.</summary>
    [JsonPropertyName("cluster")]
    public IList<V1beta1BigtableInstanceSpecCluster>? Cluster { get; set; }

    /// <summary>DEPRECATED. This field no longer serves any function and is intended to be dropped in a later version of the resource.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>Required. The descriptive name for this instance as it appears in UIs. Can be changed at any time, but should be kept globally unique to avoid confusion.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>DEPRECATED. It is recommended to leave this field unspecified since the distinction between "DEVELOPMENT" and "PRODUCTION" instances is going away, and all instances will become "PRODUCTION" instances. This means that new and existing "DEVELOPMENT" instances will be converted to "PRODUCTION" instances. It is recommended for users to use "PRODUCTION" instances in any case, since a 1-node "PRODUCTION" instance is functionally identical to a "DEVELOPMENT" instance, but without the accompanying restrictions. The instance type to create. One of "DEVELOPMENT" or "PRODUCTION". Defaults to "PRODUCTION".</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Instance name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
public partial class V1beta1BigtableInstanceStatusConditions
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

/// <summary>BigtableInstanceStatus defines the config connector machine state of BigtableInstance</summary>
public partial class V1beta1BigtableInstanceStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BigtableInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>BigtableInstance is the Schema for the BigtableInstance API</summary>
public partial class V1beta1BigtableInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BigtableInstanceSpec>, IStatus<V1beta1BigtableInstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BigtableInstance";
    public const string KubeGroup = "bigtable.cnrm.cloud.google.com";
    public const string KubePluralName = "bigtableinstances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigtableInstanceSpec defines the desired state of BigtableInstance</summary>
    [JsonPropertyName("spec")]
    public V1beta1BigtableInstanceSpec? Spec { get; set; }

    /// <summary>BigtableInstanceStatus defines the config connector machine state of BigtableInstance</summary>
    [JsonPropertyName("status")]
    public V1beta1BigtableInstanceStatus? Status { get; set; }
}