using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.logging.cnrm.cloud.google.com;
/// <summary>The explicit buckets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogMetricSpecBucketOptionsExplicitBuckets
{
    /// <summary>The values must be monotonically increasing.</summary>
    [JsonPropertyName("bounds")]
    public IList<double>? Bounds { get; set; }
}

/// <summary>The exponential buckets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogMetricSpecBucketOptionsExponentialBuckets
{
    /// <summary>Must be greater than 1.</summary>
    [JsonPropertyName("growthFactor")]
    public double? GrowthFactor { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("numFiniteBuckets")]
    public long? NumFiniteBuckets { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

/// <summary>The linear bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogMetricSpecBucketOptionsLinearBuckets
{
    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("numFiniteBuckets")]
    public long? NumFiniteBuckets { get; set; }

    /// <summary>Lower bound of the first bucket.</summary>
    [JsonPropertyName("offset")]
    public double? Offset { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary>Optional. The `bucket_options` are required when the logs-based metric is using a DISTRIBUTION value type and it describes the bucket boundaries used to create a histogram of the extracted values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogMetricSpecBucketOptions
{
    /// <summary>The explicit buckets.</summary>
    [JsonPropertyName("explicitBuckets")]
    public V1beta1LoggingLogMetricSpecBucketOptionsExplicitBuckets? ExplicitBuckets { get; set; }

    /// <summary>The exponential buckets.</summary>
    [JsonPropertyName("exponentialBuckets")]
    public V1beta1LoggingLogMetricSpecBucketOptionsExponentialBuckets? ExponentialBuckets { get; set; }

    /// <summary>The linear bucket.</summary>
    [JsonPropertyName("linearBuckets")]
    public V1beta1LoggingLogMetricSpecBucketOptionsLinearBuckets? LinearBuckets { get; set; }
}

/// <summary>The reference to the Log Bucket that owns the Log Metric. Only Log Buckets in projects are supported. The bucket has to be in the same project as the metric. For example:projects/my-project/locations/global/buckets/my-bucket If empty, then the Log Metric is considered a non-Bucket Log Metric. Only `external` field is supported to configure the reference for now.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogMetricSpecLoggingLogBucketRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogMetricSpecMetricDescriptorLabels
{
    /// <summary>Immutable. A human-readable description for the label.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The label key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Immutable. The type of data that can be assigned to the label. Possible values: STRING, BOOL, INT64, DOUBLE, DISTRIBUTION, MONEY</summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

/// <summary>Optional. Metadata which can be used to guide usage of the metric.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogMetricSpecMetricDescriptorMetadata
{
    /// <summary>The delay of data points caused by ingestion. Data points older than this age are guaranteed to be ingested and available to be read, excluding data loss due to errors.</summary>
    [JsonPropertyName("ingestDelay")]
    public string? IngestDelay { get; set; }

    /// <summary>The sampling period of metric data points. For metrics which are written periodically, consecutive data points are stored at this time interval, excluding data loss due to errors. Metrics with a higher granularity have a smaller sampling period.</summary>
    [JsonPropertyName("samplePeriod")]
    public string? SamplePeriod { get; set; }
}

/// <summary>Optional. The metric descriptor associated with the logs-based metric. If unspecified, it uses a default metric descriptor with a DELTA metric kind, INT64 value type, with no labels and a unit of "1". Such a metric counts the number of log entries matching the `filter` expression. The `name`, `type`, and `description` fields in the `metric_descriptor` are output only, and is constructed using the `name` and `description` field in the LogMetric. To create a logs-based metric that records a distribution of log values, a DELTA metric kind with a DISTRIBUTION value type must be used along with a `value_extractor` expression in the LogMetric. Each label in the metric descriptor must have a matching label name as the key and an extractor expression as the value in the `label_extractors` map. The `metric_kind` and `value_type` fields in the `metric_descriptor` cannot be updated once initially configured. New labels can be added in the `metric_descriptor`, but existing labels cannot be modified except for their description.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogMetricSpecMetricDescriptor
{
    /// <summary>A concise name for the metric, which can be displayed in user interfaces. Use sentence case without an ending period, for example "Request count". This field is optional but it is recommended to be set for any metrics associated with user-visible concepts, such as Quota.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The set of labels that can be used to describe a specific instance of this metric type. For example, the `appengine.googleapis.com/http/server/response_latencies` metric type has a label for the HTTP response code, `response_code`, so you can look at latencies for successful responses or just for responses that failed.</summary>
    [JsonPropertyName("labels")]
    public IList<V1beta1LoggingLogMetricSpecMetricDescriptorLabels>? Labels { get; set; }

    /// <summary>Optional. The launch stage of the metric definition. Possible values: UNIMPLEMENTED, PRELAUNCH, EARLY_ACCESS, ALPHA, BETA, GA, DEPRECATED</summary>
    [JsonPropertyName("launchStage")]
    public string? LaunchStage { get; set; }

    /// <summary>Optional. Metadata which can be used to guide usage of the metric.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LoggingLogMetricSpecMetricDescriptorMetadata? Metadata { get; set; }

    /// <summary>Immutable. Whether the metric records instantaneous values, changes to a value, etc. Some combinations of `metric_kind` and `value_type` might not be supported. Possible values: GAUGE, DELTA, CUMULATIVE</summary>
    [JsonPropertyName("metricKind")]
    public string? MetricKind { get; set; }

    /// <summary>The units in which the metric value is reported. It is only applicable if the `value_type` is `INT64`, `DOUBLE`, or `DISTRIBUTION`. The `unit` defines the representation of the stored metric values. Different systems might scale the values to be more easily displayed (so a value of `0.02kBy` _might_ be displayed as `20By`, and a value of `3523kBy` _might_ be displayed as `3.5MBy`). However, if the `unit` is `kBy`, then the value of the metric is always in thousands of bytes, no matter how it might be displayed. If you want a custom metric to record the exact number of CPU-seconds used by a job, you can create an `INT64 CUMULATIVE` metric whose `unit` is `s{CPU}` (or equivalently `1s{CPU}` or just `s`). If the job uses 12,005 CPU-seconds, then the value is written as `12005`. Alternatively, if you want a custom metric to record data in a more granular way, you can create a `DOUBLE CUMULATIVE` metric whose `unit` is `ks{CPU}`, and then write the value `12.005` (which is `12005/1000`), or use `Kis{CPU}` and write `11.723` (which is `12005/1024`). The supported units are a subset of [The Unified Code for Units of Measure](https://unitsofmeasure.org/ucum.html) standard: **Basic units (UNIT)** * `bit` bit * `By` byte * `s` second * `min` minute * `h` hour * `d` day * `1` dimensionless **Prefixes (PREFIX)** * `k` kilo (10^3) * `M` mega (10^6) * `G` giga (10^9) * `T` tera (10^12) * `P` peta (10^15) * `E` exa (10^18) * `Z` zetta (10^21) * `Y` yotta (10^24) * `m` milli (10^-3) * `u` micro (10^-6) * `n` nano (10^-9) * `p` pico (10^-12) * `f` femto (10^-15) * `a` atto (10^-18) * `z` zepto (10^-21) * `y` yocto (10^-24) * `Ki` kibi (2^10) * `Mi` mebi (2^20) * `Gi` gibi (2^30) * `Ti` tebi (2^40) * `Pi` pebi (2^50) **Grammar** The grammar also includes these connectors: * `/` division or ratio (as an infix operator). For examples, `kBy/{email}` or `MiBy/10ms` (although you should almost never have `/s` in a metric `unit`; rates should always be computed at query time from the underlying cumulative or delta value). * `.` multiplication or composition (as an infix operator). For examples, `GBy.d` or `k{watt}.h`. The grammar for a unit is as follows: Expression = Component: { "." Component } { "/" Component } ; Component = ( [ PREFIX ] UNIT | "%" ) [ Annotation ] | Annotation | "1" ; Annotation = "{" NAME "}" ; Notes: * `Annotation` is just a comment if it follows a `UNIT`. If the annotation is used alone, then the unit is equivalent to `1`. For examples, `{request}/s == 1/s`, `By{transmitted}/s == By/s`. * `NAME` is a sequence of non-blank printable ASCII characters not containing `{` or `}`. * `1` represents a unitary [dimensionless unit](https://en.wikipedia.org/wiki/Dimensionless_quantity) of 1, such as in `1/s`. It is typically used when none of the basic units are appropriate. For example, "new users per day" can be represented as `1/d` or `{new-users}/d` (and a metric value `5` would mean "5 new users). Alternatively, "thousands of page views per day" would be represented as `1000/d` or `k1/d` or `k{page_views}/d` (and a metric value of `5.3` would mean "5300 page views per day"). * `%` represents dimensionless value of 1/100, and annotates values giving a percentage (so the metric values are typically in the range of 0..100, and a metric value `3` means "3 percent"). * `10^2.%` indicates a metric contains a ratio, typically in the range 0..1, that will be multiplied by 100 and displayed as a percentage (so a metric value `0.03` means "3 percent").</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Immutable. Whether the measurement is an integer, a floating-point number, etc. Some combinations of `metric_kind` and `value_type` might not be supported. Possible values: STRING, BOOL, INT64, DOUBLE, DISTRIBUTION, MONEY</summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogMetricSpecProjectRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogMetricSpec
{
    /// <summary>Optional. The `bucket_options` are required when the logs-based metric is using a DISTRIBUTION value type and it describes the bucket boundaries used to create a histogram of the extracted values.</summary>
    [JsonPropertyName("bucketOptions")]
    public V1beta1LoggingLogMetricSpecBucketOptions? BucketOptions { get; set; }

    /// <summary>Optional. A description of this metric, which is used in documentation. The maximum length of the description is 8000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. If set to True, then this metric is disabled and it does not generate any points.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Required. An [advanced logs filter](https://cloud.google.com/logging/docs/view/advanced_filters) which is used to match log entries. Example: "resource.type=gae_app AND severity&gt;=ERROR" The maximum length of the filter is 20000 characters.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>Optional. A map from a label key string to an extractor expression which is used to extract data from a log entry field and assign as the label value. Each label key specified in the LabelDescriptor must have an associated extractor expression in this map. The syntax of the extractor expression is the same as for the `value_extractor` field. The extracted value is converted to the type defined in the label descriptor. If the either the extraction or the type conversion fails, the label will have a default value. The default value for a string label is an empty string, for an integer label its 0, and for a boolean label its `false`. Note that there are upper bounds on the maximum number of labels and the number of active time series that are allowed in a project.</summary>
    [JsonPropertyName("labelExtractors")]
    public IDictionary<string, string>? LabelExtractors { get; set; }

    /// <summary>The reference to the Log Bucket that owns the Log Metric. Only Log Buckets in projects are supported. The bucket has to be in the same project as the metric. For example:projects/my-project/locations/global/buckets/my-bucket If empty, then the Log Metric is considered a non-Bucket Log Metric. Only `external` field is supported to configure the reference for now.</summary>
    [JsonPropertyName("loggingLogBucketRef")]
    public V1beta1LoggingLogMetricSpecLoggingLogBucketRef? LoggingLogBucketRef { get; set; }

    /// <summary>Optional. The metric descriptor associated with the logs-based metric. If unspecified, it uses a default metric descriptor with a DELTA metric kind, INT64 value type, with no labels and a unit of "1". Such a metric counts the number of log entries matching the `filter` expression. The `name`, `type`, and `description` fields in the `metric_descriptor` are output only, and is constructed using the `name` and `description` field in the LogMetric. To create a logs-based metric that records a distribution of log values, a DELTA metric kind with a DISTRIBUTION value type must be used along with a `value_extractor` expression in the LogMetric. Each label in the metric descriptor must have a matching label name as the key and an extractor expression as the value in the `label_extractors` map. The `metric_kind` and `value_type` fields in the `metric_descriptor` cannot be updated once initially configured. New labels can be added in the `metric_descriptor`, but existing labels cannot be modified except for their description.</summary>
    [JsonPropertyName("metricDescriptor")]
    public V1beta1LoggingLogMetricSpecMetricDescriptor? MetricDescriptor { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1LoggingLogMetricSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. A `value_extractor` is required when using a distribution logs-based metric to extract the values to record from a log entry. Two functions are supported for value extraction: `EXTRACT(field)` or `REGEXP_EXTRACT(field, regex)`. The argument are: 1. field: The name of the log entry field from which the value is to be extracted. 2. regex: A regular expression using the Google RE2 syntax (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from the specified log entry field. The value of the field is converted to a string before applying the regex. It is an error to specify a regex that does not include exactly one capture group. The result of the extraction must be convertible to a double type, as the distribution always records double values. If either the extraction or the conversion to double fails, then those values are not recorded in the distribution. Example: `REGEXP_EXTRACT(jsonPayload.request, ".*quantity=(d+).*")`</summary>
    [JsonPropertyName("valueExtractor")]
    public string? ValueExtractor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogMetricStatusConditions
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
public partial class V1beta1LoggingLogMetricStatusMetricDescriptor
{
    /// <summary>A detailed description of the metric, which can be used in documentation.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Read-only. If present, then a time series, which is identified partially by a metric type and a MonitoredResourceDescriptor, that is associated with this metric type can only be associated with one of the monitored resource types listed here.</summary>
    [JsonPropertyName("monitoredResourceTypes")]
    public IList<string>? MonitoredResourceTypes { get; set; }

    /// <summary>The resource name of the metric descriptor.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The metric type, including its DNS name prefix. The type is not URL-encoded. All user-defined metric types have the DNS name `custom.googleapis.com` or `external.googleapis.com`. Metric types should use a natural hierarchical grouping. For example: "custom.googleapis.com/invoice/paid/amount" "external.googleapis.com/prometheus/up" "appengine.googleapis.com/http/server/response_latencies"</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoggingLogMetricStatus
{
    /// <summary>Conditions represent the latest available observations of the LoggingLogMetric's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LoggingLogMetricStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The creation timestamp of the metric. This field may not be present for older metrics.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricDescriptor")]
    public V1beta1LoggingLogMetricStatusMetricDescriptor? MetricDescriptor { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The last update timestamp of the metric. This field may not be present for older metrics.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>LoggingLogMetric is the Schema for the logging API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LoggingLogMetric : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LoggingLogMetricSpec>, IStatus<V1beta1LoggingLogMetricStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LoggingLogMetric";
    public const string KubeGroup = "logging.cnrm.cloud.google.com";
    public const string KubePluralName = "logginglogmetrics";
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
    public V1beta1LoggingLogMetricSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1LoggingLogMetricStatus? Status { get; set; }
}

/// <summary>LoggingLogMetric is the Schema for the logging API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LoggingLogMetricList : IKubernetesObject<V1ListMeta>, IItems<V1beta1LoggingLogMetric>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LoggingLogMetricList";
    public const string KubeGroup = "logging.cnrm.cloud.google.com";
    public const string KubePluralName = "logginglogmetrics";
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
    public IList<V1beta1LoggingLogMetric> Items { get; set; }
}