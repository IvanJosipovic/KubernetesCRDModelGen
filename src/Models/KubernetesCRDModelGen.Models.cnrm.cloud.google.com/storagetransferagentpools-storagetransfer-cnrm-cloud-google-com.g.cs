using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storagetransfer.cnrm.cloud.google.com;
public partial class V1alpha1StorageTransferAgentPoolSpecBandwidthLimit
{
    /// <summary>Bandwidth rate in megabytes per second, distributed across all the agents in the pool.</summary>
    [JsonPropertyName("limitMbps")]
    public string LimitMbps { get; set; }
}

public partial class V1alpha1StorageTransferAgentPoolSpecProjectRef
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

public partial class V1alpha1StorageTransferAgentPoolSpec
{
    /// <summary>Specifies the bandwidth limit details. If this field is unspecified, the default value is set as 'No Limit'.</summary>
    [JsonPropertyName("bandwidthLimit")]
    public V1alpha1StorageTransferAgentPoolSpecBandwidthLimit? BandwidthLimit { get; set; }

    /// <summary>Specifies the client-specified AgentPool description.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1StorageTransferAgentPoolSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

public partial class V1alpha1StorageTransferAgentPoolStatusConditions
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

public partial class V1alpha1StorageTransferAgentPoolStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1StorageTransferAgentPoolStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Specifies the state of the AgentPool.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1StorageTransferAgentPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1StorageTransferAgentPoolSpec>, IStatus<V1alpha1StorageTransferAgentPoolStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "StorageTransferAgentPool";
    public const string KubeGroup = "storagetransfer.cnrm.cloud.google.com";
    public const string KubePluralName = "storagetransferagentpools";
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
    public V1alpha1StorageTransferAgentPoolSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1StorageTransferAgentPoolStatus? Status { get; set; }
}