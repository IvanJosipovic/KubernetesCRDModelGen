using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.managedkafka.cnrm.cloud.google.com;
/// <summary>ManagedKafkaTopic is the Schema for the ManagedKafkaTopic API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ManagedKafkaTopicList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ManagedKafkaTopic>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ManagedKafkaTopicList";
    public const string KubeGroup = "managedkafka.cnrm.cloud.google.com";
    public const string KubePluralName = "managedkafkatopics";
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
    public IList<V1beta1ManagedKafkaTopic> Items { get; set; }
}

/// <summary>Required. Reference to the Kafka cluster to create the topic in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaTopicSpecClusterRef
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

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaTopicSpecProjectRef
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

/// <summary>ManagedKafkaTopicSpec defines the desired state of ManagedKafkaTopic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaTopicSpec
{
    /// <summary>Required. Reference to the Kafka cluster to create the topic in.</summary>
    [JsonPropertyName("clusterRef")]
    public V1beta1ManagedKafkaTopicSpecClusterRef ClusterRef { get; set; }

    /// <summary>Optional. Configurations for the topic that are overridden from the cluster defaults. The key of the map is a Kafka topic property name, for example: `cleanup.policy`, `compression.type`.</summary>
    [JsonPropertyName("configs")]
    public IDictionary<string, string>? Configs { get; set; }

    /// <summary>Required. the location of the Kafka resource. See https://cloud.google.com/managed-kafka/docs/locations for a list of supported locations.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Required. The number of partitions this topic has. The partition count can only be increased, not decreased. Please note that if partitions are increased for a topic that has a key, the partitioning logic or the ordering of the messages will be affected.</summary>
    [JsonPropertyName("partitionCount")]
    public int PartitionCount { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ManagedKafkaTopicSpecProjectRef ProjectRef { get; set; }

    /// <summary>Required. Immutable. The number of replicas of each partition. A replication factor of 3 is recommended for high availability.</summary>
    [JsonPropertyName("replicationFactor")]
    public int ReplicationFactor { get; set; }

    /// <summary>The GCP resource identifier. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaTopicStatusConditions
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

/// <summary>ManagedKafkaTopicStatus defines the config connector machine state of ManagedKafkaTopic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ManagedKafkaTopicStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ManagedKafkaTopicStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ManagedKafkaTopic resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ManagedKafkaTopic is the Schema for the ManagedKafkaTopic API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ManagedKafkaTopic : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ManagedKafkaTopicSpec>, IStatus<V1beta1ManagedKafkaTopicStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ManagedKafkaTopic";
    public const string KubeGroup = "managedkafka.cnrm.cloud.google.com";
    public const string KubePluralName = "managedkafkatopics";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagedKafkaTopicSpec defines the desired state of ManagedKafkaTopic</summary>
    [JsonPropertyName("spec")]
    public V1beta1ManagedKafkaTopicSpec Spec { get; set; }

    /// <summary>ManagedKafkaTopicStatus defines the config connector machine state of ManagedKafkaTopic</summary>
    [JsonPropertyName("status")]
    public V1beta1ManagedKafkaTopicStatus? Status { get; set; }
}