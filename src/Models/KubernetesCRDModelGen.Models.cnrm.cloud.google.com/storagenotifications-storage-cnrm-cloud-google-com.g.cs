using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.cnrm.cloud.google.com;
public partial class V1beta1StorageNotificationSpecBucketRef
{
    /// <summary>Allowed value: The `name` field of a `StorageBucket` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1StorageNotificationSpecTopicRef
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/topics/{{value}}`, where {{value}} is the `name` field of a `PubSubTopic` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1StorageNotificationSpec
{
    /// <summary></summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1StorageNotificationSpecBucketRef BucketRef { get; set; }

    /// <summary>Immutable.  A set of key/value attribute pairs to attach to each Cloud Pub/Sub message published for this notification subscription.</summary>
    [JsonPropertyName("customAttributes")]
    public IDictionary<string, string>? CustomAttributes { get; set; }

    /// <summary>Immutable. List of event type filters for this notification config. If not specified, Cloud Storage will send notifications for all event types. The valid types are: "OBJECT_FINALIZE", "OBJECT_METADATA_UPDATE", "OBJECT_DELETE", "OBJECT_ARCHIVE".</summary>
    [JsonPropertyName("eventTypes")]
    public IList<string>? EventTypes { get; set; }

    /// <summary>Immutable. Specifies a prefix path filter for this notification config. Cloud Storage will only send notifications for objects in this bucket whose names begin with the specified prefix.</summary>
    [JsonPropertyName("objectNamePrefix")]
    public string? ObjectNamePrefix { get; set; }

    /// <summary>Immutable. The desired content of the Payload. One of "JSON_API_V1" or "NONE".</summary>
    [JsonPropertyName("payloadFormat")]
    public string PayloadFormat { get; set; }

    /// <summary>Immutable. Optional. The service-generated notificationId of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topicRef")]
    public V1beta1StorageNotificationSpecTopicRef TopicRef { get; set; }
}

public partial class V1beta1StorageNotificationStatusConditions
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

public partial class V1beta1StorageNotificationStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StorageNotificationStatusConditions>? Conditions { get; set; }

    /// <summary>The ID of the created notification.</summary>
    [JsonPropertyName("notificationId")]
    public string? NotificationId { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StorageNotification : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StorageNotificationSpec>, IStatus<V1beta1StorageNotificationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageNotification";
    public const string KubeGroup = "storage.cnrm.cloud.google.com";
    public const string KubePluralName = "storagenotifications";
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
    public V1beta1StorageNotificationSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1StorageNotificationStatus? Status { get; set; }
}