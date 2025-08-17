using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pubsub.cnrm.cloud.google.com;
#nullable enable
/// <summary>PubSubSnapshot is the Schema for the PubSubSnapshot API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PubSubSnapshotList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1PubSubSnapshot>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PubSubSnapshotList";
    public const string KubeGroup = "pubsub.cnrm.cloud.google.com";
    public const string KubePluralName = "pubsubsnapshots";
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
    public IList<V1alpha1PubSubSnapshot> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PubSubSnapshotSpecProjectRef
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
/// <summary>The subscription whose backlog the snapshot retains. Specifically, the created snapshot is guaranteed to retain: (a) The existing backlog on the subscription. More precisely, this is defined as the messages in the subscription's backlog that are unacknowledged upon the successful completion of the snapshots.create request; as well as: (b) Any messages published to the subscription's topic following the successful completion of the snapshots.create request. Format is projects/{project}/subscriptions/{sub}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PubSubSnapshotSpecPubSubSubscriptionRef
{
    /// <summary>A reference to an externally managed PubSubSubscription resource. Should be in the format "projects/{{projectID}}/subscriptions/{{subscriptionID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a PubSubSubscription resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a PubSubSubscription resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The name of the topic from which this snapshot is retaining messages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PubSubSnapshotSpecTopicRef
{
    /// <summary>A reference to an externally managed PubSubTopic resource. Should be in the format "projects/{{projectID}}/topics/{{topicID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a PubSubTopic resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a PubSubTopic resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PubSubSnapshotSpec defines the desired state of PubSubSnapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PubSubSnapshotSpec
{
    /// <summary>Optional. The snapshot is guaranteed to exist up until this time. A newly-created snapshot expires no later than 7 days from the time of its creation. Its exact lifetime is determined at creation by the existing backlog in the source subscription. Specifically, the lifetime of the snapshot is `7 days - (age of oldest unacked message in the subscription)`. For example, consider a subscription whose oldest unacked message is 3 days old. If a snapshot is created from this subscription, the snapshot -- which will always capture this 3-day-old backlog as long as the snapshot exists -- will expire in 4 days. The service will refuse to create a snapshot that would expire in less than 1 hour after creation.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Optional. See [Creating and managing labels] (https://cloud.google.com/pubsub/docs/labels).</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1PubSubSnapshotSpecProjectRef ProjectRef { get; set; }

    /// <summary>The subscription whose backlog the snapshot retains. Specifically, the created snapshot is guaranteed to retain: (a) The existing backlog on the subscription. More precisely, this is defined as the messages in the subscription's backlog that are unacknowledged upon the successful completion of the snapshots.create request; as well as: (b) Any messages published to the subscription's topic following the successful completion of the snapshots.create request. Format is projects/{project}/subscriptions/{sub}.</summary>
    [JsonPropertyName("pubSubSubscriptionRef")]
    public V1alpha1PubSubSnapshotSpecPubSubSubscriptionRef PubSubSubscriptionRef { get; set; }

    /// <summary>The PubSubSnapshot name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The name of the topic from which this snapshot is retaining messages.</summary>
    [JsonPropertyName("topicRef")]
    public V1alpha1PubSubSnapshotSpecTopicRef? TopicRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PubSubSnapshotStatusConditions
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
public partial class V1alpha1PubSubSnapshotStatusObservedState
{
}
#nullable disable

#nullable enable
/// <summary>PubSubSnapshotStatus defines the config connector machine state of PubSubSnapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PubSubSnapshotStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1PubSubSnapshotStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the PubSubSnapshot resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1PubSubSnapshotStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PubSubSnapshot is the Schema for the PubSubSnapshot API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PubSubSnapshot : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1PubSubSnapshotSpec>, IStatus<V1alpha1PubSubSnapshotStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PubSubSnapshot";
    public const string KubeGroup = "pubsub.cnrm.cloud.google.com";
    public const string KubePluralName = "pubsubsnapshots";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PubSubSnapshotSpec defines the desired state of PubSubSnapshot</summary>
    [JsonPropertyName("spec")]
    public V1alpha1PubSubSnapshotSpec Spec { get; set; }

    /// <summary>PubSubSnapshotStatus defines the config connector machine state of PubSubSnapshot</summary>
    [JsonPropertyName("status")]
    public V1alpha1PubSubSnapshotStatus? Status { get; set; }
}
#nullable disable
