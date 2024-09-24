using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.scheduler.aws.upbound.io;
public enum V1beta1ScheduleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecForProviderFlexibleTimeWindow
{
    /// <summary>Maximum time window during which a schedule can be invoked. Ranges from 1 to 1440 minutes.</summary>
    [JsonPropertyName("maximumWindowInMinutes")]
    public double? MaximumWindowInMinutes { get; set; }

    /// <summary>Determines whether the schedule is invoked within a flexible time window. One of: OFF, FLEXIBLE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

public enum V1beta1ScheduleSpecForProviderKmsKeyArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ScheduleSpecForProviderKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ScheduleSpecForProviderKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecForProviderKmsKeyArnRefPolicyResolutionEnum>))]
    public V1beta1ScheduleSpecForProviderKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecForProviderKmsKeyArnRefPolicyResolveEnum>))]
    public V1beta1ScheduleSpecForProviderKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
public partial class V1beta1ScheduleSpecForProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecForProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ScheduleSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ScheduleSpecForProviderKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ScheduleSpecForProviderKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum>))]
    public V1beta1ScheduleSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecForProviderKmsKeyArnSelectorPolicyResolveEnum>))]
    public V1beta1ScheduleSpecForProviderKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
public partial class V1beta1ScheduleSpecForProviderKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecForProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ScheduleSpecForProviderTargetArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ScheduleSpecForProviderTargetArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ScheduleSpecForProviderTargetArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecForProviderTargetArnRefPolicyResolutionEnum>))]
    public V1beta1ScheduleSpecForProviderTargetArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecForProviderTargetArnRefPolicyResolveEnum>))]
    public V1beta1ScheduleSpecForProviderTargetArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate arn.</summary>
public partial class V1beta1ScheduleSpecForProviderTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecForProviderTargetArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ScheduleSpecForProviderTargetArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ScheduleSpecForProviderTargetArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ScheduleSpecForProviderTargetArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecForProviderTargetArnSelectorPolicyResolutionEnum>))]
    public V1beta1ScheduleSpecForProviderTargetArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecForProviderTargetArnSelectorPolicyResolveEnum>))]
    public V1beta1ScheduleSpecForProviderTargetArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate arn.</summary>
public partial class V1beta1ScheduleSpecForProviderTargetArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecForProviderTargetArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecForProviderTargetDeadLetterConfig
{
    /// <summary>ARN of the target of this schedule, such as a SQS queue or ECS cluster. For universal targets, this is a Service ARN specific to the target service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecForProviderTargetEcsParametersCapacityProviderStrategy
{
    /// <summary>How many tasks, at a minimum, to run on the specified capacity provider. Only one capacity provider in a capacity provider strategy can have a base defined. Ranges from 0 (default) to 100000.</summary>
    [JsonPropertyName("base")]
    public double? Base { get; set; }

    /// <summary>Short name of the capacity provider.</summary>
    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    /// <summary>Designates the relative percentage of the total number of tasks launched that should use the specified capacity provider. The weight value is taken into consideration after the base value, if defined, is satisfied. Ranges from from 0 to 1000.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecForProviderTargetEcsParametersNetworkConfiguration
{
    /// <summary>Specifies whether the task's elastic network interface receives a public IP address. This attribute is a boolean type, where true maps to ENABLED and false to DISABLED. You can specify true only when the launch_type is set to FARGATE.</summary>
    [JsonPropertyName("assignPublicIp")]
    public bool? AssignPublicIp { get; set; }

    /// <summary>Set of 1 to 5 Security Group ID-s to be associated with the task. These security groups must all be in the same VPC.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Set of 1 to 16 subnets to be associated with the task. These subnets must all be in the same VPC.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecForProviderTargetEcsParametersPlacementConstraints
{
    /// <summary>A cluster query language expression to apply to the constraint. You cannot specify an expression if the constraint type is distinctInstance. For more information, see Cluster query language in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The type of placement strategy. One of: random, spread, binpack.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecForProviderTargetEcsParametersPlacementStrategy
{
    /// <summary>The field to apply the placement strategy against.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>The type of placement strategy. One of: random, spread, binpack.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecForProviderTargetEcsParameters
{
    /// <summary>Up to 6 capacity provider strategies to use for the task. Detailed below.</summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1beta1ScheduleSpecForProviderTargetEcsParametersCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>Specifies whether to enable Amazon ECS managed tags for the task. For more information, see Tagging Your Amazon ECS Resources in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("enableEcsManagedTags")]
    public bool? EnableEcsManagedTags { get; set; }

    /// <summary>Specifies whether to enable the execute command functionality for the containers in this task.</summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>Specifies an ECS task group for the task. At most 255 characters.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. One of: EC2, FARGATE, EXTERNAL.</summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>Configures the networking associated with the task. Detailed below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public IList<V1beta1ScheduleSpecForProviderTargetEcsParametersNetworkConfiguration>? NetworkConfiguration { get; set; }

    /// <summary>A set of up to 10 placement constraints to use for the task. Detailed below.</summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1beta1ScheduleSpecForProviderTargetEcsParametersPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>A set of up to 5 placement strategies. Detailed below.</summary>
    [JsonPropertyName("placementStrategy")]
    public IList<V1beta1ScheduleSpecForProviderTargetEcsParametersPlacementStrategy>? PlacementStrategy { get; set; }

    /// <summary>Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Specifies whether to propagate the tags from the task definition to the task. One of: TASK_DEFINITION.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>Reference ID to use for the task.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The number of tasks to create. Ranges from 1 (default) to 10.</summary>
    [JsonPropertyName("taskCount")]
    public double? TaskCount { get; set; }

    /// <summary>ARN of the task definition to use.</summary>
    [JsonPropertyName("taskDefinitionArn")]
    public string? TaskDefinitionArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecForProviderTargetEventbridgeParameters
{
    /// <summary>Free-form string used to decide what fields to expect in the event detail. Up to 128 characters.</summary>
    [JsonPropertyName("detailType")]
    public string? DetailType { get; set; }

    /// <summary>Source of the event.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecForProviderTargetKinesisParameters
{
    /// <summary>Specifies the shard to which EventBridge Scheduler sends the event. Up to 256 characters.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecForProviderTargetRetryPolicy
{
    /// <summary>Maximum amount of time, in seconds, to continue to make retry attempts. Ranges from 60 to 86400 (default).</summary>
    [JsonPropertyName("maximumEventAgeInSeconds")]
    public double? MaximumEventAgeInSeconds { get; set; }

    /// <summary>Maximum number of retry attempts to make before the request fails. Ranges from 0 to 185 (default).</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }
}

public enum V1beta1ScheduleSpecForProviderTargetRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ScheduleSpecForProviderTargetRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ScheduleSpecForProviderTargetRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecForProviderTargetRoleArnRefPolicyResolutionEnum>))]
    public V1beta1ScheduleSpecForProviderTargetRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecForProviderTargetRoleArnRefPolicyResolveEnum>))]
    public V1beta1ScheduleSpecForProviderTargetRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
public partial class V1beta1ScheduleSpecForProviderTargetRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecForProviderTargetRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ScheduleSpecForProviderTargetRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ScheduleSpecForProviderTargetRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ScheduleSpecForProviderTargetRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecForProviderTargetRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1ScheduleSpecForProviderTargetRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecForProviderTargetRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1ScheduleSpecForProviderTargetRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
public partial class V1beta1ScheduleSpecForProviderTargetRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecForProviderTargetRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecForProviderTargetSagemakerPipelineParametersPipelineParameter
{
    /// <summary>Name of parameter to start execution of a SageMaker Model Building Pipeline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of parameter to start execution of a SageMaker Model Building Pipeline.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecForProviderTargetSagemakerPipelineParameters
{
    /// <summary>Set of up to 200 parameter names and values to use when executing the SageMaker Model Building Pipeline. Detailed below.</summary>
    [JsonPropertyName("pipelineParameter")]
    public IList<V1beta1ScheduleSpecForProviderTargetSagemakerPipelineParametersPipelineParameter>? PipelineParameter { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecForProviderTargetSqsParameters
{
    /// <summary>FIFO message group ID to use as the target.</summary>
    [JsonPropertyName("messageGroupId")]
    public string? MessageGroupId { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecForProviderTarget
{
    /// <summary>ARN of the target of this schedule, such as a SQS queue or ECS cluster. For universal targets, this is a Service ARN specific to the target service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Queue in sqs to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1ScheduleSpecForProviderTargetArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1ScheduleSpecForProviderTargetArnSelector? ArnSelector { get; set; }

    /// <summary>Information about an Amazon SQS queue that EventBridge Scheduler uses as a dead-letter queue for your schedule. If specified, EventBridge Scheduler delivers failed events that could not be successfully delivered to a target to the queue. Detailed below.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public IList<V1beta1ScheduleSpecForProviderTargetDeadLetterConfig>? DeadLetterConfig { get; set; }

    /// <summary>Templated target type for the Amazon ECS RunTask API operation. Detailed below.</summary>
    [JsonPropertyName("ecsParameters")]
    public IList<V1beta1ScheduleSpecForProviderTargetEcsParameters>? EcsParameters { get; set; }

    /// <summary>Templated target type for the EventBridge PutEvents API operation. Detailed below.</summary>
    [JsonPropertyName("eventbridgeParameters")]
    public IList<V1beta1ScheduleSpecForProviderTargetEventbridgeParameters>? EventbridgeParameters { get; set; }

    /// <summary>Text, or well-formed JSON, passed to the target. Read more in Universal target.</summary>
    [JsonPropertyName("input")]
    public string? Input { get; set; }

    /// <summary>Templated target type for the Amazon Kinesis PutRecord API operation. Detailed below.</summary>
    [JsonPropertyName("kinesisParameters")]
    public IList<V1beta1ScheduleSpecForProviderTargetKinesisParameters>? KinesisParameters { get; set; }

    /// <summary>Information about the retry policy settings. Detailed below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1ScheduleSpecForProviderTargetRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>ARN of the IAM role that EventBridge Scheduler will use for this target when the schedule is invoked. Read more in Set up the execution role.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ScheduleSpecForProviderTargetRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ScheduleSpecForProviderTargetRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Templated target type for the Amazon SageMaker StartPipelineExecution API operation. Detailed below.</summary>
    [JsonPropertyName("sagemakerPipelineParameters")]
    public IList<V1beta1ScheduleSpecForProviderTargetSagemakerPipelineParameters>? SagemakerPipelineParameters { get; set; }

    /// <summary>The templated target type for the Amazon SQS SendMessage API operation. Detailed below.</summary>
    [JsonPropertyName("sqsParameters")]
    public IList<V1beta1ScheduleSpecForProviderTargetSqsParameters>? SqsParameters { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecForProvider
{
    /// <summary>Brief description of the schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The date, in UTC, before which the schedule can invoke its target. Depending on the schedule's recurrence expression, invocations might stop on, or before, the end date you specify. EventBridge Scheduler ignores the end date for one-time schedules. Example: 2030-01-01T01:00:00Z.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>Configures a time window during which EventBridge Scheduler invokes the schedule. Detailed below.</summary>
    [JsonPropertyName("flexibleTimeWindow")]
    public IList<V1beta1ScheduleSpecForProviderFlexibleTimeWindow>? FlexibleTimeWindow { get; set; }

    /// <summary>Name of the schedule group to associate with this schedule. When omitted, the default schedule group is used.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>ARN for the customer managed KMS key that EventBridge Scheduler will use to encrypt and decrypt your data.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1ScheduleSpecForProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1ScheduleSpecForProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Name of the schedule. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Defines when the schedule runs. Read more in Schedule types on EventBridge Scheduler.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>Timezone in which the scheduling expression is evaluated. Defaults to UTC. Example: Australia/Sydney.</summary>
    [JsonPropertyName("scheduleExpressionTimezone")]
    public string? ScheduleExpressionTimezone { get; set; }

    /// <summary>The date, in UTC, after which the schedule can begin invoking its target. Depending on the schedule's recurrence expression, invocations might occur on, or after, the start date you specify. EventBridge Scheduler ignores the start date for one-time schedules. Example: 2030-01-01T01:00:00Z.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>Specifies whether the schedule is enabled or disabled. One of: ENABLED (default), DISABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Configures the target of the schedule. Detailed below.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta1ScheduleSpecForProviderTarget>? Target { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecInitProviderFlexibleTimeWindow
{
    /// <summary>Maximum time window during which a schedule can be invoked. Ranges from 1 to 1440 minutes.</summary>
    [JsonPropertyName("maximumWindowInMinutes")]
    public double? MaximumWindowInMinutes { get; set; }

    /// <summary>Determines whether the schedule is invoked within a flexible time window. One of: OFF, FLEXIBLE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

public enum V1beta1ScheduleSpecInitProviderKmsKeyArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ScheduleSpecInitProviderKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ScheduleSpecInitProviderKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecInitProviderKmsKeyArnRefPolicyResolutionEnum>))]
    public V1beta1ScheduleSpecInitProviderKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecInitProviderKmsKeyArnRefPolicyResolveEnum>))]
    public V1beta1ScheduleSpecInitProviderKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
public partial class V1beta1ScheduleSpecInitProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecInitProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ScheduleSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ScheduleSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ScheduleSpecInitProviderKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum>))]
    public V1beta1ScheduleSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum>))]
    public V1beta1ScheduleSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
public partial class V1beta1ScheduleSpecInitProviderKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecInitProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ScheduleSpecInitProviderTargetArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ScheduleSpecInitProviderTargetArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ScheduleSpecInitProviderTargetArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecInitProviderTargetArnRefPolicyResolutionEnum>))]
    public V1beta1ScheduleSpecInitProviderTargetArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecInitProviderTargetArnRefPolicyResolveEnum>))]
    public V1beta1ScheduleSpecInitProviderTargetArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate arn.</summary>
public partial class V1beta1ScheduleSpecInitProviderTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecInitProviderTargetArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ScheduleSpecInitProviderTargetArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ScheduleSpecInitProviderTargetArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ScheduleSpecInitProviderTargetArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecInitProviderTargetArnSelectorPolicyResolutionEnum>))]
    public V1beta1ScheduleSpecInitProviderTargetArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecInitProviderTargetArnSelectorPolicyResolveEnum>))]
    public V1beta1ScheduleSpecInitProviderTargetArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate arn.</summary>
public partial class V1beta1ScheduleSpecInitProviderTargetArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecInitProviderTargetArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecInitProviderTargetDeadLetterConfig
{
    /// <summary>ARN of the target of this schedule, such as a SQS queue or ECS cluster. For universal targets, this is a Service ARN specific to the target service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecInitProviderTargetEcsParametersCapacityProviderStrategy
{
    /// <summary>How many tasks, at a minimum, to run on the specified capacity provider. Only one capacity provider in a capacity provider strategy can have a base defined. Ranges from 0 (default) to 100000.</summary>
    [JsonPropertyName("base")]
    public double? Base { get; set; }

    /// <summary>Short name of the capacity provider.</summary>
    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    /// <summary>Designates the relative percentage of the total number of tasks launched that should use the specified capacity provider. The weight value is taken into consideration after the base value, if defined, is satisfied. Ranges from from 0 to 1000.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecInitProviderTargetEcsParametersNetworkConfiguration
{
    /// <summary>Specifies whether the task's elastic network interface receives a public IP address. This attribute is a boolean type, where true maps to ENABLED and false to DISABLED. You can specify true only when the launch_type is set to FARGATE.</summary>
    [JsonPropertyName("assignPublicIp")]
    public bool? AssignPublicIp { get; set; }

    /// <summary>Set of 1 to 5 Security Group ID-s to be associated with the task. These security groups must all be in the same VPC.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Set of 1 to 16 subnets to be associated with the task. These subnets must all be in the same VPC.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecInitProviderTargetEcsParametersPlacementConstraints
{
    /// <summary>A cluster query language expression to apply to the constraint. You cannot specify an expression if the constraint type is distinctInstance. For more information, see Cluster query language in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The type of placement strategy. One of: random, spread, binpack.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecInitProviderTargetEcsParametersPlacementStrategy
{
    /// <summary>The field to apply the placement strategy against.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>The type of placement strategy. One of: random, spread, binpack.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecInitProviderTargetEcsParameters
{
    /// <summary>Up to 6 capacity provider strategies to use for the task. Detailed below.</summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1beta1ScheduleSpecInitProviderTargetEcsParametersCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>Specifies whether to enable Amazon ECS managed tags for the task. For more information, see Tagging Your Amazon ECS Resources in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("enableEcsManagedTags")]
    public bool? EnableEcsManagedTags { get; set; }

    /// <summary>Specifies whether to enable the execute command functionality for the containers in this task.</summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>Specifies an ECS task group for the task. At most 255 characters.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. One of: EC2, FARGATE, EXTERNAL.</summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>Configures the networking associated with the task. Detailed below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public IList<V1beta1ScheduleSpecInitProviderTargetEcsParametersNetworkConfiguration>? NetworkConfiguration { get; set; }

    /// <summary>A set of up to 10 placement constraints to use for the task. Detailed below.</summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1beta1ScheduleSpecInitProviderTargetEcsParametersPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>A set of up to 5 placement strategies. Detailed below.</summary>
    [JsonPropertyName("placementStrategy")]
    public IList<V1beta1ScheduleSpecInitProviderTargetEcsParametersPlacementStrategy>? PlacementStrategy { get; set; }

    /// <summary>Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Specifies whether to propagate the tags from the task definition to the task. One of: TASK_DEFINITION.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>Reference ID to use for the task.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The number of tasks to create. Ranges from 1 (default) to 10.</summary>
    [JsonPropertyName("taskCount")]
    public double? TaskCount { get; set; }

    /// <summary>ARN of the task definition to use.</summary>
    [JsonPropertyName("taskDefinitionArn")]
    public string? TaskDefinitionArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecInitProviderTargetEventbridgeParameters
{
    /// <summary>Free-form string used to decide what fields to expect in the event detail. Up to 128 characters.</summary>
    [JsonPropertyName("detailType")]
    public string? DetailType { get; set; }

    /// <summary>Source of the event.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecInitProviderTargetKinesisParameters
{
    /// <summary>Specifies the shard to which EventBridge Scheduler sends the event. Up to 256 characters.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecInitProviderTargetRetryPolicy
{
    /// <summary>Maximum amount of time, in seconds, to continue to make retry attempts. Ranges from 60 to 86400 (default).</summary>
    [JsonPropertyName("maximumEventAgeInSeconds")]
    public double? MaximumEventAgeInSeconds { get; set; }

    /// <summary>Maximum number of retry attempts to make before the request fails. Ranges from 0 to 185 (default).</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }
}

public enum V1beta1ScheduleSpecInitProviderTargetRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ScheduleSpecInitProviderTargetRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ScheduleSpecInitProviderTargetRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecInitProviderTargetRoleArnRefPolicyResolutionEnum>))]
    public V1beta1ScheduleSpecInitProviderTargetRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecInitProviderTargetRoleArnRefPolicyResolveEnum>))]
    public V1beta1ScheduleSpecInitProviderTargetRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
public partial class V1beta1ScheduleSpecInitProviderTargetRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecInitProviderTargetRoleArnRefPolicy? Policy { get; set; }
}

public enum V1beta1ScheduleSpecInitProviderTargetRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ScheduleSpecInitProviderTargetRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ScheduleSpecInitProviderTargetRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecInitProviderTargetRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1ScheduleSpecInitProviderTargetRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecInitProviderTargetRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1ScheduleSpecInitProviderTargetRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
public partial class V1beta1ScheduleSpecInitProviderTargetRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecInitProviderTargetRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecInitProviderTargetSagemakerPipelineParametersPipelineParameter
{
    /// <summary>Name of parameter to start execution of a SageMaker Model Building Pipeline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of parameter to start execution of a SageMaker Model Building Pipeline.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecInitProviderTargetSagemakerPipelineParameters
{
    /// <summary>Set of up to 200 parameter names and values to use when executing the SageMaker Model Building Pipeline. Detailed below.</summary>
    [JsonPropertyName("pipelineParameter")]
    public IList<V1beta1ScheduleSpecInitProviderTargetSagemakerPipelineParametersPipelineParameter>? PipelineParameter { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecInitProviderTargetSqsParameters
{
    /// <summary>FIFO message group ID to use as the target.</summary>
    [JsonPropertyName("messageGroupId")]
    public string? MessageGroupId { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleSpecInitProviderTarget
{
    /// <summary>ARN of the target of this schedule, such as a SQS queue or ECS cluster. For universal targets, this is a Service ARN specific to the target service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Queue in sqs to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1ScheduleSpecInitProviderTargetArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1ScheduleSpecInitProviderTargetArnSelector? ArnSelector { get; set; }

    /// <summary>Information about an Amazon SQS queue that EventBridge Scheduler uses as a dead-letter queue for your schedule. If specified, EventBridge Scheduler delivers failed events that could not be successfully delivered to a target to the queue. Detailed below.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public IList<V1beta1ScheduleSpecInitProviderTargetDeadLetterConfig>? DeadLetterConfig { get; set; }

    /// <summary>Templated target type for the Amazon ECS RunTask API operation. Detailed below.</summary>
    [JsonPropertyName("ecsParameters")]
    public IList<V1beta1ScheduleSpecInitProviderTargetEcsParameters>? EcsParameters { get; set; }

    /// <summary>Templated target type for the EventBridge PutEvents API operation. Detailed below.</summary>
    [JsonPropertyName("eventbridgeParameters")]
    public IList<V1beta1ScheduleSpecInitProviderTargetEventbridgeParameters>? EventbridgeParameters { get; set; }

    /// <summary>Text, or well-formed JSON, passed to the target. Read more in Universal target.</summary>
    [JsonPropertyName("input")]
    public string? Input { get; set; }

    /// <summary>Templated target type for the Amazon Kinesis PutRecord API operation. Detailed below.</summary>
    [JsonPropertyName("kinesisParameters")]
    public IList<V1beta1ScheduleSpecInitProviderTargetKinesisParameters>? KinesisParameters { get; set; }

    /// <summary>Information about the retry policy settings. Detailed below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1ScheduleSpecInitProviderTargetRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>ARN of the IAM role that EventBridge Scheduler will use for this target when the schedule is invoked. Read more in Set up the execution role.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ScheduleSpecInitProviderTargetRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ScheduleSpecInitProviderTargetRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Templated target type for the Amazon SageMaker StartPipelineExecution API operation. Detailed below.</summary>
    [JsonPropertyName("sagemakerPipelineParameters")]
    public IList<V1beta1ScheduleSpecInitProviderTargetSagemakerPipelineParameters>? SagemakerPipelineParameters { get; set; }

    /// <summary>The templated target type for the Amazon SQS SendMessage API operation. Detailed below.</summary>
    [JsonPropertyName("sqsParameters")]
    public IList<V1beta1ScheduleSpecInitProviderTargetSqsParameters>? SqsParameters { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1ScheduleSpecInitProvider
{
    /// <summary>Brief description of the schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The date, in UTC, before which the schedule can invoke its target. Depending on the schedule's recurrence expression, invocations might stop on, or before, the end date you specify. EventBridge Scheduler ignores the end date for one-time schedules. Example: 2030-01-01T01:00:00Z.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>Configures a time window during which EventBridge Scheduler invokes the schedule. Detailed below.</summary>
    [JsonPropertyName("flexibleTimeWindow")]
    public IList<V1beta1ScheduleSpecInitProviderFlexibleTimeWindow>? FlexibleTimeWindow { get; set; }

    /// <summary>Name of the schedule group to associate with this schedule. When omitted, the default schedule group is used.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>ARN for the customer managed KMS key that EventBridge Scheduler will use to encrypt and decrypt your data.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1ScheduleSpecInitProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1ScheduleSpecInitProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Name of the schedule. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Defines when the schedule runs. Read more in Schedule types on EventBridge Scheduler.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>Timezone in which the scheduling expression is evaluated. Defaults to UTC. Example: Australia/Sydney.</summary>
    [JsonPropertyName("scheduleExpressionTimezone")]
    public string? ScheduleExpressionTimezone { get; set; }

    /// <summary>The date, in UTC, after which the schedule can begin invoking its target. Depending on the schedule's recurrence expression, invocations might occur on, or after, the start date you specify. EventBridge Scheduler ignores the start date for one-time schedules. Example: 2030-01-01T01:00:00Z.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>Specifies whether the schedule is enabled or disabled. One of: ENABLED (default), DISABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Configures the target of the schedule. Detailed below.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta1ScheduleSpecInitProviderTarget>? Target { get; set; }
}

public enum V1beta1ScheduleSpecManagementPoliciesEnum
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

public enum V1beta1ScheduleSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ScheduleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ScheduleSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ScheduleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ScheduleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1ScheduleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ScheduleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ScheduleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ScheduleSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ScheduleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ScheduleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1ScheduleSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1ScheduleSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ScheduleSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ScheduleSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ScheduleSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1ScheduleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ScheduleSpec defines the desired state of Schedule</summary>
public partial class V1beta1ScheduleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ScheduleSpecDeletionPolicyEnum>))]
    public V1beta1ScheduleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ScheduleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ScheduleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ScheduleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ScheduleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ScheduleSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ScheduleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleStatusAtProviderFlexibleTimeWindow
{
    /// <summary>Maximum time window during which a schedule can be invoked. Ranges from 1 to 1440 minutes.</summary>
    [JsonPropertyName("maximumWindowInMinutes")]
    public double? MaximumWindowInMinutes { get; set; }

    /// <summary>Determines whether the schedule is invoked within a flexible time window. One of: OFF, FLEXIBLE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleStatusAtProviderTargetDeadLetterConfig
{
    /// <summary>ARN of the target of this schedule, such as a SQS queue or ECS cluster. For universal targets, this is a Service ARN specific to the target service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleStatusAtProviderTargetEcsParametersCapacityProviderStrategy
{
    /// <summary>How many tasks, at a minimum, to run on the specified capacity provider. Only one capacity provider in a capacity provider strategy can have a base defined. Ranges from 0 (default) to 100000.</summary>
    [JsonPropertyName("base")]
    public double? Base { get; set; }

    /// <summary>Short name of the capacity provider.</summary>
    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    /// <summary>Designates the relative percentage of the total number of tasks launched that should use the specified capacity provider. The weight value is taken into consideration after the base value, if defined, is satisfied. Ranges from from 0 to 1000.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleStatusAtProviderTargetEcsParametersNetworkConfiguration
{
    /// <summary>Specifies whether the task's elastic network interface receives a public IP address. This attribute is a boolean type, where true maps to ENABLED and false to DISABLED. You can specify true only when the launch_type is set to FARGATE.</summary>
    [JsonPropertyName("assignPublicIp")]
    public bool? AssignPublicIp { get; set; }

    /// <summary>Set of 1 to 5 Security Group ID-s to be associated with the task. These security groups must all be in the same VPC.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Set of 1 to 16 subnets to be associated with the task. These subnets must all be in the same VPC.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleStatusAtProviderTargetEcsParametersPlacementConstraints
{
    /// <summary>A cluster query language expression to apply to the constraint. You cannot specify an expression if the constraint type is distinctInstance. For more information, see Cluster query language in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The type of placement strategy. One of: random, spread, binpack.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleStatusAtProviderTargetEcsParametersPlacementStrategy
{
    /// <summary>The field to apply the placement strategy against.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>The type of placement strategy. One of: random, spread, binpack.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleStatusAtProviderTargetEcsParameters
{
    /// <summary>Up to 6 capacity provider strategies to use for the task. Detailed below.</summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1beta1ScheduleStatusAtProviderTargetEcsParametersCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>Specifies whether to enable Amazon ECS managed tags for the task. For more information, see Tagging Your Amazon ECS Resources in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("enableEcsManagedTags")]
    public bool? EnableEcsManagedTags { get; set; }

    /// <summary>Specifies whether to enable the execute command functionality for the containers in this task.</summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>Specifies an ECS task group for the task. At most 255 characters.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. One of: EC2, FARGATE, EXTERNAL.</summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>Configures the networking associated with the task. Detailed below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public IList<V1beta1ScheduleStatusAtProviderTargetEcsParametersNetworkConfiguration>? NetworkConfiguration { get; set; }

    /// <summary>A set of up to 10 placement constraints to use for the task. Detailed below.</summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1beta1ScheduleStatusAtProviderTargetEcsParametersPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>A set of up to 5 placement strategies. Detailed below.</summary>
    [JsonPropertyName("placementStrategy")]
    public IList<V1beta1ScheduleStatusAtProviderTargetEcsParametersPlacementStrategy>? PlacementStrategy { get; set; }

    /// <summary>Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Specifies whether to propagate the tags from the task definition to the task. One of: TASK_DEFINITION.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>Reference ID to use for the task.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The number of tasks to create. Ranges from 1 (default) to 10.</summary>
    [JsonPropertyName("taskCount")]
    public double? TaskCount { get; set; }

    /// <summary>ARN of the task definition to use.</summary>
    [JsonPropertyName("taskDefinitionArn")]
    public string? TaskDefinitionArn { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleStatusAtProviderTargetEventbridgeParameters
{
    /// <summary>Free-form string used to decide what fields to expect in the event detail. Up to 128 characters.</summary>
    [JsonPropertyName("detailType")]
    public string? DetailType { get; set; }

    /// <summary>Source of the event.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleStatusAtProviderTargetKinesisParameters
{
    /// <summary>Specifies the shard to which EventBridge Scheduler sends the event. Up to 256 characters.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleStatusAtProviderTargetRetryPolicy
{
    /// <summary>Maximum amount of time, in seconds, to continue to make retry attempts. Ranges from 60 to 86400 (default).</summary>
    [JsonPropertyName("maximumEventAgeInSeconds")]
    public double? MaximumEventAgeInSeconds { get; set; }

    /// <summary>Maximum number of retry attempts to make before the request fails. Ranges from 0 to 185 (default).</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleStatusAtProviderTargetSagemakerPipelineParametersPipelineParameter
{
    /// <summary>Name of parameter to start execution of a SageMaker Model Building Pipeline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of parameter to start execution of a SageMaker Model Building Pipeline.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleStatusAtProviderTargetSagemakerPipelineParameters
{
    /// <summary>Set of up to 200 parameter names and values to use when executing the SageMaker Model Building Pipeline. Detailed below.</summary>
    [JsonPropertyName("pipelineParameter")]
    public IList<V1beta1ScheduleStatusAtProviderTargetSagemakerPipelineParametersPipelineParameter>? PipelineParameter { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleStatusAtProviderTargetSqsParameters
{
    /// <summary>FIFO message group ID to use as the target.</summary>
    [JsonPropertyName("messageGroupId")]
    public string? MessageGroupId { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleStatusAtProviderTarget
{
    /// <summary>ARN of the target of this schedule, such as a SQS queue or ECS cluster. For universal targets, this is a Service ARN specific to the target service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Information about an Amazon SQS queue that EventBridge Scheduler uses as a dead-letter queue for your schedule. If specified, EventBridge Scheduler delivers failed events that could not be successfully delivered to a target to the queue. Detailed below.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public IList<V1beta1ScheduleStatusAtProviderTargetDeadLetterConfig>? DeadLetterConfig { get; set; }

    /// <summary>Templated target type for the Amazon ECS RunTask API operation. Detailed below.</summary>
    [JsonPropertyName("ecsParameters")]
    public IList<V1beta1ScheduleStatusAtProviderTargetEcsParameters>? EcsParameters { get; set; }

    /// <summary>Templated target type for the EventBridge PutEvents API operation. Detailed below.</summary>
    [JsonPropertyName("eventbridgeParameters")]
    public IList<V1beta1ScheduleStatusAtProviderTargetEventbridgeParameters>? EventbridgeParameters { get; set; }

    /// <summary>Text, or well-formed JSON, passed to the target. Read more in Universal target.</summary>
    [JsonPropertyName("input")]
    public string? Input { get; set; }

    /// <summary>Templated target type for the Amazon Kinesis PutRecord API operation. Detailed below.</summary>
    [JsonPropertyName("kinesisParameters")]
    public IList<V1beta1ScheduleStatusAtProviderTargetKinesisParameters>? KinesisParameters { get; set; }

    /// <summary>Information about the retry policy settings. Detailed below.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1ScheduleStatusAtProviderTargetRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>ARN of the IAM role that EventBridge Scheduler will use for this target when the schedule is invoked. Read more in Set up the execution role.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Templated target type for the Amazon SageMaker StartPipelineExecution API operation. Detailed below.</summary>
    [JsonPropertyName("sagemakerPipelineParameters")]
    public IList<V1beta1ScheduleStatusAtProviderTargetSagemakerPipelineParameters>? SagemakerPipelineParameters { get; set; }

    /// <summary>The templated target type for the Amazon SQS SendMessage API operation. Detailed below.</summary>
    [JsonPropertyName("sqsParameters")]
    public IList<V1beta1ScheduleStatusAtProviderTargetSqsParameters>? SqsParameters { get; set; }
}

/// <summary></summary>
public partial class V1beta1ScheduleStatusAtProvider
{
    /// <summary>ARN of the SQS queue specified as the destination for the dead-letter queue.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Brief description of the schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The date, in UTC, before which the schedule can invoke its target. Depending on the schedule's recurrence expression, invocations might stop on, or before, the end date you specify. EventBridge Scheduler ignores the end date for one-time schedules. Example: 2030-01-01T01:00:00Z.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>Configures a time window during which EventBridge Scheduler invokes the schedule. Detailed below.</summary>
    [JsonPropertyName("flexibleTimeWindow")]
    public IList<V1beta1ScheduleStatusAtProviderFlexibleTimeWindow>? FlexibleTimeWindow { get; set; }

    /// <summary>Name of the schedule group to associate with this schedule. When omitted, the default schedule group is used.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>Name of the schedule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN for the customer managed KMS key that EventBridge Scheduler will use to encrypt and decrypt your data.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Name of the schedule. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Defines when the schedule runs. Read more in Schedule types on EventBridge Scheduler.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>Timezone in which the scheduling expression is evaluated. Defaults to UTC. Example: Australia/Sydney.</summary>
    [JsonPropertyName("scheduleExpressionTimezone")]
    public string? ScheduleExpressionTimezone { get; set; }

    /// <summary>The date, in UTC, after which the schedule can begin invoking its target. Depending on the schedule's recurrence expression, invocations might occur on, or after, the start date you specify. EventBridge Scheduler ignores the start date for one-time schedules. Example: 2030-01-01T01:00:00Z.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>Specifies whether the schedule is enabled or disabled. One of: ENABLED (default), DISABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Configures the target of the schedule. Detailed below.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta1ScheduleStatusAtProviderTarget>? Target { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1ScheduleStatusConditions
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

/// <summary>ScheduleStatus defines the observed state of Schedule.</summary>
public partial class V1beta1ScheduleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ScheduleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ScheduleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Schedule is the Schema for the Schedules API. Provides an EventBridge Scheduler Schedule resource.</summary>
public partial class V1beta1Schedule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ScheduleSpec>, IStatus<V1beta1ScheduleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Schedule";
    public const string KubeGroup = "scheduler.aws.upbound.io";
    public const string KubePluralName = "schedules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ScheduleSpec defines the desired state of Schedule</summary>
    [JsonPropertyName("spec")]
    public V1beta1ScheduleSpec Spec { get; set; }

    /// <summary>ScheduleStatus defines the observed state of Schedule.</summary>
    [JsonPropertyName("status")]
    public V1beta1ScheduleStatus? Status { get; set; }
}