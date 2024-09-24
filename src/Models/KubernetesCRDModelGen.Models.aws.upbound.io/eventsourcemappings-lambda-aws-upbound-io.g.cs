using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lambda.aws.upbound.io;
public enum V1beta1EventSourceMappingSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1EventSourceMappingSpecForProviderAmazonManagedKafkaEventSourceConfig
{
    /// <summary>A Kafka consumer group ID between 1 and 200 characters for use when creating this event source mapping. If one is not specified, this value will be automatically generated. See AmazonManagedKafkaEventSourceConfig Syntax.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }
}

public partial class V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailure
{
    /// <summary>The Amazon Resource Name (ARN) of the destination resource.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }
}

public partial class V1beta1EventSourceMappingSpecForProviderDestinationConfig
{
    /// <summary>The destination configuration for failed invocations. Detailed below.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1beta1EventSourceMappingSpecForProviderDestinationConfigOnFailure>? OnFailure { get; set; }
}

public partial class V1beta1EventSourceMappingSpecForProviderDocumentDbEventSourceConfig
{
    /// <summary>The name of the collection to consume within the database. If you do not specify a collection, Lambda consumes all collections.</summary>
    [JsonPropertyName("collectionName")]
    public string? CollectionName { get; set; }

    /// <summary>The name of the database to consume within the DocumentDB cluster.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Determines what DocumentDB sends to your event stream during document update operations. If set to UpdateLookup, DocumentDB sends a delta describing the changes, along with a copy of the entire document. Otherwise, DocumentDB sends only a partial document that contains the changes. Valid values: UpdateLookup, Default.</summary>
    [JsonPropertyName("fullDocument")]
    public string? FullDocument { get; set; }
}

public partial class V1beta1EventSourceMappingSpecForProviderFilterCriteriaFilter
{
    /// <summary>A filter pattern up to 4096 characters. See Filter Rule Syntax.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1EventSourceMappingSpecForProviderFilterCriteria
{
    /// <summary>A set of up to 5 filter. If an event satisfies at least one, Lambda sends the event to the function or adds it to the next batch. Detailed below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1EventSourceMappingSpecForProviderFilterCriteriaFilter>? Filter { get; set; }
}

public enum V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicyResolutionEnum>))]
    public V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicyResolveEnum>))]
    public V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EventSourceMappingSpecForProviderFunctionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceMappingSpecForProviderFunctionNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EventSourceMappingSpecForProviderFunctionNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceMappingSpecForProviderFunctionNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1EventSourceMappingSpecForProviderScalingConfig
{
    /// <summary>Limits the number of concurrent instances that the Amazon SQS event source can invoke. Must be between 2 and 1000. See Configuring maximum concurrency for Amazon SQS event sources.</summary>
    [JsonPropertyName("maximumConcurrency")]
    public double? MaximumConcurrency { get; set; }
}

public partial class V1beta1EventSourceMappingSpecForProviderSelfManagedEventSource
{
    /// <summary>A map of endpoints for the self managed source.  For Kafka self-managed sources, the key should be KAFKA_BOOTSTRAP_SERVERS and the value should be a string with a comma separated list of broker endpoints.</summary>
    [JsonPropertyName("endpoints")]
    public IDictionary<string, string>? Endpoints { get; set; }
}

public partial class V1beta1EventSourceMappingSpecForProviderSelfManagedKafkaEventSourceConfig
{
    /// <summary>A Kafka consumer group ID between 1 and 200 characters for use when creating this event source mapping. If one is not specified, this value will be automatically generated. See SelfManagedKafkaEventSourceConfig Syntax.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }
}

public partial class V1beta1EventSourceMappingSpecForProviderSourceAccessConfiguration
{
    /// <summary>The type of authentication protocol, VPC components, or virtual host for your event source. For valid values, refer to the AWS documentation.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The URI for this configuration.  For type VPC_SUBNET the value should be subnet:subnet_id where subnet_id is the value you would find in an aws_subnet resource's id attribute.  For type VPC_SECURITY_GROUP the value should be security_group:security_group_id where security_group_id is the value you would find in an aws_security_group resource's id attribute.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1EventSourceMappingSpecForProvider
{
    /// <summary>Additional configuration block for Amazon Managed Kafka sources. Incompatible with "self_managed_event_source" and "self_managed_kafka_event_source_config". Detailed below.</summary>
    [JsonPropertyName("amazonManagedKafkaEventSourceConfig")]
    public IList<V1beta1EventSourceMappingSpecForProviderAmazonManagedKafkaEventSourceConfig>? AmazonManagedKafkaEventSourceConfig { get; set; }

    /// <summary>The largest number of records that Lambda will retrieve from your event source at the time of invocation. Defaults to 100 for DynamoDB, Kinesis, MQ and MSK, 10 for SQS.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>If the function returns an error, split the batch in two and retry. Only available for stream sources (DynamoDB and Kinesis). Defaults to false.</summary>
    [JsonPropertyName("bisectBatchOnFunctionError")]
    public bool? BisectBatchOnFunctionError { get; set; }

    /// <summary>An Amazon SQS queue, Amazon SNS topic or Amazon S3 bucket (only available for Kafka sources) destination for failed records. Only available for stream sources (DynamoDB and Kinesis) and Kafka sources (Amazon MSK and Self-managed Apache Kafka). Detailed below.</summary>
    [JsonPropertyName("destinationConfig")]
    public IList<V1beta1EventSourceMappingSpecForProviderDestinationConfig>? DestinationConfig { get; set; }

    /// <summary>Configuration settings for a DocumentDB event source. Detailed below.</summary>
    [JsonPropertyName("documentDbEventSourceConfig")]
    public IList<V1beta1EventSourceMappingSpecForProviderDocumentDbEventSourceConfig>? DocumentDbEventSourceConfig { get; set; }

    /// <summary>Determines if the mapping will be enabled on creation. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The event source ARN - this is required for Kinesis stream, DynamoDB stream, SQS queue, MQ broker, MSK cluster or DocumentDB change stream.  It is incompatible with a Self Managed Kafka source.</summary>
    [JsonPropertyName("eventSourceArn")]
    public string? EventSourceArn { get; set; }

    /// <summary>The criteria to use for event filtering Kinesis stream, DynamoDB stream, SQS queue event sources. Detailed below.</summary>
    [JsonPropertyName("filterCriteria")]
    public IList<V1beta1EventSourceMappingSpecForProviderFilterCriteria>? FilterCriteria { get; set; }

    /// <summary>The name or the ARN of the Lambda function that will be subscribing to events.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>Reference to a Function in lambda to populate functionName.</summary>
    [JsonPropertyName("functionNameRef")]
    public V1beta1EventSourceMappingSpecForProviderFunctionNameRef? FunctionNameRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate functionName.</summary>
    [JsonPropertyName("functionNameSelector")]
    public V1beta1EventSourceMappingSpecForProviderFunctionNameSelector? FunctionNameSelector { get; set; }

    /// <summary>A list of current response type enums applied to the event source mapping for AWS Lambda checkpointing. Only available for SQS and stream sources (DynamoDB and Kinesis). Valid values: ReportBatchItemFailures.</summary>
    [JsonPropertyName("functionResponseTypes")]
    public IList<string>? FunctionResponseTypes { get; set; }

    /// <summary>The maximum amount of time to gather records before invoking the function, in seconds (between 0 and 300). Records will continue to buffer (or accumulate in the case of an SQS queue event source) until either maximum_batching_window_in_seconds expires or batch_size has been met. For streaming event sources, defaults to as soon as records are available in the stream. If the batch it reads from the stream/queue only has one record in it, Lambda only sends one record to the function. Only available for stream sources (DynamoDB and Kinesis) and SQS standard queues.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>The maximum age of a record that Lambda sends to a function for processing. Only available for stream sources (DynamoDB and Kinesis). Must be either -1 (forever, and the default value) or between 60 and 604800 (inclusive).</summary>
    [JsonPropertyName("maximumRecordAgeInSeconds")]
    public double? MaximumRecordAgeInSeconds { get; set; }

    /// <summary>The maximum number of times to retry when the function returns an error. Only available for stream sources (DynamoDB and Kinesis). Minimum and default of -1 (forever), maximum of 10000.</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }

    /// <summary>The number of batches to process from each shard concurrently. Only available for stream sources (DynamoDB and Kinesis). Minimum and default of 1, maximum of 10.</summary>
    [JsonPropertyName("parallelizationFactor")]
    public double? ParallelizationFactor { get; set; }

    /// <summary>The name of the Amazon MQ broker destination queue to consume. Only available for MQ sources. The list must contain exactly one queue name.</summary>
    [JsonPropertyName("queues")]
    public IList<string>? Queues { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Scaling configuration of the event source. Only available for SQS queues. Detailed below.</summary>
    [JsonPropertyName("scalingConfig")]
    public IList<V1beta1EventSourceMappingSpecForProviderScalingConfig>? ScalingConfig { get; set; }

    /// <summary>For Self Managed Kafka sources, the location of the self managed cluster. If set, configuration must also include source_access_configuration. Detailed below.</summary>
    [JsonPropertyName("selfManagedEventSource")]
    public IList<V1beta1EventSourceMappingSpecForProviderSelfManagedEventSource>? SelfManagedEventSource { get; set; }

    /// <summary>Additional configuration block for Self Managed Kafka sources. Incompatible with "event_source_arn" and "amazon_managed_kafka_event_source_config". Detailed below.</summary>
    [JsonPropertyName("selfManagedKafkaEventSourceConfig")]
    public IList<V1beta1EventSourceMappingSpecForProviderSelfManagedKafkaEventSourceConfig>? SelfManagedKafkaEventSourceConfig { get; set; }

    /// <summary>:  For Self Managed Kafka sources, the access configuration for the source. If set, configuration must also include self_managed_event_source. Detailed below.</summary>
    [JsonPropertyName("sourceAccessConfiguration")]
    public IList<V1beta1EventSourceMappingSpecForProviderSourceAccessConfiguration>? SourceAccessConfiguration { get; set; }

    /// <summary>The position in the stream where AWS Lambda should start reading. Must be one of AT_TIMESTAMP (Kinesis only), LATEST or TRIM_HORIZON if getting events from Kinesis, DynamoDB, MSK or Self Managed Apache Kafka. Must not be provided if getting events from SQS. More information about these positions can be found in the AWS DynamoDB Streams API Reference and AWS Kinesis API Reference.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>A timestamp in RFC3339 format of the data record which to start reading when using starting_position set to AT_TIMESTAMP. If a record with this exact timestamp does not exist, the next later record is chosen. If the timestamp is older than the current trim horizon, the oldest available record is chosen.</summary>
    [JsonPropertyName("startingPositionTimestamp")]
    public string? StartingPositionTimestamp { get; set; }

    /// <summary>The name of the Kafka topics. Only available for MSK sources. A single topic name must be specified.</summary>
    [JsonPropertyName("topics")]
    public IList<string>? Topics { get; set; }

    /// <summary>The duration in seconds of a processing window for AWS Lambda streaming analytics. The range is between 1 second up to 900 seconds. Only available for stream sources (DynamoDB and Kinesis).</summary>
    [JsonPropertyName("tumblingWindowInSeconds")]
    public double? TumblingWindowInSeconds { get; set; }
}

public partial class V1beta1EventSourceMappingSpecInitProviderAmazonManagedKafkaEventSourceConfig
{
    /// <summary>A Kafka consumer group ID between 1 and 200 characters for use when creating this event source mapping. If one is not specified, this value will be automatically generated. See AmazonManagedKafkaEventSourceConfig Syntax.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }
}

public partial class V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailure
{
    /// <summary>The Amazon Resource Name (ARN) of the destination resource.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }
}

public partial class V1beta1EventSourceMappingSpecInitProviderDestinationConfig
{
    /// <summary>The destination configuration for failed invocations. Detailed below.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1beta1EventSourceMappingSpecInitProviderDestinationConfigOnFailure>? OnFailure { get; set; }
}

public partial class V1beta1EventSourceMappingSpecInitProviderDocumentDbEventSourceConfig
{
    /// <summary>The name of the collection to consume within the database. If you do not specify a collection, Lambda consumes all collections.</summary>
    [JsonPropertyName("collectionName")]
    public string? CollectionName { get; set; }

    /// <summary>The name of the database to consume within the DocumentDB cluster.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Determines what DocumentDB sends to your event stream during document update operations. If set to UpdateLookup, DocumentDB sends a delta describing the changes, along with a copy of the entire document. Otherwise, DocumentDB sends only a partial document that contains the changes. Valid values: UpdateLookup, Default.</summary>
    [JsonPropertyName("fullDocument")]
    public string? FullDocument { get; set; }
}

public partial class V1beta1EventSourceMappingSpecInitProviderFilterCriteriaFilter
{
    /// <summary>A filter pattern up to 4096 characters. See Filter Rule Syntax.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1EventSourceMappingSpecInitProviderFilterCriteria
{
    /// <summary>A set of up to 5 filter. If an event satisfies at least one, Lambda sends the event to the function or adds it to the next batch. Detailed below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1EventSourceMappingSpecInitProviderFilterCriteriaFilter>? Filter { get; set; }
}

public enum V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicyResolutionEnum>))]
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicyResolveEnum>))]
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EventSourceMappingSpecInitProviderFunctionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicyResolutionEnum>))]
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicyResolveEnum>))]
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EventSourceMappingSpecInitProviderFunctionNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1EventSourceMappingSpecInitProviderScalingConfig
{
    /// <summary>Limits the number of concurrent instances that the Amazon SQS event source can invoke. Must be between 2 and 1000. See Configuring maximum concurrency for Amazon SQS event sources.</summary>
    [JsonPropertyName("maximumConcurrency")]
    public double? MaximumConcurrency { get; set; }
}

public partial class V1beta1EventSourceMappingSpecInitProviderSelfManagedEventSource
{
    /// <summary>A map of endpoints for the self managed source.  For Kafka self-managed sources, the key should be KAFKA_BOOTSTRAP_SERVERS and the value should be a string with a comma separated list of broker endpoints.</summary>
    [JsonPropertyName("endpoints")]
    public IDictionary<string, string>? Endpoints { get; set; }
}

public partial class V1beta1EventSourceMappingSpecInitProviderSelfManagedKafkaEventSourceConfig
{
    /// <summary>A Kafka consumer group ID between 1 and 200 characters for use when creating this event source mapping. If one is not specified, this value will be automatically generated. See SelfManagedKafkaEventSourceConfig Syntax.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }
}

public partial class V1beta1EventSourceMappingSpecInitProviderSourceAccessConfiguration
{
    /// <summary>The type of authentication protocol, VPC components, or virtual host for your event source. For valid values, refer to the AWS documentation.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The URI for this configuration.  For type VPC_SUBNET the value should be subnet:subnet_id where subnet_id is the value you would find in an aws_subnet resource's id attribute.  For type VPC_SECURITY_GROUP the value should be security_group:security_group_id where security_group_id is the value you would find in an aws_security_group resource's id attribute.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1EventSourceMappingSpecInitProvider
{
    /// <summary>Additional configuration block for Amazon Managed Kafka sources. Incompatible with "self_managed_event_source" and "self_managed_kafka_event_source_config". Detailed below.</summary>
    [JsonPropertyName("amazonManagedKafkaEventSourceConfig")]
    public IList<V1beta1EventSourceMappingSpecInitProviderAmazonManagedKafkaEventSourceConfig>? AmazonManagedKafkaEventSourceConfig { get; set; }

    /// <summary>The largest number of records that Lambda will retrieve from your event source at the time of invocation. Defaults to 100 for DynamoDB, Kinesis, MQ and MSK, 10 for SQS.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>If the function returns an error, split the batch in two and retry. Only available for stream sources (DynamoDB and Kinesis). Defaults to false.</summary>
    [JsonPropertyName("bisectBatchOnFunctionError")]
    public bool? BisectBatchOnFunctionError { get; set; }

    /// <summary>An Amazon SQS queue, Amazon SNS topic or Amazon S3 bucket (only available for Kafka sources) destination for failed records. Only available for stream sources (DynamoDB and Kinesis) and Kafka sources (Amazon MSK and Self-managed Apache Kafka). Detailed below.</summary>
    [JsonPropertyName("destinationConfig")]
    public IList<V1beta1EventSourceMappingSpecInitProviderDestinationConfig>? DestinationConfig { get; set; }

    /// <summary>Configuration settings for a DocumentDB event source. Detailed below.</summary>
    [JsonPropertyName("documentDbEventSourceConfig")]
    public IList<V1beta1EventSourceMappingSpecInitProviderDocumentDbEventSourceConfig>? DocumentDbEventSourceConfig { get; set; }

    /// <summary>Determines if the mapping will be enabled on creation. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The event source ARN - this is required for Kinesis stream, DynamoDB stream, SQS queue, MQ broker, MSK cluster or DocumentDB change stream.  It is incompatible with a Self Managed Kafka source.</summary>
    [JsonPropertyName("eventSourceArn")]
    public string? EventSourceArn { get; set; }

    /// <summary>The criteria to use for event filtering Kinesis stream, DynamoDB stream, SQS queue event sources. Detailed below.</summary>
    [JsonPropertyName("filterCriteria")]
    public IList<V1beta1EventSourceMappingSpecInitProviderFilterCriteria>? FilterCriteria { get; set; }

    /// <summary>The name or the ARN of the Lambda function that will be subscribing to events.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>Reference to a Function in lambda to populate functionName.</summary>
    [JsonPropertyName("functionNameRef")]
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameRef? FunctionNameRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate functionName.</summary>
    [JsonPropertyName("functionNameSelector")]
    public V1beta1EventSourceMappingSpecInitProviderFunctionNameSelector? FunctionNameSelector { get; set; }

    /// <summary>A list of current response type enums applied to the event source mapping for AWS Lambda checkpointing. Only available for SQS and stream sources (DynamoDB and Kinesis). Valid values: ReportBatchItemFailures.</summary>
    [JsonPropertyName("functionResponseTypes")]
    public IList<string>? FunctionResponseTypes { get; set; }

    /// <summary>The maximum amount of time to gather records before invoking the function, in seconds (between 0 and 300). Records will continue to buffer (or accumulate in the case of an SQS queue event source) until either maximum_batching_window_in_seconds expires or batch_size has been met. For streaming event sources, defaults to as soon as records are available in the stream. If the batch it reads from the stream/queue only has one record in it, Lambda only sends one record to the function. Only available for stream sources (DynamoDB and Kinesis) and SQS standard queues.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>The maximum age of a record that Lambda sends to a function for processing. Only available for stream sources (DynamoDB and Kinesis). Must be either -1 (forever, and the default value) or between 60 and 604800 (inclusive).</summary>
    [JsonPropertyName("maximumRecordAgeInSeconds")]
    public double? MaximumRecordAgeInSeconds { get; set; }

    /// <summary>The maximum number of times to retry when the function returns an error. Only available for stream sources (DynamoDB and Kinesis). Minimum and default of -1 (forever), maximum of 10000.</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }

    /// <summary>The number of batches to process from each shard concurrently. Only available for stream sources (DynamoDB and Kinesis). Minimum and default of 1, maximum of 10.</summary>
    [JsonPropertyName("parallelizationFactor")]
    public double? ParallelizationFactor { get; set; }

    /// <summary>The name of the Amazon MQ broker destination queue to consume. Only available for MQ sources. The list must contain exactly one queue name.</summary>
    [JsonPropertyName("queues")]
    public IList<string>? Queues { get; set; }

    /// <summary>Scaling configuration of the event source. Only available for SQS queues. Detailed below.</summary>
    [JsonPropertyName("scalingConfig")]
    public IList<V1beta1EventSourceMappingSpecInitProviderScalingConfig>? ScalingConfig { get; set; }

    /// <summary>For Self Managed Kafka sources, the location of the self managed cluster. If set, configuration must also include source_access_configuration. Detailed below.</summary>
    [JsonPropertyName("selfManagedEventSource")]
    public IList<V1beta1EventSourceMappingSpecInitProviderSelfManagedEventSource>? SelfManagedEventSource { get; set; }

    /// <summary>Additional configuration block for Self Managed Kafka sources. Incompatible with "event_source_arn" and "amazon_managed_kafka_event_source_config". Detailed below.</summary>
    [JsonPropertyName("selfManagedKafkaEventSourceConfig")]
    public IList<V1beta1EventSourceMappingSpecInitProviderSelfManagedKafkaEventSourceConfig>? SelfManagedKafkaEventSourceConfig { get; set; }

    /// <summary>:  For Self Managed Kafka sources, the access configuration for the source. If set, configuration must also include self_managed_event_source. Detailed below.</summary>
    [JsonPropertyName("sourceAccessConfiguration")]
    public IList<V1beta1EventSourceMappingSpecInitProviderSourceAccessConfiguration>? SourceAccessConfiguration { get; set; }

    /// <summary>The position in the stream where AWS Lambda should start reading. Must be one of AT_TIMESTAMP (Kinesis only), LATEST or TRIM_HORIZON if getting events from Kinesis, DynamoDB, MSK or Self Managed Apache Kafka. Must not be provided if getting events from SQS. More information about these positions can be found in the AWS DynamoDB Streams API Reference and AWS Kinesis API Reference.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>A timestamp in RFC3339 format of the data record which to start reading when using starting_position set to AT_TIMESTAMP. If a record with this exact timestamp does not exist, the next later record is chosen. If the timestamp is older than the current trim horizon, the oldest available record is chosen.</summary>
    [JsonPropertyName("startingPositionTimestamp")]
    public string? StartingPositionTimestamp { get; set; }

    /// <summary>The name of the Kafka topics. Only available for MSK sources. A single topic name must be specified.</summary>
    [JsonPropertyName("topics")]
    public IList<string>? Topics { get; set; }

    /// <summary>The duration in seconds of a processing window for AWS Lambda streaming analytics. The range is between 1 second up to 900 seconds. Only available for stream sources (DynamoDB and Kinesis).</summary>
    [JsonPropertyName("tumblingWindowInSeconds")]
    public double? TumblingWindowInSeconds { get; set; }
}

public enum V1beta1EventSourceMappingSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1EventSourceMappingSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceMappingSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EventSourceMappingSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1EventSourceMappingSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1EventSourceMappingSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EventSourceMappingSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceMappingSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1EventSourceMappingSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EventSourceMappingSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EventSourceMappingSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1EventSourceMappingSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1EventSourceMappingSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EventSourceMappingSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventSourceMappingSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1EventSourceMappingSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1EventSourceMappingSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1EventSourceMappingSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1EventSourceMappingSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1EventSourceMappingSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1EventSourceMappingSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EventSourceMappingSpecDeletionPolicyEnum>))]
    public V1beta1EventSourceMappingSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EventSourceMappingSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EventSourceMappingSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1EventSourceMappingSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EventSourceMappingSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1EventSourceMappingSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EventSourceMappingSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1EventSourceMappingStatusAtProviderAmazonManagedKafkaEventSourceConfig
{
    /// <summary>A Kafka consumer group ID between 1 and 200 characters for use when creating this event source mapping. If one is not specified, this value will be automatically generated. See AmazonManagedKafkaEventSourceConfig Syntax.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }
}

public partial class V1beta1EventSourceMappingStatusAtProviderDestinationConfigOnFailure
{
    /// <summary>The Amazon Resource Name (ARN) of the destination resource.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }
}

public partial class V1beta1EventSourceMappingStatusAtProviderDestinationConfig
{
    /// <summary>The destination configuration for failed invocations. Detailed below.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1beta1EventSourceMappingStatusAtProviderDestinationConfigOnFailure>? OnFailure { get; set; }
}

public partial class V1beta1EventSourceMappingStatusAtProviderDocumentDbEventSourceConfig
{
    /// <summary>The name of the collection to consume within the database. If you do not specify a collection, Lambda consumes all collections.</summary>
    [JsonPropertyName("collectionName")]
    public string? CollectionName { get; set; }

    /// <summary>The name of the database to consume within the DocumentDB cluster.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Determines what DocumentDB sends to your event stream during document update operations. If set to UpdateLookup, DocumentDB sends a delta describing the changes, along with a copy of the entire document. Otherwise, DocumentDB sends only a partial document that contains the changes. Valid values: UpdateLookup, Default.</summary>
    [JsonPropertyName("fullDocument")]
    public string? FullDocument { get; set; }
}

public partial class V1beta1EventSourceMappingStatusAtProviderFilterCriteriaFilter
{
    /// <summary>A filter pattern up to 4096 characters. See Filter Rule Syntax.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

public partial class V1beta1EventSourceMappingStatusAtProviderFilterCriteria
{
    /// <summary>A set of up to 5 filter. If an event satisfies at least one, Lambda sends the event to the function or adds it to the next batch. Detailed below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1EventSourceMappingStatusAtProviderFilterCriteriaFilter>? Filter { get; set; }
}

public partial class V1beta1EventSourceMappingStatusAtProviderScalingConfig
{
    /// <summary>Limits the number of concurrent instances that the Amazon SQS event source can invoke. Must be between 2 and 1000. See Configuring maximum concurrency for Amazon SQS event sources.</summary>
    [JsonPropertyName("maximumConcurrency")]
    public double? MaximumConcurrency { get; set; }
}

public partial class V1beta1EventSourceMappingStatusAtProviderSelfManagedEventSource
{
    /// <summary>A map of endpoints for the self managed source.  For Kafka self-managed sources, the key should be KAFKA_BOOTSTRAP_SERVERS and the value should be a string with a comma separated list of broker endpoints.</summary>
    [JsonPropertyName("endpoints")]
    public IDictionary<string, string>? Endpoints { get; set; }
}

public partial class V1beta1EventSourceMappingStatusAtProviderSelfManagedKafkaEventSourceConfig
{
    /// <summary>A Kafka consumer group ID between 1 and 200 characters for use when creating this event source mapping. If one is not specified, this value will be automatically generated. See SelfManagedKafkaEventSourceConfig Syntax.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }
}

public partial class V1beta1EventSourceMappingStatusAtProviderSourceAccessConfiguration
{
    /// <summary>The type of authentication protocol, VPC components, or virtual host for your event source. For valid values, refer to the AWS documentation.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The URI for this configuration.  For type VPC_SUBNET the value should be subnet:subnet_id where subnet_id is the value you would find in an aws_subnet resource's id attribute.  For type VPC_SECURITY_GROUP the value should be security_group:security_group_id where security_group_id is the value you would find in an aws_security_group resource's id attribute.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

public partial class V1beta1EventSourceMappingStatusAtProvider
{
    /// <summary>Additional configuration block for Amazon Managed Kafka sources. Incompatible with "self_managed_event_source" and "self_managed_kafka_event_source_config". Detailed below.</summary>
    [JsonPropertyName("amazonManagedKafkaEventSourceConfig")]
    public IList<V1beta1EventSourceMappingStatusAtProviderAmazonManagedKafkaEventSourceConfig>? AmazonManagedKafkaEventSourceConfig { get; set; }

    /// <summary>The largest number of records that Lambda will retrieve from your event source at the time of invocation. Defaults to 100 for DynamoDB, Kinesis, MQ and MSK, 10 for SQS.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>If the function returns an error, split the batch in two and retry. Only available for stream sources (DynamoDB and Kinesis). Defaults to false.</summary>
    [JsonPropertyName("bisectBatchOnFunctionError")]
    public bool? BisectBatchOnFunctionError { get; set; }

    /// <summary>An Amazon SQS queue, Amazon SNS topic or Amazon S3 bucket (only available for Kafka sources) destination for failed records. Only available for stream sources (DynamoDB and Kinesis) and Kafka sources (Amazon MSK and Self-managed Apache Kafka). Detailed below.</summary>
    [JsonPropertyName("destinationConfig")]
    public IList<V1beta1EventSourceMappingStatusAtProviderDestinationConfig>? DestinationConfig { get; set; }

    /// <summary>Configuration settings for a DocumentDB event source. Detailed below.</summary>
    [JsonPropertyName("documentDbEventSourceConfig")]
    public IList<V1beta1EventSourceMappingStatusAtProviderDocumentDbEventSourceConfig>? DocumentDbEventSourceConfig { get; set; }

    /// <summary>Determines if the mapping will be enabled on creation. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The event source ARN - this is required for Kinesis stream, DynamoDB stream, SQS queue, MQ broker, MSK cluster or DocumentDB change stream.  It is incompatible with a Self Managed Kafka source.</summary>
    [JsonPropertyName("eventSourceArn")]
    public string? EventSourceArn { get; set; }

    /// <summary>The criteria to use for event filtering Kinesis stream, DynamoDB stream, SQS queue event sources. Detailed below.</summary>
    [JsonPropertyName("filterCriteria")]
    public IList<V1beta1EventSourceMappingStatusAtProviderFilterCriteria>? FilterCriteria { get; set; }

    /// <summary>The the ARN of the Lambda function the event source mapping is sending events to. (Note: this is a computed value that differs from function_name above.)</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }

    /// <summary>The name or the ARN of the Lambda function that will be subscribing to events.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>A list of current response type enums applied to the event source mapping for AWS Lambda checkpointing. Only available for SQS and stream sources (DynamoDB and Kinesis). Valid values: ReportBatchItemFailures.</summary>
    [JsonPropertyName("functionResponseTypes")]
    public IList<string>? FunctionResponseTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The date this resource was last modified.</summary>
    [JsonPropertyName("lastModified")]
    public string? LastModified { get; set; }

    /// <summary>The result of the last AWS Lambda invocation of your Lambda function.</summary>
    [JsonPropertyName("lastProcessingResult")]
    public string? LastProcessingResult { get; set; }

    /// <summary>The maximum amount of time to gather records before invoking the function, in seconds (between 0 and 300). Records will continue to buffer (or accumulate in the case of an SQS queue event source) until either maximum_batching_window_in_seconds expires or batch_size has been met. For streaming event sources, defaults to as soon as records are available in the stream. If the batch it reads from the stream/queue only has one record in it, Lambda only sends one record to the function. Only available for stream sources (DynamoDB and Kinesis) and SQS standard queues.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>The maximum age of a record that Lambda sends to a function for processing. Only available for stream sources (DynamoDB and Kinesis). Must be either -1 (forever, and the default value) or between 60 and 604800 (inclusive).</summary>
    [JsonPropertyName("maximumRecordAgeInSeconds")]
    public double? MaximumRecordAgeInSeconds { get; set; }

    /// <summary>The maximum number of times to retry when the function returns an error. Only available for stream sources (DynamoDB and Kinesis). Minimum and default of -1 (forever), maximum of 10000.</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }

    /// <summary>The number of batches to process from each shard concurrently. Only available for stream sources (DynamoDB and Kinesis). Minimum and default of 1, maximum of 10.</summary>
    [JsonPropertyName("parallelizationFactor")]
    public double? ParallelizationFactor { get; set; }

    /// <summary>The name of the Amazon MQ broker destination queue to consume. Only available for MQ sources. The list must contain exactly one queue name.</summary>
    [JsonPropertyName("queues")]
    public IList<string>? Queues { get; set; }

    /// <summary>Scaling configuration of the event source. Only available for SQS queues. Detailed below.</summary>
    [JsonPropertyName("scalingConfig")]
    public IList<V1beta1EventSourceMappingStatusAtProviderScalingConfig>? ScalingConfig { get; set; }

    /// <summary>For Self Managed Kafka sources, the location of the self managed cluster. If set, configuration must also include source_access_configuration. Detailed below.</summary>
    [JsonPropertyName("selfManagedEventSource")]
    public IList<V1beta1EventSourceMappingStatusAtProviderSelfManagedEventSource>? SelfManagedEventSource { get; set; }

    /// <summary>Additional configuration block for Self Managed Kafka sources. Incompatible with "event_source_arn" and "amazon_managed_kafka_event_source_config". Detailed below.</summary>
    [JsonPropertyName("selfManagedKafkaEventSourceConfig")]
    public IList<V1beta1EventSourceMappingStatusAtProviderSelfManagedKafkaEventSourceConfig>? SelfManagedKafkaEventSourceConfig { get; set; }

    /// <summary>:  For Self Managed Kafka sources, the access configuration for the source. If set, configuration must also include self_managed_event_source. Detailed below.</summary>
    [JsonPropertyName("sourceAccessConfiguration")]
    public IList<V1beta1EventSourceMappingStatusAtProviderSourceAccessConfiguration>? SourceAccessConfiguration { get; set; }

    /// <summary>The position in the stream where AWS Lambda should start reading. Must be one of AT_TIMESTAMP (Kinesis only), LATEST or TRIM_HORIZON if getting events from Kinesis, DynamoDB, MSK or Self Managed Apache Kafka. Must not be provided if getting events from SQS. More information about these positions can be found in the AWS DynamoDB Streams API Reference and AWS Kinesis API Reference.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>A timestamp in RFC3339 format of the data record which to start reading when using starting_position set to AT_TIMESTAMP. If a record with this exact timestamp does not exist, the next later record is chosen. If the timestamp is older than the current trim horizon, the oldest available record is chosen.</summary>
    [JsonPropertyName("startingPositionTimestamp")]
    public string? StartingPositionTimestamp { get; set; }

    /// <summary>The state of the event source mapping.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The reason the event source mapping is in its current state.</summary>
    [JsonPropertyName("stateTransitionReason")]
    public string? StateTransitionReason { get; set; }

    /// <summary>The name of the Kafka topics. Only available for MSK sources. A single topic name must be specified.</summary>
    [JsonPropertyName("topics")]
    public IList<string>? Topics { get; set; }

    /// <summary>The duration in seconds of a processing window for AWS Lambda streaming analytics. The range is between 1 second up to 900 seconds. Only available for stream sources (DynamoDB and Kinesis).</summary>
    [JsonPropertyName("tumblingWindowInSeconds")]
    public double? TumblingWindowInSeconds { get; set; }

    /// <summary>The UUID of the created event source mapping.</summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

public partial class V1beta1EventSourceMappingStatusConditions
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

public partial class V1beta1EventSourceMappingStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EventSourceMappingStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EventSourceMappingStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EventSourceMapping : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EventSourceMappingSpec>, IStatus<V1beta1EventSourceMappingStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EventSourceMapping";
    public const string KubeGroup = "lambda.aws.upbound.io";
    public const string KubePluralName = "eventsourcemappings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EventSourceMappingSpec defines the desired state of EventSourceMapping</summary>
    [JsonPropertyName("spec")]
    public V1beta1EventSourceMappingSpec Spec { get; set; }

    /// <summary>EventSourceMappingStatus defines the observed state of EventSourceMapping.</summary>
    [JsonPropertyName("status")]
    public V1beta1EventSourceMappingStatus? Status { get; set; }
}