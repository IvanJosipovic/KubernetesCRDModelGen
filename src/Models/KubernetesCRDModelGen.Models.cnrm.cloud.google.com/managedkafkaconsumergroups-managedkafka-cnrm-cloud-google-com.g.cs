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
/// <summary>ManagedKafkaConsumerGroup is the Schema for the ManagedKafkaConsumerGroup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ManagedKafkaConsumerGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ManagedKafkaConsumerGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ManagedKafkaConsumerGroupList";
    public const string KubeGroup = "managedkafka.cnrm.cloud.google.com";
    public const string KubePluralName = "managedkafkaconsumergroups";
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
    public IList<V1alpha1ManagedKafkaConsumerGroup> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ClusterRef defines the resource reference to ManagedKafkaCluster, which "External" field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConsumerGroupSpecClusterRef
{
    /// <summary>A reference to an externally managed ManagedKafkaCluster resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/clusters/{{clusterID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ManagedKafkaCluster resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ManagedKafkaCluster resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConsumerGroupSpecProjectRef
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
/// <summary>ManagedKafkaConsumerGroupSpec defines the desired state of ManagedKafkaConsumerGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConsumerGroupSpec
{
    /// <summary>ClusterRef defines the resource reference to ManagedKafkaCluster, which "External" field holds the GCP identifier for the KRM object.</summary>
    [JsonPropertyName("clusterRef")]
    public V1alpha1ManagedKafkaConsumerGroupSpecClusterRef ClusterRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1ManagedKafkaConsumerGroupSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The ManagedKafkaConsumerGroup name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConsumerGroupStatusConditions
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
public partial class V1alpha1ManagedKafkaConsumerGroupStatusObservedStateTopicsPartitions
{
    /// <summary>Required. Key of the partition index for topic metadata in this consumer group.</summary>
    [JsonPropertyName("key")]
    public int Key { get; set; }

    /// <summary>Optional. The associated metadata for this partition, or empty if it does not exist.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>Required. The current offset for this partition, or 0 if no offset has been committed.</summary>
    [JsonPropertyName("offset")]
    public long Offset { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConsumerGroupStatusObservedStateTopics
{
    /// <summary>Optional. Metadata for this consumer group and topic for all partition indexes it has metadata for.</summary>
    [JsonPropertyName("partitions")]
    public IList<V1alpha1ManagedKafkaConsumerGroupStatusObservedStateTopicsPartitions>? Partitions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConsumerGroupStatusObservedState
{
    /// <summary>Optional. Metadata for this consumer group for all topics it has metadata for. The key of the map is a topic name, structured like: projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}</summary>
    [JsonPropertyName("topics")]
    public IDictionary<string, V1alpha1ManagedKafkaConsumerGroupStatusObservedStateTopics>? Topics { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ManagedKafkaConsumerGroupStatus defines the config connector machine state of ManagedKafkaConsumerGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaConsumerGroupStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ManagedKafkaConsumerGroupStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ManagedKafkaConsumerGroup resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ManagedKafkaConsumerGroupStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ManagedKafkaConsumerGroup is the Schema for the ManagedKafkaConsumerGroup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ManagedKafkaConsumerGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ManagedKafkaConsumerGroupSpec>, IStatus<V1alpha1ManagedKafkaConsumerGroupStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ManagedKafkaConsumerGroup";
    public const string KubeGroup = "managedkafka.cnrm.cloud.google.com";
    public const string KubePluralName = "managedkafkaconsumergroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagedKafkaConsumerGroupSpec defines the desired state of ManagedKafkaConsumerGroup</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ManagedKafkaConsumerGroupSpec Spec { get; set; }

    /// <summary>ManagedKafkaConsumerGroupStatus defines the config connector machine state of ManagedKafkaConsumerGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1ManagedKafkaConsumerGroupStatus? Status { get; set; }
}
#nullable disable
