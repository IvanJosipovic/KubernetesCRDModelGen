using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pubsub.gcp.upbound.io;
/// <summary>Topic is the Schema for the Topics API. A named resource to which messages are sent by publishers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TopicList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Topic>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TopicList";
    public const string KubeGroup = "pubsub.gcp.upbound.io";
    public const string KubePluralName = "topics";
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
    public IList<V1beta1Topic> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderIngestionDataSourceSettingsAwsKinesis
{
    /// <summary>AWS role ARN to be used for Federated Identity authentication with MSK. Check the Pub/Sub docs for how to set up this role and the required permissions that need to be attached to it.</summary>
    [JsonPropertyName("awsRoleArn")]
    public string? AwsRoleArn { get; set; }

    /// <summary>The Kinesis consumer ARN to used for ingestion in Enhanced Fan-Out mode. The consumer must be already created and ready to be used.</summary>
    [JsonPropertyName("consumerArn")]
    public string? ConsumerArn { get; set; }

    /// <summary>The GCP service account to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>The Kinesis stream ARN to ingest data from.</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderIngestionDataSourceSettingsAwsMsk
{
    /// <summary>AWS role ARN to be used for Federated Identity authentication with MSK. Check the Pub/Sub docs for how to set up this role and the required permissions that need to be attached to it.</summary>
    [JsonPropertyName("awsRoleArn")]
    public string? AwsRoleArn { get; set; }

    /// <summary>ARN that uniquely identifies the MSK cluster.</summary>
    [JsonPropertyName("clusterArn")]
    public string? ClusterArn { get; set; }

    /// <summary>The GCP service account to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>Name of the Confluent Cloud topic that Pub/Sub will import from.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderIngestionDataSourceSettingsAzureEventHubs
{
    /// <summary>The Azure event hub client ID to use for ingestion.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Azure event hub to ingest data from.</summary>
    [JsonPropertyName("eventHub")]
    public string? EventHub { get; set; }

    /// <summary>The GCP service account to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>The Azure event hub namespace to ingest data from.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The name of the resource group within an Azure subscription.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure event hub subscription ID to use for ingestion.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The Azure event hub tenant ID to use for ingestion.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderIngestionDataSourceSettingsCloudStorageAvroFormat
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderIngestionDataSourceSettingsCloudStoragePubsubAvroFormat
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderIngestionDataSourceSettingsCloudStorageTextFormat
{
    /// <summary>The delimiter to use when using the 'text' format. Each line of text as specified by the delimiter will be set to the 'data' field of a Pub/Sub message. When unset, '\n' is used.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderIngestionDataSourceSettingsCloudStorage
{
    /// <summary>Configuration for reading Cloud Storage data in Avro binary format. The bytes of each object will be set to the data field of a Pub/Sub message.</summary>
    [JsonPropertyName("avroFormat")]
    public IList<V1beta1TopicSpecForProviderIngestionDataSourceSettingsCloudStorageAvroFormat>? AvroFormat { get; set; }

    /// <summary>Cloud Storage bucket. The bucket name must be without any prefix like "gs://". See the bucket naming requirements: https://cloud.google.com/storage/docs/buckets#naming.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Glob pattern used to match objects that will be ingested. If unset, all objects will be ingested. See the supported patterns: https://cloud.google.com/storage/docs/json_api/v1/objects/list#list-objects-and-prefixes-using-glob</summary>
    [JsonPropertyName("matchGlob")]
    public string? MatchGlob { get; set; }

    /// <summary>The timestamp set in RFC3339 text format. If set, only objects with a larger or equal timestamp will be ingested. Unset by default, meaning all objects will be ingested.</summary>
    [JsonPropertyName("minimumObjectCreateTime")]
    public string? MinimumObjectCreateTime { get; set; }

    /// <summary>Configuration for reading Cloud Storage data written via Cloud Storage subscriptions(See https://cloud.google.com/pubsub/docs/cloudstorage). The data and attributes fields of the originally exported Pub/Sub message will be restored when publishing.</summary>
    [JsonPropertyName("pubsubAvroFormat")]
    public IList<V1beta1TopicSpecForProviderIngestionDataSourceSettingsCloudStoragePubsubAvroFormat>? PubsubAvroFormat { get; set; }

    /// <summary>Configuration for reading Cloud Storage data in text format. Each line of text as specified by the delimiter will be set to the data field of a Pub/Sub message. Structure is documented below.</summary>
    [JsonPropertyName("textFormat")]
    public IList<V1beta1TopicSpecForProviderIngestionDataSourceSettingsCloudStorageTextFormat>? TextFormat { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderIngestionDataSourceSettingsConfluentCloud
{
    /// <summary>The Confluent Cloud bootstrap server. The format is url:port.</summary>
    [JsonPropertyName("bootstrapServer")]
    public string? BootstrapServer { get; set; }

    /// <summary>The Confluent Cloud cluster ID.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>The GCP service account to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>Identity pool ID to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>Name of the Confluent Cloud topic that Pub/Sub will import from.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderIngestionDataSourceSettingsPlatformLogsSettings
{
    /// <summary>The minimum severity level of Platform Logs that will be written. If unspecified, no Platform Logs will be written. Default value is SEVERITY_UNSPECIFIED. Possible values are: SEVERITY_UNSPECIFIED, DISABLED, DEBUG, INFO, WARNING, ERROR.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderIngestionDataSourceSettings
{
    /// <summary>Settings for ingestion from Amazon Kinesis Data Streams. Structure is documented below.</summary>
    [JsonPropertyName("awsKinesis")]
    public IList<V1beta1TopicSpecForProviderIngestionDataSourceSettingsAwsKinesis>? AwsKinesis { get; set; }

    /// <summary>Settings for ingestion from Amazon Managed Streaming for Apache Kafka. Structure is documented below.</summary>
    [JsonPropertyName("awsMsk")]
    public IList<V1beta1TopicSpecForProviderIngestionDataSourceSettingsAwsMsk>? AwsMsk { get; set; }

    /// <summary>Settings for ingestion from Azure Event Hubs. Structure is documented below.</summary>
    [JsonPropertyName("azureEventHubs")]
    public IList<V1beta1TopicSpecForProviderIngestionDataSourceSettingsAzureEventHubs>? AzureEventHubs { get; set; }

    /// <summary>Settings for ingestion from Cloud Storage. Structure is documented below.</summary>
    [JsonPropertyName("cloudStorage")]
    public IList<V1beta1TopicSpecForProviderIngestionDataSourceSettingsCloudStorage>? CloudStorage { get; set; }

    /// <summary>Settings for ingestion from Confluent Cloud. Structure is documented below.</summary>
    [JsonPropertyName("confluentCloud")]
    public IList<V1beta1TopicSpecForProviderIngestionDataSourceSettingsConfluentCloud>? ConfluentCloud { get; set; }

    /// <summary>Settings for Platform Logs regarding ingestion to Pub/Sub. If unset, no Platform Logs will be generated.' Structure is documented below.</summary>
    [JsonPropertyName("platformLogsSettings")]
    public IList<V1beta1TopicSpecForProviderIngestionDataSourceSettingsPlatformLogsSettings>? PlatformLogsSettings { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderKmsKeyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicSpecForProviderKmsKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderKmsKeyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderKmsKeyNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicSpecForProviderKmsKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderMessageStoragePolicy
{
    /// <summary>A list of IDs of GCP regions where messages that are published to the topic may be persisted in storage. Messages published by publishers running in non-allowed GCP regions (or running outside of GCP altogether) will be routed for storage in one of the allowed regions. An empty list means that no regions are allowed, and is not a valid configuration.</summary>
    [JsonPropertyName("allowedPersistenceRegions")]
    public IList<string>? AllowedPersistenceRegions { get; set; }

    /// <summary>If true, allowedPersistenceRegions is also used to enforce in-transit guarantees for messages. That is, Pub/Sub will fail topics.publish operations on this topic and subscribe operations on any subscription attached to this topic in any region that is not in allowedPersistenceRegions.</summary>
    [JsonPropertyName("enforceInTransit")]
    public bool? EnforceInTransit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderMessageTransformsJavascriptUdf
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
public partial class V1beta1TopicSpecForProviderMessageTransforms
{
    /// <summary>Controls whether or not to use this transform. If not set or false, the transform will be applied to messages. Default: true.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Javascript User Defined Function. If multiple Javascript UDFs are specified on a resource, each one must have a unique function_name. Structure is documented below.</summary>
    [JsonPropertyName("javascriptUdf")]
    public IList<V1beta1TopicSpecForProviderMessageTransformsJavascriptUdf>? JavascriptUdf { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderSchemaSettings
{
    /// <summary>The encoding of messages validated against schema. Default value is ENCODING_UNSPECIFIED. Possible values are: ENCODING_UNSPECIFIED, JSON, BINARY.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The name of the schema that messages published should be validated against. Format is projects/{project}/schemas/{schema}. The value of this field will be deleted-schema if the schema has been deleted.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProvider
{
    /// <summary>Settings for ingestion from a data source into this topic. Structure is documented below.</summary>
    [JsonPropertyName("ingestionDataSourceSettings")]
    public IList<V1beta1TopicSpecForProviderIngestionDataSourceSettings>? IngestionDataSourceSettings { get; set; }

    /// <summary>The resource name of the Cloud KMS CryptoKey to be used to protect access to messages published on this topic. Your project's PubSub service account (service-{{PROJECT_NUMBER}}@gcp-sa-pubsub.iam.gserviceaccount.com) must have roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature. The expected format is projects/*/locations/*/keyRings/*/cryptoKeys/*</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta1TopicSpecForProviderKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta1TopicSpecForProviderKmsKeyNameSelector? KmsKeyNameSelector { get; set; }

    /// <summary>A set of key/value label pairs to assign to this Topic.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Indicates the minimum duration to retain a message after it is published to the topic. If this field is set, messages published to the topic in the last messageRetentionDuration are always available to subscribers. For instance, it allows any attached subscription to seek to a timestamp that is up to messageRetentionDuration in the past. If this field is not set, message retention is controlled by settings on individual subscriptions. The rotation period has the format of a decimal number, followed by the letter s (seconds). Cannot be more than 31 days or less than 10 minutes.</summary>
    [JsonPropertyName("messageRetentionDuration")]
    public string? MessageRetentionDuration { get; set; }

    /// <summary>Policy constraining the set of Google Cloud Platform regions where messages published to the topic may be stored. If not present, then no constraints are in effect. Structure is documented below.</summary>
    [JsonPropertyName("messageStoragePolicy")]
    public IList<V1beta1TopicSpecForProviderMessageStoragePolicy>? MessageStoragePolicy { get; set; }

    /// <summary>Transforms to be applied to messages published to the topic. Transforms are applied in the order specified. Structure is documented below.</summary>
    [JsonPropertyName("messageTransforms")]
    public IList<V1beta1TopicSpecForProviderMessageTransforms>? MessageTransforms { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Settings for validating messages published against a schema. Structure is documented below.</summary>
    [JsonPropertyName("schemaSettings")]
    public IList<V1beta1TopicSpecForProviderSchemaSettings>? SchemaSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderIngestionDataSourceSettingsAwsKinesis
{
    /// <summary>AWS role ARN to be used for Federated Identity authentication with MSK. Check the Pub/Sub docs for how to set up this role and the required permissions that need to be attached to it.</summary>
    [JsonPropertyName("awsRoleArn")]
    public string? AwsRoleArn { get; set; }

    /// <summary>The Kinesis consumer ARN to used for ingestion in Enhanced Fan-Out mode. The consumer must be already created and ready to be used.</summary>
    [JsonPropertyName("consumerArn")]
    public string? ConsumerArn { get; set; }

    /// <summary>The GCP service account to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>The Kinesis stream ARN to ingest data from.</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderIngestionDataSourceSettingsAwsMsk
{
    /// <summary>AWS role ARN to be used for Federated Identity authentication with MSK. Check the Pub/Sub docs for how to set up this role and the required permissions that need to be attached to it.</summary>
    [JsonPropertyName("awsRoleArn")]
    public string? AwsRoleArn { get; set; }

    /// <summary>ARN that uniquely identifies the MSK cluster.</summary>
    [JsonPropertyName("clusterArn")]
    public string? ClusterArn { get; set; }

    /// <summary>The GCP service account to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>Name of the Confluent Cloud topic that Pub/Sub will import from.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderIngestionDataSourceSettingsAzureEventHubs
{
    /// <summary>The Azure event hub client ID to use for ingestion.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Azure event hub to ingest data from.</summary>
    [JsonPropertyName("eventHub")]
    public string? EventHub { get; set; }

    /// <summary>The GCP service account to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>The Azure event hub namespace to ingest data from.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The name of the resource group within an Azure subscription.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure event hub subscription ID to use for ingestion.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The Azure event hub tenant ID to use for ingestion.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderIngestionDataSourceSettingsCloudStorageAvroFormat
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderIngestionDataSourceSettingsCloudStoragePubsubAvroFormat
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderIngestionDataSourceSettingsCloudStorageTextFormat
{
    /// <summary>The delimiter to use when using the 'text' format. Each line of text as specified by the delimiter will be set to the 'data' field of a Pub/Sub message. When unset, '\n' is used.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderIngestionDataSourceSettingsCloudStorage
{
    /// <summary>Configuration for reading Cloud Storage data in Avro binary format. The bytes of each object will be set to the data field of a Pub/Sub message.</summary>
    [JsonPropertyName("avroFormat")]
    public IList<V1beta1TopicSpecInitProviderIngestionDataSourceSettingsCloudStorageAvroFormat>? AvroFormat { get; set; }

    /// <summary>Cloud Storage bucket. The bucket name must be without any prefix like "gs://". See the bucket naming requirements: https://cloud.google.com/storage/docs/buckets#naming.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Glob pattern used to match objects that will be ingested. If unset, all objects will be ingested. See the supported patterns: https://cloud.google.com/storage/docs/json_api/v1/objects/list#list-objects-and-prefixes-using-glob</summary>
    [JsonPropertyName("matchGlob")]
    public string? MatchGlob { get; set; }

    /// <summary>The timestamp set in RFC3339 text format. If set, only objects with a larger or equal timestamp will be ingested. Unset by default, meaning all objects will be ingested.</summary>
    [JsonPropertyName("minimumObjectCreateTime")]
    public string? MinimumObjectCreateTime { get; set; }

    /// <summary>Configuration for reading Cloud Storage data written via Cloud Storage subscriptions(See https://cloud.google.com/pubsub/docs/cloudstorage). The data and attributes fields of the originally exported Pub/Sub message will be restored when publishing.</summary>
    [JsonPropertyName("pubsubAvroFormat")]
    public IList<V1beta1TopicSpecInitProviderIngestionDataSourceSettingsCloudStoragePubsubAvroFormat>? PubsubAvroFormat { get; set; }

    /// <summary>Configuration for reading Cloud Storage data in text format. Each line of text as specified by the delimiter will be set to the data field of a Pub/Sub message. Structure is documented below.</summary>
    [JsonPropertyName("textFormat")]
    public IList<V1beta1TopicSpecInitProviderIngestionDataSourceSettingsCloudStorageTextFormat>? TextFormat { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderIngestionDataSourceSettingsConfluentCloud
{
    /// <summary>The Confluent Cloud bootstrap server. The format is url:port.</summary>
    [JsonPropertyName("bootstrapServer")]
    public string? BootstrapServer { get; set; }

    /// <summary>The Confluent Cloud cluster ID.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>The GCP service account to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>Identity pool ID to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>Name of the Confluent Cloud topic that Pub/Sub will import from.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderIngestionDataSourceSettingsPlatformLogsSettings
{
    /// <summary>The minimum severity level of Platform Logs that will be written. If unspecified, no Platform Logs will be written. Default value is SEVERITY_UNSPECIFIED. Possible values are: SEVERITY_UNSPECIFIED, DISABLED, DEBUG, INFO, WARNING, ERROR.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderIngestionDataSourceSettings
{
    /// <summary>Settings for ingestion from Amazon Kinesis Data Streams. Structure is documented below.</summary>
    [JsonPropertyName("awsKinesis")]
    public IList<V1beta1TopicSpecInitProviderIngestionDataSourceSettingsAwsKinesis>? AwsKinesis { get; set; }

    /// <summary>Settings for ingestion from Amazon Managed Streaming for Apache Kafka. Structure is documented below.</summary>
    [JsonPropertyName("awsMsk")]
    public IList<V1beta1TopicSpecInitProviderIngestionDataSourceSettingsAwsMsk>? AwsMsk { get; set; }

    /// <summary>Settings for ingestion from Azure Event Hubs. Structure is documented below.</summary>
    [JsonPropertyName("azureEventHubs")]
    public IList<V1beta1TopicSpecInitProviderIngestionDataSourceSettingsAzureEventHubs>? AzureEventHubs { get; set; }

    /// <summary>Settings for ingestion from Cloud Storage. Structure is documented below.</summary>
    [JsonPropertyName("cloudStorage")]
    public IList<V1beta1TopicSpecInitProviderIngestionDataSourceSettingsCloudStorage>? CloudStorage { get; set; }

    /// <summary>Settings for ingestion from Confluent Cloud. Structure is documented below.</summary>
    [JsonPropertyName("confluentCloud")]
    public IList<V1beta1TopicSpecInitProviderIngestionDataSourceSettingsConfluentCloud>? ConfluentCloud { get; set; }

    /// <summary>Settings for Platform Logs regarding ingestion to Pub/Sub. If unset, no Platform Logs will be generated.' Structure is documented below.</summary>
    [JsonPropertyName("platformLogsSettings")]
    public IList<V1beta1TopicSpecInitProviderIngestionDataSourceSettingsPlatformLogsSettings>? PlatformLogsSettings { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderKmsKeyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicSpecInitProviderKmsKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderKmsKeyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderKmsKeyNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicSpecInitProviderKmsKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderMessageStoragePolicy
{
    /// <summary>A list of IDs of GCP regions where messages that are published to the topic may be persisted in storage. Messages published by publishers running in non-allowed GCP regions (or running outside of GCP altogether) will be routed for storage in one of the allowed regions. An empty list means that no regions are allowed, and is not a valid configuration.</summary>
    [JsonPropertyName("allowedPersistenceRegions")]
    public IList<string>? AllowedPersistenceRegions { get; set; }

    /// <summary>If true, allowedPersistenceRegions is also used to enforce in-transit guarantees for messages. That is, Pub/Sub will fail topics.publish operations on this topic and subscribe operations on any subscription attached to this topic in any region that is not in allowedPersistenceRegions.</summary>
    [JsonPropertyName("enforceInTransit")]
    public bool? EnforceInTransit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderMessageTransformsJavascriptUdf
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
public partial class V1beta1TopicSpecInitProviderMessageTransforms
{
    /// <summary>Controls whether or not to use this transform. If not set or false, the transform will be applied to messages. Default: true.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Javascript User Defined Function. If multiple Javascript UDFs are specified on a resource, each one must have a unique function_name. Structure is documented below.</summary>
    [JsonPropertyName("javascriptUdf")]
    public IList<V1beta1TopicSpecInitProviderMessageTransformsJavascriptUdf>? JavascriptUdf { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderSchemaSettings
{
    /// <summary>The encoding of messages validated against schema. Default value is ENCODING_UNSPECIFIED. Possible values are: ENCODING_UNSPECIFIED, JSON, BINARY.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The name of the schema that messages published should be validated against. Format is projects/{project}/schemas/{schema}. The value of this field will be deleted-schema if the schema has been deleted.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProvider
{
    /// <summary>Settings for ingestion from a data source into this topic. Structure is documented below.</summary>
    [JsonPropertyName("ingestionDataSourceSettings")]
    public IList<V1beta1TopicSpecInitProviderIngestionDataSourceSettings>? IngestionDataSourceSettings { get; set; }

    /// <summary>The resource name of the Cloud KMS CryptoKey to be used to protect access to messages published on this topic. Your project's PubSub service account (service-{{PROJECT_NUMBER}}@gcp-sa-pubsub.iam.gserviceaccount.com) must have roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature. The expected format is projects/*/locations/*/keyRings/*/cryptoKeys/*</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta1TopicSpecInitProviderKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta1TopicSpecInitProviderKmsKeyNameSelector? KmsKeyNameSelector { get; set; }

    /// <summary>A set of key/value label pairs to assign to this Topic.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Indicates the minimum duration to retain a message after it is published to the topic. If this field is set, messages published to the topic in the last messageRetentionDuration are always available to subscribers. For instance, it allows any attached subscription to seek to a timestamp that is up to messageRetentionDuration in the past. If this field is not set, message retention is controlled by settings on individual subscriptions. The rotation period has the format of a decimal number, followed by the letter s (seconds). Cannot be more than 31 days or less than 10 minutes.</summary>
    [JsonPropertyName("messageRetentionDuration")]
    public string? MessageRetentionDuration { get; set; }

    /// <summary>Policy constraining the set of Google Cloud Platform regions where messages published to the topic may be stored. If not present, then no constraints are in effect. Structure is documented below.</summary>
    [JsonPropertyName("messageStoragePolicy")]
    public IList<V1beta1TopicSpecInitProviderMessageStoragePolicy>? MessageStoragePolicy { get; set; }

    /// <summary>Transforms to be applied to messages published to the topic. Transforms are applied in the order specified. Structure is documented below.</summary>
    [JsonPropertyName("messageTransforms")]
    public IList<V1beta1TopicSpecInitProviderMessageTransforms>? MessageTransforms { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Settings for validating messages published against a schema. Structure is documented below.</summary>
    [JsonPropertyName("schemaSettings")]
    public IList<V1beta1TopicSpecInitProviderSchemaSettings>? SchemaSettings { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecProviderConfigRefPolicy
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
public partial class V1beta1TopicSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>TopicSpec defines the desired state of Topic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TopicSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TopicSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TopicSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TopicSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderIngestionDataSourceSettingsAwsKinesis
{
    /// <summary>AWS role ARN to be used for Federated Identity authentication with MSK. Check the Pub/Sub docs for how to set up this role and the required permissions that need to be attached to it.</summary>
    [JsonPropertyName("awsRoleArn")]
    public string? AwsRoleArn { get; set; }

    /// <summary>The Kinesis consumer ARN to used for ingestion in Enhanced Fan-Out mode. The consumer must be already created and ready to be used.</summary>
    [JsonPropertyName("consumerArn")]
    public string? ConsumerArn { get; set; }

    /// <summary>The GCP service account to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>The Kinesis stream ARN to ingest data from.</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderIngestionDataSourceSettingsAwsMsk
{
    /// <summary>AWS role ARN to be used for Federated Identity authentication with MSK. Check the Pub/Sub docs for how to set up this role and the required permissions that need to be attached to it.</summary>
    [JsonPropertyName("awsRoleArn")]
    public string? AwsRoleArn { get; set; }

    /// <summary>ARN that uniquely identifies the MSK cluster.</summary>
    [JsonPropertyName("clusterArn")]
    public string? ClusterArn { get; set; }

    /// <summary>The GCP service account to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>Name of the Confluent Cloud topic that Pub/Sub will import from.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderIngestionDataSourceSettingsAzureEventHubs
{
    /// <summary>The Azure event hub client ID to use for ingestion.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Azure event hub to ingest data from.</summary>
    [JsonPropertyName("eventHub")]
    public string? EventHub { get; set; }

    /// <summary>The GCP service account to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>The Azure event hub namespace to ingest data from.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The name of the resource group within an Azure subscription.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>The Azure event hub subscription ID to use for ingestion.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The Azure event hub tenant ID to use for ingestion.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderIngestionDataSourceSettingsCloudStorageAvroFormat
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderIngestionDataSourceSettingsCloudStoragePubsubAvroFormat
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderIngestionDataSourceSettingsCloudStorageTextFormat
{
    /// <summary>The delimiter to use when using the 'text' format. Each line of text as specified by the delimiter will be set to the 'data' field of a Pub/Sub message. When unset, '\n' is used.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderIngestionDataSourceSettingsCloudStorage
{
    /// <summary>Configuration for reading Cloud Storage data in Avro binary format. The bytes of each object will be set to the data field of a Pub/Sub message.</summary>
    [JsonPropertyName("avroFormat")]
    public IList<V1beta1TopicStatusAtProviderIngestionDataSourceSettingsCloudStorageAvroFormat>? AvroFormat { get; set; }

    /// <summary>Cloud Storage bucket. The bucket name must be without any prefix like "gs://". See the bucket naming requirements: https://cloud.google.com/storage/docs/buckets#naming.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Glob pattern used to match objects that will be ingested. If unset, all objects will be ingested. See the supported patterns: https://cloud.google.com/storage/docs/json_api/v1/objects/list#list-objects-and-prefixes-using-glob</summary>
    [JsonPropertyName("matchGlob")]
    public string? MatchGlob { get; set; }

    /// <summary>The timestamp set in RFC3339 text format. If set, only objects with a larger or equal timestamp will be ingested. Unset by default, meaning all objects will be ingested.</summary>
    [JsonPropertyName("minimumObjectCreateTime")]
    public string? MinimumObjectCreateTime { get; set; }

    /// <summary>Configuration for reading Cloud Storage data written via Cloud Storage subscriptions(See https://cloud.google.com/pubsub/docs/cloudstorage). The data and attributes fields of the originally exported Pub/Sub message will be restored when publishing.</summary>
    [JsonPropertyName("pubsubAvroFormat")]
    public IList<V1beta1TopicStatusAtProviderIngestionDataSourceSettingsCloudStoragePubsubAvroFormat>? PubsubAvroFormat { get; set; }

    /// <summary>Configuration for reading Cloud Storage data in text format. Each line of text as specified by the delimiter will be set to the data field of a Pub/Sub message. Structure is documented below.</summary>
    [JsonPropertyName("textFormat")]
    public IList<V1beta1TopicStatusAtProviderIngestionDataSourceSettingsCloudStorageTextFormat>? TextFormat { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderIngestionDataSourceSettingsConfluentCloud
{
    /// <summary>The Confluent Cloud bootstrap server. The format is url:port.</summary>
    [JsonPropertyName("bootstrapServer")]
    public string? BootstrapServer { get; set; }

    /// <summary>The Confluent Cloud cluster ID.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary>The GCP service account to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("gcpServiceAccount")]
    public string? GcpServiceAccount { get; set; }

    /// <summary>Identity pool ID to be used for Federated Identity authentication with Confluent Cloud.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>Name of the Confluent Cloud topic that Pub/Sub will import from.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderIngestionDataSourceSettingsPlatformLogsSettings
{
    /// <summary>The minimum severity level of Platform Logs that will be written. If unspecified, no Platform Logs will be written. Default value is SEVERITY_UNSPECIFIED. Possible values are: SEVERITY_UNSPECIFIED, DISABLED, DEBUG, INFO, WARNING, ERROR.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderIngestionDataSourceSettings
{
    /// <summary>Settings for ingestion from Amazon Kinesis Data Streams. Structure is documented below.</summary>
    [JsonPropertyName("awsKinesis")]
    public IList<V1beta1TopicStatusAtProviderIngestionDataSourceSettingsAwsKinesis>? AwsKinesis { get; set; }

    /// <summary>Settings for ingestion from Amazon Managed Streaming for Apache Kafka. Structure is documented below.</summary>
    [JsonPropertyName("awsMsk")]
    public IList<V1beta1TopicStatusAtProviderIngestionDataSourceSettingsAwsMsk>? AwsMsk { get; set; }

    /// <summary>Settings for ingestion from Azure Event Hubs. Structure is documented below.</summary>
    [JsonPropertyName("azureEventHubs")]
    public IList<V1beta1TopicStatusAtProviderIngestionDataSourceSettingsAzureEventHubs>? AzureEventHubs { get; set; }

    /// <summary>Settings for ingestion from Cloud Storage. Structure is documented below.</summary>
    [JsonPropertyName("cloudStorage")]
    public IList<V1beta1TopicStatusAtProviderIngestionDataSourceSettingsCloudStorage>? CloudStorage { get; set; }

    /// <summary>Settings for ingestion from Confluent Cloud. Structure is documented below.</summary>
    [JsonPropertyName("confluentCloud")]
    public IList<V1beta1TopicStatusAtProviderIngestionDataSourceSettingsConfluentCloud>? ConfluentCloud { get; set; }

    /// <summary>Settings for Platform Logs regarding ingestion to Pub/Sub. If unset, no Platform Logs will be generated.' Structure is documented below.</summary>
    [JsonPropertyName("platformLogsSettings")]
    public IList<V1beta1TopicStatusAtProviderIngestionDataSourceSettingsPlatformLogsSettings>? PlatformLogsSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderMessageStoragePolicy
{
    /// <summary>A list of IDs of GCP regions where messages that are published to the topic may be persisted in storage. Messages published by publishers running in non-allowed GCP regions (or running outside of GCP altogether) will be routed for storage in one of the allowed regions. An empty list means that no regions are allowed, and is not a valid configuration.</summary>
    [JsonPropertyName("allowedPersistenceRegions")]
    public IList<string>? AllowedPersistenceRegions { get; set; }

    /// <summary>If true, allowedPersistenceRegions is also used to enforce in-transit guarantees for messages. That is, Pub/Sub will fail topics.publish operations on this topic and subscribe operations on any subscription attached to this topic in any region that is not in allowedPersistenceRegions.</summary>
    [JsonPropertyName("enforceInTransit")]
    public bool? EnforceInTransit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderMessageTransformsJavascriptUdf
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
public partial class V1beta1TopicStatusAtProviderMessageTransforms
{
    /// <summary>Controls whether or not to use this transform. If not set or false, the transform will be applied to messages. Default: true.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Javascript User Defined Function. If multiple Javascript UDFs are specified on a resource, each one must have a unique function_name. Structure is documented below.</summary>
    [JsonPropertyName("javascriptUdf")]
    public IList<V1beta1TopicStatusAtProviderMessageTransformsJavascriptUdf>? JavascriptUdf { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderSchemaSettings
{
    /// <summary>The encoding of messages validated against schema. Default value is ENCODING_UNSPECIFIED. Possible values are: ENCODING_UNSPECIFIED, JSON, BINARY.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The name of the schema that messages published should be validated against. Format is projects/{project}/schemas/{schema}. The value of this field will be deleted-schema if the schema has been deleted.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProvider
{
    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/topics/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Settings for ingestion from a data source into this topic. Structure is documented below.</summary>
    [JsonPropertyName("ingestionDataSourceSettings")]
    public IList<V1beta1TopicStatusAtProviderIngestionDataSourceSettings>? IngestionDataSourceSettings { get; set; }

    /// <summary>The resource name of the Cloud KMS CryptoKey to be used to protect access to messages published on this topic. Your project's PubSub service account (service-{{PROJECT_NUMBER}}@gcp-sa-pubsub.iam.gserviceaccount.com) must have roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature. The expected format is projects/*/locations/*/keyRings/*/cryptoKeys/*</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>A set of key/value label pairs to assign to this Topic.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Indicates the minimum duration to retain a message after it is published to the topic. If this field is set, messages published to the topic in the last messageRetentionDuration are always available to subscribers. For instance, it allows any attached subscription to seek to a timestamp that is up to messageRetentionDuration in the past. If this field is not set, message retention is controlled by settings on individual subscriptions. The rotation period has the format of a decimal number, followed by the letter s (seconds). Cannot be more than 31 days or less than 10 minutes.</summary>
    [JsonPropertyName("messageRetentionDuration")]
    public string? MessageRetentionDuration { get; set; }

    /// <summary>Policy constraining the set of Google Cloud Platform regions where messages published to the topic may be stored. If not present, then no constraints are in effect. Structure is documented below.</summary>
    [JsonPropertyName("messageStoragePolicy")]
    public IList<V1beta1TopicStatusAtProviderMessageStoragePolicy>? MessageStoragePolicy { get; set; }

    /// <summary>Transforms to be applied to messages published to the topic. Transforms are applied in the order specified. Structure is documented below.</summary>
    [JsonPropertyName("messageTransforms")]
    public IList<V1beta1TopicStatusAtProviderMessageTransforms>? MessageTransforms { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Settings for validating messages published against a schema. Structure is documented below.</summary>
    [JsonPropertyName("schemaSettings")]
    public IList<V1beta1TopicStatusAtProviderSchemaSettings>? SchemaSettings { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusConditions
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

/// <summary>TopicStatus defines the observed state of Topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TopicStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TopicStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Topic is the Schema for the Topics API. A named resource to which messages are sent by publishers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Topic : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TopicSpec>, IStatus<V1beta1TopicStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Topic";
    public const string KubeGroup = "pubsub.gcp.upbound.io";
    public const string KubePluralName = "topics";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TopicSpec defines the desired state of Topic</summary>
    [JsonPropertyName("spec")]
    public V1beta1TopicSpec Spec { get; set; }

    /// <summary>TopicStatus defines the observed state of Topic.</summary>
    [JsonPropertyName("status")]
    public V1beta1TopicStatus? Status { get; set; }
}