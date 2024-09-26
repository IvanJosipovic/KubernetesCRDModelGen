using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.fis.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecForProviderActionParameter
{
    /// <summary>Parameter name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecForProviderActionTarget
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Target name, referencing a corresponding target.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecForProviderAction
{
    /// <summary>ID of the action. To find out what actions are supported see AWS FIS actions reference.</summary>
    [JsonPropertyName("actionId")]
    public string? ActionId { get; set; }

    /// <summary>Description of the action.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Friendly name of the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameter(s) for the action, if applicable. See below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1ExperimentTemplateSpecForProviderActionParameter>? Parameter { get; set; }

    /// <summary>Set of action names that must complete before this action can be executed.</summary>
    [JsonPropertyName("startAfter")]
    public IList<string>? StartAfter { get; set; }

    /// <summary>Action's target, if applicable. See below.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta1ExperimentTemplateSpecForProviderActionTarget>? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecForProviderLogConfigurationCloudwatchLogsConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the destination Amazon CloudWatch Logs log group.</summary>
    [JsonPropertyName("logGroupArn")]
    public string? LogGroupArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecForProviderLogConfigurationS3Configuration
{
    /// <summary>The name of the destination bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The bucket prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecForProviderLogConfiguration
{
    /// <summary>The configuration for experiment logging to Amazon CloudWatch Logs. See below.</summary>
    [JsonPropertyName("cloudwatchLogsConfiguration")]
    public IList<V1beta1ExperimentTemplateSpecForProviderLogConfigurationCloudwatchLogsConfiguration>? CloudwatchLogsConfiguration { get; set; }

    /// <summary>The schema version. See documentation for the list of schema versions.</summary>
    [JsonPropertyName("logSchemaVersion")]
    public double? LogSchemaVersion { get; set; }

    /// <summary>The configuration for experiment logging to Amazon S3. See below.</summary>
    [JsonPropertyName("s3Configuration")]
    public IList<V1beta1ExperimentTemplateSpecForProviderLogConfigurationS3Configuration>? S3Configuration { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecForProviderRoleArnRefPolicy
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
public partial class V1beta1ExperimentTemplateSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExperimentTemplateSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecForProviderRoleArnSelectorPolicy
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
public partial class V1beta1ExperimentTemplateSpecForProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExperimentTemplateSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecForProviderStopCondition
{
    /// <summary>Source of the condition. One of none, aws:cloudwatch:alarm.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>ARN of the CloudWatch alarm. Required if the source is a CloudWatch alarm.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecForProviderTargetFilter
{
    /// <summary>Attribute path for the filter.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Set of attribute values for the filter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecForProviderTargetResourceTag
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecForProviderTarget
{
    /// <summary>Filter(s) for the target. Filters can be used to select resources based on specific attributes returned by the respective describe action of the resource type. For more information, see Targets for AWS FIS. See below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1ExperimentTemplateSpecForProviderTargetFilter>? Filter { get; set; }

    /// <summary>Friendly name given to the target.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource type parameters.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Set of ARNs of the resources to target with an action. Conflicts with resource_tag.</summary>
    [JsonPropertyName("resourceArns")]
    public IList<string>? ResourceArns { get; set; }

    /// <summary>Tag(s) the resources need to have to be considered a valid target for an action. Conflicts with resource_arns. See below.</summary>
    [JsonPropertyName("resourceTag")]
    public IList<V1beta1ExperimentTemplateSpecForProviderTargetResourceTag>? ResourceTag { get; set; }

    /// <summary>AWS resource type. The resource type must be supported for the specified action. To find out what resource types are supported, see Targets for AWS FIS.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Scopes the identified resources. Valid values are ALL (all identified resources), COUNT(n) (randomly select n of the identified resources), PERCENT(n) (randomly select n percent of the identified resources).</summary>
    [JsonPropertyName("selectionMode")]
    public string? SelectionMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecForProvider
{
    /// <summary>Action to be performed during an experiment. See below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1ExperimentTemplateSpecForProviderAction>? Action { get; set; }

    /// <summary>Description for the experiment template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The configuration for experiment logging. See below.</summary>
    [JsonPropertyName("logConfiguration")]
    public IList<V1beta1ExperimentTemplateSpecForProviderLogConfiguration>? LogConfiguration { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>ARN of an IAM role that grants the AWS FIS service permission to perform service actions on your behalf.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ExperimentTemplateSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ExperimentTemplateSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>When an ongoing experiment should be stopped. See below.</summary>
    [JsonPropertyName("stopCondition")]
    public IList<V1beta1ExperimentTemplateSpecForProviderStopCondition>? StopCondition { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Target of an action. See below.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta1ExperimentTemplateSpecForProviderTarget>? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecInitProviderActionParameter
{
    /// <summary>Parameter name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecInitProviderActionTarget
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Target name, referencing a corresponding target.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecInitProviderAction
{
    /// <summary>ID of the action. To find out what actions are supported see AWS FIS actions reference.</summary>
    [JsonPropertyName("actionId")]
    public string? ActionId { get; set; }

    /// <summary>Description of the action.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Friendly name of the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameter(s) for the action, if applicable. See below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1ExperimentTemplateSpecInitProviderActionParameter>? Parameter { get; set; }

    /// <summary>Set of action names that must complete before this action can be executed.</summary>
    [JsonPropertyName("startAfter")]
    public IList<string>? StartAfter { get; set; }

    /// <summary>Action's target, if applicable. See below.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta1ExperimentTemplateSpecInitProviderActionTarget>? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecInitProviderLogConfigurationCloudwatchLogsConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the destination Amazon CloudWatch Logs log group.</summary>
    [JsonPropertyName("logGroupArn")]
    public string? LogGroupArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecInitProviderLogConfigurationS3Configuration
{
    /// <summary>The name of the destination bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The bucket prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecInitProviderLogConfiguration
{
    /// <summary>The configuration for experiment logging to Amazon CloudWatch Logs. See below.</summary>
    [JsonPropertyName("cloudwatchLogsConfiguration")]
    public IList<V1beta1ExperimentTemplateSpecInitProviderLogConfigurationCloudwatchLogsConfiguration>? CloudwatchLogsConfiguration { get; set; }

    /// <summary>The schema version. See documentation for the list of schema versions.</summary>
    [JsonPropertyName("logSchemaVersion")]
    public double? LogSchemaVersion { get; set; }

    /// <summary>The configuration for experiment logging to Amazon S3. See below.</summary>
    [JsonPropertyName("s3Configuration")]
    public IList<V1beta1ExperimentTemplateSpecInitProviderLogConfigurationS3Configuration>? S3Configuration { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecInitProviderRoleArnRefPolicy
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
public partial class V1beta1ExperimentTemplateSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExperimentTemplateSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecInitProviderRoleArnSelectorPolicy
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
public partial class V1beta1ExperimentTemplateSpecInitProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExperimentTemplateSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecInitProviderStopCondition
{
    /// <summary>Source of the condition. One of none, aws:cloudwatch:alarm.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>ARN of the CloudWatch alarm. Required if the source is a CloudWatch alarm.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecInitProviderTargetFilter
{
    /// <summary>Attribute path for the filter.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Set of attribute values for the filter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecInitProviderTargetResourceTag
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecInitProviderTarget
{
    /// <summary>Filter(s) for the target. Filters can be used to select resources based on specific attributes returned by the respective describe action of the resource type. For more information, see Targets for AWS FIS. See below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1ExperimentTemplateSpecInitProviderTargetFilter>? Filter { get; set; }

    /// <summary>Friendly name given to the target.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource type parameters.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Set of ARNs of the resources to target with an action. Conflicts with resource_tag.</summary>
    [JsonPropertyName("resourceArns")]
    public IList<string>? ResourceArns { get; set; }

    /// <summary>Tag(s) the resources need to have to be considered a valid target for an action. Conflicts with resource_arns. See below.</summary>
    [JsonPropertyName("resourceTag")]
    public IList<V1beta1ExperimentTemplateSpecInitProviderTargetResourceTag>? ResourceTag { get; set; }

    /// <summary>AWS resource type. The resource type must be supported for the specified action. To find out what resource types are supported, see Targets for AWS FIS.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Scopes the identified resources. Valid values are ALL (all identified resources), COUNT(n) (randomly select n of the identified resources), PERCENT(n) (randomly select n percent of the identified resources).</summary>
    [JsonPropertyName("selectionMode")]
    public string? SelectionMode { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecInitProvider
{
    /// <summary>Action to be performed during an experiment. See below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1ExperimentTemplateSpecInitProviderAction>? Action { get; set; }

    /// <summary>Description for the experiment template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The configuration for experiment logging. See below.</summary>
    [JsonPropertyName("logConfiguration")]
    public IList<V1beta1ExperimentTemplateSpecInitProviderLogConfiguration>? LogConfiguration { get; set; }

    /// <summary>ARN of an IAM role that grants the AWS FIS service permission to perform service actions on your behalf.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ExperimentTemplateSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ExperimentTemplateSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>When an ongoing experiment should be stopped. See below.</summary>
    [JsonPropertyName("stopCondition")]
    public IList<V1beta1ExperimentTemplateSpecInitProviderStopCondition>? StopCondition { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Target of an action. See below.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta1ExperimentTemplateSpecInitProviderTarget>? Target { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecProviderConfigRefPolicy
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
public partial class V1beta1ExperimentTemplateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExperimentTemplateSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1ExperimentTemplateSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExperimentTemplateSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ExperimentTemplateSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ExperimentTemplateSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ExperimentTemplateSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ExperimentTemplateSpec defines the desired state of ExperimentTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ExperimentTemplateSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ExperimentTemplateSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ExperimentTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ExperimentTemplateSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ExperimentTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateStatusAtProviderActionParameter
{
    /// <summary>Parameter name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateStatusAtProviderActionTarget
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Target name, referencing a corresponding target.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateStatusAtProviderAction
{
    /// <summary>ID of the action. To find out what actions are supported see AWS FIS actions reference.</summary>
    [JsonPropertyName("actionId")]
    public string? ActionId { get; set; }

    /// <summary>Description of the action.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Friendly name of the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameter(s) for the action, if applicable. See below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1ExperimentTemplateStatusAtProviderActionParameter>? Parameter { get; set; }

    /// <summary>Set of action names that must complete before this action can be executed.</summary>
    [JsonPropertyName("startAfter")]
    public IList<string>? StartAfter { get; set; }

    /// <summary>Action's target, if applicable. See below.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta1ExperimentTemplateStatusAtProviderActionTarget>? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateStatusAtProviderLogConfigurationCloudwatchLogsConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the destination Amazon CloudWatch Logs log group.</summary>
    [JsonPropertyName("logGroupArn")]
    public string? LogGroupArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateStatusAtProviderLogConfigurationS3Configuration
{
    /// <summary>The name of the destination bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The bucket prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateStatusAtProviderLogConfiguration
{
    /// <summary>The configuration for experiment logging to Amazon CloudWatch Logs. See below.</summary>
    [JsonPropertyName("cloudwatchLogsConfiguration")]
    public IList<V1beta1ExperimentTemplateStatusAtProviderLogConfigurationCloudwatchLogsConfiguration>? CloudwatchLogsConfiguration { get; set; }

    /// <summary>The schema version. See documentation for the list of schema versions.</summary>
    [JsonPropertyName("logSchemaVersion")]
    public double? LogSchemaVersion { get; set; }

    /// <summary>The configuration for experiment logging to Amazon S3. See below.</summary>
    [JsonPropertyName("s3Configuration")]
    public IList<V1beta1ExperimentTemplateStatusAtProviderLogConfigurationS3Configuration>? S3Configuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateStatusAtProviderStopCondition
{
    /// <summary>Source of the condition. One of none, aws:cloudwatch:alarm.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>ARN of the CloudWatch alarm. Required if the source is a CloudWatch alarm.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateStatusAtProviderTargetFilter
{
    /// <summary>Attribute path for the filter.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Set of attribute values for the filter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateStatusAtProviderTargetResourceTag
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateStatusAtProviderTarget
{
    /// <summary>Filter(s) for the target. Filters can be used to select resources based on specific attributes returned by the respective describe action of the resource type. For more information, see Targets for AWS FIS. See below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1ExperimentTemplateStatusAtProviderTargetFilter>? Filter { get; set; }

    /// <summary>Friendly name given to the target.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource type parameters.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Set of ARNs of the resources to target with an action. Conflicts with resource_tag.</summary>
    [JsonPropertyName("resourceArns")]
    public IList<string>? ResourceArns { get; set; }

    /// <summary>Tag(s) the resources need to have to be considered a valid target for an action. Conflicts with resource_arns. See below.</summary>
    [JsonPropertyName("resourceTag")]
    public IList<V1beta1ExperimentTemplateStatusAtProviderTargetResourceTag>? ResourceTag { get; set; }

    /// <summary>AWS resource type. The resource type must be supported for the specified action. To find out what resource types are supported, see Targets for AWS FIS.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Scopes the identified resources. Valid values are ALL (all identified resources), COUNT(n) (randomly select n of the identified resources), PERCENT(n) (randomly select n percent of the identified resources).</summary>
    [JsonPropertyName("selectionMode")]
    public string? SelectionMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateStatusAtProvider
{
    /// <summary>Action to be performed during an experiment. See below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1ExperimentTemplateStatusAtProviderAction>? Action { get; set; }

    /// <summary>Description for the experiment template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Experiment Template ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The configuration for experiment logging. See below.</summary>
    [JsonPropertyName("logConfiguration")]
    public IList<V1beta1ExperimentTemplateStatusAtProviderLogConfiguration>? LogConfiguration { get; set; }

    /// <summary>ARN of an IAM role that grants the AWS FIS service permission to perform service actions on your behalf.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>When an ongoing experiment should be stopped. See below.</summary>
    [JsonPropertyName("stopCondition")]
    public IList<V1beta1ExperimentTemplateStatusAtProviderStopCondition>? StopCondition { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Target of an action. See below.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta1ExperimentTemplateStatusAtProviderTarget>? Target { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateStatusConditions
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

/// <summary>ExperimentTemplateStatus defines the observed state of ExperimentTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExperimentTemplateStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ExperimentTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ExperimentTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ExperimentTemplate is the Schema for the ExperimentTemplates API. Provides an FIS Experiment Template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ExperimentTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ExperimentTemplateSpec>, IStatus<V1beta1ExperimentTemplateStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ExperimentTemplate";
    public const string KubeGroup = "fis.aws.upbound.io";
    public const string KubePluralName = "experimenttemplates";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ExperimentTemplateSpec defines the desired state of ExperimentTemplate</summary>
    [JsonPropertyName("spec")]
    public V1beta1ExperimentTemplateSpec Spec { get; set; }

    /// <summary>ExperimentTemplateStatus defines the observed state of ExperimentTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta1ExperimentTemplateStatus? Status { get; set; }
}