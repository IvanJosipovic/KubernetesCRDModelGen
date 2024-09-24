using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.monitoring.gcp.upbound.io;
public enum V1beta1SLOSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1SLOSpecForProviderBasicSliAvailability
{
    /// <summary>Whether an availability SLI is enabled or not. Must be set to true. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1SLOSpecForProviderBasicSliLatency
{
    /// <summary>A duration string, e.g. 10s. Good service is defined to be the count of requests made to this service that return in no more than threshold.</summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

public partial class V1beta1SLOSpecForProviderBasicSli
{
    /// <summary>Availability based SLI, dervied from count of requests made to this service that return successfully. Structure is documented below.</summary>
    [JsonPropertyName("availability")]
    public IList<V1beta1SLOSpecForProviderBasicSliAvailability>? Availability { get; set; }

    /// <summary>Parameters for a latency threshold SLI. Structure is documented below.</summary>
    [JsonPropertyName("latency")]
    public IList<V1beta1SLOSpecForProviderBasicSliLatency>? Latency { get; set; }

    /// <summary>An optional set of locations to which this SLI is relevant. Telemetry from other locations will not be used to calculate performance for this SLI. If omitted, this SLI applies to all locations in which the Service has activity. For service types that don't support breaking down by location, setting this field will result in an error.</summary>
    [JsonPropertyName("location")]
    public IList<string>? Location { get; set; }

    /// <summary>An optional set of RPCs to which this SLI is relevant. Telemetry from other methods will not be used to calculate performance for this SLI. If omitted, this SLI applies to all the Service's methods. For service types that don't support breaking down by method, setting this field will result in an error.</summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>The set of API versions to which this SLI is relevant. Telemetry from other API versions will not be used to calculate performance for this SLI. If omitted, this SLI applies to all API versions. For service types that don't support breaking down by version, setting this field will result in an error.</summary>
    [JsonPropertyName("version")]
    public IList<string>? Version { get; set; }
}

public partial class V1beta1SLOSpecForProviderRequestBasedSliDistributionCutRange
{
    /// <summary>max value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Min value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1SLOSpecForProviderRequestBasedSliDistributionCut
{
    /// <summary>A TimeSeries monitoring filter aggregating values to quantify the good service provided. Must have ValueType = DISTRIBUTION and MetricKind = DELTA or MetricKind = CUMULATIVE.</summary>
    [JsonPropertyName("distributionFilter")]
    public string? DistributionFilter { get; set; }

    /// <summary>Range of numerical values. The computed good_service will be the count of values x in the Distribution such that range.min &lt;= x &lt;= range.max. inclusive of min and max. Open ranges can be defined by setting just one of min or max. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public IList<V1beta1SLOSpecForProviderRequestBasedSliDistributionCutRange>? Range { get; set; }
}

public partial class V1beta1SLOSpecForProviderRequestBasedSliGoodTotalRatio
{
    /// <summary>A TimeSeries monitoring filter quantifying bad service provided, either demanded service that was not provided or demanded service that was of inadequate quality. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("badServiceFilter")]
    public string? BadServiceFilter { get; set; }

    /// <summary>A TimeSeries monitoring filter quantifying good service provided. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("goodServiceFilter")]
    public string? GoodServiceFilter { get; set; }

    /// <summary>A TimeSeries monitoring filter quantifying total demanded service. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("totalServiceFilter")]
    public string? TotalServiceFilter { get; set; }
}

public partial class V1beta1SLOSpecForProviderRequestBasedSli
{
    /// <summary>Used when good_service is defined by a count of values aggregated in a Distribution that fall into a good range. The total_service is the total count of all values aggregated in the Distribution. Defines a distribution TimeSeries filter and thresholds used for measuring good service and total service. Exactly one of distribution_cut or good_total_ratio can be set. Structure is documented below.</summary>
    [JsonPropertyName("distributionCut")]
    public IList<V1beta1SLOSpecForProviderRequestBasedSliDistributionCut>? DistributionCut { get; set; }

    /// <summary>A means to compute a ratio of good_service to total_service. Defines computing this ratio with two TimeSeries monitoring filters Must specify exactly two of good, bad, and total service filters. The relationship good_service + bad_service = total_service will be assumed. Exactly one of distribution_cut or good_total_ratio can be set. Structure is documented below.</summary>
    [JsonPropertyName("goodTotalRatio")]
    public IList<V1beta1SLOSpecForProviderRequestBasedSliGoodTotalRatio>? GoodTotalRatio { get; set; }
}

public enum V1beta1SLOSpecForProviderServiceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SLOSpecForProviderServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SLOSpecForProviderServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SLOSpecForProviderServiceRefPolicyResolutionEnum>))]
    public V1beta1SLOSpecForProviderServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SLOSpecForProviderServiceRefPolicyResolveEnum>))]
    public V1beta1SLOSpecForProviderServiceRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SLOSpecForProviderServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SLOSpecForProviderServiceRefPolicy? Policy { get; set; }
}

public enum V1beta1SLOSpecForProviderServiceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SLOSpecForProviderServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SLOSpecForProviderServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SLOSpecForProviderServiceSelectorPolicyResolutionEnum>))]
    public V1beta1SLOSpecForProviderServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SLOSpecForProviderServiceSelectorPolicyResolveEnum>))]
    public V1beta1SLOSpecForProviderServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SLOSpecForProviderServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SLOSpecForProviderServiceSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceAvailability
{
    /// <summary>Whether an availability SLI is enabled or not. Must be set to true. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceLatency
{
    /// <summary>A duration string, e.g. 10s. Good service is defined to be the count of requests made to this service that return in no more than threshold.</summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

public partial class V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformance
{
    /// <summary>Availability based SLI, dervied from count of requests made to this service that return successfully. Structure is documented below.</summary>
    [JsonPropertyName("availability")]
    public IList<V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceAvailability>? Availability { get; set; }

    /// <summary>Parameters for a latency threshold SLI. Structure is documented below.</summary>
    [JsonPropertyName("latency")]
    public IList<V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceLatency>? Latency { get; set; }

    /// <summary>An optional set of locations to which this SLI is relevant. Telemetry from other locations will not be used to calculate performance for this SLI. If omitted, this SLI applies to all locations in which the Service has activity. For service types that don't support breaking down by location, setting this field will result in an error.</summary>
    [JsonPropertyName("location")]
    public IList<string>? Location { get; set; }

    /// <summary>An optional set of RPCs to which this SLI is relevant. Telemetry from other methods will not be used to calculate performance for this SLI. If omitted, this SLI applies to all the Service's methods. For service types that don't support breaking down by method, setting this field will result in an error.</summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>The set of API versions to which this SLI is relevant. Telemetry from other API versions will not be used to calculate performance for this SLI. If omitted, this SLI applies to all API versions. For service types that don't support breaking down by version, setting this field will result in an error.</summary>
    [JsonPropertyName("version")]
    public IList<string>? Version { get; set; }
}

public partial class V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCutRange
{
    /// <summary>max value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Min value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCut
{
    /// <summary>A TimeSeries monitoring filter aggregating values to quantify the good service provided. Must have ValueType = DISTRIBUTION and MetricKind = DELTA or MetricKind = CUMULATIVE.</summary>
    [JsonPropertyName("distributionFilter")]
    public string? DistributionFilter { get; set; }

    /// <summary>Range of numerical values. The computed good_service will be the count of values x in the Distribution such that range.min &lt;= x &lt;= range.max. inclusive of min and max. Open ranges can be defined by setting just one of min or max. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public IList<V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCutRange>? Range { get; set; }
}

public partial class V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceGoodTotalRatio
{
    /// <summary>A TimeSeries monitoring filter quantifying bad service provided, either demanded service that was not provided or demanded service that was of inadequate quality. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("badServiceFilter")]
    public string? BadServiceFilter { get; set; }

    /// <summary>A TimeSeries monitoring filter quantifying good service provided. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("goodServiceFilter")]
    public string? GoodServiceFilter { get; set; }

    /// <summary>A TimeSeries monitoring filter quantifying total demanded service. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("totalServiceFilter")]
    public string? TotalServiceFilter { get; set; }
}

public partial class V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformance
{
    /// <summary>Used when good_service is defined by a count of values aggregated in a Distribution that fall into a good range. The total_service is the total count of all values aggregated in the Distribution. Defines a distribution TimeSeries filter and thresholds used for measuring good service and total service. Exactly one of distribution_cut or good_total_ratio can be set. Structure is documented below.</summary>
    [JsonPropertyName("distributionCut")]
    public IList<V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCut>? DistributionCut { get; set; }

    /// <summary>A means to compute a ratio of good_service to total_service. Defines computing this ratio with two TimeSeries monitoring filters Must specify exactly two of good, bad, and total service filters. The relationship good_service + bad_service = total_service will be assumed. Exactly one of distribution_cut or good_total_ratio can be set. Structure is documented below.</summary>
    [JsonPropertyName("goodTotalRatio")]
    public IList<V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceGoodTotalRatio>? GoodTotalRatio { get; set; }
}

public partial class V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThreshold
{
    /// <summary>Basic SLI to evaluate to judge window quality. Structure is documented below.</summary>
    [JsonPropertyName("basicSliPerformance")]
    public IList<V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformance>? BasicSliPerformance { get; set; }

    /// <summary>Request-based SLI to evaluate to judge window quality. Structure is documented below.</summary>
    [JsonPropertyName("performance")]
    public IList<V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThresholdPerformance>? Performance { get; set; }

    /// <summary>A duration string, e.g. 10s. Good service is defined to be the count of requests made to this service that return in no more than threshold.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

public partial class V1beta1SLOSpecForProviderWindowsBasedSliMetricMeanInRangeRange
{
    /// <summary>max value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Min value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1SLOSpecForProviderWindowsBasedSliMetricMeanInRange
{
    /// <summary>Range of numerical values. The computed good_service will be the count of values x in the Distribution such that range.min &lt;= x &lt;= range.max. inclusive of min and max. Open ranges can be defined by setting just one of min or max. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public IList<V1beta1SLOSpecForProviderWindowsBasedSliMetricMeanInRangeRange>? Range { get; set; }

    /// <summary>A monitoring filter specifying the TimeSeries to use for evaluating window quality. The provided TimeSeries must have ValueType = INT64 or ValueType = DOUBLE and MetricKind = GAUGE. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window.</summary>
    [JsonPropertyName("timeSeries")]
    public string? TimeSeries { get; set; }
}

public partial class V1beta1SLOSpecForProviderWindowsBasedSliMetricSumInRangeRange
{
    /// <summary>max value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Min value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1SLOSpecForProviderWindowsBasedSliMetricSumInRange
{
    /// <summary>Range of numerical values. The computed good_service will be the count of values x in the Distribution such that range.min &lt;= x &lt;= range.max. inclusive of min and max. Open ranges can be defined by setting just one of min or max. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public IList<V1beta1SLOSpecForProviderWindowsBasedSliMetricSumInRangeRange>? Range { get; set; }

    /// <summary>A monitoring filter specifying the TimeSeries to use for evaluating window quality. The provided TimeSeries must have ValueType = INT64 or ValueType = DOUBLE and MetricKind = GAUGE. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window.</summary>
    [JsonPropertyName("timeSeries")]
    public string? TimeSeries { get; set; }
}

public partial class V1beta1SLOSpecForProviderWindowsBasedSli
{
    /// <summary>A TimeSeries monitoring filter with ValueType = BOOL. The window is good if any true values appear in the window. One of good_bad_metric_filter, good_total_ratio_threshold, metric_mean_in_range, metric_sum_in_range must be set for windows_based_sli.</summary>
    [JsonPropertyName("goodBadMetricFilter")]
    public string? GoodBadMetricFilter { get; set; }

    /// <summary>Criterion that describes a window as good if its performance is high enough. One of good_bad_metric_filter, good_total_ratio_threshold, metric_mean_in_range, metric_sum_in_range must be set for windows_based_sli. Structure is documented below.</summary>
    [JsonPropertyName("goodTotalRatioThreshold")]
    public IList<V1beta1SLOSpecForProviderWindowsBasedSliGoodTotalRatioThreshold>? GoodTotalRatioThreshold { get; set; }

    /// <summary>Criterion that describes a window as good if the metric's value is in a good range, averaged across returned streams. One of good_bad_metric_filter, good_total_ratio_threshold, metric_mean_in_range, metric_sum_in_range must be set for windows_based_sli. Average value X of time_series should satisfy range.min &lt;= X &lt;= range.max for a good window. Structure is documented below.</summary>
    [JsonPropertyName("metricMeanInRange")]
    public IList<V1beta1SLOSpecForProviderWindowsBasedSliMetricMeanInRange>? MetricMeanInRange { get; set; }

    /// <summary>Criterion that describes a window as good if the metric's value is in a good range, summed across returned streams. Summed value X of time_series should satisfy range.min &lt;= X &lt;= range.max for a good window. One of good_bad_metric_filter, good_total_ratio_threshold, metric_mean_in_range, metric_sum_in_range must be set for windows_based_sli. Structure is documented below.</summary>
    [JsonPropertyName("metricSumInRange")]
    public IList<V1beta1SLOSpecForProviderWindowsBasedSliMetricSumInRange>? MetricSumInRange { get; set; }

    /// <summary>Duration over which window quality is evaluated, given as a duration string "{X}s" representing X seconds. Must be an integer fraction of a day and at least 60s.</summary>
    [JsonPropertyName("windowPeriod")]
    public string? WindowPeriod { get; set; }
}

public partial class V1beta1SLOSpecForProvider
{
    /// <summary>Basic Service-Level Indicator (SLI) on a well-known service type. Performance will be computed on the basis of pre-defined metrics. SLIs are used to measure and calculate the quality of the Service's performance with respect to a single aspect of service quality. Exactly one of the following must be set: basic_sli, request_based_sli, windows_based_sli Structure is documented below.</summary>
    [JsonPropertyName("basicSli")]
    public IList<V1beta1SLOSpecForProviderBasicSli>? BasicSli { get; set; }

    /// <summary>A calendar period, semantically "since the start of the current ". Possible values are: DAY, WEEK, FORTNIGHT, MONTH.</summary>
    [JsonPropertyName("calendarPeriod")]
    public string? CalendarPeriod { get; set; }

    /// <summary>Name used for UI elements listing this SLO.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The fraction of service that must be good in order for this objective to be met. 0 &lt; goal &lt;= 0.999</summary>
    [JsonPropertyName("goal")]
    public double? Goal { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A request-based SLI defines a SLI for which atomic units of service are counted directly. A SLI describes a good service. It is used to measure and calculate the quality of the Service's performance with respect to a single aspect of service quality. Exactly one of the following must be set: basic_sli, request_based_sli, windows_based_sli Structure is documented below.</summary>
    [JsonPropertyName("requestBasedSli")]
    public IList<V1beta1SLOSpecForProviderRequestBasedSli>? RequestBasedSli { get; set; }

    /// <summary>A rolling time period, semantically "in the past X days". Must be between 1 to 30 days, inclusive.</summary>
    [JsonPropertyName("rollingPeriodDays")]
    public double? RollingPeriodDays { get; set; }

    /// <summary>ID of the service to which this SLO belongs.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a CustomService in monitoring to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1SLOSpecForProviderServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a CustomService in monitoring to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1SLOSpecForProviderServiceSelector? ServiceSelector { get; set; }

    /// <summary>The id to use for this ServiceLevelObjective. If omitted, an id will be generated instead.</summary>
    [JsonPropertyName("sloId")]
    public string? SloId { get; set; }

    /// <summary>This field is intended to be used for organizing and identifying the AlertPolicy objects.The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.</summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }

    /// <summary>A windows-based SLI defines the criteria for time windows. good_service is defined based off the count of these time windows for which the provided service was of good quality. A SLI describes a good service. It is used to measure and calculate the quality of the Service's performance with respect to a single aspect of service quality. Exactly one of the following must be set: basic_sli, request_based_sli, windows_based_sli Structure is documented below.</summary>
    [JsonPropertyName("windowsBasedSli")]
    public IList<V1beta1SLOSpecForProviderWindowsBasedSli>? WindowsBasedSli { get; set; }
}

public partial class V1beta1SLOSpecInitProviderBasicSliAvailability
{
    /// <summary>Whether an availability SLI is enabled or not. Must be set to true. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1SLOSpecInitProviderBasicSliLatency
{
    /// <summary>A duration string, e.g. 10s. Good service is defined to be the count of requests made to this service that return in no more than threshold.</summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

public partial class V1beta1SLOSpecInitProviderBasicSli
{
    /// <summary>Availability based SLI, dervied from count of requests made to this service that return successfully. Structure is documented below.</summary>
    [JsonPropertyName("availability")]
    public IList<V1beta1SLOSpecInitProviderBasicSliAvailability>? Availability { get; set; }

    /// <summary>Parameters for a latency threshold SLI. Structure is documented below.</summary>
    [JsonPropertyName("latency")]
    public IList<V1beta1SLOSpecInitProviderBasicSliLatency>? Latency { get; set; }

    /// <summary>An optional set of locations to which this SLI is relevant. Telemetry from other locations will not be used to calculate performance for this SLI. If omitted, this SLI applies to all locations in which the Service has activity. For service types that don't support breaking down by location, setting this field will result in an error.</summary>
    [JsonPropertyName("location")]
    public IList<string>? Location { get; set; }

    /// <summary>An optional set of RPCs to which this SLI is relevant. Telemetry from other methods will not be used to calculate performance for this SLI. If omitted, this SLI applies to all the Service's methods. For service types that don't support breaking down by method, setting this field will result in an error.</summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>The set of API versions to which this SLI is relevant. Telemetry from other API versions will not be used to calculate performance for this SLI. If omitted, this SLI applies to all API versions. For service types that don't support breaking down by version, setting this field will result in an error.</summary>
    [JsonPropertyName("version")]
    public IList<string>? Version { get; set; }
}

public partial class V1beta1SLOSpecInitProviderRequestBasedSliDistributionCutRange
{
    /// <summary>max value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Min value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1SLOSpecInitProviderRequestBasedSliDistributionCut
{
    /// <summary>A TimeSeries monitoring filter aggregating values to quantify the good service provided. Must have ValueType = DISTRIBUTION and MetricKind = DELTA or MetricKind = CUMULATIVE.</summary>
    [JsonPropertyName("distributionFilter")]
    public string? DistributionFilter { get; set; }

    /// <summary>Range of numerical values. The computed good_service will be the count of values x in the Distribution such that range.min &lt;= x &lt;= range.max. inclusive of min and max. Open ranges can be defined by setting just one of min or max. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public IList<V1beta1SLOSpecInitProviderRequestBasedSliDistributionCutRange>? Range { get; set; }
}

public partial class V1beta1SLOSpecInitProviderRequestBasedSliGoodTotalRatio
{
    /// <summary>A TimeSeries monitoring filter quantifying bad service provided, either demanded service that was not provided or demanded service that was of inadequate quality. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("badServiceFilter")]
    public string? BadServiceFilter { get; set; }

    /// <summary>A TimeSeries monitoring filter quantifying good service provided. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("goodServiceFilter")]
    public string? GoodServiceFilter { get; set; }

    /// <summary>A TimeSeries monitoring filter quantifying total demanded service. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("totalServiceFilter")]
    public string? TotalServiceFilter { get; set; }
}

public partial class V1beta1SLOSpecInitProviderRequestBasedSli
{
    /// <summary>Used when good_service is defined by a count of values aggregated in a Distribution that fall into a good range. The total_service is the total count of all values aggregated in the Distribution. Defines a distribution TimeSeries filter and thresholds used for measuring good service and total service. Exactly one of distribution_cut or good_total_ratio can be set. Structure is documented below.</summary>
    [JsonPropertyName("distributionCut")]
    public IList<V1beta1SLOSpecInitProviderRequestBasedSliDistributionCut>? DistributionCut { get; set; }

    /// <summary>A means to compute a ratio of good_service to total_service. Defines computing this ratio with two TimeSeries monitoring filters Must specify exactly two of good, bad, and total service filters. The relationship good_service + bad_service = total_service will be assumed. Exactly one of distribution_cut or good_total_ratio can be set. Structure is documented below.</summary>
    [JsonPropertyName("goodTotalRatio")]
    public IList<V1beta1SLOSpecInitProviderRequestBasedSliGoodTotalRatio>? GoodTotalRatio { get; set; }
}

public enum V1beta1SLOSpecInitProviderServiceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SLOSpecInitProviderServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SLOSpecInitProviderServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SLOSpecInitProviderServiceRefPolicyResolutionEnum>))]
    public V1beta1SLOSpecInitProviderServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SLOSpecInitProviderServiceRefPolicyResolveEnum>))]
    public V1beta1SLOSpecInitProviderServiceRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SLOSpecInitProviderServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SLOSpecInitProviderServiceRefPolicy? Policy { get; set; }
}

public enum V1beta1SLOSpecInitProviderServiceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SLOSpecInitProviderServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SLOSpecInitProviderServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SLOSpecInitProviderServiceSelectorPolicyResolutionEnum>))]
    public V1beta1SLOSpecInitProviderServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SLOSpecInitProviderServiceSelectorPolicyResolveEnum>))]
    public V1beta1SLOSpecInitProviderServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SLOSpecInitProviderServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SLOSpecInitProviderServiceSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceAvailability
{
    /// <summary>Whether an availability SLI is enabled or not. Must be set to true. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceLatency
{
    /// <summary>A duration string, e.g. 10s. Good service is defined to be the count of requests made to this service that return in no more than threshold.</summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

public partial class V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformance
{
    /// <summary>Availability based SLI, dervied from count of requests made to this service that return successfully. Structure is documented below.</summary>
    [JsonPropertyName("availability")]
    public IList<V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceAvailability>? Availability { get; set; }

    /// <summary>Parameters for a latency threshold SLI. Structure is documented below.</summary>
    [JsonPropertyName("latency")]
    public IList<V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceLatency>? Latency { get; set; }

    /// <summary>An optional set of locations to which this SLI is relevant. Telemetry from other locations will not be used to calculate performance for this SLI. If omitted, this SLI applies to all locations in which the Service has activity. For service types that don't support breaking down by location, setting this field will result in an error.</summary>
    [JsonPropertyName("location")]
    public IList<string>? Location { get; set; }

    /// <summary>An optional set of RPCs to which this SLI is relevant. Telemetry from other methods will not be used to calculate performance for this SLI. If omitted, this SLI applies to all the Service's methods. For service types that don't support breaking down by method, setting this field will result in an error.</summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>The set of API versions to which this SLI is relevant. Telemetry from other API versions will not be used to calculate performance for this SLI. If omitted, this SLI applies to all API versions. For service types that don't support breaking down by version, setting this field will result in an error.</summary>
    [JsonPropertyName("version")]
    public IList<string>? Version { get; set; }
}

public partial class V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCutRange
{
    /// <summary>max value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Min value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCut
{
    /// <summary>A TimeSeries monitoring filter aggregating values to quantify the good service provided. Must have ValueType = DISTRIBUTION and MetricKind = DELTA or MetricKind = CUMULATIVE.</summary>
    [JsonPropertyName("distributionFilter")]
    public string? DistributionFilter { get; set; }

    /// <summary>Range of numerical values. The computed good_service will be the count of values x in the Distribution such that range.min &lt;= x &lt;= range.max. inclusive of min and max. Open ranges can be defined by setting just one of min or max. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public IList<V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCutRange>? Range { get; set; }
}

public partial class V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceGoodTotalRatio
{
    /// <summary>A TimeSeries monitoring filter quantifying bad service provided, either demanded service that was not provided or demanded service that was of inadequate quality. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("badServiceFilter")]
    public string? BadServiceFilter { get; set; }

    /// <summary>A TimeSeries monitoring filter quantifying good service provided. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("goodServiceFilter")]
    public string? GoodServiceFilter { get; set; }

    /// <summary>A TimeSeries monitoring filter quantifying total demanded service. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("totalServiceFilter")]
    public string? TotalServiceFilter { get; set; }
}

public partial class V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformance
{
    /// <summary>Used when good_service is defined by a count of values aggregated in a Distribution that fall into a good range. The total_service is the total count of all values aggregated in the Distribution. Defines a distribution TimeSeries filter and thresholds used for measuring good service and total service. Exactly one of distribution_cut or good_total_ratio can be set. Structure is documented below.</summary>
    [JsonPropertyName("distributionCut")]
    public IList<V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCut>? DistributionCut { get; set; }

    /// <summary>A means to compute a ratio of good_service to total_service. Defines computing this ratio with two TimeSeries monitoring filters Must specify exactly two of good, bad, and total service filters. The relationship good_service + bad_service = total_service will be assumed. Exactly one of distribution_cut or good_total_ratio can be set. Structure is documented below.</summary>
    [JsonPropertyName("goodTotalRatio")]
    public IList<V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceGoodTotalRatio>? GoodTotalRatio { get; set; }
}

public partial class V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThreshold
{
    /// <summary>Basic SLI to evaluate to judge window quality. Structure is documented below.</summary>
    [JsonPropertyName("basicSliPerformance")]
    public IList<V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformance>? BasicSliPerformance { get; set; }

    /// <summary>Request-based SLI to evaluate to judge window quality. Structure is documented below.</summary>
    [JsonPropertyName("performance")]
    public IList<V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThresholdPerformance>? Performance { get; set; }

    /// <summary>A duration string, e.g. 10s. Good service is defined to be the count of requests made to this service that return in no more than threshold.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

public partial class V1beta1SLOSpecInitProviderWindowsBasedSliMetricMeanInRangeRange
{
    /// <summary>max value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Min value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1SLOSpecInitProviderWindowsBasedSliMetricMeanInRange
{
    /// <summary>Range of numerical values. The computed good_service will be the count of values x in the Distribution such that range.min &lt;= x &lt;= range.max. inclusive of min and max. Open ranges can be defined by setting just one of min or max. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public IList<V1beta1SLOSpecInitProviderWindowsBasedSliMetricMeanInRangeRange>? Range { get; set; }

    /// <summary>A monitoring filter specifying the TimeSeries to use for evaluating window quality. The provided TimeSeries must have ValueType = INT64 or ValueType = DOUBLE and MetricKind = GAUGE. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window.</summary>
    [JsonPropertyName("timeSeries")]
    public string? TimeSeries { get; set; }
}

public partial class V1beta1SLOSpecInitProviderWindowsBasedSliMetricSumInRangeRange
{
    /// <summary>max value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Min value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1SLOSpecInitProviderWindowsBasedSliMetricSumInRange
{
    /// <summary>Range of numerical values. The computed good_service will be the count of values x in the Distribution such that range.min &lt;= x &lt;= range.max. inclusive of min and max. Open ranges can be defined by setting just one of min or max. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public IList<V1beta1SLOSpecInitProviderWindowsBasedSliMetricSumInRangeRange>? Range { get; set; }

    /// <summary>A monitoring filter specifying the TimeSeries to use for evaluating window quality. The provided TimeSeries must have ValueType = INT64 or ValueType = DOUBLE and MetricKind = GAUGE. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window.</summary>
    [JsonPropertyName("timeSeries")]
    public string? TimeSeries { get; set; }
}

public partial class V1beta1SLOSpecInitProviderWindowsBasedSli
{
    /// <summary>A TimeSeries monitoring filter with ValueType = BOOL. The window is good if any true values appear in the window. One of good_bad_metric_filter, good_total_ratio_threshold, metric_mean_in_range, metric_sum_in_range must be set for windows_based_sli.</summary>
    [JsonPropertyName("goodBadMetricFilter")]
    public string? GoodBadMetricFilter { get; set; }

    /// <summary>Criterion that describes a window as good if its performance is high enough. One of good_bad_metric_filter, good_total_ratio_threshold, metric_mean_in_range, metric_sum_in_range must be set for windows_based_sli. Structure is documented below.</summary>
    [JsonPropertyName("goodTotalRatioThreshold")]
    public IList<V1beta1SLOSpecInitProviderWindowsBasedSliGoodTotalRatioThreshold>? GoodTotalRatioThreshold { get; set; }

    /// <summary>Criterion that describes a window as good if the metric's value is in a good range, averaged across returned streams. One of good_bad_metric_filter, good_total_ratio_threshold, metric_mean_in_range, metric_sum_in_range must be set for windows_based_sli. Average value X of time_series should satisfy range.min &lt;= X &lt;= range.max for a good window. Structure is documented below.</summary>
    [JsonPropertyName("metricMeanInRange")]
    public IList<V1beta1SLOSpecInitProviderWindowsBasedSliMetricMeanInRange>? MetricMeanInRange { get; set; }

    /// <summary>Criterion that describes a window as good if the metric's value is in a good range, summed across returned streams. Summed value X of time_series should satisfy range.min &lt;= X &lt;= range.max for a good window. One of good_bad_metric_filter, good_total_ratio_threshold, metric_mean_in_range, metric_sum_in_range must be set for windows_based_sli. Structure is documented below.</summary>
    [JsonPropertyName("metricSumInRange")]
    public IList<V1beta1SLOSpecInitProviderWindowsBasedSliMetricSumInRange>? MetricSumInRange { get; set; }

    /// <summary>Duration over which window quality is evaluated, given as a duration string "{X}s" representing X seconds. Must be an integer fraction of a day and at least 60s.</summary>
    [JsonPropertyName("windowPeriod")]
    public string? WindowPeriod { get; set; }
}

public partial class V1beta1SLOSpecInitProvider
{
    /// <summary>Basic Service-Level Indicator (SLI) on a well-known service type. Performance will be computed on the basis of pre-defined metrics. SLIs are used to measure and calculate the quality of the Service's performance with respect to a single aspect of service quality. Exactly one of the following must be set: basic_sli, request_based_sli, windows_based_sli Structure is documented below.</summary>
    [JsonPropertyName("basicSli")]
    public IList<V1beta1SLOSpecInitProviderBasicSli>? BasicSli { get; set; }

    /// <summary>A calendar period, semantically "since the start of the current ". Possible values are: DAY, WEEK, FORTNIGHT, MONTH.</summary>
    [JsonPropertyName("calendarPeriod")]
    public string? CalendarPeriod { get; set; }

    /// <summary>Name used for UI elements listing this SLO.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The fraction of service that must be good in order for this objective to be met. 0 &lt; goal &lt;= 0.999</summary>
    [JsonPropertyName("goal")]
    public double? Goal { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A request-based SLI defines a SLI for which atomic units of service are counted directly. A SLI describes a good service. It is used to measure and calculate the quality of the Service's performance with respect to a single aspect of service quality. Exactly one of the following must be set: basic_sli, request_based_sli, windows_based_sli Structure is documented below.</summary>
    [JsonPropertyName("requestBasedSli")]
    public IList<V1beta1SLOSpecInitProviderRequestBasedSli>? RequestBasedSli { get; set; }

    /// <summary>A rolling time period, semantically "in the past X days". Must be between 1 to 30 days, inclusive.</summary>
    [JsonPropertyName("rollingPeriodDays")]
    public double? RollingPeriodDays { get; set; }

    /// <summary>ID of the service to which this SLO belongs.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a CustomService in monitoring to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1SLOSpecInitProviderServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a CustomService in monitoring to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1SLOSpecInitProviderServiceSelector? ServiceSelector { get; set; }

    /// <summary>The id to use for this ServiceLevelObjective. If omitted, an id will be generated instead.</summary>
    [JsonPropertyName("sloId")]
    public string? SloId { get; set; }

    /// <summary>This field is intended to be used for organizing and identifying the AlertPolicy objects.The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.</summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }

    /// <summary>A windows-based SLI defines the criteria for time windows. good_service is defined based off the count of these time windows for which the provided service was of good quality. A SLI describes a good service. It is used to measure and calculate the quality of the Service's performance with respect to a single aspect of service quality. Exactly one of the following must be set: basic_sli, request_based_sli, windows_based_sli Structure is documented below.</summary>
    [JsonPropertyName("windowsBasedSli")]
    public IList<V1beta1SLOSpecInitProviderWindowsBasedSli>? WindowsBasedSli { get; set; }
}

public enum V1beta1SLOSpecManagementPoliciesEnum
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

public enum V1beta1SLOSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SLOSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SLOSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SLOSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SLOSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SLOSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SLOSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SLOSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SLOSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SLOSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SLOSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SLOSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SLOSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SLOSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SLOSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SLOSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SLOSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SLOSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1SLOSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1SLOSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SLOSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SLOSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1SLOSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1SLOSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SLOSpecDeletionPolicyEnum>))]
    public V1beta1SLOSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SLOSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SLOSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SLOSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SLOSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SLOSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SLOSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1SLOStatusAtProviderBasicSliAvailability
{
    /// <summary>Whether an availability SLI is enabled or not. Must be set to true. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1SLOStatusAtProviderBasicSliLatency
{
    /// <summary>A duration string, e.g. 10s. Good service is defined to be the count of requests made to this service that return in no more than threshold.</summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

public partial class V1beta1SLOStatusAtProviderBasicSli
{
    /// <summary>Availability based SLI, dervied from count of requests made to this service that return successfully. Structure is documented below.</summary>
    [JsonPropertyName("availability")]
    public IList<V1beta1SLOStatusAtProviderBasicSliAvailability>? Availability { get; set; }

    /// <summary>Parameters for a latency threshold SLI. Structure is documented below.</summary>
    [JsonPropertyName("latency")]
    public IList<V1beta1SLOStatusAtProviderBasicSliLatency>? Latency { get; set; }

    /// <summary>An optional set of locations to which this SLI is relevant. Telemetry from other locations will not be used to calculate performance for this SLI. If omitted, this SLI applies to all locations in which the Service has activity. For service types that don't support breaking down by location, setting this field will result in an error.</summary>
    [JsonPropertyName("location")]
    public IList<string>? Location { get; set; }

    /// <summary>An optional set of RPCs to which this SLI is relevant. Telemetry from other methods will not be used to calculate performance for this SLI. If omitted, this SLI applies to all the Service's methods. For service types that don't support breaking down by method, setting this field will result in an error.</summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>The set of API versions to which this SLI is relevant. Telemetry from other API versions will not be used to calculate performance for this SLI. If omitted, this SLI applies to all API versions. For service types that don't support breaking down by version, setting this field will result in an error.</summary>
    [JsonPropertyName("version")]
    public IList<string>? Version { get; set; }
}

public partial class V1beta1SLOStatusAtProviderRequestBasedSliDistributionCutRange
{
    /// <summary>max value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Min value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1SLOStatusAtProviderRequestBasedSliDistributionCut
{
    /// <summary>A TimeSeries monitoring filter aggregating values to quantify the good service provided. Must have ValueType = DISTRIBUTION and MetricKind = DELTA or MetricKind = CUMULATIVE.</summary>
    [JsonPropertyName("distributionFilter")]
    public string? DistributionFilter { get; set; }

    /// <summary>Range of numerical values. The computed good_service will be the count of values x in the Distribution such that range.min &lt;= x &lt;= range.max. inclusive of min and max. Open ranges can be defined by setting just one of min or max. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public IList<V1beta1SLOStatusAtProviderRequestBasedSliDistributionCutRange>? Range { get; set; }
}

public partial class V1beta1SLOStatusAtProviderRequestBasedSliGoodTotalRatio
{
    /// <summary>A TimeSeries monitoring filter quantifying bad service provided, either demanded service that was not provided or demanded service that was of inadequate quality. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("badServiceFilter")]
    public string? BadServiceFilter { get; set; }

    /// <summary>A TimeSeries monitoring filter quantifying good service provided. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("goodServiceFilter")]
    public string? GoodServiceFilter { get; set; }

    /// <summary>A TimeSeries monitoring filter quantifying total demanded service. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("totalServiceFilter")]
    public string? TotalServiceFilter { get; set; }
}

public partial class V1beta1SLOStatusAtProviderRequestBasedSli
{
    /// <summary>Used when good_service is defined by a count of values aggregated in a Distribution that fall into a good range. The total_service is the total count of all values aggregated in the Distribution. Defines a distribution TimeSeries filter and thresholds used for measuring good service and total service. Exactly one of distribution_cut or good_total_ratio can be set. Structure is documented below.</summary>
    [JsonPropertyName("distributionCut")]
    public IList<V1beta1SLOStatusAtProviderRequestBasedSliDistributionCut>? DistributionCut { get; set; }

    /// <summary>A means to compute a ratio of good_service to total_service. Defines computing this ratio with two TimeSeries monitoring filters Must specify exactly two of good, bad, and total service filters. The relationship good_service + bad_service = total_service will be assumed. Exactly one of distribution_cut or good_total_ratio can be set. Structure is documented below.</summary>
    [JsonPropertyName("goodTotalRatio")]
    public IList<V1beta1SLOStatusAtProviderRequestBasedSliGoodTotalRatio>? GoodTotalRatio { get; set; }
}

public partial class V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceAvailability
{
    /// <summary>Whether an availability SLI is enabled or not. Must be set to true. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceLatency
{
    /// <summary>A duration string, e.g. 10s. Good service is defined to be the count of requests made to this service that return in no more than threshold.</summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }
}

public partial class V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformance
{
    /// <summary>Availability based SLI, dervied from count of requests made to this service that return successfully. Structure is documented below.</summary>
    [JsonPropertyName("availability")]
    public IList<V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceAvailability>? Availability { get; set; }

    /// <summary>Parameters for a latency threshold SLI. Structure is documented below.</summary>
    [JsonPropertyName("latency")]
    public IList<V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformanceLatency>? Latency { get; set; }

    /// <summary>An optional set of locations to which this SLI is relevant. Telemetry from other locations will not be used to calculate performance for this SLI. If omitted, this SLI applies to all locations in which the Service has activity. For service types that don't support breaking down by location, setting this field will result in an error.</summary>
    [JsonPropertyName("location")]
    public IList<string>? Location { get; set; }

    /// <summary>An optional set of RPCs to which this SLI is relevant. Telemetry from other methods will not be used to calculate performance for this SLI. If omitted, this SLI applies to all the Service's methods. For service types that don't support breaking down by method, setting this field will result in an error.</summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>The set of API versions to which this SLI is relevant. Telemetry from other API versions will not be used to calculate performance for this SLI. If omitted, this SLI applies to all API versions. For service types that don't support breaking down by version, setting this field will result in an error.</summary>
    [JsonPropertyName("version")]
    public IList<string>? Version { get; set; }
}

public partial class V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCutRange
{
    /// <summary>max value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Min value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCut
{
    /// <summary>A TimeSeries monitoring filter aggregating values to quantify the good service provided. Must have ValueType = DISTRIBUTION and MetricKind = DELTA or MetricKind = CUMULATIVE.</summary>
    [JsonPropertyName("distributionFilter")]
    public string? DistributionFilter { get; set; }

    /// <summary>Range of numerical values. The computed good_service will be the count of values x in the Distribution such that range.min &lt;= x &lt;= range.max. inclusive of min and max. Open ranges can be defined by setting just one of min or max. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public IList<V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCutRange>? Range { get; set; }
}

public partial class V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceGoodTotalRatio
{
    /// <summary>A TimeSeries monitoring filter quantifying bad service provided, either demanded service that was not provided or demanded service that was of inadequate quality. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("badServiceFilter")]
    public string? BadServiceFilter { get; set; }

    /// <summary>A TimeSeries monitoring filter quantifying good service provided. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("goodServiceFilter")]
    public string? GoodServiceFilter { get; set; }

    /// <summary>A TimeSeries monitoring filter quantifying total demanded service. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind = CUMULATIVE. Exactly two of good_service_filter,bad_service_filter,total_service_filter must be set (good + bad = total is assumed).</summary>
    [JsonPropertyName("totalServiceFilter")]
    public string? TotalServiceFilter { get; set; }
}

public partial class V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformance
{
    /// <summary>Used when good_service is defined by a count of values aggregated in a Distribution that fall into a good range. The total_service is the total count of all values aggregated in the Distribution. Defines a distribution TimeSeries filter and thresholds used for measuring good service and total service. Exactly one of distribution_cut or good_total_ratio can be set. Structure is documented below.</summary>
    [JsonPropertyName("distributionCut")]
    public IList<V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceDistributionCut>? DistributionCut { get; set; }

    /// <summary>A means to compute a ratio of good_service to total_service. Defines computing this ratio with two TimeSeries monitoring filters Must specify exactly two of good, bad, and total service filters. The relationship good_service + bad_service = total_service will be assumed. Exactly one of distribution_cut or good_total_ratio can be set. Structure is documented below.</summary>
    [JsonPropertyName("goodTotalRatio")]
    public IList<V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformanceGoodTotalRatio>? GoodTotalRatio { get; set; }
}

public partial class V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThreshold
{
    /// <summary>Basic SLI to evaluate to judge window quality. Structure is documented below.</summary>
    [JsonPropertyName("basicSliPerformance")]
    public IList<V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdBasicSliPerformance>? BasicSliPerformance { get; set; }

    /// <summary>Request-based SLI to evaluate to judge window quality. Structure is documented below.</summary>
    [JsonPropertyName("performance")]
    public IList<V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThresholdPerformance>? Performance { get; set; }

    /// <summary>A duration string, e.g. 10s. Good service is defined to be the count of requests made to this service that return in no more than threshold.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

public partial class V1beta1SLOStatusAtProviderWindowsBasedSliMetricMeanInRangeRange
{
    /// <summary>max value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Min value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1SLOStatusAtProviderWindowsBasedSliMetricMeanInRange
{
    /// <summary>Range of numerical values. The computed good_service will be the count of values x in the Distribution such that range.min &lt;= x &lt;= range.max. inclusive of min and max. Open ranges can be defined by setting just one of min or max. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public IList<V1beta1SLOStatusAtProviderWindowsBasedSliMetricMeanInRangeRange>? Range { get; set; }

    /// <summary>A monitoring filter specifying the TimeSeries to use for evaluating window quality. The provided TimeSeries must have ValueType = INT64 or ValueType = DOUBLE and MetricKind = GAUGE. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window.</summary>
    [JsonPropertyName("timeSeries")]
    public string? TimeSeries { get; set; }
}

public partial class V1beta1SLOStatusAtProviderWindowsBasedSliMetricSumInRangeRange
{
    /// <summary>max value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Min value for the range (inclusive). If not given, will be set to 0</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1SLOStatusAtProviderWindowsBasedSliMetricSumInRange
{
    /// <summary>Range of numerical values. The computed good_service will be the count of values x in the Distribution such that range.min &lt;= x &lt;= range.max. inclusive of min and max. Open ranges can be defined by setting just one of min or max. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window. Structure is documented below.</summary>
    [JsonPropertyName("range")]
    public IList<V1beta1SLOStatusAtProviderWindowsBasedSliMetricSumInRangeRange>? Range { get; set; }

    /// <summary>A monitoring filter specifying the TimeSeries to use for evaluating window quality. The provided TimeSeries must have ValueType = INT64 or ValueType = DOUBLE and MetricKind = GAUGE. Summed value X should satisfy range.min &lt;= X &lt;= range.max for a good window.</summary>
    [JsonPropertyName("timeSeries")]
    public string? TimeSeries { get; set; }
}

public partial class V1beta1SLOStatusAtProviderWindowsBasedSli
{
    /// <summary>A TimeSeries monitoring filter with ValueType = BOOL. The window is good if any true values appear in the window. One of good_bad_metric_filter, good_total_ratio_threshold, metric_mean_in_range, metric_sum_in_range must be set for windows_based_sli.</summary>
    [JsonPropertyName("goodBadMetricFilter")]
    public string? GoodBadMetricFilter { get; set; }

    /// <summary>Criterion that describes a window as good if its performance is high enough. One of good_bad_metric_filter, good_total_ratio_threshold, metric_mean_in_range, metric_sum_in_range must be set for windows_based_sli. Structure is documented below.</summary>
    [JsonPropertyName("goodTotalRatioThreshold")]
    public IList<V1beta1SLOStatusAtProviderWindowsBasedSliGoodTotalRatioThreshold>? GoodTotalRatioThreshold { get; set; }

    /// <summary>Criterion that describes a window as good if the metric's value is in a good range, averaged across returned streams. One of good_bad_metric_filter, good_total_ratio_threshold, metric_mean_in_range, metric_sum_in_range must be set for windows_based_sli. Average value X of time_series should satisfy range.min &lt;= X &lt;= range.max for a good window. Structure is documented below.</summary>
    [JsonPropertyName("metricMeanInRange")]
    public IList<V1beta1SLOStatusAtProviderWindowsBasedSliMetricMeanInRange>? MetricMeanInRange { get; set; }

    /// <summary>Criterion that describes a window as good if the metric's value is in a good range, summed across returned streams. Summed value X of time_series should satisfy range.min &lt;= X &lt;= range.max for a good window. One of good_bad_metric_filter, good_total_ratio_threshold, metric_mean_in_range, metric_sum_in_range must be set for windows_based_sli. Structure is documented below.</summary>
    [JsonPropertyName("metricSumInRange")]
    public IList<V1beta1SLOStatusAtProviderWindowsBasedSliMetricSumInRange>? MetricSumInRange { get; set; }

    /// <summary>Duration over which window quality is evaluated, given as a duration string "{X}s" representing X seconds. Must be an integer fraction of a day and at least 60s.</summary>
    [JsonPropertyName("windowPeriod")]
    public string? WindowPeriod { get; set; }
}

public partial class V1beta1SLOStatusAtProvider
{
    /// <summary>Basic Service-Level Indicator (SLI) on a well-known service type. Performance will be computed on the basis of pre-defined metrics. SLIs are used to measure and calculate the quality of the Service's performance with respect to a single aspect of service quality. Exactly one of the following must be set: basic_sli, request_based_sli, windows_based_sli Structure is documented below.</summary>
    [JsonPropertyName("basicSli")]
    public IList<V1beta1SLOStatusAtProviderBasicSli>? BasicSli { get; set; }

    /// <summary>A calendar period, semantically "since the start of the current ". Possible values are: DAY, WEEK, FORTNIGHT, MONTH.</summary>
    [JsonPropertyName("calendarPeriod")]
    public string? CalendarPeriod { get; set; }

    /// <summary>Name used for UI elements listing this SLO.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The fraction of service that must be good in order for this objective to be met. 0 &lt; goal &lt;= 0.999</summary>
    [JsonPropertyName("goal")]
    public double? Goal { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The full resource name for this service. The syntax is: projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A request-based SLI defines a SLI for which atomic units of service are counted directly. A SLI describes a good service. It is used to measure and calculate the quality of the Service's performance with respect to a single aspect of service quality. Exactly one of the following must be set: basic_sli, request_based_sli, windows_based_sli Structure is documented below.</summary>
    [JsonPropertyName("requestBasedSli")]
    public IList<V1beta1SLOStatusAtProviderRequestBasedSli>? RequestBasedSli { get; set; }

    /// <summary>A rolling time period, semantically "in the past X days". Must be between 1 to 30 days, inclusive.</summary>
    [JsonPropertyName("rollingPeriodDays")]
    public double? RollingPeriodDays { get; set; }

    /// <summary>ID of the service to which this SLO belongs.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>The id to use for this ServiceLevelObjective. If omitted, an id will be generated instead.</summary>
    [JsonPropertyName("sloId")]
    public string? SloId { get; set; }

    /// <summary>This field is intended to be used for organizing and identifying the AlertPolicy objects.The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.</summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }

    /// <summary>A windows-based SLI defines the criteria for time windows. good_service is defined based off the count of these time windows for which the provided service was of good quality. A SLI describes a good service. It is used to measure and calculate the quality of the Service's performance with respect to a single aspect of service quality. Exactly one of the following must be set: basic_sli, request_based_sli, windows_based_sli Structure is documented below.</summary>
    [JsonPropertyName("windowsBasedSli")]
    public IList<V1beta1SLOStatusAtProviderWindowsBasedSli>? WindowsBasedSli { get; set; }
}

public partial class V1beta1SLOStatusConditions
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

public partial class V1beta1SLOStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SLOStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SLOStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SLO : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SLOSpec>, IStatus<V1beta1SLOStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SLO";
    public const string KubeGroup = "monitoring.gcp.upbound.io";
    public const string KubePluralName = "sloes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SLOSpec defines the desired state of SLO</summary>
    [JsonPropertyName("spec")]
    public V1beta1SLOSpec Spec { get; set; }

    /// <summary>SLOStatus defines the observed state of SLO.</summary>
    [JsonPropertyName("status")]
    public V1beta1SLOStatus? Status { get; set; }
}