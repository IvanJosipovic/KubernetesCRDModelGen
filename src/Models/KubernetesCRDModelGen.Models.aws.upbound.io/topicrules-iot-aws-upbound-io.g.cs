using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iot.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderCloudwatchAlarm
{
    /// <summary>The CloudWatch alarm name.</summary>
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The reason for the alarm change.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>The value of the alarm state. Acceptable values are: OK, ALARM, INSUFFICIENT_DATA.</summary>
    [JsonPropertyName("stateValue")]
    public string? StateValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderCloudwatchLogs
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The CloudWatch log group name.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderCloudwatchMetric
{
    /// <summary>The CloudWatch metric name.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The CloudWatch metric namespace name.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>An optional Unix timestamp (http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp).</summary>
    [JsonPropertyName("metricTimestamp")]
    public string? MetricTimestamp { get; set; }

    /// <summary>The metric unit (supported units can be found here: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#Unit)</summary>
    [JsonPropertyName("metricUnit")]
    public string? MetricUnit { get; set; }

    /// <summary>The CloudWatch metric value.</summary>
    [JsonPropertyName("metricValue")]
    public string? MetricValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderDynamodb
{
    /// <summary>The hash key name.</summary>
    [JsonPropertyName("hashKeyField")]
    public string? HashKeyField { get; set; }

    /// <summary>The hash key type. Valid values are "STRING" or "NUMBER".</summary>
    [JsonPropertyName("hashKeyType")]
    public string? HashKeyType { get; set; }

    /// <summary>The hash key value.</summary>
    [JsonPropertyName("hashKeyValue")]
    public string? HashKeyValue { get; set; }

    /// <summary>The operation. Valid values are "INSERT", "UPDATE", or "DELETE".</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The action payload.</summary>
    [JsonPropertyName("payloadField")]
    public string? PayloadField { get; set; }

    /// <summary>The range key name.</summary>
    [JsonPropertyName("rangeKeyField")]
    public string? RangeKeyField { get; set; }

    /// <summary>The range key type. Valid values are "STRING" or "NUMBER".</summary>
    [JsonPropertyName("rangeKeyType")]
    public string? RangeKeyType { get; set; }

    /// <summary>The range key value.</summary>
    [JsonPropertyName("rangeKeyValue")]
    public string? RangeKeyValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderDynamodbv2PutItem
{
    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderDynamodbv2
{
    /// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
    [JsonPropertyName("putItem")]
    public IList<V1beta1TopicRuleSpecForProviderDynamodbv2PutItem>? PutItem { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderElasticsearch
{
    /// <summary>The endpoint of your Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The unique identifier for the document you are storing.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Elasticsearch index where you want to store your data.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The type of document you are storing.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionCloudwatchAlarm
{
    /// <summary>The CloudWatch alarm name.</summary>
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The reason for the alarm change.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>The value of the alarm state. Acceptable values are: OK, ALARM, INSUFFICIENT_DATA.</summary>
    [JsonPropertyName("stateValue")]
    public string? StateValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionCloudwatchLogs
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The CloudWatch log group name.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionCloudwatchMetric
{
    /// <summary>The CloudWatch metric name.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The CloudWatch metric namespace name.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>An optional Unix timestamp (http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp).</summary>
    [JsonPropertyName("metricTimestamp")]
    public string? MetricTimestamp { get; set; }

    /// <summary>The metric unit (supported units can be found here: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#Unit)</summary>
    [JsonPropertyName("metricUnit")]
    public string? MetricUnit { get; set; }

    /// <summary>The CloudWatch metric value.</summary>
    [JsonPropertyName("metricValue")]
    public string? MetricValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionDynamodb
{
    /// <summary>The hash key name.</summary>
    [JsonPropertyName("hashKeyField")]
    public string? HashKeyField { get; set; }

    /// <summary>The hash key type. Valid values are "STRING" or "NUMBER".</summary>
    [JsonPropertyName("hashKeyType")]
    public string? HashKeyType { get; set; }

    /// <summary>The hash key value.</summary>
    [JsonPropertyName("hashKeyValue")]
    public string? HashKeyValue { get; set; }

    /// <summary>The operation. Valid values are "INSERT", "UPDATE", or "DELETE".</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The action payload.</summary>
    [JsonPropertyName("payloadField")]
    public string? PayloadField { get; set; }

    /// <summary>The range key name.</summary>
    [JsonPropertyName("rangeKeyField")]
    public string? RangeKeyField { get; set; }

    /// <summary>The range key type. Valid values are "STRING" or "NUMBER".</summary>
    [JsonPropertyName("rangeKeyType")]
    public string? RangeKeyType { get; set; }

    /// <summary>The range key value.</summary>
    [JsonPropertyName("rangeKeyValue")]
    public string? RangeKeyValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionDynamodbv2PutItem
{
    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionDynamodbv2
{
    /// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
    [JsonPropertyName("putItem")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionDynamodbv2PutItem>? PutItem { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionElasticsearch
{
    /// <summary>The endpoint of your Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The unique identifier for the document you are storing.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Elasticsearch index where you want to store your data.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The type of document you are storing.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionFirehose
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The delivery stream name.</summary>
    [JsonPropertyName("deliveryStreamName")]
    public string? DeliveryStreamName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A character separator that is used to separate records written to the Firehose stream. Valid values are: '\n' (newline), '\t' (tab), '\r\n' (Windows newline), ',' (comma).</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionHttpHttpHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionHttp
{
    /// <summary>The HTTPS URL used to verify ownership of url.</summary>
    [JsonPropertyName("confirmationUrl")]
    public string? ConfirmationUrl { get; set; }

    /// <summary>Custom HTTP header IoT Core should send. It is possible to define more than one custom header.</summary>
    [JsonPropertyName("httpHeader")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionHttpHttpHeader>? HttpHeader { get; set; }

    /// <summary>The HTTPS URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionIotAnalytics
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>Name of AWS IOT Analytics channel.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionIotEvents
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The name of the AWS IoT Events input.</summary>
    [JsonPropertyName("inputName")]
    public string? InputName { get; set; }

    /// <summary>Use this to ensure that only one input (message) with a given messageId is processed by an AWS IoT Events detector.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionKafkaHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionKafka
{
    /// <summary>Properties of the Apache Kafka producer client. For more info, see the AWS documentation.</summary>
    [JsonPropertyName("clientProperties")]
    public IDictionary<string, string>? ClientProperties { get; set; }

    /// <summary>The ARN of Kafka action's VPC aws_iot_topic_rule_destination.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>The list of Kafka headers that you specify. Nested arguments below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionKafkaHeader>? Header { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Kafka message partition.</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionKinesis
{
    /// <summary>The partition key.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Amazon Kinesis stream.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionRepublish
{
    /// <summary>The Quality of Service (QoS) level to use when republishing messages. Valid values are 0 or 1. The default value is 0.</summary>
    [JsonPropertyName("qos")]
    public double? Qos { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionS3
{
    /// <summary>The Amazon S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The Amazon S3 canned ACL that controls access to the object identified by the object key. Valid values.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionSnsRoleArnRefPolicy
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
public partial class V1beta1TopicRuleSpecForProviderErrorActionSnsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecForProviderErrorActionSnsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionSnsRoleArnSelectorPolicy
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
public partial class V1beta1TopicRuleSpecForProviderErrorActionSnsRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecForProviderErrorActionSnsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionSnsTargetArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionSnsTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecForProviderErrorActionSnsTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionSnsTargetArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionSnsTargetArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecForProviderErrorActionSnsTargetArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionSns
{
    /// <summary>The message format of the message to publish. Accepted values are "JSON" and "RAW".</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1TopicRuleSpecForProviderErrorActionSnsRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1TopicRuleSpecForProviderErrorActionSnsRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The ARN of the SNS topic.</summary>
    [JsonPropertyName("targetArn")]
    public string? TargetArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnRef")]
    public V1beta1TopicRuleSpecForProviderErrorActionSnsTargetArnRef? TargetArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnSelector")]
    public V1beta1TopicRuleSpecForProviderErrorActionSnsTargetArnSelector? TargetArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionSqs
{
    /// <summary>The URL of the Amazon SQS queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Specifies whether to use Base64 encoding.</summary>
    [JsonPropertyName("useBase64")]
    public bool? UseBase64 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionStepFunctions
{
    /// <summary>The prefix used to generate, along with a UUID, the unique state machine execution name.</summary>
    [JsonPropertyName("executionNamePrefix")]
    public string? ExecutionNamePrefix { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Step Functions state machine whose execution will be started.</summary>
    [JsonPropertyName("stateMachineName")]
    public string? StateMachineName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionTimestreamDimension
{
    /// <summary>The name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionTimestreamTimestamp
{
    /// <summary>The precision of the timestamp value that results from the expression described in value. Valid values: SECONDS, MILLISECONDS, MICROSECONDS, NANOSECONDS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorActionTimestream
{
    /// <summary>The name of an Amazon Timestream database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Configuration blocks with metadata attributes of the time series that are written in each measure record. Nested arguments below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionTimestreamDimension>? Dimension { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record's timestamp in the time column. Nested arguments below.</summary>
    [JsonPropertyName("timestamp")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionTimestreamTimestamp>? Timestamp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderErrorAction
{
    /// <summary></summary>
    [JsonPropertyName("cloudwatchAlarm")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionCloudwatchAlarm>? CloudwatchAlarm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionCloudwatchLogs>? CloudwatchLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchMetric")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionCloudwatchMetric>? CloudwatchMetric { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dynamodb")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionDynamodb>? Dynamodb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dynamodbv2")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionDynamodbv2>? Dynamodbv2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("elasticsearch")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionElasticsearch>? Elasticsearch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firehose")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionFirehose>? Firehose { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionHttp>? Http { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iotAnalytics")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionIotAnalytics>? IotAnalytics { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iotEvents")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionIotEvents>? IotEvents { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kafka")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionKafka>? Kafka { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kinesis")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionKinesis>? Kinesis { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lambda")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionLambda>? Lambda { get; set; }

    /// <summary></summary>
    [JsonPropertyName("republish")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionRepublish>? Republish { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sns")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionSns>? Sns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqs")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionSqs>? Sqs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stepFunctions")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionStepFunctions>? StepFunctions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestream")]
    public IList<V1beta1TopicRuleSpecForProviderErrorActionTimestream>? Timestream { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderFirehose
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The delivery stream name.</summary>
    [JsonPropertyName("deliveryStreamName")]
    public string? DeliveryStreamName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A character separator that is used to separate records written to the Firehose stream. Valid values are: '\n' (newline), '\t' (tab), '\r\n' (Windows newline), ',' (comma).</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderHttpHttpHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderHttp
{
    /// <summary>The HTTPS URL used to verify ownership of url.</summary>
    [JsonPropertyName("confirmationUrl")]
    public string? ConfirmationUrl { get; set; }

    /// <summary>Custom HTTP header IoT Core should send. It is possible to define more than one custom header.</summary>
    [JsonPropertyName("httpHeader")]
    public IList<V1beta1TopicRuleSpecForProviderHttpHttpHeader>? HttpHeader { get; set; }

    /// <summary>The HTTPS URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderIotAnalytics
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>Name of AWS IOT Analytics channel.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderIotEvents
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The name of the AWS IoT Events input.</summary>
    [JsonPropertyName("inputName")]
    public string? InputName { get; set; }

    /// <summary>Use this to ensure that only one input (message) with a given messageId is processed by an AWS IoT Events detector.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderKafkaHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderKafka
{
    /// <summary>Properties of the Apache Kafka producer client. For more info, see the AWS documentation.</summary>
    [JsonPropertyName("clientProperties")]
    public IDictionary<string, string>? ClientProperties { get; set; }

    /// <summary>The ARN of Kafka action's VPC aws_iot_topic_rule_destination.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>The list of Kafka headers that you specify. Nested arguments below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1TopicRuleSpecForProviderKafkaHeader>? Header { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Kafka message partition.</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderKinesis
{
    /// <summary>The partition key.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Amazon Kinesis stream.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderRepublish
{
    /// <summary>The Quality of Service (QoS) level to use when republishing messages. Valid values are 0 or 1. The default value is 0.</summary>
    [JsonPropertyName("qos")]
    public double? Qos { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderS3
{
    /// <summary>The Amazon S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The Amazon S3 canned ACL that controls access to the object identified by the object key. Valid values.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderSnsRoleArnRefPolicy
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
public partial class V1beta1TopicRuleSpecForProviderSnsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecForProviderSnsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderSnsRoleArnSelectorPolicy
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
public partial class V1beta1TopicRuleSpecForProviderSnsRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecForProviderSnsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderSnsTargetArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderSnsTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecForProviderSnsTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderSnsTargetArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderSnsTargetArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecForProviderSnsTargetArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderSns
{
    /// <summary>The message format of the message to publish. Accepted values are "JSON" and "RAW".</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1TopicRuleSpecForProviderSnsRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1TopicRuleSpecForProviderSnsRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The ARN of the SNS topic.</summary>
    [JsonPropertyName("targetArn")]
    public string? TargetArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnRef")]
    public V1beta1TopicRuleSpecForProviderSnsTargetArnRef? TargetArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnSelector")]
    public V1beta1TopicRuleSpecForProviderSnsTargetArnSelector? TargetArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderSqs
{
    /// <summary>The URL of the Amazon SQS queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Specifies whether to use Base64 encoding.</summary>
    [JsonPropertyName("useBase64")]
    public bool? UseBase64 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderStepFunctions
{
    /// <summary>The prefix used to generate, along with a UUID, the unique state machine execution name.</summary>
    [JsonPropertyName("executionNamePrefix")]
    public string? ExecutionNamePrefix { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Step Functions state machine whose execution will be started.</summary>
    [JsonPropertyName("stateMachineName")]
    public string? StateMachineName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderTimestreamDimension
{
    /// <summary>The name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderTimestreamTimestamp
{
    /// <summary>The precision of the timestamp value that results from the expression described in value. Valid values: SECONDS, MILLISECONDS, MICROSECONDS, NANOSECONDS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProviderTimestream
{
    /// <summary>The name of an Amazon Timestream database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Configuration blocks with metadata attributes of the time series that are written in each measure record. Nested arguments below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1TopicRuleSpecForProviderTimestreamDimension>? Dimension { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record's timestamp in the time column. Nested arguments below.</summary>
    [JsonPropertyName("timestamp")]
    public IList<V1beta1TopicRuleSpecForProviderTimestreamTimestamp>? Timestamp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecForProvider
{
    /// <summary></summary>
    [JsonPropertyName("cloudwatchAlarm")]
    public IList<V1beta1TopicRuleSpecForProviderCloudwatchAlarm>? CloudwatchAlarm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta1TopicRuleSpecForProviderCloudwatchLogs>? CloudwatchLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchMetric")]
    public IList<V1beta1TopicRuleSpecForProviderCloudwatchMetric>? CloudwatchMetric { get; set; }

    /// <summary>The description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dynamodb")]
    public IList<V1beta1TopicRuleSpecForProviderDynamodb>? Dynamodb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dynamodbv2")]
    public IList<V1beta1TopicRuleSpecForProviderDynamodbv2>? Dynamodbv2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("elasticsearch")]
    public IList<V1beta1TopicRuleSpecForProviderElasticsearch>? Elasticsearch { get; set; }

    /// <summary>Specifies whether the rule is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration block with error action to be associated with the rule. See the documentation for cloudwatch_alarm, cloudwatch_logs, cloudwatch_metric, dynamodb, dynamodbv2, elasticsearch, firehose, http, iot_analytics, iot_events, kafka, kinesis, lambda, republish, s3, sns, sqs, step_functions, timestream configuration blocks for further configuration details.</summary>
    [JsonPropertyName("errorAction")]
    public IList<V1beta1TopicRuleSpecForProviderErrorAction>? ErrorAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firehose")]
    public IList<V1beta1TopicRuleSpecForProviderFirehose>? Firehose { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public IList<V1beta1TopicRuleSpecForProviderHttp>? Http { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iotAnalytics")]
    public IList<V1beta1TopicRuleSpecForProviderIotAnalytics>? IotAnalytics { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iotEvents")]
    public IList<V1beta1TopicRuleSpecForProviderIotEvents>? IotEvents { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kafka")]
    public IList<V1beta1TopicRuleSpecForProviderKafka>? Kafka { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kinesis")]
    public IList<V1beta1TopicRuleSpecForProviderKinesis>? Kinesis { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lambda")]
    public IList<V1beta1TopicRuleSpecForProviderLambda>? Lambda { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("republish")]
    public IList<V1beta1TopicRuleSpecForProviderRepublish>? Republish { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1beta1TopicRuleSpecForProviderS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sns")]
    public IList<V1beta1TopicRuleSpecForProviderSns>? Sns { get; set; }

    /// <summary>The SQL statement used to query the topic. For more information, see AWS IoT SQL Reference (http://docs.aws.amazon.com/iot/latest/developerguide/iot-rules.html#aws-iot-sql-reference) in the AWS IoT Developer Guide.</summary>
    [JsonPropertyName("sql")]
    public string? Sql { get; set; }

    /// <summary>The version of the SQL rules engine to use when evaluating the rule.</summary>
    [JsonPropertyName("sqlVersion")]
    public string? SqlVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqs")]
    public IList<V1beta1TopicRuleSpecForProviderSqs>? Sqs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stepFunctions")]
    public IList<V1beta1TopicRuleSpecForProviderStepFunctions>? StepFunctions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestream")]
    public IList<V1beta1TopicRuleSpecForProviderTimestream>? Timestream { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderCloudwatchAlarm
{
    /// <summary>The CloudWatch alarm name.</summary>
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The reason for the alarm change.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>The value of the alarm state. Acceptable values are: OK, ALARM, INSUFFICIENT_DATA.</summary>
    [JsonPropertyName("stateValue")]
    public string? StateValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderCloudwatchLogs
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The CloudWatch log group name.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderCloudwatchMetric
{
    /// <summary>The CloudWatch metric name.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The CloudWatch metric namespace name.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>An optional Unix timestamp (http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp).</summary>
    [JsonPropertyName("metricTimestamp")]
    public string? MetricTimestamp { get; set; }

    /// <summary>The metric unit (supported units can be found here: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#Unit)</summary>
    [JsonPropertyName("metricUnit")]
    public string? MetricUnit { get; set; }

    /// <summary>The CloudWatch metric value.</summary>
    [JsonPropertyName("metricValue")]
    public string? MetricValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderDynamodb
{
    /// <summary>The hash key name.</summary>
    [JsonPropertyName("hashKeyField")]
    public string? HashKeyField { get; set; }

    /// <summary>The hash key type. Valid values are "STRING" or "NUMBER".</summary>
    [JsonPropertyName("hashKeyType")]
    public string? HashKeyType { get; set; }

    /// <summary>The hash key value.</summary>
    [JsonPropertyName("hashKeyValue")]
    public string? HashKeyValue { get; set; }

    /// <summary>The operation. Valid values are "INSERT", "UPDATE", or "DELETE".</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The action payload.</summary>
    [JsonPropertyName("payloadField")]
    public string? PayloadField { get; set; }

    /// <summary>The range key name.</summary>
    [JsonPropertyName("rangeKeyField")]
    public string? RangeKeyField { get; set; }

    /// <summary>The range key type. Valid values are "STRING" or "NUMBER".</summary>
    [JsonPropertyName("rangeKeyType")]
    public string? RangeKeyType { get; set; }

    /// <summary>The range key value.</summary>
    [JsonPropertyName("rangeKeyValue")]
    public string? RangeKeyValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderDynamodbv2PutItem
{
    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderDynamodbv2
{
    /// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
    [JsonPropertyName("putItem")]
    public IList<V1beta1TopicRuleSpecInitProviderDynamodbv2PutItem>? PutItem { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderElasticsearch
{
    /// <summary>The endpoint of your Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The unique identifier for the document you are storing.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Elasticsearch index where you want to store your data.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The type of document you are storing.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionCloudwatchAlarm
{
    /// <summary>The CloudWatch alarm name.</summary>
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The reason for the alarm change.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>The value of the alarm state. Acceptable values are: OK, ALARM, INSUFFICIENT_DATA.</summary>
    [JsonPropertyName("stateValue")]
    public string? StateValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionCloudwatchLogs
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The CloudWatch log group name.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionCloudwatchMetric
{
    /// <summary>The CloudWatch metric name.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The CloudWatch metric namespace name.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>An optional Unix timestamp (http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp).</summary>
    [JsonPropertyName("metricTimestamp")]
    public string? MetricTimestamp { get; set; }

    /// <summary>The metric unit (supported units can be found here: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#Unit)</summary>
    [JsonPropertyName("metricUnit")]
    public string? MetricUnit { get; set; }

    /// <summary>The CloudWatch metric value.</summary>
    [JsonPropertyName("metricValue")]
    public string? MetricValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionDynamodb
{
    /// <summary>The hash key name.</summary>
    [JsonPropertyName("hashKeyField")]
    public string? HashKeyField { get; set; }

    /// <summary>The hash key type. Valid values are "STRING" or "NUMBER".</summary>
    [JsonPropertyName("hashKeyType")]
    public string? HashKeyType { get; set; }

    /// <summary>The hash key value.</summary>
    [JsonPropertyName("hashKeyValue")]
    public string? HashKeyValue { get; set; }

    /// <summary>The operation. Valid values are "INSERT", "UPDATE", or "DELETE".</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The action payload.</summary>
    [JsonPropertyName("payloadField")]
    public string? PayloadField { get; set; }

    /// <summary>The range key name.</summary>
    [JsonPropertyName("rangeKeyField")]
    public string? RangeKeyField { get; set; }

    /// <summary>The range key type. Valid values are "STRING" or "NUMBER".</summary>
    [JsonPropertyName("rangeKeyType")]
    public string? RangeKeyType { get; set; }

    /// <summary>The range key value.</summary>
    [JsonPropertyName("rangeKeyValue")]
    public string? RangeKeyValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionDynamodbv2PutItem
{
    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionDynamodbv2
{
    /// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
    [JsonPropertyName("putItem")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionDynamodbv2PutItem>? PutItem { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionElasticsearch
{
    /// <summary>The endpoint of your Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The unique identifier for the document you are storing.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Elasticsearch index where you want to store your data.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The type of document you are storing.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionFirehose
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The delivery stream name.</summary>
    [JsonPropertyName("deliveryStreamName")]
    public string? DeliveryStreamName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A character separator that is used to separate records written to the Firehose stream. Valid values are: '\n' (newline), '\t' (tab), '\r\n' (Windows newline), ',' (comma).</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionHttpHttpHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionHttp
{
    /// <summary>The HTTPS URL used to verify ownership of url.</summary>
    [JsonPropertyName("confirmationUrl")]
    public string? ConfirmationUrl { get; set; }

    /// <summary>Custom HTTP header IoT Core should send. It is possible to define more than one custom header.</summary>
    [JsonPropertyName("httpHeader")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionHttpHttpHeader>? HttpHeader { get; set; }

    /// <summary>The HTTPS URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionIotAnalytics
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>Name of AWS IOT Analytics channel.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionIotEvents
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The name of the AWS IoT Events input.</summary>
    [JsonPropertyName("inputName")]
    public string? InputName { get; set; }

    /// <summary>Use this to ensure that only one input (message) with a given messageId is processed by an AWS IoT Events detector.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionKafkaHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionKafka
{
    /// <summary>Properties of the Apache Kafka producer client. For more info, see the AWS documentation.</summary>
    [JsonPropertyName("clientProperties")]
    public IDictionary<string, string>? ClientProperties { get; set; }

    /// <summary>The ARN of Kafka action's VPC aws_iot_topic_rule_destination.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>The list of Kafka headers that you specify. Nested arguments below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionKafkaHeader>? Header { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Kafka message partition.</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionKinesis
{
    /// <summary>The partition key.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Amazon Kinesis stream.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionRepublish
{
    /// <summary>The Quality of Service (QoS) level to use when republishing messages. Valid values are 0 or 1. The default value is 0.</summary>
    [JsonPropertyName("qos")]
    public double? Qos { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionS3
{
    /// <summary>The Amazon S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The Amazon S3 canned ACL that controls access to the object identified by the object key. Valid values.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionSnsRoleArnRefPolicy
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
public partial class V1beta1TopicRuleSpecInitProviderErrorActionSnsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecInitProviderErrorActionSnsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionSnsRoleArnSelectorPolicy
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
public partial class V1beta1TopicRuleSpecInitProviderErrorActionSnsRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecInitProviderErrorActionSnsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionSnsTargetArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionSnsTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecInitProviderErrorActionSnsTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionSnsTargetArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionSnsTargetArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecInitProviderErrorActionSnsTargetArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionSns
{
    /// <summary>The message format of the message to publish. Accepted values are "JSON" and "RAW".</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1TopicRuleSpecInitProviderErrorActionSnsRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1TopicRuleSpecInitProviderErrorActionSnsRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The ARN of the SNS topic.</summary>
    [JsonPropertyName("targetArn")]
    public string? TargetArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnRef")]
    public V1beta1TopicRuleSpecInitProviderErrorActionSnsTargetArnRef? TargetArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnSelector")]
    public V1beta1TopicRuleSpecInitProviderErrorActionSnsTargetArnSelector? TargetArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionSqs
{
    /// <summary>The URL of the Amazon SQS queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Specifies whether to use Base64 encoding.</summary>
    [JsonPropertyName("useBase64")]
    public bool? UseBase64 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionStepFunctions
{
    /// <summary>The prefix used to generate, along with a UUID, the unique state machine execution name.</summary>
    [JsonPropertyName("executionNamePrefix")]
    public string? ExecutionNamePrefix { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Step Functions state machine whose execution will be started.</summary>
    [JsonPropertyName("stateMachineName")]
    public string? StateMachineName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionTimestreamDimension
{
    /// <summary>The name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionTimestreamTimestamp
{
    /// <summary>The precision of the timestamp value that results from the expression described in value. Valid values: SECONDS, MILLISECONDS, MICROSECONDS, NANOSECONDS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorActionTimestream
{
    /// <summary>The name of an Amazon Timestream database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Configuration blocks with metadata attributes of the time series that are written in each measure record. Nested arguments below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionTimestreamDimension>? Dimension { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record's timestamp in the time column. Nested arguments below.</summary>
    [JsonPropertyName("timestamp")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionTimestreamTimestamp>? Timestamp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderErrorAction
{
    /// <summary></summary>
    [JsonPropertyName("cloudwatchAlarm")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionCloudwatchAlarm>? CloudwatchAlarm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionCloudwatchLogs>? CloudwatchLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchMetric")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionCloudwatchMetric>? CloudwatchMetric { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dynamodb")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionDynamodb>? Dynamodb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dynamodbv2")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionDynamodbv2>? Dynamodbv2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("elasticsearch")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionElasticsearch>? Elasticsearch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firehose")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionFirehose>? Firehose { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionHttp>? Http { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iotAnalytics")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionIotAnalytics>? IotAnalytics { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iotEvents")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionIotEvents>? IotEvents { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kafka")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionKafka>? Kafka { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kinesis")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionKinesis>? Kinesis { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lambda")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionLambda>? Lambda { get; set; }

    /// <summary></summary>
    [JsonPropertyName("republish")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionRepublish>? Republish { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sns")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionSns>? Sns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqs")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionSqs>? Sqs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stepFunctions")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionStepFunctions>? StepFunctions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestream")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorActionTimestream>? Timestream { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderFirehose
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The delivery stream name.</summary>
    [JsonPropertyName("deliveryStreamName")]
    public string? DeliveryStreamName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A character separator that is used to separate records written to the Firehose stream. Valid values are: '\n' (newline), '\t' (tab), '\r\n' (Windows newline), ',' (comma).</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderHttpHttpHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderHttp
{
    /// <summary>The HTTPS URL used to verify ownership of url.</summary>
    [JsonPropertyName("confirmationUrl")]
    public string? ConfirmationUrl { get; set; }

    /// <summary>Custom HTTP header IoT Core should send. It is possible to define more than one custom header.</summary>
    [JsonPropertyName("httpHeader")]
    public IList<V1beta1TopicRuleSpecInitProviderHttpHttpHeader>? HttpHeader { get; set; }

    /// <summary>The HTTPS URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderIotAnalytics
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>Name of AWS IOT Analytics channel.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderIotEvents
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The name of the AWS IoT Events input.</summary>
    [JsonPropertyName("inputName")]
    public string? InputName { get; set; }

    /// <summary>Use this to ensure that only one input (message) with a given messageId is processed by an AWS IoT Events detector.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderKafkaHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderKafka
{
    /// <summary>Properties of the Apache Kafka producer client. For more info, see the AWS documentation.</summary>
    [JsonPropertyName("clientProperties")]
    public IDictionary<string, string>? ClientProperties { get; set; }

    /// <summary>The ARN of Kafka action's VPC aws_iot_topic_rule_destination.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>The list of Kafka headers that you specify. Nested arguments below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1TopicRuleSpecInitProviderKafkaHeader>? Header { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Kafka message partition.</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderKinesis
{
    /// <summary>The partition key.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Amazon Kinesis stream.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderRepublish
{
    /// <summary>The Quality of Service (QoS) level to use when republishing messages. Valid values are 0 or 1. The default value is 0.</summary>
    [JsonPropertyName("qos")]
    public double? Qos { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderS3
{
    /// <summary>The Amazon S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The Amazon S3 canned ACL that controls access to the object identified by the object key. Valid values.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderSnsRoleArnRefPolicy
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
public partial class V1beta1TopicRuleSpecInitProviderSnsRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecInitProviderSnsRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderSnsRoleArnSelectorPolicy
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
public partial class V1beta1TopicRuleSpecInitProviderSnsRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecInitProviderSnsRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderSnsTargetArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderSnsTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecInitProviderSnsTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderSnsTargetArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate targetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderSnsTargetArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecInitProviderSnsTargetArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderSns
{
    /// <summary>The message format of the message to publish. Accepted values are "JSON" and "RAW".</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1TopicRuleSpecInitProviderSnsRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1TopicRuleSpecInitProviderSnsRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The ARN of the SNS topic.</summary>
    [JsonPropertyName("targetArn")]
    public string? TargetArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnRef")]
    public V1beta1TopicRuleSpecInitProviderSnsTargetArnRef? TargetArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate targetArn.</summary>
    [JsonPropertyName("targetArnSelector")]
    public V1beta1TopicRuleSpecInitProviderSnsTargetArnSelector? TargetArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderSqs
{
    /// <summary>The URL of the Amazon SQS queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Specifies whether to use Base64 encoding.</summary>
    [JsonPropertyName("useBase64")]
    public bool? UseBase64 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderStepFunctions
{
    /// <summary>The prefix used to generate, along with a UUID, the unique state machine execution name.</summary>
    [JsonPropertyName("executionNamePrefix")]
    public string? ExecutionNamePrefix { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Step Functions state machine whose execution will be started.</summary>
    [JsonPropertyName("stateMachineName")]
    public string? StateMachineName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderTimestreamDimension
{
    /// <summary>The name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderTimestreamTimestamp
{
    /// <summary>The precision of the timestamp value that results from the expression described in value. Valid values: SECONDS, MILLISECONDS, MICROSECONDS, NANOSECONDS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProviderTimestream
{
    /// <summary>The name of an Amazon Timestream database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Configuration blocks with metadata attributes of the time series that are written in each measure record. Nested arguments below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1TopicRuleSpecInitProviderTimestreamDimension>? Dimension { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record's timestamp in the time column. Nested arguments below.</summary>
    [JsonPropertyName("timestamp")]
    public IList<V1beta1TopicRuleSpecInitProviderTimestreamTimestamp>? Timestamp { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecInitProvider
{
    /// <summary></summary>
    [JsonPropertyName("cloudwatchAlarm")]
    public IList<V1beta1TopicRuleSpecInitProviderCloudwatchAlarm>? CloudwatchAlarm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta1TopicRuleSpecInitProviderCloudwatchLogs>? CloudwatchLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchMetric")]
    public IList<V1beta1TopicRuleSpecInitProviderCloudwatchMetric>? CloudwatchMetric { get; set; }

    /// <summary>The description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dynamodb")]
    public IList<V1beta1TopicRuleSpecInitProviderDynamodb>? Dynamodb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dynamodbv2")]
    public IList<V1beta1TopicRuleSpecInitProviderDynamodbv2>? Dynamodbv2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("elasticsearch")]
    public IList<V1beta1TopicRuleSpecInitProviderElasticsearch>? Elasticsearch { get; set; }

    /// <summary>Specifies whether the rule is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration block with error action to be associated with the rule. See the documentation for cloudwatch_alarm, cloudwatch_logs, cloudwatch_metric, dynamodb, dynamodbv2, elasticsearch, firehose, http, iot_analytics, iot_events, kafka, kinesis, lambda, republish, s3, sns, sqs, step_functions, timestream configuration blocks for further configuration details.</summary>
    [JsonPropertyName("errorAction")]
    public IList<V1beta1TopicRuleSpecInitProviderErrorAction>? ErrorAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firehose")]
    public IList<V1beta1TopicRuleSpecInitProviderFirehose>? Firehose { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public IList<V1beta1TopicRuleSpecInitProviderHttp>? Http { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iotAnalytics")]
    public IList<V1beta1TopicRuleSpecInitProviderIotAnalytics>? IotAnalytics { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iotEvents")]
    public IList<V1beta1TopicRuleSpecInitProviderIotEvents>? IotEvents { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kafka")]
    public IList<V1beta1TopicRuleSpecInitProviderKafka>? Kafka { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kinesis")]
    public IList<V1beta1TopicRuleSpecInitProviderKinesis>? Kinesis { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lambda")]
    public IList<V1beta1TopicRuleSpecInitProviderLambda>? Lambda { get; set; }

    /// <summary></summary>
    [JsonPropertyName("republish")]
    public IList<V1beta1TopicRuleSpecInitProviderRepublish>? Republish { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1beta1TopicRuleSpecInitProviderS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sns")]
    public IList<V1beta1TopicRuleSpecInitProviderSns>? Sns { get; set; }

    /// <summary>The SQL statement used to query the topic. For more information, see AWS IoT SQL Reference (http://docs.aws.amazon.com/iot/latest/developerguide/iot-rules.html#aws-iot-sql-reference) in the AWS IoT Developer Guide.</summary>
    [JsonPropertyName("sql")]
    public string? Sql { get; set; }

    /// <summary>The version of the SQL rules engine to use when evaluating the rule.</summary>
    [JsonPropertyName("sqlVersion")]
    public string? SqlVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqs")]
    public IList<V1beta1TopicRuleSpecInitProviderSqs>? Sqs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stepFunctions")]
    public IList<V1beta1TopicRuleSpecInitProviderStepFunctions>? StepFunctions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestream")]
    public IList<V1beta1TopicRuleSpecInitProviderTimestream>? Timestream { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecProviderConfigRefPolicy
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
public partial class V1beta1TopicRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1TopicRuleSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicRuleSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1TopicRuleSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TopicRuleSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TopicRuleSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>TopicRuleSpec defines the desired state of TopicRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TopicRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TopicRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TopicRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TopicRuleSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TopicRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderCloudwatchAlarm
{
    /// <summary>The CloudWatch alarm name.</summary>
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The reason for the alarm change.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>The value of the alarm state. Acceptable values are: OK, ALARM, INSUFFICIENT_DATA.</summary>
    [JsonPropertyName("stateValue")]
    public string? StateValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderCloudwatchLogs
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The CloudWatch log group name.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderCloudwatchMetric
{
    /// <summary>The CloudWatch metric name.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The CloudWatch metric namespace name.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>An optional Unix timestamp (http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp).</summary>
    [JsonPropertyName("metricTimestamp")]
    public string? MetricTimestamp { get; set; }

    /// <summary>The metric unit (supported units can be found here: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#Unit)</summary>
    [JsonPropertyName("metricUnit")]
    public string? MetricUnit { get; set; }

    /// <summary>The CloudWatch metric value.</summary>
    [JsonPropertyName("metricValue")]
    public string? MetricValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderDynamodb
{
    /// <summary>The hash key name.</summary>
    [JsonPropertyName("hashKeyField")]
    public string? HashKeyField { get; set; }

    /// <summary>The hash key type. Valid values are "STRING" or "NUMBER".</summary>
    [JsonPropertyName("hashKeyType")]
    public string? HashKeyType { get; set; }

    /// <summary>The hash key value.</summary>
    [JsonPropertyName("hashKeyValue")]
    public string? HashKeyValue { get; set; }

    /// <summary>The operation. Valid values are "INSERT", "UPDATE", or "DELETE".</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The action payload.</summary>
    [JsonPropertyName("payloadField")]
    public string? PayloadField { get; set; }

    /// <summary>The range key name.</summary>
    [JsonPropertyName("rangeKeyField")]
    public string? RangeKeyField { get; set; }

    /// <summary>The range key type. Valid values are "STRING" or "NUMBER".</summary>
    [JsonPropertyName("rangeKeyType")]
    public string? RangeKeyType { get; set; }

    /// <summary>The range key value.</summary>
    [JsonPropertyName("rangeKeyValue")]
    public string? RangeKeyValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderDynamodbv2PutItem
{
    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderDynamodbv2
{
    /// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
    [JsonPropertyName("putItem")]
    public IList<V1beta1TopicRuleStatusAtProviderDynamodbv2PutItem>? PutItem { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderElasticsearch
{
    /// <summary>The endpoint of your Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The unique identifier for the document you are storing.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Elasticsearch index where you want to store your data.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The type of document you are storing.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionCloudwatchAlarm
{
    /// <summary>The CloudWatch alarm name.</summary>
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The reason for the alarm change.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>The value of the alarm state. Acceptable values are: OK, ALARM, INSUFFICIENT_DATA.</summary>
    [JsonPropertyName("stateValue")]
    public string? StateValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionCloudwatchLogs
{
    /// <summary>The payload that contains a JSON array of records will be sent to CloudWatch via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The CloudWatch log group name.</summary>
    [JsonPropertyName("logGroupName")]
    public string? LogGroupName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionCloudwatchMetric
{
    /// <summary>The CloudWatch metric name.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The CloudWatch metric namespace name.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>An optional Unix timestamp (http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp).</summary>
    [JsonPropertyName("metricTimestamp")]
    public string? MetricTimestamp { get; set; }

    /// <summary>The metric unit (supported units can be found here: http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#Unit)</summary>
    [JsonPropertyName("metricUnit")]
    public string? MetricUnit { get; set; }

    /// <summary>The CloudWatch metric value.</summary>
    [JsonPropertyName("metricValue")]
    public string? MetricValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionDynamodb
{
    /// <summary>The hash key name.</summary>
    [JsonPropertyName("hashKeyField")]
    public string? HashKeyField { get; set; }

    /// <summary>The hash key type. Valid values are "STRING" or "NUMBER".</summary>
    [JsonPropertyName("hashKeyType")]
    public string? HashKeyType { get; set; }

    /// <summary>The hash key value.</summary>
    [JsonPropertyName("hashKeyValue")]
    public string? HashKeyValue { get; set; }

    /// <summary>The operation. Valid values are "INSERT", "UPDATE", or "DELETE".</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The action payload.</summary>
    [JsonPropertyName("payloadField")]
    public string? PayloadField { get; set; }

    /// <summary>The range key name.</summary>
    [JsonPropertyName("rangeKeyField")]
    public string? RangeKeyField { get; set; }

    /// <summary>The range key type. Valid values are "STRING" or "NUMBER".</summary>
    [JsonPropertyName("rangeKeyType")]
    public string? RangeKeyType { get; set; }

    /// <summary>The range key value.</summary>
    [JsonPropertyName("rangeKeyValue")]
    public string? RangeKeyValue { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionDynamodbv2PutItem
{
    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionDynamodbv2
{
    /// <summary>Configuration block with DynamoDB Table to which the message will be written. Nested arguments below.</summary>
    [JsonPropertyName("putItem")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionDynamodbv2PutItem>? PutItem { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionElasticsearch
{
    /// <summary>The endpoint of your Elasticsearch domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The unique identifier for the document you are storing.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Elasticsearch index where you want to store your data.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The type of document you are storing.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionFirehose
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The delivery stream name.</summary>
    [JsonPropertyName("deliveryStreamName")]
    public string? DeliveryStreamName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A character separator that is used to separate records written to the Firehose stream. Valid values are: '\n' (newline), '\t' (tab), '\r\n' (Windows newline), ',' (comma).</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionHttpHttpHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionHttp
{
    /// <summary>The HTTPS URL used to verify ownership of url.</summary>
    [JsonPropertyName("confirmationUrl")]
    public string? ConfirmationUrl { get; set; }

    /// <summary>Custom HTTP header IoT Core should send. It is possible to define more than one custom header.</summary>
    [JsonPropertyName("httpHeader")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionHttpHttpHeader>? HttpHeader { get; set; }

    /// <summary>The HTTPS URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionIotAnalytics
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>Name of AWS IOT Analytics channel.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionIotEvents
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The name of the AWS IoT Events input.</summary>
    [JsonPropertyName("inputName")]
    public string? InputName { get; set; }

    /// <summary>Use this to ensure that only one input (message) with a given messageId is processed by an AWS IoT Events detector.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionKafkaHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionKafka
{
    /// <summary>Properties of the Apache Kafka producer client. For more info, see the AWS documentation.</summary>
    [JsonPropertyName("clientProperties")]
    public IDictionary<string, string>? ClientProperties { get; set; }

    /// <summary>The ARN of Kafka action's VPC aws_iot_topic_rule_destination.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>The list of Kafka headers that you specify. Nested arguments below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionKafkaHeader>? Header { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Kafka message partition.</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionKinesis
{
    /// <summary>The partition key.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Amazon Kinesis stream.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionRepublish
{
    /// <summary>The Quality of Service (QoS) level to use when republishing messages. Valid values are 0 or 1. The default value is 0.</summary>
    [JsonPropertyName("qos")]
    public double? Qos { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionS3
{
    /// <summary>The Amazon S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The Amazon S3 canned ACL that controls access to the object identified by the object key. Valid values.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionSns
{
    /// <summary>The message format of the message to publish. Accepted values are "JSON" and "RAW".</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the SNS topic.</summary>
    [JsonPropertyName("targetArn")]
    public string? TargetArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionSqs
{
    /// <summary>The URL of the Amazon SQS queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Specifies whether to use Base64 encoding.</summary>
    [JsonPropertyName("useBase64")]
    public bool? UseBase64 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionStepFunctions
{
    /// <summary>The prefix used to generate, along with a UUID, the unique state machine execution name.</summary>
    [JsonPropertyName("executionNamePrefix")]
    public string? ExecutionNamePrefix { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Step Functions state machine whose execution will be started.</summary>
    [JsonPropertyName("stateMachineName")]
    public string? StateMachineName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionTimestreamDimension
{
    /// <summary>The name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionTimestreamTimestamp
{
    /// <summary>The precision of the timestamp value that results from the expression described in value. Valid values: SECONDS, MILLISECONDS, MICROSECONDS, NANOSECONDS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorActionTimestream
{
    /// <summary>The name of an Amazon Timestream database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Configuration blocks with metadata attributes of the time series that are written in each measure record. Nested arguments below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionTimestreamDimension>? Dimension { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record's timestamp in the time column. Nested arguments below.</summary>
    [JsonPropertyName("timestamp")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionTimestreamTimestamp>? Timestamp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderErrorAction
{
    /// <summary></summary>
    [JsonPropertyName("cloudwatchAlarm")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionCloudwatchAlarm>? CloudwatchAlarm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionCloudwatchLogs>? CloudwatchLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchMetric")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionCloudwatchMetric>? CloudwatchMetric { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dynamodb")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionDynamodb>? Dynamodb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dynamodbv2")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionDynamodbv2>? Dynamodbv2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("elasticsearch")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionElasticsearch>? Elasticsearch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firehose")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionFirehose>? Firehose { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionHttp>? Http { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iotAnalytics")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionIotAnalytics>? IotAnalytics { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iotEvents")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionIotEvents>? IotEvents { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kafka")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionKafka>? Kafka { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kinesis")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionKinesis>? Kinesis { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lambda")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionLambda>? Lambda { get; set; }

    /// <summary></summary>
    [JsonPropertyName("republish")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionRepublish>? Republish { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sns")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionSns>? Sns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqs")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionSqs>? Sqs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stepFunctions")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionStepFunctions>? StepFunctions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestream")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorActionTimestream>? Timestream { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderFirehose
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The delivery stream name.</summary>
    [JsonPropertyName("deliveryStreamName")]
    public string? DeliveryStreamName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>A character separator that is used to separate records written to the Firehose stream. Valid values are: '\n' (newline), '\t' (tab), '\r\n' (Windows newline), ',' (comma).</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderHttpHttpHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderHttp
{
    /// <summary>The HTTPS URL used to verify ownership of url.</summary>
    [JsonPropertyName("confirmationUrl")]
    public string? ConfirmationUrl { get; set; }

    /// <summary>Custom HTTP header IoT Core should send. It is possible to define more than one custom header.</summary>
    [JsonPropertyName("httpHeader")]
    public IList<V1beta1TopicRuleStatusAtProviderHttpHttpHeader>? HttpHeader { get; set; }

    /// <summary>The HTTPS URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderIotAnalytics
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>Name of AWS IOT Analytics channel.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderIotEvents
{
    /// <summary>The payload that contains a JSON array of records will be sent to Kinesis Firehose via a batch call.</summary>
    [JsonPropertyName("batchMode")]
    public bool? BatchMode { get; set; }

    /// <summary>The name of the AWS IoT Events input.</summary>
    [JsonPropertyName("inputName")]
    public string? InputName { get; set; }

    /// <summary>Use this to ensure that only one input (message) with a given messageId is processed by an AWS IoT Events detector.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderKafkaHeader
{
    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderKafka
{
    /// <summary>Properties of the Apache Kafka producer client. For more info, see the AWS documentation.</summary>
    [JsonPropertyName("clientProperties")]
    public IDictionary<string, string>? ClientProperties { get; set; }

    /// <summary>The ARN of Kafka action's VPC aws_iot_topic_rule_destination.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>The list of Kafka headers that you specify. Nested arguments below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1TopicRuleStatusAtProviderKafkaHeader>? Header { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Kafka message partition.</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderKinesis
{
    /// <summary>The partition key.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Amazon Kinesis stream.</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderLambda
{
    /// <summary>The ARN of the Lambda function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderRepublish
{
    /// <summary>The Quality of Service (QoS) level to use when republishing messages. Valid values are 0 or 1. The default value is 0.</summary>
    [JsonPropertyName("qos")]
    public double? Qos { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The Kafka topic for messages to be sent to the Kafka broker.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderS3
{
    /// <summary>The Amazon S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The Amazon S3 canned ACL that controls access to the object identified by the object key. Valid values.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>The name of the HTTP header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderSns
{
    /// <summary>The message format of the message to publish. Accepted values are "JSON" and "RAW".</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ARN of the SNS topic.</summary>
    [JsonPropertyName("targetArn")]
    public string? TargetArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderSqs
{
    /// <summary>The URL of the Amazon SQS queue.</summary>
    [JsonPropertyName("queueUrl")]
    public string? QueueUrl { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Specifies whether to use Base64 encoding.</summary>
    [JsonPropertyName("useBase64")]
    public bool? UseBase64 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderStepFunctions
{
    /// <summary>The prefix used to generate, along with a UUID, the unique state machine execution name.</summary>
    [JsonPropertyName("executionNamePrefix")]
    public string? ExecutionNamePrefix { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the Step Functions state machine whose execution will be started.</summary>
    [JsonPropertyName("stateMachineName")]
    public string? StateMachineName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderTimestreamDimension
{
    /// <summary>The name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderTimestreamTimestamp
{
    /// <summary>The precision of the timestamp value that results from the expression described in value. Valid values: SECONDS, MILLISECONDS, MICROSECONDS, NANOSECONDS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProviderTimestream
{
    /// <summary>The name of an Amazon Timestream database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Configuration blocks with metadata attributes of the time series that are written in each measure record. Nested arguments below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1TopicRuleStatusAtProviderTimestreamDimension>? Dimension { get; set; }

    /// <summary>The IAM role ARN that allows access to the CloudWatch alarm.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Configuration block specifying an application-defined value to replace the default value assigned to the Timestream record's timestamp in the time column. Nested arguments below.</summary>
    [JsonPropertyName("timestamp")]
    public IList<V1beta1TopicRuleStatusAtProviderTimestreamTimestamp>? Timestamp { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusAtProvider
{
    /// <summary>The ARN of the topic rule</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchAlarm")]
    public IList<V1beta1TopicRuleStatusAtProviderCloudwatchAlarm>? CloudwatchAlarm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchLogs")]
    public IList<V1beta1TopicRuleStatusAtProviderCloudwatchLogs>? CloudwatchLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudwatchMetric")]
    public IList<V1beta1TopicRuleStatusAtProviderCloudwatchMetric>? CloudwatchMetric { get; set; }

    /// <summary>The description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dynamodb")]
    public IList<V1beta1TopicRuleStatusAtProviderDynamodb>? Dynamodb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dynamodbv2")]
    public IList<V1beta1TopicRuleStatusAtProviderDynamodbv2>? Dynamodbv2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("elasticsearch")]
    public IList<V1beta1TopicRuleStatusAtProviderElasticsearch>? Elasticsearch { get; set; }

    /// <summary>Specifies whether the rule is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration block with error action to be associated with the rule. See the documentation for cloudwatch_alarm, cloudwatch_logs, cloudwatch_metric, dynamodb, dynamodbv2, elasticsearch, firehose, http, iot_analytics, iot_events, kafka, kinesis, lambda, republish, s3, sns, sqs, step_functions, timestream configuration blocks for further configuration details.</summary>
    [JsonPropertyName("errorAction")]
    public IList<V1beta1TopicRuleStatusAtProviderErrorAction>? ErrorAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firehose")]
    public IList<V1beta1TopicRuleStatusAtProviderFirehose>? Firehose { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public IList<V1beta1TopicRuleStatusAtProviderHttp>? Http { get; set; }

    /// <summary>The unique identifier for the document you are storing.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iotAnalytics")]
    public IList<V1beta1TopicRuleStatusAtProviderIotAnalytics>? IotAnalytics { get; set; }

    /// <summary></summary>
    [JsonPropertyName("iotEvents")]
    public IList<V1beta1TopicRuleStatusAtProviderIotEvents>? IotEvents { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kafka")]
    public IList<V1beta1TopicRuleStatusAtProviderKafka>? Kafka { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kinesis")]
    public IList<V1beta1TopicRuleStatusAtProviderKinesis>? Kinesis { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lambda")]
    public IList<V1beta1TopicRuleStatusAtProviderLambda>? Lambda { get; set; }

    /// <summary></summary>
    [JsonPropertyName("republish")]
    public IList<V1beta1TopicRuleStatusAtProviderRepublish>? Republish { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1beta1TopicRuleStatusAtProviderS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sns")]
    public IList<V1beta1TopicRuleStatusAtProviderSns>? Sns { get; set; }

    /// <summary>The SQL statement used to query the topic. For more information, see AWS IoT SQL Reference (http://docs.aws.amazon.com/iot/latest/developerguide/iot-rules.html#aws-iot-sql-reference) in the AWS IoT Developer Guide.</summary>
    [JsonPropertyName("sql")]
    public string? Sql { get; set; }

    /// <summary>The version of the SQL rules engine to use when evaluating the rule.</summary>
    [JsonPropertyName("sqlVersion")]
    public string? SqlVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqs")]
    public IList<V1beta1TopicRuleStatusAtProviderSqs>? Sqs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stepFunctions")]
    public IList<V1beta1TopicRuleStatusAtProviderStepFunctions>? StepFunctions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timestream")]
    public IList<V1beta1TopicRuleStatusAtProviderTimestream>? Timestream { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatusConditions
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

/// <summary>TopicRuleStatus defines the observed state of TopicRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TopicRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TopicRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>TopicRule is the Schema for the TopicRules API. Creates and manages an AWS IoT topic rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TopicRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TopicRuleSpec>, IStatus<V1beta1TopicRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TopicRule";
    public const string KubeGroup = "iot.aws.upbound.io";
    public const string KubePluralName = "topicrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TopicRuleSpec defines the desired state of TopicRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1TopicRuleSpec Spec { get; set; }

    /// <summary>TopicRuleStatus defines the observed state of TopicRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1TopicRuleStatus? Status { get; set; }
}

/// <summary>TopicRule is the Schema for the TopicRules API. Creates and manages an AWS IoT topic rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TopicRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1TopicRule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TopicRuleList";
    public const string KubeGroup = "iot.aws.upbound.io";
    public const string KubePluralName = "topicrules";
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
    public IList<V1beta1TopicRule> Items { get; set; }
}