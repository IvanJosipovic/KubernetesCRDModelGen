using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3.aws.upbound.io;
public enum V1beta1BucketNotificationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1BucketNotificationSpecForProviderBucketRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketNotificationSpecForProviderBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketNotificationSpecForProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecForProviderBucketRefPolicyResolutionEnum>))]
    public V1beta1BucketNotificationSpecForProviderBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecForProviderBucketRefPolicyResolveEnum>))]
    public V1beta1BucketNotificationSpecForProviderBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
public partial class V1beta1BucketNotificationSpecForProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketNotificationSpecForProviderBucketRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketNotificationSpecForProviderBucketSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketNotificationSpecForProviderBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BucketNotificationSpecForProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecForProviderBucketSelectorPolicyResolutionEnum>))]
    public V1beta1BucketNotificationSpecForProviderBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecForProviderBucketSelectorPolicyResolveEnum>))]
    public V1beta1BucketNotificationSpecForProviderBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
public partial class V1beta1BucketNotificationSpecForProviderBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketNotificationSpecForProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketNotificationSpecForProviderLambdaFunction
{
    /// <summary>Event for which to send notifications.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>Object key name prefix.</summary>
    [JsonPropertyName("filterPrefix")]
    public string? FilterPrefix { get; set; }

    /// <summary>Object key name suffix.</summary>
    [JsonPropertyName("filterSuffix")]
    public string? FilterSuffix { get; set; }

    /// <summary>Unique identifier for each of the notification configurations.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Lambda function ARN.</summary>
    [JsonPropertyName("lambdaFunctionArn")]
    public string? LambdaFunctionArn { get; set; }
}

public enum V1beta1BucketNotificationSpecForProviderQueueQueueArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketNotificationSpecForProviderQueueQueueArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketNotificationSpecForProviderQueueQueueArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecForProviderQueueQueueArnRefPolicyResolutionEnum>))]
    public V1beta1BucketNotificationSpecForProviderQueueQueueArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecForProviderQueueQueueArnRefPolicyResolveEnum>))]
    public V1beta1BucketNotificationSpecForProviderQueueQueueArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate queueArn.</summary>
public partial class V1beta1BucketNotificationSpecForProviderQueueQueueArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketNotificationSpecForProviderQueueQueueArnRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketNotificationSpecForProviderQueueQueueArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketNotificationSpecForProviderQueueQueueArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BucketNotificationSpecForProviderQueueQueueArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecForProviderQueueQueueArnSelectorPolicyResolutionEnum>))]
    public V1beta1BucketNotificationSpecForProviderQueueQueueArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecForProviderQueueQueueArnSelectorPolicyResolveEnum>))]
    public V1beta1BucketNotificationSpecForProviderQueueQueueArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate queueArn.</summary>
public partial class V1beta1BucketNotificationSpecForProviderQueueQueueArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketNotificationSpecForProviderQueueQueueArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketNotificationSpecForProviderQueue
{
    /// <summary>Specifies event for which to send notifications.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>Object key name prefix.</summary>
    [JsonPropertyName("filterPrefix")]
    public string? FilterPrefix { get; set; }

    /// <summary>Object key name suffix.</summary>
    [JsonPropertyName("filterSuffix")]
    public string? FilterSuffix { get; set; }

    /// <summary>Unique identifier for each of the notification configurations.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>SQS queue ARN.</summary>
    [JsonPropertyName("queueArn")]
    public string? QueueArn { get; set; }

    /// <summary>Reference to a Queue in sqs to populate queueArn.</summary>
    [JsonPropertyName("queueArnRef")]
    public V1beta1BucketNotificationSpecForProviderQueueQueueArnRef? QueueArnRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate queueArn.</summary>
    [JsonPropertyName("queueArnSelector")]
    public V1beta1BucketNotificationSpecForProviderQueueQueueArnSelector? QueueArnSelector { get; set; }
}

public enum V1beta1BucketNotificationSpecForProviderTopicTopicArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketNotificationSpecForProviderTopicTopicArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketNotificationSpecForProviderTopicTopicArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecForProviderTopicTopicArnRefPolicyResolutionEnum>))]
    public V1beta1BucketNotificationSpecForProviderTopicTopicArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecForProviderTopicTopicArnRefPolicyResolveEnum>))]
    public V1beta1BucketNotificationSpecForProviderTopicTopicArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate topicArn.</summary>
public partial class V1beta1BucketNotificationSpecForProviderTopicTopicArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketNotificationSpecForProviderTopicTopicArnRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketNotificationSpecForProviderTopicTopicArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketNotificationSpecForProviderTopicTopicArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BucketNotificationSpecForProviderTopicTopicArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecForProviderTopicTopicArnSelectorPolicyResolutionEnum>))]
    public V1beta1BucketNotificationSpecForProviderTopicTopicArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecForProviderTopicTopicArnSelectorPolicyResolveEnum>))]
    public V1beta1BucketNotificationSpecForProviderTopicTopicArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate topicArn.</summary>
public partial class V1beta1BucketNotificationSpecForProviderTopicTopicArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketNotificationSpecForProviderTopicTopicArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketNotificationSpecForProviderTopic
{
    /// <summary>Event for which to send notifications.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>Object key name prefix.</summary>
    [JsonPropertyName("filterPrefix")]
    public string? FilterPrefix { get; set; }

    /// <summary>Object key name suffix.</summary>
    [JsonPropertyName("filterSuffix")]
    public string? FilterSuffix { get; set; }

    /// <summary>Unique identifier for each of the notification configurations.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>SNS topic ARN.</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnRef")]
    public V1beta1BucketNotificationSpecForProviderTopicTopicArnRef? TopicArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnSelector")]
    public V1beta1BucketNotificationSpecForProviderTopicTopicArnSelector? TopicArnSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketNotificationSpecForProvider
{
    /// <summary>Name of the bucket for notification configuration.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketNotificationSpecForProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketNotificationSpecForProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Whether to enable Amazon EventBridge notifications. Defaults to false.</summary>
    [JsonPropertyName("eventbridge")]
    public bool? Eventbridge { get; set; }

    /// <summary>Used to configure notifications to a Lambda Function. See below.</summary>
    [JsonPropertyName("lambdaFunction")]
    public IList<V1beta1BucketNotificationSpecForProviderLambdaFunction>? LambdaFunction { get; set; }

    /// <summary>Notification configuration to SQS Queue. See below.</summary>
    [JsonPropertyName("queue")]
    public IList<V1beta1BucketNotificationSpecForProviderQueue>? Queue { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Notification configuration to SNS Topic. See below.</summary>
    [JsonPropertyName("topic")]
    public IList<V1beta1BucketNotificationSpecForProviderTopic>? Topic { get; set; }
}

public enum V1beta1BucketNotificationSpecInitProviderBucketRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketNotificationSpecInitProviderBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketNotificationSpecInitProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecInitProviderBucketRefPolicyResolutionEnum>))]
    public V1beta1BucketNotificationSpecInitProviderBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecInitProviderBucketRefPolicyResolveEnum>))]
    public V1beta1BucketNotificationSpecInitProviderBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
public partial class V1beta1BucketNotificationSpecInitProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketNotificationSpecInitProviderBucketRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketNotificationSpecInitProviderBucketSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketNotificationSpecInitProviderBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BucketNotificationSpecInitProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecInitProviderBucketSelectorPolicyResolutionEnum>))]
    public V1beta1BucketNotificationSpecInitProviderBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecInitProviderBucketSelectorPolicyResolveEnum>))]
    public V1beta1BucketNotificationSpecInitProviderBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
public partial class V1beta1BucketNotificationSpecInitProviderBucketSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketNotificationSpecInitProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketNotificationSpecInitProviderLambdaFunction
{
    /// <summary>Event for which to send notifications.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>Object key name prefix.</summary>
    [JsonPropertyName("filterPrefix")]
    public string? FilterPrefix { get; set; }

    /// <summary>Object key name suffix.</summary>
    [JsonPropertyName("filterSuffix")]
    public string? FilterSuffix { get; set; }

    /// <summary>Unique identifier for each of the notification configurations.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Lambda function ARN.</summary>
    [JsonPropertyName("lambdaFunctionArn")]
    public string? LambdaFunctionArn { get; set; }
}

public enum V1beta1BucketNotificationSpecInitProviderQueueQueueArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketNotificationSpecInitProviderQueueQueueArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketNotificationSpecInitProviderQueueQueueArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecInitProviderQueueQueueArnRefPolicyResolutionEnum>))]
    public V1beta1BucketNotificationSpecInitProviderQueueQueueArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecInitProviderQueueQueueArnRefPolicyResolveEnum>))]
    public V1beta1BucketNotificationSpecInitProviderQueueQueueArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate queueArn.</summary>
public partial class V1beta1BucketNotificationSpecInitProviderQueueQueueArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketNotificationSpecInitProviderQueueQueueArnRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketNotificationSpecInitProviderQueueQueueArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketNotificationSpecInitProviderQueueQueueArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BucketNotificationSpecInitProviderQueueQueueArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecInitProviderQueueQueueArnSelectorPolicyResolutionEnum>))]
    public V1beta1BucketNotificationSpecInitProviderQueueQueueArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecInitProviderQueueQueueArnSelectorPolicyResolveEnum>))]
    public V1beta1BucketNotificationSpecInitProviderQueueQueueArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate queueArn.</summary>
public partial class V1beta1BucketNotificationSpecInitProviderQueueQueueArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketNotificationSpecInitProviderQueueQueueArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketNotificationSpecInitProviderQueue
{
    /// <summary>Specifies event for which to send notifications.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>Object key name prefix.</summary>
    [JsonPropertyName("filterPrefix")]
    public string? FilterPrefix { get; set; }

    /// <summary>Object key name suffix.</summary>
    [JsonPropertyName("filterSuffix")]
    public string? FilterSuffix { get; set; }

    /// <summary>Unique identifier for each of the notification configurations.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>SQS queue ARN.</summary>
    [JsonPropertyName("queueArn")]
    public string? QueueArn { get; set; }

    /// <summary>Reference to a Queue in sqs to populate queueArn.</summary>
    [JsonPropertyName("queueArnRef")]
    public V1beta1BucketNotificationSpecInitProviderQueueQueueArnRef? QueueArnRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate queueArn.</summary>
    [JsonPropertyName("queueArnSelector")]
    public V1beta1BucketNotificationSpecInitProviderQueueQueueArnSelector? QueueArnSelector { get; set; }
}

public enum V1beta1BucketNotificationSpecInitProviderTopicTopicArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketNotificationSpecInitProviderTopicTopicArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketNotificationSpecInitProviderTopicTopicArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecInitProviderTopicTopicArnRefPolicyResolutionEnum>))]
    public V1beta1BucketNotificationSpecInitProviderTopicTopicArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecInitProviderTopicTopicArnRefPolicyResolveEnum>))]
    public V1beta1BucketNotificationSpecInitProviderTopicTopicArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate topicArn.</summary>
public partial class V1beta1BucketNotificationSpecInitProviderTopicTopicArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketNotificationSpecInitProviderTopicTopicArnRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketNotificationSpecInitProviderTopicTopicArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketNotificationSpecInitProviderTopicTopicArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BucketNotificationSpecInitProviderTopicTopicArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecInitProviderTopicTopicArnSelectorPolicyResolutionEnum>))]
    public V1beta1BucketNotificationSpecInitProviderTopicTopicArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecInitProviderTopicTopicArnSelectorPolicyResolveEnum>))]
    public V1beta1BucketNotificationSpecInitProviderTopicTopicArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate topicArn.</summary>
public partial class V1beta1BucketNotificationSpecInitProviderTopicTopicArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketNotificationSpecInitProviderTopicTopicArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketNotificationSpecInitProviderTopic
{
    /// <summary>Event for which to send notifications.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>Object key name prefix.</summary>
    [JsonPropertyName("filterPrefix")]
    public string? FilterPrefix { get; set; }

    /// <summary>Object key name suffix.</summary>
    [JsonPropertyName("filterSuffix")]
    public string? FilterSuffix { get; set; }

    /// <summary>Unique identifier for each of the notification configurations.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>SNS topic ARN.</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnRef")]
    public V1beta1BucketNotificationSpecInitProviderTopicTopicArnRef? TopicArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnSelector")]
    public V1beta1BucketNotificationSpecInitProviderTopicTopicArnSelector? TopicArnSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1BucketNotificationSpecInitProvider
{
    /// <summary>Name of the bucket for notification configuration.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketNotificationSpecInitProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketNotificationSpecInitProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Whether to enable Amazon EventBridge notifications. Defaults to false.</summary>
    [JsonPropertyName("eventbridge")]
    public bool? Eventbridge { get; set; }

    /// <summary>Used to configure notifications to a Lambda Function. See below.</summary>
    [JsonPropertyName("lambdaFunction")]
    public IList<V1beta1BucketNotificationSpecInitProviderLambdaFunction>? LambdaFunction { get; set; }

    /// <summary>Notification configuration to SQS Queue. See below.</summary>
    [JsonPropertyName("queue")]
    public IList<V1beta1BucketNotificationSpecInitProviderQueue>? Queue { get; set; }

    /// <summary>Notification configuration to SNS Topic. See below.</summary>
    [JsonPropertyName("topic")]
    public IList<V1beta1BucketNotificationSpecInitProviderTopic>? Topic { get; set; }
}

public enum V1beta1BucketNotificationSpecManagementPoliciesEnum
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

public enum V1beta1BucketNotificationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketNotificationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketNotificationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1BucketNotificationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1BucketNotificationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1BucketNotificationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketNotificationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1BucketNotificationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BucketNotificationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BucketNotificationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1BucketNotificationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1BucketNotificationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1BucketNotificationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketNotificationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1BucketNotificationSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1BucketNotificationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BucketNotificationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BucketNotificationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1BucketNotificationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>BucketNotificationSpec defines the desired state of BucketNotification</summary>
public partial class V1beta1BucketNotificationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BucketNotificationSpecDeletionPolicyEnum>))]
    public V1beta1BucketNotificationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BucketNotificationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BucketNotificationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1BucketNotificationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BucketNotificationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BucketNotificationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BucketNotificationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketNotificationStatusAtProviderLambdaFunction
{
    /// <summary>Event for which to send notifications.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>Object key name prefix.</summary>
    [JsonPropertyName("filterPrefix")]
    public string? FilterPrefix { get; set; }

    /// <summary>Object key name suffix.</summary>
    [JsonPropertyName("filterSuffix")]
    public string? FilterSuffix { get; set; }

    /// <summary>Unique identifier for each of the notification configurations.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Lambda function ARN.</summary>
    [JsonPropertyName("lambdaFunctionArn")]
    public string? LambdaFunctionArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketNotificationStatusAtProviderQueue
{
    /// <summary>Specifies event for which to send notifications.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>Object key name prefix.</summary>
    [JsonPropertyName("filterPrefix")]
    public string? FilterPrefix { get; set; }

    /// <summary>Object key name suffix.</summary>
    [JsonPropertyName("filterSuffix")]
    public string? FilterSuffix { get; set; }

    /// <summary>Unique identifier for each of the notification configurations.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>SQS queue ARN.</summary>
    [JsonPropertyName("queueArn")]
    public string? QueueArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketNotificationStatusAtProviderTopic
{
    /// <summary>Event for which to send notifications.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>Object key name prefix.</summary>
    [JsonPropertyName("filterPrefix")]
    public string? FilterPrefix { get; set; }

    /// <summary>Object key name suffix.</summary>
    [JsonPropertyName("filterSuffix")]
    public string? FilterSuffix { get; set; }

    /// <summary>Unique identifier for each of the notification configurations.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>SNS topic ARN.</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1BucketNotificationStatusAtProvider
{
    /// <summary>Name of the bucket for notification configuration.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Whether to enable Amazon EventBridge notifications. Defaults to false.</summary>
    [JsonPropertyName("eventbridge")]
    public bool? Eventbridge { get; set; }

    /// <summary>Unique identifier for each of the notification configurations.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Used to configure notifications to a Lambda Function. See below.</summary>
    [JsonPropertyName("lambdaFunction")]
    public IList<V1beta1BucketNotificationStatusAtProviderLambdaFunction>? LambdaFunction { get; set; }

    /// <summary>Notification configuration to SQS Queue. See below.</summary>
    [JsonPropertyName("queue")]
    public IList<V1beta1BucketNotificationStatusAtProviderQueue>? Queue { get; set; }

    /// <summary>Notification configuration to SNS Topic. See below.</summary>
    [JsonPropertyName("topic")]
    public IList<V1beta1BucketNotificationStatusAtProviderTopic>? Topic { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1BucketNotificationStatusConditions
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

/// <summary>BucketNotificationStatus defines the observed state of BucketNotification.</summary>
public partial class V1beta1BucketNotificationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BucketNotificationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BucketNotificationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>BucketNotification is the Schema for the BucketNotifications API. Manages a S3 Bucket Notification Configuration</summary>
public partial class V1beta1BucketNotification : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BucketNotificationSpec>, IStatus<V1beta1BucketNotificationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BucketNotification";
    public const string KubeGroup = "s3.aws.upbound.io";
    public const string KubePluralName = "bucketnotifications";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BucketNotificationSpec defines the desired state of BucketNotification</summary>
    [JsonPropertyName("spec")]
    public V1beta1BucketNotificationSpec Spec { get; set; }

    /// <summary>BucketNotificationStatus defines the observed state of BucketNotification.</summary>
    [JsonPropertyName("status")]
    public V1beta1BucketNotificationStatus? Status { get; set; }
}