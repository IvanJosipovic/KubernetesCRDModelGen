using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.autoscalingplans.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecForProviderApplicationSourceTagFilter
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Tag values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecForProviderApplicationSource
{
    /// <summary>ARN of a AWS CloudFormation stack.</summary>
    [JsonPropertyName("cloudformationStackArn")]
    public string? CloudformationStackArn { get; set; }

    /// <summary>Set of tags.</summary>
    [JsonPropertyName("tagFilter")]
    public IList<V1beta1ScalingPlanSpecForProviderApplicationSourceTagFilter>? TagFilter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecForProviderScalingInstructionCustomizedLoadMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Statistic of the metric. Currently, the value must always be Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecForProviderScalingInstructionPredefinedLoadMetricSpecification
{
    /// <summary>Metric type. Valid values: ALBTargetGroupRequestCount, ASGTotalCPUUtilization, ASGTotalNetworkIn, ASGTotalNetworkOut.</summary>
    [JsonPropertyName("predefinedLoadMetricType")]
    public string? PredefinedLoadMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecForProviderScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Statistic of the metric. Currently, the value must always be Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecForProviderScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification
{
    /// <summary>Metric type. Valid values: ALBRequestCountPerTarget, ASGAverageCPUUtilization, ASGAverageNetworkIn, ASGAverageNetworkOut, DynamoDBReadCapacityUtilization, DynamoDBWriteCapacityUtilization, ECSServiceAverageCPUUtilization, ECSServiceAverageMemoryUtilization, EC2SpotFleetRequestAverageCPUUtilization, EC2SpotFleetRequestAverageNetworkIn, EC2SpotFleetRequestAverageNetworkOut, RDSReaderAverageCPUUtilization, RDSReaderAverageDatabaseConnections.</summary>
    [JsonPropertyName("predefinedScalingMetricType")]
    public string? PredefinedScalingMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecForProviderScalingInstructionTargetTrackingConfiguration
{
    /// <summary>Customized metric. You can specify either customized_scaling_metric_specification or predefined_scaling_metric_specification. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public IList<V1beta1ScalingPlanSpecForProviderScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification>? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Boolean indicating whether scale in by the target tracking scaling policy is disabled. Defaults to false.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>Estimated time, in seconds, until a newly launched instance can contribute to the CloudWatch metrics. This value is used only if the resource is an Auto Scaling group.</summary>
    [JsonPropertyName("estimatedInstanceWarmup")]
    public double? EstimatedInstanceWarmup { get; set; }

    /// <summary>Predefined metric. You can specify either predefined_scaling_metric_specification or customized_scaling_metric_specification. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public IList<V1beta1ScalingPlanSpecForProviderScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification>? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>Amount of time, in seconds, after a scale in activity completes before another scale in activity can start. This value is not used if the scalable resource is an Auto Scaling group.</summary>
    [JsonPropertyName("scaleInCooldown")]
    public double? ScaleInCooldown { get; set; }

    /// <summary>Amount of time, in seconds, after a scale-out activity completes before another scale-out activity can start. This value is not used if the scalable resource is an Auto Scaling group.</summary>
    [JsonPropertyName("scaleOutCooldown")]
    public double? ScaleOutCooldown { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecForProviderScalingInstruction
{
    /// <summary>Customized load metric to use for predictive scaling. You must specify either customized_load_metric_specification or predefined_load_metric_specification when configuring predictive scaling. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public IList<V1beta1ScalingPlanSpecForProviderScalingInstructionCustomizedLoadMetricSpecification>? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Boolean controlling whether dynamic scaling by AWS Auto Scaling is disabled. Defaults to false.</summary>
    [JsonPropertyName("disableDynamicScaling")]
    public bool? DisableDynamicScaling { get; set; }

    /// <summary>Maximum capacity of the resource. The exception to this upper limit is if you specify a non-default setting for predictive_scaling_max_capacity_behavior.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity of the resource.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>Predefined load metric to use for predictive scaling. You must specify either predefined_load_metric_specification or customized_load_metric_specification when configuring predictive scaling. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public IList<V1beta1ScalingPlanSpecForProviderScalingInstructionPredefinedLoadMetricSpecification>? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>Defines the behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity specified for the resource. Valid values: SetForecastCapacityToMaxCapacity, SetMaxCapacityAboveForecastCapacity, SetMaxCapacityToForecastCapacity.</summary>
    [JsonPropertyName("predictiveScalingMaxCapacityBehavior")]
    public string? PredictiveScalingMaxCapacityBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity.</summary>
    [JsonPropertyName("predictiveScalingMaxCapacityBuffer")]
    public double? PredictiveScalingMaxCapacityBuffer { get; set; }

    /// <summary>Predictive scaling mode. Valid values: ForecastAndScale, ForecastOnly.</summary>
    [JsonPropertyName("predictiveScalingMode")]
    public string? PredictiveScalingMode { get; set; }

    /// <summary>ID of the resource. This string consists of the resource type and unique identifier.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Scalable dimension associated with the resource. Valid values: autoscaling:autoScalingGroup:DesiredCapacity, dynamodb:index:ReadCapacityUnits, dynamodb:index:WriteCapacityUnits, dynamodb:table:ReadCapacityUnits, dynamodb:table:WriteCapacityUnits, ecs:service:DesiredCount, ec2:spot-fleet-request:TargetCapacity, rds:cluster:ReadReplicaCount.</summary>
    [JsonPropertyName("scalableDimension")]
    public string? ScalableDimension { get; set; }

    /// <summary>Controls whether a resource's externally created scaling policies are kept or replaced. Valid values: KeepExternalPolicies, ReplaceExternalPolicies. Defaults to KeepExternalPolicies.</summary>
    [JsonPropertyName("scalingPolicyUpdateBehavior")]
    public string? ScalingPolicyUpdateBehavior { get; set; }

    /// <summary>Amount of time, in seconds, to buffer the run time of scheduled scaling actions when scaling out.</summary>
    [JsonPropertyName("scheduledActionBufferTime")]
    public double? ScheduledActionBufferTime { get; set; }

    /// <summary>Namespace of the AWS service. Valid values: autoscaling, dynamodb, ecs, ec2, rds.</summary>
    [JsonPropertyName("serviceNamespace")]
    public string? ServiceNamespace { get; set; }

    /// <summary>Structure that defines new target tracking configurations. Each of these structures includes a specific scaling metric and a target value for the metric, along with various parameters to use with dynamic scaling. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("targetTrackingConfiguration")]
    public IList<V1beta1ScalingPlanSpecForProviderScalingInstructionTargetTrackingConfiguration>? TargetTrackingConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecForProvider
{
    /// <summary>CloudFormation stack or set of tags. You can create one scaling plan per application source.</summary>
    [JsonPropertyName("applicationSource")]
    public IList<V1beta1ScalingPlanSpecForProviderApplicationSource>? ApplicationSource { get; set; }

    /// <summary>Name of the scaling plan. Names cannot contain vertical bars, colons, or forward slashes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Scaling instructions. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("scalingInstruction")]
    public IList<V1beta1ScalingPlanSpecForProviderScalingInstruction>? ScalingInstruction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecInitProviderApplicationSourceTagFilter
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Tag values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecInitProviderApplicationSource
{
    /// <summary>ARN of a AWS CloudFormation stack.</summary>
    [JsonPropertyName("cloudformationStackArn")]
    public string? CloudformationStackArn { get; set; }

    /// <summary>Set of tags.</summary>
    [JsonPropertyName("tagFilter")]
    public IList<V1beta1ScalingPlanSpecInitProviderApplicationSourceTagFilter>? TagFilter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecInitProviderScalingInstructionCustomizedLoadMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Statistic of the metric. Currently, the value must always be Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecInitProviderScalingInstructionPredefinedLoadMetricSpecification
{
    /// <summary>Metric type. Valid values: ALBTargetGroupRequestCount, ASGTotalCPUUtilization, ASGTotalNetworkIn, ASGTotalNetworkOut.</summary>
    [JsonPropertyName("predefinedLoadMetricType")]
    public string? PredefinedLoadMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecInitProviderScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Statistic of the metric. Currently, the value must always be Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecInitProviderScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification
{
    /// <summary>Metric type. Valid values: ALBRequestCountPerTarget, ASGAverageCPUUtilization, ASGAverageNetworkIn, ASGAverageNetworkOut, DynamoDBReadCapacityUtilization, DynamoDBWriteCapacityUtilization, ECSServiceAverageCPUUtilization, ECSServiceAverageMemoryUtilization, EC2SpotFleetRequestAverageCPUUtilization, EC2SpotFleetRequestAverageNetworkIn, EC2SpotFleetRequestAverageNetworkOut, RDSReaderAverageCPUUtilization, RDSReaderAverageDatabaseConnections.</summary>
    [JsonPropertyName("predefinedScalingMetricType")]
    public string? PredefinedScalingMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecInitProviderScalingInstructionTargetTrackingConfiguration
{
    /// <summary>Customized metric. You can specify either customized_scaling_metric_specification or predefined_scaling_metric_specification. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public IList<V1beta1ScalingPlanSpecInitProviderScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification>? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Boolean indicating whether scale in by the target tracking scaling policy is disabled. Defaults to false.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>Estimated time, in seconds, until a newly launched instance can contribute to the CloudWatch metrics. This value is used only if the resource is an Auto Scaling group.</summary>
    [JsonPropertyName("estimatedInstanceWarmup")]
    public double? EstimatedInstanceWarmup { get; set; }

    /// <summary>Predefined metric. You can specify either predefined_scaling_metric_specification or customized_scaling_metric_specification. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public IList<V1beta1ScalingPlanSpecInitProviderScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification>? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>Amount of time, in seconds, after a scale in activity completes before another scale in activity can start. This value is not used if the scalable resource is an Auto Scaling group.</summary>
    [JsonPropertyName("scaleInCooldown")]
    public double? ScaleInCooldown { get; set; }

    /// <summary>Amount of time, in seconds, after a scale-out activity completes before another scale-out activity can start. This value is not used if the scalable resource is an Auto Scaling group.</summary>
    [JsonPropertyName("scaleOutCooldown")]
    public double? ScaleOutCooldown { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecInitProviderScalingInstruction
{
    /// <summary>Customized load metric to use for predictive scaling. You must specify either customized_load_metric_specification or predefined_load_metric_specification when configuring predictive scaling. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public IList<V1beta1ScalingPlanSpecInitProviderScalingInstructionCustomizedLoadMetricSpecification>? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Boolean controlling whether dynamic scaling by AWS Auto Scaling is disabled. Defaults to false.</summary>
    [JsonPropertyName("disableDynamicScaling")]
    public bool? DisableDynamicScaling { get; set; }

    /// <summary>Maximum capacity of the resource. The exception to this upper limit is if you specify a non-default setting for predictive_scaling_max_capacity_behavior.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity of the resource.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>Predefined load metric to use for predictive scaling. You must specify either predefined_load_metric_specification or customized_load_metric_specification when configuring predictive scaling. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public IList<V1beta1ScalingPlanSpecInitProviderScalingInstructionPredefinedLoadMetricSpecification>? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>Defines the behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity specified for the resource. Valid values: SetForecastCapacityToMaxCapacity, SetMaxCapacityAboveForecastCapacity, SetMaxCapacityToForecastCapacity.</summary>
    [JsonPropertyName("predictiveScalingMaxCapacityBehavior")]
    public string? PredictiveScalingMaxCapacityBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity.</summary>
    [JsonPropertyName("predictiveScalingMaxCapacityBuffer")]
    public double? PredictiveScalingMaxCapacityBuffer { get; set; }

    /// <summary>Predictive scaling mode. Valid values: ForecastAndScale, ForecastOnly.</summary>
    [JsonPropertyName("predictiveScalingMode")]
    public string? PredictiveScalingMode { get; set; }

    /// <summary>ID of the resource. This string consists of the resource type and unique identifier.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Scalable dimension associated with the resource. Valid values: autoscaling:autoScalingGroup:DesiredCapacity, dynamodb:index:ReadCapacityUnits, dynamodb:index:WriteCapacityUnits, dynamodb:table:ReadCapacityUnits, dynamodb:table:WriteCapacityUnits, ecs:service:DesiredCount, ec2:spot-fleet-request:TargetCapacity, rds:cluster:ReadReplicaCount.</summary>
    [JsonPropertyName("scalableDimension")]
    public string? ScalableDimension { get; set; }

    /// <summary>Controls whether a resource's externally created scaling policies are kept or replaced. Valid values: KeepExternalPolicies, ReplaceExternalPolicies. Defaults to KeepExternalPolicies.</summary>
    [JsonPropertyName("scalingPolicyUpdateBehavior")]
    public string? ScalingPolicyUpdateBehavior { get; set; }

    /// <summary>Amount of time, in seconds, to buffer the run time of scheduled scaling actions when scaling out.</summary>
    [JsonPropertyName("scheduledActionBufferTime")]
    public double? ScheduledActionBufferTime { get; set; }

    /// <summary>Namespace of the AWS service. Valid values: autoscaling, dynamodb, ecs, ec2, rds.</summary>
    [JsonPropertyName("serviceNamespace")]
    public string? ServiceNamespace { get; set; }

    /// <summary>Structure that defines new target tracking configurations. Each of these structures includes a specific scaling metric and a target value for the metric, along with various parameters to use with dynamic scaling. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("targetTrackingConfiguration")]
    public IList<V1beta1ScalingPlanSpecInitProviderScalingInstructionTargetTrackingConfiguration>? TargetTrackingConfiguration { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecInitProvider
{
    /// <summary>CloudFormation stack or set of tags. You can create one scaling plan per application source.</summary>
    [JsonPropertyName("applicationSource")]
    public IList<V1beta1ScalingPlanSpecInitProviderApplicationSource>? ApplicationSource { get; set; }

    /// <summary>Name of the scaling plan. Names cannot contain vertical bars, colons, or forward slashes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Scaling instructions. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("scalingInstruction")]
    public IList<V1beta1ScalingPlanSpecInitProviderScalingInstruction>? ScalingInstruction { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecProviderConfigRefPolicy
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
public partial class V1beta1ScalingPlanSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScalingPlanSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1ScalingPlanSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScalingPlanSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ScalingPlanSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ScalingPlanSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ScalingPlanSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ScalingPlanSpec defines the desired state of ScalingPlan</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ScalingPlanSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ScalingPlanSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ScalingPlanSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ScalingPlanSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ScalingPlanSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanStatusAtProviderApplicationSourceTagFilter
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Tag values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanStatusAtProviderApplicationSource
{
    /// <summary>ARN of a AWS CloudFormation stack.</summary>
    [JsonPropertyName("cloudformationStackArn")]
    public string? CloudformationStackArn { get; set; }

    /// <summary>Set of tags.</summary>
    [JsonPropertyName("tagFilter")]
    public IList<V1beta1ScalingPlanStatusAtProviderApplicationSourceTagFilter>? TagFilter { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanStatusAtProviderScalingInstructionCustomizedLoadMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Statistic of the metric. Currently, the value must always be Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanStatusAtProviderScalingInstructionPredefinedLoadMetricSpecification
{
    /// <summary>Metric type. Valid values: ALBTargetGroupRequestCount, ASGTotalCPUUtilization, ASGTotalNetworkIn, ASGTotalNetworkOut.</summary>
    [JsonPropertyName("predefinedLoadMetricType")]
    public string? PredefinedLoadMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanStatusAtProviderScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Statistic of the metric. Currently, the value must always be Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanStatusAtProviderScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification
{
    /// <summary>Metric type. Valid values: ALBRequestCountPerTarget, ASGAverageCPUUtilization, ASGAverageNetworkIn, ASGAverageNetworkOut, DynamoDBReadCapacityUtilization, DynamoDBWriteCapacityUtilization, ECSServiceAverageCPUUtilization, ECSServiceAverageMemoryUtilization, EC2SpotFleetRequestAverageCPUUtilization, EC2SpotFleetRequestAverageNetworkIn, EC2SpotFleetRequestAverageNetworkOut, RDSReaderAverageCPUUtilization, RDSReaderAverageDatabaseConnections.</summary>
    [JsonPropertyName("predefinedScalingMetricType")]
    public string? PredefinedScalingMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanStatusAtProviderScalingInstructionTargetTrackingConfiguration
{
    /// <summary>Customized metric. You can specify either customized_scaling_metric_specification or predefined_scaling_metric_specification. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public IList<V1beta1ScalingPlanStatusAtProviderScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification>? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Boolean indicating whether scale in by the target tracking scaling policy is disabled. Defaults to false.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>Estimated time, in seconds, until a newly launched instance can contribute to the CloudWatch metrics. This value is used only if the resource is an Auto Scaling group.</summary>
    [JsonPropertyName("estimatedInstanceWarmup")]
    public double? EstimatedInstanceWarmup { get; set; }

    /// <summary>Predefined metric. You can specify either predefined_scaling_metric_specification or customized_scaling_metric_specification. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public IList<V1beta1ScalingPlanStatusAtProviderScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification>? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>Amount of time, in seconds, after a scale in activity completes before another scale in activity can start. This value is not used if the scalable resource is an Auto Scaling group.</summary>
    [JsonPropertyName("scaleInCooldown")]
    public double? ScaleInCooldown { get; set; }

    /// <summary>Amount of time, in seconds, after a scale-out activity completes before another scale-out activity can start. This value is not used if the scalable resource is an Auto Scaling group.</summary>
    [JsonPropertyName("scaleOutCooldown")]
    public double? ScaleOutCooldown { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanStatusAtProviderScalingInstruction
{
    /// <summary>Customized load metric to use for predictive scaling. You must specify either customized_load_metric_specification or predefined_load_metric_specification when configuring predictive scaling. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public IList<V1beta1ScalingPlanStatusAtProviderScalingInstructionCustomizedLoadMetricSpecification>? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Boolean controlling whether dynamic scaling by AWS Auto Scaling is disabled. Defaults to false.</summary>
    [JsonPropertyName("disableDynamicScaling")]
    public bool? DisableDynamicScaling { get; set; }

    /// <summary>Maximum capacity of the resource. The exception to this upper limit is if you specify a non-default setting for predictive_scaling_max_capacity_behavior.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity of the resource.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>Predefined load metric to use for predictive scaling. You must specify either predefined_load_metric_specification or customized_load_metric_specification when configuring predictive scaling. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public IList<V1beta1ScalingPlanStatusAtProviderScalingInstructionPredefinedLoadMetricSpecification>? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>Defines the behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity specified for the resource. Valid values: SetForecastCapacityToMaxCapacity, SetMaxCapacityAboveForecastCapacity, SetMaxCapacityToForecastCapacity.</summary>
    [JsonPropertyName("predictiveScalingMaxCapacityBehavior")]
    public string? PredictiveScalingMaxCapacityBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity.</summary>
    [JsonPropertyName("predictiveScalingMaxCapacityBuffer")]
    public double? PredictiveScalingMaxCapacityBuffer { get; set; }

    /// <summary>Predictive scaling mode. Valid values: ForecastAndScale, ForecastOnly.</summary>
    [JsonPropertyName("predictiveScalingMode")]
    public string? PredictiveScalingMode { get; set; }

    /// <summary>ID of the resource. This string consists of the resource type and unique identifier.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Scalable dimension associated with the resource. Valid values: autoscaling:autoScalingGroup:DesiredCapacity, dynamodb:index:ReadCapacityUnits, dynamodb:index:WriteCapacityUnits, dynamodb:table:ReadCapacityUnits, dynamodb:table:WriteCapacityUnits, ecs:service:DesiredCount, ec2:spot-fleet-request:TargetCapacity, rds:cluster:ReadReplicaCount.</summary>
    [JsonPropertyName("scalableDimension")]
    public string? ScalableDimension { get; set; }

    /// <summary>Controls whether a resource's externally created scaling policies are kept or replaced. Valid values: KeepExternalPolicies, ReplaceExternalPolicies. Defaults to KeepExternalPolicies.</summary>
    [JsonPropertyName("scalingPolicyUpdateBehavior")]
    public string? ScalingPolicyUpdateBehavior { get; set; }

    /// <summary>Amount of time, in seconds, to buffer the run time of scheduled scaling actions when scaling out.</summary>
    [JsonPropertyName("scheduledActionBufferTime")]
    public double? ScheduledActionBufferTime { get; set; }

    /// <summary>Namespace of the AWS service. Valid values: autoscaling, dynamodb, ecs, ec2, rds.</summary>
    [JsonPropertyName("serviceNamespace")]
    public string? ServiceNamespace { get; set; }

    /// <summary>Structure that defines new target tracking configurations. Each of these structures includes a specific scaling metric and a target value for the metric, along with various parameters to use with dynamic scaling. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("targetTrackingConfiguration")]
    public IList<V1beta1ScalingPlanStatusAtProviderScalingInstructionTargetTrackingConfiguration>? TargetTrackingConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanStatusAtProvider
{
    /// <summary>CloudFormation stack or set of tags. You can create one scaling plan per application source.</summary>
    [JsonPropertyName("applicationSource")]
    public IList<V1beta1ScalingPlanStatusAtProviderApplicationSource>? ApplicationSource { get; set; }

    /// <summary>Scaling plan identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the scaling plan. Names cannot contain vertical bars, colons, or forward slashes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Scaling instructions. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("scalingInstruction")]
    public IList<V1beta1ScalingPlanStatusAtProviderScalingInstruction>? ScalingInstruction { get; set; }

    /// <summary>The version number of the scaling plan. This value is always 1.</summary>
    [JsonPropertyName("scalingPlanVersion")]
    public double? ScalingPlanVersion { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanStatusConditions
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

/// <summary>ScalingPlanStatus defines the observed state of ScalingPlan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScalingPlanStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ScalingPlanStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ScalingPlanStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ScalingPlan is the Schema for the ScalingPlans API. Manages an AWS Auto Scaling scaling plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ScalingPlan : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ScalingPlanSpec>, IStatus<V1beta1ScalingPlanStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ScalingPlan";
    public const string KubeGroup = "autoscalingplans.aws.upbound.io";
    public const string KubePluralName = "scalingplans";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ScalingPlanSpec defines the desired state of ScalingPlan</summary>
    [JsonPropertyName("spec")]
    public V1beta1ScalingPlanSpec Spec { get; set; }

    /// <summary>ScalingPlanStatus defines the observed state of ScalingPlan.</summary>
    [JsonPropertyName("status")]
    public V1beta1ScalingPlanStatus? Status { get; set; }
}

/// <summary>ScalingPlan is the Schema for the ScalingPlans API. Manages an AWS Auto Scaling scaling plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ScalingPlanList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ScalingPlan>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ScalingPlanList";
    public const string KubeGroup = "autoscalingplans.aws.upbound.io";
    public const string KubePluralName = "scalingplans";
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
    public IList<V1beta1ScalingPlan> Items { get; set; }
}