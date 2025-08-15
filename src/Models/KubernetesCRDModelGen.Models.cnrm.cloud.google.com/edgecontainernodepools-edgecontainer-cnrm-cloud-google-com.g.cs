using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.edgecontainer.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerNodePoolSpecClusterRef
{
    /// <summary>Allowed value: The `name` field of an `EdgeContainerCluster` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerNodePoolSpecLocalDiskEncryptionKmsKeyRef
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

/// <summary>Local disk encryption options. This field is only used when enabling CMEK support.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerNodePoolSpecLocalDiskEncryption
{
    /// <summary>The Cloud KMS CryptoKeyVersion currently in use for protecting node local disks. Only applicable if kmsKey is set.</summary>
    [JsonPropertyName("kmsKeyActiveVersion")]
    public string? KmsKeyActiveVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1EdgeContainerNodePoolSpecLocalDiskEncryptionKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Availability of the Cloud KMS CryptoKey. If not KEY_AVAILABLE, then nodes may go offline as they cannot access their local data. This can be caused by a lack of permissions to use the key, or if the key is disabled or deleted.</summary>
    [JsonPropertyName("kmsKeyState")]
    public string? KmsKeyState { get; set; }
}

/// <summary>Configuration for each node in the NodePool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerNodePoolSpecNodeConfig
{
    /// <summary>"The Kubernetes node labels".</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerNodePoolSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerNodePoolSpec
{
    /// <summary></summary>
    [JsonPropertyName("clusterRef")]
    public V1beta1EdgeContainerNodePoolSpecClusterRef ClusterRef { get; set; }

    /// <summary>Local disk encryption options. This field is only used when enabling CMEK support.</summary>
    [JsonPropertyName("localDiskEncryption")]
    public V1beta1EdgeContainerNodePoolSpecLocalDiskEncryption? LocalDiskEncryption { get; set; }

    /// <summary>Immutable. The location of the resource.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Only machines matching this filter will be allowed to join the node pool. The filtering language accepts strings like "name=&lt;name&gt;", and is documented in more detail in [AIP-160](https://google.aip.dev/160).</summary>
    [JsonPropertyName("machineFilter")]
    public string? MachineFilter { get; set; }

    /// <summary>Configuration for each node in the NodePool.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta1EdgeContainerNodePoolSpecNodeConfig? NodeConfig { get; set; }

    /// <summary>The number of nodes in the pool.</summary>
    [JsonPropertyName("nodeCount")]
    public int NodeCount { get; set; }

    /// <summary>Immutable. Name of the Google Distributed Cloud Edge zone where this node pool will be created. For example: 'us-central1-edge-customer-a'.</summary>
    [JsonPropertyName("nodeLocation")]
    public string NodeLocation { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1EdgeContainerNodePoolSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerNodePoolStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerNodePoolStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EdgeContainerNodePoolStatusConditions>? Conditions { get; set; }

    /// <summary>The time when the node pool was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The lowest release version among all worker nodes.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The time when the node pool was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EdgeContainerNodePool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EdgeContainerNodePoolSpec>, IStatus<V1beta1EdgeContainerNodePoolStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EdgeContainerNodePool";
    public const string KubeGroup = "edgecontainer.cnrm.cloud.google.com";
    public const string KubePluralName = "edgecontainernodepools";
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
    public V1beta1EdgeContainerNodePoolSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1EdgeContainerNodePoolStatus? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EdgeContainerNodePoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta1EdgeContainerNodePool>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EdgeContainerNodePoolList";
    public const string KubeGroup = "edgecontainer.cnrm.cloud.google.com";
    public const string KubePluralName = "edgecontainernodepools";
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
    public IList<V1beta1EdgeContainerNodePool> Items { get; set; }
}