using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.monitoring.gcp.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderAlertStrategyNotificationChannelStrategy
{
    /// <summary>The notification channels that these settings apply to. Each of these correspond to the name field in one of the NotificationChannel objects referenced in the notification_channels field of this AlertPolicy. The format is projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]</summary>
    [JsonPropertyName("notificationChannelNames")]
    public IList<string>? NotificationChannelNames { get; set; }

    /// <summary>The frequency at which to send reminder notifications for open incidents.</summary>
    [JsonPropertyName("renotifyInterval")]
    public string? RenotifyInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderAlertStrategyNotificationRateLimit
{
    /// <summary>Not more than one notification per period.</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderAlertStrategy
{
    /// <summary>If an alert policy that was active has no data for this long, any open incidents will close.</summary>
    [JsonPropertyName("autoClose")]
    public string? AutoClose { get; set; }

    /// <summary>Control over how the notification channels in notification_channels are notified when this alert fires, on a per-channel basis. Structure is documented below.</summary>
    [JsonPropertyName("notificationChannelStrategy")]
    public IList<V1beta1AlertPolicySpecForProviderAlertStrategyNotificationChannelStrategy>? NotificationChannelStrategy { get; set; }

    /// <summary>Required for alert policies with a LogMatch condition. This limit is not implemented for alert policies that are not log-based. Structure is documented below.</summary>
    [JsonPropertyName("notificationRateLimit")]
    public IList<V1beta1AlertPolicySpecForProviderAlertStrategyNotificationRateLimit>? NotificationRateLimit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderConditionsConditionAbsentAggregations
{
    /// <summary>The alignment period for per-time series alignment. If present, alignmentPeriod must be at least 60 seconds. After per-time series alignment, each time series will contain data points only on the period boundaries. If perSeriesAligner is not specified or equals ALIGN_NONE, then this field is ignored. If perSeriesAligner is specified and does not equal ALIGN_NONE, then this field must be defined; otherwise an error is returned.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The approach to be used to combine time series. Not all reducer functions may be applied to all time series, depending on the metric type and the value type of the original time series. Reduction may change the metric type of value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when crossSeriesReducer is specified. The groupByFields determine how the time series are partitioned into subsets prior to applying the aggregation function. Each subset contains time series that have the same value for each of the grouping fields. Each individual time series is a member of exactly one subset. The crossSeriesReducer is applied to each subset of time series. It is not possible to reduce across different resource types, so this field implicitly contains resource.type. Fields not specified in groupByFields are aggregated away. If groupByFields is not specified and all the time series have the same resource type, then the time series are aggregated into a single output time series. If crossSeriesReducer is not defined, this field is ignored.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>The approach to be used to align individual time series. Not all alignment functions may be applied to all time series, depending on the metric type and value type of the original time series. Alignment may change the metric type or the value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderConditionsConditionAbsentTrigger
{
    /// <summary>The absolute number of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The percentage of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderConditionsConditionAbsent
{
    /// <summary>Specifies the alignment of data points in individual time series as well as how to combine the retrieved time series together (such as when aggregating multiple streams on each resource to a single stream for each resource or when aggregating streams across all members of a group of resources). Multiple aggregations are applied in the order specified.This field is similar to the one in the MetricService.ListTimeSeries request. It is advisable to use the ListTimeSeries method when debugging this field. Structure is documented below.</summary>
    [JsonPropertyName("aggregations")]
    public IList<V1beta1AlertPolicySpecForProviderConditionsConditionAbsentAggregations>? Aggregations { get; set; }

    /// <summary>The amount of time that a time series must violate the threshold to be considered failing. Currently, only values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of the underlying time series data (which may also be affected by any alignments specified in the aggregations field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short enough that unhealthy states are detected and alerted on quickly.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>A filter that identifies which time series should be compared with the threshold.The filter is similar to the one that is specified in the MetricService.ListTimeSeries request (that call is useful to verify the time series that will be retrieved / processed) and must specify the metric type and optionally may contain restrictions on resource type, resource labels, and metric labels. This field may not exceed 2048 Unicode characters in length.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The number/percent of time series for which the comparison must hold in order for the condition to trigger. If unspecified, then the condition will trigger if the comparison is true for any of the time series that have been identified by filter and aggregations, or by the ratio, if denominator_filter and denominator_aggregations are specified. Structure is documented below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1AlertPolicySpecForProviderConditionsConditionAbsentTrigger>? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderConditionsConditionMatchedLog
{
    /// <summary>A filter that identifies which time series should be compared with the threshold.The filter is similar to the one that is specified in the MetricService.ListTimeSeries request (that call is useful to verify the time series that will be retrieved / processed) and must specify the metric type and optionally may contain restrictions on resource type, resource labels, and metric labels. This field may not exceed 2048 Unicode characters in length.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>A map from a label key to an extractor expression, which is used to extract the value for this label key. Each entry in this map is a specification for how data should be extracted from log entries that match filter. Each combination of extracted values is treated as a separate rule for the purposes of triggering notifications. Label keys and corresponding values can be used in notifications generated by this condition.</summary>
    [JsonPropertyName("labelExtractors")]
    public IDictionary<string, string>? LabelExtractors { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderConditionsConditionMonitoringQueryLanguageTrigger
{
    /// <summary>The absolute number of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The percentage of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderConditionsConditionMonitoringQueryLanguage
{
    /// <summary>The amount of time that a time series must violate the threshold to be considered failing. Currently, only values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of the underlying time series data (which may also be affected by any alignments specified in the aggregations field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short enough that unhealthy states are detected and alerted on quickly.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>A condition control that determines how metric-threshold conditions are evaluated when data stops arriving. Possible values are: EVALUATION_MISSING_DATA_INACTIVE, EVALUATION_MISSING_DATA_ACTIVE, EVALUATION_MISSING_DATA_NO_OP.</summary>
    [JsonPropertyName("evaluationMissingData")]
    public string? EvaluationMissingData { get; set; }

    /// <summary>The PromQL expression to evaluate. Every evaluation cycle this expression is evaluated at the current time, and all resultant time series become pending/firing alerts. This field must not be empty.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The number/percent of time series for which the comparison must hold in order for the condition to trigger. If unspecified, then the condition will trigger if the comparison is true for any of the time series that have been identified by filter and aggregations, or by the ratio, if denominator_filter and denominator_aggregations are specified. Structure is documented below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1AlertPolicySpecForProviderConditionsConditionMonitoringQueryLanguageTrigger>? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderConditionsConditionPrometheusQueryLanguage
{
    /// <summary>The alerting rule name of this alert in the corresponding Prometheus configuration file. Some external tools may require this field to be populated correctly in order to refer to the original Prometheus configuration file. The rule group name and the alert name are necessary to update the relevant AlertPolicies in case the definition of the rule group changes in the future. This field is optional. If this field is not empty, then it must be a valid Prometheus label name.</summary>
    [JsonPropertyName("alertRule")]
    public string? AlertRule { get; set; }

    /// <summary>The amount of time that a time series must violate the threshold to be considered failing. Currently, only values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of the underlying time series data (which may also be affected by any alignments specified in the aggregations field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short enough that unhealthy states are detected and alerted on quickly.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>How often this rule should be evaluated. Must be a positive multiple of 30 seconds or missing. The default value is 30 seconds. If this PrometheusQueryLanguageCondition was generated from a Prometheus alerting rule, then this value should be taken from the enclosing rule group.</summary>
    [JsonPropertyName("evaluationInterval")]
    public string? EvaluationInterval { get; set; }

    /// <summary>Labels to add to or overwrite in the PromQL query result. Label names must be valid. Label values can be templatized by using variables. The only available variable names are the names of the labels in the PromQL result, including "name" and "value". "labels" may be empty. This field is intended to be used for organizing and identifying the AlertPolicy</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The PromQL expression to evaluate. Every evaluation cycle this expression is evaluated at the current time, and all resultant time series become pending/firing alerts. This field must not be empty.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The rule group name of this alert in the corresponding Prometheus configuration file. Some external tools may require this field to be populated correctly in order to refer to the original Prometheus configuration file. The rule group name and the alert name are necessary to update the relevant AlertPolicies in case the definition of the rule group changes in the future. This field is optional.</summary>
    [JsonPropertyName("ruleGroup")]
    public string? RuleGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderConditionsConditionThresholdAggregations
{
    /// <summary>The alignment period for per-time series alignment. If present, alignmentPeriod must be at least 60 seconds. After per-time series alignment, each time series will contain data points only on the period boundaries. If perSeriesAligner is not specified or equals ALIGN_NONE, then this field is ignored. If perSeriesAligner is specified and does not equal ALIGN_NONE, then this field must be defined; otherwise an error is returned.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The approach to be used to combine time series. Not all reducer functions may be applied to all time series, depending on the metric type and the value type of the original time series. Reduction may change the metric type of value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when crossSeriesReducer is specified. The groupByFields determine how the time series are partitioned into subsets prior to applying the aggregation function. Each subset contains time series that have the same value for each of the grouping fields. Each individual time series is a member of exactly one subset. The crossSeriesReducer is applied to each subset of time series. It is not possible to reduce across different resource types, so this field implicitly contains resource.type. Fields not specified in groupByFields are aggregated away. If groupByFields is not specified and all the time series have the same resource type, then the time series are aggregated into a single output time series. If crossSeriesReducer is not defined, this field is ignored.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>The approach to be used to align individual time series. Not all alignment functions may be applied to all time series, depending on the metric type and value type of the original time series. Alignment may change the metric type or the value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderConditionsConditionThresholdDenominatorAggregations
{
    /// <summary>The alignment period for per-time series alignment. If present, alignmentPeriod must be at least 60 seconds. After per-time series alignment, each time series will contain data points only on the period boundaries. If perSeriesAligner is not specified or equals ALIGN_NONE, then this field is ignored. If perSeriesAligner is specified and does not equal ALIGN_NONE, then this field must be defined; otherwise an error is returned.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The approach to be used to combine time series. Not all reducer functions may be applied to all time series, depending on the metric type and the value type of the original time series. Reduction may change the metric type of value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when crossSeriesReducer is specified. The groupByFields determine how the time series are partitioned into subsets prior to applying the aggregation function. Each subset contains time series that have the same value for each of the grouping fields. Each individual time series is a member of exactly one subset. The crossSeriesReducer is applied to each subset of time series. It is not possible to reduce across different resource types, so this field implicitly contains resource.type. Fields not specified in groupByFields are aggregated away. If groupByFields is not specified and all the time series have the same resource type, then the time series are aggregated into a single output time series. If crossSeriesReducer is not defined, this field is ignored.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>The approach to be used to align individual time series. Not all alignment functions may be applied to all time series, depending on the metric type and value type of the original time series. Alignment may change the metric type or the value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderConditionsConditionThresholdForecastOptions
{
    /// <summary>The length of time into the future to forecast whether a timeseries will violate the threshold. If the predicted value is found to violate the threshold, and the violation is observed in all forecasts made for the Configured duration, then the timeseries is considered to be failing.</summary>
    [JsonPropertyName("forecastHorizon")]
    public string? ForecastHorizon { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderConditionsConditionThresholdTrigger
{
    /// <summary>The absolute number of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The percentage of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderConditionsConditionThreshold
{
    /// <summary>Specifies the alignment of data points in individual time series as well as how to combine the retrieved time series together (such as when aggregating multiple streams on each resource to a single stream for each resource or when aggregating streams across all members of a group of resources). Multiple aggregations are applied in the order specified.This field is similar to the one in the MetricService.ListTimeSeries request. It is advisable to use the ListTimeSeries method when debugging this field. Structure is documented below.</summary>
    [JsonPropertyName("aggregations")]
    public IList<V1beta1AlertPolicySpecForProviderConditionsConditionThresholdAggregations>? Aggregations { get; set; }

    /// <summary>The comparison to apply between the time series (indicated by filter and aggregation) and the threshold (indicated by threshold_value). The comparison is applied on each time series, with the time series on the left-hand side and the threshold on the right-hand side. Only COMPARISON_LT and COMPARISON_GT are supported currently. Possible values are: COMPARISON_GT, COMPARISON_GE, COMPARISON_LT, COMPARISON_LE, COMPARISON_EQ, COMPARISON_NE.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>Specifies the alignment of data points in individual time series selected by denominatorFilter as well as how to combine the retrieved time series together (such as when aggregating multiple streams on each resource to a single stream for each resource or when aggregating streams across all members of a group of resources).When computing ratios, the aggregations and denominator_aggregations fields must use the same alignment period and produce time series that have the same periodicity and labels.This field is similar to the one in the MetricService.ListTimeSeries request. It is advisable to use the ListTimeSeries method when debugging this field. Structure is documented below.</summary>
    [JsonPropertyName("denominatorAggregations")]
    public IList<V1beta1AlertPolicySpecForProviderConditionsConditionThresholdDenominatorAggregations>? DenominatorAggregations { get; set; }

    /// <summary>A filter that identifies a time series that should be used as the denominator of a ratio that will be compared with the threshold. If a denominator_filter is specified, the time series specified by the filter field will be used as the numerator.The filter is similar to the one that is specified in the MetricService.ListTimeSeries request (that call is useful to verify the time series that will be retrieved / processed) and must specify the metric type and optionally may contain restrictions on resource type, resource labels, and metric labels. This field may not exceed 2048 Unicode characters in length.</summary>
    [JsonPropertyName("denominatorFilter")]
    public string? DenominatorFilter { get; set; }

    /// <summary>The amount of time that a time series must violate the threshold to be considered failing. Currently, only values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of the underlying time series data (which may also be affected by any alignments specified in the aggregations field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short enough that unhealthy states are detected and alerted on quickly.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>A condition control that determines how metric-threshold conditions are evaluated when data stops arriving. Possible values are: EVALUATION_MISSING_DATA_INACTIVE, EVALUATION_MISSING_DATA_ACTIVE, EVALUATION_MISSING_DATA_NO_OP.</summary>
    [JsonPropertyName("evaluationMissingData")]
    public string? EvaluationMissingData { get; set; }

    /// <summary>A filter that identifies which time series should be compared with the threshold.The filter is similar to the one that is specified in the MetricService.ListTimeSeries request (that call is useful to verify the time series that will be retrieved / processed) and must specify the metric type and optionally may contain restrictions on resource type, resource labels, and metric labels. This field may not exceed 2048 Unicode characters in length.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>When this field is present, the MetricThreshold condition forecasts whether the time series is predicted to violate the threshold within the forecastHorizon. When this field is not set, the MetricThreshold tests the current value of the timeseries against the threshold. Structure is documented below.</summary>
    [JsonPropertyName("forecastOptions")]
    public IList<V1beta1AlertPolicySpecForProviderConditionsConditionThresholdForecastOptions>? ForecastOptions { get; set; }

    /// <summary>A value against which to compare the time series.</summary>
    [JsonPropertyName("thresholdValue")]
    public double? ThresholdValue { get; set; }

    /// <summary>The number/percent of time series for which the comparison must hold in order for the condition to trigger. If unspecified, then the condition will trigger if the comparison is true for any of the time series that have been identified by filter and aggregations, or by the ratio, if denominator_filter and denominator_aggregations are specified. Structure is documented below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1AlertPolicySpecForProviderConditionsConditionThresholdTrigger>? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderConditions
{
    /// <summary>A condition that checks that a time series continues to receive new data points. Structure is documented below.</summary>
    [JsonPropertyName("conditionAbsent")]
    public IList<V1beta1AlertPolicySpecForProviderConditionsConditionAbsent>? ConditionAbsent { get; set; }

    /// <summary>A condition that checks for log messages matching given constraints. If set, no other conditions can be present. Structure is documented below.</summary>
    [JsonPropertyName("conditionMatchedLog")]
    public IList<V1beta1AlertPolicySpecForProviderConditionsConditionMatchedLog>? ConditionMatchedLog { get; set; }

    /// <summary>A Monitoring Query Language query that outputs a boolean stream Structure is documented below.</summary>
    [JsonPropertyName("conditionMonitoringQueryLanguage")]
    public IList<V1beta1AlertPolicySpecForProviderConditionsConditionMonitoringQueryLanguage>? ConditionMonitoringQueryLanguage { get; set; }

    /// <summary>A condition type that allows alert policies to be defined using Prometheus Query Language (PromQL). The PrometheusQueryLanguageCondition message contains information from a Prometheus alerting rule and its associated rule group. Structure is documented below.</summary>
    [JsonPropertyName("conditionPrometheusQueryLanguage")]
    public IList<V1beta1AlertPolicySpecForProviderConditionsConditionPrometheusQueryLanguage>? ConditionPrometheusQueryLanguage { get; set; }

    /// <summary>A condition that compares a time series against a threshold. Structure is documented below.</summary>
    [JsonPropertyName("conditionThreshold")]
    public IList<V1beta1AlertPolicySpecForProviderConditionsConditionThreshold>? ConditionThreshold { get; set; }

    /// <summary>A short name or phrase used to identify the condition in dashboards, notifications, and incidents. To avoid confusion, don't use the same display name for multiple conditions in the same policy.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderDocumentationLinks
{
    /// <summary>A short display name for the link. The display name must not be empty or exceed 63 characters. Example: "playbook".</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The url of a webpage. A url can be templatized by using variables in the path or the query parameters. The total length of a URL should not exceed 2083 characters before and after variable expansion. Example: "https://my_domain.com/playbook?name=${resource.name}".</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProviderDocumentation
{
    /// <summary>The text of the documentation, interpreted according to mimeType. The content may not exceed 8,192 Unicode characters and may not exceed more than 10,240 bytes when encoded in UTF-8 format, whichever is smaller.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Links to content such as playbooks, repositories, and other resources. This field can contain up to 3 entries. Structure is documented below.</summary>
    [JsonPropertyName("links")]
    public IList<V1beta1AlertPolicySpecForProviderDocumentationLinks>? Links { get; set; }

    /// <summary>The format of the content field. Presently, only the value "text/markdown" is supported.</summary>
    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }

    /// <summary>The subject line of the notification. The subject line may not exceed 10,240 bytes. In notifications generated by this policy the contents of the subject line after variable expansion will be truncated to 255 bytes or shorter at the latest UTF-8 character boundary.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecForProvider
{
    /// <summary>Control over how this alert policy's notification channels are notified. Structure is documented below.</summary>
    [JsonPropertyName("alertStrategy")]
    public IList<V1beta1AlertPolicySpecForProviderAlertStrategy>? AlertStrategy { get; set; }

    /// <summary>How to combine the results of multiple conditions to determine if an incident should be opened. Possible values are: AND, OR, AND_WITH_MATCHING_RESOURCE.</summary>
    [JsonPropertyName("combiner")]
    public string? Combiner { get; set; }

    /// <summary>A list of conditions for the policy. The conditions are combined by AND or OR according to the combiner field. If the combined conditions evaluate to true, then an incident is created. A policy can have from one to six conditions. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AlertPolicySpecForProviderConditions>? Conditions { get; set; }

    /// <summary>A short name or phrase used to identify the policy in dashboards, notifications, and incidents. To avoid confusion, don't use the same display name for multiple policies in the same project. The name is limited to 512 Unicode characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Documentation that is included with notifications and incidents related to this policy. Best practice is for the documentation to include information to help responders understand, mitigate, escalate, and correct the underlying problems detected by the alerting policy. Notification channels that have limited capacity might not show this documentation. Structure is documented below.</summary>
    [JsonPropertyName("documentation")]
    public IList<V1beta1AlertPolicySpecForProviderDocumentation>? Documentation { get; set; }

    /// <summary>Whether or not the policy is enabled. The default is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Identifies the notification channels to which notifications should be sent when incidents are opened or closed or when new violations occur on an already opened incident. Each element of this array corresponds to the name field in each of the NotificationChannel objects that are returned from the notificationChannels.list method. The syntax of the entries in this field is projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]</summary>
    [JsonPropertyName("notificationChannels")]
    public IList<string>? NotificationChannels { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The severity of an alert policy indicates how important incidents generated by that policy are. The severity level will be displayed on the Incident detail page and in notifications. Possible values are: CRITICAL, ERROR, WARNING.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>This field is intended to be used for organizing and identifying the AlertPolicy objects.The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.</summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderAlertStrategyNotificationChannelStrategy
{
    /// <summary>The notification channels that these settings apply to. Each of these correspond to the name field in one of the NotificationChannel objects referenced in the notification_channels field of this AlertPolicy. The format is projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]</summary>
    [JsonPropertyName("notificationChannelNames")]
    public IList<string>? NotificationChannelNames { get; set; }

    /// <summary>The frequency at which to send reminder notifications for open incidents.</summary>
    [JsonPropertyName("renotifyInterval")]
    public string? RenotifyInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderAlertStrategyNotificationRateLimit
{
    /// <summary>Not more than one notification per period.</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderAlertStrategy
{
    /// <summary>If an alert policy that was active has no data for this long, any open incidents will close.</summary>
    [JsonPropertyName("autoClose")]
    public string? AutoClose { get; set; }

    /// <summary>Control over how the notification channels in notification_channels are notified when this alert fires, on a per-channel basis. Structure is documented below.</summary>
    [JsonPropertyName("notificationChannelStrategy")]
    public IList<V1beta1AlertPolicySpecInitProviderAlertStrategyNotificationChannelStrategy>? NotificationChannelStrategy { get; set; }

    /// <summary>Required for alert policies with a LogMatch condition. This limit is not implemented for alert policies that are not log-based. Structure is documented below.</summary>
    [JsonPropertyName("notificationRateLimit")]
    public IList<V1beta1AlertPolicySpecInitProviderAlertStrategyNotificationRateLimit>? NotificationRateLimit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderConditionsConditionAbsentAggregations
{
    /// <summary>The alignment period for per-time series alignment. If present, alignmentPeriod must be at least 60 seconds. After per-time series alignment, each time series will contain data points only on the period boundaries. If perSeriesAligner is not specified or equals ALIGN_NONE, then this field is ignored. If perSeriesAligner is specified and does not equal ALIGN_NONE, then this field must be defined; otherwise an error is returned.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The approach to be used to combine time series. Not all reducer functions may be applied to all time series, depending on the metric type and the value type of the original time series. Reduction may change the metric type of value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when crossSeriesReducer is specified. The groupByFields determine how the time series are partitioned into subsets prior to applying the aggregation function. Each subset contains time series that have the same value for each of the grouping fields. Each individual time series is a member of exactly one subset. The crossSeriesReducer is applied to each subset of time series. It is not possible to reduce across different resource types, so this field implicitly contains resource.type. Fields not specified in groupByFields are aggregated away. If groupByFields is not specified and all the time series have the same resource type, then the time series are aggregated into a single output time series. If crossSeriesReducer is not defined, this field is ignored.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>The approach to be used to align individual time series. Not all alignment functions may be applied to all time series, depending on the metric type and value type of the original time series. Alignment may change the metric type or the value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderConditionsConditionAbsentTrigger
{
    /// <summary>The absolute number of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The percentage of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderConditionsConditionAbsent
{
    /// <summary>Specifies the alignment of data points in individual time series as well as how to combine the retrieved time series together (such as when aggregating multiple streams on each resource to a single stream for each resource or when aggregating streams across all members of a group of resources). Multiple aggregations are applied in the order specified.This field is similar to the one in the MetricService.ListTimeSeries request. It is advisable to use the ListTimeSeries method when debugging this field. Structure is documented below.</summary>
    [JsonPropertyName("aggregations")]
    public IList<V1beta1AlertPolicySpecInitProviderConditionsConditionAbsentAggregations>? Aggregations { get; set; }

    /// <summary>The amount of time that a time series must violate the threshold to be considered failing. Currently, only values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of the underlying time series data (which may also be affected by any alignments specified in the aggregations field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short enough that unhealthy states are detected and alerted on quickly.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>A filter that identifies which time series should be compared with the threshold.The filter is similar to the one that is specified in the MetricService.ListTimeSeries request (that call is useful to verify the time series that will be retrieved / processed) and must specify the metric type and optionally may contain restrictions on resource type, resource labels, and metric labels. This field may not exceed 2048 Unicode characters in length.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The number/percent of time series for which the comparison must hold in order for the condition to trigger. If unspecified, then the condition will trigger if the comparison is true for any of the time series that have been identified by filter and aggregations, or by the ratio, if denominator_filter and denominator_aggregations are specified. Structure is documented below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1AlertPolicySpecInitProviderConditionsConditionAbsentTrigger>? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderConditionsConditionMatchedLog
{
    /// <summary>A filter that identifies which time series should be compared with the threshold.The filter is similar to the one that is specified in the MetricService.ListTimeSeries request (that call is useful to verify the time series that will be retrieved / processed) and must specify the metric type and optionally may contain restrictions on resource type, resource labels, and metric labels. This field may not exceed 2048 Unicode characters in length.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>A map from a label key to an extractor expression, which is used to extract the value for this label key. Each entry in this map is a specification for how data should be extracted from log entries that match filter. Each combination of extracted values is treated as a separate rule for the purposes of triggering notifications. Label keys and corresponding values can be used in notifications generated by this condition.</summary>
    [JsonPropertyName("labelExtractors")]
    public IDictionary<string, string>? LabelExtractors { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderConditionsConditionMonitoringQueryLanguageTrigger
{
    /// <summary>The absolute number of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The percentage of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderConditionsConditionMonitoringQueryLanguage
{
    /// <summary>The amount of time that a time series must violate the threshold to be considered failing. Currently, only values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of the underlying time series data (which may also be affected by any alignments specified in the aggregations field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short enough that unhealthy states are detected and alerted on quickly.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>A condition control that determines how metric-threshold conditions are evaluated when data stops arriving. Possible values are: EVALUATION_MISSING_DATA_INACTIVE, EVALUATION_MISSING_DATA_ACTIVE, EVALUATION_MISSING_DATA_NO_OP.</summary>
    [JsonPropertyName("evaluationMissingData")]
    public string? EvaluationMissingData { get; set; }

    /// <summary>The PromQL expression to evaluate. Every evaluation cycle this expression is evaluated at the current time, and all resultant time series become pending/firing alerts. This field must not be empty.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The number/percent of time series for which the comparison must hold in order for the condition to trigger. If unspecified, then the condition will trigger if the comparison is true for any of the time series that have been identified by filter and aggregations, or by the ratio, if denominator_filter and denominator_aggregations are specified. Structure is documented below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1AlertPolicySpecInitProviderConditionsConditionMonitoringQueryLanguageTrigger>? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderConditionsConditionPrometheusQueryLanguage
{
    /// <summary>The alerting rule name of this alert in the corresponding Prometheus configuration file. Some external tools may require this field to be populated correctly in order to refer to the original Prometheus configuration file. The rule group name and the alert name are necessary to update the relevant AlertPolicies in case the definition of the rule group changes in the future. This field is optional. If this field is not empty, then it must be a valid Prometheus label name.</summary>
    [JsonPropertyName("alertRule")]
    public string? AlertRule { get; set; }

    /// <summary>The amount of time that a time series must violate the threshold to be considered failing. Currently, only values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of the underlying time series data (which may also be affected by any alignments specified in the aggregations field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short enough that unhealthy states are detected and alerted on quickly.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>How often this rule should be evaluated. Must be a positive multiple of 30 seconds or missing. The default value is 30 seconds. If this PrometheusQueryLanguageCondition was generated from a Prometheus alerting rule, then this value should be taken from the enclosing rule group.</summary>
    [JsonPropertyName("evaluationInterval")]
    public string? EvaluationInterval { get; set; }

    /// <summary>Labels to add to or overwrite in the PromQL query result. Label names must be valid. Label values can be templatized by using variables. The only available variable names are the names of the labels in the PromQL result, including "name" and "value". "labels" may be empty. This field is intended to be used for organizing and identifying the AlertPolicy</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The PromQL expression to evaluate. Every evaluation cycle this expression is evaluated at the current time, and all resultant time series become pending/firing alerts. This field must not be empty.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The rule group name of this alert in the corresponding Prometheus configuration file. Some external tools may require this field to be populated correctly in order to refer to the original Prometheus configuration file. The rule group name and the alert name are necessary to update the relevant AlertPolicies in case the definition of the rule group changes in the future. This field is optional.</summary>
    [JsonPropertyName("ruleGroup")]
    public string? RuleGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderConditionsConditionThresholdAggregations
{
    /// <summary>The alignment period for per-time series alignment. If present, alignmentPeriod must be at least 60 seconds. After per-time series alignment, each time series will contain data points only on the period boundaries. If perSeriesAligner is not specified or equals ALIGN_NONE, then this field is ignored. If perSeriesAligner is specified and does not equal ALIGN_NONE, then this field must be defined; otherwise an error is returned.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The approach to be used to combine time series. Not all reducer functions may be applied to all time series, depending on the metric type and the value type of the original time series. Reduction may change the metric type of value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when crossSeriesReducer is specified. The groupByFields determine how the time series are partitioned into subsets prior to applying the aggregation function. Each subset contains time series that have the same value for each of the grouping fields. Each individual time series is a member of exactly one subset. The crossSeriesReducer is applied to each subset of time series. It is not possible to reduce across different resource types, so this field implicitly contains resource.type. Fields not specified in groupByFields are aggregated away. If groupByFields is not specified and all the time series have the same resource type, then the time series are aggregated into a single output time series. If crossSeriesReducer is not defined, this field is ignored.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>The approach to be used to align individual time series. Not all alignment functions may be applied to all time series, depending on the metric type and value type of the original time series. Alignment may change the metric type or the value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderConditionsConditionThresholdDenominatorAggregations
{
    /// <summary>The alignment period for per-time series alignment. If present, alignmentPeriod must be at least 60 seconds. After per-time series alignment, each time series will contain data points only on the period boundaries. If perSeriesAligner is not specified or equals ALIGN_NONE, then this field is ignored. If perSeriesAligner is specified and does not equal ALIGN_NONE, then this field must be defined; otherwise an error is returned.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The approach to be used to combine time series. Not all reducer functions may be applied to all time series, depending on the metric type and the value type of the original time series. Reduction may change the metric type of value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when crossSeriesReducer is specified. The groupByFields determine how the time series are partitioned into subsets prior to applying the aggregation function. Each subset contains time series that have the same value for each of the grouping fields. Each individual time series is a member of exactly one subset. The crossSeriesReducer is applied to each subset of time series. It is not possible to reduce across different resource types, so this field implicitly contains resource.type. Fields not specified in groupByFields are aggregated away. If groupByFields is not specified and all the time series have the same resource type, then the time series are aggregated into a single output time series. If crossSeriesReducer is not defined, this field is ignored.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>The approach to be used to align individual time series. Not all alignment functions may be applied to all time series, depending on the metric type and value type of the original time series. Alignment may change the metric type or the value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderConditionsConditionThresholdForecastOptions
{
    /// <summary>The length of time into the future to forecast whether a timeseries will violate the threshold. If the predicted value is found to violate the threshold, and the violation is observed in all forecasts made for the Configured duration, then the timeseries is considered to be failing.</summary>
    [JsonPropertyName("forecastHorizon")]
    public string? ForecastHorizon { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderConditionsConditionThresholdTrigger
{
    /// <summary>The absolute number of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The percentage of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderConditionsConditionThreshold
{
    /// <summary>Specifies the alignment of data points in individual time series as well as how to combine the retrieved time series together (such as when aggregating multiple streams on each resource to a single stream for each resource or when aggregating streams across all members of a group of resources). Multiple aggregations are applied in the order specified.This field is similar to the one in the MetricService.ListTimeSeries request. It is advisable to use the ListTimeSeries method when debugging this field. Structure is documented below.</summary>
    [JsonPropertyName("aggregations")]
    public IList<V1beta1AlertPolicySpecInitProviderConditionsConditionThresholdAggregations>? Aggregations { get; set; }

    /// <summary>The comparison to apply between the time series (indicated by filter and aggregation) and the threshold (indicated by threshold_value). The comparison is applied on each time series, with the time series on the left-hand side and the threshold on the right-hand side. Only COMPARISON_LT and COMPARISON_GT are supported currently. Possible values are: COMPARISON_GT, COMPARISON_GE, COMPARISON_LT, COMPARISON_LE, COMPARISON_EQ, COMPARISON_NE.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>Specifies the alignment of data points in individual time series selected by denominatorFilter as well as how to combine the retrieved time series together (such as when aggregating multiple streams on each resource to a single stream for each resource or when aggregating streams across all members of a group of resources).When computing ratios, the aggregations and denominator_aggregations fields must use the same alignment period and produce time series that have the same periodicity and labels.This field is similar to the one in the MetricService.ListTimeSeries request. It is advisable to use the ListTimeSeries method when debugging this field. Structure is documented below.</summary>
    [JsonPropertyName("denominatorAggregations")]
    public IList<V1beta1AlertPolicySpecInitProviderConditionsConditionThresholdDenominatorAggregations>? DenominatorAggregations { get; set; }

    /// <summary>A filter that identifies a time series that should be used as the denominator of a ratio that will be compared with the threshold. If a denominator_filter is specified, the time series specified by the filter field will be used as the numerator.The filter is similar to the one that is specified in the MetricService.ListTimeSeries request (that call is useful to verify the time series that will be retrieved / processed) and must specify the metric type and optionally may contain restrictions on resource type, resource labels, and metric labels. This field may not exceed 2048 Unicode characters in length.</summary>
    [JsonPropertyName("denominatorFilter")]
    public string? DenominatorFilter { get; set; }

    /// <summary>The amount of time that a time series must violate the threshold to be considered failing. Currently, only values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of the underlying time series data (which may also be affected by any alignments specified in the aggregations field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short enough that unhealthy states are detected and alerted on quickly.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>A condition control that determines how metric-threshold conditions are evaluated when data stops arriving. Possible values are: EVALUATION_MISSING_DATA_INACTIVE, EVALUATION_MISSING_DATA_ACTIVE, EVALUATION_MISSING_DATA_NO_OP.</summary>
    [JsonPropertyName("evaluationMissingData")]
    public string? EvaluationMissingData { get; set; }

    /// <summary>A filter that identifies which time series should be compared with the threshold.The filter is similar to the one that is specified in the MetricService.ListTimeSeries request (that call is useful to verify the time series that will be retrieved / processed) and must specify the metric type and optionally may contain restrictions on resource type, resource labels, and metric labels. This field may not exceed 2048 Unicode characters in length.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>When this field is present, the MetricThreshold condition forecasts whether the time series is predicted to violate the threshold within the forecastHorizon. When this field is not set, the MetricThreshold tests the current value of the timeseries against the threshold. Structure is documented below.</summary>
    [JsonPropertyName("forecastOptions")]
    public IList<V1beta1AlertPolicySpecInitProviderConditionsConditionThresholdForecastOptions>? ForecastOptions { get; set; }

    /// <summary>A value against which to compare the time series.</summary>
    [JsonPropertyName("thresholdValue")]
    public double? ThresholdValue { get; set; }

    /// <summary>The number/percent of time series for which the comparison must hold in order for the condition to trigger. If unspecified, then the condition will trigger if the comparison is true for any of the time series that have been identified by filter and aggregations, or by the ratio, if denominator_filter and denominator_aggregations are specified. Structure is documented below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1AlertPolicySpecInitProviderConditionsConditionThresholdTrigger>? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderConditions
{
    /// <summary>A condition that checks that a time series continues to receive new data points. Structure is documented below.</summary>
    [JsonPropertyName("conditionAbsent")]
    public IList<V1beta1AlertPolicySpecInitProviderConditionsConditionAbsent>? ConditionAbsent { get; set; }

    /// <summary>A condition that checks for log messages matching given constraints. If set, no other conditions can be present. Structure is documented below.</summary>
    [JsonPropertyName("conditionMatchedLog")]
    public IList<V1beta1AlertPolicySpecInitProviderConditionsConditionMatchedLog>? ConditionMatchedLog { get; set; }

    /// <summary>A Monitoring Query Language query that outputs a boolean stream Structure is documented below.</summary>
    [JsonPropertyName("conditionMonitoringQueryLanguage")]
    public IList<V1beta1AlertPolicySpecInitProviderConditionsConditionMonitoringQueryLanguage>? ConditionMonitoringQueryLanguage { get; set; }

    /// <summary>A condition type that allows alert policies to be defined using Prometheus Query Language (PromQL). The PrometheusQueryLanguageCondition message contains information from a Prometheus alerting rule and its associated rule group. Structure is documented below.</summary>
    [JsonPropertyName("conditionPrometheusQueryLanguage")]
    public IList<V1beta1AlertPolicySpecInitProviderConditionsConditionPrometheusQueryLanguage>? ConditionPrometheusQueryLanguage { get; set; }

    /// <summary>A condition that compares a time series against a threshold. Structure is documented below.</summary>
    [JsonPropertyName("conditionThreshold")]
    public IList<V1beta1AlertPolicySpecInitProviderConditionsConditionThreshold>? ConditionThreshold { get; set; }

    /// <summary>A short name or phrase used to identify the condition in dashboards, notifications, and incidents. To avoid confusion, don't use the same display name for multiple conditions in the same policy.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderDocumentationLinks
{
    /// <summary>A short display name for the link. The display name must not be empty or exceed 63 characters. Example: "playbook".</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The url of a webpage. A url can be templatized by using variables in the path or the query parameters. The total length of a URL should not exceed 2083 characters before and after variable expansion. Example: "https://my_domain.com/playbook?name=${resource.name}".</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProviderDocumentation
{
    /// <summary>The text of the documentation, interpreted according to mimeType. The content may not exceed 8,192 Unicode characters and may not exceed more than 10,240 bytes when encoded in UTF-8 format, whichever is smaller.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Links to content such as playbooks, repositories, and other resources. This field can contain up to 3 entries. Structure is documented below.</summary>
    [JsonPropertyName("links")]
    public IList<V1beta1AlertPolicySpecInitProviderDocumentationLinks>? Links { get; set; }

    /// <summary>The format of the content field. Presently, only the value "text/markdown" is supported.</summary>
    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }

    /// <summary>The subject line of the notification. The subject line may not exceed 10,240 bytes. In notifications generated by this policy the contents of the subject line after variable expansion will be truncated to 255 bytes or shorter at the latest UTF-8 character boundary.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecInitProvider
{
    /// <summary>Control over how this alert policy's notification channels are notified. Structure is documented below.</summary>
    [JsonPropertyName("alertStrategy")]
    public IList<V1beta1AlertPolicySpecInitProviderAlertStrategy>? AlertStrategy { get; set; }

    /// <summary>How to combine the results of multiple conditions to determine if an incident should be opened. Possible values are: AND, OR, AND_WITH_MATCHING_RESOURCE.</summary>
    [JsonPropertyName("combiner")]
    public string? Combiner { get; set; }

    /// <summary>A list of conditions for the policy. The conditions are combined by AND or OR according to the combiner field. If the combined conditions evaluate to true, then an incident is created. A policy can have from one to six conditions. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AlertPolicySpecInitProviderConditions>? Conditions { get; set; }

    /// <summary>A short name or phrase used to identify the policy in dashboards, notifications, and incidents. To avoid confusion, don't use the same display name for multiple policies in the same project. The name is limited to 512 Unicode characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Documentation that is included with notifications and incidents related to this policy. Best practice is for the documentation to include information to help responders understand, mitigate, escalate, and correct the underlying problems detected by the alerting policy. Notification channels that have limited capacity might not show this documentation. Structure is documented below.</summary>
    [JsonPropertyName("documentation")]
    public IList<V1beta1AlertPolicySpecInitProviderDocumentation>? Documentation { get; set; }

    /// <summary>Whether or not the policy is enabled. The default is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Identifies the notification channels to which notifications should be sent when incidents are opened or closed or when new violations occur on an already opened incident. Each element of this array corresponds to the name field in each of the NotificationChannel objects that are returned from the notificationChannels.list method. The syntax of the entries in this field is projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]</summary>
    [JsonPropertyName("notificationChannels")]
    public IList<string>? NotificationChannels { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The severity of an alert policy indicates how important incidents generated by that policy are. The severity level will be displayed on the Incident detail page and in notifications. Possible values are: CRITICAL, ERROR, WARNING.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>This field is intended to be used for organizing and identifying the AlertPolicy objects.The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.</summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecProviderConfigRefPolicy
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
public partial class V1beta1AlertPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AlertPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1AlertPolicySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AlertPolicySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1AlertPolicySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AlertPolicySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AlertPolicySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AlertPolicySpec defines the desired state of AlertPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AlertPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AlertPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AlertPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AlertPolicySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AlertPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderAlertStrategyNotificationChannelStrategy
{
    /// <summary>The notification channels that these settings apply to. Each of these correspond to the name field in one of the NotificationChannel objects referenced in the notification_channels field of this AlertPolicy. The format is projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]</summary>
    [JsonPropertyName("notificationChannelNames")]
    public IList<string>? NotificationChannelNames { get; set; }

    /// <summary>The frequency at which to send reminder notifications for open incidents.</summary>
    [JsonPropertyName("renotifyInterval")]
    public string? RenotifyInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderAlertStrategyNotificationRateLimit
{
    /// <summary>Not more than one notification per period.</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderAlertStrategy
{
    /// <summary>If an alert policy that was active has no data for this long, any open incidents will close.</summary>
    [JsonPropertyName("autoClose")]
    public string? AutoClose { get; set; }

    /// <summary>Control over how the notification channels in notification_channels are notified when this alert fires, on a per-channel basis. Structure is documented below.</summary>
    [JsonPropertyName("notificationChannelStrategy")]
    public IList<V1beta1AlertPolicyStatusAtProviderAlertStrategyNotificationChannelStrategy>? NotificationChannelStrategy { get; set; }

    /// <summary>Required for alert policies with a LogMatch condition. This limit is not implemented for alert policies that are not log-based. Structure is documented below.</summary>
    [JsonPropertyName("notificationRateLimit")]
    public IList<V1beta1AlertPolicyStatusAtProviderAlertStrategyNotificationRateLimit>? NotificationRateLimit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderConditionsConditionAbsentAggregations
{
    /// <summary>The alignment period for per-time series alignment. If present, alignmentPeriod must be at least 60 seconds. After per-time series alignment, each time series will contain data points only on the period boundaries. If perSeriesAligner is not specified or equals ALIGN_NONE, then this field is ignored. If perSeriesAligner is specified and does not equal ALIGN_NONE, then this field must be defined; otherwise an error is returned.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The approach to be used to combine time series. Not all reducer functions may be applied to all time series, depending on the metric type and the value type of the original time series. Reduction may change the metric type of value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when crossSeriesReducer is specified. The groupByFields determine how the time series are partitioned into subsets prior to applying the aggregation function. Each subset contains time series that have the same value for each of the grouping fields. Each individual time series is a member of exactly one subset. The crossSeriesReducer is applied to each subset of time series. It is not possible to reduce across different resource types, so this field implicitly contains resource.type. Fields not specified in groupByFields are aggregated away. If groupByFields is not specified and all the time series have the same resource type, then the time series are aggregated into a single output time series. If crossSeriesReducer is not defined, this field is ignored.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>The approach to be used to align individual time series. Not all alignment functions may be applied to all time series, depending on the metric type and value type of the original time series. Alignment may change the metric type or the value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderConditionsConditionAbsentTrigger
{
    /// <summary>The absolute number of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The percentage of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderConditionsConditionAbsent
{
    /// <summary>Specifies the alignment of data points in individual time series as well as how to combine the retrieved time series together (such as when aggregating multiple streams on each resource to a single stream for each resource or when aggregating streams across all members of a group of resources). Multiple aggregations are applied in the order specified.This field is similar to the one in the MetricService.ListTimeSeries request. It is advisable to use the ListTimeSeries method when debugging this field. Structure is documented below.</summary>
    [JsonPropertyName("aggregations")]
    public IList<V1beta1AlertPolicyStatusAtProviderConditionsConditionAbsentAggregations>? Aggregations { get; set; }

    /// <summary>The amount of time that a time series must violate the threshold to be considered failing. Currently, only values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of the underlying time series data (which may also be affected by any alignments specified in the aggregations field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short enough that unhealthy states are detected and alerted on quickly.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>A filter that identifies which time series should be compared with the threshold.The filter is similar to the one that is specified in the MetricService.ListTimeSeries request (that call is useful to verify the time series that will be retrieved / processed) and must specify the metric type and optionally may contain restrictions on resource type, resource labels, and metric labels. This field may not exceed 2048 Unicode characters in length.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The number/percent of time series for which the comparison must hold in order for the condition to trigger. If unspecified, then the condition will trigger if the comparison is true for any of the time series that have been identified by filter and aggregations, or by the ratio, if denominator_filter and denominator_aggregations are specified. Structure is documented below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1AlertPolicyStatusAtProviderConditionsConditionAbsentTrigger>? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderConditionsConditionMatchedLog
{
    /// <summary>A filter that identifies which time series should be compared with the threshold.The filter is similar to the one that is specified in the MetricService.ListTimeSeries request (that call is useful to verify the time series that will be retrieved / processed) and must specify the metric type and optionally may contain restrictions on resource type, resource labels, and metric labels. This field may not exceed 2048 Unicode characters in length.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>A map from a label key to an extractor expression, which is used to extract the value for this label key. Each entry in this map is a specification for how data should be extracted from log entries that match filter. Each combination of extracted values is treated as a separate rule for the purposes of triggering notifications. Label keys and corresponding values can be used in notifications generated by this condition.</summary>
    [JsonPropertyName("labelExtractors")]
    public IDictionary<string, string>? LabelExtractors { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderConditionsConditionMonitoringQueryLanguageTrigger
{
    /// <summary>The absolute number of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The percentage of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderConditionsConditionMonitoringQueryLanguage
{
    /// <summary>The amount of time that a time series must violate the threshold to be considered failing. Currently, only values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of the underlying time series data (which may also be affected by any alignments specified in the aggregations field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short enough that unhealthy states are detected and alerted on quickly.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>A condition control that determines how metric-threshold conditions are evaluated when data stops arriving. Possible values are: EVALUATION_MISSING_DATA_INACTIVE, EVALUATION_MISSING_DATA_ACTIVE, EVALUATION_MISSING_DATA_NO_OP.</summary>
    [JsonPropertyName("evaluationMissingData")]
    public string? EvaluationMissingData { get; set; }

    /// <summary>The PromQL expression to evaluate. Every evaluation cycle this expression is evaluated at the current time, and all resultant time series become pending/firing alerts. This field must not be empty.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The number/percent of time series for which the comparison must hold in order for the condition to trigger. If unspecified, then the condition will trigger if the comparison is true for any of the time series that have been identified by filter and aggregations, or by the ratio, if denominator_filter and denominator_aggregations are specified. Structure is documented below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1AlertPolicyStatusAtProviderConditionsConditionMonitoringQueryLanguageTrigger>? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderConditionsConditionPrometheusQueryLanguage
{
    /// <summary>The alerting rule name of this alert in the corresponding Prometheus configuration file. Some external tools may require this field to be populated correctly in order to refer to the original Prometheus configuration file. The rule group name and the alert name are necessary to update the relevant AlertPolicies in case the definition of the rule group changes in the future. This field is optional. If this field is not empty, then it must be a valid Prometheus label name.</summary>
    [JsonPropertyName("alertRule")]
    public string? AlertRule { get; set; }

    /// <summary>The amount of time that a time series must violate the threshold to be considered failing. Currently, only values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of the underlying time series data (which may also be affected by any alignments specified in the aggregations field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short enough that unhealthy states are detected and alerted on quickly.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>How often this rule should be evaluated. Must be a positive multiple of 30 seconds or missing. The default value is 30 seconds. If this PrometheusQueryLanguageCondition was generated from a Prometheus alerting rule, then this value should be taken from the enclosing rule group.</summary>
    [JsonPropertyName("evaluationInterval")]
    public string? EvaluationInterval { get; set; }

    /// <summary>Labels to add to or overwrite in the PromQL query result. Label names must be valid. Label values can be templatized by using variables. The only available variable names are the names of the labels in the PromQL result, including "name" and "value". "labels" may be empty. This field is intended to be used for organizing and identifying the AlertPolicy</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The PromQL expression to evaluate. Every evaluation cycle this expression is evaluated at the current time, and all resultant time series become pending/firing alerts. This field must not be empty.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The rule group name of this alert in the corresponding Prometheus configuration file. Some external tools may require this field to be populated correctly in order to refer to the original Prometheus configuration file. The rule group name and the alert name are necessary to update the relevant AlertPolicies in case the definition of the rule group changes in the future. This field is optional.</summary>
    [JsonPropertyName("ruleGroup")]
    public string? RuleGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderConditionsConditionThresholdAggregations
{
    /// <summary>The alignment period for per-time series alignment. If present, alignmentPeriod must be at least 60 seconds. After per-time series alignment, each time series will contain data points only on the period boundaries. If perSeriesAligner is not specified or equals ALIGN_NONE, then this field is ignored. If perSeriesAligner is specified and does not equal ALIGN_NONE, then this field must be defined; otherwise an error is returned.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The approach to be used to combine time series. Not all reducer functions may be applied to all time series, depending on the metric type and the value type of the original time series. Reduction may change the metric type of value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when crossSeriesReducer is specified. The groupByFields determine how the time series are partitioned into subsets prior to applying the aggregation function. Each subset contains time series that have the same value for each of the grouping fields. Each individual time series is a member of exactly one subset. The crossSeriesReducer is applied to each subset of time series. It is not possible to reduce across different resource types, so this field implicitly contains resource.type. Fields not specified in groupByFields are aggregated away. If groupByFields is not specified and all the time series have the same resource type, then the time series are aggregated into a single output time series. If crossSeriesReducer is not defined, this field is ignored.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>The approach to be used to align individual time series. Not all alignment functions may be applied to all time series, depending on the metric type and value type of the original time series. Alignment may change the metric type or the value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderConditionsConditionThresholdDenominatorAggregations
{
    /// <summary>The alignment period for per-time series alignment. If present, alignmentPeriod must be at least 60 seconds. After per-time series alignment, each time series will contain data points only on the period boundaries. If perSeriesAligner is not specified or equals ALIGN_NONE, then this field is ignored. If perSeriesAligner is specified and does not equal ALIGN_NONE, then this field must be defined; otherwise an error is returned.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The approach to be used to combine time series. Not all reducer functions may be applied to all time series, depending on the metric type and the value type of the original time series. Reduction may change the metric type of value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when crossSeriesReducer is specified. The groupByFields determine how the time series are partitioned into subsets prior to applying the aggregation function. Each subset contains time series that have the same value for each of the grouping fields. Each individual time series is a member of exactly one subset. The crossSeriesReducer is applied to each subset of time series. It is not possible to reduce across different resource types, so this field implicitly contains resource.type. Fields not specified in groupByFields are aggregated away. If groupByFields is not specified and all the time series have the same resource type, then the time series are aggregated into a single output time series. If crossSeriesReducer is not defined, this field is ignored.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>The approach to be used to align individual time series. Not all alignment functions may be applied to all time series, depending on the metric type and value type of the original time series. Alignment may change the metric type or the value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderConditionsConditionThresholdForecastOptions
{
    /// <summary>The length of time into the future to forecast whether a timeseries will violate the threshold. If the predicted value is found to violate the threshold, and the violation is observed in all forecasts made for the Configured duration, then the timeseries is considered to be failing.</summary>
    [JsonPropertyName("forecastHorizon")]
    public string? ForecastHorizon { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderConditionsConditionThresholdTrigger
{
    /// <summary>The absolute number of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The percentage of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderConditionsConditionThreshold
{
    /// <summary>Specifies the alignment of data points in individual time series as well as how to combine the retrieved time series together (such as when aggregating multiple streams on each resource to a single stream for each resource or when aggregating streams across all members of a group of resources). Multiple aggregations are applied in the order specified.This field is similar to the one in the MetricService.ListTimeSeries request. It is advisable to use the ListTimeSeries method when debugging this field. Structure is documented below.</summary>
    [JsonPropertyName("aggregations")]
    public IList<V1beta1AlertPolicyStatusAtProviderConditionsConditionThresholdAggregations>? Aggregations { get; set; }

    /// <summary>The comparison to apply between the time series (indicated by filter and aggregation) and the threshold (indicated by threshold_value). The comparison is applied on each time series, with the time series on the left-hand side and the threshold on the right-hand side. Only COMPARISON_LT and COMPARISON_GT are supported currently. Possible values are: COMPARISON_GT, COMPARISON_GE, COMPARISON_LT, COMPARISON_LE, COMPARISON_EQ, COMPARISON_NE.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>Specifies the alignment of data points in individual time series selected by denominatorFilter as well as how to combine the retrieved time series together (such as when aggregating multiple streams on each resource to a single stream for each resource or when aggregating streams across all members of a group of resources).When computing ratios, the aggregations and denominator_aggregations fields must use the same alignment period and produce time series that have the same periodicity and labels.This field is similar to the one in the MetricService.ListTimeSeries request. It is advisable to use the ListTimeSeries method when debugging this field. Structure is documented below.</summary>
    [JsonPropertyName("denominatorAggregations")]
    public IList<V1beta1AlertPolicyStatusAtProviderConditionsConditionThresholdDenominatorAggregations>? DenominatorAggregations { get; set; }

    /// <summary>A filter that identifies a time series that should be used as the denominator of a ratio that will be compared with the threshold. If a denominator_filter is specified, the time series specified by the filter field will be used as the numerator.The filter is similar to the one that is specified in the MetricService.ListTimeSeries request (that call is useful to verify the time series that will be retrieved / processed) and must specify the metric type and optionally may contain restrictions on resource type, resource labels, and metric labels. This field may not exceed 2048 Unicode characters in length.</summary>
    [JsonPropertyName("denominatorFilter")]
    public string? DenominatorFilter { get; set; }

    /// <summary>The amount of time that a time series must violate the threshold to be considered failing. Currently, only values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of the underlying time series data (which may also be affected by any alignments specified in the aggregations field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short enough that unhealthy states are detected and alerted on quickly.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>A condition control that determines how metric-threshold conditions are evaluated when data stops arriving. Possible values are: EVALUATION_MISSING_DATA_INACTIVE, EVALUATION_MISSING_DATA_ACTIVE, EVALUATION_MISSING_DATA_NO_OP.</summary>
    [JsonPropertyName("evaluationMissingData")]
    public string? EvaluationMissingData { get; set; }

    /// <summary>A filter that identifies which time series should be compared with the threshold.The filter is similar to the one that is specified in the MetricService.ListTimeSeries request (that call is useful to verify the time series that will be retrieved / processed) and must specify the metric type and optionally may contain restrictions on resource type, resource labels, and metric labels. This field may not exceed 2048 Unicode characters in length.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>When this field is present, the MetricThreshold condition forecasts whether the time series is predicted to violate the threshold within the forecastHorizon. When this field is not set, the MetricThreshold tests the current value of the timeseries against the threshold. Structure is documented below.</summary>
    [JsonPropertyName("forecastOptions")]
    public IList<V1beta1AlertPolicyStatusAtProviderConditionsConditionThresholdForecastOptions>? ForecastOptions { get; set; }

    /// <summary>A value against which to compare the time series.</summary>
    [JsonPropertyName("thresholdValue")]
    public double? ThresholdValue { get; set; }

    /// <summary>The number/percent of time series for which the comparison must hold in order for the condition to trigger. If unspecified, then the condition will trigger if the comparison is true for any of the time series that have been identified by filter and aggregations, or by the ratio, if denominator_filter and denominator_aggregations are specified. Structure is documented below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1AlertPolicyStatusAtProviderConditionsConditionThresholdTrigger>? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderConditions
{
    /// <summary>A condition that checks that a time series continues to receive new data points. Structure is documented below.</summary>
    [JsonPropertyName("conditionAbsent")]
    public IList<V1beta1AlertPolicyStatusAtProviderConditionsConditionAbsent>? ConditionAbsent { get; set; }

    /// <summary>A condition that checks for log messages matching given constraints. If set, no other conditions can be present. Structure is documented below.</summary>
    [JsonPropertyName("conditionMatchedLog")]
    public IList<V1beta1AlertPolicyStatusAtProviderConditionsConditionMatchedLog>? ConditionMatchedLog { get; set; }

    /// <summary>A Monitoring Query Language query that outputs a boolean stream Structure is documented below.</summary>
    [JsonPropertyName("conditionMonitoringQueryLanguage")]
    public IList<V1beta1AlertPolicyStatusAtProviderConditionsConditionMonitoringQueryLanguage>? ConditionMonitoringQueryLanguage { get; set; }

    /// <summary>A condition type that allows alert policies to be defined using Prometheus Query Language (PromQL). The PrometheusQueryLanguageCondition message contains information from a Prometheus alerting rule and its associated rule group. Structure is documented below.</summary>
    [JsonPropertyName("conditionPrometheusQueryLanguage")]
    public IList<V1beta1AlertPolicyStatusAtProviderConditionsConditionPrometheusQueryLanguage>? ConditionPrometheusQueryLanguage { get; set; }

    /// <summary>A condition that compares a time series against a threshold. Structure is documented below.</summary>
    [JsonPropertyName("conditionThreshold")]
    public IList<V1beta1AlertPolicyStatusAtProviderConditionsConditionThreshold>? ConditionThreshold { get; set; }

    /// <summary>A short name or phrase used to identify the condition in dashboards, notifications, and incidents. To avoid confusion, don't use the same display name for multiple conditions in the same policy.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>(Output) The unique resource name for this condition. Its syntax is: projects/[PROJECT_ID]/alertPolicies/[POLICY_ID]/conditions/[CONDITION_ID] [CONDITION_ID] is assigned by Stackdriver Monitoring when the condition is created as part of a new or updated alerting policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderCreationRecord
{
    /// <summary>(Output) When the change occurred.</summary>
    [JsonPropertyName("mutateTime")]
    public string? MutateTime { get; set; }

    /// <summary>(Output) The email address of the user making the change.</summary>
    [JsonPropertyName("mutatedBy")]
    public string? MutatedBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderDocumentationLinks
{
    /// <summary>A short display name for the link. The display name must not be empty or exceed 63 characters. Example: "playbook".</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The url of a webpage. A url can be templatized by using variables in the path or the query parameters. The total length of a URL should not exceed 2083 characters before and after variable expansion. Example: "https://my_domain.com/playbook?name=${resource.name}".</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProviderDocumentation
{
    /// <summary>The text of the documentation, interpreted according to mimeType. The content may not exceed 8,192 Unicode characters and may not exceed more than 10,240 bytes when encoded in UTF-8 format, whichever is smaller.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Links to content such as playbooks, repositories, and other resources. This field can contain up to 3 entries. Structure is documented below.</summary>
    [JsonPropertyName("links")]
    public IList<V1beta1AlertPolicyStatusAtProviderDocumentationLinks>? Links { get; set; }

    /// <summary>The format of the content field. Presently, only the value "text/markdown" is supported.</summary>
    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }

    /// <summary>The subject line of the notification. The subject line may not exceed 10,240 bytes. In notifications generated by this policy the contents of the subject line after variable expansion will be truncated to 255 bytes or shorter at the latest UTF-8 character boundary.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusAtProvider
{
    /// <summary>Control over how this alert policy's notification channels are notified. Structure is documented below.</summary>
    [JsonPropertyName("alertStrategy")]
    public IList<V1beta1AlertPolicyStatusAtProviderAlertStrategy>? AlertStrategy { get; set; }

    /// <summary>How to combine the results of multiple conditions to determine if an incident should be opened. Possible values are: AND, OR, AND_WITH_MATCHING_RESOURCE.</summary>
    [JsonPropertyName("combiner")]
    public string? Combiner { get; set; }

    /// <summary>A list of conditions for the policy. The conditions are combined by AND or OR according to the combiner field. If the combined conditions evaluate to true, then an incident is created. A policy can have from one to six conditions. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AlertPolicyStatusAtProviderConditions>? Conditions { get; set; }

    /// <summary>A read-only record of the creation of the alerting policy. If provided in a call to create or update, this field will be ignored. Structure is documented below.</summary>
    [JsonPropertyName("creationRecord")]
    public IList<V1beta1AlertPolicyStatusAtProviderCreationRecord>? CreationRecord { get; set; }

    /// <summary>A short name or phrase used to identify the policy in dashboards, notifications, and incidents. To avoid confusion, don't use the same display name for multiple policies in the same project. The name is limited to 512 Unicode characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Documentation that is included with notifications and incidents related to this policy. Best practice is for the documentation to include information to help responders understand, mitigate, escalate, and correct the underlying problems detected by the alerting policy. Notification channels that have limited capacity might not show this documentation. Structure is documented below.</summary>
    [JsonPropertyName("documentation")]
    public IList<V1beta1AlertPolicyStatusAtProviderDocumentation>? Documentation { get; set; }

    /// <summary>Whether or not the policy is enabled. The default is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The unique resource name for this policy. Its syntax is: projects/[PROJECT_ID]/alertPolicies/[ALERT_POLICY_ID]</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Identifies the notification channels to which notifications should be sent when incidents are opened or closed or when new violations occur on an already opened incident. Each element of this array corresponds to the name field in each of the NotificationChannel objects that are returned from the notificationChannels.list method. The syntax of the entries in this field is projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]</summary>
    [JsonPropertyName("notificationChannels")]
    public IList<string>? NotificationChannels { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The severity of an alert policy indicates how important incidents generated by that policy are. The severity level will be displayed on the Incident detail page and in notifications. Possible values are: CRITICAL, ERROR, WARNING.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>This field is intended to be used for organizing and identifying the AlertPolicy objects.The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.</summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatusConditions
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

/// <summary>AlertPolicyStatus defines the observed state of AlertPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AlertPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AlertPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AlertPolicy is the Schema for the AlertPolicys API. A description of the conditions under which some aspect of your system is considered to be "unhealthy" and the ways to notify people or services about this state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AlertPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AlertPolicySpec>, IStatus<V1beta1AlertPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AlertPolicy";
    public const string KubeGroup = "monitoring.gcp.upbound.io";
    public const string KubePluralName = "alertpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AlertPolicySpec defines the desired state of AlertPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1AlertPolicySpec Spec { get; set; }

    /// <summary>AlertPolicyStatus defines the observed state of AlertPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1AlertPolicyStatus? Status { get; set; }
}

/// <summary>AlertPolicy is the Schema for the AlertPolicys API. A description of the conditions under which some aspect of your system is considered to be "unhealthy" and the ways to notify people or services about this state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AlertPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AlertPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AlertPolicyList";
    public const string KubeGroup = "monitoring.gcp.upbound.io";
    public const string KubePluralName = "alertpolicies";
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
    public IList<V1beta1AlertPolicy> Items { get; set; }
}