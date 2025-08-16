using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pubsub.gcp.upbound.io;
/// <summary>Subscription is the Schema for the Subscriptions API. A named resource representing the stream of messages from a single, specific topic, to be delivered to the subscribing application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Subscription>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SubscriptionList";
    public const string KubeGroup = "pubsub.gcp.upbound.io";
    public const string KubePluralName = "subscriptions";
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
    public IList<V1beta1Subscription> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderBigqueryConfig
{
    /// <summary>When true and use_topic_schema or use_table_schema is true, any fields that are a part of the topic schema or message schema that are not part of the BigQuery table schema are dropped when writing to BigQuery. Otherwise, the schemas must be kept in sync and any messages with extra fields are not written and remain in the subscription's backlog.</summary>
    [JsonPropertyName("dropUnknownFields")]
    public bool? DropUnknownFields { get; set; }

    /// <summary>The name of the table to which to write data, of the form {projectId}:{datasetId}.{tableId}</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>When true, use the BigQuery table's schema as the columns to write to in BigQuery. Messages must be published in JSON format. Only one of use_topic_schema and use_table_schema can be set.</summary>
    [JsonPropertyName("useTableSchema")]
    public bool? UseTableSchema { get; set; }

    /// <summary>When true, use the topic's schema as the columns to write to in BigQuery, if it exists. Only one of use_topic_schema and use_table_schema can be set.</summary>
    [JsonPropertyName("useTopicSchema")]
    public bool? UseTopicSchema { get; set; }

    /// <summary>When true, write the subscription name, messageId, publishTime, attributes, and orderingKey to additional columns in the table. The subscription name, messageId, and publishTime fields are put in their own columns while all other message properties (other than data) are written to a JSON object in the attributes column.</summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderCloudStorageConfigAvroConfig
{
    /// <summary>When true, use the topic's schema as the columns to write to in BigQuery, if it exists. Only one of use_topic_schema and use_table_schema can be set.</summary>
    [JsonPropertyName("useTopicSchema")]
    public bool? UseTopicSchema { get; set; }

    /// <summary>When true, writes the Pub/Sub message metadata to x-goog-pubsub-&lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request. Writes the Pub/Sub message attributes to &lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request.</summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderCloudStorageConfig
{
    /// <summary>If set, message data will be written to Cloud Storage in Avro format. Structure is documented below.</summary>
    [JsonPropertyName("avroConfig")]
    public IList<V1beta1SubscriptionSpecForProviderCloudStorageConfigAvroConfig>? AvroConfig { get; set; }

    /// <summary>User-provided name for the Cloud Storage bucket. The bucket must be created by the user. The bucket name must be without any prefix like "gs://".</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>User-provided format string specifying how to represent datetimes in Cloud Storage filenames.</summary>
    [JsonPropertyName("filenameDatetimeFormat")]
    public string? FilenameDatetimeFormat { get; set; }

    /// <summary>User-provided prefix for Cloud Storage filename.</summary>
    [JsonPropertyName("filenamePrefix")]
    public string? FilenamePrefix { get; set; }

    /// <summary>User-provided suffix for Cloud Storage filename. Must not end in "/".</summary>
    [JsonPropertyName("filenameSuffix")]
    public string? FilenameSuffix { get; set; }

    /// <summary>The maximum bytes that can be written to a Cloud Storage file before a new file is created. Min 1 KB, max 10 GiB. The maxBytes limit may be exceeded in cases where messages are larger than the limit.</summary>
    [JsonPropertyName("maxBytes")]
    public double? MaxBytes { get; set; }

    /// <summary>The maximum duration that can elapse before a new Cloud Storage file is created. Min 1 minute, max 10 minutes, default 5 minutes. May not exceed the subscription's acknowledgement deadline. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }

    /// <summary>The maximum messages that can be written to a Cloud Storage file before a new file is created. Min 1000 messages.</summary>
    [JsonPropertyName("maxMessages")]
    public double? MaxMessages { get; set; }

    /// <summary>The service account to use to write to Cloud Storage. If not specified, the Pub/Sub service agent, service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com, is used.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta1SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta1SubscriptionSpecForProviderCloudStorageConfigServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate deadLetterTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate deadLetterTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderDeadLetterPolicy
{
    /// <summary>The name of the topic to which dead letter messages should be published. Format is projects/{project}/topics/{topic}. The Cloud Pub/Sub service account associated with the enclosing subscription's parent project (i.e., service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have permission to Publish() to this topic. The operation will fail if the topic does not exist. Users should ensure that there is a subscription attached to this topic since messages published to a topic with no subscriptions are lost.</summary>
    [JsonPropertyName("deadLetterTopic")]
    public string? DeadLetterTopic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate deadLetterTopic.</summary>
    [JsonPropertyName("deadLetterTopicRef")]
    public V1beta1SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicRef? DeadLetterTopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate deadLetterTopic.</summary>
    [JsonPropertyName("deadLetterTopicSelector")]
    public V1beta1SubscriptionSpecForProviderDeadLetterPolicyDeadLetterTopicSelector? DeadLetterTopicSelector { get; set; }

    /// <summary>The maximum number of delivery attempts for any message. The value must be between 5 and 100. The number of delivery attempts is defined as 1 + (the sum of number of NACKs and number of times the acknowledgement deadline has been exceeded for the message). A NACK is any call to ModifyAckDeadline with a 0 deadline. Note that client libraries may automatically extend ack_deadlines. This field will be honored on a best effort basis. If this parameter is 0, a default value of 5 is used.</summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public double? MaxDeliveryAttempts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderExpirationPolicy
{
    /// <summary>Specifies the "time-to-live" duration for an associated resource. The resource expires if it is not active for a period of ttl. If ttl is set to "", the associated resource never expires. A duration in seconds with up to nine fractional digits, terminated by 's'. Example - "3.5s".</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderMessageTransformsJavascriptUdf
{
    /// <summary>JavaScript code that contains a function function_name with the following signature:</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Name of the JavaScript function that should be applied to Pub/Sub messages.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderMessageTransforms
{
    /// <summary>Controls whether or not to use this transform. If not set or false, the transform will be applied to messages. Default: true.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Javascript User Defined Function. If multiple Javascript UDFs are specified on a resource, each one must have a unique function_name. Structure is documented below.</summary>
    [JsonPropertyName("javascriptUdf")]
    public IList<V1beta1SubscriptionSpecForProviderMessageTransformsJavascriptUdf>? JavascriptUdf { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderPushConfigNoWrapper
{
    /// <summary>When true, writes the Pub/Sub message metadata to x-goog-pubsub-&lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request. Writes the Pub/Sub message attributes to &lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request.</summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderPushConfigOidcToken
{
    /// <summary>Audience to be used when generating OIDC token. The audience claim identifies the recipients that the JWT is intended for. The audience value is a single case-sensitive string. Having multiple values (array) for the audience field is not supported. More info about the OIDC JWT token audience here: https://tools.ietf.org/html/rfc7519#section-4.1.3 Note: if not specified, the Push endpoint URL will be used.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>Service account email to be used for generating the OIDC token. The caller (for subscriptions.create, subscriptions.patch, and subscriptions.modifyPushConfig RPCs) must have the iam.serviceAccounts.actAs permission for the service account.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderPushConfig
{
    /// <summary>Endpoint configuration attributes. Every endpoint has a set of API supported attributes that can be used to control different aspects of the message delivery. The currently supported attribute is x-goog-version, which you can use to change the format of the pushed message. This attribute indicates the version of the data expected by the endpoint. This controls the shape of the pushed message (i.e., its fields and metadata). The endpoint version is based on the version of the Pub/Sub API. If not present during the subscriptions.create call, it will default to the version of the API used to make such call. If not present during a subscriptions.modifyPushConfig call, its value will not be changed. subscriptions.get calls will always return a valid version, even if the subscription was created without this attribute. The possible values for this attribute are:</summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>When set, the payload to the push endpoint is not wrapped.Sets the data field as the HTTP body for delivery. Structure is documented below.</summary>
    [JsonPropertyName("noWrapper")]
    public IList<V1beta1SubscriptionSpecForProviderPushConfigNoWrapper>? NoWrapper { get; set; }

    /// <summary>If specified, Pub/Sub will generate and attach an OIDC JWT token as an Authorization header in the HTTP request for every pushed message. Structure is documented below.</summary>
    [JsonPropertyName("oidcToken")]
    public IList<V1beta1SubscriptionSpecForProviderPushConfigOidcToken>? OidcToken { get; set; }

    /// <summary>A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint might use "https://example.com/push".</summary>
    [JsonPropertyName("pushEndpoint")]
    public string? PushEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderRetryPolicy
{
    /// <summary>The maximum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 600 seconds. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("maximumBackoff")]
    public string? MaximumBackoff { get; set; }

    /// <summary>The minimum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 10 seconds. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("minimumBackoff")]
    public string? MinimumBackoff { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderTopicRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecForProviderTopicRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderTopicSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProviderTopicSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecForProviderTopicSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecForProvider
{
    /// <summary>This value is the maximum time after a subscriber receives a message before the subscriber should acknowledge the message. After message delivery but before the ack deadline expires and before the message is acknowledged, it is an outstanding message and will not be delivered again during that time (on a best-effort basis). For pull subscriptions, this value is used as the initial value for the ack deadline. To override this value for a given message, call subscriptions.modifyAckDeadline with the corresponding ackId if using pull. The minimum custom deadline you can specify is 10 seconds. The maximum custom deadline you can specify is 600 seconds (10 minutes). If this parameter is 0, a default value of 10 seconds is used. For push delivery, this value is also used to set the request timeout for the call to the push endpoint. If the subscriber never acknowledges the message, the Pub/Sub system will eventually redeliver the message.</summary>
    [JsonPropertyName("ackDeadlineSeconds")]
    public double? AckDeadlineSeconds { get; set; }

    /// <summary>If delivery to BigQuery is used with this subscription, this field is used to configure it. Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined. If all three are empty, then the subscriber will pull and ack messages using API methods. Structure is documented below.</summary>
    [JsonPropertyName("bigqueryConfig")]
    public IList<V1beta1SubscriptionSpecForProviderBigqueryConfig>? BigqueryConfig { get; set; }

    /// <summary>If delivery to Cloud Storage is used with this subscription, this field is used to configure it. Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined. If all three are empty, then the subscriber will pull and ack messages using API methods. Structure is documented below.</summary>
    [JsonPropertyName("cloudStorageConfig")]
    public IList<V1beta1SubscriptionSpecForProviderCloudStorageConfig>? CloudStorageConfig { get; set; }

    /// <summary>A policy that specifies the conditions for dead lettering messages in this subscription. If dead_letter_policy is not set, dead lettering is disabled. The Cloud Pub/Sub service account associated with this subscription's parent project (i.e., service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have permission to Acknowledge() messages on this subscription. Structure is documented below.</summary>
    [JsonPropertyName("deadLetterPolicy")]
    public IList<V1beta1SubscriptionSpecForProviderDeadLetterPolicy>? DeadLetterPolicy { get; set; }

    /// <summary>If true, Pub/Sub provides the following guarantees for the delivery of a message with a given value of messageId on this Subscriptions':</summary>
    [JsonPropertyName("enableExactlyOnceDelivery")]
    public bool? EnableExactlyOnceDelivery { get; set; }

    /// <summary>If true, messages published with the same orderingKey in PubsubMessage will be delivered to the subscribers in the order in which they are received by the Pub/Sub system. Otherwise, they may be delivered in any order.</summary>
    [JsonPropertyName("enableMessageOrdering")]
    public bool? EnableMessageOrdering { get; set; }

    /// <summary>A policy that specifies the conditions for this subscription's expiration. A subscription is considered active as long as any connected subscriber is successfully consuming messages from the subscription or is issuing operations on the subscription. If expirationPolicy is not set, a default policy with ttl of 31 days will be used.  If it is set but ttl is "", the resource never expires.  The minimum allowed value for expirationPolicy.ttl is 1 day. Structure is documented below.</summary>
    [JsonPropertyName("expirationPolicy")]
    public IList<V1beta1SubscriptionSpecForProviderExpirationPolicy>? ExpirationPolicy { get; set; }

    /// <summary>The subscription only delivers the messages that match the filter. Pub/Sub automatically acknowledges the messages that don't match the filter. You can filter messages by their attributes. The maximum length of a filter is 256 bytes. After creating the subscription, you can't modify the filter.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>A set of key/value label pairs to assign to this Subscription.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>How long to retain unacknowledged messages in the subscription's backlog, from the moment a message is published. If retain_acked_messages is true, then this also configures the retention of acknowledged messages, and thus configures how far back in time a subscriptions.seek can be done. Defaults to 7 days. Cannot be more than 31 days ("2678400s") or less than 10 minutes ("600s"). A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "600.5s".</summary>
    [JsonPropertyName("messageRetentionDuration")]
    public string? MessageRetentionDuration { get; set; }

    /// <summary>Transforms to be applied to messages published to the topic. Transforms are applied in the order specified. Structure is documented below.</summary>
    [JsonPropertyName("messageTransforms")]
    public IList<V1beta1SubscriptionSpecForProviderMessageTransforms>? MessageTransforms { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>If push delivery is used with this subscription, this field is used to configure it. An empty pushConfig signifies that the subscriber will pull and ack messages using API methods. Structure is documented below.</summary>
    [JsonPropertyName("pushConfig")]
    public IList<V1beta1SubscriptionSpecForProviderPushConfig>? PushConfig { get; set; }

    /// <summary>Indicates whether to retain acknowledged messages. If true, then messages are not expunged from the subscription's backlog, even if they are acknowledged, until they fall out of the messageRetentionDuration window.</summary>
    [JsonPropertyName("retainAckedMessages")]
    public bool? RetainAckedMessages { get; set; }

    /// <summary>A policy that specifies how Pub/Sub retries message delivery for this subscription. If not set, the default retry policy is applied. This generally implies that messages will be retried as soon as possible for healthy subscribers. RetryPolicy will be triggered on NACKs or acknowledgement deadline exceeded events for a given message Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1SubscriptionSpecForProviderRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>A reference to a Topic resource, of the form projects/{project}/topics/{{name}} (as in the id property of a google_pubsub_topic), or just a topic name if the topic is in the same project as the subscription.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta1SubscriptionSpecForProviderTopicRef? TopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicSelector")]
    public V1beta1SubscriptionSpecForProviderTopicSelector? TopicSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderBigqueryConfig
{
    /// <summary>When true and use_topic_schema or use_table_schema is true, any fields that are a part of the topic schema or message schema that are not part of the BigQuery table schema are dropped when writing to BigQuery. Otherwise, the schemas must be kept in sync and any messages with extra fields are not written and remain in the subscription's backlog.</summary>
    [JsonPropertyName("dropUnknownFields")]
    public bool? DropUnknownFields { get; set; }

    /// <summary>The name of the table to which to write data, of the form {projectId}:{datasetId}.{tableId}</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>When true, use the BigQuery table's schema as the columns to write to in BigQuery. Messages must be published in JSON format. Only one of use_topic_schema and use_table_schema can be set.</summary>
    [JsonPropertyName("useTableSchema")]
    public bool? UseTableSchema { get; set; }

    /// <summary>When true, use the topic's schema as the columns to write to in BigQuery, if it exists. Only one of use_topic_schema and use_table_schema can be set.</summary>
    [JsonPropertyName("useTopicSchema")]
    public bool? UseTopicSchema { get; set; }

    /// <summary>When true, write the subscription name, messageId, publishTime, attributes, and orderingKey to additional columns in the table. The subscription name, messageId, and publishTime fields are put in their own columns while all other message properties (other than data) are written to a JSON object in the attributes column.</summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderCloudStorageConfigAvroConfig
{
    /// <summary>When true, use the topic's schema as the columns to write to in BigQuery, if it exists. Only one of use_topic_schema and use_table_schema can be set.</summary>
    [JsonPropertyName("useTopicSchema")]
    public bool? UseTopicSchema { get; set; }

    /// <summary>When true, writes the Pub/Sub message metadata to x-goog-pubsub-&lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request. Writes the Pub/Sub message attributes to &lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request.</summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderCloudStorageConfig
{
    /// <summary>If set, message data will be written to Cloud Storage in Avro format. Structure is documented below.</summary>
    [JsonPropertyName("avroConfig")]
    public IList<V1beta1SubscriptionSpecInitProviderCloudStorageConfigAvroConfig>? AvroConfig { get; set; }

    /// <summary>User-provided name for the Cloud Storage bucket. The bucket must be created by the user. The bucket name must be without any prefix like "gs://".</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>User-provided format string specifying how to represent datetimes in Cloud Storage filenames.</summary>
    [JsonPropertyName("filenameDatetimeFormat")]
    public string? FilenameDatetimeFormat { get; set; }

    /// <summary>User-provided prefix for Cloud Storage filename.</summary>
    [JsonPropertyName("filenamePrefix")]
    public string? FilenamePrefix { get; set; }

    /// <summary>User-provided suffix for Cloud Storage filename. Must not end in "/".</summary>
    [JsonPropertyName("filenameSuffix")]
    public string? FilenameSuffix { get; set; }

    /// <summary>The maximum bytes that can be written to a Cloud Storage file before a new file is created. Min 1 KB, max 10 GiB. The maxBytes limit may be exceeded in cases where messages are larger than the limit.</summary>
    [JsonPropertyName("maxBytes")]
    public double? MaxBytes { get; set; }

    /// <summary>The maximum duration that can elapse before a new Cloud Storage file is created. Min 1 minute, max 10 minutes, default 5 minutes. May not exceed the subscription's acknowledgement deadline. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }

    /// <summary>The maximum messages that can be written to a Cloud Storage file before a new file is created. Min 1000 messages.</summary>
    [JsonPropertyName("maxMessages")]
    public double? MaxMessages { get; set; }

    /// <summary>The service account to use to write to Cloud Storage. If not specified, the Pub/Sub service agent, service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com, is used.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta1SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta1SubscriptionSpecInitProviderCloudStorageConfigServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate deadLetterTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate deadLetterTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderDeadLetterPolicy
{
    /// <summary>The name of the topic to which dead letter messages should be published. Format is projects/{project}/topics/{topic}. The Cloud Pub/Sub service account associated with the enclosing subscription's parent project (i.e., service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have permission to Publish() to this topic. The operation will fail if the topic does not exist. Users should ensure that there is a subscription attached to this topic since messages published to a topic with no subscriptions are lost.</summary>
    [JsonPropertyName("deadLetterTopic")]
    public string? DeadLetterTopic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate deadLetterTopic.</summary>
    [JsonPropertyName("deadLetterTopicRef")]
    public V1beta1SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicRef? DeadLetterTopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate deadLetterTopic.</summary>
    [JsonPropertyName("deadLetterTopicSelector")]
    public V1beta1SubscriptionSpecInitProviderDeadLetterPolicyDeadLetterTopicSelector? DeadLetterTopicSelector { get; set; }

    /// <summary>The maximum number of delivery attempts for any message. The value must be between 5 and 100. The number of delivery attempts is defined as 1 + (the sum of number of NACKs and number of times the acknowledgement deadline has been exceeded for the message). A NACK is any call to ModifyAckDeadline with a 0 deadline. Note that client libraries may automatically extend ack_deadlines. This field will be honored on a best effort basis. If this parameter is 0, a default value of 5 is used.</summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public double? MaxDeliveryAttempts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderExpirationPolicy
{
    /// <summary>Specifies the "time-to-live" duration for an associated resource. The resource expires if it is not active for a period of ttl. If ttl is set to "", the associated resource never expires. A duration in seconds with up to nine fractional digits, terminated by 's'. Example - "3.5s".</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderMessageTransformsJavascriptUdf
{
    /// <summary>JavaScript code that contains a function function_name with the following signature:</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Name of the JavaScript function that should be applied to Pub/Sub messages.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderMessageTransforms
{
    /// <summary>Controls whether or not to use this transform. If not set or false, the transform will be applied to messages. Default: true.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Javascript User Defined Function. If multiple Javascript UDFs are specified on a resource, each one must have a unique function_name. Structure is documented below.</summary>
    [JsonPropertyName("javascriptUdf")]
    public IList<V1beta1SubscriptionSpecInitProviderMessageTransformsJavascriptUdf>? JavascriptUdf { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderPushConfigNoWrapper
{
    /// <summary>When true, writes the Pub/Sub message metadata to x-goog-pubsub-&lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request. Writes the Pub/Sub message attributes to &lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request.</summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderPushConfigOidcToken
{
    /// <summary>Audience to be used when generating OIDC token. The audience claim identifies the recipients that the JWT is intended for. The audience value is a single case-sensitive string. Having multiple values (array) for the audience field is not supported. More info about the OIDC JWT token audience here: https://tools.ietf.org/html/rfc7519#section-4.1.3 Note: if not specified, the Push endpoint URL will be used.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>Service account email to be used for generating the OIDC token. The caller (for subscriptions.create, subscriptions.patch, and subscriptions.modifyPushConfig RPCs) must have the iam.serviceAccounts.actAs permission for the service account.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderPushConfig
{
    /// <summary>Endpoint configuration attributes. Every endpoint has a set of API supported attributes that can be used to control different aspects of the message delivery. The currently supported attribute is x-goog-version, which you can use to change the format of the pushed message. This attribute indicates the version of the data expected by the endpoint. This controls the shape of the pushed message (i.e., its fields and metadata). The endpoint version is based on the version of the Pub/Sub API. If not present during the subscriptions.create call, it will default to the version of the API used to make such call. If not present during a subscriptions.modifyPushConfig call, its value will not be changed. subscriptions.get calls will always return a valid version, even if the subscription was created without this attribute. The possible values for this attribute are:</summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>When set, the payload to the push endpoint is not wrapped.Sets the data field as the HTTP body for delivery. Structure is documented below.</summary>
    [JsonPropertyName("noWrapper")]
    public IList<V1beta1SubscriptionSpecInitProviderPushConfigNoWrapper>? NoWrapper { get; set; }

    /// <summary>If specified, Pub/Sub will generate and attach an OIDC JWT token as an Authorization header in the HTTP request for every pushed message. Structure is documented below.</summary>
    [JsonPropertyName("oidcToken")]
    public IList<V1beta1SubscriptionSpecInitProviderPushConfigOidcToken>? OidcToken { get; set; }

    /// <summary>A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint might use "https://example.com/push".</summary>
    [JsonPropertyName("pushEndpoint")]
    public string? PushEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderRetryPolicy
{
    /// <summary>The maximum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 600 seconds. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("maximumBackoff")]
    public string? MaximumBackoff { get; set; }

    /// <summary>The minimum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 10 seconds. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("minimumBackoff")]
    public string? MinimumBackoff { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderTopicRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecInitProviderTopicRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderTopicSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProviderTopicSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecInitProviderTopicSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecInitProvider
{
    /// <summary>This value is the maximum time after a subscriber receives a message before the subscriber should acknowledge the message. After message delivery but before the ack deadline expires and before the message is acknowledged, it is an outstanding message and will not be delivered again during that time (on a best-effort basis). For pull subscriptions, this value is used as the initial value for the ack deadline. To override this value for a given message, call subscriptions.modifyAckDeadline with the corresponding ackId if using pull. The minimum custom deadline you can specify is 10 seconds. The maximum custom deadline you can specify is 600 seconds (10 minutes). If this parameter is 0, a default value of 10 seconds is used. For push delivery, this value is also used to set the request timeout for the call to the push endpoint. If the subscriber never acknowledges the message, the Pub/Sub system will eventually redeliver the message.</summary>
    [JsonPropertyName("ackDeadlineSeconds")]
    public double? AckDeadlineSeconds { get; set; }

    /// <summary>If delivery to BigQuery is used with this subscription, this field is used to configure it. Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined. If all three are empty, then the subscriber will pull and ack messages using API methods. Structure is documented below.</summary>
    [JsonPropertyName("bigqueryConfig")]
    public IList<V1beta1SubscriptionSpecInitProviderBigqueryConfig>? BigqueryConfig { get; set; }

    /// <summary>If delivery to Cloud Storage is used with this subscription, this field is used to configure it. Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined. If all three are empty, then the subscriber will pull and ack messages using API methods. Structure is documented below.</summary>
    [JsonPropertyName("cloudStorageConfig")]
    public IList<V1beta1SubscriptionSpecInitProviderCloudStorageConfig>? CloudStorageConfig { get; set; }

    /// <summary>A policy that specifies the conditions for dead lettering messages in this subscription. If dead_letter_policy is not set, dead lettering is disabled. The Cloud Pub/Sub service account associated with this subscription's parent project (i.e., service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have permission to Acknowledge() messages on this subscription. Structure is documented below.</summary>
    [JsonPropertyName("deadLetterPolicy")]
    public IList<V1beta1SubscriptionSpecInitProviderDeadLetterPolicy>? DeadLetterPolicy { get; set; }

    /// <summary>If true, Pub/Sub provides the following guarantees for the delivery of a message with a given value of messageId on this Subscriptions':</summary>
    [JsonPropertyName("enableExactlyOnceDelivery")]
    public bool? EnableExactlyOnceDelivery { get; set; }

    /// <summary>If true, messages published with the same orderingKey in PubsubMessage will be delivered to the subscribers in the order in which they are received by the Pub/Sub system. Otherwise, they may be delivered in any order.</summary>
    [JsonPropertyName("enableMessageOrdering")]
    public bool? EnableMessageOrdering { get; set; }

    /// <summary>A policy that specifies the conditions for this subscription's expiration. A subscription is considered active as long as any connected subscriber is successfully consuming messages from the subscription or is issuing operations on the subscription. If expirationPolicy is not set, a default policy with ttl of 31 days will be used.  If it is set but ttl is "", the resource never expires.  The minimum allowed value for expirationPolicy.ttl is 1 day. Structure is documented below.</summary>
    [JsonPropertyName("expirationPolicy")]
    public IList<V1beta1SubscriptionSpecInitProviderExpirationPolicy>? ExpirationPolicy { get; set; }

    /// <summary>The subscription only delivers the messages that match the filter. Pub/Sub automatically acknowledges the messages that don't match the filter. You can filter messages by their attributes. The maximum length of a filter is 256 bytes. After creating the subscription, you can't modify the filter.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>A set of key/value label pairs to assign to this Subscription.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>How long to retain unacknowledged messages in the subscription's backlog, from the moment a message is published. If retain_acked_messages is true, then this also configures the retention of acknowledged messages, and thus configures how far back in time a subscriptions.seek can be done. Defaults to 7 days. Cannot be more than 31 days ("2678400s") or less than 10 minutes ("600s"). A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "600.5s".</summary>
    [JsonPropertyName("messageRetentionDuration")]
    public string? MessageRetentionDuration { get; set; }

    /// <summary>Transforms to be applied to messages published to the topic. Transforms are applied in the order specified. Structure is documented below.</summary>
    [JsonPropertyName("messageTransforms")]
    public IList<V1beta1SubscriptionSpecInitProviderMessageTransforms>? MessageTransforms { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>If push delivery is used with this subscription, this field is used to configure it. An empty pushConfig signifies that the subscriber will pull and ack messages using API methods. Structure is documented below.</summary>
    [JsonPropertyName("pushConfig")]
    public IList<V1beta1SubscriptionSpecInitProviderPushConfig>? PushConfig { get; set; }

    /// <summary>Indicates whether to retain acknowledged messages. If true, then messages are not expunged from the subscription's backlog, even if they are acknowledged, until they fall out of the messageRetentionDuration window.</summary>
    [JsonPropertyName("retainAckedMessages")]
    public bool? RetainAckedMessages { get; set; }

    /// <summary>A policy that specifies how Pub/Sub retries message delivery for this subscription. If not set, the default retry policy is applied. This generally implies that messages will be retried as soon as possible for healthy subscribers. RetryPolicy will be triggered on NACKs or acknowledgement deadline exceeded events for a given message Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1SubscriptionSpecInitProviderRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>A reference to a Topic resource, of the form projects/{project}/topics/{{name}} (as in the id property of a google_pubsub_topic), or just a topic name if the topic is in the same project as the subscription.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta1SubscriptionSpecInitProviderTopicRef? TopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicSelector")]
    public V1beta1SubscriptionSpecInitProviderTopicSelector? TopicSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SubscriptionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SubscriptionSpec defines the desired state of Subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SubscriptionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SubscriptionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SubscriptionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SubscriptionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusAtProviderBigqueryConfig
{
    /// <summary>When true and use_topic_schema or use_table_schema is true, any fields that are a part of the topic schema or message schema that are not part of the BigQuery table schema are dropped when writing to BigQuery. Otherwise, the schemas must be kept in sync and any messages with extra fields are not written and remain in the subscription's backlog.</summary>
    [JsonPropertyName("dropUnknownFields")]
    public bool? DropUnknownFields { get; set; }

    /// <summary>The name of the table to which to write data, of the form {projectId}:{datasetId}.{tableId}</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>When true, use the BigQuery table's schema as the columns to write to in BigQuery. Messages must be published in JSON format. Only one of use_topic_schema and use_table_schema can be set.</summary>
    [JsonPropertyName("useTableSchema")]
    public bool? UseTableSchema { get; set; }

    /// <summary>When true, use the topic's schema as the columns to write to in BigQuery, if it exists. Only one of use_topic_schema and use_table_schema can be set.</summary>
    [JsonPropertyName("useTopicSchema")]
    public bool? UseTopicSchema { get; set; }

    /// <summary>When true, write the subscription name, messageId, publishTime, attributes, and orderingKey to additional columns in the table. The subscription name, messageId, and publishTime fields are put in their own columns while all other message properties (other than data) are written to a JSON object in the attributes column.</summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusAtProviderCloudStorageConfigAvroConfig
{
    /// <summary>When true, use the topic's schema as the columns to write to in BigQuery, if it exists. Only one of use_topic_schema and use_table_schema can be set.</summary>
    [JsonPropertyName("useTopicSchema")]
    public bool? UseTopicSchema { get; set; }

    /// <summary>When true, writes the Pub/Sub message metadata to x-goog-pubsub-&lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request. Writes the Pub/Sub message attributes to &lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request.</summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusAtProviderCloudStorageConfig
{
    /// <summary>If set, message data will be written to Cloud Storage in Avro format. Structure is documented below.</summary>
    [JsonPropertyName("avroConfig")]
    public IList<V1beta1SubscriptionStatusAtProviderCloudStorageConfigAvroConfig>? AvroConfig { get; set; }

    /// <summary>User-provided name for the Cloud Storage bucket. The bucket must be created by the user. The bucket name must be without any prefix like "gs://".</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>User-provided format string specifying how to represent datetimes in Cloud Storage filenames.</summary>
    [JsonPropertyName("filenameDatetimeFormat")]
    public string? FilenameDatetimeFormat { get; set; }

    /// <summary>User-provided prefix for Cloud Storage filename.</summary>
    [JsonPropertyName("filenamePrefix")]
    public string? FilenamePrefix { get; set; }

    /// <summary>User-provided suffix for Cloud Storage filename. Must not end in "/".</summary>
    [JsonPropertyName("filenameSuffix")]
    public string? FilenameSuffix { get; set; }

    /// <summary>The maximum bytes that can be written to a Cloud Storage file before a new file is created. Min 1 KB, max 10 GiB. The maxBytes limit may be exceeded in cases where messages are larger than the limit.</summary>
    [JsonPropertyName("maxBytes")]
    public double? MaxBytes { get; set; }

    /// <summary>The maximum duration that can elapse before a new Cloud Storage file is created. Min 1 minute, max 10 minutes, default 5 minutes. May not exceed the subscription's acknowledgement deadline. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }

    /// <summary>The maximum messages that can be written to a Cloud Storage file before a new file is created. Min 1000 messages.</summary>
    [JsonPropertyName("maxMessages")]
    public double? MaxMessages { get; set; }

    /// <summary>The service account to use to write to Cloud Storage. If not specified, the Pub/Sub service agent, service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com, is used.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>(Output) An output-only field that indicates whether or not the subscription can receive messages.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusAtProviderDeadLetterPolicy
{
    /// <summary>The name of the topic to which dead letter messages should be published. Format is projects/{project}/topics/{topic}. The Cloud Pub/Sub service account associated with the enclosing subscription's parent project (i.e., service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have permission to Publish() to this topic. The operation will fail if the topic does not exist. Users should ensure that there is a subscription attached to this topic since messages published to a topic with no subscriptions are lost.</summary>
    [JsonPropertyName("deadLetterTopic")]
    public string? DeadLetterTopic { get; set; }

    /// <summary>The maximum number of delivery attempts for any message. The value must be between 5 and 100. The number of delivery attempts is defined as 1 + (the sum of number of NACKs and number of times the acknowledgement deadline has been exceeded for the message). A NACK is any call to ModifyAckDeadline with a 0 deadline. Note that client libraries may automatically extend ack_deadlines. This field will be honored on a best effort basis. If this parameter is 0, a default value of 5 is used.</summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public double? MaxDeliveryAttempts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusAtProviderExpirationPolicy
{
    /// <summary>Specifies the "time-to-live" duration for an associated resource. The resource expires if it is not active for a period of ttl. If ttl is set to "", the associated resource never expires. A duration in seconds with up to nine fractional digits, terminated by 's'. Example - "3.5s".</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusAtProviderMessageTransformsJavascriptUdf
{
    /// <summary>JavaScript code that contains a function function_name with the following signature:</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Name of the JavaScript function that should be applied to Pub/Sub messages.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusAtProviderMessageTransforms
{
    /// <summary>Controls whether or not to use this transform. If not set or false, the transform will be applied to messages. Default: true.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Javascript User Defined Function. If multiple Javascript UDFs are specified on a resource, each one must have a unique function_name. Structure is documented below.</summary>
    [JsonPropertyName("javascriptUdf")]
    public IList<V1beta1SubscriptionStatusAtProviderMessageTransformsJavascriptUdf>? JavascriptUdf { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusAtProviderPushConfigNoWrapper
{
    /// <summary>When true, writes the Pub/Sub message metadata to x-goog-pubsub-&lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request. Writes the Pub/Sub message attributes to &lt;KEY&gt;:&lt;VAL&gt; headers of the HTTP request.</summary>
    [JsonPropertyName("writeMetadata")]
    public bool? WriteMetadata { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusAtProviderPushConfigOidcToken
{
    /// <summary>Audience to be used when generating OIDC token. The audience claim identifies the recipients that the JWT is intended for. The audience value is a single case-sensitive string. Having multiple values (array) for the audience field is not supported. More info about the OIDC JWT token audience here: https://tools.ietf.org/html/rfc7519#section-4.1.3 Note: if not specified, the Push endpoint URL will be used.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>Service account email to be used for generating the OIDC token. The caller (for subscriptions.create, subscriptions.patch, and subscriptions.modifyPushConfig RPCs) must have the iam.serviceAccounts.actAs permission for the service account.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusAtProviderPushConfig
{
    /// <summary>Endpoint configuration attributes. Every endpoint has a set of API supported attributes that can be used to control different aspects of the message delivery. The currently supported attribute is x-goog-version, which you can use to change the format of the pushed message. This attribute indicates the version of the data expected by the endpoint. This controls the shape of the pushed message (i.e., its fields and metadata). The endpoint version is based on the version of the Pub/Sub API. If not present during the subscriptions.create call, it will default to the version of the API used to make such call. If not present during a subscriptions.modifyPushConfig call, its value will not be changed. subscriptions.get calls will always return a valid version, even if the subscription was created without this attribute. The possible values for this attribute are:</summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>When set, the payload to the push endpoint is not wrapped.Sets the data field as the HTTP body for delivery. Structure is documented below.</summary>
    [JsonPropertyName("noWrapper")]
    public IList<V1beta1SubscriptionStatusAtProviderPushConfigNoWrapper>? NoWrapper { get; set; }

    /// <summary>If specified, Pub/Sub will generate and attach an OIDC JWT token as an Authorization header in the HTTP request for every pushed message. Structure is documented below.</summary>
    [JsonPropertyName("oidcToken")]
    public IList<V1beta1SubscriptionStatusAtProviderPushConfigOidcToken>? OidcToken { get; set; }

    /// <summary>A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint might use "https://example.com/push".</summary>
    [JsonPropertyName("pushEndpoint")]
    public string? PushEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusAtProviderRetryPolicy
{
    /// <summary>The maximum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 600 seconds. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("maximumBackoff")]
    public string? MaximumBackoff { get; set; }

    /// <summary>The minimum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 10 seconds. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("minimumBackoff")]
    public string? MinimumBackoff { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusAtProvider
{
    /// <summary>This value is the maximum time after a subscriber receives a message before the subscriber should acknowledge the message. After message delivery but before the ack deadline expires and before the message is acknowledged, it is an outstanding message and will not be delivered again during that time (on a best-effort basis). For pull subscriptions, this value is used as the initial value for the ack deadline. To override this value for a given message, call subscriptions.modifyAckDeadline with the corresponding ackId if using pull. The minimum custom deadline you can specify is 10 seconds. The maximum custom deadline you can specify is 600 seconds (10 minutes). If this parameter is 0, a default value of 10 seconds is used. For push delivery, this value is also used to set the request timeout for the call to the push endpoint. If the subscriber never acknowledges the message, the Pub/Sub system will eventually redeliver the message.</summary>
    [JsonPropertyName("ackDeadlineSeconds")]
    public double? AckDeadlineSeconds { get; set; }

    /// <summary>If delivery to BigQuery is used with this subscription, this field is used to configure it. Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined. If all three are empty, then the subscriber will pull and ack messages using API methods. Structure is documented below.</summary>
    [JsonPropertyName("bigqueryConfig")]
    public IList<V1beta1SubscriptionStatusAtProviderBigqueryConfig>? BigqueryConfig { get; set; }

    /// <summary>If delivery to Cloud Storage is used with this subscription, this field is used to configure it. Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined. If all three are empty, then the subscriber will pull and ack messages using API methods. Structure is documented below.</summary>
    [JsonPropertyName("cloudStorageConfig")]
    public IList<V1beta1SubscriptionStatusAtProviderCloudStorageConfig>? CloudStorageConfig { get; set; }

    /// <summary>A policy that specifies the conditions for dead lettering messages in this subscription. If dead_letter_policy is not set, dead lettering is disabled. The Cloud Pub/Sub service account associated with this subscription's parent project (i.e., service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have permission to Acknowledge() messages on this subscription. Structure is documented below.</summary>
    [JsonPropertyName("deadLetterPolicy")]
    public IList<V1beta1SubscriptionStatusAtProviderDeadLetterPolicy>? DeadLetterPolicy { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>If true, Pub/Sub provides the following guarantees for the delivery of a message with a given value of messageId on this Subscriptions':</summary>
    [JsonPropertyName("enableExactlyOnceDelivery")]
    public bool? EnableExactlyOnceDelivery { get; set; }

    /// <summary>If true, messages published with the same orderingKey in PubsubMessage will be delivered to the subscribers in the order in which they are received by the Pub/Sub system. Otherwise, they may be delivered in any order.</summary>
    [JsonPropertyName("enableMessageOrdering")]
    public bool? EnableMessageOrdering { get; set; }

    /// <summary>A policy that specifies the conditions for this subscription's expiration. A subscription is considered active as long as any connected subscriber is successfully consuming messages from the subscription or is issuing operations on the subscription. If expirationPolicy is not set, a default policy with ttl of 31 days will be used.  If it is set but ttl is "", the resource never expires.  The minimum allowed value for expirationPolicy.ttl is 1 day. Structure is documented below.</summary>
    [JsonPropertyName("expirationPolicy")]
    public IList<V1beta1SubscriptionStatusAtProviderExpirationPolicy>? ExpirationPolicy { get; set; }

    /// <summary>The subscription only delivers the messages that match the filter. Pub/Sub automatically acknowledges the messages that don't match the filter. You can filter messages by their attributes. The maximum length of a filter is 256 bytes. After creating the subscription, you can't modify the filter.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/subscriptions/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A set of key/value label pairs to assign to this Subscription.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>How long to retain unacknowledged messages in the subscription's backlog, from the moment a message is published. If retain_acked_messages is true, then this also configures the retention of acknowledged messages, and thus configures how far back in time a subscriptions.seek can be done. Defaults to 7 days. Cannot be more than 31 days ("2678400s") or less than 10 minutes ("600s"). A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "600.5s".</summary>
    [JsonPropertyName("messageRetentionDuration")]
    public string? MessageRetentionDuration { get; set; }

    /// <summary>Transforms to be applied to messages published to the topic. Transforms are applied in the order specified. Structure is documented below.</summary>
    [JsonPropertyName("messageTransforms")]
    public IList<V1beta1SubscriptionStatusAtProviderMessageTransforms>? MessageTransforms { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>If push delivery is used with this subscription, this field is used to configure it. An empty pushConfig signifies that the subscriber will pull and ack messages using API methods. Structure is documented below.</summary>
    [JsonPropertyName("pushConfig")]
    public IList<V1beta1SubscriptionStatusAtProviderPushConfig>? PushConfig { get; set; }

    /// <summary>Indicates whether to retain acknowledged messages. If true, then messages are not expunged from the subscription's backlog, even if they are acknowledged, until they fall out of the messageRetentionDuration window.</summary>
    [JsonPropertyName("retainAckedMessages")]
    public bool? RetainAckedMessages { get; set; }

    /// <summary>A policy that specifies how Pub/Sub retries message delivery for this subscription. If not set, the default retry policy is applied. This generally implies that messages will be retried as soon as possible for healthy subscribers. RetryPolicy will be triggered on NACKs or acknowledgement deadline exceeded events for a given message Structure is documented below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1SubscriptionStatusAtProviderRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>A reference to a Topic resource, of the form projects/{project}/topics/{{name}} (as in the id property of a google_pubsub_topic), or just a topic name if the topic is in the same project as the subscription.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>SubscriptionStatus defines the observed state of Subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SubscriptionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SubscriptionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Subscription is the Schema for the Subscriptions API. A named resource representing the stream of messages from a single, specific topic, to be delivered to the subscribing application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Subscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SubscriptionSpec>, IStatus<V1beta1SubscriptionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Subscription";
    public const string KubeGroup = "pubsub.gcp.upbound.io";
    public const string KubePluralName = "subscriptions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SubscriptionSpec defines the desired state of Subscription</summary>
    [JsonPropertyName("spec")]
    public V1beta1SubscriptionSpec Spec { get; set; }

    /// <summary>SubscriptionStatus defines the observed state of Subscription.</summary>
    [JsonPropertyName("status")]
    public V1beta1SubscriptionStatus? Status { get; set; }
}