using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.autoscaling.aws.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderAutoscalingGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a AutoscalingGroup in autoscaling to populate autoscalingGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderAutoscalingGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySpecForProviderAutoscalingGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderAutoscalingGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a AutoscalingGroup in autoscaling to populate autoscalingGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderAutoscalingGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySpecForProviderAutoscalingGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueries
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized capacity metric specification. The field is only valid when you use customized_load_metric_specification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueries
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized load metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueries
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized scaling metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

/// <summary>Predefined load metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Metric pair specification from which Amazon EC2 Auto Scaling determines the appropriate scaling metric and load metric to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Predefined scaling metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>This structure includes the metrics and target utilization to use for predictive scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecification
{
    /// <summary>Customized capacity metric specification. The field is only valid when you use customized_load_metric_specification</summary>
    [JsonPropertyName("customizedCapacityMetricSpecification")]
    public V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecification { get; set; }

    /// <summary>Customized load metric specification.</summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Customized scaling metric specification.</summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Predefined load metric specification.</summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>Metric pair specification from which Amazon EC2 Auto Scaling determines the appropriate scaling metric and load metric to use.</summary>
    [JsonPropertyName("predefinedMetricPairSpecification")]
    public V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification { get; set; }

    /// <summary>Predefined scaling metric specification.</summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

/// <summary>Predictive scaling policy configuration to use with Amazon EC2 Auto Scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingConfiguration
{
    /// <summary>Defines the behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity of the Auto Scaling group. Valid values are HonorMaxCapacity or IncreaseMaxCapacity. Default is HonorMaxCapacity.</summary>
    [JsonPropertyName("maxCapacityBreachBehavior")]
    public string? MaxCapacityBreachBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity. Valid range is 0 to 100. If set to 0, Amazon EC2 Auto Scaling may scale capacity higher than the maximum capacity to equal but not exceed forecast capacity.</summary>
    [JsonPropertyName("maxCapacityBuffer")]
    public string? MaxCapacityBuffer { get; set; }

    /// <summary>This structure includes the metrics and target utilization to use for predictive scaling.</summary>
    [JsonPropertyName("metricSpecification")]
    public V1beta1PolicySpecForProviderPredictiveScalingConfigurationMetricSpecification? MetricSpecification { get; set; }

    /// <summary>Predictive scaling mode. Valid values are ForecastAndScale and ForecastOnly. Default is ForecastOnly.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Amount of time, in seconds, by which the instance launch time can be advanced. Minimum is 0.</summary>
    [JsonPropertyName("schedulingBufferTime")]
    public string? SchedulingBufferTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderStepAdjustment
{
    /// <summary>Lower bound for the difference between the alarm threshold and the CloudWatch metric. Without a value, AWS will treat this bound as negative infinity.</summary>
    [JsonPropertyName("metricIntervalLowerBound")]
    public string? MetricIntervalLowerBound { get; set; }

    /// <summary>Upper bound for the difference between the alarm threshold and the CloudWatch metric. Without a value, AWS will treat this bound as positive infinity. The upper bound must be greater than the lower bound.</summary>
    [JsonPropertyName("metricIntervalUpperBound")]
    public string? MetricIntervalUpperBound { get; set; }

    /// <summary>Number of instances by which to scale. adjustment_type determines the interpretation of this number (e.g., as an absolute number or as a percentage of the existing Auto Scaling group size). A positive increment adds to the current capacity and a negative value removes from the current capacity.</summary>
    [JsonPropertyName("scalingAdjustment")]
    public double? ScalingAdjustment { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric? Metric { get; set; }

    /// <summary>The period of the metric in seconds.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetrics
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized metric. Conflicts with predefined_metric_specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("metricDimension")]
    public IList<V1beta1PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension>? MetricDimension { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Metrics to include, as a metric data query.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta1PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetrics>? Metrics { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The period of the metric in seconds.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Statistic of the metric.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>Predefined metric. Conflicts with customized_metric_specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingConfigurationPredefinedMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Target tracking policy. These have the following structure:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingConfiguration
{
    /// <summary>Customized metric. Conflicts with predefined_metric_specification.</summary>
    [JsonPropertyName("customizedMetricSpecification")]
    public V1beta1PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification { get; set; }

    /// <summary>Whether scale in by the target tracking policy is disabled.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>Predefined metric. Conflicts with customized_metric_specification.</summary>
    [JsonPropertyName("predefinedMetricSpecification")]
    public V1beta1PolicySpecForProviderTargetTrackingConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProvider
{
    /// <summary>Whether the adjustment is an absolute number or a percentage of the current capacity. Valid values are ChangeInCapacity, ExactCapacity, and PercentChangeInCapacity.</summary>
    [JsonPropertyName("adjustmentType")]
    public string? AdjustmentType { get; set; }

    /// <summary>Name of the autoscaling group.</summary>
    [JsonPropertyName("autoscalingGroupName")]
    public string? AutoscalingGroupName { get; set; }

    /// <summary>Reference to a AutoscalingGroup in autoscaling to populate autoscalingGroupName.</summary>
    [JsonPropertyName("autoscalingGroupNameRef")]
    public V1beta1PolicySpecForProviderAutoscalingGroupNameRef? AutoscalingGroupNameRef { get; set; }

    /// <summary>Selector for a AutoscalingGroup in autoscaling to populate autoscalingGroupName.</summary>
    [JsonPropertyName("autoscalingGroupNameSelector")]
    public V1beta1PolicySpecForProviderAutoscalingGroupNameSelector? AutoscalingGroupNameSelector { get; set; }

    /// <summary>Amount of time, in seconds, after a scaling activity completes and before the next scaling activity can start.</summary>
    [JsonPropertyName("cooldown")]
    public double? Cooldown { get; set; }

    /// <summary>Whether the scaling policy is enabled or disabled. Default: true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Estimated time, in seconds, until a newly launched instance will contribute CloudWatch metrics. Without a value, AWS will default to the group's specified cooldown period.</summary>
    [JsonPropertyName("estimatedInstanceWarmup")]
    public double? EstimatedInstanceWarmup { get; set; }

    /// <summary>Aggregation type for the policy's metrics. Valid values are "Minimum", "Maximum", and "Average". Without a value, AWS will treat the aggregation type as "Average".</summary>
    [JsonPropertyName("metricAggregationType")]
    public string? MetricAggregationType { get; set; }

    /// <summary>Minimum value to scale by when adjustment_type is set to PercentChangeInCapacity.</summary>
    [JsonPropertyName("minAdjustmentMagnitude")]
    public double? MinAdjustmentMagnitude { get; set; }

    /// <summary>Policy type, either "SimpleScaling", "StepScaling", "TargetTrackingScaling", or "PredictiveScaling". If this value isn't provided, AWS will default to "SimpleScaling."</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Predictive scaling policy configuration to use with Amazon EC2 Auto Scaling.</summary>
    [JsonPropertyName("predictiveScalingConfiguration")]
    public V1beta1PolicySpecForProviderPredictiveScalingConfiguration? PredictiveScalingConfiguration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Number of instances by which to scale. adjustment_type determines the interpretation of this number (e.g., as an absolute number or as a percentage of the existing Auto Scaling group size). A positive increment adds to the current capacity and a negative value removes from the current capacity.</summary>
    [JsonPropertyName("scalingAdjustment")]
    public double? ScalingAdjustment { get; set; }

    /// <summary>Set of adjustments that manage group scaling. These have the following structure:</summary>
    [JsonPropertyName("stepAdjustment")]
    public IList<V1beta1PolicySpecForProviderStepAdjustment>? StepAdjustment { get; set; }

    /// <summary>Target tracking policy. These have the following structure:</summary>
    [JsonPropertyName("targetTrackingConfiguration")]
    public V1beta1PolicySpecForProviderTargetTrackingConfiguration? TargetTrackingConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueries
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized capacity metric specification. The field is only valid when you use customized_load_metric_specification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueries
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized load metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueries
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized scaling metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

/// <summary>Predefined load metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Metric pair specification from which Amazon EC2 Auto Scaling determines the appropriate scaling metric and load metric to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Predefined scaling metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>This structure includes the metrics and target utilization to use for predictive scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecification
{
    /// <summary>Customized capacity metric specification. The field is only valid when you use customized_load_metric_specification</summary>
    [JsonPropertyName("customizedCapacityMetricSpecification")]
    public V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecification { get; set; }

    /// <summary>Customized load metric specification.</summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Customized scaling metric specification.</summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Predefined load metric specification.</summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>Metric pair specification from which Amazon EC2 Auto Scaling determines the appropriate scaling metric and load metric to use.</summary>
    [JsonPropertyName("predefinedMetricPairSpecification")]
    public V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification { get; set; }

    /// <summary>Predefined scaling metric specification.</summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

/// <summary>Predictive scaling policy configuration to use with Amazon EC2 Auto Scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingConfiguration
{
    /// <summary>Defines the behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity of the Auto Scaling group. Valid values are HonorMaxCapacity or IncreaseMaxCapacity. Default is HonorMaxCapacity.</summary>
    [JsonPropertyName("maxCapacityBreachBehavior")]
    public string? MaxCapacityBreachBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity. Valid range is 0 to 100. If set to 0, Amazon EC2 Auto Scaling may scale capacity higher than the maximum capacity to equal but not exceed forecast capacity.</summary>
    [JsonPropertyName("maxCapacityBuffer")]
    public string? MaxCapacityBuffer { get; set; }

    /// <summary>This structure includes the metrics and target utilization to use for predictive scaling.</summary>
    [JsonPropertyName("metricSpecification")]
    public V1beta1PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecification? MetricSpecification { get; set; }

    /// <summary>Predictive scaling mode. Valid values are ForecastAndScale and ForecastOnly. Default is ForecastOnly.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Amount of time, in seconds, by which the instance launch time can be advanced. Minimum is 0.</summary>
    [JsonPropertyName("schedulingBufferTime")]
    public string? SchedulingBufferTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderStepAdjustment
{
    /// <summary>Lower bound for the difference between the alarm threshold and the CloudWatch metric. Without a value, AWS will treat this bound as negative infinity.</summary>
    [JsonPropertyName("metricIntervalLowerBound")]
    public string? MetricIntervalLowerBound { get; set; }

    /// <summary>Upper bound for the difference between the alarm threshold and the CloudWatch metric. Without a value, AWS will treat this bound as positive infinity. The upper bound must be greater than the lower bound.</summary>
    [JsonPropertyName("metricIntervalUpperBound")]
    public string? MetricIntervalUpperBound { get; set; }

    /// <summary>Number of instances by which to scale. adjustment_type determines the interpretation of this number (e.g., as an absolute number or as a percentage of the existing Auto Scaling group size). A positive increment adds to the current capacity and a negative value removes from the current capacity.</summary>
    [JsonPropertyName("scalingAdjustment")]
    public double? ScalingAdjustment { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric? Metric { get; set; }

    /// <summary>The period of the metric in seconds.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetrics
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized metric. Conflicts with predefined_metric_specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("metricDimension")]
    public IList<V1beta1PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension>? MetricDimension { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Metrics to include, as a metric data query.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta1PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetrics>? Metrics { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The period of the metric in seconds.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Statistic of the metric.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>Predefined metric. Conflicts with customized_metric_specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingConfigurationPredefinedMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Target tracking policy. These have the following structure:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingConfiguration
{
    /// <summary>Customized metric. Conflicts with predefined_metric_specification.</summary>
    [JsonPropertyName("customizedMetricSpecification")]
    public V1beta1PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification { get; set; }

    /// <summary>Whether scale in by the target tracking policy is disabled.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>Predefined metric. Conflicts with customized_metric_specification.</summary>
    [JsonPropertyName("predefinedMetricSpecification")]
    public V1beta1PolicySpecInitProviderTargetTrackingConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProvider
{
    /// <summary>Whether the adjustment is an absolute number or a percentage of the current capacity. Valid values are ChangeInCapacity, ExactCapacity, and PercentChangeInCapacity.</summary>
    [JsonPropertyName("adjustmentType")]
    public string? AdjustmentType { get; set; }

    /// <summary>Amount of time, in seconds, after a scaling activity completes and before the next scaling activity can start.</summary>
    [JsonPropertyName("cooldown")]
    public double? Cooldown { get; set; }

    /// <summary>Whether the scaling policy is enabled or disabled. Default: true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Estimated time, in seconds, until a newly launched instance will contribute CloudWatch metrics. Without a value, AWS will default to the group's specified cooldown period.</summary>
    [JsonPropertyName("estimatedInstanceWarmup")]
    public double? EstimatedInstanceWarmup { get; set; }

    /// <summary>Aggregation type for the policy's metrics. Valid values are "Minimum", "Maximum", and "Average". Without a value, AWS will treat the aggregation type as "Average".</summary>
    [JsonPropertyName("metricAggregationType")]
    public string? MetricAggregationType { get; set; }

    /// <summary>Minimum value to scale by when adjustment_type is set to PercentChangeInCapacity.</summary>
    [JsonPropertyName("minAdjustmentMagnitude")]
    public double? MinAdjustmentMagnitude { get; set; }

    /// <summary>Policy type, either "SimpleScaling", "StepScaling", "TargetTrackingScaling", or "PredictiveScaling". If this value isn't provided, AWS will default to "SimpleScaling."</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Predictive scaling policy configuration to use with Amazon EC2 Auto Scaling.</summary>
    [JsonPropertyName("predictiveScalingConfiguration")]
    public V1beta1PolicySpecInitProviderPredictiveScalingConfiguration? PredictiveScalingConfiguration { get; set; }

    /// <summary>Number of instances by which to scale. adjustment_type determines the interpretation of this number (e.g., as an absolute number or as a percentage of the existing Auto Scaling group size). A positive increment adds to the current capacity and a negative value removes from the current capacity.</summary>
    [JsonPropertyName("scalingAdjustment")]
    public double? ScalingAdjustment { get; set; }

    /// <summary>Set of adjustments that manage group scaling. These have the following structure:</summary>
    [JsonPropertyName("stepAdjustment")]
    public IList<V1beta1PolicySpecInitProviderStepAdjustment>? StepAdjustment { get; set; }

    /// <summary>Target tracking policy. These have the following structure:</summary>
    [JsonPropertyName("targetTrackingConfiguration")]
    public V1beta1PolicySpecInitProviderTargetTrackingConfiguration? TargetTrackingConfiguration { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>PolicySpec defines the desired state of Policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueries
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized capacity metric specification. The field is only valid when you use customized_load_metric_specification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueries
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized load metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueries
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized scaling metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

/// <summary>Predefined load metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Metric pair specification from which Amazon EC2 Auto Scaling determines the appropriate scaling metric and load metric to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Predefined scaling metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>This structure includes the metrics and target utilization to use for predictive scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecification
{
    /// <summary>Customized capacity metric specification. The field is only valid when you use customized_load_metric_specification</summary>
    [JsonPropertyName("customizedCapacityMetricSpecification")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecification { get; set; }

    /// <summary>Customized load metric specification.</summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Customized scaling metric specification.</summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Predefined load metric specification.</summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>Metric pair specification from which Amazon EC2 Auto Scaling determines the appropriate scaling metric and load metric to use.</summary>
    [JsonPropertyName("predefinedMetricPairSpecification")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification { get; set; }

    /// <summary>Predefined scaling metric specification.</summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

/// <summary>Predictive scaling policy configuration to use with Amazon EC2 Auto Scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingConfiguration
{
    /// <summary>Defines the behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity of the Auto Scaling group. Valid values are HonorMaxCapacity or IncreaseMaxCapacity. Default is HonorMaxCapacity.</summary>
    [JsonPropertyName("maxCapacityBreachBehavior")]
    public string? MaxCapacityBreachBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity. Valid range is 0 to 100. If set to 0, Amazon EC2 Auto Scaling may scale capacity higher than the maximum capacity to equal but not exceed forecast capacity.</summary>
    [JsonPropertyName("maxCapacityBuffer")]
    public string? MaxCapacityBuffer { get; set; }

    /// <summary>This structure includes the metrics and target utilization to use for predictive scaling.</summary>
    [JsonPropertyName("metricSpecification")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecification? MetricSpecification { get; set; }

    /// <summary>Predictive scaling mode. Valid values are ForecastAndScale and ForecastOnly. Default is ForecastOnly.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Amount of time, in seconds, by which the instance launch time can be advanced. Minimum is 0.</summary>
    [JsonPropertyName("schedulingBufferTime")]
    public string? SchedulingBufferTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderStepAdjustment
{
    /// <summary>Lower bound for the difference between the alarm threshold and the CloudWatch metric. Without a value, AWS will treat this bound as negative infinity.</summary>
    [JsonPropertyName("metricIntervalLowerBound")]
    public string? MetricIntervalLowerBound { get; set; }

    /// <summary>Upper bound for the difference between the alarm threshold and the CloudWatch metric. Without a value, AWS will treat this bound as positive infinity. The upper bound must be greater than the lower bound.</summary>
    [JsonPropertyName("metricIntervalUpperBound")]
    public string? MetricIntervalUpperBound { get; set; }

    /// <summary>Number of instances by which to scale. adjustment_type determines the interpretation of this number (e.g., as an absolute number or as a percentage of the existing Auto Scaling group size). A positive increment adds to the current capacity and a negative value removes from the current capacity.</summary>
    [JsonPropertyName("scalingAdjustment")]
    public double? ScalingAdjustment { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric? Metric { get; set; }

    /// <summary>The period of the metric in seconds.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetrics
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized metric. Conflicts with predefined_metric_specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("metricDimension")]
    public IList<V1beta1PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension>? MetricDimension { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Metrics to include, as a metric data query.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta1PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetrics>? Metrics { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The period of the metric in seconds.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Statistic of the metric.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>Predefined metric. Conflicts with customized_metric_specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingConfigurationPredefinedMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Target tracking policy. These have the following structure:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingConfiguration
{
    /// <summary>Customized metric. Conflicts with predefined_metric_specification.</summary>
    [JsonPropertyName("customizedMetricSpecification")]
    public V1beta1PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification { get; set; }

    /// <summary>Whether scale in by the target tracking policy is disabled.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>Predefined metric. Conflicts with customized_metric_specification.</summary>
    [JsonPropertyName("predefinedMetricSpecification")]
    public V1beta1PolicyStatusAtProviderTargetTrackingConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProvider
{
    /// <summary>Whether the adjustment is an absolute number or a percentage of the current capacity. Valid values are ChangeInCapacity, ExactCapacity, and PercentChangeInCapacity.</summary>
    [JsonPropertyName("adjustmentType")]
    public string? AdjustmentType { get; set; }

    /// <summary>ARN assigned by AWS to the scaling policy.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Name of the autoscaling group.</summary>
    [JsonPropertyName("autoscalingGroupName")]
    public string? AutoscalingGroupName { get; set; }

    /// <summary>Amount of time, in seconds, after a scaling activity completes and before the next scaling activity can start.</summary>
    [JsonPropertyName("cooldown")]
    public double? Cooldown { get; set; }

    /// <summary>Whether the scaling policy is enabled or disabled. Default: true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Estimated time, in seconds, until a newly launched instance will contribute CloudWatch metrics. Without a value, AWS will default to the group's specified cooldown period.</summary>
    [JsonPropertyName("estimatedInstanceWarmup")]
    public double? EstimatedInstanceWarmup { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Aggregation type for the policy's metrics. Valid values are "Minimum", "Maximum", and "Average". Without a value, AWS will treat the aggregation type as "Average".</summary>
    [JsonPropertyName("metricAggregationType")]
    public string? MetricAggregationType { get; set; }

    /// <summary>Minimum value to scale by when adjustment_type is set to PercentChangeInCapacity.</summary>
    [JsonPropertyName("minAdjustmentMagnitude")]
    public double? MinAdjustmentMagnitude { get; set; }

    /// <summary>Policy type, either "SimpleScaling", "StepScaling", "TargetTrackingScaling", or "PredictiveScaling". If this value isn't provided, AWS will default to "SimpleScaling."</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Predictive scaling policy configuration to use with Amazon EC2 Auto Scaling.</summary>
    [JsonPropertyName("predictiveScalingConfiguration")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingConfiguration? PredictiveScalingConfiguration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Number of instances by which to scale. adjustment_type determines the interpretation of this number (e.g., as an absolute number or as a percentage of the existing Auto Scaling group size). A positive increment adds to the current capacity and a negative value removes from the current capacity.</summary>
    [JsonPropertyName("scalingAdjustment")]
    public double? ScalingAdjustment { get; set; }

    /// <summary>Set of adjustments that manage group scaling. These have the following structure:</summary>
    [JsonPropertyName("stepAdjustment")]
    public IList<V1beta1PolicyStatusAtProviderStepAdjustment>? StepAdjustment { get; set; }

    /// <summary>Target tracking policy. These have the following structure:</summary>
    [JsonPropertyName("targetTrackingConfiguration")]
    public V1beta1PolicyStatusAtProviderTargetTrackingConfiguration? TargetTrackingConfiguration { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusConditions
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

/// <summary>PolicyStatus defines the observed state of Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Policy is the Schema for the Policys API. Provides an AutoScaling Scaling Group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Policy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PolicySpec>, IStatus<V1beta1PolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Policy";
    public const string KubeGroup = "autoscaling.aws.m.upbound.io";
    public const string KubePluralName = "policies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PolicySpec defines the desired state of Policy</summary>
    [JsonPropertyName("spec")]
    public V1beta1PolicySpec Spec { get; set; }

    /// <summary>PolicyStatus defines the observed state of Policy.</summary>
    [JsonPropertyName("status")]
    public V1beta1PolicyStatus? Status { get; set; }
}

/// <summary>Policy is the Schema for the Policys API. Provides an AutoScaling Scaling Group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Policy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PolicyList";
    public const string KubeGroup = "autoscaling.aws.m.upbound.io";
    public const string KubePluralName = "policies";
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
    public IList<V1beta1Policy> Items { get; set; }
}