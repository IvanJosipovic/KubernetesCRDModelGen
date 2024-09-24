using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.healthcare.cnrm.cloud.google.com;
public partial class V1alpha1HealthcareHL7V2StoreSpecNotificationConfig
{
    /// <summary>The Cloud Pub/Sub topic that notifications of changes are published on. Supplied by the client. PubsubMessage.Data will contain the resource name. PubsubMessage.MessageId is the ID of this message. It is guaranteed to be unique within the topic. PubsubMessage.PublishTime is the time at which the message was published. Notifications are only sent if the topic is non-empty. Topic names must be scoped to a project. service-PROJECT_NUMBER@gcp-sa-healthcare.iam.gserviceaccount.com must have publisher permissions on the given Cloud Pub/Sub topic. Not having adequate permissions will cause the calls that send notifications to fail.</summary>
    [JsonPropertyName("pubsubTopic")]
    public string PubsubTopic { get; set; }
}

public partial class V1alpha1HealthcareHL7V2StoreSpecNotificationConfigs
{
    /// <summary>Restricts notifications sent for messages matching a filter. If this is empty, all messages are matched. Syntax: https://cloud.google.com/appengine/docs/standard/python/search/query_strings  Fields/functions available for filtering are:  * messageType, from the MSH-9.1 field. For example, NOT messageType = "ADT". * send_date or sendDate, the YYYY-MM-DD date the message was sent in the dataset's timeZone, from the MSH-7 segment. For example, send_date &lt; "2017-01-02". * sendTime, the timestamp when the message was sent, using the RFC3339 time format for comparisons, from the MSH-7 segment. For example, sendTime &lt; "2017-01-02T00:00:00-05:00". * sendFacility, the care center that the message came from, from the MSH-4 segment. For example, sendFacility = "ABC". * PatientId(value, type), which matches if the message lists a patient having an ID of the given value and type in the PID-2, PID-3, or PID-4 segments. For example, PatientId("123456", "MRN"). * labels.x, a string value of the label with key x as set using the Message.labels map. For example, labels."priority"="high". The operator :* can be used to assert the existence of a label. For example, labels."priority":*.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The Cloud Pub/Sub topic that notifications of changes are published on. Supplied by the client. PubsubMessage.Data will contain the resource name. PubsubMessage.MessageId is the ID of this message. It is guaranteed to be unique within the topic. PubsubMessage.PublishTime is the time at which the message was published. Notifications are only sent if the topic is non-empty. Topic names must be scoped to a project. service-PROJECT_NUMBER@gcp-sa-healthcare.iam.gserviceaccount.com must have publisher permissions on the given Cloud Pub/Sub topic. Not having adequate permissions will cause the calls that send notifications to fail.  If a notification cannot be published to Cloud Pub/Sub, errors will be logged to Stackdriver.</summary>
    [JsonPropertyName("pubsubTopic")]
    public string PubsubTopic { get; set; }
}

public partial class V1alpha1HealthcareHL7V2StoreSpecParserConfig
{
    /// <summary>Determines whether messages with no header are allowed.</summary>
    [JsonPropertyName("allowNullHeader")]
    public bool? AllowNullHeader { get; set; }

    /// <summary>JSON encoded string for schemas used to parse messages in this store if schematized parsing is desired.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Byte(s) to be used as the segment terminator. If this is unset, '\r' will be used as segment terminator.  A base64-encoded string.</summary>
    [JsonPropertyName("segmentTerminator")]
    public string? SegmentTerminator { get; set; }

    /// <summary>Immutable. The version of the unschematized parser to be used when a custom 'schema' is not set. Default value: "V1" Possible values: ["V1", "V2", "V3"].</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1alpha1HealthcareHL7V2StoreSpec
{
    /// <summary>Immutable. Identifies the dataset addressed by this request. Must be in the format 'projects/{project}/locations/{location}/datasets/{dataset}'.</summary>
    [JsonPropertyName("dataset")]
    public string Dataset { get; set; }

    /// <summary>DEPRECATED. `notification_config` is deprecated. Use `notification_configs` instead. A nested object resource.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1alpha1HealthcareHL7V2StoreSpecNotificationConfig? NotificationConfig { get; set; }

    /// <summary>A list of notification configs. Each configuration uses a filter to determine whether to publish a message (both Ingest &amp; Create) on the corresponding notification destination. Only the message name is sent as part of the notification. Supplied by the client.</summary>
    [JsonPropertyName("notificationConfigs")]
    public IList<V1alpha1HealthcareHL7V2StoreSpecNotificationConfigs>? NotificationConfigs { get; set; }

    /// <summary>A nested object resource.</summary>
    [JsonPropertyName("parserConfig")]
    public V1alpha1HealthcareHL7V2StoreSpecParserConfig? ParserConfig { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

public partial class V1alpha1HealthcareHL7V2StoreStatusConditions
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

public partial class V1alpha1HealthcareHL7V2StoreStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1HealthcareHL7V2StoreStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The fully qualified name of this dataset.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1HealthcareHL7V2Store : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1HealthcareHL7V2StoreSpec>, IStatus<V1alpha1HealthcareHL7V2StoreStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "HealthcareHL7V2Store";
    public const string KubeGroup = "healthcare.cnrm.cloud.google.com";
    public const string KubePluralName = "healthcarehl7v2stores";
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
    public V1alpha1HealthcareHL7V2StoreSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1HealthcareHL7V2StoreStatus? Status { get; set; }
}