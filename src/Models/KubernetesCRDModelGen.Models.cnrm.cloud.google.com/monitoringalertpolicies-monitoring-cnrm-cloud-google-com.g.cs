using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.monitoring.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecAlertStrategyNotificationChannelStrategy
{
    /// <summary>The notification channels that these settings apply to. Each of these correspond to the name field in one of the NotificationChannel objects referenced in the notification_channels field of this AlertPolicy. The format is 'projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]'.</summary>
    [JsonPropertyName("notificationChannelNames")]
    public IList<string>? NotificationChannelNames { get; set; }

    /// <summary>The frequency at which to send reminder notifications for open incidents.</summary>
    [JsonPropertyName("renotifyInterval")]
    public string? RenotifyInterval { get; set; }
}

/// <summary>Required for alert policies with a LogMatch condition. This limit is not implemented for alert policies that are not log-based.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecAlertStrategyNotificationRateLimit
{
    /// <summary>Not more than one notification per period.</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

/// <summary>Control over how this alert policy's notification channels are notified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecAlertStrategy
{
    /// <summary>If an alert policy that was active has no data for this long, any open incidents will close.</summary>
    [JsonPropertyName("autoClose")]
    public string? AutoClose { get; set; }

    /// <summary>Control over how the notification channels in 'notification_channels' are notified when this alert fires, on a per-channel basis.</summary>
    [JsonPropertyName("notificationChannelStrategy")]
    public IList<V1beta1MonitoringAlertPolicySpecAlertStrategyNotificationChannelStrategy>? NotificationChannelStrategy { get; set; }

    /// <summary>Required for alert policies with a LogMatch condition. This limit is not implemented for alert policies that are not log-based.</summary>
    [JsonPropertyName("notificationRateLimit")]
    public V1beta1MonitoringAlertPolicySpecAlertStrategyNotificationRateLimit? NotificationRateLimit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecConditionsConditionAbsentAggregations
{
    /// <summary>The alignment period for per-time series alignment. If present, alignmentPeriod must be at least 60 seconds. After per-time series alignment, each time series will contain data points only on the period boundaries. If perSeriesAligner is not specified or equals ALIGN_NONE, then this field is ignored. If perSeriesAligner is specified and does not equal ALIGN_NONE, then this field must be defined; otherwise an error is returned.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The approach to be used to combine time series. Not all reducer functions may be applied to all time series, depending on the metric type and the value type of the original time series. Reduction may change the metric type of value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values: ["REDUCE_NONE", "REDUCE_MEAN", "REDUCE_MIN", "REDUCE_MAX", "REDUCE_SUM", "REDUCE_STDDEV", "REDUCE_COUNT", "REDUCE_COUNT_TRUE", "REDUCE_COUNT_FALSE", "REDUCE_FRACTION_TRUE", "REDUCE_PERCENTILE_99", "REDUCE_PERCENTILE_95", "REDUCE_PERCENTILE_50", "REDUCE_PERCENTILE_05"].</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when crossSeriesReducer is specified. The groupByFields determine how the time series are partitioned into subsets prior to applying the aggregation function. Each subset contains time series that have the same value for each of the grouping fields. Each individual time series is a member of exactly one subset. The crossSeriesReducer is applied to each subset of time series. It is not possible to reduce across different resource types, so this field implicitly contains resource.type. Fields not specified in groupByFields are aggregated away. If groupByFields is not specified and all the time series have the same resource type, then the time series are aggregated into a single output time series. If crossSeriesReducer is not defined, this field is ignored.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>The approach to be used to align individual time series. Not all alignment functions may be applied to all time series, depending on the metric type and value type of the original time series. Alignment may change the metric type or the value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values: ["ALIGN_NONE", "ALIGN_DELTA", "ALIGN_RATE", "ALIGN_INTERPOLATE", "ALIGN_NEXT_OLDER", "ALIGN_MIN", "ALIGN_MAX", "ALIGN_MEAN", "ALIGN_COUNT", "ALIGN_SUM", "ALIGN_STDDEV", "ALIGN_COUNT_TRUE", "ALIGN_COUNT_FALSE", "ALIGN_FRACTION_TRUE", "ALIGN_PERCENTILE_99", "ALIGN_PERCENTILE_95", "ALIGN_PERCENTILE_50", "ALIGN_PERCENTILE_05", "ALIGN_PERCENT_CHANGE"].</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary>The number/percent of time series for which the comparison must hold in order for the condition to trigger. If unspecified, then the condition will trigger if the comparison is true for any of the time series that have been identified by filter and aggregations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecConditionsConditionAbsentTrigger
{
    /// <summary>The absolute number of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>The percentage of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>A condition that checks that a time series continues to receive new data points.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecConditionsConditionAbsent
{
    /// <summary>Specifies the alignment of data points in individual time series as well as how to combine the retrieved time series together (such as when aggregating multiple streams on each resource to a single stream for each resource or when aggregating streams across all members of a group of resources). Multiple aggregations are applied in the order specified.</summary>
    [JsonPropertyName("aggregations")]
    public IList<V1beta1MonitoringAlertPolicySpecConditionsConditionAbsentAggregations>? Aggregations { get; set; }

    /// <summary>The amount of time that a time series must fail to report new data to be considered failing. Currently, only values that are a multiple of a minute--e.g. 60s, 120s, or 300s --are supported.</summary>
    [JsonPropertyName("duration")]
    public string Duration { get; set; }

    /// <summary>A filter that identifies which time series should be compared with the threshold.The filter is similar to the one that is specified in the MetricService.ListTimeSeries request (that call is useful to verify the time series that will be retrieved / processed) and must specify the metric type and optionally may contain restrictions on resource type, resource labels, and metric labels. This field may not exceed 2048 Unicode characters in length.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The number/percent of time series for which the comparison must hold in order for the condition to trigger. If unspecified, then the condition will trigger if the comparison is true for any of the time series that have been identified by filter and aggregations.</summary>
    [JsonPropertyName("trigger")]
    public V1beta1MonitoringAlertPolicySpecConditionsConditionAbsentTrigger? Trigger { get; set; }
}

/// <summary>A condition that checks for log messages matching given constraints. If set, no other conditions can be present.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecConditionsConditionMatchedLog
{
    /// <summary>A logs-based filter.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>A map from a label key to an extractor expression, which is used to extract the value for this label key. Each entry in this map is a specification for how data should be extracted from log entries that match filter. Each combination of extracted values is treated as a separate rule for the purposes of triggering notifications. Label keys and corresponding values can be used in notifications generated by this condition.</summary>
    [JsonPropertyName("labelExtractors")]
    public IDictionary<string, string>? LabelExtractors { get; set; }
}

/// <summary>The number/percent of time series for which the comparison must hold in order for the condition to trigger. If unspecified, then the condition will trigger if the comparison is true for any of the time series that have been identified by filter and aggregations, or by the ratio, if denominator_filter and denominator_aggregations are specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecConditionsConditionMonitoringQueryLanguageTrigger
{
    /// <summary>The absolute number of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>The percentage of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>A Monitoring Query Language query that outputs a boolean stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecConditionsConditionMonitoringQueryLanguage
{
    /// <summary>The amount of time that a time series must violate the threshold to be considered failing. Currently, only values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of the underlying time series data (which may also be affected by any alignments specified in the aggregations field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short enough that unhealthy states are detected and alerted on quickly.</summary>
    [JsonPropertyName("duration")]
    public string Duration { get; set; }

    /// <summary>A condition control that determines how metric-threshold conditions are evaluated when data stops arriving. Possible values: ["EVALUATION_MISSING_DATA_INACTIVE", "EVALUATION_MISSING_DATA_ACTIVE", "EVALUATION_MISSING_DATA_NO_OP"].</summary>
    [JsonPropertyName("evaluationMissingData")]
    public string? EvaluationMissingData { get; set; }

    /// <summary>Monitoring Query Language query that outputs a boolean stream.</summary>
    [JsonPropertyName("query")]
    public string Query { get; set; }

    /// <summary>The number/percent of time series for which the comparison must hold in order for the condition to trigger. If unspecified, then the condition will trigger if the comparison is true for any of the time series that have been identified by filter and aggregations, or by the ratio, if denominator_filter and denominator_aggregations are specified.</summary>
    [JsonPropertyName("trigger")]
    public V1beta1MonitoringAlertPolicySpecConditionsConditionMonitoringQueryLanguageTrigger? Trigger { get; set; }
}

/// <summary>A Monitoring Query Language query that outputs a boolean stream  A condition type that allows alert policies to be defined using Prometheus Query Language (PromQL).  The PrometheusQueryLanguageCondition message contains information from a Prometheus alerting rule and its associated rule group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecConditionsConditionPrometheusQueryLanguage
{
    /// <summary>The alerting rule name of this alert in the corresponding Prometheus configuration file.  Some external tools may require this field to be populated correctly in order to refer to the original Prometheus configuration file. The rule group name and the alert name are necessary to update the relevant AlertPolicies in case the definition of the rule group changes in the future.  This field is optional. If this field is not empty, then it must be a valid Prometheus label name.</summary>
    [JsonPropertyName("alertRule")]
    public string? AlertRule { get; set; }

    /// <summary>Alerts are considered firing once their PromQL expression evaluated to be "true" for this long. Alerts whose PromQL expression was not evaluated to be "true" for long enough are considered pending. The default value is zero. Must be zero or positive.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>How often this rule should be evaluated. Must be a positive multiple of 30 seconds or missing. The default value is 30 seconds. If this PrometheusQueryLanguageCondition was generated from a Prometheus alerting rule, then this value should be taken from the enclosing rule group.</summary>
    [JsonPropertyName("evaluationInterval")]
    public string? EvaluationInterval { get; set; }

    /// <summary>Labels to add to or overwrite in the PromQL query result. Label names must be valid.  Label values can be templatized by using variables. The only available variable names are the names of the labels in the PromQL result, including "__name__" and "value". "labels" may be empty. This field is intended to be used for organizing and identifying the AlertPolicy.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The PromQL expression to evaluate. Every evaluation cycle this expression is evaluated at the current time, and all resultant time series become pending/firing alerts. This field must not be empty.</summary>
    [JsonPropertyName("query")]
    public string Query { get; set; }

    /// <summary>The rule group name of this alert in the corresponding Prometheus configuration file.  Some external tools may require this field to be populated correctly in order to refer to the original Prometheus configuration file. The rule group name and the alert name are necessary to update the relevant AlertPolicies in case the definition of the rule group changes in the future.  This field is optional. If this field is not empty, then it must be a valid Prometheus label name.</summary>
    [JsonPropertyName("ruleGroup")]
    public string? RuleGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecConditionsConditionThresholdAggregations
{
    /// <summary>The alignment period for per-time series alignment. If present, alignmentPeriod must be at least 60 seconds. After per-time series alignment, each time series will contain data points only on the period boundaries. If perSeriesAligner is not specified or equals ALIGN_NONE, then this field is ignored. If perSeriesAligner is specified and does not equal ALIGN_NONE, then this field must be defined; otherwise an error is returned.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The approach to be used to combine time series. Not all reducer functions may be applied to all time series, depending on the metric type and the value type of the original time series. Reduction may change the metric type of value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values: ["REDUCE_NONE", "REDUCE_MEAN", "REDUCE_MIN", "REDUCE_MAX", "REDUCE_SUM", "REDUCE_STDDEV", "REDUCE_COUNT", "REDUCE_COUNT_TRUE", "REDUCE_COUNT_FALSE", "REDUCE_FRACTION_TRUE", "REDUCE_PERCENTILE_99", "REDUCE_PERCENTILE_95", "REDUCE_PERCENTILE_50", "REDUCE_PERCENTILE_05"].</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when crossSeriesReducer is specified. The groupByFields determine how the time series are partitioned into subsets prior to applying the aggregation function. Each subset contains time series that have the same value for each of the grouping fields. Each individual time series is a member of exactly one subset. The crossSeriesReducer is applied to each subset of time series. It is not possible to reduce across different resource types, so this field implicitly contains resource.type. Fields not specified in groupByFields are aggregated away. If groupByFields is not specified and all the time series have the same resource type, then the time series are aggregated into a single output time series. If crossSeriesReducer is not defined, this field is ignored.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>The approach to be used to align individual time series. Not all alignment functions may be applied to all time series, depending on the metric type and value type of the original time series. Alignment may change the metric type or the value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values: ["ALIGN_NONE", "ALIGN_DELTA", "ALIGN_RATE", "ALIGN_INTERPOLATE", "ALIGN_NEXT_OLDER", "ALIGN_MIN", "ALIGN_MAX", "ALIGN_MEAN", "ALIGN_COUNT", "ALIGN_SUM", "ALIGN_STDDEV", "ALIGN_COUNT_TRUE", "ALIGN_COUNT_FALSE", "ALIGN_FRACTION_TRUE", "ALIGN_PERCENTILE_99", "ALIGN_PERCENTILE_95", "ALIGN_PERCENTILE_50", "ALIGN_PERCENTILE_05", "ALIGN_PERCENT_CHANGE"].</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecConditionsConditionThresholdDenominatorAggregations
{
    /// <summary>The alignment period for per-time series alignment. If present, alignmentPeriod must be at least 60 seconds. After per-time series alignment, each time series will contain data points only on the period boundaries. If perSeriesAligner is not specified or equals ALIGN_NONE, then this field is ignored. If perSeriesAligner is specified and does not equal ALIGN_NONE, then this field must be defined; otherwise an error is returned.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The approach to be used to combine time series. Not all reducer functions may be applied to all time series, depending on the metric type and the value type of the original time series. Reduction may change the metric type of value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values: ["REDUCE_NONE", "REDUCE_MEAN", "REDUCE_MIN", "REDUCE_MAX", "REDUCE_SUM", "REDUCE_STDDEV", "REDUCE_COUNT", "REDUCE_COUNT_TRUE", "REDUCE_COUNT_FALSE", "REDUCE_FRACTION_TRUE", "REDUCE_PERCENTILE_99", "REDUCE_PERCENTILE_95", "REDUCE_PERCENTILE_50", "REDUCE_PERCENTILE_05"].</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when crossSeriesReducer is specified. The groupByFields determine how the time series are partitioned into subsets prior to applying the aggregation function. Each subset contains time series that have the same value for each of the grouping fields. Each individual time series is a member of exactly one subset. The crossSeriesReducer is applied to each subset of time series. It is not possible to reduce across different resource types, so this field implicitly contains resource.type. Fields not specified in groupByFields are aggregated away. If groupByFields is not specified and all the time series have the same resource type, then the time series are aggregated into a single output time series. If crossSeriesReducer is not defined, this field is ignored.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>The approach to be used to align individual time series. Not all alignment functions may be applied to all time series, depending on the metric type and value type of the original time series. Alignment may change the metric type or the value type of the time series.Time series data must be aligned in order to perform cross- time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned. Possible values: ["ALIGN_NONE", "ALIGN_DELTA", "ALIGN_RATE", "ALIGN_INTERPOLATE", "ALIGN_NEXT_OLDER", "ALIGN_MIN", "ALIGN_MAX", "ALIGN_MEAN", "ALIGN_COUNT", "ALIGN_SUM", "ALIGN_STDDEV", "ALIGN_COUNT_TRUE", "ALIGN_COUNT_FALSE", "ALIGN_FRACTION_TRUE", "ALIGN_PERCENTILE_99", "ALIGN_PERCENTILE_95", "ALIGN_PERCENTILE_50", "ALIGN_PERCENTILE_05", "ALIGN_PERCENT_CHANGE"].</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary>When this field is present, the 'MetricThreshold' condition forecasts whether the time series is predicted to violate the threshold within the 'forecastHorizon'. When this field is not set, the 'MetricThreshold' tests the current value of the timeseries against the threshold.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecConditionsConditionThresholdForecastOptions
{
    /// <summary>The length of time into the future to forecast whether a timeseries will violate the threshold. If the predicted value is found to violate the threshold, and the violation is observed in all forecasts made for the Configured 'duration', then the timeseries is considered to be failing.</summary>
    [JsonPropertyName("forecastHorizon")]
    public string ForecastHorizon { get; set; }
}

/// <summary>The number/percent of time series for which the comparison must hold in order for the condition to trigger. If unspecified, then the condition will trigger if the comparison is true for any of the time series that have been identified by filter and aggregations, or by the ratio, if denominator_filter and denominator_aggregations are specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecConditionsConditionThresholdTrigger
{
    /// <summary>The absolute number of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>The percentage of time series that must fail the predicate for the condition to be triggered.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>A condition that compares a time series against a threshold.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecConditionsConditionThreshold
{
    /// <summary>Specifies the alignment of data points in individual time series as well as how to combine the retrieved time series together (such as when aggregating multiple streams on each resource to a single stream for each resource or when aggregating streams across all members of a group of resources). Multiple aggregations are applied in the order specified.This field is similar to the one in the MetricService.ListTimeSeries request. It is advisable to use the ListTimeSeries method when debugging this field.</summary>
    [JsonPropertyName("aggregations")]
    public IList<V1beta1MonitoringAlertPolicySpecConditionsConditionThresholdAggregations>? Aggregations { get; set; }

    /// <summary>The comparison to apply between the time series (indicated by filter and aggregation) and the threshold (indicated by threshold_value). The comparison is applied on each time series, with the time series on the left-hand side and the threshold on the right-hand side. Only COMPARISON_LT and COMPARISON_GT are supported currently. Possible values: ["COMPARISON_GT", "COMPARISON_GE", "COMPARISON_LT", "COMPARISON_LE", "COMPARISON_EQ", "COMPARISON_NE"].</summary>
    [JsonPropertyName("comparison")]
    public string Comparison { get; set; }

    /// <summary>Specifies the alignment of data points in individual time series selected by denominatorFilter as well as how to combine the retrieved time series together (such as when aggregating multiple streams on each resource to a single stream for each resource or when aggregating streams across all members of a group of resources).When computing ratios, the aggregations and denominator_aggregations fields must use the same alignment period and produce time series that have the same periodicity and labels.This field is similar to the one in the MetricService.ListTimeSeries request. It is advisable to use the ListTimeSeries method when debugging this field.</summary>
    [JsonPropertyName("denominatorAggregations")]
    public IList<V1beta1MonitoringAlertPolicySpecConditionsConditionThresholdDenominatorAggregations>? DenominatorAggregations { get; set; }

    /// <summary>A filter that identifies a time series that should be used as the denominator of a ratio that will be compared with the threshold. If a denominator_filter is specified, the time series specified by the filter field will be used as the numerator.The filter is similar to the one that is specified in the MetricService.ListTimeSeries request (that call is useful to verify the time series that will be retrieved / processed) and must specify the metric type and optionally may contain restrictions on resource type, resource labels, and metric labels. This field may not exceed 2048 Unicode characters in length.</summary>
    [JsonPropertyName("denominatorFilter")]
    public string? DenominatorFilter { get; set; }

    /// <summary>The amount of time that a time series must violate the threshold to be considered failing. Currently, only values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of the underlying time series data (which may also be affected by any alignments specified in the aggregations field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short enough that unhealthy states are detected and alerted on quickly.</summary>
    [JsonPropertyName("duration")]
    public string Duration { get; set; }

    /// <summary>A condition control that determines how metric-threshold conditions are evaluated when data stops arriving. Possible values: ["EVALUATION_MISSING_DATA_INACTIVE", "EVALUATION_MISSING_DATA_ACTIVE", "EVALUATION_MISSING_DATA_NO_OP"].</summary>
    [JsonPropertyName("evaluationMissingData")]
    public string? EvaluationMissingData { get; set; }

    /// <summary>A filter that identifies which time series should be compared with the threshold.The filter is similar to the one that is specified in the MetricService.ListTimeSeries request (that call is useful to verify the time series that will be retrieved / processed) and must specify the metric type and optionally may contain restrictions on resource type, resource labels, and metric labels. This field may not exceed 2048 Unicode characters in length.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>When this field is present, the 'MetricThreshold' condition forecasts whether the time series is predicted to violate the threshold within the 'forecastHorizon'. When this field is not set, the 'MetricThreshold' tests the current value of the timeseries against the threshold.</summary>
    [JsonPropertyName("forecastOptions")]
    public V1beta1MonitoringAlertPolicySpecConditionsConditionThresholdForecastOptions? ForecastOptions { get; set; }

    /// <summary>A value against which to compare the time series.</summary>
    [JsonPropertyName("thresholdValue")]
    public double? ThresholdValue { get; set; }

    /// <summary>The number/percent of time series for which the comparison must hold in order for the condition to trigger. If unspecified, then the condition will trigger if the comparison is true for any of the time series that have been identified by filter and aggregations, or by the ratio, if denominator_filter and denominator_aggregations are specified.</summary>
    [JsonPropertyName("trigger")]
    public V1beta1MonitoringAlertPolicySpecConditionsConditionThresholdTrigger? Trigger { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecConditions
{
    /// <summary>A condition that checks that a time series continues to receive new data points.</summary>
    [JsonPropertyName("conditionAbsent")]
    public V1beta1MonitoringAlertPolicySpecConditionsConditionAbsent? ConditionAbsent { get; set; }

    /// <summary>A condition that checks for log messages matching given constraints. If set, no other conditions can be present.</summary>
    [JsonPropertyName("conditionMatchedLog")]
    public V1beta1MonitoringAlertPolicySpecConditionsConditionMatchedLog? ConditionMatchedLog { get; set; }

    /// <summary>A Monitoring Query Language query that outputs a boolean stream.</summary>
    [JsonPropertyName("conditionMonitoringQueryLanguage")]
    public V1beta1MonitoringAlertPolicySpecConditionsConditionMonitoringQueryLanguage? ConditionMonitoringQueryLanguage { get; set; }

    /// <summary>A Monitoring Query Language query that outputs a boolean stream  A condition type that allows alert policies to be defined using Prometheus Query Language (PromQL).  The PrometheusQueryLanguageCondition message contains information from a Prometheus alerting rule and its associated rule group.</summary>
    [JsonPropertyName("conditionPrometheusQueryLanguage")]
    public V1beta1MonitoringAlertPolicySpecConditionsConditionPrometheusQueryLanguage? ConditionPrometheusQueryLanguage { get; set; }

    /// <summary>A condition that compares a time series against a threshold.</summary>
    [JsonPropertyName("conditionThreshold")]
    public V1beta1MonitoringAlertPolicySpecConditionsConditionThreshold? ConditionThreshold { get; set; }

    /// <summary>A short name or phrase used to identify the condition in dashboards, notifications, and incidents. To avoid confusion, don't use the same display name for multiple conditions in the same policy.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>The unique resource name for this condition. Its syntax is: projects/[PROJECT_ID]/alertPolicies/[POLICY_ID]/conditions/[CONDITION_ID] [CONDITION_ID] is assigned by Stackdriver Monitoring when the condition is created as part of a new or updated alerting policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Documentation that is included with notifications and incidents related to this policy. Best practice is for the documentation to include information to help responders understand, mitigate, escalate, and correct the underlying problems detected by the alerting policy. Notification channels that have limited capacity might not show this documentation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecDocumentation
{
    /// <summary>The text of the documentation, interpreted according to mimeType. The content may not exceed 8,192 Unicode characters and may not exceed more than 10,240 bytes when encoded in UTF-8 format, whichever is smaller.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The format of the content field. Presently, only the value "text/markdown" is supported.</summary>
    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }
}

/// <summary>Identifies the notification channels to which notifications should be sent when incidents are opened or closed or when new violations occur on an already opened incident.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpecNotificationChannels
{
    /// <summary>Allowed value: The `name` field of a `MonitoringNotificationChannel` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicySpec
{
    /// <summary>Control over how this alert policy's notification channels are notified.</summary>
    [JsonPropertyName("alertStrategy")]
    public V1beta1MonitoringAlertPolicySpecAlertStrategy? AlertStrategy { get; set; }

    /// <summary>How to combine the results of multiple conditions to determine if an incident should be opened. Possible values: ["AND", "OR", "AND_WITH_MATCHING_RESOURCE"].</summary>
    [JsonPropertyName("combiner")]
    public string Combiner { get; set; }

    /// <summary>A list of conditions for the policy. The conditions are combined by AND or OR according to the combiner field. If the combined conditions evaluate to true, then an incident is created. A policy can have from one to six conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitoringAlertPolicySpecConditions> Conditions { get; set; }

    /// <summary>A short name or phrase used to identify the policy in dashboards, notifications, and incidents. To avoid confusion, don't use the same display name for multiple policies in the same project. The name is limited to 512 Unicode characters.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Documentation that is included with notifications and incidents related to this policy. Best practice is for the documentation to include information to help responders understand, mitigate, escalate, and correct the underlying problems detected by the alerting policy. Notification channels that have limited capacity might not show this documentation.</summary>
    [JsonPropertyName("documentation")]
    public V1beta1MonitoringAlertPolicySpecDocumentation? Documentation { get; set; }

    /// <summary>Whether or not the policy is enabled. The default is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notificationChannels")]
    public IList<V1beta1MonitoringAlertPolicySpecNotificationChannels>? NotificationChannels { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The severity of an alert policy indicates how important incidents generated by that policy are. The severity level will be displayed on the Incident detail page and in notifications. Possible values: ["CRITICAL", "ERROR", "WARNING"].</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicyStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicyStatusCreationRecord
{
    /// <summary>When the change occurred.</summary>
    [JsonPropertyName("mutateTime")]
    public string? MutateTime { get; set; }

    /// <summary>The email address of the user making the change.</summary>
    [JsonPropertyName("mutatedBy")]
    public string? MutatedBy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitoringAlertPolicyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitoringAlertPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>A read-only record of the creation of the alerting policy. If provided in a call to create or update, this field will be ignored.</summary>
    [JsonPropertyName("creationRecord")]
    public IList<V1beta1MonitoringAlertPolicyStatusCreationRecord>? CreationRecord { get; set; }

    /// <summary>The unique resource name for this policy. Its syntax is: projects/[PROJECT_ID]/alertPolicies/[ALERT_POLICY_ID].</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitoringAlertPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitoringAlertPolicySpec>, IStatus<V1beta1MonitoringAlertPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitoringAlertPolicy";
    public const string KubeGroup = "monitoring.cnrm.cloud.google.com";
    public const string KubePluralName = "monitoringalertpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1MonitoringAlertPolicySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1MonitoringAlertPolicyStatus? Status { get; set; }
}