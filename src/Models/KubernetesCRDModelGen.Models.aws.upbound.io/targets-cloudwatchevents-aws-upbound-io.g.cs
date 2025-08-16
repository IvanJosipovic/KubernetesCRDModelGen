using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudwatchevents.aws.upbound.io;
/// <summary>Target is the Schema for the Targets API. Provides an EventBridge Target resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TargetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Target>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TargetList";
    public const string KubeGroup = "cloudwatchevents.aws.upbound.io";
    public const string KubePluralName = "targets";
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
    public IList<V1beta1Target> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderAppsyncTarget
{
    /// <summary>Contains the GraphQL mutation to be parsed and executed.</summary>
    [JsonPropertyName("graphqlOperation")]
    public string? GraphqlOperation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderBatchTarget
{
    /// <summary>The size of the array, if this is an array batch job. Valid values are integers between 2 and 10,000.</summary>
    [JsonPropertyName("arraySize")]
    public double? ArraySize { get; set; }

    /// <summary>The number of times to attempt to retry, if the job fails. Valid values are 1 to 10.</summary>
    [JsonPropertyName("jobAttempts")]
    public double? JobAttempts { get; set; }

    /// <summary>The ARN or name of the job definition to use if the event target is an AWS Batch job. This job definition must already exist.</summary>
    [JsonPropertyName("jobDefinition")]
    public string? JobDefinition { get; set; }

    /// <summary>The name to use for this execution of the job, if the target is an AWS Batch job.</summary>
    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderDeadLetterConfig
{
    /// <summary>- ARN of the SQS queue specified as the target for the dead-letter queue.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderEcsTargetCapacityProviderStrategy
{
    /// <summary>The base value designates how many tasks, at a minimum, to run on the specified capacity provider. Only one capacity provider in a capacity provider strategy can have a base defined. Defaults to 0.</summary>
    [JsonPropertyName("base")]
    public double? Base { get; set; }

    /// <summary>Short name of the capacity provider.</summary>
    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    /// <summary>The weight value designates the relative percentage of the total number of tasks launched that should use the specified capacity provider. The weight value is taken into consideration after the base value, if defined, is satisfied.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderEcsTargetNetworkConfiguration
{
    /// <summary>Assign a public IP address to the ENI (Fargate launch type only). Valid values are true or false. Defaults to false.</summary>
    [JsonPropertyName("assignPublicIp")]
    public bool? AssignPublicIp { get; set; }

    /// <summary>The security groups associated with the task or service. If you do not specify a security group, the default security group for the VPC is used.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The subnets associated with the task or service.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderEcsTargetOrderedPlacementStrategy
{
    /// <summary>The field to apply the placement strategy against. For the spread placement strategy, valid values are instanceId (or host, which has the same effect), or any platform or custom attribute that is applied to a container instance, such as attribute:ecs.availability-zone. For the binpack placement strategy, valid values are cpu and memory. For the random placement strategy, this field is not used. For more information, see Amazon ECS task placement strategies.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>Type of placement strategy. The only valid values at this time are binpack, random and spread.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderEcsTargetPlacementConstraint
{
    /// <summary>Cluster Query Language expression to apply to the constraint. Does not need to be specified for the distinctInstance type. For more information, see Cluster Query Language in the Amazon EC2 Container Service Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Type of constraint. The only valid values at this time are memberOf and distinctInstance.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderEcsTargetTaskDefinitionArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a TaskDefinition in ecs to populate taskDefinitionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderEcsTargetTaskDefinitionArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecForProviderEcsTargetTaskDefinitionArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderEcsTargetTaskDefinitionArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a TaskDefinition in ecs to populate taskDefinitionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderEcsTargetTaskDefinitionArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecForProviderEcsTargetTaskDefinitionArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderEcsTarget
{
    /// <summary>The capacity provider strategy to use for the task. If a capacity_provider_strategy specified, the launch_type parameter must be omitted. If no capacity_provider_strategy or launch_type is specified, the default capacity provider strategy for the cluster is used. Can be one or more. See below.</summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1beta1TargetSpecForProviderEcsTargetCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>Specifies whether to enable Amazon ECS managed tags for the task.</summary>
    [JsonPropertyName("enableEcsManagedTags")]
    public bool? EnableEcsManagedTags { get; set; }

    /// <summary>Whether or not to enable the execute command functionality for the containers in this task. If true, this enables execute command functionality on all containers in the task.</summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>Specifies an ECS task group for the task. The maximum length is 255 characters.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. Valid values include: EC2, EXTERNAL, or FARGATE.</summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>Use this if the ECS task uses the awsvpc network mode. This specifies the VPC subnets and security groups associated with the task, and whether a public IP address is to be used. Required if launch_type is FARGATE because the awsvpc mode is required for Fargate tasks.</summary>
    [JsonPropertyName("networkConfiguration")]
    public IList<V1beta1TargetSpecForProviderEcsTargetNetworkConfiguration>? NetworkConfiguration { get; set; }

    /// <summary>An array of placement strategy objects to use for the task. You can specify a maximum of five strategy rules per task.</summary>
    [JsonPropertyName("orderedPlacementStrategy")]
    public IList<V1beta1TargetSpecForProviderEcsTargetOrderedPlacementStrategy>? OrderedPlacementStrategy { get; set; }

    /// <summary>An array of placement constraint objects to use for the task. You can specify up to 10 constraints per task (including constraints in the task definition and those specified at runtime). See Below.</summary>
    [JsonPropertyName("placementConstraint")]
    public IList<V1beta1TargetSpecForProviderEcsTargetPlacementConstraint>? PlacementConstraint { get; set; }

    /// <summary>Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0. This is used only if LaunchType is FARGATE. For more information about valid platform versions, see AWS Fargate Platform Versions.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Specifies whether to propagate the tags from the task definition to the task. If no value is specified, the tags are not propagated. Tags can only be propagated to the task during task creation. The only valid value is: TASK_DEFINITION.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>A map of tags to assign to ecs resources.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The number of tasks to create based on the TaskDefinition. Defaults to 1.</summary>
    [JsonPropertyName("taskCount")]
    public double? TaskCount { get; set; }

    /// <summary>The ARN of the task definition to use if the event target is an Amazon ECS cluster.</summary>
    [JsonPropertyName("taskDefinitionArn")]
    public string? TaskDefinitionArn { get; set; }

    /// <summary>Reference to a TaskDefinition in ecs to populate taskDefinitionArn.</summary>
    [JsonPropertyName("taskDefinitionArnRef")]
    public V1beta1TargetSpecForProviderEcsTargetTaskDefinitionArnRef? TaskDefinitionArnRef { get; set; }

    /// <summary>Selector for a TaskDefinition in ecs to populate taskDefinitionArn.</summary>
    [JsonPropertyName("taskDefinitionArnSelector")]
    public V1beta1TargetSpecForProviderEcsTargetTaskDefinitionArnSelector? TaskDefinitionArnSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderEventBusNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bus in cloudwatchevents to populate eventBusName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderEventBusNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecForProviderEventBusNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderEventBusNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bus in cloudwatchevents to populate eventBusName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderEventBusNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecForProviderEventBusNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderHttpTarget
{
    /// <summary>Enables you to specify HTTP headers to add to the request.</summary>
    [JsonPropertyName("headerParameters")]
    public IDictionary<string, string>? HeaderParameters { get; set; }

    /// <summary>The list of values that correspond sequentially to any path variables in your endpoint ARN (for example arn:aws:execute-api:us-east-1:123456:myapi/*/POST/pets/*).</summary>
    [JsonPropertyName("pathParameterValues")]
    public IList<string>? PathParameterValues { get; set; }

    /// <summary>Represents keys/values of query string parameters that are appended to the invoked endpoint.</summary>
    [JsonPropertyName("queryStringParameters")]
    public IDictionary<string, string>? QueryStringParameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderInputTransformer
{
    /// <summary>Key value pairs specified in the form of JSONPath (for example, time = $.time)</summary>
    [JsonPropertyName("inputPaths")]
    public IDictionary<string, string>? InputPaths { get; set; }

    /// <summary>Template to customize data sent to the target. Must be valid JSON. To send a string value, the string value must include double quotes.g., "\"Your string goes here.\\nA new line.\""</summary>
    [JsonPropertyName("inputTemplate")]
    public string? InputTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderKinesisTarget
{
    /// <summary>The JSON path to be extracted from the event and used as the partition key.</summary>
    [JsonPropertyName("partitionKeyPath")]
    public string? PartitionKeyPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderRedshiftTarget
{
    /// <summary>The name of the database.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>The database user name.</summary>
    [JsonPropertyName("dbUser")]
    public string? DbUser { get; set; }

    /// <summary>The name or ARN of the secret that enables access to the database.</summary>
    [JsonPropertyName("secretsManagerArn")]
    public string? SecretsManagerArn { get; set; }

    /// <summary>The SQL statement text to run.</summary>
    [JsonPropertyName("sql")]
    public string? Sql { get; set; }

    /// <summary>The name of the SQL statement.</summary>
    [JsonPropertyName("statementName")]
    public string? StatementName { get; set; }

    /// <summary>Indicates whether to send an event back to EventBridge after the SQL statement runs.</summary>
    [JsonPropertyName("withEvent")]
    public bool? WithEvent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderRetryPolicy
{
    /// <summary>The age in seconds to continue to make retry attempts.</summary>
    [JsonPropertyName("maximumEventAgeInSeconds")]
    public double? MaximumEventAgeInSeconds { get; set; }

    /// <summary>maximum number of retry attempts to make before the request fails</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderRoleArnRefPolicy
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
public partial class V1beta1TargetSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderRoleArnSelectorPolicy
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
public partial class V1beta1TargetSpecForProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderRuleRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Rule in cloudwatchevents to populate rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderRuleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecForProviderRuleRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderRuleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Rule in cloudwatchevents to populate rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderRuleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecForProviderRuleSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderRunCommandTargets
{
    /// <summary>Can be either tag:tag-key or InstanceIds.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>If Key is tag:tag-key, Values is a list of tag values. If Key is InstanceIds, Values is a list of Amazon EC2 instance IDs.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderSagemakerPipelineTargetPipelineParameterList
{
    /// <summary>Name of parameter to start execution of a SageMaker AI Model Building Pipeline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of parameter to start execution of a SageMaker AI Model Building Pipeline.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderSagemakerPipelineTarget
{
    /// <summary>List of Parameter names and values for SageMaker AI Model Building Pipeline execution.</summary>
    [JsonPropertyName("pipelineParameterList")]
    public IList<V1beta1TargetSpecForProviderSagemakerPipelineTargetPipelineParameterList>? PipelineParameterList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProviderSqsTarget
{
    /// <summary>The FIFO message group ID to use as the target.</summary>
    [JsonPropertyName("messageGroupId")]
    public string? MessageGroupId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecForProvider
{
    /// <summary>Parameters used when you are using the rule to invoke an AppSync GraphQL API mutation. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("appsyncTarget")]
    public IList<V1beta1TargetSpecForProviderAppsyncTarget>? AppsyncTarget { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the target.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an Amazon Batch Job. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("batchTarget")]
    public IList<V1beta1TargetSpecForProviderBatchTarget>? BatchTarget { get; set; }

    /// <summary>Parameters used when you are providing a dead letter config. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public IList<V1beta1TargetSpecForProviderDeadLetterConfig>? DeadLetterConfig { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke Amazon ECS Task. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("ecsTarget")]
    public IList<V1beta1TargetSpecForProviderEcsTarget>? EcsTarget { get; set; }

    /// <summary>The name or ARN of the event bus to associate with the rule. If you omit this, the default event bus is used.</summary>
    [JsonPropertyName("eventBusName")]
    public string? EventBusName { get; set; }

    /// <summary>Reference to a Bus in cloudwatchevents to populate eventBusName.</summary>
    [JsonPropertyName("eventBusNameRef")]
    public V1beta1TargetSpecForProviderEventBusNameRef? EventBusNameRef { get; set; }

    /// <summary>Selector for a Bus in cloudwatchevents to populate eventBusName.</summary>
    [JsonPropertyName("eventBusNameSelector")]
    public V1beta1TargetSpecForProviderEventBusNameSelector? EventBusNameSelector { get; set; }

    /// <summary>Used to delete managed rules created by AWS. Defaults to false.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an API Gateway REST endpoint. Documented below. A maximum of 1 is allowed.</summary>
    [JsonPropertyName("httpTarget")]
    public IList<V1beta1TargetSpecForProviderHttpTarget>? HttpTarget { get; set; }

    /// <summary>Valid JSON text passed to the target. Conflicts with input_path and input_transformer.</summary>
    [JsonPropertyName("input")]
    public string? Input { get; set; }

    /// <summary>The value of the JSONPath that is used for extracting part of the matched event when passing it to the target. Conflicts with input and input_transformer.</summary>
    [JsonPropertyName("inputPath")]
    public string? InputPath { get; set; }

    /// <summary>Parameters used when you are providing a custom input to a target based on certain event data. Conflicts with input and input_path.</summary>
    [JsonPropertyName("inputTransformer")]
    public IList<V1beta1TargetSpecForProviderInputTransformer>? InputTransformer { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an Amazon Kinesis Stream. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("kinesisTarget")]
    public IList<V1beta1TargetSpecForProviderKinesisTarget>? KinesisTarget { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an Amazon Redshift Statement. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("redshiftTarget")]
    public IList<V1beta1TargetSpecForProviderRedshiftTarget>? RedshiftTarget { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Parameters used when you are providing retry policies. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1TargetSpecForProviderRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role to be used for this target when the rule is triggered. Required if ecs_target is used or target in arn is EC2 instance, Kinesis data stream, Step Functions state machine, or Event Bus in different account or region.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1TargetSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1TargetSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The name of the rule you want to add targets to.</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }

    /// <summary>Reference to a Rule in cloudwatchevents to populate rule.</summary>
    [JsonPropertyName("ruleRef")]
    public V1beta1TargetSpecForProviderRuleRef? RuleRef { get; set; }

    /// <summary>Selector for a Rule in cloudwatchevents to populate rule.</summary>
    [JsonPropertyName("ruleSelector")]
    public V1beta1TargetSpecForProviderRuleSelector? RuleSelector { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke Amazon EC2 Run Command. Documented below. A maximum of 5 are allowed.</summary>
    [JsonPropertyName("runCommandTargets")]
    public IList<V1beta1TargetSpecForProviderRunCommandTargets>? RunCommandTargets { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an Amazon SageMaker AI Pipeline. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("sagemakerPipelineTarget")]
    public IList<V1beta1TargetSpecForProviderSagemakerPipelineTarget>? SagemakerPipelineTarget { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an Amazon SQS Queue. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("sqsTarget")]
    public IList<V1beta1TargetSpecForProviderSqsTarget>? SqsTarget { get; set; }

    /// <summary>The unique target assignment ID. If missing, will generate a random, unique id.</summary>
    [JsonPropertyName("targetId")]
    public string? TargetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderAppsyncTarget
{
    /// <summary>Contains the GraphQL mutation to be parsed and executed.</summary>
    [JsonPropertyName("graphqlOperation")]
    public string? GraphqlOperation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderBatchTarget
{
    /// <summary>The size of the array, if this is an array batch job. Valid values are integers between 2 and 10,000.</summary>
    [JsonPropertyName("arraySize")]
    public double? ArraySize { get; set; }

    /// <summary>The number of times to attempt to retry, if the job fails. Valid values are 1 to 10.</summary>
    [JsonPropertyName("jobAttempts")]
    public double? JobAttempts { get; set; }

    /// <summary>The ARN or name of the job definition to use if the event target is an AWS Batch job. This job definition must already exist.</summary>
    [JsonPropertyName("jobDefinition")]
    public string? JobDefinition { get; set; }

    /// <summary>The name to use for this execution of the job, if the target is an AWS Batch job.</summary>
    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderDeadLetterConfig
{
    /// <summary>- ARN of the SQS queue specified as the target for the dead-letter queue.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderEcsTargetCapacityProviderStrategy
{
    /// <summary>The base value designates how many tasks, at a minimum, to run on the specified capacity provider. Only one capacity provider in a capacity provider strategy can have a base defined. Defaults to 0.</summary>
    [JsonPropertyName("base")]
    public double? Base { get; set; }

    /// <summary>Short name of the capacity provider.</summary>
    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    /// <summary>The weight value designates the relative percentage of the total number of tasks launched that should use the specified capacity provider. The weight value is taken into consideration after the base value, if defined, is satisfied.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderEcsTargetNetworkConfiguration
{
    /// <summary>Assign a public IP address to the ENI (Fargate launch type only). Valid values are true or false. Defaults to false.</summary>
    [JsonPropertyName("assignPublicIp")]
    public bool? AssignPublicIp { get; set; }

    /// <summary>The security groups associated with the task or service. If you do not specify a security group, the default security group for the VPC is used.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The subnets associated with the task or service.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderEcsTargetOrderedPlacementStrategy
{
    /// <summary>The field to apply the placement strategy against. For the spread placement strategy, valid values are instanceId (or host, which has the same effect), or any platform or custom attribute that is applied to a container instance, such as attribute:ecs.availability-zone. For the binpack placement strategy, valid values are cpu and memory. For the random placement strategy, this field is not used. For more information, see Amazon ECS task placement strategies.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>Type of placement strategy. The only valid values at this time are binpack, random and spread.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderEcsTargetPlacementConstraint
{
    /// <summary>Cluster Query Language expression to apply to the constraint. Does not need to be specified for the distinctInstance type. For more information, see Cluster Query Language in the Amazon EC2 Container Service Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Type of constraint. The only valid values at this time are memberOf and distinctInstance.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderEcsTargetTaskDefinitionArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a TaskDefinition in ecs to populate taskDefinitionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderEcsTargetTaskDefinitionArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecInitProviderEcsTargetTaskDefinitionArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderEcsTargetTaskDefinitionArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a TaskDefinition in ecs to populate taskDefinitionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderEcsTargetTaskDefinitionArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecInitProviderEcsTargetTaskDefinitionArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderEcsTarget
{
    /// <summary>The capacity provider strategy to use for the task. If a capacity_provider_strategy specified, the launch_type parameter must be omitted. If no capacity_provider_strategy or launch_type is specified, the default capacity provider strategy for the cluster is used. Can be one or more. See below.</summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1beta1TargetSpecInitProviderEcsTargetCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>Specifies whether to enable Amazon ECS managed tags for the task.</summary>
    [JsonPropertyName("enableEcsManagedTags")]
    public bool? EnableEcsManagedTags { get; set; }

    /// <summary>Whether or not to enable the execute command functionality for the containers in this task. If true, this enables execute command functionality on all containers in the task.</summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>Specifies an ECS task group for the task. The maximum length is 255 characters.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. Valid values include: EC2, EXTERNAL, or FARGATE.</summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>Use this if the ECS task uses the awsvpc network mode. This specifies the VPC subnets and security groups associated with the task, and whether a public IP address is to be used. Required if launch_type is FARGATE because the awsvpc mode is required for Fargate tasks.</summary>
    [JsonPropertyName("networkConfiguration")]
    public IList<V1beta1TargetSpecInitProviderEcsTargetNetworkConfiguration>? NetworkConfiguration { get; set; }

    /// <summary>An array of placement strategy objects to use for the task. You can specify a maximum of five strategy rules per task.</summary>
    [JsonPropertyName("orderedPlacementStrategy")]
    public IList<V1beta1TargetSpecInitProviderEcsTargetOrderedPlacementStrategy>? OrderedPlacementStrategy { get; set; }

    /// <summary>An array of placement constraint objects to use for the task. You can specify up to 10 constraints per task (including constraints in the task definition and those specified at runtime). See Below.</summary>
    [JsonPropertyName("placementConstraint")]
    public IList<V1beta1TargetSpecInitProviderEcsTargetPlacementConstraint>? PlacementConstraint { get; set; }

    /// <summary>Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0. This is used only if LaunchType is FARGATE. For more information about valid platform versions, see AWS Fargate Platform Versions.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Specifies whether to propagate the tags from the task definition to the task. If no value is specified, the tags are not propagated. Tags can only be propagated to the task during task creation. The only valid value is: TASK_DEFINITION.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>A map of tags to assign to ecs resources.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The number of tasks to create based on the TaskDefinition. Defaults to 1.</summary>
    [JsonPropertyName("taskCount")]
    public double? TaskCount { get; set; }

    /// <summary>The ARN of the task definition to use if the event target is an Amazon ECS cluster.</summary>
    [JsonPropertyName("taskDefinitionArn")]
    public string? TaskDefinitionArn { get; set; }

    /// <summary>Reference to a TaskDefinition in ecs to populate taskDefinitionArn.</summary>
    [JsonPropertyName("taskDefinitionArnRef")]
    public V1beta1TargetSpecInitProviderEcsTargetTaskDefinitionArnRef? TaskDefinitionArnRef { get; set; }

    /// <summary>Selector for a TaskDefinition in ecs to populate taskDefinitionArn.</summary>
    [JsonPropertyName("taskDefinitionArnSelector")]
    public V1beta1TargetSpecInitProviderEcsTargetTaskDefinitionArnSelector? TaskDefinitionArnSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderEventBusNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bus in cloudwatchevents to populate eventBusName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderEventBusNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecInitProviderEventBusNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderEventBusNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bus in cloudwatchevents to populate eventBusName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderEventBusNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecInitProviderEventBusNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderHttpTarget
{
    /// <summary>Enables you to specify HTTP headers to add to the request.</summary>
    [JsonPropertyName("headerParameters")]
    public IDictionary<string, string>? HeaderParameters { get; set; }

    /// <summary>The list of values that correspond sequentially to any path variables in your endpoint ARN (for example arn:aws:execute-api:us-east-1:123456:myapi/*/POST/pets/*).</summary>
    [JsonPropertyName("pathParameterValues")]
    public IList<string>? PathParameterValues { get; set; }

    /// <summary>Represents keys/values of query string parameters that are appended to the invoked endpoint.</summary>
    [JsonPropertyName("queryStringParameters")]
    public IDictionary<string, string>? QueryStringParameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderInputTransformer
{
    /// <summary>Key value pairs specified in the form of JSONPath (for example, time = $.time)</summary>
    [JsonPropertyName("inputPaths")]
    public IDictionary<string, string>? InputPaths { get; set; }

    /// <summary>Template to customize data sent to the target. Must be valid JSON. To send a string value, the string value must include double quotes.g., "\"Your string goes here.\\nA new line.\""</summary>
    [JsonPropertyName("inputTemplate")]
    public string? InputTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderKinesisTarget
{
    /// <summary>The JSON path to be extracted from the event and used as the partition key.</summary>
    [JsonPropertyName("partitionKeyPath")]
    public string? PartitionKeyPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderRedshiftTarget
{
    /// <summary>The name of the database.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>The database user name.</summary>
    [JsonPropertyName("dbUser")]
    public string? DbUser { get; set; }

    /// <summary>The name or ARN of the secret that enables access to the database.</summary>
    [JsonPropertyName("secretsManagerArn")]
    public string? SecretsManagerArn { get; set; }

    /// <summary>The SQL statement text to run.</summary>
    [JsonPropertyName("sql")]
    public string? Sql { get; set; }

    /// <summary>The name of the SQL statement.</summary>
    [JsonPropertyName("statementName")]
    public string? StatementName { get; set; }

    /// <summary>Indicates whether to send an event back to EventBridge after the SQL statement runs.</summary>
    [JsonPropertyName("withEvent")]
    public bool? WithEvent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderRetryPolicy
{
    /// <summary>The age in seconds to continue to make retry attempts.</summary>
    [JsonPropertyName("maximumEventAgeInSeconds")]
    public double? MaximumEventAgeInSeconds { get; set; }

    /// <summary>maximum number of retry attempts to make before the request fails</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderRoleArnRefPolicy
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
public partial class V1beta1TargetSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderRoleArnSelectorPolicy
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
public partial class V1beta1TargetSpecInitProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderRuleRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Rule in cloudwatchevents to populate rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderRuleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecInitProviderRuleRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderRuleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Rule in cloudwatchevents to populate rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderRuleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecInitProviderRuleSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderRunCommandTargets
{
    /// <summary>Can be either tag:tag-key or InstanceIds.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>If Key is tag:tag-key, Values is a list of tag values. If Key is InstanceIds, Values is a list of Amazon EC2 instance IDs.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderSagemakerPipelineTargetPipelineParameterList
{
    /// <summary>Name of parameter to start execution of a SageMaker AI Model Building Pipeline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of parameter to start execution of a SageMaker AI Model Building Pipeline.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderSagemakerPipelineTarget
{
    /// <summary>List of Parameter names and values for SageMaker AI Model Building Pipeline execution.</summary>
    [JsonPropertyName("pipelineParameterList")]
    public IList<V1beta1TargetSpecInitProviderSagemakerPipelineTargetPipelineParameterList>? PipelineParameterList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProviderSqsTarget
{
    /// <summary>The FIFO message group ID to use as the target.</summary>
    [JsonPropertyName("messageGroupId")]
    public string? MessageGroupId { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecInitProvider
{
    /// <summary>Parameters used when you are using the rule to invoke an AppSync GraphQL API mutation. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("appsyncTarget")]
    public IList<V1beta1TargetSpecInitProviderAppsyncTarget>? AppsyncTarget { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the target.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an Amazon Batch Job. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("batchTarget")]
    public IList<V1beta1TargetSpecInitProviderBatchTarget>? BatchTarget { get; set; }

    /// <summary>Parameters used when you are providing a dead letter config. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public IList<V1beta1TargetSpecInitProviderDeadLetterConfig>? DeadLetterConfig { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke Amazon ECS Task. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("ecsTarget")]
    public IList<V1beta1TargetSpecInitProviderEcsTarget>? EcsTarget { get; set; }

    /// <summary>The name or ARN of the event bus to associate with the rule. If you omit this, the default event bus is used.</summary>
    [JsonPropertyName("eventBusName")]
    public string? EventBusName { get; set; }

    /// <summary>Reference to a Bus in cloudwatchevents to populate eventBusName.</summary>
    [JsonPropertyName("eventBusNameRef")]
    public V1beta1TargetSpecInitProviderEventBusNameRef? EventBusNameRef { get; set; }

    /// <summary>Selector for a Bus in cloudwatchevents to populate eventBusName.</summary>
    [JsonPropertyName("eventBusNameSelector")]
    public V1beta1TargetSpecInitProviderEventBusNameSelector? EventBusNameSelector { get; set; }

    /// <summary>Used to delete managed rules created by AWS. Defaults to false.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an API Gateway REST endpoint. Documented below. A maximum of 1 is allowed.</summary>
    [JsonPropertyName("httpTarget")]
    public IList<V1beta1TargetSpecInitProviderHttpTarget>? HttpTarget { get; set; }

    /// <summary>Valid JSON text passed to the target. Conflicts with input_path and input_transformer.</summary>
    [JsonPropertyName("input")]
    public string? Input { get; set; }

    /// <summary>The value of the JSONPath that is used for extracting part of the matched event when passing it to the target. Conflicts with input and input_transformer.</summary>
    [JsonPropertyName("inputPath")]
    public string? InputPath { get; set; }

    /// <summary>Parameters used when you are providing a custom input to a target based on certain event data. Conflicts with input and input_path.</summary>
    [JsonPropertyName("inputTransformer")]
    public IList<V1beta1TargetSpecInitProviderInputTransformer>? InputTransformer { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an Amazon Kinesis Stream. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("kinesisTarget")]
    public IList<V1beta1TargetSpecInitProviderKinesisTarget>? KinesisTarget { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an Amazon Redshift Statement. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("redshiftTarget")]
    public IList<V1beta1TargetSpecInitProviderRedshiftTarget>? RedshiftTarget { get; set; }

    /// <summary>Parameters used when you are providing retry policies. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1TargetSpecInitProviderRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role to be used for this target when the rule is triggered. Required if ecs_target is used or target in arn is EC2 instance, Kinesis data stream, Step Functions state machine, or Event Bus in different account or region.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1TargetSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1TargetSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>The name of the rule you want to add targets to.</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }

    /// <summary>Reference to a Rule in cloudwatchevents to populate rule.</summary>
    [JsonPropertyName("ruleRef")]
    public V1beta1TargetSpecInitProviderRuleRef? RuleRef { get; set; }

    /// <summary>Selector for a Rule in cloudwatchevents to populate rule.</summary>
    [JsonPropertyName("ruleSelector")]
    public V1beta1TargetSpecInitProviderRuleSelector? RuleSelector { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke Amazon EC2 Run Command. Documented below. A maximum of 5 are allowed.</summary>
    [JsonPropertyName("runCommandTargets")]
    public IList<V1beta1TargetSpecInitProviderRunCommandTargets>? RunCommandTargets { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an Amazon SageMaker AI Pipeline. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("sagemakerPipelineTarget")]
    public IList<V1beta1TargetSpecInitProviderSagemakerPipelineTarget>? SagemakerPipelineTarget { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an Amazon SQS Queue. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("sqsTarget")]
    public IList<V1beta1TargetSpecInitProviderSqsTarget>? SqsTarget { get; set; }

    /// <summary>The unique target assignment ID. If missing, will generate a random, unique id.</summary>
    [JsonPropertyName("targetId")]
    public string? TargetId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecProviderConfigRefPolicy
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
public partial class V1beta1TargetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TargetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>TargetSpec defines the desired state of Target</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TargetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TargetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TargetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TargetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderAppsyncTarget
{
    /// <summary>Contains the GraphQL mutation to be parsed and executed.</summary>
    [JsonPropertyName("graphqlOperation")]
    public string? GraphqlOperation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderBatchTarget
{
    /// <summary>The size of the array, if this is an array batch job. Valid values are integers between 2 and 10,000.</summary>
    [JsonPropertyName("arraySize")]
    public double? ArraySize { get; set; }

    /// <summary>The number of times to attempt to retry, if the job fails. Valid values are 1 to 10.</summary>
    [JsonPropertyName("jobAttempts")]
    public double? JobAttempts { get; set; }

    /// <summary>The ARN or name of the job definition to use if the event target is an AWS Batch job. This job definition must already exist.</summary>
    [JsonPropertyName("jobDefinition")]
    public string? JobDefinition { get; set; }

    /// <summary>The name to use for this execution of the job, if the target is an AWS Batch job.</summary>
    [JsonPropertyName("jobName")]
    public string? JobName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderDeadLetterConfig
{
    /// <summary>- ARN of the SQS queue specified as the target for the dead-letter queue.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderEcsTargetCapacityProviderStrategy
{
    /// <summary>The base value designates how many tasks, at a minimum, to run on the specified capacity provider. Only one capacity provider in a capacity provider strategy can have a base defined. Defaults to 0.</summary>
    [JsonPropertyName("base")]
    public double? Base { get; set; }

    /// <summary>Short name of the capacity provider.</summary>
    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    /// <summary>The weight value designates the relative percentage of the total number of tasks launched that should use the specified capacity provider. The weight value is taken into consideration after the base value, if defined, is satisfied.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderEcsTargetNetworkConfiguration
{
    /// <summary>Assign a public IP address to the ENI (Fargate launch type only). Valid values are true or false. Defaults to false.</summary>
    [JsonPropertyName("assignPublicIp")]
    public bool? AssignPublicIp { get; set; }

    /// <summary>The security groups associated with the task or service. If you do not specify a security group, the default security group for the VPC is used.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The subnets associated with the task or service.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderEcsTargetOrderedPlacementStrategy
{
    /// <summary>The field to apply the placement strategy against. For the spread placement strategy, valid values are instanceId (or host, which has the same effect), or any platform or custom attribute that is applied to a container instance, such as attribute:ecs.availability-zone. For the binpack placement strategy, valid values are cpu and memory. For the random placement strategy, this field is not used. For more information, see Amazon ECS task placement strategies.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>Type of placement strategy. The only valid values at this time are binpack, random and spread.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderEcsTargetPlacementConstraint
{
    /// <summary>Cluster Query Language expression to apply to the constraint. Does not need to be specified for the distinctInstance type. For more information, see Cluster Query Language in the Amazon EC2 Container Service Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Type of constraint. The only valid values at this time are memberOf and distinctInstance.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderEcsTarget
{
    /// <summary>The capacity provider strategy to use for the task. If a capacity_provider_strategy specified, the launch_type parameter must be omitted. If no capacity_provider_strategy or launch_type is specified, the default capacity provider strategy for the cluster is used. Can be one or more. See below.</summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1beta1TargetStatusAtProviderEcsTargetCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>Specifies whether to enable Amazon ECS managed tags for the task.</summary>
    [JsonPropertyName("enableEcsManagedTags")]
    public bool? EnableEcsManagedTags { get; set; }

    /// <summary>Whether or not to enable the execute command functionality for the containers in this task. If true, this enables execute command functionality on all containers in the task.</summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>Specifies an ECS task group for the task. The maximum length is 255 characters.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. Valid values include: EC2, EXTERNAL, or FARGATE.</summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>Use this if the ECS task uses the awsvpc network mode. This specifies the VPC subnets and security groups associated with the task, and whether a public IP address is to be used. Required if launch_type is FARGATE because the awsvpc mode is required for Fargate tasks.</summary>
    [JsonPropertyName("networkConfiguration")]
    public IList<V1beta1TargetStatusAtProviderEcsTargetNetworkConfiguration>? NetworkConfiguration { get; set; }

    /// <summary>An array of placement strategy objects to use for the task. You can specify a maximum of five strategy rules per task.</summary>
    [JsonPropertyName("orderedPlacementStrategy")]
    public IList<V1beta1TargetStatusAtProviderEcsTargetOrderedPlacementStrategy>? OrderedPlacementStrategy { get; set; }

    /// <summary>An array of placement constraint objects to use for the task. You can specify up to 10 constraints per task (including constraints in the task definition and those specified at runtime). See Below.</summary>
    [JsonPropertyName("placementConstraint")]
    public IList<V1beta1TargetStatusAtProviderEcsTargetPlacementConstraint>? PlacementConstraint { get; set; }

    /// <summary>Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0. This is used only if LaunchType is FARGATE. For more information about valid platform versions, see AWS Fargate Platform Versions.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Specifies whether to propagate the tags from the task definition to the task. If no value is specified, the tags are not propagated. Tags can only be propagated to the task during task creation. The only valid value is: TASK_DEFINITION.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>A map of tags to assign to ecs resources.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The number of tasks to create based on the TaskDefinition. Defaults to 1.</summary>
    [JsonPropertyName("taskCount")]
    public double? TaskCount { get; set; }

    /// <summary>The ARN of the task definition to use if the event target is an Amazon ECS cluster.</summary>
    [JsonPropertyName("taskDefinitionArn")]
    public string? TaskDefinitionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderHttpTarget
{
    /// <summary>Enables you to specify HTTP headers to add to the request.</summary>
    [JsonPropertyName("headerParameters")]
    public IDictionary<string, string>? HeaderParameters { get; set; }

    /// <summary>The list of values that correspond sequentially to any path variables in your endpoint ARN (for example arn:aws:execute-api:us-east-1:123456:myapi/*/POST/pets/*).</summary>
    [JsonPropertyName("pathParameterValues")]
    public IList<string>? PathParameterValues { get; set; }

    /// <summary>Represents keys/values of query string parameters that are appended to the invoked endpoint.</summary>
    [JsonPropertyName("queryStringParameters")]
    public IDictionary<string, string>? QueryStringParameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderInputTransformer
{
    /// <summary>Key value pairs specified in the form of JSONPath (for example, time = $.time)</summary>
    [JsonPropertyName("inputPaths")]
    public IDictionary<string, string>? InputPaths { get; set; }

    /// <summary>Template to customize data sent to the target. Must be valid JSON. To send a string value, the string value must include double quotes.g., "\"Your string goes here.\\nA new line.\""</summary>
    [JsonPropertyName("inputTemplate")]
    public string? InputTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderKinesisTarget
{
    /// <summary>The JSON path to be extracted from the event and used as the partition key.</summary>
    [JsonPropertyName("partitionKeyPath")]
    public string? PartitionKeyPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderRedshiftTarget
{
    /// <summary>The name of the database.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>The database user name.</summary>
    [JsonPropertyName("dbUser")]
    public string? DbUser { get; set; }

    /// <summary>The name or ARN of the secret that enables access to the database.</summary>
    [JsonPropertyName("secretsManagerArn")]
    public string? SecretsManagerArn { get; set; }

    /// <summary>The SQL statement text to run.</summary>
    [JsonPropertyName("sql")]
    public string? Sql { get; set; }

    /// <summary>The name of the SQL statement.</summary>
    [JsonPropertyName("statementName")]
    public string? StatementName { get; set; }

    /// <summary>Indicates whether to send an event back to EventBridge after the SQL statement runs.</summary>
    [JsonPropertyName("withEvent")]
    public bool? WithEvent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderRetryPolicy
{
    /// <summary>The age in seconds to continue to make retry attempts.</summary>
    [JsonPropertyName("maximumEventAgeInSeconds")]
    public double? MaximumEventAgeInSeconds { get; set; }

    /// <summary>maximum number of retry attempts to make before the request fails</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderRunCommandTargets
{
    /// <summary>Can be either tag:tag-key or InstanceIds.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>If Key is tag:tag-key, Values is a list of tag values. If Key is InstanceIds, Values is a list of Amazon EC2 instance IDs.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderSagemakerPipelineTargetPipelineParameterList
{
    /// <summary>Name of parameter to start execution of a SageMaker AI Model Building Pipeline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of parameter to start execution of a SageMaker AI Model Building Pipeline.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderSagemakerPipelineTarget
{
    /// <summary>List of Parameter names and values for SageMaker AI Model Building Pipeline execution.</summary>
    [JsonPropertyName("pipelineParameterList")]
    public IList<V1beta1TargetStatusAtProviderSagemakerPipelineTargetPipelineParameterList>? PipelineParameterList { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProviderSqsTarget
{
    /// <summary>The FIFO message group ID to use as the target.</summary>
    [JsonPropertyName("messageGroupId")]
    public string? MessageGroupId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusAtProvider
{
    /// <summary>Parameters used when you are using the rule to invoke an AppSync GraphQL API mutation. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("appsyncTarget")]
    public IList<V1beta1TargetStatusAtProviderAppsyncTarget>? AppsyncTarget { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the target.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an Amazon Batch Job. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("batchTarget")]
    public IList<V1beta1TargetStatusAtProviderBatchTarget>? BatchTarget { get; set; }

    /// <summary>Parameters used when you are providing a dead letter config. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public IList<V1beta1TargetStatusAtProviderDeadLetterConfig>? DeadLetterConfig { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke Amazon ECS Task. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("ecsTarget")]
    public IList<V1beta1TargetStatusAtProviderEcsTarget>? EcsTarget { get; set; }

    /// <summary>The name or ARN of the event bus to associate with the rule. If you omit this, the default event bus is used.</summary>
    [JsonPropertyName("eventBusName")]
    public string? EventBusName { get; set; }

    /// <summary>Used to delete managed rules created by AWS. Defaults to false.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an API Gateway REST endpoint. Documented below. A maximum of 1 is allowed.</summary>
    [JsonPropertyName("httpTarget")]
    public IList<V1beta1TargetStatusAtProviderHttpTarget>? HttpTarget { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Valid JSON text passed to the target. Conflicts with input_path and input_transformer.</summary>
    [JsonPropertyName("input")]
    public string? Input { get; set; }

    /// <summary>The value of the JSONPath that is used for extracting part of the matched event when passing it to the target. Conflicts with input and input_transformer.</summary>
    [JsonPropertyName("inputPath")]
    public string? InputPath { get; set; }

    /// <summary>Parameters used when you are providing a custom input to a target based on certain event data. Conflicts with input and input_path.</summary>
    [JsonPropertyName("inputTransformer")]
    public IList<V1beta1TargetStatusAtProviderInputTransformer>? InputTransformer { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an Amazon Kinesis Stream. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("kinesisTarget")]
    public IList<V1beta1TargetStatusAtProviderKinesisTarget>? KinesisTarget { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an Amazon Redshift Statement. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("redshiftTarget")]
    public IList<V1beta1TargetStatusAtProviderRedshiftTarget>? RedshiftTarget { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Parameters used when you are providing retry policies. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("retryPolicy")]
    public IList<V1beta1TargetStatusAtProviderRetryPolicy>? RetryPolicy { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role to be used for this target when the rule is triggered. Required if ecs_target is used or target in arn is EC2 instance, Kinesis data stream, Step Functions state machine, or Event Bus in different account or region.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The name of the rule you want to add targets to.</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke Amazon EC2 Run Command. Documented below. A maximum of 5 are allowed.</summary>
    [JsonPropertyName("runCommandTargets")]
    public IList<V1beta1TargetStatusAtProviderRunCommandTargets>? RunCommandTargets { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an Amazon SageMaker AI Pipeline. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("sagemakerPipelineTarget")]
    public IList<V1beta1TargetStatusAtProviderSagemakerPipelineTarget>? SagemakerPipelineTarget { get; set; }

    /// <summary>Parameters used when you are using the rule to invoke an Amazon SQS Queue. Documented below. A maximum of 1 are allowed.</summary>
    [JsonPropertyName("sqsTarget")]
    public IList<V1beta1TargetStatusAtProviderSqsTarget>? SqsTarget { get; set; }

    /// <summary>The unique target assignment ID. If missing, will generate a random, unique id.</summary>
    [JsonPropertyName("targetId")]
    public string? TargetId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatusConditions
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

/// <summary>TargetStatus defines the observed state of Target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TargetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TargetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TargetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Target is the Schema for the Targets API. Provides an EventBridge Target resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Target : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TargetSpec>, IStatus<V1beta1TargetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Target";
    public const string KubeGroup = "cloudwatchevents.aws.upbound.io";
    public const string KubePluralName = "targets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TargetSpec defines the desired state of Target</summary>
    [JsonPropertyName("spec")]
    public V1beta1TargetSpec Spec { get; set; }

    /// <summary>TargetStatus defines the observed state of Target.</summary>
    [JsonPropertyName("status")]
    public V1beta1TargetStatus? Status { get; set; }
}