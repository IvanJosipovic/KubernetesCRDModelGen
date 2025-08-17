using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.managedkafka.cnrm.cloud.google.com;
#nullable enable
/// <summary>ManagedKafkaCluster is the Schema for the ManagedKafkaCluster API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ManagedKafkaClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ManagedKafkaCluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ManagedKafkaClusterList";
    public const string KubeGroup = "managedkafka.cnrm.cloud.google.com";
    public const string KubePluralName = "managedkafkaclusters";
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
    public IList<V1beta1ManagedKafkaCluster> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Capacity configuration for the Kafka cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaClusterSpecCapacityConfig
{
    /// <summary>Required. The memory to provision for the cluster in bytes. The CPU:memory ratio (vCPU:GiB) must be between 1:1 and 1:8. Minimum: 3221225472 (3 GiB).</summary>
    [JsonPropertyName("memoryBytes")]
    public long MemoryBytes { get; set; }

    /// <summary>Required. The number of vCPUs to provision for the cluster. Minimum: 3.</summary>
    [JsonPropertyName("vcpuCount")]
    public long VcpuCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Reference to the VPC subnet in which to create Private Service Connect  (PSC) endpoints for the Kafka brokers and bootstrap address.   The subnet must be located in the same region as the Kafka cluster. The  project may differ. Multiple subnets from the same parent network must not  be specified.   The CIDR range of the subnet must be within the IPv4 address ranges for  private networks, as specified in RFC 1918.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaClusterSpecGcpConfigAccessConfigNetworkConfigsSubnetworkRef
{
    /// <summary>The ComputeSubnetwork selflink of form "projects/{{project}}/regions/{{region}}/subnetworks/{{name}}", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaClusterSpecGcpConfigAccessConfigNetworkConfigs
{
    /// <summary>Required. Reference to the VPC subnet in which to create Private Service Connect  (PSC) endpoints for the Kafka brokers and bootstrap address.   The subnet must be located in the same region as the Kafka cluster. The  project may differ. Multiple subnets from the same parent network must not  be specified.   The CIDR range of the subnet must be within the IPv4 address ranges for  private networks, as specified in RFC 1918.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ManagedKafkaClusterSpecGcpConfigAccessConfigNetworkConfigsSubnetworkRef SubnetworkRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Access configuration for the Kafka cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaClusterSpecGcpConfigAccessConfig
{
    /// <summary>Required. Virtual Private Cloud (VPC) networks that must be granted direct access to the Kafka cluster. Minimum of 1 network is required. Maximum 10 networks can be specified.</summary>
    [JsonPropertyName("networkConfigs")]
    public IList<V1beta1ManagedKafkaClusterSpecGcpConfigAccessConfigNetworkConfigs> NetworkConfigs { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Immutable. The Cloud KMS Key name to use for encryption. The key must be located in the same region as the cluster and cannot be changed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaClusterSpecGcpConfigKmsKeyRef
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
#nullable disable

#nullable enable
/// <summary>Required. Configuration properties for a Kafka cluster deployed to Google Cloud Platform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaClusterSpecGcpConfig
{
    /// <summary>Required. Access configuration for the Kafka cluster.</summary>
    [JsonPropertyName("accessConfig")]
    public V1beta1ManagedKafkaClusterSpecGcpConfigAccessConfig AccessConfig { get; set; }

    /// <summary>Optional. Immutable. The Cloud KMS Key name to use for encryption. The key must be located in the same region as the cluster and cannot be changed.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1ManagedKafkaClusterSpecGcpConfigKmsKeyRef? KmsKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaClusterSpecProjectRef
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
#nullable disable

#nullable enable
/// <summary>Optional. Rebalance configuration for the Kafka cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaClusterSpecRebalanceConfig
{
    /// <summary>Optional. The rebalance behavior for the cluster. When not specified, defaults to `NO_REBALANCE`.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ManagedKafkaClusterSpec defines the desired state of ManagedKafkaCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaClusterSpec
{
    /// <summary>Required. Capacity configuration for the Kafka cluster.</summary>
    [JsonPropertyName("capacityConfig")]
    public V1beta1ManagedKafkaClusterSpecCapacityConfig CapacityConfig { get; set; }

    /// <summary>Required. Configuration properties for a Kafka cluster deployed to Google Cloud Platform.</summary>
    [JsonPropertyName("gcpConfig")]
    public V1beta1ManagedKafkaClusterSpecGcpConfig GcpConfig { get; set; }

    /// <summary>Optional. Labels as key value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ManagedKafkaClusterSpecProjectRef ProjectRef { get; set; }

    /// <summary>Optional. Rebalance configuration for the Kafka cluster.</summary>
    [JsonPropertyName("rebalanceConfig")]
    public V1beta1ManagedKafkaClusterSpecRebalanceConfig? RebalanceConfig { get; set; }

    /// <summary>The GCP resource identifier. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaClusterStatusConditions
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
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaClusterStatusObservedState
{
    /// <summary>Output only. The time when the cluster was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The current state of the cluster.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The time when the cluster was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ManagedKafkaClusterStatus defines the config connector machine state of ManagedKafkaCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaClusterStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ManagedKafkaClusterStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ManagedKafkaCluster resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1ManagedKafkaClusterStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ManagedKafkaCluster is the Schema for the ManagedKafkaCluster API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ManagedKafkaCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ManagedKafkaClusterSpec>, IStatus<V1beta1ManagedKafkaClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ManagedKafkaCluster";
    public const string KubeGroup = "managedkafka.cnrm.cloud.google.com";
    public const string KubePluralName = "managedkafkaclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagedKafkaClusterSpec defines the desired state of ManagedKafkaCluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1ManagedKafkaClusterSpec Spec { get; set; }

    /// <summary>ManagedKafkaClusterStatus defines the config connector machine state of ManagedKafkaCluster</summary>
    [JsonPropertyName("status")]
    public V1beta1ManagedKafkaClusterStatus? Status { get; set; }
}
#nullable disable
