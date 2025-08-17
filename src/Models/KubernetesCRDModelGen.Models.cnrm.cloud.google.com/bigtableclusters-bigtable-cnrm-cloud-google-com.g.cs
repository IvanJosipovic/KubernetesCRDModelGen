using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigtable.cnrm.cloud.google.com;
#nullable enable
/// <summary>BigtableCluster is the Schema for the BigtableCluster API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigtableClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BigtableCluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigtableClusterList";
    public const string KubeGroup = "bigtable.cnrm.cloud.google.com";
    public const string KubePluralName = "bigtableclusters";
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
    public IList<V1alpha1BigtableCluster> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Autoscaling limits for this cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableClusterSpecClusterConfigClusterAutoscalingConfigAutoscalingLimits
{
    /// <summary>Required. Maximum number of nodes to scale up to.</summary>
    [JsonPropertyName("maxServeNodes")]
    public int? MaxServeNodes { get; set; }

    /// <summary>Required. Minimum number of nodes to scale down to.</summary>
    [JsonPropertyName("minServeNodes")]
    public int? MinServeNodes { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Autoscaling targets for this cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableClusterSpecClusterConfigClusterAutoscalingConfigAutoscalingTargets
{
    /// <summary>The cpu utilization that the Autoscaler should be trying to achieve. This number is on a scale from 0 (no utilization) to 100 (total utilization), and is limited between 10 and 80, otherwise it will return INVALID_ARGUMENT error.</summary>
    [JsonPropertyName("cpuUtilizationPercent")]
    public int? CpuUtilizationPercent { get; set; }

    /// <summary>The storage utilization that the Autoscaler should be trying to achieve. This number is limited between 2560 (2.5TiB) and 5120 (5TiB) for a SSD cluster and between 8192 (8TiB) and 16384 (16TiB) for an HDD cluster, otherwise it will return INVALID_ARGUMENT error. If this value is set to 0, it will be treated as if it were set to the default value: 2560 for SSD, 8192 for HDD.</summary>
    [JsonPropertyName("storageUtilizationGiBPerNode")]
    public int? StorageUtilizationGiBPerNode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Autoscaling configuration for this cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableClusterSpecClusterConfigClusterAutoscalingConfig
{
    /// <summary>Required. Autoscaling limits for this cluster.</summary>
    [JsonPropertyName("autoscalingLimits")]
    public V1alpha1BigtableClusterSpecClusterConfigClusterAutoscalingConfigAutoscalingLimits? AutoscalingLimits { get; set; }

    /// <summary>Required. Autoscaling targets for this cluster.</summary>
    [JsonPropertyName("autoscalingTargets")]
    public V1alpha1BigtableClusterSpecClusterConfigClusterAutoscalingConfigAutoscalingTargets? AutoscalingTargets { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for this cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableClusterSpecClusterConfig
{
    /// <summary>Autoscaling configuration for this cluster.</summary>
    [JsonPropertyName("clusterAutoscalingConfig")]
    public V1alpha1BigtableClusterSpecClusterConfigClusterAutoscalingConfig? ClusterAutoscalingConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Describes the Cloud KMS encryption key that will be used to protect the destination Bigtable cluster. The requirements for this key are: 1) The Cloud Bigtable service account associated with the project that contains this cluster must be granted the `cloudkms.cryptoKeyEncrypterDecrypter` role on the CMEK key. 2) Only regional keys can be used and the region of the CMEK key must match the region of the cluster. 3) All clusters within an instance must use the same CMEK key. Values are of the form `projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableClusterSpecEncryptionConfigKmsKeyRef
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
/// <summary>Immutable. The encryption configuration for CMEK-protected clusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableClusterSpecEncryptionConfig
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect the destination Bigtable cluster. The requirements for this key are: 1) The Cloud Bigtable service account associated with the project that contains this cluster must be granted the `cloudkms.cryptoKeyEncrypterDecrypter` role on the CMEK key. 2) Only regional keys can be used and the region of the CMEK key must match the region of the cluster. 3) All clusters within an instance must use the same CMEK key. Values are of the form `projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}`</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1BigtableClusterSpecEncryptionConfigKmsKeyRef? KmsKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>InstanceRef defines the resource reference to BigtableInstance, which "External" field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableClusterSpecInstanceRef
{
    /// <summary>A reference to an externally managed BigtableInstance resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BigtableInstance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BigtableInstance resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BigtableClusterSpec defines the desired state of BigtableCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableClusterSpec
{
    /// <summary>Configuration for this cluster.</summary>
    [JsonPropertyName("clusterConfig")]
    public V1alpha1BigtableClusterSpecClusterConfig? ClusterConfig { get; set; }

    /// <summary>Immutable. The type of storage used by this cluster to serve its parent instance's tables, unless explicitly overridden.</summary>
    [JsonPropertyName("defaultStorageType")]
    public string? DefaultStorageType { get; set; }

    /// <summary>Immutable. The encryption configuration for CMEK-protected clusters.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1alpha1BigtableClusterSpecEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>InstanceRef defines the resource reference to BigtableInstance, which "External" field holds the GCP identifier for the KRM object.</summary>
    [JsonPropertyName("instanceRef")]
    public V1alpha1BigtableClusterSpecInstanceRef InstanceRef { get; set; }

    /// <summary>Immutable. The location where this cluster's nodes and storage reside. For best performance, clients should be located as close as possible to this cluster. Currently only zones are supported, so values should be of the form `projects/{project}/locations/{zone}`.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Immutable. The node scaling factor of this cluster.</summary>
    [JsonPropertyName("nodeScalingFactor")]
    public string? NodeScalingFactor { get; set; }

    /// <summary>The BigtableCluster name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The number of nodes allocated to this cluster. More nodes enable higher throughput and more consistent performance.</summary>
    [JsonPropertyName("serveNodes")]
    public int? ServeNodes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableClusterStatusConditions
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
public partial class V1alpha1BigtableClusterStatusObservedState
{
    /// <summary>Output only. The current state of the cluster.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BigtableClusterStatus defines the config connector machine state of BigtableCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigtableClusterStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigtableClusterStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigtableCluster resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BigtableClusterStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BigtableCluster is the Schema for the BigtableCluster API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigtableCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigtableClusterSpec>, IStatus<V1alpha1BigtableClusterStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigtableCluster";
    public const string KubeGroup = "bigtable.cnrm.cloud.google.com";
    public const string KubePluralName = "bigtableclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigtableClusterSpec defines the desired state of BigtableCluster</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BigtableClusterSpec Spec { get; set; }

    /// <summary>BigtableClusterStatus defines the config connector machine state of BigtableCluster</summary>
    [JsonPropertyName("status")]
    public V1alpha1BigtableClusterStatus? Status { get; set; }
}
#nullable disable
