using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pipes.aws.upbound.io;
/// <summary>Contains the HTTP parameters to use when the target is a API Gateway REST endpoint or EventBridge ApiDestination. If you specify an API Gateway REST API or EventBridge ApiDestination as a target, you can use this parameter to specify headers, path parameters, and query string keys/values as part of your target invoking request. If you're using ApiDestinations, the corresponding Connection can also have these values configured. In case of any conflicting keys, values from the Connection take precedence. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderEnrichmentParametersHttpParameters
{
    /// <summary>Key-value mapping of the headers that need to be sent as part of request invoking the API Gateway REST API or EventBridge ApiDestination.</summary>
    [JsonPropertyName("headerParameters")]
    public IDictionary<string, string>? HeaderParameters { get; set; }

    /// <summary>The path parameter values to be used to populate API Gateway REST API or EventBridge ApiDestination path wildcards ("*").</summary>
    [JsonPropertyName("pathParameterValues")]
    public IList<string>? PathParameterValues { get; set; }

    /// <summary>Key-value mapping of the query strings that need to be sent as part of request invoking the API Gateway REST API or EventBridge ApiDestination.</summary>
    [JsonPropertyName("queryStringParameters")]
    public IDictionary<string, string>? QueryStringParameters { get; set; }
}

/// <summary>Parameters to configure enrichment for your pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderEnrichmentParameters
{
    /// <summary>Contains the HTTP parameters to use when the target is a API Gateway REST endpoint or EventBridge ApiDestination. If you specify an API Gateway REST API or EventBridge ApiDestination as a target, you can use this parameter to specify headers, path parameters, and query string keys/values as part of your target invoking request. If you're using ApiDestinations, the corresponding Connection can also have these values configured. In case of any conflicting keys, values from the Connection take precedence. Detailed below.</summary>
    [JsonPropertyName("httpParameters")]
    public V1beta1PipeSpecForProviderEnrichmentParametersHttpParameters? HttpParameters { get; set; }

    /// <summary>Valid JSON text passed to the target. In this case, nothing from the event itself is passed to the target. Maximum length of 8192 characters.</summary>
    [JsonPropertyName("inputTemplate")]
    public string? InputTemplate { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderEnrichmentRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a APIDestination in cloudwatchevents to populate enrichment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderEnrichmentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecForProviderEnrichmentRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderEnrichmentSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a APIDestination in cloudwatchevents to populate enrichment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderEnrichmentSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecForProviderEnrichmentSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate logGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecForProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate logGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecForProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Amazon CloudWatch Logs logging configuration settings for the pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderLogConfigurationCloudwatchLogsLogDestination
{
    /// <summary>Amazon Web Services Resource Name (ARN) for the CloudWatch log group to which EventBridge sends the log records.</summary>
    [JsonPropertyName("logGroupArn")]
    public string? LogGroupArn { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate logGroupArn.</summary>
    [JsonPropertyName("logGroupArnRef")]
    public V1beta1PipeSpecForProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnRef? LogGroupArnRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate logGroupArn.</summary>
    [JsonPropertyName("logGroupArnSelector")]
    public V1beta1PipeSpecForProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnSelector? LogGroupArnSelector { get; set; }
}

/// <summary>Amazon Kinesis Data Firehose logging configuration settings for the pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderLogConfigurationFirehoseLogDestination
{
    /// <summary>Amazon Resource Name (ARN) of the Kinesis Data Firehose delivery stream to which EventBridge delivers the pipe log records.</summary>
    [JsonPropertyName("deliveryStreamArn")]
    public string? DeliveryStreamArn { get; set; }
}

/// <summary>Amazon S3 logging configuration settings for the pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderLogConfigurationS3LogDestination
{
    /// <summary>Name of the Amazon S3 bucket to which EventBridge delivers the log records for the pipe.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon Web Services account that owns the Amazon S3 bucket to which EventBridge delivers the log records for the pipe.</summary>
    [JsonPropertyName("bucketOwner")]
    public string? BucketOwner { get; set; }

    /// <summary>EventBridge format for the log records. Valid values json, plain and w3c.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Prefix text with which to begin Amazon S3 log object names.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Logging configuration settings for the pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderLogConfiguration
{
    /// <summary>Amazon CloudWatch Logs logging configuration settings for the pipe. Detailed below.</summary>
    [JsonPropertyName("cloudwatchLogsLogDestination")]
    public V1beta1PipeSpecForProviderLogConfigurationCloudwatchLogsLogDestination? CloudwatchLogsLogDestination { get; set; }

    /// <summary>Amazon Kinesis Data Firehose logging configuration settings for the pipe. Detailed below.</summary>
    [JsonPropertyName("firehoseLogDestination")]
    public V1beta1PipeSpecForProviderLogConfigurationFirehoseLogDestination? FirehoseLogDestination { get; set; }

    /// <summary>String list that specifies whether the execution data (specifically, the payload, awsRequest, and awsResponse fields) is included in the log messages for this pipe. This applies to all log destinations for the pipe. Valid values ALL.</summary>
    [JsonPropertyName("includeExecutionData")]
    public IList<string>? IncludeExecutionData { get; set; }

    /// <summary>The level of logging detail to include. Valid values OFF, ERROR, INFO and TRACE.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Amazon S3 logging configuration settings for the pipe. Detailed below.</summary>
    [JsonPropertyName("s3LogDestination")]
    public V1beta1PipeSpecForProviderLogConfigurationS3LogDestination? S3LogDestination { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The credentials needed to access the resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersActivemqBrokerParametersCredentials
{
    /// <summary>The ARN of the Secrets Manager secret containing the basic auth credentials.</summary>
    [JsonPropertyName("basicAuth")]
    public string? BasicAuth { get; set; }
}

/// <summary>The parameters for using an Active MQ broker as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersActivemqBrokerParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The credentials needed to access the resource. Detailed below.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1PipeSpecForProviderSourceParametersActivemqBrokerParametersCredentials? Credentials { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>The name of the destination queue to consume. Maximum length of 1000.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }
}

/// <summary>Define the target queue to send dead-letter queue events to. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersDynamodbStreamParametersDeadLetterConfig
{
    /// <summary>The ARN of the Amazon SQS queue specified as the target for the dead-letter queue.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>The parameters for using a DynamoDB stream as a source.  Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersDynamodbStreamParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>Define the target queue to send dead-letter queue events to. Detailed below.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public V1beta1PipeSpecForProviderSourceParametersDynamodbStreamParametersDeadLetterConfig? DeadLetterConfig { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>Discard records older than the specified age. The default value is -1, which sets the maximum age to infinite. When the value is set to infinite, EventBridge never discards old records. Maximum value of 604,800.</summary>
    [JsonPropertyName("maximumRecordAgeInSeconds")]
    public double? MaximumRecordAgeInSeconds { get; set; }

    /// <summary>Discard records after the specified number of retries. The default value is -1, which sets the maximum number of retries to infinite. When MaximumRetryAttempts is infinite, EventBridge retries failed records until the record expires in the event source. Maximum value of 10,000.</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }

    /// <summary>Define how to handle item process failures. AUTOMATIC_BISECT halves each batch and retry each half until all the records are processed or there is one failed message left in the batch. Valid values: AUTOMATIC_BISECT.</summary>
    [JsonPropertyName("onPartialBatchItemFailure")]
    public string? OnPartialBatchItemFailure { get; set; }

    /// <summary>The number of batches to process concurrently from each shard. The default value is 1. Maximum value of 10.</summary>
    [JsonPropertyName("parallelizationFactor")]
    public double? ParallelizationFactor { get; set; }

    /// <summary>The position in a stream from which to start reading. Valid values: TRIM_HORIZON, LATEST.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersFilterCriteriaFilter
{
    /// <summary>The event pattern. At most 4096 characters.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>The collection of event patterns used to filter events. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersFilterCriteria
{
    /// <summary>An array of up to 5 event patterns. Detailed below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1PipeSpecForProviderSourceParametersFilterCriteriaFilter>? Filter { get; set; }
}

/// <summary>Define the target queue to send dead-letter queue events to. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersKinesisStreamParametersDeadLetterConfig
{
    /// <summary>The ARN of the Amazon SQS queue specified as the target for the dead-letter queue.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>The parameters for using a Kinesis stream as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersKinesisStreamParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>Define the target queue to send dead-letter queue events to. Detailed below.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public V1beta1PipeSpecForProviderSourceParametersKinesisStreamParametersDeadLetterConfig? DeadLetterConfig { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>Discard records older than the specified age. The default value is -1, which sets the maximum age to infinite. When the value is set to infinite, EventBridge never discards old records. Maximum value of 604,800.</summary>
    [JsonPropertyName("maximumRecordAgeInSeconds")]
    public double? MaximumRecordAgeInSeconds { get; set; }

    /// <summary>Discard records after the specified number of retries. The default value is -1, which sets the maximum number of retries to infinite. When MaximumRetryAttempts is infinite, EventBridge retries failed records until the record expires in the event source. Maximum value of 10,000.</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }

    /// <summary>Define how to handle item process failures. AUTOMATIC_BISECT halves each batch and retry each half until all the records are processed or there is one failed message left in the batch. Valid values: AUTOMATIC_BISECT.</summary>
    [JsonPropertyName("onPartialBatchItemFailure")]
    public string? OnPartialBatchItemFailure { get; set; }

    /// <summary>The number of batches to process concurrently from each shard. The default value is 1. Maximum value of 10.</summary>
    [JsonPropertyName("parallelizationFactor")]
    public double? ParallelizationFactor { get; set; }

    /// <summary>The position in a stream from which to start reading. Valid values: TRIM_HORIZON, LATEST, AT_TIMESTAMP.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>With StartingPosition set to AT_TIMESTAMP, the time from which to start reading, in Unix time seconds.</summary>
    [JsonPropertyName("startingPositionTimestamp")]
    public string? StartingPositionTimestamp { get; set; }
}

/// <summary>The credentials needed to access the resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersManagedStreamingKafkaParametersCredentials
{
    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("clientCertificateTlsAuth")]
    public string? ClientCertificateTlsAuth { get; set; }

    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("saslScram512Auth")]
    public string? SaslScram512Auth { get; set; }
}

/// <summary>The parameters for using an MSK stream as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersManagedStreamingKafkaParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The name of the destination queue to consume. Maximum value of 200.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }

    /// <summary>The credentials needed to access the resource. Detailed below.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1PipeSpecForProviderSourceParametersManagedStreamingKafkaParametersCredentials? Credentials { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>The position in a stream from which to start reading. Valid values: TRIM_HORIZON, LATEST.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>The name of the topic that the pipe will read from. Maximum length of 249.</summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }
}

/// <summary>The credentials needed to access the resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersRabbitmqBrokerParametersCredentials
{
    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("basicAuth")]
    public string? BasicAuth { get; set; }
}

/// <summary>The parameters for using a Rabbit MQ broker as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersRabbitmqBrokerParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The credentials needed to access the resource. Detailed below.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1PipeSpecForProviderSourceParametersRabbitmqBrokerParametersCredentials? Credentials { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>The name of the destination queue to consume. Maximum length of 1000.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>The name of the virtual host associated with the source broker. Maximum length of 200.</summary>
    [JsonPropertyName("virtualHost")]
    public string? VirtualHost { get; set; }
}

/// <summary>The credentials needed to access the resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersSelfManagedKafkaParametersCredentials
{
    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("basicAuth")]
    public string? BasicAuth { get; set; }

    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("clientCertificateTlsAuth")]
    public string? ClientCertificateTlsAuth { get; set; }

    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("saslScram256Auth")]
    public string? SaslScram256Auth { get; set; }

    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("saslScram512Auth")]
    public string? SaslScram512Auth { get; set; }
}

/// <summary>This structure specifies the VPC subnets and security groups for the stream, and whether a public IP address is to be used. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersSelfManagedKafkaParametersVpc
{
    /// <summary>List of security groups associated with the stream. These security groups must all be in the same VPC. You can specify as many as five security groups. If you do not specify a security group, the default security group for the VPC is used.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>List of the subnets associated with the stream. These subnets must all be in the same VPC. You can specify as many as 16 subnets.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>The parameters for using a self-managed Apache Kafka stream as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersSelfManagedKafkaParameters
{
    /// <summary>An array of server URLs. Maximum number of 2 items, each of maximum length 300.</summary>
    [JsonPropertyName("additionalBootstrapServers")]
    public IList<string>? AdditionalBootstrapServers { get; set; }

    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The name of the destination queue to consume. Maximum value of 200.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }

    /// <summary>The credentials needed to access the resource. Detailed below.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1PipeSpecForProviderSourceParametersSelfManagedKafkaParametersCredentials? Credentials { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>The ARN of the Secrets Manager secret used for certification.</summary>
    [JsonPropertyName("serverRootCaCertificate")]
    public string? ServerRootCaCertificate { get; set; }

    /// <summary>The position in a stream from which to start reading. Valid values: TRIM_HORIZON, LATEST.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>The name of the topic that the pipe will read from. Maximum length of 249.</summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }

    /// <summary>This structure specifies the VPC subnets and security groups for the stream, and whether a public IP address is to be used. Detailed below.</summary>
    [JsonPropertyName("vpc")]
    public V1beta1PipeSpecForProviderSourceParametersSelfManagedKafkaParametersVpc? Vpc { get; set; }
}

/// <summary>The parameters for using a Amazon SQS stream as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParametersSqsQueueParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }
}

/// <summary>Parameters to configure a source for the pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceParameters
{
    /// <summary>The parameters for using an Active MQ broker as a source. Detailed below.</summary>
    [JsonPropertyName("activemqBrokerParameters")]
    public V1beta1PipeSpecForProviderSourceParametersActivemqBrokerParameters? ActivemqBrokerParameters { get; set; }

    /// <summary>The parameters for using a DynamoDB stream as a source.  Detailed below.</summary>
    [JsonPropertyName("dynamodbStreamParameters")]
    public V1beta1PipeSpecForProviderSourceParametersDynamodbStreamParameters? DynamodbStreamParameters { get; set; }

    /// <summary>The collection of event patterns used to filter events. Detailed below.</summary>
    [JsonPropertyName("filterCriteria")]
    public V1beta1PipeSpecForProviderSourceParametersFilterCriteria? FilterCriteria { get; set; }

    /// <summary>The parameters for using a Kinesis stream as a source. Detailed below.</summary>
    [JsonPropertyName("kinesisStreamParameters")]
    public V1beta1PipeSpecForProviderSourceParametersKinesisStreamParameters? KinesisStreamParameters { get; set; }

    /// <summary>The parameters for using an MSK stream as a source. Detailed below.</summary>
    [JsonPropertyName("managedStreamingKafkaParameters")]
    public V1beta1PipeSpecForProviderSourceParametersManagedStreamingKafkaParameters? ManagedStreamingKafkaParameters { get; set; }

    /// <summary>The parameters for using a Rabbit MQ broker as a source. Detailed below.</summary>
    [JsonPropertyName("rabbitmqBrokerParameters")]
    public V1beta1PipeSpecForProviderSourceParametersRabbitmqBrokerParameters? RabbitmqBrokerParameters { get; set; }

    /// <summary>The parameters for using a self-managed Apache Kafka stream as a source. Detailed below.</summary>
    [JsonPropertyName("selfManagedKafkaParameters")]
    public V1beta1PipeSpecForProviderSourceParametersSelfManagedKafkaParameters? SelfManagedKafkaParameters { get; set; }

    /// <summary>The parameters for using a Amazon SQS stream as a source. Detailed below.</summary>
    [JsonPropertyName("sqsQueueParameters")]
    public V1beta1PipeSpecForProviderSourceParametersSqsQueueParameters? SqsQueueParameters { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecForProviderSourceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderSourceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecForProviderSourceSelectorPolicy? Policy { get; set; }
}

/// <summary>The array properties for the submitted job, such as the size of the array. The array size can be between 2 and 10,000. If you specify array properties for a job, it becomes an array job. This parameter is used only if the target is an AWS Batch job. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersBatchJobParametersArrayProperties
{
    /// <summary>The size of the array, if this is an array batch job. Minimum value of 2. Maximum value of 10,000.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersBatchJobParametersContainerOverridesEnvironment
{
    /// <summary>The name of the key-value pair. For environment variables, this is the name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the key-value pair. For environment variables, this is the value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersBatchJobParametersContainerOverridesResourceRequirement
{
    /// <summary>The type of resource to assign to a container. The supported resources include GPU, MEMORY, and VCPU.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The quantity of the specified resource to reserve for the container. The values vary based on the type specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The overrides that are sent to a container. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersBatchJobParametersContainerOverrides
{
    /// <summary>List of commands to send to the container that overrides the default command from the Docker image or the task definition.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>The environment variables to send to the container. You can add new environment variables, which are added to the container at launch, or you can override the existing environment variables from the Docker image or the task definition. Environment variables cannot start with " AWS Batch ". This naming convention is reserved for variables that AWS Batch sets. Detailed below.</summary>
    [JsonPropertyName("environment")]
    public IList<V1beta1PipeSpecForProviderTargetParametersBatchJobParametersContainerOverridesEnvironment>? Environment { get; set; }

    /// <summary>The instance type to use for a multi-node parallel job. This parameter isn't applicable to single-node container jobs or jobs that run on Fargate resources, and shouldn't be provided.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The type and amount of resources to assign to a container. This overrides the settings in the job definition. The supported resources include GPU, MEMORY, and VCPU. Detailed below.</summary>
    [JsonPropertyName("resourceRequirement")]
    public IList<V1beta1PipeSpecForProviderTargetParametersBatchJobParametersContainerOverridesResourceRequirement>? ResourceRequirement { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersBatchJobParametersDependsOn
{
    /// <summary>The job ID of the AWS Batch job that's associated with this dependency.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>The type of the job dependency. Valid Values: N_TO_N, SEQUENTIAL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The retry strategy to use for failed jobs. When a retry strategy is specified here, it overrides the retry strategy defined in the job definition. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersBatchJobParametersRetryStrategy
{
    /// <summary>The number of times to move a job to the RUNNABLE status. If the value of attempts is greater than one, the job is retried on failure the same number of attempts as the value. Maximum value of 10.</summary>
    [JsonPropertyName("attempts")]
    public double? Attempts { get; set; }
}

/// <summary>The parameters for using an AWS Batch job as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersBatchJobParameters
{
    /// <summary>The array properties for the submitted job, such as the size of the array. The array size can be between 2 and 10,000. If you specify array properties for a job, it becomes an array job. This parameter is used only if the target is an AWS Batch job. Detailed below.</summary>
    [JsonPropertyName("arrayProperties")]
    public V1beta1PipeSpecForProviderTargetParametersBatchJobParametersArrayProperties? ArrayProperties { get; set; }

    /// <summary>The overrides that are sent to a container. Detailed below.</summary>
    [JsonPropertyName("containerOverrides")]
    public V1beta1PipeSpecForProviderTargetParametersBatchJobParametersContainerOverrides? ContainerOverrides { get; set; }

    /// <summary>A list of dependencies for the job. A job can depend upon a maximum of 20 jobs. You can specify a SEQUENTIAL type dependency without specifying a job ID for array jobs so that each child array job completes sequentially, starting at index 0. You can also specify an N_TO_N type dependency with a job ID for array jobs. In that case, each index child of this job must wait for the corresponding index child of each dependency to complete before it can begin. Detailed below.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1beta1PipeSpecForProviderTargetParametersBatchJobParametersDependsOn>? DependsOn { get; set; }

    /// <summary>The job definition used by this job. This value can be one of name, name:revision, or the Amazon Resource Name (ARN) for the job definition. If name is specified without a revision then the latest active revision is used.</summary>
    [JsonPropertyName("jobDefinition")]
    public string? JobDefinition { get; set; }

    /// <summary>The name of the job. It can be up to 128 letters long.</summary>
    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }

    /// <summary>Additional parameters passed to the job that replace parameter substitution placeholders that are set in the job definition. Parameters are specified as a key and value pair mapping. Parameters included here override any corresponding parameter defaults from the job definition. Detailed below.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The retry strategy to use for failed jobs. When a retry strategy is specified here, it overrides the retry strategy defined in the job definition. Detailed below.</summary>
    [JsonPropertyName("retryStrategy")]
    public V1beta1PipeSpecForProviderTargetParametersBatchJobParametersRetryStrategy? RetryStrategy { get; set; }
}

/// <summary>The parameters for using an CloudWatch Logs log stream as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersCloudwatchLogsParameters
{
    /// <summary>The name of the log stream.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }

    /// <summary>The time the event occurred, expressed as the number of milliseconds after Jan 1, 1970 00:00:00 UTC. This is the JSON path to the field in the event e.g. $.detail.timestamp</summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersCapacityProviderStrategy
{
    /// <summary>The base value designates how many tasks, at a minimum, to run on the specified capacity provider. Only one capacity provider in a capacity provider strategy can have a base defined. If no value is specified, the default value of 0 is used. Maximum value of 100,000.</summary>
    [JsonPropertyName("base")]
    public double? Base { get; set; }

    /// <summary>The short name of the capacity provider. Maximum value of 255.</summary>
    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    /// <summary>The weight value designates the relative percentage of the total number of tasks launched that should use the specified capacity provider. The weight value is taken into consideration after the base value, if defined, is satisfied. Maximum value of 1,000.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Use this structure to specify the VPC subnets and security groups for the task, and whether a public IP address is to be used. This structure is relevant only for ECS tasks that use the awsvpc network mode. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration
{
    /// <summary>Specifies whether the task's elastic network interface receives a public IP address. You can specify ENABLED only when LaunchType in EcsParameters is set to FARGATE. Valid Values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("assignPublicIp")]
    public string? AssignPublicIp { get; set; }

    /// <summary>Specifies the security groups associated with the task. These security groups must all be in the same VPC. You can specify as many as five security groups. If you do not specify a security group, the default security group for the VPC is used.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Specifies the subnets associated with the task. These subnets must all be in the same VPC. You can specify as many as 16 subnets.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>Use this structure if the Amazon ECS task uses the awsvpc network mode. This structure specifies the VPC subnets and security groups associated with the task, and whether a public IP address is to be used. This structure is required if LaunchType is FARGATE because the awsvpc mode is required for Fargate tasks. If you specify NetworkConfiguration when the target ECS task does not use the awsvpc network mode, the task fails. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersNetworkConfiguration
{
    /// <summary>Use this structure to specify the VPC subnets and security groups for the task, and whether a public IP address is to be used. This structure is relevant only for ECS tasks that use the awsvpc network mode. Detailed below.</summary>
    [JsonPropertyName("awsVpcConfiguration")]
    public V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration? AwsVpcConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironment
{
    /// <summary>The name of the key-value pair. For environment variables, this is the name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the key-value pair. For environment variables, this is the value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironmentFile
{
    /// <summary>The file type to use. The only supported value is s3.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Amazon S3 object containing the environment variable file.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersOverridesContainerOverrideResourceRequirement
{
    /// <summary>The type of resource to assign to a container. The supported values are GPU or InferenceAccelerator.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value for the specified resource type. If the GPU type is used, the value is the number of physical GPUs the Amazon ECS container agent reserves for the container. The number of GPUs that's reserved for all containers in a task can't exceed the number of available GPUs on the container instance that the task is launched on. If the InferenceAccelerator type is used, the value matches the deviceName for an InferenceAccelerator specified in a task definition.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersOverridesContainerOverride
{
    /// <summary>List of commands to send to the container that overrides the default command from the Docker image or the task definition. You must also specify a container name.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>The number of cpu units reserved for the container, instead of the default value from the task definition. You must also specify a container name.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The environment variables to send to the container. You can add new environment variables, which are added to the container at launch, or you can override the existing environment variables from the Docker image or the task definition. You must also specify a container name. Detailed below.</summary>
    [JsonPropertyName("environment")]
    public IList<V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironment>? Environment { get; set; }

    /// <summary>A list of files containing the environment variables to pass to a container, instead of the value from the container definition. Detailed below.</summary>
    [JsonPropertyName("environmentFile")]
    public IList<V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironmentFile>? EnvironmentFile { get; set; }

    /// <summary>The hard limit (in MiB) of memory to present to the container, instead of the default value from the task definition. If your container attempts to exceed the memory specified here, the container is killed. You must also specify a container name.</summary>
    [JsonPropertyName("memory")]
    public double? Memory { get; set; }

    /// <summary>The soft limit (in MiB) of memory to reserve for the container, instead of the default value from the task definition. You must also specify a container name.</summary>
    [JsonPropertyName("memoryReservation")]
    public double? MemoryReservation { get; set; }

    /// <summary>The name of the container that receives the override. This parameter is required if any override is specified.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type and amount of a resource to assign to a container, instead of the default value from the task definition. The only supported resource is a GPU. Detailed below.</summary>
    [JsonPropertyName("resourceRequirement")]
    public IList<V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersOverridesContainerOverrideResourceRequirement>? ResourceRequirement { get; set; }
}

/// <summary>The ephemeral storage setting override for the task.  Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersOverridesEphemeralStorage
{
    /// <summary>The total amount, in GiB, of ephemeral storage to set for the task. The minimum supported value is 21 GiB and the maximum supported value is 200 GiB.</summary>
    [JsonPropertyName("sizeInGib")]
    public double? SizeInGib { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride
{
    /// <summary>The Elastic Inference accelerator device name to override for the task. This parameter must match a deviceName specified in the task definition.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The Elastic Inference accelerator type to use.</summary>
    [JsonPropertyName("deviceType")]
    public string? DeviceType { get; set; }
}

/// <summary>The overrides that are associated with a task. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersOverrides
{
    /// <summary>One or more container overrides that are sent to a task. Detailed below.</summary>
    [JsonPropertyName("containerOverride")]
    public IList<V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersOverridesContainerOverride>? ContainerOverride { get; set; }

    /// <summary>The cpu override for the task.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>The ephemeral storage setting override for the task.  Detailed below.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersOverridesEphemeralStorage? EphemeralStorage { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the task execution IAM role override for the task.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>List of Elastic Inference accelerator overrides for the task. Detailed below.</summary>
    [JsonPropertyName("inferenceAcceleratorOverride")]
    public IList<V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride>? InferenceAcceleratorOverride { get; set; }

    /// <summary>The memory override for the task.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role that containers in this task can assume. All containers in this task are granted the permissions that are specified in this role.</summary>
    [JsonPropertyName("taskRoleArn")]
    public string? TaskRoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersPlacementConstraint
{
    /// <summary>A cluster query language expression to apply to the constraint. You cannot specify an expression if the constraint type is distinctInstance. Maximum length of 2,000.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The type of constraint. Use distinctInstance to ensure that each task in a particular group is running on a different container instance. Use memberOf to restrict the selection to a group of valid candidates. Valid Values: distinctInstance, memberOf.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersPlacementStrategy
{
    /// <summary>The field to apply the placement strategy against. For the spread placement strategy, valid values are instanceId (or host, which has the same effect), or any platform or custom attribute that is applied to a container instance, such as attribute:ecs.availability-zone. For the binpack placement strategy, valid values are cpu and memory. For the random placement strategy, this field is not used. Maximum length of 255.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>The type of placement strategy. The random placement strategy randomly places tasks on available candidates. The spread placement strategy spreads placement across available candidates evenly based on the field parameter. The binpack strategy places tasks on available candidates that have the least available amount of the resource that is specified with the field parameter. For example, if you binpack on memory, a task is placed on the instance with the least amount of remaining memory (but still enough to run the task). Valid Values: random, spread, binpack.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The parameters for using an Amazon ECS task as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersEcsTaskParameters
{
    /// <summary>List of capacity provider strategies to use for the task. If a capacityProviderStrategy is specified, the launchType parameter must be omitted. If no capacityProviderStrategy or launchType is specified, the defaultCapacityProviderStrategy for the cluster is used. Detailed below.</summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>Specifies whether to enable Amazon ECS managed tags for the task. Valid values: true, false.</summary>
    [JsonPropertyName("enableEcsManagedTags")]
    public bool? EnableEcsManagedTags { get; set; }

    /// <summary>Whether or not to enable the execute command functionality for the containers in this task. If true, this enables execute command functionality on all containers in the task. Valid values: true, false.</summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>Specifies an Amazon ECS task group for the task. The maximum length is 255 characters.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. The FARGATE value is supported only in the Regions where AWS Fargate with Amazon ECS is supported. Valid Values: EC2, FARGATE, EXTERNAL</summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>Use this structure if the Amazon ECS task uses the awsvpc network mode. This structure specifies the VPC subnets and security groups associated with the task, and whether a public IP address is to be used. This structure is required if LaunchType is FARGATE because the awsvpc mode is required for Fargate tasks. If you specify NetworkConfiguration when the target ECS task does not use the awsvpc network mode, the task fails. Detailed below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>The overrides that are associated with a task. Detailed below.</summary>
    [JsonPropertyName("overrides")]
    public V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersOverrides? Overrides { get; set; }

    /// <summary>An array of placement constraint objects to use for the task. You can specify up to 10 constraints per task (including constraints in the task definition and those specified at runtime). Detailed below.</summary>
    [JsonPropertyName("placementConstraint")]
    public IList<V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersPlacementConstraint>? PlacementConstraint { get; set; }

    /// <summary>The placement strategy objects to use for the task. You can specify a maximum of five strategy rules per task. Detailed below.</summary>
    [JsonPropertyName("placementStrategy")]
    public IList<V1beta1PipeSpecForProviderTargetParametersEcsTaskParametersPlacementStrategy>? PlacementStrategy { get; set; }

    /// <summary>Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0. This structure is used only if LaunchType is FARGATE.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Specifies whether to propagate the tags from the task definition to the task. If no value is specified, the tags are not propagated. Tags can only be propagated to the task during task creation. To add tags to a task after task creation, use the TagResource API action. Valid Values: TASK_DEFINITION</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>The reference ID to use for the task. Maximum length of 1,024.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>Key-value map of tags that you apply to the task to help you categorize and organize them.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The number of tasks to create based on TaskDefinition. The default is 1.</summary>
    [JsonPropertyName("taskCount")]
    public double? TaskCount { get; set; }

    /// <summary>The ARN of the task definition to use if the event target is an Amazon ECS task.</summary>
    [JsonPropertyName("taskDefinitionArn")]
    public string? TaskDefinitionArn { get; set; }
}

/// <summary>The parameters for using an EventBridge event bus as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersEventbridgeEventBusParameters
{
    /// <summary>A free-form string, with a maximum of 128 characters, used to decide what fields to expect in the event detail.</summary>
    [JsonPropertyName("detailType")]
    public string? DetailType { get; set; }

    /// <summary>The URL subdomain of the endpoint. For example, if the URL for Endpoint is https://abcde.veo.endpoints.event.amazonaws.com, then the EndpointId is abcde.veo.</summary>
    [JsonPropertyName("endpointId")]
    public string? EndpointId { get; set; }

    /// <summary>List of AWS resources, identified by Amazon Resource Name (ARN), which the event primarily concerns. Any number, including zero, may be present.</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>The source of the event. Maximum length of 256.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The time stamp of the event, per RFC3339. If no time stamp is provided, the time stamp of the PutEvents call is used. This is the JSON path to the field in the event e.g. $.detail.timestamp</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>These are custom parameter to be used when the target is an API Gateway REST APIs or EventBridge ApiDestinations. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersHttpParameters
{
    /// <summary>Key-value mapping of the headers that need to be sent as part of request invoking the API Gateway REST API or EventBridge ApiDestination. Detailed below.</summary>
    [JsonPropertyName("headerParameters")]
    public IDictionary<string, string>? HeaderParameters { get; set; }

    /// <summary>The path parameter values to be used to populate API Gateway REST API or EventBridge ApiDestination path wildcards ("*").</summary>
    [JsonPropertyName("pathParameterValues")]
    public IList<string>? PathParameterValues { get; set; }

    /// <summary>Key-value mapping of the query strings that need to be sent as part of request invoking the API Gateway REST API or EventBridge ApiDestination. Detailed below.</summary>
    [JsonPropertyName("queryStringParameters")]
    public IDictionary<string, string>? QueryStringParameters { get; set; }
}

/// <summary>The parameters for using a Kinesis stream as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersKinesisStreamParameters
{
    /// <summary>Determines which shard in the stream the data record is assigned to. Partition keys are Unicode strings with a maximum length limit of 256 characters for each key. Amazon Kinesis Data Streams uses the partition key as input to a hash function that maps the partition key and associated data to a specific shard. Specifically, an MD5 hash function is used to map partition keys to 128-bit integer values and to map associated data records to shards. As a result of this hashing mechanism, all data records with the same partition key map to the same shard within the stream.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }
}

/// <summary>The parameters for using a Lambda function as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersLambdaFunctionParameters
{
    /// <summary>Specify whether to invoke the function synchronously or asynchronously. Valid Values: REQUEST_RESPONSE, FIRE_AND_FORGET.</summary>
    [JsonPropertyName("invocationType")]
    public string? InvocationType { get; set; }
}

/// <summary>These are custom parameters to be used when the target is a Amazon Redshift cluster to invoke the Amazon Redshift Data API BatchExecuteStatement. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersRedshiftDataParameters
{
    /// <summary>The name of the database. Required when authenticating using temporary credentials.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>The database user name. Required when authenticating using temporary credentials.</summary>
    [JsonPropertyName("dbUser")]
    public string? DbUser { get; set; }

    /// <summary>The name or ARN of the secret that enables access to the database. Required when authenticating using Secrets Manager.</summary>
    [JsonPropertyName("secretManagerArn")]
    public string? SecretManagerArn { get; set; }

    /// <summary>List of SQL statements text to run, each of maximum length of 100,000.</summary>
    [JsonPropertyName("sqls")]
    public IList<string>? Sqls { get; set; }

    /// <summary>The name of the SQL statement. You can name the SQL statement when you create it to identify the query.</summary>
    [JsonPropertyName("statementName")]
    public string? StatementName { get; set; }

    /// <summary>Indicates whether to send an event back to EventBridge after the SQL statement runs.</summary>
    [JsonPropertyName("withEvent")]
    public bool? WithEvent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersSagemakerPipelineParametersPipelineParameter
{
    /// <summary>The name of the container that receives the override. This parameter is required if any override is specified.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of parameter to start execution of a SageMaker AI Model Building Pipeline. Maximum length of 1024.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The parameters for using a SageMaker AI pipeline as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersSagemakerPipelineParameters
{
    /// <summary>List of Parameter names and values for SageMaker AI Model Building Pipeline execution. Detailed below.</summary>
    [JsonPropertyName("pipelineParameter")]
    public IList<V1beta1PipeSpecForProviderTargetParametersSagemakerPipelineParametersPipelineParameter>? PipelineParameter { get; set; }
}

/// <summary>The parameters for using a Amazon SQS stream as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersSqsQueueParameters
{
    /// <summary>This parameter applies only to FIFO (first-in-first-out) queues. The token used for deduplication of sent messages.</summary>
    [JsonPropertyName("messageDeduplicationId")]
    public string? MessageDeduplicationId { get; set; }

    /// <summary>The FIFO message group ID to use as the target.</summary>
    [JsonPropertyName("messageGroupId")]
    public string? MessageGroupId { get; set; }
}

/// <summary>The parameters for using a Step Functions state machine as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParametersStepFunctionStateMachineParameters
{
    /// <summary>Specify whether to invoke the function synchronously or asynchronously. Valid Values: REQUEST_RESPONSE, FIRE_AND_FORGET.</summary>
    [JsonPropertyName("invocationType")]
    public string? InvocationType { get; set; }
}

/// <summary>Parameters to configure a target for your pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetParameters
{
    /// <summary>The parameters for using an AWS Batch job as a target. Detailed below.</summary>
    [JsonPropertyName("batchJobParameters")]
    public V1beta1PipeSpecForProviderTargetParametersBatchJobParameters? BatchJobParameters { get; set; }

    /// <summary>The parameters for using an CloudWatch Logs log stream as a target. Detailed below.</summary>
    [JsonPropertyName("cloudwatchLogsParameters")]
    public V1beta1PipeSpecForProviderTargetParametersCloudwatchLogsParameters? CloudwatchLogsParameters { get; set; }

    /// <summary>The parameters for using an Amazon ECS task as a target. Detailed below.</summary>
    [JsonPropertyName("ecsTaskParameters")]
    public V1beta1PipeSpecForProviderTargetParametersEcsTaskParameters? EcsTaskParameters { get; set; }

    /// <summary>The parameters for using an EventBridge event bus as a target. Detailed below.</summary>
    [JsonPropertyName("eventbridgeEventBusParameters")]
    public V1beta1PipeSpecForProviderTargetParametersEventbridgeEventBusParameters? EventbridgeEventBusParameters { get; set; }

    /// <summary>These are custom parameter to be used when the target is an API Gateway REST APIs or EventBridge ApiDestinations. Detailed below.</summary>
    [JsonPropertyName("httpParameters")]
    public V1beta1PipeSpecForProviderTargetParametersHttpParameters? HttpParameters { get; set; }

    /// <summary>Valid JSON text passed to the target. In this case, nothing from the event itself is passed to the target. Maximum length of 8192 characters.</summary>
    [JsonPropertyName("inputTemplate")]
    public string? InputTemplate { get; set; }

    /// <summary>The parameters for using a Kinesis stream as a source. Detailed below.</summary>
    [JsonPropertyName("kinesisStreamParameters")]
    public V1beta1PipeSpecForProviderTargetParametersKinesisStreamParameters? KinesisStreamParameters { get; set; }

    /// <summary>The parameters for using a Lambda function as a target. Detailed below.</summary>
    [JsonPropertyName("lambdaFunctionParameters")]
    public V1beta1PipeSpecForProviderTargetParametersLambdaFunctionParameters? LambdaFunctionParameters { get; set; }

    /// <summary>These are custom parameters to be used when the target is a Amazon Redshift cluster to invoke the Amazon Redshift Data API BatchExecuteStatement. Detailed below.</summary>
    [JsonPropertyName("redshiftDataParameters")]
    public V1beta1PipeSpecForProviderTargetParametersRedshiftDataParameters? RedshiftDataParameters { get; set; }

    /// <summary>The parameters for using a SageMaker AI pipeline as a target. Detailed below.</summary>
    [JsonPropertyName("sagemakerPipelineParameters")]
    public V1beta1PipeSpecForProviderTargetParametersSagemakerPipelineParameters? SagemakerPipelineParameters { get; set; }

    /// <summary>The parameters for using a Amazon SQS stream as a target. Detailed below.</summary>
    [JsonPropertyName("sqsQueueParameters")]
    public V1beta1PipeSpecForProviderTargetParametersSqsQueueParameters? SqsQueueParameters { get; set; }

    /// <summary>The parameters for using a Step Functions state machine as a target. Detailed below.</summary>
    [JsonPropertyName("stepFunctionStateMachineParameters")]
    public V1beta1PipeSpecForProviderTargetParametersStepFunctionStateMachineParameters? StepFunctionStateMachineParameters { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecForProviderTargetRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProviderTargetSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecForProviderTargetSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecForProvider
{
    /// <summary>A description of the pipe. At most 512 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The state the pipe should be in. One of: RUNNING, STOPPED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Enrichment resource of the pipe (typically an ARN). Read more about enrichment in the User Guide.</summary>
    [JsonPropertyName("enrichment")]
    public string? Enrichment { get; set; }

    /// <summary>Parameters to configure enrichment for your pipe. Detailed below.</summary>
    [JsonPropertyName("enrichmentParameters")]
    public V1beta1PipeSpecForProviderEnrichmentParameters? EnrichmentParameters { get; set; }

    /// <summary>Reference to a APIDestination in cloudwatchevents to populate enrichment.</summary>
    [JsonPropertyName("enrichmentRef")]
    public V1beta1PipeSpecForProviderEnrichmentRef? EnrichmentRef { get; set; }

    /// <summary>Selector for a APIDestination in cloudwatchevents to populate enrichment.</summary>
    [JsonPropertyName("enrichmentSelector")]
    public V1beta1PipeSpecForProviderEnrichmentSelector? EnrichmentSelector { get; set; }

    /// <summary>Identifier of the AWS KMS customer managed key for EventBridge to use, if you choose to use a customer managed key to encrypt pipe data. The identifier can be the key Amazon Resource Name (ARN), KeyId, key alias, or key alias ARN. If not set, EventBridge uses an AWS owned key to encrypt pipe data.</summary>
    [JsonPropertyName("kmsKeyIdentifier")]
    public string? KmsKeyIdentifier { get; set; }

    /// <summary>Logging configuration settings for the pipe. Detailed below.</summary>
    [JsonPropertyName("logConfiguration")]
    public V1beta1PipeSpecForProviderLogConfiguration? LogConfiguration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>ARN of the role that allows the pipe to send data to the target.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1PipeSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1PipeSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Source resource of the pipe. This field typically requires an ARN (Amazon Resource Name). However, when using a self-managed Kafka cluster, you should use a different format. Instead of an ARN, use 'smk://' followed by the bootstrap server's address.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Parameters to configure a source for the pipe. Detailed below.</summary>
    [JsonPropertyName("sourceParameters")]
    public V1beta1PipeSpecForProviderSourceParameters? SourceParameters { get; set; }

    /// <summary>Reference to a Queue in sqs to populate source.</summary>
    [JsonPropertyName("sourceRef")]
    public V1beta1PipeSpecForProviderSourceRef? SourceRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate source.</summary>
    [JsonPropertyName("sourceSelector")]
    public V1beta1PipeSpecForProviderSourceSelector? SourceSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Target resource of the pipe (typically an ARN).</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Parameters to configure a target for your pipe. Detailed below.</summary>
    [JsonPropertyName("targetParameters")]
    public V1beta1PipeSpecForProviderTargetParameters? TargetParameters { get; set; }

    /// <summary>Reference to a Queue in sqs to populate target.</summary>
    [JsonPropertyName("targetRef")]
    public V1beta1PipeSpecForProviderTargetRef? TargetRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate target.</summary>
    [JsonPropertyName("targetSelector")]
    public V1beta1PipeSpecForProviderTargetSelector? TargetSelector { get; set; }
}

/// <summary>Contains the HTTP parameters to use when the target is a API Gateway REST endpoint or EventBridge ApiDestination. If you specify an API Gateway REST API or EventBridge ApiDestination as a target, you can use this parameter to specify headers, path parameters, and query string keys/values as part of your target invoking request. If you're using ApiDestinations, the corresponding Connection can also have these values configured. In case of any conflicting keys, values from the Connection take precedence. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderEnrichmentParametersHttpParameters
{
    /// <summary>Key-value mapping of the headers that need to be sent as part of request invoking the API Gateway REST API or EventBridge ApiDestination.</summary>
    [JsonPropertyName("headerParameters")]
    public IDictionary<string, string>? HeaderParameters { get; set; }

    /// <summary>The path parameter values to be used to populate API Gateway REST API or EventBridge ApiDestination path wildcards ("*").</summary>
    [JsonPropertyName("pathParameterValues")]
    public IList<string>? PathParameterValues { get; set; }

    /// <summary>Key-value mapping of the query strings that need to be sent as part of request invoking the API Gateway REST API or EventBridge ApiDestination.</summary>
    [JsonPropertyName("queryStringParameters")]
    public IDictionary<string, string>? QueryStringParameters { get; set; }
}

/// <summary>Parameters to configure enrichment for your pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderEnrichmentParameters
{
    /// <summary>Contains the HTTP parameters to use when the target is a API Gateway REST endpoint or EventBridge ApiDestination. If you specify an API Gateway REST API or EventBridge ApiDestination as a target, you can use this parameter to specify headers, path parameters, and query string keys/values as part of your target invoking request. If you're using ApiDestinations, the corresponding Connection can also have these values configured. In case of any conflicting keys, values from the Connection take precedence. Detailed below.</summary>
    [JsonPropertyName("httpParameters")]
    public V1beta1PipeSpecInitProviderEnrichmentParametersHttpParameters? HttpParameters { get; set; }

    /// <summary>Valid JSON text passed to the target. In this case, nothing from the event itself is passed to the target. Maximum length of 8192 characters.</summary>
    [JsonPropertyName("inputTemplate")]
    public string? InputTemplate { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderEnrichmentRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a APIDestination in cloudwatchevents to populate enrichment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderEnrichmentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecInitProviderEnrichmentRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderEnrichmentSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a APIDestination in cloudwatchevents to populate enrichment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderEnrichmentSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecInitProviderEnrichmentSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate logGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecInitProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate logGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecInitProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Amazon CloudWatch Logs logging configuration settings for the pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderLogConfigurationCloudwatchLogsLogDestination
{
    /// <summary>Amazon Web Services Resource Name (ARN) for the CloudWatch log group to which EventBridge sends the log records.</summary>
    [JsonPropertyName("logGroupArn")]
    public string? LogGroupArn { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate logGroupArn.</summary>
    [JsonPropertyName("logGroupArnRef")]
    public V1beta1PipeSpecInitProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnRef? LogGroupArnRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate logGroupArn.</summary>
    [JsonPropertyName("logGroupArnSelector")]
    public V1beta1PipeSpecInitProviderLogConfigurationCloudwatchLogsLogDestinationLogGroupArnSelector? LogGroupArnSelector { get; set; }
}

/// <summary>Amazon Kinesis Data Firehose logging configuration settings for the pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderLogConfigurationFirehoseLogDestination
{
    /// <summary>Amazon Resource Name (ARN) of the Kinesis Data Firehose delivery stream to which EventBridge delivers the pipe log records.</summary>
    [JsonPropertyName("deliveryStreamArn")]
    public string? DeliveryStreamArn { get; set; }
}

/// <summary>Amazon S3 logging configuration settings for the pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderLogConfigurationS3LogDestination
{
    /// <summary>Name of the Amazon S3 bucket to which EventBridge delivers the log records for the pipe.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon Web Services account that owns the Amazon S3 bucket to which EventBridge delivers the log records for the pipe.</summary>
    [JsonPropertyName("bucketOwner")]
    public string? BucketOwner { get; set; }

    /// <summary>EventBridge format for the log records. Valid values json, plain and w3c.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Prefix text with which to begin Amazon S3 log object names.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Logging configuration settings for the pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderLogConfiguration
{
    /// <summary>Amazon CloudWatch Logs logging configuration settings for the pipe. Detailed below.</summary>
    [JsonPropertyName("cloudwatchLogsLogDestination")]
    public V1beta1PipeSpecInitProviderLogConfigurationCloudwatchLogsLogDestination? CloudwatchLogsLogDestination { get; set; }

    /// <summary>Amazon Kinesis Data Firehose logging configuration settings for the pipe. Detailed below.</summary>
    [JsonPropertyName("firehoseLogDestination")]
    public V1beta1PipeSpecInitProviderLogConfigurationFirehoseLogDestination? FirehoseLogDestination { get; set; }

    /// <summary>String list that specifies whether the execution data (specifically, the payload, awsRequest, and awsResponse fields) is included in the log messages for this pipe. This applies to all log destinations for the pipe. Valid values ALL.</summary>
    [JsonPropertyName("includeExecutionData")]
    public IList<string>? IncludeExecutionData { get; set; }

    /// <summary>The level of logging detail to include. Valid values OFF, ERROR, INFO and TRACE.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Amazon S3 logging configuration settings for the pipe. Detailed below.</summary>
    [JsonPropertyName("s3LogDestination")]
    public V1beta1PipeSpecInitProviderLogConfigurationS3LogDestination? S3LogDestination { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>The credentials needed to access the resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersActivemqBrokerParametersCredentials
{
    /// <summary>The ARN of the Secrets Manager secret containing the basic auth credentials.</summary>
    [JsonPropertyName("basicAuth")]
    public string? BasicAuth { get; set; }
}

/// <summary>The parameters for using an Active MQ broker as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersActivemqBrokerParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The credentials needed to access the resource. Detailed below.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1PipeSpecInitProviderSourceParametersActivemqBrokerParametersCredentials? Credentials { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>The name of the destination queue to consume. Maximum length of 1000.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }
}

/// <summary>Define the target queue to send dead-letter queue events to. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersDynamodbStreamParametersDeadLetterConfig
{
    /// <summary>The ARN of the Amazon SQS queue specified as the target for the dead-letter queue.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>The parameters for using a DynamoDB stream as a source.  Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersDynamodbStreamParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>Define the target queue to send dead-letter queue events to. Detailed below.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public V1beta1PipeSpecInitProviderSourceParametersDynamodbStreamParametersDeadLetterConfig? DeadLetterConfig { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>Discard records older than the specified age. The default value is -1, which sets the maximum age to infinite. When the value is set to infinite, EventBridge never discards old records. Maximum value of 604,800.</summary>
    [JsonPropertyName("maximumRecordAgeInSeconds")]
    public double? MaximumRecordAgeInSeconds { get; set; }

    /// <summary>Discard records after the specified number of retries. The default value is -1, which sets the maximum number of retries to infinite. When MaximumRetryAttempts is infinite, EventBridge retries failed records until the record expires in the event source. Maximum value of 10,000.</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }

    /// <summary>Define how to handle item process failures. AUTOMATIC_BISECT halves each batch and retry each half until all the records are processed or there is one failed message left in the batch. Valid values: AUTOMATIC_BISECT.</summary>
    [JsonPropertyName("onPartialBatchItemFailure")]
    public string? OnPartialBatchItemFailure { get; set; }

    /// <summary>The number of batches to process concurrently from each shard. The default value is 1. Maximum value of 10.</summary>
    [JsonPropertyName("parallelizationFactor")]
    public double? ParallelizationFactor { get; set; }

    /// <summary>The position in a stream from which to start reading. Valid values: TRIM_HORIZON, LATEST.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersFilterCriteriaFilter
{
    /// <summary>The event pattern. At most 4096 characters.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>The collection of event patterns used to filter events. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersFilterCriteria
{
    /// <summary>An array of up to 5 event patterns. Detailed below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1PipeSpecInitProviderSourceParametersFilterCriteriaFilter>? Filter { get; set; }
}

/// <summary>Define the target queue to send dead-letter queue events to. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersKinesisStreamParametersDeadLetterConfig
{
    /// <summary>The ARN of the Amazon SQS queue specified as the target for the dead-letter queue.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>The parameters for using a Kinesis stream as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersKinesisStreamParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>Define the target queue to send dead-letter queue events to. Detailed below.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public V1beta1PipeSpecInitProviderSourceParametersKinesisStreamParametersDeadLetterConfig? DeadLetterConfig { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>Discard records older than the specified age. The default value is -1, which sets the maximum age to infinite. When the value is set to infinite, EventBridge never discards old records. Maximum value of 604,800.</summary>
    [JsonPropertyName("maximumRecordAgeInSeconds")]
    public double? MaximumRecordAgeInSeconds { get; set; }

    /// <summary>Discard records after the specified number of retries. The default value is -1, which sets the maximum number of retries to infinite. When MaximumRetryAttempts is infinite, EventBridge retries failed records until the record expires in the event source. Maximum value of 10,000.</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }

    /// <summary>Define how to handle item process failures. AUTOMATIC_BISECT halves each batch and retry each half until all the records are processed or there is one failed message left in the batch. Valid values: AUTOMATIC_BISECT.</summary>
    [JsonPropertyName("onPartialBatchItemFailure")]
    public string? OnPartialBatchItemFailure { get; set; }

    /// <summary>The number of batches to process concurrently from each shard. The default value is 1. Maximum value of 10.</summary>
    [JsonPropertyName("parallelizationFactor")]
    public double? ParallelizationFactor { get; set; }

    /// <summary>The position in a stream from which to start reading. Valid values: TRIM_HORIZON, LATEST, AT_TIMESTAMP.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>With StartingPosition set to AT_TIMESTAMP, the time from which to start reading, in Unix time seconds.</summary>
    [JsonPropertyName("startingPositionTimestamp")]
    public string? StartingPositionTimestamp { get; set; }
}

/// <summary>The credentials needed to access the resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersManagedStreamingKafkaParametersCredentials
{
    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("clientCertificateTlsAuth")]
    public string? ClientCertificateTlsAuth { get; set; }

    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("saslScram512Auth")]
    public string? SaslScram512Auth { get; set; }
}

/// <summary>The parameters for using an MSK stream as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersManagedStreamingKafkaParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The name of the destination queue to consume. Maximum value of 200.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }

    /// <summary>The credentials needed to access the resource. Detailed below.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1PipeSpecInitProviderSourceParametersManagedStreamingKafkaParametersCredentials? Credentials { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>The position in a stream from which to start reading. Valid values: TRIM_HORIZON, LATEST.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>The name of the topic that the pipe will read from. Maximum length of 249.</summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }
}

/// <summary>The credentials needed to access the resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersRabbitmqBrokerParametersCredentials
{
    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("basicAuth")]
    public string? BasicAuth { get; set; }
}

/// <summary>The parameters for using a Rabbit MQ broker as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersRabbitmqBrokerParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The credentials needed to access the resource. Detailed below.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1PipeSpecInitProviderSourceParametersRabbitmqBrokerParametersCredentials? Credentials { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>The name of the destination queue to consume. Maximum length of 1000.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>The name of the virtual host associated with the source broker. Maximum length of 200.</summary>
    [JsonPropertyName("virtualHost")]
    public string? VirtualHost { get; set; }
}

/// <summary>The credentials needed to access the resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersSelfManagedKafkaParametersCredentials
{
    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("basicAuth")]
    public string? BasicAuth { get; set; }

    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("clientCertificateTlsAuth")]
    public string? ClientCertificateTlsAuth { get; set; }

    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("saslScram256Auth")]
    public string? SaslScram256Auth { get; set; }

    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("saslScram512Auth")]
    public string? SaslScram512Auth { get; set; }
}

/// <summary>This structure specifies the VPC subnets and security groups for the stream, and whether a public IP address is to be used. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersSelfManagedKafkaParametersVpc
{
    /// <summary>List of security groups associated with the stream. These security groups must all be in the same VPC. You can specify as many as five security groups. If you do not specify a security group, the default security group for the VPC is used.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>List of the subnets associated with the stream. These subnets must all be in the same VPC. You can specify as many as 16 subnets.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>The parameters for using a self-managed Apache Kafka stream as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersSelfManagedKafkaParameters
{
    /// <summary>An array of server URLs. Maximum number of 2 items, each of maximum length 300.</summary>
    [JsonPropertyName("additionalBootstrapServers")]
    public IList<string>? AdditionalBootstrapServers { get; set; }

    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The name of the destination queue to consume. Maximum value of 200.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }

    /// <summary>The credentials needed to access the resource. Detailed below.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1PipeSpecInitProviderSourceParametersSelfManagedKafkaParametersCredentials? Credentials { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>The ARN of the Secrets Manager secret used for certification.</summary>
    [JsonPropertyName("serverRootCaCertificate")]
    public string? ServerRootCaCertificate { get; set; }

    /// <summary>The position in a stream from which to start reading. Valid values: TRIM_HORIZON, LATEST.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>The name of the topic that the pipe will read from. Maximum length of 249.</summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }

    /// <summary>This structure specifies the VPC subnets and security groups for the stream, and whether a public IP address is to be used. Detailed below.</summary>
    [JsonPropertyName("vpc")]
    public V1beta1PipeSpecInitProviderSourceParametersSelfManagedKafkaParametersVpc? Vpc { get; set; }
}

/// <summary>The parameters for using a Amazon SQS stream as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParametersSqsQueueParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }
}

/// <summary>Parameters to configure a source for the pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceParameters
{
    /// <summary>The parameters for using an Active MQ broker as a source. Detailed below.</summary>
    [JsonPropertyName("activemqBrokerParameters")]
    public V1beta1PipeSpecInitProviderSourceParametersActivemqBrokerParameters? ActivemqBrokerParameters { get; set; }

    /// <summary>The parameters for using a DynamoDB stream as a source.  Detailed below.</summary>
    [JsonPropertyName("dynamodbStreamParameters")]
    public V1beta1PipeSpecInitProviderSourceParametersDynamodbStreamParameters? DynamodbStreamParameters { get; set; }

    /// <summary>The collection of event patterns used to filter events. Detailed below.</summary>
    [JsonPropertyName("filterCriteria")]
    public V1beta1PipeSpecInitProviderSourceParametersFilterCriteria? FilterCriteria { get; set; }

    /// <summary>The parameters for using a Kinesis stream as a source. Detailed below.</summary>
    [JsonPropertyName("kinesisStreamParameters")]
    public V1beta1PipeSpecInitProviderSourceParametersKinesisStreamParameters? KinesisStreamParameters { get; set; }

    /// <summary>The parameters for using an MSK stream as a source. Detailed below.</summary>
    [JsonPropertyName("managedStreamingKafkaParameters")]
    public V1beta1PipeSpecInitProviderSourceParametersManagedStreamingKafkaParameters? ManagedStreamingKafkaParameters { get; set; }

    /// <summary>The parameters for using a Rabbit MQ broker as a source. Detailed below.</summary>
    [JsonPropertyName("rabbitmqBrokerParameters")]
    public V1beta1PipeSpecInitProviderSourceParametersRabbitmqBrokerParameters? RabbitmqBrokerParameters { get; set; }

    /// <summary>The parameters for using a self-managed Apache Kafka stream as a source. Detailed below.</summary>
    [JsonPropertyName("selfManagedKafkaParameters")]
    public V1beta1PipeSpecInitProviderSourceParametersSelfManagedKafkaParameters? SelfManagedKafkaParameters { get; set; }

    /// <summary>The parameters for using a Amazon SQS stream as a source. Detailed below.</summary>
    [JsonPropertyName("sqsQueueParameters")]
    public V1beta1PipeSpecInitProviderSourceParametersSqsQueueParameters? SqsQueueParameters { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecInitProviderSourceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderSourceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecInitProviderSourceSelectorPolicy? Policy { get; set; }
}

/// <summary>The array properties for the submitted job, such as the size of the array. The array size can be between 2 and 10,000. If you specify array properties for a job, it becomes an array job. This parameter is used only if the target is an AWS Batch job. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersBatchJobParametersArrayProperties
{
    /// <summary>The size of the array, if this is an array batch job. Minimum value of 2. Maximum value of 10,000.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersBatchJobParametersContainerOverridesEnvironment
{
    /// <summary>The name of the key-value pair. For environment variables, this is the name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the key-value pair. For environment variables, this is the value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersBatchJobParametersContainerOverridesResourceRequirement
{
    /// <summary>The type of resource to assign to a container. The supported resources include GPU, MEMORY, and VCPU.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The quantity of the specified resource to reserve for the container. The values vary based on the type specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The overrides that are sent to a container. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersBatchJobParametersContainerOverrides
{
    /// <summary>List of commands to send to the container that overrides the default command from the Docker image or the task definition.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>The environment variables to send to the container. You can add new environment variables, which are added to the container at launch, or you can override the existing environment variables from the Docker image or the task definition. Environment variables cannot start with " AWS Batch ". This naming convention is reserved for variables that AWS Batch sets. Detailed below.</summary>
    [JsonPropertyName("environment")]
    public IList<V1beta1PipeSpecInitProviderTargetParametersBatchJobParametersContainerOverridesEnvironment>? Environment { get; set; }

    /// <summary>The instance type to use for a multi-node parallel job. This parameter isn't applicable to single-node container jobs or jobs that run on Fargate resources, and shouldn't be provided.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The type and amount of resources to assign to a container. This overrides the settings in the job definition. The supported resources include GPU, MEMORY, and VCPU. Detailed below.</summary>
    [JsonPropertyName("resourceRequirement")]
    public IList<V1beta1PipeSpecInitProviderTargetParametersBatchJobParametersContainerOverridesResourceRequirement>? ResourceRequirement { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersBatchJobParametersDependsOn
{
    /// <summary>The job ID of the AWS Batch job that's associated with this dependency.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>The type of the job dependency. Valid Values: N_TO_N, SEQUENTIAL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The retry strategy to use for failed jobs. When a retry strategy is specified here, it overrides the retry strategy defined in the job definition. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersBatchJobParametersRetryStrategy
{
    /// <summary>The number of times to move a job to the RUNNABLE status. If the value of attempts is greater than one, the job is retried on failure the same number of attempts as the value. Maximum value of 10.</summary>
    [JsonPropertyName("attempts")]
    public double? Attempts { get; set; }
}

/// <summary>The parameters for using an AWS Batch job as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersBatchJobParameters
{
    /// <summary>The array properties for the submitted job, such as the size of the array. The array size can be between 2 and 10,000. If you specify array properties for a job, it becomes an array job. This parameter is used only if the target is an AWS Batch job. Detailed below.</summary>
    [JsonPropertyName("arrayProperties")]
    public V1beta1PipeSpecInitProviderTargetParametersBatchJobParametersArrayProperties? ArrayProperties { get; set; }

    /// <summary>The overrides that are sent to a container. Detailed below.</summary>
    [JsonPropertyName("containerOverrides")]
    public V1beta1PipeSpecInitProviderTargetParametersBatchJobParametersContainerOverrides? ContainerOverrides { get; set; }

    /// <summary>A list of dependencies for the job. A job can depend upon a maximum of 20 jobs. You can specify a SEQUENTIAL type dependency without specifying a job ID for array jobs so that each child array job completes sequentially, starting at index 0. You can also specify an N_TO_N type dependency with a job ID for array jobs. In that case, each index child of this job must wait for the corresponding index child of each dependency to complete before it can begin. Detailed below.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1beta1PipeSpecInitProviderTargetParametersBatchJobParametersDependsOn>? DependsOn { get; set; }

    /// <summary>The job definition used by this job. This value can be one of name, name:revision, or the Amazon Resource Name (ARN) for the job definition. If name is specified without a revision then the latest active revision is used.</summary>
    [JsonPropertyName("jobDefinition")]
    public string? JobDefinition { get; set; }

    /// <summary>The name of the job. It can be up to 128 letters long.</summary>
    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }

    /// <summary>Additional parameters passed to the job that replace parameter substitution placeholders that are set in the job definition. Parameters are specified as a key and value pair mapping. Parameters included here override any corresponding parameter defaults from the job definition. Detailed below.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The retry strategy to use for failed jobs. When a retry strategy is specified here, it overrides the retry strategy defined in the job definition. Detailed below.</summary>
    [JsonPropertyName("retryStrategy")]
    public V1beta1PipeSpecInitProviderTargetParametersBatchJobParametersRetryStrategy? RetryStrategy { get; set; }
}

/// <summary>The parameters for using an CloudWatch Logs log stream as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersCloudwatchLogsParameters
{
    /// <summary>The name of the log stream.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }

    /// <summary>The time the event occurred, expressed as the number of milliseconds after Jan 1, 1970 00:00:00 UTC. This is the JSON path to the field in the event e.g. $.detail.timestamp</summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersCapacityProviderStrategy
{
    /// <summary>The base value designates how many tasks, at a minimum, to run on the specified capacity provider. Only one capacity provider in a capacity provider strategy can have a base defined. If no value is specified, the default value of 0 is used. Maximum value of 100,000.</summary>
    [JsonPropertyName("base")]
    public double? Base { get; set; }

    /// <summary>The short name of the capacity provider. Maximum value of 255.</summary>
    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    /// <summary>The weight value designates the relative percentage of the total number of tasks launched that should use the specified capacity provider. The weight value is taken into consideration after the base value, if defined, is satisfied. Maximum value of 1,000.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Use this structure to specify the VPC subnets and security groups for the task, and whether a public IP address is to be used. This structure is relevant only for ECS tasks that use the awsvpc network mode. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration
{
    /// <summary>Specifies whether the task's elastic network interface receives a public IP address. You can specify ENABLED only when LaunchType in EcsParameters is set to FARGATE. Valid Values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("assignPublicIp")]
    public string? AssignPublicIp { get; set; }

    /// <summary>Specifies the security groups associated with the task. These security groups must all be in the same VPC. You can specify as many as five security groups. If you do not specify a security group, the default security group for the VPC is used.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Specifies the subnets associated with the task. These subnets must all be in the same VPC. You can specify as many as 16 subnets.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>Use this structure if the Amazon ECS task uses the awsvpc network mode. This structure specifies the VPC subnets and security groups associated with the task, and whether a public IP address is to be used. This structure is required if LaunchType is FARGATE because the awsvpc mode is required for Fargate tasks. If you specify NetworkConfiguration when the target ECS task does not use the awsvpc network mode, the task fails. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersNetworkConfiguration
{
    /// <summary>Use this structure to specify the VPC subnets and security groups for the task, and whether a public IP address is to be used. This structure is relevant only for ECS tasks that use the awsvpc network mode. Detailed below.</summary>
    [JsonPropertyName("awsVpcConfiguration")]
    public V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration? AwsVpcConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironment
{
    /// <summary>The name of the key-value pair. For environment variables, this is the name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the key-value pair. For environment variables, this is the value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironmentFile
{
    /// <summary>The file type to use. The only supported value is s3.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Amazon S3 object containing the environment variable file.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersOverridesContainerOverrideResourceRequirement
{
    /// <summary>The type of resource to assign to a container. The supported values are GPU or InferenceAccelerator.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value for the specified resource type. If the GPU type is used, the value is the number of physical GPUs the Amazon ECS container agent reserves for the container. The number of GPUs that's reserved for all containers in a task can't exceed the number of available GPUs on the container instance that the task is launched on. If the InferenceAccelerator type is used, the value matches the deviceName for an InferenceAccelerator specified in a task definition.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersOverridesContainerOverride
{
    /// <summary>List of commands to send to the container that overrides the default command from the Docker image or the task definition. You must also specify a container name.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>The number of cpu units reserved for the container, instead of the default value from the task definition. You must also specify a container name.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The environment variables to send to the container. You can add new environment variables, which are added to the container at launch, or you can override the existing environment variables from the Docker image or the task definition. You must also specify a container name. Detailed below.</summary>
    [JsonPropertyName("environment")]
    public IList<V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironment>? Environment { get; set; }

    /// <summary>A list of files containing the environment variables to pass to a container, instead of the value from the container definition. Detailed below.</summary>
    [JsonPropertyName("environmentFile")]
    public IList<V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironmentFile>? EnvironmentFile { get; set; }

    /// <summary>The hard limit (in MiB) of memory to present to the container, instead of the default value from the task definition. If your container attempts to exceed the memory specified here, the container is killed. You must also specify a container name.</summary>
    [JsonPropertyName("memory")]
    public double? Memory { get; set; }

    /// <summary>The soft limit (in MiB) of memory to reserve for the container, instead of the default value from the task definition. You must also specify a container name.</summary>
    [JsonPropertyName("memoryReservation")]
    public double? MemoryReservation { get; set; }

    /// <summary>The name of the container that receives the override. This parameter is required if any override is specified.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type and amount of a resource to assign to a container, instead of the default value from the task definition. The only supported resource is a GPU. Detailed below.</summary>
    [JsonPropertyName("resourceRequirement")]
    public IList<V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersOverridesContainerOverrideResourceRequirement>? ResourceRequirement { get; set; }
}

/// <summary>The ephemeral storage setting override for the task.  Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersOverridesEphemeralStorage
{
    /// <summary>The total amount, in GiB, of ephemeral storage to set for the task. The minimum supported value is 21 GiB and the maximum supported value is 200 GiB.</summary>
    [JsonPropertyName("sizeInGib")]
    public double? SizeInGib { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride
{
    /// <summary>The Elastic Inference accelerator device name to override for the task. This parameter must match a deviceName specified in the task definition.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The Elastic Inference accelerator type to use.</summary>
    [JsonPropertyName("deviceType")]
    public string? DeviceType { get; set; }
}

/// <summary>The overrides that are associated with a task. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersOverrides
{
    /// <summary>One or more container overrides that are sent to a task. Detailed below.</summary>
    [JsonPropertyName("containerOverride")]
    public IList<V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersOverridesContainerOverride>? ContainerOverride { get; set; }

    /// <summary>The cpu override for the task.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>The ephemeral storage setting override for the task.  Detailed below.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersOverridesEphemeralStorage? EphemeralStorage { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the task execution IAM role override for the task.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>List of Elastic Inference accelerator overrides for the task. Detailed below.</summary>
    [JsonPropertyName("inferenceAcceleratorOverride")]
    public IList<V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride>? InferenceAcceleratorOverride { get; set; }

    /// <summary>The memory override for the task.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role that containers in this task can assume. All containers in this task are granted the permissions that are specified in this role.</summary>
    [JsonPropertyName("taskRoleArn")]
    public string? TaskRoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersPlacementConstraint
{
    /// <summary>A cluster query language expression to apply to the constraint. You cannot specify an expression if the constraint type is distinctInstance. Maximum length of 2,000.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The type of constraint. Use distinctInstance to ensure that each task in a particular group is running on a different container instance. Use memberOf to restrict the selection to a group of valid candidates. Valid Values: distinctInstance, memberOf.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersPlacementStrategy
{
    /// <summary>The field to apply the placement strategy against. For the spread placement strategy, valid values are instanceId (or host, which has the same effect), or any platform or custom attribute that is applied to a container instance, such as attribute:ecs.availability-zone. For the binpack placement strategy, valid values are cpu and memory. For the random placement strategy, this field is not used. Maximum length of 255.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>The type of placement strategy. The random placement strategy randomly places tasks on available candidates. The spread placement strategy spreads placement across available candidates evenly based on the field parameter. The binpack strategy places tasks on available candidates that have the least available amount of the resource that is specified with the field parameter. For example, if you binpack on memory, a task is placed on the instance with the least amount of remaining memory (but still enough to run the task). Valid Values: random, spread, binpack.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The parameters for using an Amazon ECS task as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersEcsTaskParameters
{
    /// <summary>List of capacity provider strategies to use for the task. If a capacityProviderStrategy is specified, the launchType parameter must be omitted. If no capacityProviderStrategy or launchType is specified, the defaultCapacityProviderStrategy for the cluster is used. Detailed below.</summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>Specifies whether to enable Amazon ECS managed tags for the task. Valid values: true, false.</summary>
    [JsonPropertyName("enableEcsManagedTags")]
    public bool? EnableEcsManagedTags { get; set; }

    /// <summary>Whether or not to enable the execute command functionality for the containers in this task. If true, this enables execute command functionality on all containers in the task. Valid values: true, false.</summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>Specifies an Amazon ECS task group for the task. The maximum length is 255 characters.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. The FARGATE value is supported only in the Regions where AWS Fargate with Amazon ECS is supported. Valid Values: EC2, FARGATE, EXTERNAL</summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>Use this structure if the Amazon ECS task uses the awsvpc network mode. This structure specifies the VPC subnets and security groups associated with the task, and whether a public IP address is to be used. This structure is required if LaunchType is FARGATE because the awsvpc mode is required for Fargate tasks. If you specify NetworkConfiguration when the target ECS task does not use the awsvpc network mode, the task fails. Detailed below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>The overrides that are associated with a task. Detailed below.</summary>
    [JsonPropertyName("overrides")]
    public V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersOverrides? Overrides { get; set; }

    /// <summary>An array of placement constraint objects to use for the task. You can specify up to 10 constraints per task (including constraints in the task definition and those specified at runtime). Detailed below.</summary>
    [JsonPropertyName("placementConstraint")]
    public IList<V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersPlacementConstraint>? PlacementConstraint { get; set; }

    /// <summary>The placement strategy objects to use for the task. You can specify a maximum of five strategy rules per task. Detailed below.</summary>
    [JsonPropertyName("placementStrategy")]
    public IList<V1beta1PipeSpecInitProviderTargetParametersEcsTaskParametersPlacementStrategy>? PlacementStrategy { get; set; }

    /// <summary>Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0. This structure is used only if LaunchType is FARGATE.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Specifies whether to propagate the tags from the task definition to the task. If no value is specified, the tags are not propagated. Tags can only be propagated to the task during task creation. To add tags to a task after task creation, use the TagResource API action. Valid Values: TASK_DEFINITION</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>The reference ID to use for the task. Maximum length of 1,024.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>Key-value map of tags that you apply to the task to help you categorize and organize them.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The number of tasks to create based on TaskDefinition. The default is 1.</summary>
    [JsonPropertyName("taskCount")]
    public double? TaskCount { get; set; }

    /// <summary>The ARN of the task definition to use if the event target is an Amazon ECS task.</summary>
    [JsonPropertyName("taskDefinitionArn")]
    public string? TaskDefinitionArn { get; set; }
}

/// <summary>The parameters for using an EventBridge event bus as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersEventbridgeEventBusParameters
{
    /// <summary>A free-form string, with a maximum of 128 characters, used to decide what fields to expect in the event detail.</summary>
    [JsonPropertyName("detailType")]
    public string? DetailType { get; set; }

    /// <summary>The URL subdomain of the endpoint. For example, if the URL for Endpoint is https://abcde.veo.endpoints.event.amazonaws.com, then the EndpointId is abcde.veo.</summary>
    [JsonPropertyName("endpointId")]
    public string? EndpointId { get; set; }

    /// <summary>List of AWS resources, identified by Amazon Resource Name (ARN), which the event primarily concerns. Any number, including zero, may be present.</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>The source of the event. Maximum length of 256.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The time stamp of the event, per RFC3339. If no time stamp is provided, the time stamp of the PutEvents call is used. This is the JSON path to the field in the event e.g. $.detail.timestamp</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>These are custom parameter to be used when the target is an API Gateway REST APIs or EventBridge ApiDestinations. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersHttpParameters
{
    /// <summary>Key-value mapping of the headers that need to be sent as part of request invoking the API Gateway REST API or EventBridge ApiDestination. Detailed below.</summary>
    [JsonPropertyName("headerParameters")]
    public IDictionary<string, string>? HeaderParameters { get; set; }

    /// <summary>The path parameter values to be used to populate API Gateway REST API or EventBridge ApiDestination path wildcards ("*").</summary>
    [JsonPropertyName("pathParameterValues")]
    public IList<string>? PathParameterValues { get; set; }

    /// <summary>Key-value mapping of the query strings that need to be sent as part of request invoking the API Gateway REST API or EventBridge ApiDestination. Detailed below.</summary>
    [JsonPropertyName("queryStringParameters")]
    public IDictionary<string, string>? QueryStringParameters { get; set; }
}

/// <summary>The parameters for using a Kinesis stream as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersKinesisStreamParameters
{
    /// <summary>Determines which shard in the stream the data record is assigned to. Partition keys are Unicode strings with a maximum length limit of 256 characters for each key. Amazon Kinesis Data Streams uses the partition key as input to a hash function that maps the partition key and associated data to a specific shard. Specifically, an MD5 hash function is used to map partition keys to 128-bit integer values and to map associated data records to shards. As a result of this hashing mechanism, all data records with the same partition key map to the same shard within the stream.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }
}

/// <summary>The parameters for using a Lambda function as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersLambdaFunctionParameters
{
    /// <summary>Specify whether to invoke the function synchronously or asynchronously. Valid Values: REQUEST_RESPONSE, FIRE_AND_FORGET.</summary>
    [JsonPropertyName("invocationType")]
    public string? InvocationType { get; set; }
}

/// <summary>These are custom parameters to be used when the target is a Amazon Redshift cluster to invoke the Amazon Redshift Data API BatchExecuteStatement. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersRedshiftDataParameters
{
    /// <summary>The name of the database. Required when authenticating using temporary credentials.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>The database user name. Required when authenticating using temporary credentials.</summary>
    [JsonPropertyName("dbUser")]
    public string? DbUser { get; set; }

    /// <summary>The name or ARN of the secret that enables access to the database. Required when authenticating using Secrets Manager.</summary>
    [JsonPropertyName("secretManagerArn")]
    public string? SecretManagerArn { get; set; }

    /// <summary>List of SQL statements text to run, each of maximum length of 100,000.</summary>
    [JsonPropertyName("sqls")]
    public IList<string>? Sqls { get; set; }

    /// <summary>The name of the SQL statement. You can name the SQL statement when you create it to identify the query.</summary>
    [JsonPropertyName("statementName")]
    public string? StatementName { get; set; }

    /// <summary>Indicates whether to send an event back to EventBridge after the SQL statement runs.</summary>
    [JsonPropertyName("withEvent")]
    public bool? WithEvent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersSagemakerPipelineParametersPipelineParameter
{
    /// <summary>The name of the container that receives the override. This parameter is required if any override is specified.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of parameter to start execution of a SageMaker AI Model Building Pipeline. Maximum length of 1024.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The parameters for using a SageMaker AI pipeline as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersSagemakerPipelineParameters
{
    /// <summary>List of Parameter names and values for SageMaker AI Model Building Pipeline execution. Detailed below.</summary>
    [JsonPropertyName("pipelineParameter")]
    public IList<V1beta1PipeSpecInitProviderTargetParametersSagemakerPipelineParametersPipelineParameter>? PipelineParameter { get; set; }
}

/// <summary>The parameters for using a Amazon SQS stream as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersSqsQueueParameters
{
    /// <summary>This parameter applies only to FIFO (first-in-first-out) queues. The token used for deduplication of sent messages.</summary>
    [JsonPropertyName("messageDeduplicationId")]
    public string? MessageDeduplicationId { get; set; }

    /// <summary>The FIFO message group ID to use as the target.</summary>
    [JsonPropertyName("messageGroupId")]
    public string? MessageGroupId { get; set; }
}

/// <summary>The parameters for using a Step Functions state machine as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParametersStepFunctionStateMachineParameters
{
    /// <summary>Specify whether to invoke the function synchronously or asynchronously. Valid Values: REQUEST_RESPONSE, FIRE_AND_FORGET.</summary>
    [JsonPropertyName("invocationType")]
    public string? InvocationType { get; set; }
}

/// <summary>Parameters to configure a target for your pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetParameters
{
    /// <summary>The parameters for using an AWS Batch job as a target. Detailed below.</summary>
    [JsonPropertyName("batchJobParameters")]
    public V1beta1PipeSpecInitProviderTargetParametersBatchJobParameters? BatchJobParameters { get; set; }

    /// <summary>The parameters for using an CloudWatch Logs log stream as a target. Detailed below.</summary>
    [JsonPropertyName("cloudwatchLogsParameters")]
    public V1beta1PipeSpecInitProviderTargetParametersCloudwatchLogsParameters? CloudwatchLogsParameters { get; set; }

    /// <summary>The parameters for using an Amazon ECS task as a target. Detailed below.</summary>
    [JsonPropertyName("ecsTaskParameters")]
    public V1beta1PipeSpecInitProviderTargetParametersEcsTaskParameters? EcsTaskParameters { get; set; }

    /// <summary>The parameters for using an EventBridge event bus as a target. Detailed below.</summary>
    [JsonPropertyName("eventbridgeEventBusParameters")]
    public V1beta1PipeSpecInitProviderTargetParametersEventbridgeEventBusParameters? EventbridgeEventBusParameters { get; set; }

    /// <summary>These are custom parameter to be used when the target is an API Gateway REST APIs or EventBridge ApiDestinations. Detailed below.</summary>
    [JsonPropertyName("httpParameters")]
    public V1beta1PipeSpecInitProviderTargetParametersHttpParameters? HttpParameters { get; set; }

    /// <summary>Valid JSON text passed to the target. In this case, nothing from the event itself is passed to the target. Maximum length of 8192 characters.</summary>
    [JsonPropertyName("inputTemplate")]
    public string? InputTemplate { get; set; }

    /// <summary>The parameters for using a Kinesis stream as a source. Detailed below.</summary>
    [JsonPropertyName("kinesisStreamParameters")]
    public V1beta1PipeSpecInitProviderTargetParametersKinesisStreamParameters? KinesisStreamParameters { get; set; }

    /// <summary>The parameters for using a Lambda function as a target. Detailed below.</summary>
    [JsonPropertyName("lambdaFunctionParameters")]
    public V1beta1PipeSpecInitProviderTargetParametersLambdaFunctionParameters? LambdaFunctionParameters { get; set; }

    /// <summary>These are custom parameters to be used when the target is a Amazon Redshift cluster to invoke the Amazon Redshift Data API BatchExecuteStatement. Detailed below.</summary>
    [JsonPropertyName("redshiftDataParameters")]
    public V1beta1PipeSpecInitProviderTargetParametersRedshiftDataParameters? RedshiftDataParameters { get; set; }

    /// <summary>The parameters for using a SageMaker AI pipeline as a target. Detailed below.</summary>
    [JsonPropertyName("sagemakerPipelineParameters")]
    public V1beta1PipeSpecInitProviderTargetParametersSagemakerPipelineParameters? SagemakerPipelineParameters { get; set; }

    /// <summary>The parameters for using a Amazon SQS stream as a target. Detailed below.</summary>
    [JsonPropertyName("sqsQueueParameters")]
    public V1beta1PipeSpecInitProviderTargetParametersSqsQueueParameters? SqsQueueParameters { get; set; }

    /// <summary>The parameters for using a Step Functions state machine as a target. Detailed below.</summary>
    [JsonPropertyName("stepFunctionStateMachineParameters")]
    public V1beta1PipeSpecInitProviderTargetParametersStepFunctionStateMachineParameters? StepFunctionStateMachineParameters { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecInitProviderTargetRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProviderTargetSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecInitProviderTargetSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecInitProvider
{
    /// <summary>A description of the pipe. At most 512 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The state the pipe should be in. One of: RUNNING, STOPPED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Enrichment resource of the pipe (typically an ARN). Read more about enrichment in the User Guide.</summary>
    [JsonPropertyName("enrichment")]
    public string? Enrichment { get; set; }

    /// <summary>Parameters to configure enrichment for your pipe. Detailed below.</summary>
    [JsonPropertyName("enrichmentParameters")]
    public V1beta1PipeSpecInitProviderEnrichmentParameters? EnrichmentParameters { get; set; }

    /// <summary>Reference to a APIDestination in cloudwatchevents to populate enrichment.</summary>
    [JsonPropertyName("enrichmentRef")]
    public V1beta1PipeSpecInitProviderEnrichmentRef? EnrichmentRef { get; set; }

    /// <summary>Selector for a APIDestination in cloudwatchevents to populate enrichment.</summary>
    [JsonPropertyName("enrichmentSelector")]
    public V1beta1PipeSpecInitProviderEnrichmentSelector? EnrichmentSelector { get; set; }

    /// <summary>Identifier of the AWS KMS customer managed key for EventBridge to use, if you choose to use a customer managed key to encrypt pipe data. The identifier can be the key Amazon Resource Name (ARN), KeyId, key alias, or key alias ARN. If not set, EventBridge uses an AWS owned key to encrypt pipe data.</summary>
    [JsonPropertyName("kmsKeyIdentifier")]
    public string? KmsKeyIdentifier { get; set; }

    /// <summary>Logging configuration settings for the pipe. Detailed below.</summary>
    [JsonPropertyName("logConfiguration")]
    public V1beta1PipeSpecInitProviderLogConfiguration? LogConfiguration { get; set; }

    /// <summary>ARN of the role that allows the pipe to send data to the target.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1PipeSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1PipeSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Source resource of the pipe. This field typically requires an ARN (Amazon Resource Name). However, when using a self-managed Kafka cluster, you should use a different format. Instead of an ARN, use 'smk://' followed by the bootstrap server's address.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Parameters to configure a source for the pipe. Detailed below.</summary>
    [JsonPropertyName("sourceParameters")]
    public V1beta1PipeSpecInitProviderSourceParameters? SourceParameters { get; set; }

    /// <summary>Reference to a Queue in sqs to populate source.</summary>
    [JsonPropertyName("sourceRef")]
    public V1beta1PipeSpecInitProviderSourceRef? SourceRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate source.</summary>
    [JsonPropertyName("sourceSelector")]
    public V1beta1PipeSpecInitProviderSourceSelector? SourceSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Target resource of the pipe (typically an ARN).</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Parameters to configure a target for your pipe. Detailed below.</summary>
    [JsonPropertyName("targetParameters")]
    public V1beta1PipeSpecInitProviderTargetParameters? TargetParameters { get; set; }

    /// <summary>Reference to a Queue in sqs to populate target.</summary>
    [JsonPropertyName("targetRef")]
    public V1beta1PipeSpecInitProviderTargetRef? TargetRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate target.</summary>
    [JsonPropertyName("targetSelector")]
    public V1beta1PipeSpecInitProviderTargetSelector? TargetSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecProviderConfigRefPolicy
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
public partial class V1beta1PipeSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipeSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecPublishConnectionDetailsToMetadata
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

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PipeSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PipeSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PipeSpec defines the desired state of Pipe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PipeSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PipeSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PipeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PipeSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PipeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Contains the HTTP parameters to use when the target is a API Gateway REST endpoint or EventBridge ApiDestination. If you specify an API Gateway REST API or EventBridge ApiDestination as a target, you can use this parameter to specify headers, path parameters, and query string keys/values as part of your target invoking request. If you're using ApiDestinations, the corresponding Connection can also have these values configured. In case of any conflicting keys, values from the Connection take precedence. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderEnrichmentParametersHttpParameters
{
    /// <summary>Key-value mapping of the headers that need to be sent as part of request invoking the API Gateway REST API or EventBridge ApiDestination.</summary>
    [JsonPropertyName("headerParameters")]
    public IDictionary<string, string>? HeaderParameters { get; set; }

    /// <summary>The path parameter values to be used to populate API Gateway REST API or EventBridge ApiDestination path wildcards ("*").</summary>
    [JsonPropertyName("pathParameterValues")]
    public IList<string>? PathParameterValues { get; set; }

    /// <summary>Key-value mapping of the query strings that need to be sent as part of request invoking the API Gateway REST API or EventBridge ApiDestination.</summary>
    [JsonPropertyName("queryStringParameters")]
    public IDictionary<string, string>? QueryStringParameters { get; set; }
}

/// <summary>Parameters to configure enrichment for your pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderEnrichmentParameters
{
    /// <summary>Contains the HTTP parameters to use when the target is a API Gateway REST endpoint or EventBridge ApiDestination. If you specify an API Gateway REST API or EventBridge ApiDestination as a target, you can use this parameter to specify headers, path parameters, and query string keys/values as part of your target invoking request. If you're using ApiDestinations, the corresponding Connection can also have these values configured. In case of any conflicting keys, values from the Connection take precedence. Detailed below.</summary>
    [JsonPropertyName("httpParameters")]
    public V1beta1PipeStatusAtProviderEnrichmentParametersHttpParameters? HttpParameters { get; set; }

    /// <summary>Valid JSON text passed to the target. In this case, nothing from the event itself is passed to the target. Maximum length of 8192 characters.</summary>
    [JsonPropertyName("inputTemplate")]
    public string? InputTemplate { get; set; }
}

/// <summary>Amazon CloudWatch Logs logging configuration settings for the pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderLogConfigurationCloudwatchLogsLogDestination
{
    /// <summary>Amazon Web Services Resource Name (ARN) for the CloudWatch log group to which EventBridge sends the log records.</summary>
    [JsonPropertyName("logGroupArn")]
    public string? LogGroupArn { get; set; }
}

/// <summary>Amazon Kinesis Data Firehose logging configuration settings for the pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderLogConfigurationFirehoseLogDestination
{
    /// <summary>Amazon Resource Name (ARN) of the Kinesis Data Firehose delivery stream to which EventBridge delivers the pipe log records.</summary>
    [JsonPropertyName("deliveryStreamArn")]
    public string? DeliveryStreamArn { get; set; }
}

/// <summary>Amazon S3 logging configuration settings for the pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderLogConfigurationS3LogDestination
{
    /// <summary>Name of the Amazon S3 bucket to which EventBridge delivers the log records for the pipe.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Amazon Web Services account that owns the Amazon S3 bucket to which EventBridge delivers the log records for the pipe.</summary>
    [JsonPropertyName("bucketOwner")]
    public string? BucketOwner { get; set; }

    /// <summary>EventBridge format for the log records. Valid values json, plain and w3c.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Prefix text with which to begin Amazon S3 log object names.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Logging configuration settings for the pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderLogConfiguration
{
    /// <summary>Amazon CloudWatch Logs logging configuration settings for the pipe. Detailed below.</summary>
    [JsonPropertyName("cloudwatchLogsLogDestination")]
    public V1beta1PipeStatusAtProviderLogConfigurationCloudwatchLogsLogDestination? CloudwatchLogsLogDestination { get; set; }

    /// <summary>Amazon Kinesis Data Firehose logging configuration settings for the pipe. Detailed below.</summary>
    [JsonPropertyName("firehoseLogDestination")]
    public V1beta1PipeStatusAtProviderLogConfigurationFirehoseLogDestination? FirehoseLogDestination { get; set; }

    /// <summary>String list that specifies whether the execution data (specifically, the payload, awsRequest, and awsResponse fields) is included in the log messages for this pipe. This applies to all log destinations for the pipe. Valid values ALL.</summary>
    [JsonPropertyName("includeExecutionData")]
    public IList<string>? IncludeExecutionData { get; set; }

    /// <summary>The level of logging detail to include. Valid values OFF, ERROR, INFO and TRACE.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Amazon S3 logging configuration settings for the pipe. Detailed below.</summary>
    [JsonPropertyName("s3LogDestination")]
    public V1beta1PipeStatusAtProviderLogConfigurationS3LogDestination? S3LogDestination { get; set; }
}

/// <summary>The credentials needed to access the resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersActivemqBrokerParametersCredentials
{
    /// <summary>The ARN of the Secrets Manager secret containing the basic auth credentials.</summary>
    [JsonPropertyName("basicAuth")]
    public string? BasicAuth { get; set; }
}

/// <summary>The parameters for using an Active MQ broker as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersActivemqBrokerParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The credentials needed to access the resource. Detailed below.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1PipeStatusAtProviderSourceParametersActivemqBrokerParametersCredentials? Credentials { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>The name of the destination queue to consume. Maximum length of 1000.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }
}

/// <summary>Define the target queue to send dead-letter queue events to. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersDynamodbStreamParametersDeadLetterConfig
{
    /// <summary>The ARN of the Amazon SQS queue specified as the target for the dead-letter queue.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>The parameters for using a DynamoDB stream as a source.  Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersDynamodbStreamParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>Define the target queue to send dead-letter queue events to. Detailed below.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public V1beta1PipeStatusAtProviderSourceParametersDynamodbStreamParametersDeadLetterConfig? DeadLetterConfig { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>Discard records older than the specified age. The default value is -1, which sets the maximum age to infinite. When the value is set to infinite, EventBridge never discards old records. Maximum value of 604,800.</summary>
    [JsonPropertyName("maximumRecordAgeInSeconds")]
    public double? MaximumRecordAgeInSeconds { get; set; }

    /// <summary>Discard records after the specified number of retries. The default value is -1, which sets the maximum number of retries to infinite. When MaximumRetryAttempts is infinite, EventBridge retries failed records until the record expires in the event source. Maximum value of 10,000.</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }

    /// <summary>Define how to handle item process failures. AUTOMATIC_BISECT halves each batch and retry each half until all the records are processed or there is one failed message left in the batch. Valid values: AUTOMATIC_BISECT.</summary>
    [JsonPropertyName("onPartialBatchItemFailure")]
    public string? OnPartialBatchItemFailure { get; set; }

    /// <summary>The number of batches to process concurrently from each shard. The default value is 1. Maximum value of 10.</summary>
    [JsonPropertyName("parallelizationFactor")]
    public double? ParallelizationFactor { get; set; }

    /// <summary>The position in a stream from which to start reading. Valid values: TRIM_HORIZON, LATEST.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersFilterCriteriaFilter
{
    /// <summary>The event pattern. At most 4096 characters.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>The collection of event patterns used to filter events. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersFilterCriteria
{
    /// <summary>An array of up to 5 event patterns. Detailed below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1PipeStatusAtProviderSourceParametersFilterCriteriaFilter>? Filter { get; set; }
}

/// <summary>Define the target queue to send dead-letter queue events to. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersKinesisStreamParametersDeadLetterConfig
{
    /// <summary>The ARN of the Amazon SQS queue specified as the target for the dead-letter queue.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>The parameters for using a Kinesis stream as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersKinesisStreamParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>Define the target queue to send dead-letter queue events to. Detailed below.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public V1beta1PipeStatusAtProviderSourceParametersKinesisStreamParametersDeadLetterConfig? DeadLetterConfig { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>Discard records older than the specified age. The default value is -1, which sets the maximum age to infinite. When the value is set to infinite, EventBridge never discards old records. Maximum value of 604,800.</summary>
    [JsonPropertyName("maximumRecordAgeInSeconds")]
    public double? MaximumRecordAgeInSeconds { get; set; }

    /// <summary>Discard records after the specified number of retries. The default value is -1, which sets the maximum number of retries to infinite. When MaximumRetryAttempts is infinite, EventBridge retries failed records until the record expires in the event source. Maximum value of 10,000.</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }

    /// <summary>Define how to handle item process failures. AUTOMATIC_BISECT halves each batch and retry each half until all the records are processed or there is one failed message left in the batch. Valid values: AUTOMATIC_BISECT.</summary>
    [JsonPropertyName("onPartialBatchItemFailure")]
    public string? OnPartialBatchItemFailure { get; set; }

    /// <summary>The number of batches to process concurrently from each shard. The default value is 1. Maximum value of 10.</summary>
    [JsonPropertyName("parallelizationFactor")]
    public double? ParallelizationFactor { get; set; }

    /// <summary>The position in a stream from which to start reading. Valid values: TRIM_HORIZON, LATEST, AT_TIMESTAMP.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>With StartingPosition set to AT_TIMESTAMP, the time from which to start reading, in Unix time seconds.</summary>
    [JsonPropertyName("startingPositionTimestamp")]
    public string? StartingPositionTimestamp { get; set; }
}

/// <summary>The credentials needed to access the resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersManagedStreamingKafkaParametersCredentials
{
    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("clientCertificateTlsAuth")]
    public string? ClientCertificateTlsAuth { get; set; }

    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("saslScram512Auth")]
    public string? SaslScram512Auth { get; set; }
}

/// <summary>The parameters for using an MSK stream as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersManagedStreamingKafkaParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The name of the destination queue to consume. Maximum value of 200.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }

    /// <summary>The credentials needed to access the resource. Detailed below.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1PipeStatusAtProviderSourceParametersManagedStreamingKafkaParametersCredentials? Credentials { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>The position in a stream from which to start reading. Valid values: TRIM_HORIZON, LATEST.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>The name of the topic that the pipe will read from. Maximum length of 249.</summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }
}

/// <summary>The credentials needed to access the resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersRabbitmqBrokerParametersCredentials
{
    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("basicAuth")]
    public string? BasicAuth { get; set; }
}

/// <summary>The parameters for using a Rabbit MQ broker as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersRabbitmqBrokerParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The credentials needed to access the resource. Detailed below.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1PipeStatusAtProviderSourceParametersRabbitmqBrokerParametersCredentials? Credentials { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>The name of the destination queue to consume. Maximum length of 1000.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>The name of the virtual host associated with the source broker. Maximum length of 200.</summary>
    [JsonPropertyName("virtualHost")]
    public string? VirtualHost { get; set; }
}

/// <summary>The credentials needed to access the resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersSelfManagedKafkaParametersCredentials
{
    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("basicAuth")]
    public string? BasicAuth { get; set; }

    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("clientCertificateTlsAuth")]
    public string? ClientCertificateTlsAuth { get; set; }

    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("saslScram256Auth")]
    public string? SaslScram256Auth { get; set; }

    /// <summary>The ARN of the Secrets Manager secret containing the credentials.</summary>
    [JsonPropertyName("saslScram512Auth")]
    public string? SaslScram512Auth { get; set; }
}

/// <summary>This structure specifies the VPC subnets and security groups for the stream, and whether a public IP address is to be used. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersSelfManagedKafkaParametersVpc
{
    /// <summary>List of security groups associated with the stream. These security groups must all be in the same VPC. You can specify as many as five security groups. If you do not specify a security group, the default security group for the VPC is used.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>List of the subnets associated with the stream. These subnets must all be in the same VPC. You can specify as many as 16 subnets.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>The parameters for using a self-managed Apache Kafka stream as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersSelfManagedKafkaParameters
{
    /// <summary>An array of server URLs. Maximum number of 2 items, each of maximum length 300.</summary>
    [JsonPropertyName("additionalBootstrapServers")]
    public IList<string>? AdditionalBootstrapServers { get; set; }

    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The name of the destination queue to consume. Maximum value of 200.</summary>
    [JsonPropertyName("consumerGroupId")]
    public string? ConsumerGroupId { get; set; }

    /// <summary>The credentials needed to access the resource. Detailed below.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1PipeStatusAtProviderSourceParametersSelfManagedKafkaParametersCredentials? Credentials { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>The ARN of the Secrets Manager secret used for certification.</summary>
    [JsonPropertyName("serverRootCaCertificate")]
    public string? ServerRootCaCertificate { get; set; }

    /// <summary>The position in a stream from which to start reading. Valid values: TRIM_HORIZON, LATEST.</summary>
    [JsonPropertyName("startingPosition")]
    public string? StartingPosition { get; set; }

    /// <summary>The name of the topic that the pipe will read from. Maximum length of 249.</summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }

    /// <summary>This structure specifies the VPC subnets and security groups for the stream, and whether a public IP address is to be used. Detailed below.</summary>
    [JsonPropertyName("vpc")]
    public V1beta1PipeStatusAtProviderSourceParametersSelfManagedKafkaParametersVpc? Vpc { get; set; }
}

/// <summary>The parameters for using a Amazon SQS stream as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParametersSqsQueueParameters
{
    /// <summary>The maximum number of records to include in each batch. Maximum value of 10000.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The maximum length of a time to wait for events. Maximum value of 300.</summary>
    [JsonPropertyName("maximumBatchingWindowInSeconds")]
    public double? MaximumBatchingWindowInSeconds { get; set; }
}

/// <summary>Parameters to configure a source for the pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderSourceParameters
{
    /// <summary>The parameters for using an Active MQ broker as a source. Detailed below.</summary>
    [JsonPropertyName("activemqBrokerParameters")]
    public V1beta1PipeStatusAtProviderSourceParametersActivemqBrokerParameters? ActivemqBrokerParameters { get; set; }

    /// <summary>The parameters for using a DynamoDB stream as a source.  Detailed below.</summary>
    [JsonPropertyName("dynamodbStreamParameters")]
    public V1beta1PipeStatusAtProviderSourceParametersDynamodbStreamParameters? DynamodbStreamParameters { get; set; }

    /// <summary>The collection of event patterns used to filter events. Detailed below.</summary>
    [JsonPropertyName("filterCriteria")]
    public V1beta1PipeStatusAtProviderSourceParametersFilterCriteria? FilterCriteria { get; set; }

    /// <summary>The parameters for using a Kinesis stream as a source. Detailed below.</summary>
    [JsonPropertyName("kinesisStreamParameters")]
    public V1beta1PipeStatusAtProviderSourceParametersKinesisStreamParameters? KinesisStreamParameters { get; set; }

    /// <summary>The parameters for using an MSK stream as a source. Detailed below.</summary>
    [JsonPropertyName("managedStreamingKafkaParameters")]
    public V1beta1PipeStatusAtProviderSourceParametersManagedStreamingKafkaParameters? ManagedStreamingKafkaParameters { get; set; }

    /// <summary>The parameters for using a Rabbit MQ broker as a source. Detailed below.</summary>
    [JsonPropertyName("rabbitmqBrokerParameters")]
    public V1beta1PipeStatusAtProviderSourceParametersRabbitmqBrokerParameters? RabbitmqBrokerParameters { get; set; }

    /// <summary>The parameters for using a self-managed Apache Kafka stream as a source. Detailed below.</summary>
    [JsonPropertyName("selfManagedKafkaParameters")]
    public V1beta1PipeStatusAtProviderSourceParametersSelfManagedKafkaParameters? SelfManagedKafkaParameters { get; set; }

    /// <summary>The parameters for using a Amazon SQS stream as a source. Detailed below.</summary>
    [JsonPropertyName("sqsQueueParameters")]
    public V1beta1PipeStatusAtProviderSourceParametersSqsQueueParameters? SqsQueueParameters { get; set; }
}

/// <summary>The array properties for the submitted job, such as the size of the array. The array size can be between 2 and 10,000. If you specify array properties for a job, it becomes an array job. This parameter is used only if the target is an AWS Batch job. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersBatchJobParametersArrayProperties
{
    /// <summary>The size of the array, if this is an array batch job. Minimum value of 2. Maximum value of 10,000.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersBatchJobParametersContainerOverridesEnvironment
{
    /// <summary>The name of the key-value pair. For environment variables, this is the name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the key-value pair. For environment variables, this is the value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersBatchJobParametersContainerOverridesResourceRequirement
{
    /// <summary>The type of resource to assign to a container. The supported resources include GPU, MEMORY, and VCPU.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The quantity of the specified resource to reserve for the container. The values vary based on the type specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The overrides that are sent to a container. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersBatchJobParametersContainerOverrides
{
    /// <summary>List of commands to send to the container that overrides the default command from the Docker image or the task definition.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>The environment variables to send to the container. You can add new environment variables, which are added to the container at launch, or you can override the existing environment variables from the Docker image or the task definition. Environment variables cannot start with " AWS Batch ". This naming convention is reserved for variables that AWS Batch sets. Detailed below.</summary>
    [JsonPropertyName("environment")]
    public IList<V1beta1PipeStatusAtProviderTargetParametersBatchJobParametersContainerOverridesEnvironment>? Environment { get; set; }

    /// <summary>The instance type to use for a multi-node parallel job. This parameter isn't applicable to single-node container jobs or jobs that run on Fargate resources, and shouldn't be provided.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The type and amount of resources to assign to a container. This overrides the settings in the job definition. The supported resources include GPU, MEMORY, and VCPU. Detailed below.</summary>
    [JsonPropertyName("resourceRequirement")]
    public IList<V1beta1PipeStatusAtProviderTargetParametersBatchJobParametersContainerOverridesResourceRequirement>? ResourceRequirement { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersBatchJobParametersDependsOn
{
    /// <summary>The job ID of the AWS Batch job that's associated with this dependency.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>The type of the job dependency. Valid Values: N_TO_N, SEQUENTIAL.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The retry strategy to use for failed jobs. When a retry strategy is specified here, it overrides the retry strategy defined in the job definition. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersBatchJobParametersRetryStrategy
{
    /// <summary>The number of times to move a job to the RUNNABLE status. If the value of attempts is greater than one, the job is retried on failure the same number of attempts as the value. Maximum value of 10.</summary>
    [JsonPropertyName("attempts")]
    public double? Attempts { get; set; }
}

/// <summary>The parameters for using an AWS Batch job as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersBatchJobParameters
{
    /// <summary>The array properties for the submitted job, such as the size of the array. The array size can be between 2 and 10,000. If you specify array properties for a job, it becomes an array job. This parameter is used only if the target is an AWS Batch job. Detailed below.</summary>
    [JsonPropertyName("arrayProperties")]
    public V1beta1PipeStatusAtProviderTargetParametersBatchJobParametersArrayProperties? ArrayProperties { get; set; }

    /// <summary>The overrides that are sent to a container. Detailed below.</summary>
    [JsonPropertyName("containerOverrides")]
    public V1beta1PipeStatusAtProviderTargetParametersBatchJobParametersContainerOverrides? ContainerOverrides { get; set; }

    /// <summary>A list of dependencies for the job. A job can depend upon a maximum of 20 jobs. You can specify a SEQUENTIAL type dependency without specifying a job ID for array jobs so that each child array job completes sequentially, starting at index 0. You can also specify an N_TO_N type dependency with a job ID for array jobs. In that case, each index child of this job must wait for the corresponding index child of each dependency to complete before it can begin. Detailed below.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1beta1PipeStatusAtProviderTargetParametersBatchJobParametersDependsOn>? DependsOn { get; set; }

    /// <summary>The job definition used by this job. This value can be one of name, name:revision, or the Amazon Resource Name (ARN) for the job definition. If name is specified without a revision then the latest active revision is used.</summary>
    [JsonPropertyName("jobDefinition")]
    public string? JobDefinition { get; set; }

    /// <summary>The name of the job. It can be up to 128 letters long.</summary>
    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }

    /// <summary>Additional parameters passed to the job that replace parameter substitution placeholders that are set in the job definition. Parameters are specified as a key and value pair mapping. Parameters included here override any corresponding parameter defaults from the job definition. Detailed below.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The retry strategy to use for failed jobs. When a retry strategy is specified here, it overrides the retry strategy defined in the job definition. Detailed below.</summary>
    [JsonPropertyName("retryStrategy")]
    public V1beta1PipeStatusAtProviderTargetParametersBatchJobParametersRetryStrategy? RetryStrategy { get; set; }
}

/// <summary>The parameters for using an CloudWatch Logs log stream as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersCloudwatchLogsParameters
{
    /// <summary>The name of the log stream.</summary>
    [JsonPropertyName("logStreamName")]
    public string? LogStreamName { get; set; }

    /// <summary>The time the event occurred, expressed as the number of milliseconds after Jan 1, 1970 00:00:00 UTC. This is the JSON path to the field in the event e.g. $.detail.timestamp</summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersCapacityProviderStrategy
{
    /// <summary>The base value designates how many tasks, at a minimum, to run on the specified capacity provider. Only one capacity provider in a capacity provider strategy can have a base defined. If no value is specified, the default value of 0 is used. Maximum value of 100,000.</summary>
    [JsonPropertyName("base")]
    public double? Base { get; set; }

    /// <summary>The short name of the capacity provider. Maximum value of 255.</summary>
    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    /// <summary>The weight value designates the relative percentage of the total number of tasks launched that should use the specified capacity provider. The weight value is taken into consideration after the base value, if defined, is satisfied. Maximum value of 1,000.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Use this structure to specify the VPC subnets and security groups for the task, and whether a public IP address is to be used. This structure is relevant only for ECS tasks that use the awsvpc network mode. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration
{
    /// <summary>Specifies whether the task's elastic network interface receives a public IP address. You can specify ENABLED only when LaunchType in EcsParameters is set to FARGATE. Valid Values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("assignPublicIp")]
    public string? AssignPublicIp { get; set; }

    /// <summary>Specifies the security groups associated with the task. These security groups must all be in the same VPC. You can specify as many as five security groups. If you do not specify a security group, the default security group for the VPC is used.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Specifies the subnets associated with the task. These subnets must all be in the same VPC. You can specify as many as 16 subnets.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>Use this structure if the Amazon ECS task uses the awsvpc network mode. This structure specifies the VPC subnets and security groups associated with the task, and whether a public IP address is to be used. This structure is required if LaunchType is FARGATE because the awsvpc mode is required for Fargate tasks. If you specify NetworkConfiguration when the target ECS task does not use the awsvpc network mode, the task fails. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersNetworkConfiguration
{
    /// <summary>Use this structure to specify the VPC subnets and security groups for the task, and whether a public IP address is to be used. This structure is relevant only for ECS tasks that use the awsvpc network mode. Detailed below.</summary>
    [JsonPropertyName("awsVpcConfiguration")]
    public V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration? AwsVpcConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironment
{
    /// <summary>The name of the key-value pair. For environment variables, this is the name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the key-value pair. For environment variables, this is the value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironmentFile
{
    /// <summary>The file type to use. The only supported value is s3.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Amazon S3 object containing the environment variable file.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersOverridesContainerOverrideResourceRequirement
{
    /// <summary>The type of resource to assign to a container. The supported values are GPU or InferenceAccelerator.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value for the specified resource type. If the GPU type is used, the value is the number of physical GPUs the Amazon ECS container agent reserves for the container. The number of GPUs that's reserved for all containers in a task can't exceed the number of available GPUs on the container instance that the task is launched on. If the InferenceAccelerator type is used, the value matches the deviceName for an InferenceAccelerator specified in a task definition.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersOverridesContainerOverride
{
    /// <summary>List of commands to send to the container that overrides the default command from the Docker image or the task definition. You must also specify a container name.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>The number of cpu units reserved for the container, instead of the default value from the task definition. You must also specify a container name.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The environment variables to send to the container. You can add new environment variables, which are added to the container at launch, or you can override the existing environment variables from the Docker image or the task definition. You must also specify a container name. Detailed below.</summary>
    [JsonPropertyName("environment")]
    public IList<V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironment>? Environment { get; set; }

    /// <summary>A list of files containing the environment variables to pass to a container, instead of the value from the container definition. Detailed below.</summary>
    [JsonPropertyName("environmentFile")]
    public IList<V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironmentFile>? EnvironmentFile { get; set; }

    /// <summary>The hard limit (in MiB) of memory to present to the container, instead of the default value from the task definition. If your container attempts to exceed the memory specified here, the container is killed. You must also specify a container name.</summary>
    [JsonPropertyName("memory")]
    public double? Memory { get; set; }

    /// <summary>The soft limit (in MiB) of memory to reserve for the container, instead of the default value from the task definition. You must also specify a container name.</summary>
    [JsonPropertyName("memoryReservation")]
    public double? MemoryReservation { get; set; }

    /// <summary>The name of the container that receives the override. This parameter is required if any override is specified.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type and amount of a resource to assign to a container, instead of the default value from the task definition. The only supported resource is a GPU. Detailed below.</summary>
    [JsonPropertyName("resourceRequirement")]
    public IList<V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersOverridesContainerOverrideResourceRequirement>? ResourceRequirement { get; set; }
}

/// <summary>The ephemeral storage setting override for the task.  Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersOverridesEphemeralStorage
{
    /// <summary>The total amount, in GiB, of ephemeral storage to set for the task. The minimum supported value is 21 GiB and the maximum supported value is 200 GiB.</summary>
    [JsonPropertyName("sizeInGib")]
    public double? SizeInGib { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride
{
    /// <summary>The Elastic Inference accelerator device name to override for the task. This parameter must match a deviceName specified in the task definition.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The Elastic Inference accelerator type to use.</summary>
    [JsonPropertyName("deviceType")]
    public string? DeviceType { get; set; }
}

/// <summary>The overrides that are associated with a task. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersOverrides
{
    /// <summary>One or more container overrides that are sent to a task. Detailed below.</summary>
    [JsonPropertyName("containerOverride")]
    public IList<V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersOverridesContainerOverride>? ContainerOverride { get; set; }

    /// <summary>The cpu override for the task.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>The ephemeral storage setting override for the task.  Detailed below.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersOverridesEphemeralStorage? EphemeralStorage { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the task execution IAM role override for the task.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>List of Elastic Inference accelerator overrides for the task. Detailed below.</summary>
    [JsonPropertyName("inferenceAcceleratorOverride")]
    public IList<V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride>? InferenceAcceleratorOverride { get; set; }

    /// <summary>The memory override for the task.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role that containers in this task can assume. All containers in this task are granted the permissions that are specified in this role.</summary>
    [JsonPropertyName("taskRoleArn")]
    public string? TaskRoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersPlacementConstraint
{
    /// <summary>A cluster query language expression to apply to the constraint. You cannot specify an expression if the constraint type is distinctInstance. Maximum length of 2,000.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The type of constraint. Use distinctInstance to ensure that each task in a particular group is running on a different container instance. Use memberOf to restrict the selection to a group of valid candidates. Valid Values: distinctInstance, memberOf.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersPlacementStrategy
{
    /// <summary>The field to apply the placement strategy against. For the spread placement strategy, valid values are instanceId (or host, which has the same effect), or any platform or custom attribute that is applied to a container instance, such as attribute:ecs.availability-zone. For the binpack placement strategy, valid values are cpu and memory. For the random placement strategy, this field is not used. Maximum length of 255.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>The type of placement strategy. The random placement strategy randomly places tasks on available candidates. The spread placement strategy spreads placement across available candidates evenly based on the field parameter. The binpack strategy places tasks on available candidates that have the least available amount of the resource that is specified with the field parameter. For example, if you binpack on memory, a task is placed on the instance with the least amount of remaining memory (but still enough to run the task). Valid Values: random, spread, binpack.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The parameters for using an Amazon ECS task as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersEcsTaskParameters
{
    /// <summary>List of capacity provider strategies to use for the task. If a capacityProviderStrategy is specified, the launchType parameter must be omitted. If no capacityProviderStrategy or launchType is specified, the defaultCapacityProviderStrategy for the cluster is used. Detailed below.</summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>Specifies whether to enable Amazon ECS managed tags for the task. Valid values: true, false.</summary>
    [JsonPropertyName("enableEcsManagedTags")]
    public bool? EnableEcsManagedTags { get; set; }

    /// <summary>Whether or not to enable the execute command functionality for the containers in this task. If true, this enables execute command functionality on all containers in the task. Valid values: true, false.</summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>Specifies an Amazon ECS task group for the task. The maximum length is 255 characters.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. The FARGATE value is supported only in the Regions where AWS Fargate with Amazon ECS is supported. Valid Values: EC2, FARGATE, EXTERNAL</summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>Use this structure if the Amazon ECS task uses the awsvpc network mode. This structure specifies the VPC subnets and security groups associated with the task, and whether a public IP address is to be used. This structure is required if LaunchType is FARGATE because the awsvpc mode is required for Fargate tasks. If you specify NetworkConfiguration when the target ECS task does not use the awsvpc network mode, the task fails. Detailed below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>The overrides that are associated with a task. Detailed below.</summary>
    [JsonPropertyName("overrides")]
    public V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersOverrides? Overrides { get; set; }

    /// <summary>An array of placement constraint objects to use for the task. You can specify up to 10 constraints per task (including constraints in the task definition and those specified at runtime). Detailed below.</summary>
    [JsonPropertyName("placementConstraint")]
    public IList<V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersPlacementConstraint>? PlacementConstraint { get; set; }

    /// <summary>The placement strategy objects to use for the task. You can specify a maximum of five strategy rules per task. Detailed below.</summary>
    [JsonPropertyName("placementStrategy")]
    public IList<V1beta1PipeStatusAtProviderTargetParametersEcsTaskParametersPlacementStrategy>? PlacementStrategy { get; set; }

    /// <summary>Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0. This structure is used only if LaunchType is FARGATE.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Specifies whether to propagate the tags from the task definition to the task. If no value is specified, the tags are not propagated. Tags can only be propagated to the task during task creation. To add tags to a task after task creation, use the TagResource API action. Valid Values: TASK_DEFINITION</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>The reference ID to use for the task. Maximum length of 1,024.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>Key-value map of tags that you apply to the task to help you categorize and organize them.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The number of tasks to create based on TaskDefinition. The default is 1.</summary>
    [JsonPropertyName("taskCount")]
    public double? TaskCount { get; set; }

    /// <summary>The ARN of the task definition to use if the event target is an Amazon ECS task.</summary>
    [JsonPropertyName("taskDefinitionArn")]
    public string? TaskDefinitionArn { get; set; }
}

/// <summary>The parameters for using an EventBridge event bus as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersEventbridgeEventBusParameters
{
    /// <summary>A free-form string, with a maximum of 128 characters, used to decide what fields to expect in the event detail.</summary>
    [JsonPropertyName("detailType")]
    public string? DetailType { get; set; }

    /// <summary>The URL subdomain of the endpoint. For example, if the URL for Endpoint is https://abcde.veo.endpoints.event.amazonaws.com, then the EndpointId is abcde.veo.</summary>
    [JsonPropertyName("endpointId")]
    public string? EndpointId { get; set; }

    /// <summary>List of AWS resources, identified by Amazon Resource Name (ARN), which the event primarily concerns. Any number, including zero, may be present.</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>The source of the event. Maximum length of 256.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The time stamp of the event, per RFC3339. If no time stamp is provided, the time stamp of the PutEvents call is used. This is the JSON path to the field in the event e.g. $.detail.timestamp</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>These are custom parameter to be used when the target is an API Gateway REST APIs or EventBridge ApiDestinations. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersHttpParameters
{
    /// <summary>Key-value mapping of the headers that need to be sent as part of request invoking the API Gateway REST API or EventBridge ApiDestination. Detailed below.</summary>
    [JsonPropertyName("headerParameters")]
    public IDictionary<string, string>? HeaderParameters { get; set; }

    /// <summary>The path parameter values to be used to populate API Gateway REST API or EventBridge ApiDestination path wildcards ("*").</summary>
    [JsonPropertyName("pathParameterValues")]
    public IList<string>? PathParameterValues { get; set; }

    /// <summary>Key-value mapping of the query strings that need to be sent as part of request invoking the API Gateway REST API or EventBridge ApiDestination. Detailed below.</summary>
    [JsonPropertyName("queryStringParameters")]
    public IDictionary<string, string>? QueryStringParameters { get; set; }
}

/// <summary>The parameters for using a Kinesis stream as a source. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersKinesisStreamParameters
{
    /// <summary>Determines which shard in the stream the data record is assigned to. Partition keys are Unicode strings with a maximum length limit of 256 characters for each key. Amazon Kinesis Data Streams uses the partition key as input to a hash function that maps the partition key and associated data to a specific shard. Specifically, an MD5 hash function is used to map partition keys to 128-bit integer values and to map associated data records to shards. As a result of this hashing mechanism, all data records with the same partition key map to the same shard within the stream.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }
}

/// <summary>The parameters for using a Lambda function as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersLambdaFunctionParameters
{
    /// <summary>Specify whether to invoke the function synchronously or asynchronously. Valid Values: REQUEST_RESPONSE, FIRE_AND_FORGET.</summary>
    [JsonPropertyName("invocationType")]
    public string? InvocationType { get; set; }
}

/// <summary>These are custom parameters to be used when the target is a Amazon Redshift cluster to invoke the Amazon Redshift Data API BatchExecuteStatement. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersRedshiftDataParameters
{
    /// <summary>The name of the database. Required when authenticating using temporary credentials.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>The database user name. Required when authenticating using temporary credentials.</summary>
    [JsonPropertyName("dbUser")]
    public string? DbUser { get; set; }

    /// <summary>The name or ARN of the secret that enables access to the database. Required when authenticating using Secrets Manager.</summary>
    [JsonPropertyName("secretManagerArn")]
    public string? SecretManagerArn { get; set; }

    /// <summary>List of SQL statements text to run, each of maximum length of 100,000.</summary>
    [JsonPropertyName("sqls")]
    public IList<string>? Sqls { get; set; }

    /// <summary>The name of the SQL statement. You can name the SQL statement when you create it to identify the query.</summary>
    [JsonPropertyName("statementName")]
    public string? StatementName { get; set; }

    /// <summary>Indicates whether to send an event back to EventBridge after the SQL statement runs.</summary>
    [JsonPropertyName("withEvent")]
    public bool? WithEvent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersSagemakerPipelineParametersPipelineParameter
{
    /// <summary>The name of the container that receives the override. This parameter is required if any override is specified.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of parameter to start execution of a SageMaker AI Model Building Pipeline. Maximum length of 1024.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The parameters for using a SageMaker AI pipeline as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersSagemakerPipelineParameters
{
    /// <summary>List of Parameter names and values for SageMaker AI Model Building Pipeline execution. Detailed below.</summary>
    [JsonPropertyName("pipelineParameter")]
    public IList<V1beta1PipeStatusAtProviderTargetParametersSagemakerPipelineParametersPipelineParameter>? PipelineParameter { get; set; }
}

/// <summary>The parameters for using a Amazon SQS stream as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersSqsQueueParameters
{
    /// <summary>This parameter applies only to FIFO (first-in-first-out) queues. The token used for deduplication of sent messages.</summary>
    [JsonPropertyName("messageDeduplicationId")]
    public string? MessageDeduplicationId { get; set; }

    /// <summary>The FIFO message group ID to use as the target.</summary>
    [JsonPropertyName("messageGroupId")]
    public string? MessageGroupId { get; set; }
}

/// <summary>The parameters for using a Step Functions state machine as a target. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParametersStepFunctionStateMachineParameters
{
    /// <summary>Specify whether to invoke the function synchronously or asynchronously. Valid Values: REQUEST_RESPONSE, FIRE_AND_FORGET.</summary>
    [JsonPropertyName("invocationType")]
    public string? InvocationType { get; set; }
}

/// <summary>Parameters to configure a target for your pipe. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProviderTargetParameters
{
    /// <summary>The parameters for using an AWS Batch job as a target. Detailed below.</summary>
    [JsonPropertyName("batchJobParameters")]
    public V1beta1PipeStatusAtProviderTargetParametersBatchJobParameters? BatchJobParameters { get; set; }

    /// <summary>The parameters for using an CloudWatch Logs log stream as a target. Detailed below.</summary>
    [JsonPropertyName("cloudwatchLogsParameters")]
    public V1beta1PipeStatusAtProviderTargetParametersCloudwatchLogsParameters? CloudwatchLogsParameters { get; set; }

    /// <summary>The parameters for using an Amazon ECS task as a target. Detailed below.</summary>
    [JsonPropertyName("ecsTaskParameters")]
    public V1beta1PipeStatusAtProviderTargetParametersEcsTaskParameters? EcsTaskParameters { get; set; }

    /// <summary>The parameters for using an EventBridge event bus as a target. Detailed below.</summary>
    [JsonPropertyName("eventbridgeEventBusParameters")]
    public V1beta1PipeStatusAtProviderTargetParametersEventbridgeEventBusParameters? EventbridgeEventBusParameters { get; set; }

    /// <summary>These are custom parameter to be used when the target is an API Gateway REST APIs or EventBridge ApiDestinations. Detailed below.</summary>
    [JsonPropertyName("httpParameters")]
    public V1beta1PipeStatusAtProviderTargetParametersHttpParameters? HttpParameters { get; set; }

    /// <summary>Valid JSON text passed to the target. In this case, nothing from the event itself is passed to the target. Maximum length of 8192 characters.</summary>
    [JsonPropertyName("inputTemplate")]
    public string? InputTemplate { get; set; }

    /// <summary>The parameters for using a Kinesis stream as a source. Detailed below.</summary>
    [JsonPropertyName("kinesisStreamParameters")]
    public V1beta1PipeStatusAtProviderTargetParametersKinesisStreamParameters? KinesisStreamParameters { get; set; }

    /// <summary>The parameters for using a Lambda function as a target. Detailed below.</summary>
    [JsonPropertyName("lambdaFunctionParameters")]
    public V1beta1PipeStatusAtProviderTargetParametersLambdaFunctionParameters? LambdaFunctionParameters { get; set; }

    /// <summary>These are custom parameters to be used when the target is a Amazon Redshift cluster to invoke the Amazon Redshift Data API BatchExecuteStatement. Detailed below.</summary>
    [JsonPropertyName("redshiftDataParameters")]
    public V1beta1PipeStatusAtProviderTargetParametersRedshiftDataParameters? RedshiftDataParameters { get; set; }

    /// <summary>The parameters for using a SageMaker AI pipeline as a target. Detailed below.</summary>
    [JsonPropertyName("sagemakerPipelineParameters")]
    public V1beta1PipeStatusAtProviderTargetParametersSagemakerPipelineParameters? SagemakerPipelineParameters { get; set; }

    /// <summary>The parameters for using a Amazon SQS stream as a target. Detailed below.</summary>
    [JsonPropertyName("sqsQueueParameters")]
    public V1beta1PipeStatusAtProviderTargetParametersSqsQueueParameters? SqsQueueParameters { get; set; }

    /// <summary>The parameters for using a Step Functions state machine as a target. Detailed below.</summary>
    [JsonPropertyName("stepFunctionStateMachineParameters")]
    public V1beta1PipeStatusAtProviderTargetParametersStepFunctionStateMachineParameters? StepFunctionStateMachineParameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusAtProvider
{
    /// <summary>ARN of this pipe.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A description of the pipe. At most 512 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The state the pipe should be in. One of: RUNNING, STOPPED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Enrichment resource of the pipe (typically an ARN). Read more about enrichment in the User Guide.</summary>
    [JsonPropertyName("enrichment")]
    public string? Enrichment { get; set; }

    /// <summary>Parameters to configure enrichment for your pipe. Detailed below.</summary>
    [JsonPropertyName("enrichmentParameters")]
    public V1beta1PipeStatusAtProviderEnrichmentParameters? EnrichmentParameters { get; set; }

    /// <summary>Same as name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identifier of the AWS KMS customer managed key for EventBridge to use, if you choose to use a customer managed key to encrypt pipe data. The identifier can be the key Amazon Resource Name (ARN), KeyId, key alias, or key alias ARN. If not set, EventBridge uses an AWS owned key to encrypt pipe data.</summary>
    [JsonPropertyName("kmsKeyIdentifier")]
    public string? KmsKeyIdentifier { get; set; }

    /// <summary>Logging configuration settings for the pipe. Detailed below.</summary>
    [JsonPropertyName("logConfiguration")]
    public V1beta1PipeStatusAtProviderLogConfiguration? LogConfiguration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>ARN of the role that allows the pipe to send data to the target.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Source resource of the pipe. This field typically requires an ARN (Amazon Resource Name). However, when using a self-managed Kafka cluster, you should use a different format. Instead of an ARN, use 'smk://' followed by the bootstrap server's address.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Parameters to configure a source for the pipe. Detailed below.</summary>
    [JsonPropertyName("sourceParameters")]
    public V1beta1PipeStatusAtProviderSourceParameters? SourceParameters { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Target resource of the pipe (typically an ARN).</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Parameters to configure a target for your pipe. Detailed below.</summary>
    [JsonPropertyName("targetParameters")]
    public V1beta1PipeStatusAtProviderTargetParameters? TargetParameters { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatusConditions
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

/// <summary>PipeStatus defines the observed state of Pipe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipeStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PipeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PipeStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Pipe is the Schema for the Pipes API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Pipe : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PipeSpec>, IStatus<V1beta1PipeStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Pipe";
    public const string KubeGroup = "pipes.aws.upbound.io";
    public const string KubePluralName = "pipes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PipeSpec defines the desired state of Pipe</summary>
    [JsonPropertyName("spec")]
    public V1beta1PipeSpec Spec { get; set; }

    /// <summary>PipeStatus defines the observed state of Pipe.</summary>
    [JsonPropertyName("status")]
    public V1beta1PipeStatus? Status { get; set; }
}

/// <summary>Pipe is the Schema for the Pipes API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PipeList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Pipe>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PipeList";
    public const string KubeGroup = "pipes.aws.upbound.io";
    public const string KubePluralName = "pipes";
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
    public IList<V1beta1Pipe> Items { get; set; }
}