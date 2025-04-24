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
public partial class MonitoringServiceLevelObjectiveMetadata
{
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecProjectRef
{
    /// <summary>The project for the resource  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Good service is defined to be the count of requests made to this service that are fast enough with respect to `latency.threshold`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorBasicSliLatency
{
    /// <summary>A description of the experience associated with failing requests. Possible values: LATENCY_EXPERIENCE_UNSPECIFIED, DELIGHTING, SATISFYING, ANNOYING</summary>
    [JsonPropertyName("experience")]
    public string? Experience { get; set; }

    /// <summary>Good service is defined to be the count of requests made to this service that return in no more than `threshold`.</summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

/// <summary>Good service is defined to be the count of operations performed by this service that are fast enough with respect to `operation_latency.threshold`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorBasicSliOperationLatency
{
    /// <summary>A description of the experience associated with failing requests. Possible values: LATENCY_EXPERIENCE_UNSPECIFIED, DELIGHTING, SATISFYING, ANNOYING</summary>
    [JsonPropertyName("experience")]
    public string? Experience { get; set; }

    /// <summary>Good service is defined to be the count of operations that are completed in no more than `threshold`.</summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

/// <summary>Basic SLI on a well-known service type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorBasicSli
{
    /// <summary>Good service is defined to be the count of requests made to this service that return successfully.</summary>
    [JsonPropertyName("availability")]
    public JsonNode? Availability { get; set; }

    /// <summary>Good service is defined to be the count of requests made to this service that are fast enough with respect to `latency.threshold`.</summary>
    [JsonPropertyName("latency")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorBasicSliLatency? Latency { get; set; }

    /// <summary>OPTIONAL: The set of locations to which this SLI is relevant. Telemetry from other locations will not be used to calculate performance for this SLI. If omitted, this SLI applies to all locations in which the Service has activity. For service types that don't support breaking down by location, setting this field will result in an error.</summary>
    [JsonPropertyName("location")]
    public IList<string>? Location { get; set; }

    /// <summary>OPTIONAL: The set of RPCs to which this SLI is relevant. Telemetry from other methods will not be used to calculate performance for this SLI. If omitted, this SLI applies to all the Service's methods. For service types that don't support breaking down by method, setting this field will result in an error.</summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>Good service is defined to be the count of operations performed by this service that return successfully</summary>
    [JsonPropertyName("operationAvailability")]
    public JsonNode? OperationAvailability { get; set; }

    /// <summary>Good service is defined to be the count of operations performed by this service that are fast enough with respect to `operation_latency.threshold`.</summary>
    [JsonPropertyName("operationLatency")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorBasicSliOperationLatency? OperationLatency { get; set; }

    /// <summary>OPTIONAL: The set of API versions to which this SLI is relevant. Telemetry from other API versions will not be used to calculate performance for this SLI. If omitted, this SLI applies to all API versions. For service types that don't support breaking down by version, setting this field will result in an error.</summary>
    [JsonPropertyName("version")]
    public IList<string>? Version { get; set; }
}

/// <summary>Range of values considered "good." For a one-sided range, set one bound to an infinite value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorRequestBasedDistributionCutRange
{
    /// <summary>Range maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Range minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>`distribution_cut` is used when `good_service` is a count of values aggregated in a `Distribution` that fall into a good range. The `total_service` is the total count of all values aggregated in the `Distribution`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorRequestBasedDistributionCut
{
    /// <summary>A [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) specifying a `TimeSeries` aggregating values. Must have `ValueType = DISTRIBUTION` and `MetricKind = DELTA` or `MetricKind = CUMULATIVE`.</summary>
    [JsonPropertyName("distributionFilter")]
    public string? DistributionFilter { get; set; }

    /// <summary>Range of values considered "good." For a one-sided range, set one bound to an infinite value.</summary>
    [JsonPropertyName("range")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorRequestBasedDistributionCutRange? Range { get; set; }
}

/// <summary>`good_total_ratio` is used when the ratio of `good_service` to `total_service` is computed from two `TimeSeries`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorRequestBasedGoodTotalRatio
{
    /// <summary>A [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) specifying a `TimeSeries` quantifying bad service, either demanded service that was not provided or demanded service that was of inadequate quality. Must have `ValueType = DOUBLE` or `ValueType = INT64` and must have `MetricKind = DELTA` or `MetricKind = CUMULATIVE`.</summary>
    [JsonPropertyName("badServiceFilter")]
    public string? BadServiceFilter { get; set; }

    /// <summary>A [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) specifying a `TimeSeries` quantifying good service provided. Must have `ValueType = DOUBLE` or `ValueType = INT64` and must have `MetricKind = DELTA` or `MetricKind = CUMULATIVE`.</summary>
    [JsonPropertyName("goodServiceFilter")]
    public string? GoodServiceFilter { get; set; }

    /// <summary>A [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) specifying a `TimeSeries` quantifying total demanded service. Must have `ValueType = DOUBLE` or `ValueType = INT64` and must have `MetricKind = DELTA` or `MetricKind = CUMULATIVE`.</summary>
    [JsonPropertyName("totalServiceFilter")]
    public string? TotalServiceFilter { get; set; }
}

/// <summary>Request-based SLIs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorRequestBased
{
    /// <summary>`distribution_cut` is used when `good_service` is a count of values aggregated in a `Distribution` that fall into a good range. The `total_service` is the total count of all values aggregated in the `Distribution`.</summary>
    [JsonPropertyName("distributionCut")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorRequestBasedDistributionCut? DistributionCut { get; set; }

    /// <summary>`good_total_ratio` is used when the ratio of `good_service` to `total_service` is computed from two `TimeSeries`.</summary>
    [JsonPropertyName("goodTotalRatio")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorRequestBasedGoodTotalRatio? GoodTotalRatio { get; set; }
}

/// <summary>Good service is defined to be the count of requests made to this service that are fast enough with respect to `latency.threshold`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThresholdBasicSliPerformanceLatency
{
    /// <summary>A description of the experience associated with failing requests. Possible values: LATENCY_EXPERIENCE_UNSPECIFIED, DELIGHTING, SATISFYING, ANNOYING</summary>
    [JsonPropertyName("experience")]
    public string? Experience { get; set; }

    /// <summary>Good service is defined to be the count of requests made to this service that return in no more than `threshold`.</summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

/// <summary>Good service is defined to be the count of operations performed by this service that are fast enough with respect to `operation_latency.threshold`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThresholdBasicSliPerformanceOperationLatency
{
    /// <summary>A description of the experience associated with failing requests. Possible values: LATENCY_EXPERIENCE_UNSPECIFIED, DELIGHTING, SATISFYING, ANNOYING</summary>
    [JsonPropertyName("experience")]
    public string? Experience { get; set; }

    /// <summary>Good service is defined to be the count of operations that are completed in no more than `threshold`.</summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

/// <summary>`BasicSli` to evaluate to judge window quality.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThresholdBasicSliPerformance
{
    /// <summary>Good service is defined to be the count of requests made to this service that return successfully.</summary>
    [JsonPropertyName("availability")]
    public JsonNode? Availability { get; set; }

    /// <summary>Good service is defined to be the count of requests made to this service that are fast enough with respect to `latency.threshold`.</summary>
    [JsonPropertyName("latency")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThresholdBasicSliPerformanceLatency? Latency { get; set; }

    /// <summary>OPTIONAL: The set of locations to which this SLI is relevant. Telemetry from other locations will not be used to calculate performance for this SLI. If omitted, this SLI applies to all locations in which the Service has activity. For service types that don't support breaking down by location, setting this field will result in an error.</summary>
    [JsonPropertyName("location")]
    public IList<string>? Location { get; set; }

    /// <summary>OPTIONAL: The set of RPCs to which this SLI is relevant. Telemetry from other methods will not be used to calculate performance for this SLI. If omitted, this SLI applies to all the Service's methods. For service types that don't support breaking down by method, setting this field will result in an error.</summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>Good service is defined to be the count of operations performed by this service that return successfully</summary>
    [JsonPropertyName("operationAvailability")]
    public JsonNode? OperationAvailability { get; set; }

    /// <summary>Good service is defined to be the count of operations performed by this service that are fast enough with respect to `operation_latency.threshold`.</summary>
    [JsonPropertyName("operationLatency")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThresholdBasicSliPerformanceOperationLatency? OperationLatency { get; set; }

    /// <summary>OPTIONAL: The set of API versions to which this SLI is relevant. Telemetry from other API versions will not be used to calculate performance for this SLI. If omitted, this SLI applies to all API versions. For service types that don't support breaking down by version, setting this field will result in an error.</summary>
    [JsonPropertyName("version")]
    public IList<string>? Version { get; set; }
}

/// <summary>Range of values considered "good." For a one-sided range, set one bound to an infinite value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThresholdPerformanceDistributionCutRange
{
    /// <summary>Range maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Range minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>`distribution_cut` is used when `good_service` is a count of values aggregated in a `Distribution` that fall into a good range. The `total_service` is the total count of all values aggregated in the `Distribution`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThresholdPerformanceDistributionCut
{
    /// <summary>A [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) specifying a `TimeSeries` aggregating values. Must have `ValueType = DISTRIBUTION` and `MetricKind = DELTA` or `MetricKind = CUMULATIVE`.</summary>
    [JsonPropertyName("distributionFilter")]
    public string? DistributionFilter { get; set; }

    /// <summary>Range of values considered "good." For a one-sided range, set one bound to an infinite value.</summary>
    [JsonPropertyName("range")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThresholdPerformanceDistributionCutRange? Range { get; set; }
}

/// <summary>`good_total_ratio` is used when the ratio of `good_service` to `total_service` is computed from two `TimeSeries`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThresholdPerformanceGoodTotalRatio
{
    /// <summary>A [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) specifying a `TimeSeries` quantifying bad service, either demanded service that was not provided or demanded service that was of inadequate quality. Must have `ValueType = DOUBLE` or `ValueType = INT64` and must have `MetricKind = DELTA` or `MetricKind = CUMULATIVE`.</summary>
    [JsonPropertyName("badServiceFilter")]
    public string? BadServiceFilter { get; set; }

    /// <summary>A [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) specifying a `TimeSeries` quantifying good service provided. Must have `ValueType = DOUBLE` or `ValueType = INT64` and must have `MetricKind = DELTA` or `MetricKind = CUMULATIVE`.</summary>
    [JsonPropertyName("goodServiceFilter")]
    public string? GoodServiceFilter { get; set; }

    /// <summary>A [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) specifying a `TimeSeries` quantifying total demanded service. Must have `ValueType = DOUBLE` or `ValueType = INT64` and must have `MetricKind = DELTA` or `MetricKind = CUMULATIVE`.</summary>
    [JsonPropertyName("totalServiceFilter")]
    public string? TotalServiceFilter { get; set; }
}

/// <summary>`RequestBasedSli` to evaluate to judge window quality.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThresholdPerformance
{
    /// <summary>`distribution_cut` is used when `good_service` is a count of values aggregated in a `Distribution` that fall into a good range. The `total_service` is the total count of all values aggregated in the `Distribution`.</summary>
    [JsonPropertyName("distributionCut")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThresholdPerformanceDistributionCut? DistributionCut { get; set; }

    /// <summary>`good_total_ratio` is used when the ratio of `good_service` to `total_service` is computed from two `TimeSeries`.</summary>
    [JsonPropertyName("goodTotalRatio")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThresholdPerformanceGoodTotalRatio? GoodTotalRatio { get; set; }
}

/// <summary>A window is good if its `performance` is high enough.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThreshold
{
    /// <summary>`BasicSli` to evaluate to judge window quality.</summary>
    [JsonPropertyName("basicSliPerformance")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThresholdBasicSliPerformance? BasicSliPerformance { get; set; }

    /// <summary>`RequestBasedSli` to evaluate to judge window quality.</summary>
    [JsonPropertyName("performance")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThresholdPerformance? Performance { get; set; }

    /// <summary>If window `performance &gt;= threshold`, the window is counted as good.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

/// <summary>Range of values considered "good." For a one-sided range, set one bound to an infinite value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedMetricMeanInRangeRange
{
    /// <summary>Range maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Range minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>A window is good if the metric's value is in a good range, averaged across returned streams.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedMetricMeanInRange
{
    /// <summary>Range of values considered "good." For a one-sided range, set one bound to an infinite value.</summary>
    [JsonPropertyName("range")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedMetricMeanInRangeRange? Range { get; set; }

    /// <summary>A [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) specifying the `TimeSeries` to use for evaluating window quality.</summary>
    [JsonPropertyName("timeSeries")]
    public string? TimeSeries { get; set; }
}

/// <summary>Range of values considered "good." For a one-sided range, set one bound to an infinite value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedMetricSumInRangeRange
{
    /// <summary>Range maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Range minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>A window is good if the metric's value is in a good range, summed across returned streams.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedMetricSumInRange
{
    /// <summary>Range of values considered "good." For a one-sided range, set one bound to an infinite value.</summary>
    [JsonPropertyName("range")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedMetricSumInRangeRange? Range { get; set; }

    /// <summary>A [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) specifying the `TimeSeries` to use for evaluating window quality.</summary>
    [JsonPropertyName("timeSeries")]
    public string? TimeSeries { get; set; }
}

/// <summary>Windows-based SLIs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBased
{
    /// <summary>A [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) specifying a `TimeSeries` with `ValueType = BOOL`. The window is good if any `true` values appear in the window.</summary>
    [JsonPropertyName("goodBadMetricFilter")]
    public string? GoodBadMetricFilter { get; set; }

    /// <summary>A window is good if its `performance` is high enough.</summary>
    [JsonPropertyName("goodTotalRatioThreshold")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedGoodTotalRatioThreshold? GoodTotalRatioThreshold { get; set; }

    /// <summary>A window is good if the metric's value is in a good range, averaged across returned streams.</summary>
    [JsonPropertyName("metricMeanInRange")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedMetricMeanInRange? MetricMeanInRange { get; set; }

    /// <summary>A window is good if the metric's value is in a good range, summed across returned streams.</summary>
    [JsonPropertyName("metricSumInRange")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBasedMetricSumInRange? MetricSumInRange { get; set; }

    /// <summary>Duration over which window quality is evaluated. Must be an integer fraction of a day and at least `60s`.</summary>
    [JsonPropertyName("windowPeriod")]
    public string? WindowPeriod { get; set; }
}

/// <summary>The definition of good service, used to measure and calculate the quality of the `Service`'s performance with respect to a single aspect of service quality.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceLevelIndicator
{
    /// <summary>Basic SLI on a well-known service type.</summary>
    [JsonPropertyName("basicSli")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorBasicSli? BasicSli { get; set; }

    /// <summary>Request-based SLIs</summary>
    [JsonPropertyName("requestBased")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorRequestBased? RequestBased { get; set; }

    /// <summary>Windows-based SLIs</summary>
    [JsonPropertyName("windowsBased")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicatorWindowsBased? WindowsBased { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveSpecServiceRef
{
    /// <summary>The service for the resource  Allowed value: The Google Cloud resource name of a `MonitoringService` resource (format: `projects/{{project}}/services/{{name}}`).</summary>
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
public partial class MonitoringServiceLevelObjectiveSpec
{
    /// <summary>A calendar period, semantically "since the start of the current ``". At this time, only `DAY`, `WEEK`, `FORTNIGHT`, and `MONTH` are supported. Possible values: CALENDAR_PERIOD_UNSPECIFIED, DAY, WEEK, FORTNIGHT, MONTH, QUARTER, HALF, YEAR</summary>
    [JsonPropertyName("calendarPeriod")]
    public string? CalendarPeriod { get; set; }

    /// <summary>Name used for UI elements listing this SLO.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The fraction of service that must be good in order for this objective to be met. `0 &lt; goal &lt;= 0.999`.</summary>
    [JsonPropertyName("goal")]
    public double Goal { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public MonitoringServiceLevelObjectiveSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>A rolling time period, semantically "in the past ``". Must be an integer multiple of 1 day no larger than 30 days.</summary>
    [JsonPropertyName("rollingPeriod")]
    public string? RollingPeriod { get; set; }

    /// <summary>The definition of good service, used to measure and calculate the quality of the `Service`'s performance with respect to a single aspect of service quality.</summary>
    [JsonPropertyName("serviceLevelIndicator")]
    public MonitoringServiceLevelObjectiveSpecServiceLevelIndicator? ServiceLevelIndicator { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("serviceRef")]
    public MonitoringServiceLevelObjectiveSpecServiceRef ServiceRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjectiveStatusConditions
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
public partial class MonitoringServiceLevelObjectiveStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<MonitoringServiceLevelObjectiveStatusConditions>? Conditions { get; set; }

    /// <summary>Time stamp of the `Create` or most recent `Update` command on this `Slo`.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Time stamp of the `Update` or `Delete` command that made this no longer a current `Slo`. This field is not populated in `ServiceLevelObjective`s returned from calls to `GetServiceLevelObjective` and `ListServiceLevelObjectives`, because it is always empty in the current version. It is populated in `ServiceLevelObjective`s representing previous versions in the output of `ListServiceLevelObjectiveVersions`. Because all old configuration versions are stored, `Update` operations mark the obsoleted version as deleted.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. If set, this SLO is managed at the [Service Management](https://cloud.google.com/service-management/overview) level. Therefore the service yaml file is the source of truth for this SLO, and API `Update` and `Delete` operations are forbidden.</summary>
    [JsonPropertyName("serviceManagementOwned")]
    public bool? ServiceManagementOwned { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MonitoringServiceLevelObjective
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public MonitoringServiceLevelObjectiveMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public MonitoringServiceLevelObjectiveSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public MonitoringServiceLevelObjectiveStatus? Status { get; set; }
}