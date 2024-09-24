using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.monitoring.cnrm.cloud.google.com;
public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsAlertChartAlertPolicyRef
{
    /// <summary>The MonitoringAlertPolicy link in the form "projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsAlertChart
{
    /// <summary>Required. A reference to the MonitoringAlertPolicy.</summary>
    [JsonPropertyName("alertPolicyRef")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsAlertChartAlertPolicyRef AlertPolicyRef { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsBlank
{
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsCollapsibleGroup
{
    /// <summary>The collapsed state of the widget on first page load.</summary>
    [JsonPropertyName("collapsed")]
    public bool? Collapsed { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsErrorReportingPanelProjectRefs
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsErrorReportingPanel
{
    /// <summary>The projects from which to gather errors.</summary>
    [JsonPropertyName("projectRefs")]
    public IList<V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsErrorReportingPanelProjectRefs>? ProjectRefs { get; set; }

    /// <summary>An identifier of the service, such as the name of the executable, job, or Google App Engine service name. This field is expected to have a low number of values that are relatively stable over time, as opposed to `version`, which can be changed whenever new code is deployed.</summary>
    [JsonPropertyName("services")]
    public IList<string>? Services { get; set; }

    /// <summary>Represents the source code version that the developer provided, which could represent a version label or a Git SHA-1 hash, for example. For App Engine standard environment, the version is set to the version of the app.</summary>
    [JsonPropertyName("versions")]
    public IList<string>? Versions { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsIncidentListMonitoredResources
{
    /// <summary>Required. Values for all of the labels listed in the associated monitored resource descriptor.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Required. The monitored resource type. This field must match the `type` field of a [MonitoredResourceDescriptor][google.api.MonitoredResourceDescriptor] object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsIncidentListPolicyRefs
{
    /// <summary>The MonitoringAlertPolicy link in the form "projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsIncidentList
{
    /// <summary>Optional. The monitored resource for which incidents are listed.</summary>
    [JsonPropertyName("monitoredResources")]
    public IList<V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsIncidentListMonitoredResources>? MonitoredResources { get; set; }

    /// <summary>Optional. A list of alert policies to filter the incident list by.</summary>
    [JsonPropertyName("policyRefs")]
    public IList<V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsIncidentListPolicyRefs>? PolicyRefs { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsLogsPanelResourceNames
{
    /// <summary>The external name of the referenced resource</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsLogsPanel
{
    /// <summary>A filter that chooses which log entries to return.  See [Advanced Logs Queries](https://cloud.google.com/logging/docs/view/advanced-queries).</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The names of logging resources to collect logs for.</summary>
    [JsonPropertyName("resourceNames")]
    public IList<V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsLogsPanelResourceNames>? ResourceNames { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSets
{
    /// <summary>Optional. The lower bound on data point frequency for this data set.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>Optional. A template for the name of the slice.</summary>
    [JsonPropertyName("sliceNameTemplate")]
    public string? SliceNameTemplate { get; set; }

    /// <summary>Required. The query for the PieChart. See, `google.monitoring.dashboard.v1.TimeSeriesQuery`.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSetsTimeSeriesQuery TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChart
{
    /// <summary>Required. Indicates the visualization type for the PieChart.</summary>
    [JsonPropertyName("chartType")]
    public string ChartType { get; set; }

    /// <summary>Required. The queries for the chart's data.</summary>
    [JsonPropertyName("dataSets")]
    public IList<V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChartDataSets> DataSets { get; set; }

    /// <summary>Optional. Indicates whether or not the pie chart should show slices' labels</summary>
    [JsonPropertyName("showLabels")]
    public bool? ShowLabels { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardBlankView
{
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardGaugeView
{
    /// <summary>The lower bound for this gauge chart. The value of the chart should always be greater than or equal to this.</summary>
    [JsonPropertyName("lowerBound")]
    public double? LowerBound { get; set; }

    /// <summary>The upper bound for this gauge chart. The value of the chart should always be less than or equal to this.</summary>
    [JsonPropertyName("upperBound")]
    public double? UpperBound { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardSparkChartView
{
    /// <summary>The lower bound on data point frequency in the chart implemented by specifying the minimum alignment period to use in a time series query.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>Required. The type of sparkchart to show in this chartView.</summary>
    [JsonPropertyName("sparkChartType")]
    public string SparkChartType { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardThresholds
{
    /// <summary>The state color for this threshold. Color is not allowed in a XyChart.</summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }

    /// <summary>The direction for the current threshold. Direction is not allowed in a XyChart.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>A label for the threshold.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The target axis to use for plotting the threshold. Target axis is not allowed in a Scorecard.</summary>
    [JsonPropertyName("targetAxis")]
    public string? TargetAxis { get; set; }

    /// <summary>The value of the threshold. The value should be defined in the native scale of the metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecard
{
    /// <summary>Will cause the `Scorecard` to show only the value, with no indicator to its value relative to its thresholds.</summary>
    [JsonPropertyName("blankView")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardBlankView? BlankView { get; set; }

    /// <summary>Will cause the scorecard to show a gauge chart.</summary>
    [JsonPropertyName("gaugeView")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardGaugeView? GaugeView { get; set; }

    /// <summary>Will cause the scorecard to show a spark chart.</summary>
    [JsonPropertyName("sparkChartView")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardSparkChartView? SparkChartView { get; set; }

    /// <summary>The thresholds used to determine the state of the scorecard given the time series' current value.</summary>
    [JsonPropertyName("thresholds")]
    public IList<V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardThresholds>? Thresholds { get; set; }

    /// <summary>Required. Fields for querying time series data from the Stackdriver metrics API.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecardTimeSeriesQuery TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsSectionHeader
{
    /// <summary>Whether to insert a divider below the section in the table of contents</summary>
    [JsonPropertyName("dividerBelow")]
    public bool? DividerBelow { get; set; }

    /// <summary>The subtitle of the section</summary>
    [JsonPropertyName("subtitle")]
    public string? Subtitle { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsSingleViewGroup
{
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTextStyle
{
    /// <summary>The background color as a hex string. "#RRGGBB" or "#RGB"</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>Font sizes for both the title and content. The title will still be larger relative to the content.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>The horizontal alignment of both the title and content</summary>
    [JsonPropertyName("horizontalAlignment")]
    public string? HorizontalAlignment { get; set; }

    /// <summary>The amount of padding around the widget</summary>
    [JsonPropertyName("padding")]
    public string? Padding { get; set; }

    /// <summary>The pointer location for this widget (also sometimes called a "tail")</summary>
    [JsonPropertyName("pointerLocation")]
    public string? PointerLocation { get; set; }

    /// <summary>The text color as a hex string. "#RRGGBB" or "#RGB"</summary>
    [JsonPropertyName("textColor")]
    public string? TextColor { get; set; }

    /// <summary>The vertical alignment of both the title and content</summary>
    [JsonPropertyName("verticalAlignment")]
    public string? VerticalAlignment { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsText
{
    /// <summary>The text content to be displayed.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>How the text content is formatted.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>How the text is styled</summary>
    [JsonPropertyName("style")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTextStyle? Style { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableColumnSettings
{
    /// <summary>Required. The id of the column.</summary>
    [JsonPropertyName("column")]
    public string Column { get; set; }

    /// <summary>Required. Whether the column should be visible on page load.</summary>
    [JsonPropertyName("visible")]
    public bool Visible { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTableDisplayOptions
{
    /// <summary>Optional. This field is unused and has been replaced by TimeSeriesTable.column_settings</summary>
    [JsonPropertyName("shownColumns")]
    public IList<string>? ShownColumns { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSets
{
    /// <summary>Optional. The lower bound on data point frequency for this data set.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>Optional. Table display options for configuring how the table is rendered.</summary>
    [JsonPropertyName("tableDisplayOptions")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTableDisplayOptions? TableDisplayOptions { get; set; }

    /// <summary>Optional. A template string for naming `TimeSeries` in the resulting data set.</summary>
    [JsonPropertyName("tableTemplate")]
    public string? TableTemplate { get; set; }

    /// <summary>Required. Fields for querying time series data from the Stackdriver metrics API.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSetsTimeSeriesQuery? TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTable
{
    /// <summary>Optional. The list of the persistent column settings for the table.</summary>
    [JsonPropertyName("columnSettings")]
    public IList<V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableColumnSettings>? ColumnSettings { get; set; }

    /// <summary>Required. The data displayed in this table.</summary>
    [JsonPropertyName("dataSets")]
    public IList<V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTableDataSets> DataSets { get; set; }

    /// <summary>Optional. Store rendering strategy</summary>
    [JsonPropertyName("metricVisualization")]
    public string? MetricVisualization { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartChartOptions
{
    /// <summary>The chart mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSets
{
    /// <summary>A template string for naming `TimeSeries` in the resulting data set.</summary>
    [JsonPropertyName("legendTemplate")]
    public string? LegendTemplate { get; set; }

    /// <summary>Optional. The lower bound on data point frequency for this data set.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>How this data should be plotted on the chart.</summary>
    [JsonPropertyName("plotType")]
    public string? PlotType { get; set; }

    /// <summary>Optional. The target axis to use for plotting the metric.</summary>
    [JsonPropertyName("targetAxis")]
    public string? TargetAxis { get; set; }

    /// <summary>Fields for querying time series data from the Stackdriver metrics API.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSetsTimeSeriesQuery TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartThresholds
{
    /// <summary>The state color for this threshold. Color is not allowed in a XyChart.</summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }

    /// <summary>The direction for the current threshold. Direction is not allowed in a XyChart.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>A label for the threshold.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The target axis to use for plotting the threshold. Target axis is not allowed in a Scorecard.</summary>
    [JsonPropertyName("targetAxis")]
    public string? TargetAxis { get; set; }

    /// <summary>The value of the threshold. The value should be defined in the native scale of the metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartXAxis
{
    /// <summary>The label of the axis.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The axis scale. By default, a linear scale is used.</summary>
    [JsonPropertyName("scale")]
    public string? Scale { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartY2Axis
{
    /// <summary>The label of the axis.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The axis scale. By default, a linear scale is used.</summary>
    [JsonPropertyName("scale")]
    public string? Scale { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartYAxis
{
    /// <summary>The label of the axis.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The axis scale. By default, a linear scale is used.</summary>
    [JsonPropertyName("scale")]
    public string? Scale { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChart
{
    /// <summary>Display options for the chart.</summary>
    [JsonPropertyName("chartOptions")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartChartOptions? ChartOptions { get; set; }

    /// <summary>Required. The data displayed in this chart.</summary>
    [JsonPropertyName("dataSets")]
    public IList<V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartDataSets> DataSets { get; set; }

    /// <summary>Threshold lines drawn horizontally across the chart.</summary>
    [JsonPropertyName("thresholds")]
    public IList<V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartThresholds>? Thresholds { get; set; }

    /// <summary>The duration used to display a comparison chart.</summary>
    [JsonPropertyName("timeshiftDuration")]
    public string? TimeshiftDuration { get; set; }

    /// <summary>The properties applied to the x-axis.</summary>
    [JsonPropertyName("xAxis")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartXAxis? XAxis { get; set; }

    /// <summary>The properties applied to the y2-axis.</summary>
    [JsonPropertyName("y2Axis")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartY2Axis? Y2Axis { get; set; }

    /// <summary>The properties applied to the y-axis.</summary>
    [JsonPropertyName("yAxis")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChartYAxis? YAxis { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgets
{
    /// <summary>A chart of alert policy data.</summary>
    [JsonPropertyName("alertChart")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsAlertChart? AlertChart { get; set; }

    /// <summary>A blank space.</summary>
    [JsonPropertyName("blank")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsBlank? Blank { get; set; }

    /// <summary>A widget that groups the other widgets. All widgets that are within the area spanned by the grouping widget are considered member widgets.</summary>
    [JsonPropertyName("collapsibleGroup")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsCollapsibleGroup? CollapsibleGroup { get; set; }

    /// <summary>A widget that displays a list of error groups.</summary>
    [JsonPropertyName("errorReportingPanel")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsErrorReportingPanel? ErrorReportingPanel { get; set; }

    /// <summary>Optional. The widget id. Ids may be made up of alphanumerics, dashes and underscores. Widget ids are optional.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A widget that shows list of incidents.</summary>
    [JsonPropertyName("incidentList")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsIncidentList? IncidentList { get; set; }

    /// <summary>A widget that shows a stream of logs.</summary>
    [JsonPropertyName("logsPanel")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsLogsPanel? LogsPanel { get; set; }

    /// <summary>A widget that displays timeseries data as a pie chart.</summary>
    [JsonPropertyName("pieChart")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsPieChart? PieChart { get; set; }

    /// <summary>A scorecard summarizing time series data.</summary>
    [JsonPropertyName("scorecard")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsScorecard? Scorecard { get; set; }

    /// <summary>A widget that defines a section header for easier navigation of the dashboard.</summary>
    [JsonPropertyName("sectionHeader")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsSectionHeader? SectionHeader { get; set; }

    /// <summary>A widget that groups the other widgets by using a dropdown menu.</summary>
    [JsonPropertyName("singleViewGroup")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsSingleViewGroup? SingleViewGroup { get; set; }

    /// <summary>A raw string or markdown displaying textual content.</summary>
    [JsonPropertyName("text")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsText? Text { get; set; }

    /// <summary>A widget that displays time series data in a tabular format.</summary>
    [JsonPropertyName("timeSeriesTable")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsTimeSeriesTable? TimeSeriesTable { get; set; }

    /// <summary>Optional. The title of the widget.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A chart of time series data.</summary>
    [JsonPropertyName("xyChart")]
    public V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgetsXyChart? XyChart { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayoutColumns
{
    /// <summary>The relative weight of this column. The column weight is used to adjust the width of columns on the screen (relative to peers).</summary>
    [JsonPropertyName("weight")]
    public long? Weight { get; set; }

    /// <summary>The display widgets arranged vertically in this column.</summary>
    [JsonPropertyName("widgets")]
    public IList<V1beta1MonitoringDashboardSpecColumnLayoutColumnsWidgets>? Widgets { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecColumnLayout
{
    /// <summary>The columns of content to display.</summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1MonitoringDashboardSpecColumnLayoutColumns>? Columns { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecDashboardFilters
{
    /// <summary>The specified filter type</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>Required. The key for the label</summary>
    [JsonPropertyName("labelKey")]
    public string LabelKey { get; set; }

    /// <summary>A variable-length string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>The placeholder text that can be referenced in a filter string or MQL query. If omitted, the dashboard filter will be applied to all relevant widgets in the dashboard.</summary>
    [JsonPropertyName("templateVariable")]
    public string? TemplateVariable { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsAlertChartAlertPolicyRef
{
    /// <summary>The MonitoringAlertPolicy link in the form "projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsAlertChart
{
    /// <summary>Required. A reference to the MonitoringAlertPolicy.</summary>
    [JsonPropertyName("alertPolicyRef")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsAlertChartAlertPolicyRef AlertPolicyRef { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsBlank
{
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsCollapsibleGroup
{
    /// <summary>The collapsed state of the widget on first page load.</summary>
    [JsonPropertyName("collapsed")]
    public bool? Collapsed { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsErrorReportingPanelProjectRefs
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsErrorReportingPanel
{
    /// <summary>The projects from which to gather errors.</summary>
    [JsonPropertyName("projectRefs")]
    public IList<V1beta1MonitoringDashboardSpecGridLayoutWidgetsErrorReportingPanelProjectRefs>? ProjectRefs { get; set; }

    /// <summary>An identifier of the service, such as the name of the executable, job, or Google App Engine service name. This field is expected to have a low number of values that are relatively stable over time, as opposed to `version`, which can be changed whenever new code is deployed.</summary>
    [JsonPropertyName("services")]
    public IList<string>? Services { get; set; }

    /// <summary>Represents the source code version that the developer provided, which could represent a version label or a Git SHA-1 hash, for example. For App Engine standard environment, the version is set to the version of the app.</summary>
    [JsonPropertyName("versions")]
    public IList<string>? Versions { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsIncidentListMonitoredResources
{
    /// <summary>Required. Values for all of the labels listed in the associated monitored resource descriptor.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Required. The monitored resource type. This field must match the `type` field of a [MonitoredResourceDescriptor][google.api.MonitoredResourceDescriptor] object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsIncidentListPolicyRefs
{
    /// <summary>The MonitoringAlertPolicy link in the form "projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsIncidentList
{
    /// <summary>Optional. The monitored resource for which incidents are listed.</summary>
    [JsonPropertyName("monitoredResources")]
    public IList<V1beta1MonitoringDashboardSpecGridLayoutWidgetsIncidentListMonitoredResources>? MonitoredResources { get; set; }

    /// <summary>Optional. A list of alert policies to filter the incident list by.</summary>
    [JsonPropertyName("policyRefs")]
    public IList<V1beta1MonitoringDashboardSpecGridLayoutWidgetsIncidentListPolicyRefs>? PolicyRefs { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsLogsPanelResourceNames
{
    /// <summary>The external name of the referenced resource</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsLogsPanel
{
    /// <summary>A filter that chooses which log entries to return.  See [Advanced Logs Queries](https://cloud.google.com/logging/docs/view/advanced-queries).</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The names of logging resources to collect logs for.</summary>
    [JsonPropertyName("resourceNames")]
    public IList<V1beta1MonitoringDashboardSpecGridLayoutWidgetsLogsPanelResourceNames>? ResourceNames { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSets
{
    /// <summary>Optional. The lower bound on data point frequency for this data set.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>Optional. A template for the name of the slice.</summary>
    [JsonPropertyName("sliceNameTemplate")]
    public string? SliceNameTemplate { get; set; }

    /// <summary>Required. The query for the PieChart. See, `google.monitoring.dashboard.v1.TimeSeriesQuery`.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSetsTimeSeriesQuery TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChart
{
    /// <summary>Required. Indicates the visualization type for the PieChart.</summary>
    [JsonPropertyName("chartType")]
    public string ChartType { get; set; }

    /// <summary>Required. The queries for the chart's data.</summary>
    [JsonPropertyName("dataSets")]
    public IList<V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChartDataSets> DataSets { get; set; }

    /// <summary>Optional. Indicates whether or not the pie chart should show slices' labels</summary>
    [JsonPropertyName("showLabels")]
    public bool? ShowLabels { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardBlankView
{
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardGaugeView
{
    /// <summary>The lower bound for this gauge chart. The value of the chart should always be greater than or equal to this.</summary>
    [JsonPropertyName("lowerBound")]
    public double? LowerBound { get; set; }

    /// <summary>The upper bound for this gauge chart. The value of the chart should always be less than or equal to this.</summary>
    [JsonPropertyName("upperBound")]
    public double? UpperBound { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardSparkChartView
{
    /// <summary>The lower bound on data point frequency in the chart implemented by specifying the minimum alignment period to use in a time series query.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>Required. The type of sparkchart to show in this chartView.</summary>
    [JsonPropertyName("sparkChartType")]
    public string SparkChartType { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardThresholds
{
    /// <summary>The state color for this threshold. Color is not allowed in a XyChart.</summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }

    /// <summary>The direction for the current threshold. Direction is not allowed in a XyChart.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>A label for the threshold.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The target axis to use for plotting the threshold. Target axis is not allowed in a Scorecard.</summary>
    [JsonPropertyName("targetAxis")]
    public string? TargetAxis { get; set; }

    /// <summary>The value of the threshold. The value should be defined in the native scale of the metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecard
{
    /// <summary>Will cause the `Scorecard` to show only the value, with no indicator to its value relative to its thresholds.</summary>
    [JsonPropertyName("blankView")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardBlankView? BlankView { get; set; }

    /// <summary>Will cause the scorecard to show a gauge chart.</summary>
    [JsonPropertyName("gaugeView")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardGaugeView? GaugeView { get; set; }

    /// <summary>Will cause the scorecard to show a spark chart.</summary>
    [JsonPropertyName("sparkChartView")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardSparkChartView? SparkChartView { get; set; }

    /// <summary>The thresholds used to determine the state of the scorecard given the time series' current value.</summary>
    [JsonPropertyName("thresholds")]
    public IList<V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardThresholds>? Thresholds { get; set; }

    /// <summary>Required. Fields for querying time series data from the Stackdriver metrics API.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecardTimeSeriesQuery TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsSectionHeader
{
    /// <summary>Whether to insert a divider below the section in the table of contents</summary>
    [JsonPropertyName("dividerBelow")]
    public bool? DividerBelow { get; set; }

    /// <summary>The subtitle of the section</summary>
    [JsonPropertyName("subtitle")]
    public string? Subtitle { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsSingleViewGroup
{
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTextStyle
{
    /// <summary>The background color as a hex string. "#RRGGBB" or "#RGB"</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>Font sizes for both the title and content. The title will still be larger relative to the content.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>The horizontal alignment of both the title and content</summary>
    [JsonPropertyName("horizontalAlignment")]
    public string? HorizontalAlignment { get; set; }

    /// <summary>The amount of padding around the widget</summary>
    [JsonPropertyName("padding")]
    public string? Padding { get; set; }

    /// <summary>The pointer location for this widget (also sometimes called a "tail")</summary>
    [JsonPropertyName("pointerLocation")]
    public string? PointerLocation { get; set; }

    /// <summary>The text color as a hex string. "#RRGGBB" or "#RGB"</summary>
    [JsonPropertyName("textColor")]
    public string? TextColor { get; set; }

    /// <summary>The vertical alignment of both the title and content</summary>
    [JsonPropertyName("verticalAlignment")]
    public string? VerticalAlignment { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsText
{
    /// <summary>The text content to be displayed.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>How the text content is formatted.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>How the text is styled</summary>
    [JsonPropertyName("style")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsTextStyle? Style { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableColumnSettings
{
    /// <summary>Required. The id of the column.</summary>
    [JsonPropertyName("column")]
    public string Column { get; set; }

    /// <summary>Required. Whether the column should be visible on page load.</summary>
    [JsonPropertyName("visible")]
    public bool Visible { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTableDisplayOptions
{
    /// <summary>Optional. This field is unused and has been replaced by TimeSeriesTable.column_settings</summary>
    [JsonPropertyName("shownColumns")]
    public IList<string>? ShownColumns { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSets
{
    /// <summary>Optional. The lower bound on data point frequency for this data set.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>Optional. Table display options for configuring how the table is rendered.</summary>
    [JsonPropertyName("tableDisplayOptions")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTableDisplayOptions? TableDisplayOptions { get; set; }

    /// <summary>Optional. A template string for naming `TimeSeries` in the resulting data set.</summary>
    [JsonPropertyName("tableTemplate")]
    public string? TableTemplate { get; set; }

    /// <summary>Required. Fields for querying time series data from the Stackdriver metrics API.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSetsTimeSeriesQuery? TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTable
{
    /// <summary>Optional. The list of the persistent column settings for the table.</summary>
    [JsonPropertyName("columnSettings")]
    public IList<V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableColumnSettings>? ColumnSettings { get; set; }

    /// <summary>Required. The data displayed in this table.</summary>
    [JsonPropertyName("dataSets")]
    public IList<V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTableDataSets> DataSets { get; set; }

    /// <summary>Optional. Store rendering strategy</summary>
    [JsonPropertyName("metricVisualization")]
    public string? MetricVisualization { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartChartOptions
{
    /// <summary>The chart mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSets
{
    /// <summary>A template string for naming `TimeSeries` in the resulting data set.</summary>
    [JsonPropertyName("legendTemplate")]
    public string? LegendTemplate { get; set; }

    /// <summary>Optional. The lower bound on data point frequency for this data set.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>How this data should be plotted on the chart.</summary>
    [JsonPropertyName("plotType")]
    public string? PlotType { get; set; }

    /// <summary>Optional. The target axis to use for plotting the metric.</summary>
    [JsonPropertyName("targetAxis")]
    public string? TargetAxis { get; set; }

    /// <summary>Fields for querying time series data from the Stackdriver metrics API.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSetsTimeSeriesQuery TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartThresholds
{
    /// <summary>The state color for this threshold. Color is not allowed in a XyChart.</summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }

    /// <summary>The direction for the current threshold. Direction is not allowed in a XyChart.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>A label for the threshold.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The target axis to use for plotting the threshold. Target axis is not allowed in a Scorecard.</summary>
    [JsonPropertyName("targetAxis")]
    public string? TargetAxis { get; set; }

    /// <summary>The value of the threshold. The value should be defined in the native scale of the metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartXAxis
{
    /// <summary>The label of the axis.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The axis scale. By default, a linear scale is used.</summary>
    [JsonPropertyName("scale")]
    public string? Scale { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartY2Axis
{
    /// <summary>The label of the axis.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The axis scale. By default, a linear scale is used.</summary>
    [JsonPropertyName("scale")]
    public string? Scale { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartYAxis
{
    /// <summary>The label of the axis.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The axis scale. By default, a linear scale is used.</summary>
    [JsonPropertyName("scale")]
    public string? Scale { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChart
{
    /// <summary>Display options for the chart.</summary>
    [JsonPropertyName("chartOptions")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartChartOptions? ChartOptions { get; set; }

    /// <summary>Required. The data displayed in this chart.</summary>
    [JsonPropertyName("dataSets")]
    public IList<V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartDataSets> DataSets { get; set; }

    /// <summary>Threshold lines drawn horizontally across the chart.</summary>
    [JsonPropertyName("thresholds")]
    public IList<V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartThresholds>? Thresholds { get; set; }

    /// <summary>The duration used to display a comparison chart.</summary>
    [JsonPropertyName("timeshiftDuration")]
    public string? TimeshiftDuration { get; set; }

    /// <summary>The properties applied to the x-axis.</summary>
    [JsonPropertyName("xAxis")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartXAxis? XAxis { get; set; }

    /// <summary>The properties applied to the y2-axis.</summary>
    [JsonPropertyName("y2Axis")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartY2Axis? Y2Axis { get; set; }

    /// <summary>The properties applied to the y-axis.</summary>
    [JsonPropertyName("yAxis")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChartYAxis? YAxis { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayoutWidgets
{
    /// <summary>A chart of alert policy data.</summary>
    [JsonPropertyName("alertChart")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsAlertChart? AlertChart { get; set; }

    /// <summary>A blank space.</summary>
    [JsonPropertyName("blank")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsBlank? Blank { get; set; }

    /// <summary>A widget that groups the other widgets. All widgets that are within the area spanned by the grouping widget are considered member widgets.</summary>
    [JsonPropertyName("collapsibleGroup")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsCollapsibleGroup? CollapsibleGroup { get; set; }

    /// <summary>A widget that displays a list of error groups.</summary>
    [JsonPropertyName("errorReportingPanel")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsErrorReportingPanel? ErrorReportingPanel { get; set; }

    /// <summary>Optional. The widget id. Ids may be made up of alphanumerics, dashes and underscores. Widget ids are optional.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A widget that shows list of incidents.</summary>
    [JsonPropertyName("incidentList")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsIncidentList? IncidentList { get; set; }

    /// <summary>A widget that shows a stream of logs.</summary>
    [JsonPropertyName("logsPanel")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsLogsPanel? LogsPanel { get; set; }

    /// <summary>A widget that displays timeseries data as a pie chart.</summary>
    [JsonPropertyName("pieChart")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsPieChart? PieChart { get; set; }

    /// <summary>A scorecard summarizing time series data.</summary>
    [JsonPropertyName("scorecard")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsScorecard? Scorecard { get; set; }

    /// <summary>A widget that defines a section header for easier navigation of the dashboard.</summary>
    [JsonPropertyName("sectionHeader")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsSectionHeader? SectionHeader { get; set; }

    /// <summary>A widget that groups the other widgets by using a dropdown menu.</summary>
    [JsonPropertyName("singleViewGroup")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsSingleViewGroup? SingleViewGroup { get; set; }

    /// <summary>A raw string or markdown displaying textual content.</summary>
    [JsonPropertyName("text")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsText? Text { get; set; }

    /// <summary>A widget that displays time series data in a tabular format.</summary>
    [JsonPropertyName("timeSeriesTable")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsTimeSeriesTable? TimeSeriesTable { get; set; }

    /// <summary>Optional. The title of the widget.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A chart of time series data.</summary>
    [JsonPropertyName("xyChart")]
    public V1beta1MonitoringDashboardSpecGridLayoutWidgetsXyChart? XyChart { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecGridLayout
{
    /// <summary>The number of columns into which the view's width is divided. If omitted or set to zero, a system default will be used while rendering.</summary>
    [JsonPropertyName("columns")]
    public long? Columns { get; set; }

    /// <summary>The informational elements that are arranged into the columns row-first.</summary>
    [JsonPropertyName("widgets")]
    public IList<V1beta1MonitoringDashboardSpecGridLayoutWidgets>? Widgets { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetAlertChartAlertPolicyRef
{
    /// <summary>The MonitoringAlertPolicy link in the form "projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetAlertChart
{
    /// <summary>Required. A reference to the MonitoringAlertPolicy.</summary>
    [JsonPropertyName("alertPolicyRef")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetAlertChartAlertPolicyRef AlertPolicyRef { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetBlank
{
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetCollapsibleGroup
{
    /// <summary>The collapsed state of the widget on first page load.</summary>
    [JsonPropertyName("collapsed")]
    public bool? Collapsed { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetErrorReportingPanelProjectRefs
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetErrorReportingPanel
{
    /// <summary>The projects from which to gather errors.</summary>
    [JsonPropertyName("projectRefs")]
    public IList<V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetErrorReportingPanelProjectRefs>? ProjectRefs { get; set; }

    /// <summary>An identifier of the service, such as the name of the executable, job, or Google App Engine service name. This field is expected to have a low number of values that are relatively stable over time, as opposed to `version`, which can be changed whenever new code is deployed.</summary>
    [JsonPropertyName("services")]
    public IList<string>? Services { get; set; }

    /// <summary>Represents the source code version that the developer provided, which could represent a version label or a Git SHA-1 hash, for example. For App Engine standard environment, the version is set to the version of the app.</summary>
    [JsonPropertyName("versions")]
    public IList<string>? Versions { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetIncidentListMonitoredResources
{
    /// <summary>Required. Values for all of the labels listed in the associated monitored resource descriptor.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Required. The monitored resource type. This field must match the `type` field of a [MonitoredResourceDescriptor][google.api.MonitoredResourceDescriptor] object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetIncidentListPolicyRefs
{
    /// <summary>The MonitoringAlertPolicy link in the form "projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetIncidentList
{
    /// <summary>Optional. The monitored resource for which incidents are listed.</summary>
    [JsonPropertyName("monitoredResources")]
    public IList<V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetIncidentListMonitoredResources>? MonitoredResources { get; set; }

    /// <summary>Optional. A list of alert policies to filter the incident list by.</summary>
    [JsonPropertyName("policyRefs")]
    public IList<V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetIncidentListPolicyRefs>? PolicyRefs { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetLogsPanelResourceNames
{
    /// <summary>The external name of the referenced resource</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetLogsPanel
{
    /// <summary>A filter that chooses which log entries to return.  See [Advanced Logs Queries](https://cloud.google.com/logging/docs/view/advanced-queries).</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The names of logging resources to collect logs for.</summary>
    [JsonPropertyName("resourceNames")]
    public IList<V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetLogsPanelResourceNames>? ResourceNames { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSets
{
    /// <summary>Optional. The lower bound on data point frequency for this data set.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>Optional. A template for the name of the slice.</summary>
    [JsonPropertyName("sliceNameTemplate")]
    public string? SliceNameTemplate { get; set; }

    /// <summary>Required. The query for the PieChart. See, `google.monitoring.dashboard.v1.TimeSeriesQuery`.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSetsTimeSeriesQuery TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChart
{
    /// <summary>Required. Indicates the visualization type for the PieChart.</summary>
    [JsonPropertyName("chartType")]
    public string ChartType { get; set; }

    /// <summary>Required. The queries for the chart's data.</summary>
    [JsonPropertyName("dataSets")]
    public IList<V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChartDataSets> DataSets { get; set; }

    /// <summary>Optional. Indicates whether or not the pie chart should show slices' labels</summary>
    [JsonPropertyName("showLabels")]
    public bool? ShowLabels { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardBlankView
{
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardGaugeView
{
    /// <summary>The lower bound for this gauge chart. The value of the chart should always be greater than or equal to this.</summary>
    [JsonPropertyName("lowerBound")]
    public double? LowerBound { get; set; }

    /// <summary>The upper bound for this gauge chart. The value of the chart should always be less than or equal to this.</summary>
    [JsonPropertyName("upperBound")]
    public double? UpperBound { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardSparkChartView
{
    /// <summary>The lower bound on data point frequency in the chart implemented by specifying the minimum alignment period to use in a time series query.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>Required. The type of sparkchart to show in this chartView.</summary>
    [JsonPropertyName("sparkChartType")]
    public string SparkChartType { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardThresholds
{
    /// <summary>The state color for this threshold. Color is not allowed in a XyChart.</summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }

    /// <summary>The direction for the current threshold. Direction is not allowed in a XyChart.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>A label for the threshold.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The target axis to use for plotting the threshold. Target axis is not allowed in a Scorecard.</summary>
    [JsonPropertyName("targetAxis")]
    public string? TargetAxis { get; set; }

    /// <summary>The value of the threshold. The value should be defined in the native scale of the metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecard
{
    /// <summary>Will cause the `Scorecard` to show only the value, with no indicator to its value relative to its thresholds.</summary>
    [JsonPropertyName("blankView")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardBlankView? BlankView { get; set; }

    /// <summary>Will cause the scorecard to show a gauge chart.</summary>
    [JsonPropertyName("gaugeView")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardGaugeView? GaugeView { get; set; }

    /// <summary>Will cause the scorecard to show a spark chart.</summary>
    [JsonPropertyName("sparkChartView")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardSparkChartView? SparkChartView { get; set; }

    /// <summary>The thresholds used to determine the state of the scorecard given the time series' current value.</summary>
    [JsonPropertyName("thresholds")]
    public IList<V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardThresholds>? Thresholds { get; set; }

    /// <summary>Required. Fields for querying time series data from the Stackdriver metrics API.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecardTimeSeriesQuery TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetSectionHeader
{
    /// <summary>Whether to insert a divider below the section in the table of contents</summary>
    [JsonPropertyName("dividerBelow")]
    public bool? DividerBelow { get; set; }

    /// <summary>The subtitle of the section</summary>
    [JsonPropertyName("subtitle")]
    public string? Subtitle { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetSingleViewGroup
{
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTextStyle
{
    /// <summary>The background color as a hex string. "#RRGGBB" or "#RGB"</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>Font sizes for both the title and content. The title will still be larger relative to the content.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>The horizontal alignment of both the title and content</summary>
    [JsonPropertyName("horizontalAlignment")]
    public string? HorizontalAlignment { get; set; }

    /// <summary>The amount of padding around the widget</summary>
    [JsonPropertyName("padding")]
    public string? Padding { get; set; }

    /// <summary>The pointer location for this widget (also sometimes called a "tail")</summary>
    [JsonPropertyName("pointerLocation")]
    public string? PointerLocation { get; set; }

    /// <summary>The text color as a hex string. "#RRGGBB" or "#RGB"</summary>
    [JsonPropertyName("textColor")]
    public string? TextColor { get; set; }

    /// <summary>The vertical alignment of both the title and content</summary>
    [JsonPropertyName("verticalAlignment")]
    public string? VerticalAlignment { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetText
{
    /// <summary>The text content to be displayed.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>How the text content is formatted.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>How the text is styled</summary>
    [JsonPropertyName("style")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTextStyle? Style { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableColumnSettings
{
    /// <summary>Required. The id of the column.</summary>
    [JsonPropertyName("column")]
    public string Column { get; set; }

    /// <summary>Required. Whether the column should be visible on page load.</summary>
    [JsonPropertyName("visible")]
    public bool Visible { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTableDisplayOptions
{
    /// <summary>Optional. This field is unused and has been replaced by TimeSeriesTable.column_settings</summary>
    [JsonPropertyName("shownColumns")]
    public IList<string>? ShownColumns { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSets
{
    /// <summary>Optional. The lower bound on data point frequency for this data set.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>Optional. Table display options for configuring how the table is rendered.</summary>
    [JsonPropertyName("tableDisplayOptions")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTableDisplayOptions? TableDisplayOptions { get; set; }

    /// <summary>Optional. A template string for naming `TimeSeries` in the resulting data set.</summary>
    [JsonPropertyName("tableTemplate")]
    public string? TableTemplate { get; set; }

    /// <summary>Required. Fields for querying time series data from the Stackdriver metrics API.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSetsTimeSeriesQuery? TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTable
{
    /// <summary>Optional. The list of the persistent column settings for the table.</summary>
    [JsonPropertyName("columnSettings")]
    public IList<V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableColumnSettings>? ColumnSettings { get; set; }

    /// <summary>Required. The data displayed in this table.</summary>
    [JsonPropertyName("dataSets")]
    public IList<V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTableDataSets> DataSets { get; set; }

    /// <summary>Optional. Store rendering strategy</summary>
    [JsonPropertyName("metricVisualization")]
    public string? MetricVisualization { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartChartOptions
{
    /// <summary>The chart mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSets
{
    /// <summary>A template string for naming `TimeSeries` in the resulting data set.</summary>
    [JsonPropertyName("legendTemplate")]
    public string? LegendTemplate { get; set; }

    /// <summary>Optional. The lower bound on data point frequency for this data set.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>How this data should be plotted on the chart.</summary>
    [JsonPropertyName("plotType")]
    public string? PlotType { get; set; }

    /// <summary>Optional. The target axis to use for plotting the metric.</summary>
    [JsonPropertyName("targetAxis")]
    public string? TargetAxis { get; set; }

    /// <summary>Fields for querying time series data from the Stackdriver metrics API.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSetsTimeSeriesQuery TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartThresholds
{
    /// <summary>The state color for this threshold. Color is not allowed in a XyChart.</summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }

    /// <summary>The direction for the current threshold. Direction is not allowed in a XyChart.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>A label for the threshold.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The target axis to use for plotting the threshold. Target axis is not allowed in a Scorecard.</summary>
    [JsonPropertyName("targetAxis")]
    public string? TargetAxis { get; set; }

    /// <summary>The value of the threshold. The value should be defined in the native scale of the metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartXAxis
{
    /// <summary>The label of the axis.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The axis scale. By default, a linear scale is used.</summary>
    [JsonPropertyName("scale")]
    public string? Scale { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartY2Axis
{
    /// <summary>The label of the axis.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The axis scale. By default, a linear scale is used.</summary>
    [JsonPropertyName("scale")]
    public string? Scale { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartYAxis
{
    /// <summary>The label of the axis.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The axis scale. By default, a linear scale is used.</summary>
    [JsonPropertyName("scale")]
    public string? Scale { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChart
{
    /// <summary>Display options for the chart.</summary>
    [JsonPropertyName("chartOptions")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartChartOptions? ChartOptions { get; set; }

    /// <summary>Required. The data displayed in this chart.</summary>
    [JsonPropertyName("dataSets")]
    public IList<V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartDataSets> DataSets { get; set; }

    /// <summary>Threshold lines drawn horizontally across the chart.</summary>
    [JsonPropertyName("thresholds")]
    public IList<V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartThresholds>? Thresholds { get; set; }

    /// <summary>The duration used to display a comparison chart.</summary>
    [JsonPropertyName("timeshiftDuration")]
    public string? TimeshiftDuration { get; set; }

    /// <summary>The properties applied to the x-axis.</summary>
    [JsonPropertyName("xAxis")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartXAxis? XAxis { get; set; }

    /// <summary>The properties applied to the y2-axis.</summary>
    [JsonPropertyName("y2Axis")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartY2Axis? Y2Axis { get; set; }

    /// <summary>The properties applied to the y-axis.</summary>
    [JsonPropertyName("yAxis")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChartYAxis? YAxis { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidget
{
    /// <summary>A chart of alert policy data.</summary>
    [JsonPropertyName("alertChart")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetAlertChart? AlertChart { get; set; }

    /// <summary>A blank space.</summary>
    [JsonPropertyName("blank")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetBlank? Blank { get; set; }

    /// <summary>A widget that groups the other widgets. All widgets that are within the area spanned by the grouping widget are considered member widgets.</summary>
    [JsonPropertyName("collapsibleGroup")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetCollapsibleGroup? CollapsibleGroup { get; set; }

    /// <summary>A widget that displays a list of error groups.</summary>
    [JsonPropertyName("errorReportingPanel")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetErrorReportingPanel? ErrorReportingPanel { get; set; }

    /// <summary>Optional. The widget id. Ids may be made up of alphanumerics, dashes and underscores. Widget ids are optional.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A widget that shows list of incidents.</summary>
    [JsonPropertyName("incidentList")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetIncidentList? IncidentList { get; set; }

    /// <summary>A widget that shows a stream of logs.</summary>
    [JsonPropertyName("logsPanel")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetLogsPanel? LogsPanel { get; set; }

    /// <summary>A widget that displays timeseries data as a pie chart.</summary>
    [JsonPropertyName("pieChart")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetPieChart? PieChart { get; set; }

    /// <summary>A scorecard summarizing time series data.</summary>
    [JsonPropertyName("scorecard")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetScorecard? Scorecard { get; set; }

    /// <summary>A widget that defines a section header for easier navigation of the dashboard.</summary>
    [JsonPropertyName("sectionHeader")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetSectionHeader? SectionHeader { get; set; }

    /// <summary>A widget that groups the other widgets by using a dropdown menu.</summary>
    [JsonPropertyName("singleViewGroup")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetSingleViewGroup? SingleViewGroup { get; set; }

    /// <summary>A raw string or markdown displaying textual content.</summary>
    [JsonPropertyName("text")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetText? Text { get; set; }

    /// <summary>A widget that displays time series data in a tabular format.</summary>
    [JsonPropertyName("timeSeriesTable")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetTimeSeriesTable? TimeSeriesTable { get; set; }

    /// <summary>Optional. The title of the widget.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A chart of time series data.</summary>
    [JsonPropertyName("xyChart")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidgetXyChart? XyChart { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayoutTiles
{
    /// <summary>The height of the tile, measured in grid blocks. Tiles must have a minimum height of 1.</summary>
    [JsonPropertyName("height")]
    public int? Height { get; set; }

    /// <summary>The informational widget contained in the tile. For example an `XyChart`.</summary>
    [JsonPropertyName("widget")]
    public V1beta1MonitoringDashboardSpecMosaicLayoutTilesWidget? Widget { get; set; }

    /// <summary>The width of the tile, measured in grid blocks. Tiles must have a minimum width of 1.</summary>
    [JsonPropertyName("width")]
    public int? Width { get; set; }

    /// <summary>The zero-indexed position of the tile in grid blocks relative to the left edge of the grid. Tiles must be contained within the specified number of columns. `x_pos` cannot be negative.</summary>
    [JsonPropertyName("xPos")]
    public int? XPos { get; set; }

    /// <summary>The zero-indexed position of the tile in grid blocks relative to the top edge of the grid. `y_pos` cannot be negative.</summary>
    [JsonPropertyName("yPos")]
    public int? YPos { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecMosaicLayout
{
    /// <summary>The number of columns in the mosaic grid. The number of columns must be between 1 and 12, inclusive.</summary>
    [JsonPropertyName("columns")]
    public int? Columns { get; set; }

    /// <summary>The tiles to display.</summary>
    [JsonPropertyName("tiles")]
    public IList<V1beta1MonitoringDashboardSpecMosaicLayoutTiles>? Tiles { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsAlertChartAlertPolicyRef
{
    /// <summary>The MonitoringAlertPolicy link in the form "projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsAlertChart
{
    /// <summary>Required. A reference to the MonitoringAlertPolicy.</summary>
    [JsonPropertyName("alertPolicyRef")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsAlertChartAlertPolicyRef AlertPolicyRef { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsBlank
{
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsCollapsibleGroup
{
    /// <summary>The collapsed state of the widget on first page load.</summary>
    [JsonPropertyName("collapsed")]
    public bool? Collapsed { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsErrorReportingPanelProjectRefs
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsErrorReportingPanel
{
    /// <summary>The projects from which to gather errors.</summary>
    [JsonPropertyName("projectRefs")]
    public IList<V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsErrorReportingPanelProjectRefs>? ProjectRefs { get; set; }

    /// <summary>An identifier of the service, such as the name of the executable, job, or Google App Engine service name. This field is expected to have a low number of values that are relatively stable over time, as opposed to `version`, which can be changed whenever new code is deployed.</summary>
    [JsonPropertyName("services")]
    public IList<string>? Services { get; set; }

    /// <summary>Represents the source code version that the developer provided, which could represent a version label or a Git SHA-1 hash, for example. For App Engine standard environment, the version is set to the version of the app.</summary>
    [JsonPropertyName("versions")]
    public IList<string>? Versions { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsIncidentListMonitoredResources
{
    /// <summary>Required. Values for all of the labels listed in the associated monitored resource descriptor.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Required. The monitored resource type. This field must match the `type` field of a [MonitoredResourceDescriptor][google.api.MonitoredResourceDescriptor] object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsIncidentListPolicyRefs
{
    /// <summary>The MonitoringAlertPolicy link in the form "projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `MonitoringAlertPolicy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsIncidentList
{
    /// <summary>Optional. The monitored resource for which incidents are listed.</summary>
    [JsonPropertyName("monitoredResources")]
    public IList<V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsIncidentListMonitoredResources>? MonitoredResources { get; set; }

    /// <summary>Optional. A list of alert policies to filter the incident list by.</summary>
    [JsonPropertyName("policyRefs")]
    public IList<V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsIncidentListPolicyRefs>? PolicyRefs { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsLogsPanelResourceNames
{
    /// <summary>The external name of the referenced resource</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsLogsPanel
{
    /// <summary>A filter that chooses which log entries to return.  See [Advanced Logs Queries](https://cloud.google.com/logging/docs/view/advanced-queries).</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The names of logging resources to collect logs for.</summary>
    [JsonPropertyName("resourceNames")]
    public IList<V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsLogsPanelResourceNames>? ResourceNames { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSets
{
    /// <summary>Optional. The lower bound on data point frequency for this data set.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>Optional. A template for the name of the slice.</summary>
    [JsonPropertyName("sliceNameTemplate")]
    public string? SliceNameTemplate { get; set; }

    /// <summary>Required. The query for the PieChart. See, `google.monitoring.dashboard.v1.TimeSeriesQuery`.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSetsTimeSeriesQuery TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChart
{
    /// <summary>Required. Indicates the visualization type for the PieChart.</summary>
    [JsonPropertyName("chartType")]
    public string ChartType { get; set; }

    /// <summary>Required. The queries for the chart's data.</summary>
    [JsonPropertyName("dataSets")]
    public IList<V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChartDataSets> DataSets { get; set; }

    /// <summary>Optional. Indicates whether or not the pie chart should show slices' labels</summary>
    [JsonPropertyName("showLabels")]
    public bool? ShowLabels { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardBlankView
{
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardGaugeView
{
    /// <summary>The lower bound for this gauge chart. The value of the chart should always be greater than or equal to this.</summary>
    [JsonPropertyName("lowerBound")]
    public double? LowerBound { get; set; }

    /// <summary>The upper bound for this gauge chart. The value of the chart should always be less than or equal to this.</summary>
    [JsonPropertyName("upperBound")]
    public double? UpperBound { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardSparkChartView
{
    /// <summary>The lower bound on data point frequency in the chart implemented by specifying the minimum alignment period to use in a time series query.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>Required. The type of sparkchart to show in this chartView.</summary>
    [JsonPropertyName("sparkChartType")]
    public string SparkChartType { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardThresholds
{
    /// <summary>The state color for this threshold. Color is not allowed in a XyChart.</summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }

    /// <summary>The direction for the current threshold. Direction is not allowed in a XyChart.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>A label for the threshold.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The target axis to use for plotting the threshold. Target axis is not allowed in a Scorecard.</summary>
    [JsonPropertyName("targetAxis")]
    public string? TargetAxis { get; set; }

    /// <summary>The value of the threshold. The value should be defined in the native scale of the metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecard
{
    /// <summary>Will cause the `Scorecard` to show only the value, with no indicator to its value relative to its thresholds.</summary>
    [JsonPropertyName("blankView")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardBlankView? BlankView { get; set; }

    /// <summary>Will cause the scorecard to show a gauge chart.</summary>
    [JsonPropertyName("gaugeView")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardGaugeView? GaugeView { get; set; }

    /// <summary>Will cause the scorecard to show a spark chart.</summary>
    [JsonPropertyName("sparkChartView")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardSparkChartView? SparkChartView { get; set; }

    /// <summary>The thresholds used to determine the state of the scorecard given the time series' current value.</summary>
    [JsonPropertyName("thresholds")]
    public IList<V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardThresholds>? Thresholds { get; set; }

    /// <summary>Required. Fields for querying time series data from the Stackdriver metrics API.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecardTimeSeriesQuery TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsSectionHeader
{
    /// <summary>Whether to insert a divider below the section in the table of contents</summary>
    [JsonPropertyName("dividerBelow")]
    public bool? DividerBelow { get; set; }

    /// <summary>The subtitle of the section</summary>
    [JsonPropertyName("subtitle")]
    public string? Subtitle { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsSingleViewGroup
{
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTextStyle
{
    /// <summary>The background color as a hex string. "#RRGGBB" or "#RGB"</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>Font sizes for both the title and content. The title will still be larger relative to the content.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>The horizontal alignment of both the title and content</summary>
    [JsonPropertyName("horizontalAlignment")]
    public string? HorizontalAlignment { get; set; }

    /// <summary>The amount of padding around the widget</summary>
    [JsonPropertyName("padding")]
    public string? Padding { get; set; }

    /// <summary>The pointer location for this widget (also sometimes called a "tail")</summary>
    [JsonPropertyName("pointerLocation")]
    public string? PointerLocation { get; set; }

    /// <summary>The text color as a hex string. "#RRGGBB" or "#RGB"</summary>
    [JsonPropertyName("textColor")]
    public string? TextColor { get; set; }

    /// <summary>The vertical alignment of both the title and content</summary>
    [JsonPropertyName("verticalAlignment")]
    public string? VerticalAlignment { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsText
{
    /// <summary>The text content to be displayed.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>How the text content is formatted.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>How the text is styled</summary>
    [JsonPropertyName("style")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTextStyle? Style { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableColumnSettings
{
    /// <summary>Required. The id of the column.</summary>
    [JsonPropertyName("column")]
    public string Column { get; set; }

    /// <summary>Required. Whether the column should be visible on page load.</summary>
    [JsonPropertyName("visible")]
    public bool Visible { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTableDisplayOptions
{
    /// <summary>Optional. This field is unused and has been replaced by TimeSeriesTable.column_settings</summary>
    [JsonPropertyName("shownColumns")]
    public IList<string>? ShownColumns { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSets
{
    /// <summary>Optional. The lower bound on data point frequency for this data set.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>Optional. Table display options for configuring how the table is rendered.</summary>
    [JsonPropertyName("tableDisplayOptions")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTableDisplayOptions? TableDisplayOptions { get; set; }

    /// <summary>Optional. A template string for naming `TimeSeries` in the resulting data set.</summary>
    [JsonPropertyName("tableTemplate")]
    public string? TableTemplate { get; set; }

    /// <summary>Required. Fields for querying time series data from the Stackdriver metrics API.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSetsTimeSeriesQuery? TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTable
{
    /// <summary>Optional. The list of the persistent column settings for the table.</summary>
    [JsonPropertyName("columnSettings")]
    public IList<V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableColumnSettings>? ColumnSettings { get; set; }

    /// <summary>Required. The data displayed in this table.</summary>
    [JsonPropertyName("dataSets")]
    public IList<V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTableDataSets> DataSets { get; set; }

    /// <summary>Optional. Store rendering strategy</summary>
    [JsonPropertyName("metricVisualization")]
    public string? MetricVisualization { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartChartOptions
{
    /// <summary>The chart mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilter
{
    /// <summary>By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterAggregation? Aggregation { get; set; }

    /// <summary>Required. The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after `aggregation` is applied.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominatorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator
{
    /// <summary>By default, the raw time series data is returned.</summary>
    [JsonPropertyName("aggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumeratorAggregation? Aggregation { get; set; }

    /// <summary>The [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter
{
    /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>How many time series to allow to pass through the filter.</summary>
    [JsonPropertyName("numTimeSeries")]
    public int? NumTimeSeries { get; set; }

    /// <summary>`ranking_method` is applied to each time series independently to produce the value which will be used to compare the time series to other time series.</summary>
    [JsonPropertyName("rankingMethod")]
    public string? RankingMethod { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation
{
    /// <summary>The `alignment_period` specifies a time interval, in seconds, that is used to divide the data in all the [time series][google.monitoring.v3.TimeSeries] into consistent blocks of time. This will be done before the per-series aligner can be applied to the data.</summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>The reduction operation to be used to combine time series into a single time series, where the value of each data point in the resulting series is a function of all the already aligned values in the input time series.</summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>The set of fields to preserve when `cross_series_reducer` is specified.</summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>An `Aligner` describes how to bring the data points in a single time series into temporal alignment. Except for `ALIGN_NONE`, all alignments cause all the data points in an `alignment_period` to be mathematically grouped together, resulting in a single data point for each `alignment_period` with end timestamp at the end of the period.</summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio
{
    /// <summary>The denominator of the ratio.</summary>
    [JsonPropertyName("denominator")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioDenominator? Denominator { get; set; }

    /// <summary>The numerator of the ratio.</summary>
    [JsonPropertyName("numerator")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioNumerator? Numerator { get; set; }

    /// <summary>Ranking based time series filter.</summary>
    [JsonPropertyName("pickTimeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioPickTimeSeriesFilter? PickTimeSeriesFilter { get; set; }

    /// <summary>Apply a second aggregation after the ratio is computed.</summary>
    [JsonPropertyName("secondaryAggregation")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatioSecondaryAggregation? SecondaryAggregation { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQuery
{
    /// <summary>Optional. If set, Cloud Monitoring will treat the full query duration as the alignment period so that there will be only 1 output value.</summary>
    [JsonPropertyName("outputFullDuration")]
    public bool? OutputFullDuration { get; set; }

    /// <summary>A query used to fetch time series with PromQL.</summary>
    [JsonPropertyName("prometheusQuery")]
    public string? PrometheusQuery { get; set; }

    /// <summary>Filter parameters to fetch time series.</summary>
    [JsonPropertyName("timeSeriesFilter")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilter? TimeSeriesFilter { get; set; }

    /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
    [JsonPropertyName("timeSeriesFilterRatio")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQueryTimeSeriesFilterRatio? TimeSeriesFilterRatio { get; set; }

    /// <summary>A query used to fetch time series with MQL.</summary>
    [JsonPropertyName("timeSeriesQueryLanguage")]
    public string? TimeSeriesQueryLanguage { get; set; }

    /// <summary>The unit of data contained in fetched time series. If non-empty, this unit will override any unit that accompanies fetched data. The format is the same as the [`unit`](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in `MetricDescriptor`.</summary>
    [JsonPropertyName("unitOverride")]
    public string? UnitOverride { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSets
{
    /// <summary>A template string for naming `TimeSeries` in the resulting data set.</summary>
    [JsonPropertyName("legendTemplate")]
    public string? LegendTemplate { get; set; }

    /// <summary>Optional. The lower bound on data point frequency for this data set.</summary>
    [JsonPropertyName("minAlignmentPeriod")]
    public string? MinAlignmentPeriod { get; set; }

    /// <summary>How this data should be plotted on the chart.</summary>
    [JsonPropertyName("plotType")]
    public string? PlotType { get; set; }

    /// <summary>Optional. The target axis to use for plotting the metric.</summary>
    [JsonPropertyName("targetAxis")]
    public string? TargetAxis { get; set; }

    /// <summary>Fields for querying time series data from the Stackdriver metrics API.</summary>
    [JsonPropertyName("timeSeriesQuery")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSetsTimeSeriesQuery TimeSeriesQuery { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartThresholds
{
    /// <summary>The state color for this threshold. Color is not allowed in a XyChart.</summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }

    /// <summary>The direction for the current threshold. Direction is not allowed in a XyChart.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>A label for the threshold.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The target axis to use for plotting the threshold. Target axis is not allowed in a Scorecard.</summary>
    [JsonPropertyName("targetAxis")]
    public string? TargetAxis { get; set; }

    /// <summary>The value of the threshold. The value should be defined in the native scale of the metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartXAxis
{
    /// <summary>The label of the axis.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The axis scale. By default, a linear scale is used.</summary>
    [JsonPropertyName("scale")]
    public string? Scale { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartY2Axis
{
    /// <summary>The label of the axis.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The axis scale. By default, a linear scale is used.</summary>
    [JsonPropertyName("scale")]
    public string? Scale { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartYAxis
{
    /// <summary>The label of the axis.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The axis scale. By default, a linear scale is used.</summary>
    [JsonPropertyName("scale")]
    public string? Scale { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChart
{
    /// <summary>Display options for the chart.</summary>
    [JsonPropertyName("chartOptions")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartChartOptions? ChartOptions { get; set; }

    /// <summary>Required. The data displayed in this chart.</summary>
    [JsonPropertyName("dataSets")]
    public IList<V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartDataSets> DataSets { get; set; }

    /// <summary>Threshold lines drawn horizontally across the chart.</summary>
    [JsonPropertyName("thresholds")]
    public IList<V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartThresholds>? Thresholds { get; set; }

    /// <summary>The duration used to display a comparison chart.</summary>
    [JsonPropertyName("timeshiftDuration")]
    public string? TimeshiftDuration { get; set; }

    /// <summary>The properties applied to the x-axis.</summary>
    [JsonPropertyName("xAxis")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartXAxis? XAxis { get; set; }

    /// <summary>The properties applied to the y2-axis.</summary>
    [JsonPropertyName("y2Axis")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartY2Axis? Y2Axis { get; set; }

    /// <summary>The properties applied to the y-axis.</summary>
    [JsonPropertyName("yAxis")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChartYAxis? YAxis { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRowsWidgets
{
    /// <summary>A chart of alert policy data.</summary>
    [JsonPropertyName("alertChart")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsAlertChart? AlertChart { get; set; }

    /// <summary>A blank space.</summary>
    [JsonPropertyName("blank")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsBlank? Blank { get; set; }

    /// <summary>A widget that groups the other widgets. All widgets that are within the area spanned by the grouping widget are considered member widgets.</summary>
    [JsonPropertyName("collapsibleGroup")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsCollapsibleGroup? CollapsibleGroup { get; set; }

    /// <summary>A widget that displays a list of error groups.</summary>
    [JsonPropertyName("errorReportingPanel")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsErrorReportingPanel? ErrorReportingPanel { get; set; }

    /// <summary>Optional. The widget id. Ids may be made up of alphanumerics, dashes and underscores. Widget ids are optional.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A widget that shows list of incidents.</summary>
    [JsonPropertyName("incidentList")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsIncidentList? IncidentList { get; set; }

    /// <summary>A widget that shows a stream of logs.</summary>
    [JsonPropertyName("logsPanel")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsLogsPanel? LogsPanel { get; set; }

    /// <summary>A widget that displays timeseries data as a pie chart.</summary>
    [JsonPropertyName("pieChart")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsPieChart? PieChart { get; set; }

    /// <summary>A scorecard summarizing time series data.</summary>
    [JsonPropertyName("scorecard")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsScorecard? Scorecard { get; set; }

    /// <summary>A widget that defines a section header for easier navigation of the dashboard.</summary>
    [JsonPropertyName("sectionHeader")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsSectionHeader? SectionHeader { get; set; }

    /// <summary>A widget that groups the other widgets by using a dropdown menu.</summary>
    [JsonPropertyName("singleViewGroup")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsSingleViewGroup? SingleViewGroup { get; set; }

    /// <summary>A raw string or markdown displaying textual content.</summary>
    [JsonPropertyName("text")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsText? Text { get; set; }

    /// <summary>A widget that displays time series data in a tabular format.</summary>
    [JsonPropertyName("timeSeriesTable")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsTimeSeriesTable? TimeSeriesTable { get; set; }

    /// <summary>Optional. The title of the widget.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A chart of time series data.</summary>
    [JsonPropertyName("xyChart")]
    public V1beta1MonitoringDashboardSpecRowLayoutRowsWidgetsXyChart? XyChart { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayoutRows
{
    /// <summary>The relative weight of this row. The row weight is used to adjust the height of rows on the screen (relative to peers).</summary>
    [JsonPropertyName("weight")]
    public long? Weight { get; set; }

    /// <summary>The display widgets arranged horizontally in this row.</summary>
    [JsonPropertyName("widgets")]
    public IList<V1beta1MonitoringDashboardSpecRowLayoutRowsWidgets>? Widgets { get; set; }
}

public partial class V1beta1MonitoringDashboardSpecRowLayout
{
    /// <summary>The rows of content to display.</summary>
    [JsonPropertyName("rows")]
    public IList<V1beta1MonitoringDashboardSpecRowLayoutRows>? Rows { get; set; }
}

public partial class V1beta1MonitoringDashboardSpec
{
    /// <summary>The content is divided into equally spaced columns and the widgets are arranged vertically.</summary>
    [JsonPropertyName("columnLayout")]
    public V1beta1MonitoringDashboardSpecColumnLayout? ColumnLayout { get; set; }

    /// <summary>Filters to reduce the amount of data charted based on the filter criteria.</summary>
    [JsonPropertyName("dashboardFilters")]
    public IList<V1beta1MonitoringDashboardSpecDashboardFilters>? DashboardFilters { get; set; }

    /// <summary>Required. The mutable, human-readable name.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Content is arranged with a basic layout that re-flows a simple list of informational elements like widgets or tiles.</summary>
    [JsonPropertyName("gridLayout")]
    public V1beta1MonitoringDashboardSpecGridLayout? GridLayout { get; set; }

    /// <summary>The content is arranged as a grid of tiles, with each content widget occupying one or more grid blocks.</summary>
    [JsonPropertyName("mosaicLayout")]
    public V1beta1MonitoringDashboardSpecMosaicLayout? MosaicLayout { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1MonitoringDashboardSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The content is divided into equally spaced rows and the widgets are arranged horizontally.</summary>
    [JsonPropertyName("rowLayout")]
    public V1beta1MonitoringDashboardSpecRowLayout? RowLayout { get; set; }
}

public partial class V1beta1MonitoringDashboardStatusConditions
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

public partial class V1beta1MonitoringDashboardStatus
{
    /// <summary>Conditions represent the latest available observations of the MonitoringDashboard's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitoringDashboardStatusConditions>? Conditions { get; set; }

    /// <summary>\`etag\` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitoringDashboard : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitoringDashboardSpec>, IStatus<V1beta1MonitoringDashboardStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitoringDashboard";
    public const string KubeGroup = "monitoring.cnrm.cloud.google.com";
    public const string KubePluralName = "monitoringdashboards";
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
    public V1beta1MonitoringDashboardSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1MonitoringDashboardStatus? Status { get; set; }
}