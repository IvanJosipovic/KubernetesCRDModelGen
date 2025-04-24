using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pubsub.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionMetadata
{
}

/// <summary>The name of the table to which to write data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionSpecBigqueryConfigTableRef
{
    /// <summary>Allowed value: string of the format `{{project}}.{{dataset_id}}.{{value}}`, where {{value}} is the `name` field of a `BigQueryTable` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>If delivery to BigQuery is used with this subscription, this field is used to configure it. Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined. If all three are empty, then the subscriber will pull and ack messages using API methods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionSpecBigqueryConfig
{
    /// <summary>When true and useTopicSchema is true, any fields that are a part of the topic schema that are not part of the BigQuery table schema are dropped when writing to BigQuery. Otherwise, the schemas must be kept in sync and any messages with extra fields are not written and remain in the subscription's backlog.</summary>
    [JsonPropertyName("dropUnknownFields")]
    public bool? DropUnknownFields { get; set; }

    /// <summary>The name of the table to which to write data.</summary>
    [JsonPropertyName("tableRef")]
    public PubSubSubscriptionSpecBigqueryConfigTableRef TableRef { get; set; }

    /// <summary>When true, use the topic's schema as the columns to write to in BigQuery, if it exists.</summary>
    [JsonPropertyName("useTopicSchema")]
    public bool? UseTopicSchema { get; set; }

    /// <summary>When true, write the subscription name, messageId, publishTime, attributes, and orderingKey to additional columns in the table. The subscription name, messageId, and publishTime fields are put in their own columns while all other message properties (other than data) are written to a JSON object in the attributes column.</summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary>If set, message data will be written to Cloud Storage in Avro format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionSpecCloudStorageConfigAvroConfig
{
    /// <summary>When true, write the subscription name, messageId, publishTime, attributes, and orderingKey as additional fields in the output.</summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary>User-provided name for the Cloud Storage bucket. The bucket must be created by the user. The bucket name must be without any prefix like "gs://".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionSpecCloudStorageConfigBucketRef
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

/// <summary>If delivery to Cloud Storage is used with this subscription, this field is used to configure it. Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined. If all three are empty, then the subscriber will pull and ack messages using API methods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionSpecCloudStorageConfig
{
    /// <summary>If set, message data will be written to Cloud Storage in Avro format.</summary>
    [JsonPropertyName("avroConfig")]
    public PubSubSubscriptionSpecCloudStorageConfigAvroConfig? AvroConfig { get; set; }

    /// <summary>User-provided name for the Cloud Storage bucket. The bucket must be created by the user. The bucket name must be without any prefix like "gs://".</summary>
    [JsonPropertyName("bucketRef")]
    public PubSubSubscriptionSpecCloudStorageConfigBucketRef BucketRef { get; set; }

    /// <summary>User-provided prefix for Cloud Storage filename.</summary>
    [JsonPropertyName("filenamePrefix")]
    public string? FilenamePrefix { get; set; }

    /// <summary>User-provided suffix for Cloud Storage filename. Must not end in "/".</summary>
    [JsonPropertyName("filenameSuffix")]
    public string? FilenameSuffix { get; set; }

    /// <summary>The maximum bytes that can be written to a Cloud Storage file before a new file is created. Min 1 KB, max 10 GiB. The maxBytes limit may be exceeded in cases where messages are larger than the limit.</summary>
    [JsonPropertyName("maxBytes")]
    public int? MaxBytes { get; set; }

    /// <summary>The maximum duration that can elapse before a new Cloud Storage file is created. Min 1 minute, max 10 minutes, default 5 minutes. May not exceed the subscription's acknowledgement deadline. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }

    /// <summary>An output-only field that indicates whether or not the subscription can receive messages.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionSpecDeadLetterPolicyDeadLetterTopicRef
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

/// <summary>A policy that specifies the conditions for dead lettering messages in this subscription. If dead_letter_policy is not set, dead lettering is disabled.  The Cloud Pub/Sub service account associated with this subscription's parent project (i.e., service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have permission to Acknowledge() messages on this subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionSpecDeadLetterPolicy
{
    /// <summary></summary>
    [JsonPropertyName("deadLetterTopicRef")]
    public PubSubSubscriptionSpecDeadLetterPolicyDeadLetterTopicRef? DeadLetterTopicRef { get; set; }

    /// <summary>The maximum number of delivery attempts for any message. The value must be between 5 and 100.  The number of delivery attempts is defined as 1 + (the sum of number of NACKs and number of times the acknowledgement deadline has been exceeded for the message).  A NACK is any call to ModifyAckDeadline with a 0 deadline. Note that client libraries may automatically extend ack_deadlines.  This field will be honored on a best effort basis.  If this parameter is 0, a default value of 5 is used.</summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public int? MaxDeliveryAttempts { get; set; }
}

/// <summary>A policy that specifies the conditions for this subscription's expiration. A subscription is considered active as long as any connected subscriber is successfully consuming messages from the subscription or is issuing operations on the subscription. If expirationPolicy is not set, a default policy with ttl of 31 days will be used.  If it is set but ttl is "", the resource never expires.  The minimum allowed value for expirationPolicy.ttl is 1 day.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionSpecExpirationPolicy
{
    /// <summary>Specifies the "time-to-live" duration for an associated resource. The resource expires if it is not active for a period of ttl. If ttl is set to "", the associated resource never expires. A duration in seconds with up to nine fractional digits, terminated by 's'. Example - "3.5s".</summary>
    [JsonPropertyName("ttl")]
    public string Ttl { get; set; }
}

/// <summary>When set, the payload to the push endpoint is not wrapped.Sets the 'data' field as the HTTP body for delivery.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionSpecPushConfigNoWrapper
{
    /// <summary>When true, writes the Pub/Sub message metadata to 'x-goog-pubsub-&lt;KEY&gt;:&lt;VAL&gt;' headers of the HTTP request. Writes the Pub/Sub message attributes to '&lt;KEY&gt;:&lt;VAL&gt;' headers of the HTTP request.</summary>
    [JsonPropertyName("writeMetadata")]
    public bool WriteMetadata { get; set; }
}

/// <summary>If specified, Pub/Sub will generate and attach an OIDC JWT token as an Authorization header in the HTTP request for every pushed message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionSpecPushConfigOidcToken
{
    /// <summary>Audience to be used when generating OIDC token. The audience claim identifies the recipients that the JWT is intended for. The audience value is a single case-sensitive string. Having multiple values (array) for the audience field is not supported. More info about the OIDC JWT token audience here: https://tools.ietf.org/html/rfc7519#section-4.1.3 Note: if not specified, the Push endpoint URL will be used.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>Service account email to be used for generating the OIDC token. The caller (for subscriptions.create, subscriptions.patch, and subscriptions.modifyPushConfig RPCs) must have the iam.serviceAccounts.actAs permission for the service account.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string ServiceAccountEmail { get; set; }
}

/// <summary>If push delivery is used with this subscription, this field is used to configure it. An empty pushConfig signifies that the subscriber will pull and ack messages using API methods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionSpecPushConfig
{
    /// <summary>Endpoint configuration attributes.  Every endpoint has a set of API supported attributes that can be used to control different aspects of the message delivery.  The currently supported attribute is x-goog-version, which you can use to change the format of the pushed message. This attribute indicates the version of the data expected by the endpoint. This controls the shape of the pushed message (i.e., its fields and metadata). The endpoint version is based on the version of the Pub/Sub API.  If not present during the subscriptions.create call, it will default to the version of the API used to make such call. If not present during a subscriptions.modifyPushConfig call, its value will not be changed. subscriptions.get calls will always return a valid version, even if the subscription was created without this attribute.  The possible values for this attribute are:  - v1beta1: uses the push format defined in the v1beta1 Pub/Sub API. - v1 or v1beta2: uses the push format defined in the v1 Pub/Sub API.</summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>When set, the payload to the push endpoint is not wrapped.Sets the 'data' field as the HTTP body for delivery.</summary>
    [JsonPropertyName("noWrapper")]
    public PubSubSubscriptionSpecPushConfigNoWrapper? NoWrapper { get; set; }

    /// <summary>If specified, Pub/Sub will generate and attach an OIDC JWT token as an Authorization header in the HTTP request for every pushed message.</summary>
    [JsonPropertyName("oidcToken")]
    public PubSubSubscriptionSpecPushConfigOidcToken? OidcToken { get; set; }

    /// <summary>A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint might use "https://example.com/push".</summary>
    [JsonPropertyName("pushEndpoint")]
    public string PushEndpoint { get; set; }
}

/// <summary>A policy that specifies how Pub/Sub retries message delivery for this subscription.  If not set, the default retry policy is applied. This generally implies that messages will be retried as soon as possible for healthy subscribers. RetryPolicy will be triggered on NACKs or acknowledgement deadline exceeded events for a given message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionSpecRetryPolicy
{
    /// <summary>The maximum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 600 seconds. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("maximumBackoff")]
    public string? MaximumBackoff { get; set; }

    /// <summary>The minimum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 10 seconds. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("minimumBackoff")]
    public string? MinimumBackoff { get; set; }
}

/// <summary>Reference to a PubSubTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionSpecTopicRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionSpec
{
    /// <summary>This value is the maximum time after a subscriber receives a message before the subscriber should acknowledge the message. After message delivery but before the ack deadline expires and before the message is acknowledged, it is an outstanding message and will not be delivered again during that time (on a best-effort basis).  For pull subscriptions, this value is used as the initial value for the ack deadline. To override this value for a given message, call subscriptions.modifyAckDeadline with the corresponding ackId if using pull. The minimum custom deadline you can specify is 10 seconds. The maximum custom deadline you can specify is 600 seconds (10 minutes). If this parameter is 0, a default value of 10 seconds is used.  For push delivery, this value is also used to set the request timeout for the call to the push endpoint.  If the subscriber never acknowledges the message, the Pub/Sub system will eventually redeliver the message.</summary>
    [JsonPropertyName("ackDeadlineSeconds")]
    public int? AckDeadlineSeconds { get; set; }

    /// <summary>If delivery to BigQuery is used with this subscription, this field is used to configure it. Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined. If all three are empty, then the subscriber will pull and ack messages using API methods.</summary>
    [JsonPropertyName("bigqueryConfig")]
    public PubSubSubscriptionSpecBigqueryConfig? BigqueryConfig { get; set; }

    /// <summary>If delivery to Cloud Storage is used with this subscription, this field is used to configure it. Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined. If all three are empty, then the subscriber will pull and ack messages using API methods.</summary>
    [JsonPropertyName("cloudStorageConfig")]
    public PubSubSubscriptionSpecCloudStorageConfig? CloudStorageConfig { get; set; }

    /// <summary>A policy that specifies the conditions for dead lettering messages in this subscription. If dead_letter_policy is not set, dead lettering is disabled.  The Cloud Pub/Sub service account associated with this subscription's parent project (i.e., service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have permission to Acknowledge() messages on this subscription.</summary>
    [JsonPropertyName("deadLetterPolicy")]
    public PubSubSubscriptionSpecDeadLetterPolicy? DeadLetterPolicy { get; set; }

    /// <summary>If 'true', Pub/Sub provides the following guarantees for the delivery of a message with a given value of messageId on this Subscriptions':  - The message sent to a subscriber is guaranteed not to be resent before the message's acknowledgement deadline expires.  - An acknowledged message will not be resent to a subscriber.  Note that subscribers may still receive multiple copies of a message when 'enable_exactly_once_delivery' is true if the message was published multiple times by a publisher client. These copies are considered distinct by Pub/Sub and have distinct messageId values.</summary>
    [JsonPropertyName("enableExactlyOnceDelivery")]
    public bool? EnableExactlyOnceDelivery { get; set; }

    /// <summary>Immutable. If 'true', messages published with the same orderingKey in PubsubMessage will be delivered to the subscribers in the order in which they are received by the Pub/Sub system. Otherwise, they may be delivered in any order.</summary>
    [JsonPropertyName("enableMessageOrdering")]
    public bool? EnableMessageOrdering { get; set; }

    /// <summary>A policy that specifies the conditions for this subscription's expiration. A subscription is considered active as long as any connected subscriber is successfully consuming messages from the subscription or is issuing operations on the subscription. If expirationPolicy is not set, a default policy with ttl of 31 days will be used.  If it is set but ttl is "", the resource never expires.  The minimum allowed value for expirationPolicy.ttl is 1 day.</summary>
    [JsonPropertyName("expirationPolicy")]
    public PubSubSubscriptionSpecExpirationPolicy? ExpirationPolicy { get; set; }

    /// <summary>Immutable. The subscription only delivers the messages that match the filter. Pub/Sub automatically acknowledges the messages that don't match the filter. You can filter messages by their attributes. The maximum length of a filter is 256 bytes. After creating the subscription, you can't modify the filter.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>How long to retain unacknowledged messages in the subscription's backlog, from the moment a message is published. If retain_acked_messages is true, then this also configures the retention of acknowledged messages, and thus configures how far back in time a subscriptions.seek can be done. Defaults to 7 days. Cannot be more than 7 days ('"604800s"') or less than 10 minutes ('"600s"').  A duration in seconds with up to nine fractional digits, terminated by 's'. Example: '"600.5s"'.</summary>
    [JsonPropertyName("messageRetentionDuration")]
    public string? MessageRetentionDuration { get; set; }

    /// <summary>If push delivery is used with this subscription, this field is used to configure it. An empty pushConfig signifies that the subscriber will pull and ack messages using API methods.</summary>
    [JsonPropertyName("pushConfig")]
    public PubSubSubscriptionSpecPushConfig? PushConfig { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Indicates whether to retain acknowledged messages. If 'true', then messages are not expunged from the subscription's backlog, even if they are acknowledged, until they fall out of the messageRetentionDuration window.</summary>
    [JsonPropertyName("retainAckedMessages")]
    public bool? RetainAckedMessages { get; set; }

    /// <summary>A policy that specifies how Pub/Sub retries message delivery for this subscription.  If not set, the default retry policy is applied. This generally implies that messages will be retried as soon as possible for healthy subscribers. RetryPolicy will be triggered on NACKs or acknowledgement deadline exceeded events for a given message.</summary>
    [JsonPropertyName("retryPolicy")]
    public PubSubSubscriptionSpecRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Reference to a PubSubTopic.</summary>
    [JsonPropertyName("topicRef")]
    public PubSubSubscriptionSpecTopicRef TopicRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscriptionStatusConditions
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
public partial class PubSubSubscriptionStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<PubSubSubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class PubSubSubscription
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public PubSubSubscriptionMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public PubSubSubscriptionSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public PubSubSubscriptionStatus? Status { get; set; }
}