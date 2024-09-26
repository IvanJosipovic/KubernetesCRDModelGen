using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudwatch.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecForProviderMetricQueryMetric
{
    /// <summary>The dimensions for this metric.  For the list of available dimensions see the AWS documentation here.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>The name for this metric. See docs for supported metrics.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The namespace for this metric. See docs for the list of namespaces. See docs for supported metrics.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Granularity in seconds of returned data points. For metrics with regular resolution, valid values are any multiple of 60. For high-resolution metrics, valid values are 1, 5, 10, 30, or any multiple of 60.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>The statistic to apply to this metric. See docs for supported statistics.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>The unit for this metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecForProviderMetricQuery
{
    /// <summary>The ID of the account where the metrics are located, if this is a cross-account alarm.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The math expression to be performed on the returned data, if this object is performing a math expression. This expression can use the id of the other metrics to refer to those metrics, and can also use the id of other expressions to use the result of those expressions. For more information about metric math expressions, see Metric Math Syntax and Functions in the Amazon CloudWatch User Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>A short name used to tie this object to the results in the response. If you are performing math expressions on this set of data, this name represents that data and can serve as a variable in the mathematical expression. The valid characters are letters, numbers, and underscore. The first character must be a lowercase letter.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A human-readable label for this metric or expression. This is especially useful if this is an expression, so that you know what the value represents.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The metric to be returned, along with statistics, period, and units. Use this parameter only if this object is retrieving a metric and not performing a math expression on returned data.</summary>
    [JsonPropertyName("metric")]
    public IList<V1beta1MetricAlarmSpecForProviderMetricQueryMetric>? Metric { get; set; }

    /// <summary>Granularity in seconds of returned data points. For metrics with regular resolution, valid values are any multiple of 60. For high-resolution metrics, valid values are 1, 5, 10, 30, or any multiple of 60.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Specify exactly one metric_query to be true to use that metric_query result as the alarm.</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecForProvider
{
    /// <summary>Indicates whether or not actions should be executed during any changes to the alarm's state. Defaults to true.</summary>
    [JsonPropertyName("actionsEnabled")]
    public bool? ActionsEnabled { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an ALARM state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("alarmActions")]
    public IList<string>? AlarmActions { get; set; }

    /// <summary>The description for the alarm.</summary>
    [JsonPropertyName("alarmDescription")]
    public string? AlarmDescription { get; set; }

    /// <summary>The arithmetic operation to use when comparing the specified Statistic and Threshold. The specified Statistic value is used as the first operand. Either of the following is supported: GreaterThanOrEqualToThreshold, GreaterThanThreshold, LessThanThreshold, LessThanOrEqualToThreshold. Additionally, the values  LessThanLowerOrGreaterThanUpperThreshold, LessThanLowerThreshold, and GreaterThanUpperThreshold are used only for alarms based on anomaly detection models.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>The number of datapoints that must be breaching to trigger the alarm.</summary>
    [JsonPropertyName("datapointsToAlarm")]
    public double? DatapointsToAlarm { get; set; }

    /// <summary>The dimensions for the alarm's associated metric.  For the list of available dimensions see the AWS documentation here.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>Used only for alarms based on percentiles. If you specify ignore, the alarm state will not change during periods with too few data points to be statistically significant. If you specify evaluate or omit this parameter, the alarm will always be evaluated and possibly change state no matter how many data points are available. The following values are supported: ignore, and evaluate.</summary>
    [JsonPropertyName("evaluateLowSampleCountPercentiles")]
    public string? EvaluateLowSampleCountPercentiles { get; set; }

    /// <summary>The number of periods over which data is compared to the specified threshold.</summary>
    [JsonPropertyName("evaluationPeriods")]
    public double? EvaluationPeriods { get; set; }

    /// <summary>The percentile statistic for the metric associated with the alarm. Specify a value between p0.0 and p100.</summary>
    [JsonPropertyName("extendedStatistic")]
    public string? ExtendedStatistic { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an INSUFFICIENT_DATA state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("insufficientDataActions")]
    public IList<string>? InsufficientDataActions { get; set; }

    /// <summary>The name for the alarm's associated metric. See docs for supported metrics.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Enables you to create an alarm based on a metric math expression. You may specify at most 20.</summary>
    [JsonPropertyName("metricQuery")]
    public IList<V1beta1MetricAlarmSpecForProviderMetricQuery>? MetricQuery { get; set; }

    /// <summary>The namespace for the alarm's associated metric. See docs for the list of namespaces. See docs for supported metrics.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an OK state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("okActions")]
    public IList<string>? OkActions { get; set; }

    /// <summary>The period in seconds over which the specified statistic is applied. Valid values are 10, 30, or any multiple of 60.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The statistic to apply to the alarm's associated metric. Either of the following is supported: SampleCount, Average, Sum, Minimum, Maximum</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The value against which the specified statistic is compared. This parameter is required for alarms based on static thresholds, but should not be used for alarms based on anomaly detection models.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>If this is an alarm based on an anomaly detection model, make this value match the ID of the ANOMALY_DETECTION_BAND function.</summary>
    [JsonPropertyName("thresholdMetricId")]
    public string? ThresholdMetricId { get; set; }

    /// <summary>Sets how this alarm is to handle missing data points. The following values are supported: missing, ignore, breaching and notBreaching. Defaults to missing.</summary>
    [JsonPropertyName("treatMissingData")]
    public string? TreatMissingData { get; set; }

    /// <summary>The unit for the alarm's associated metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecInitProviderMetricQueryMetric
{
    /// <summary>The dimensions for this metric.  For the list of available dimensions see the AWS documentation here.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>The name for this metric. See docs for supported metrics.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The namespace for this metric. See docs for the list of namespaces. See docs for supported metrics.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Granularity in seconds of returned data points. For metrics with regular resolution, valid values are any multiple of 60. For high-resolution metrics, valid values are 1, 5, 10, 30, or any multiple of 60.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>The statistic to apply to this metric. See docs for supported statistics.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>The unit for this metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecInitProviderMetricQuery
{
    /// <summary>The ID of the account where the metrics are located, if this is a cross-account alarm.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The math expression to be performed on the returned data, if this object is performing a math expression. This expression can use the id of the other metrics to refer to those metrics, and can also use the id of other expressions to use the result of those expressions. For more information about metric math expressions, see Metric Math Syntax and Functions in the Amazon CloudWatch User Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>A short name used to tie this object to the results in the response. If you are performing math expressions on this set of data, this name represents that data and can serve as a variable in the mathematical expression. The valid characters are letters, numbers, and underscore. The first character must be a lowercase letter.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A human-readable label for this metric or expression. This is especially useful if this is an expression, so that you know what the value represents.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The metric to be returned, along with statistics, period, and units. Use this parameter only if this object is retrieving a metric and not performing a math expression on returned data.</summary>
    [JsonPropertyName("metric")]
    public IList<V1beta1MetricAlarmSpecInitProviderMetricQueryMetric>? Metric { get; set; }

    /// <summary>Granularity in seconds of returned data points. For metrics with regular resolution, valid values are any multiple of 60. For high-resolution metrics, valid values are 1, 5, 10, 30, or any multiple of 60.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Specify exactly one metric_query to be true to use that metric_query result as the alarm.</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecInitProvider
{
    /// <summary>Indicates whether or not actions should be executed during any changes to the alarm's state. Defaults to true.</summary>
    [JsonPropertyName("actionsEnabled")]
    public bool? ActionsEnabled { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an ALARM state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("alarmActions")]
    public IList<string>? AlarmActions { get; set; }

    /// <summary>The description for the alarm.</summary>
    [JsonPropertyName("alarmDescription")]
    public string? AlarmDescription { get; set; }

    /// <summary>The arithmetic operation to use when comparing the specified Statistic and Threshold. The specified Statistic value is used as the first operand. Either of the following is supported: GreaterThanOrEqualToThreshold, GreaterThanThreshold, LessThanThreshold, LessThanOrEqualToThreshold. Additionally, the values  LessThanLowerOrGreaterThanUpperThreshold, LessThanLowerThreshold, and GreaterThanUpperThreshold are used only for alarms based on anomaly detection models.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>The number of datapoints that must be breaching to trigger the alarm.</summary>
    [JsonPropertyName("datapointsToAlarm")]
    public double? DatapointsToAlarm { get; set; }

    /// <summary>The dimensions for the alarm's associated metric.  For the list of available dimensions see the AWS documentation here.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>Used only for alarms based on percentiles. If you specify ignore, the alarm state will not change during periods with too few data points to be statistically significant. If you specify evaluate or omit this parameter, the alarm will always be evaluated and possibly change state no matter how many data points are available. The following values are supported: ignore, and evaluate.</summary>
    [JsonPropertyName("evaluateLowSampleCountPercentiles")]
    public string? EvaluateLowSampleCountPercentiles { get; set; }

    /// <summary>The number of periods over which data is compared to the specified threshold.</summary>
    [JsonPropertyName("evaluationPeriods")]
    public double? EvaluationPeriods { get; set; }

    /// <summary>The percentile statistic for the metric associated with the alarm. Specify a value between p0.0 and p100.</summary>
    [JsonPropertyName("extendedStatistic")]
    public string? ExtendedStatistic { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an INSUFFICIENT_DATA state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("insufficientDataActions")]
    public IList<string>? InsufficientDataActions { get; set; }

    /// <summary>The name for the alarm's associated metric. See docs for supported metrics.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Enables you to create an alarm based on a metric math expression. You may specify at most 20.</summary>
    [JsonPropertyName("metricQuery")]
    public IList<V1beta1MetricAlarmSpecInitProviderMetricQuery>? MetricQuery { get; set; }

    /// <summary>The namespace for the alarm's associated metric. See docs for the list of namespaces. See docs for supported metrics.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an OK state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("okActions")]
    public IList<string>? OkActions { get; set; }

    /// <summary>The period in seconds over which the specified statistic is applied. Valid values are 10, 30, or any multiple of 60.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>The statistic to apply to the alarm's associated metric. Either of the following is supported: SampleCount, Average, Sum, Minimum, Maximum</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The value against which the specified statistic is compared. This parameter is required for alarms based on static thresholds, but should not be used for alarms based on anomaly detection models.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>If this is an alarm based on an anomaly detection model, make this value match the ID of the ANOMALY_DETECTION_BAND function.</summary>
    [JsonPropertyName("thresholdMetricId")]
    public string? ThresholdMetricId { get; set; }

    /// <summary>Sets how this alarm is to handle missing data points. The following values are supported: missing, ignore, breaching and notBreaching. Defaults to missing.</summary>
    [JsonPropertyName("treatMissingData")]
    public string? TreatMissingData { get; set; }

    /// <summary>The unit for the alarm's associated metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecProviderConfigRefPolicy
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
public partial class V1beta1MetricAlarmSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetricAlarmSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1MetricAlarmSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetricAlarmSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1MetricAlarmSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1MetricAlarmSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1MetricAlarmSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MetricAlarmSpec defines the desired state of MetricAlarm</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MetricAlarmSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MetricAlarmSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MetricAlarmSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1MetricAlarmSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MetricAlarmSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmStatusAtProviderMetricQueryMetric
{
    /// <summary>The dimensions for this metric.  For the list of available dimensions see the AWS documentation here.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>The name for this metric. See docs for supported metrics.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The namespace for this metric. See docs for the list of namespaces. See docs for supported metrics.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Granularity in seconds of returned data points. For metrics with regular resolution, valid values are any multiple of 60. For high-resolution metrics, valid values are 1, 5, 10, 30, or any multiple of 60.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>The statistic to apply to this metric. See docs for supported statistics.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>The unit for this metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmStatusAtProviderMetricQuery
{
    /// <summary>The ID of the account where the metrics are located, if this is a cross-account alarm.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The math expression to be performed on the returned data, if this object is performing a math expression. This expression can use the id of the other metrics to refer to those metrics, and can also use the id of other expressions to use the result of those expressions. For more information about metric math expressions, see Metric Math Syntax and Functions in the Amazon CloudWatch User Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>A short name used to tie this object to the results in the response. If you are performing math expressions on this set of data, this name represents that data and can serve as a variable in the mathematical expression. The valid characters are letters, numbers, and underscore. The first character must be a lowercase letter.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A human-readable label for this metric or expression. This is especially useful if this is an expression, so that you know what the value represents.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The metric to be returned, along with statistics, period, and units. Use this parameter only if this object is retrieving a metric and not performing a math expression on returned data.</summary>
    [JsonPropertyName("metric")]
    public IList<V1beta1MetricAlarmStatusAtProviderMetricQueryMetric>? Metric { get; set; }

    /// <summary>Granularity in seconds of returned data points. For metrics with regular resolution, valid values are any multiple of 60. For high-resolution metrics, valid values are 1, 5, 10, 30, or any multiple of 60.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Specify exactly one metric_query to be true to use that metric_query result as the alarm.</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmStatusAtProvider
{
    /// <summary>Indicates whether or not actions should be executed during any changes to the alarm's state. Defaults to true.</summary>
    [JsonPropertyName("actionsEnabled")]
    public bool? ActionsEnabled { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an ALARM state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("alarmActions")]
    public IList<string>? AlarmActions { get; set; }

    /// <summary>The description for the alarm.</summary>
    [JsonPropertyName("alarmDescription")]
    public string? AlarmDescription { get; set; }

    /// <summary>The ARN of the CloudWatch Metric Alarm.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The arithmetic operation to use when comparing the specified Statistic and Threshold. The specified Statistic value is used as the first operand. Either of the following is supported: GreaterThanOrEqualToThreshold, GreaterThanThreshold, LessThanThreshold, LessThanOrEqualToThreshold. Additionally, the values  LessThanLowerOrGreaterThanUpperThreshold, LessThanLowerThreshold, and GreaterThanUpperThreshold are used only for alarms based on anomaly detection models.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>The number of datapoints that must be breaching to trigger the alarm.</summary>
    [JsonPropertyName("datapointsToAlarm")]
    public double? DatapointsToAlarm { get; set; }

    /// <summary>The dimensions for the alarm's associated metric.  For the list of available dimensions see the AWS documentation here.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>Used only for alarms based on percentiles. If you specify ignore, the alarm state will not change during periods with too few data points to be statistically significant. If you specify evaluate or omit this parameter, the alarm will always be evaluated and possibly change state no matter how many data points are available. The following values are supported: ignore, and evaluate.</summary>
    [JsonPropertyName("evaluateLowSampleCountPercentiles")]
    public string? EvaluateLowSampleCountPercentiles { get; set; }

    /// <summary>The number of periods over which data is compared to the specified threshold.</summary>
    [JsonPropertyName("evaluationPeriods")]
    public double? EvaluationPeriods { get; set; }

    /// <summary>The percentile statistic for the metric associated with the alarm. Specify a value between p0.0 and p100.</summary>
    [JsonPropertyName("extendedStatistic")]
    public string? ExtendedStatistic { get; set; }

    /// <summary>The ID of the health check.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an INSUFFICIENT_DATA state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("insufficientDataActions")]
    public IList<string>? InsufficientDataActions { get; set; }

    /// <summary>The name for the alarm's associated metric. See docs for supported metrics.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Enables you to create an alarm based on a metric math expression. You may specify at most 20.</summary>
    [JsonPropertyName("metricQuery")]
    public IList<V1beta1MetricAlarmStatusAtProviderMetricQuery>? MetricQuery { get; set; }

    /// <summary>The namespace for the alarm's associated metric. See docs for the list of namespaces. See docs for supported metrics.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an OK state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("okActions")]
    public IList<string>? OkActions { get; set; }

    /// <summary>The period in seconds over which the specified statistic is applied. Valid values are 10, 30, or any multiple of 60.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>The statistic to apply to the alarm's associated metric. Either of the following is supported: SampleCount, Average, Sum, Minimum, Maximum</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The value against which the specified statistic is compared. This parameter is required for alarms based on static thresholds, but should not be used for alarms based on anomaly detection models.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>If this is an alarm based on an anomaly detection model, make this value match the ID of the ANOMALY_DETECTION_BAND function.</summary>
    [JsonPropertyName("thresholdMetricId")]
    public string? ThresholdMetricId { get; set; }

    /// <summary>Sets how this alarm is to handle missing data points. The following values are supported: missing, ignore, breaching and notBreaching. Defaults to missing.</summary>
    [JsonPropertyName("treatMissingData")]
    public string? TreatMissingData { get; set; }

    /// <summary>The unit for the alarm's associated metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmStatusConditions
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

/// <summary>MetricAlarmStatus defines the observed state of MetricAlarm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MetricAlarmStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MetricAlarmStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MetricAlarm is the Schema for the MetricAlarms API. Provides a CloudWatch Metric Alarm resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MetricAlarm : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MetricAlarmSpec>, IStatus<V1beta1MetricAlarmStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MetricAlarm";
    public const string KubeGroup = "cloudwatch.aws.upbound.io";
    public const string KubePluralName = "metricalarms";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MetricAlarmSpec defines the desired state of MetricAlarm</summary>
    [JsonPropertyName("spec")]
    public V1beta1MetricAlarmSpec Spec { get; set; }

    /// <summary>MetricAlarmStatus defines the observed state of MetricAlarm.</summary>
    [JsonPropertyName("status")]
    public V1beta1MetricAlarmStatus? Status { get; set; }
}