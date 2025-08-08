using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.logging.gcp.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecForProviderBucketNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ProjectBucketConfig in logging to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecForProviderBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetricSpecForProviderBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecForProviderBucketNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ProjectBucketConfig in logging to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecForProviderBucketNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetricSpecForProviderBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecForProviderBucketOptionsExplicitBuckets
{
    /// <summary>The values must be monotonically increasing.</summary>
    [JsonPropertyName("bounds")]
    public IList<double>? Bounds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecForProviderBucketOptionsExponentialBuckets
{
    /// <summary>Must be greater than 1.</summary>
    [JsonPropertyName("growthFactor")]
    public double? GrowthFactor { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("numFiniteBuckets")]
    public double? NumFiniteBuckets { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecForProviderBucketOptionsLinearBuckets
{
    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("numFiniteBuckets")]
    public double? NumFiniteBuckets { get; set; }

    /// <summary>Lower bound of the first bucket.</summary>
    [JsonPropertyName("offset")]
    public double? Offset { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecForProviderBucketOptions
{
    /// <summary>Specifies a set of buckets with arbitrary widths. Structure is documented below.</summary>
    [JsonPropertyName("explicitBuckets")]
    public IList<V1beta1MetricSpecForProviderBucketOptionsExplicitBuckets>? ExplicitBuckets { get; set; }

    /// <summary>Specifies an exponential sequence of buckets that have a width that is proportional to the value of the lower bound. Each bucket represents a constant relative uncertainty on a specific value in the bucket. Structure is documented below.</summary>
    [JsonPropertyName("exponentialBuckets")]
    public IList<V1beta1MetricSpecForProviderBucketOptionsExponentialBuckets>? ExponentialBuckets { get; set; }

    /// <summary>Specifies a linear sequence of buckets that all have the same width (except overflow and underflow). Each bucket represents a constant absolute uncertainty on the specific value in the bucket. Structure is documented below.</summary>
    [JsonPropertyName("linearBuckets")]
    public IList<V1beta1MetricSpecForProviderBucketOptionsLinearBuckets>? LinearBuckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecForProviderMetricDescriptorLabels
{
    /// <summary>A human-readable description for the label.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The label key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Whether the measurement is an integer, a floating-point number, etc. Some combinations of metricKind and valueType might not be supported. For counter metrics, set this to INT64. Possible values are: BOOL, INT64, DOUBLE, STRING, DISTRIBUTION, MONEY.</summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecForProviderMetricDescriptor
{
    /// <summary>A concise name for the metric, which can be displayed in user interfaces. Use sentence case without an ending period, for example "Request count". This field is optional but it is recommended to be set for any metrics associated with user-visible concepts, such as Quota.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The set of labels that can be used to describe a specific instance of this metric type. For example, the appengine.googleapis.com/http/server/response_latencies metric type has a label for the HTTP response code, response_code, so you can look at latencies for successful responses or just for responses that failed. Structure is documented below.</summary>
    [JsonPropertyName("labels")]
    public IList<V1beta1MetricSpecForProviderMetricDescriptorLabels>? Labels { get; set; }

    /// <summary>Whether the metric records instantaneous values, changes to a value, etc. Some combinations of metricKind and valueType might not be supported. For counter metrics, set this to DELTA. Possible values are: DELTA, GAUGE, CUMULATIVE.</summary>
    [JsonPropertyName("metricKind")]
    public string? MetricKind { get; set; }

    /// <summary>The unit in which the metric value is reported. It is only applicable if the valueType is INT64, DOUBLE, or DISTRIBUTION. The supported units are a subset of The Unified Code for Units of Measure standard</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Whether the measurement is an integer, a floating-point number, etc. Some combinations of metricKind and valueType might not be supported. For counter metrics, set this to INT64. Possible values are: BOOL, INT64, DOUBLE, STRING, DISTRIBUTION, MONEY.</summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecForProvider
{
    /// <summary>The resource name of the Log Bucket that owns the Log Metric. Only Log Buckets in projects are supported. The bucket has to be in the same project as the metric.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a ProjectBucketConfig in logging to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1MetricSpecForProviderBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a ProjectBucketConfig in logging to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1MetricSpecForProviderBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>The bucketOptions are required when the logs-based metric is using a DISTRIBUTION value type and it describes the bucket boundaries used to create a histogram of the extracted values. Structure is documented below.</summary>
    [JsonPropertyName("bucketOptions")]
    public IList<V1beta1MetricSpecForProviderBucketOptions>? BucketOptions { get; set; }

    /// <summary>A description of this metric, which is used in documentation. The maximum length of the description is 8000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set to True, then this metric is disabled and it does not generate any points.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-filters) which is used to match log entries.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>A map from a label key string to an extractor expression which is used to extract data from a log entry field and assign as the label value. Each label key specified in the LabelDescriptor must have an associated extractor expression in this map. The syntax of the extractor expression is the same as for the valueExtractor field.</summary>
    [JsonPropertyName("labelExtractors")]
    public IDictionary<string, string>? LabelExtractors { get; set; }

    /// <summary>The optional metric descriptor associated with the logs-based metric. If unspecified, it uses a default metric descriptor with a DELTA metric kind, INT64 value type, with no labels and a unit of "1". Such a metric counts the number of log entries matching the filter expression. Structure is documented below.</summary>
    [JsonPropertyName("metricDescriptor")]
    public IList<V1beta1MetricSpecForProviderMetricDescriptor>? MetricDescriptor { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A valueExtractor is required when using a distribution logs-based metric to extract the values to record from a log entry. Two functions are supported for value extraction - EXTRACT(field) or REGEXP_EXTRACT(field, regex). The argument are 1. field - The name of the log entry field from which the value is to be extracted. 2. regex - A regular expression using the Google RE2 syntax (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from the specified log entry field. The value of the field is converted to a string before applying the regex. It is an error to specify a regex that does not include exactly one capture group.</summary>
    [JsonPropertyName("valueExtractor")]
    public string? ValueExtractor { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecInitProviderBucketNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ProjectBucketConfig in logging to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecInitProviderBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetricSpecInitProviderBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecInitProviderBucketNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ProjectBucketConfig in logging to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecInitProviderBucketNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetricSpecInitProviderBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecInitProviderBucketOptionsExplicitBuckets
{
    /// <summary>The values must be monotonically increasing.</summary>
    [JsonPropertyName("bounds")]
    public IList<double>? Bounds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecInitProviderBucketOptionsExponentialBuckets
{
    /// <summary>Must be greater than 1.</summary>
    [JsonPropertyName("growthFactor")]
    public double? GrowthFactor { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("numFiniteBuckets")]
    public double? NumFiniteBuckets { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecInitProviderBucketOptionsLinearBuckets
{
    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("numFiniteBuckets")]
    public double? NumFiniteBuckets { get; set; }

    /// <summary>Lower bound of the first bucket.</summary>
    [JsonPropertyName("offset")]
    public double? Offset { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecInitProviderBucketOptions
{
    /// <summary>Specifies a set of buckets with arbitrary widths. Structure is documented below.</summary>
    [JsonPropertyName("explicitBuckets")]
    public IList<V1beta1MetricSpecInitProviderBucketOptionsExplicitBuckets>? ExplicitBuckets { get; set; }

    /// <summary>Specifies an exponential sequence of buckets that have a width that is proportional to the value of the lower bound. Each bucket represents a constant relative uncertainty on a specific value in the bucket. Structure is documented below.</summary>
    [JsonPropertyName("exponentialBuckets")]
    public IList<V1beta1MetricSpecInitProviderBucketOptionsExponentialBuckets>? ExponentialBuckets { get; set; }

    /// <summary>Specifies a linear sequence of buckets that all have the same width (except overflow and underflow). Each bucket represents a constant absolute uncertainty on the specific value in the bucket. Structure is documented below.</summary>
    [JsonPropertyName("linearBuckets")]
    public IList<V1beta1MetricSpecInitProviderBucketOptionsLinearBuckets>? LinearBuckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecInitProviderMetricDescriptorLabels
{
    /// <summary>A human-readable description for the label.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The label key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Whether the measurement is an integer, a floating-point number, etc. Some combinations of metricKind and valueType might not be supported. For counter metrics, set this to INT64. Possible values are: BOOL, INT64, DOUBLE, STRING, DISTRIBUTION, MONEY.</summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecInitProviderMetricDescriptor
{
    /// <summary>A concise name for the metric, which can be displayed in user interfaces. Use sentence case without an ending period, for example "Request count". This field is optional but it is recommended to be set for any metrics associated with user-visible concepts, such as Quota.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The set of labels that can be used to describe a specific instance of this metric type. For example, the appengine.googleapis.com/http/server/response_latencies metric type has a label for the HTTP response code, response_code, so you can look at latencies for successful responses or just for responses that failed. Structure is documented below.</summary>
    [JsonPropertyName("labels")]
    public IList<V1beta1MetricSpecInitProviderMetricDescriptorLabels>? Labels { get; set; }

    /// <summary>Whether the metric records instantaneous values, changes to a value, etc. Some combinations of metricKind and valueType might not be supported. For counter metrics, set this to DELTA. Possible values are: DELTA, GAUGE, CUMULATIVE.</summary>
    [JsonPropertyName("metricKind")]
    public string? MetricKind { get; set; }

    /// <summary>The unit in which the metric value is reported. It is only applicable if the valueType is INT64, DOUBLE, or DISTRIBUTION. The supported units are a subset of The Unified Code for Units of Measure standard</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Whether the measurement is an integer, a floating-point number, etc. Some combinations of metricKind and valueType might not be supported. For counter metrics, set this to INT64. Possible values are: BOOL, INT64, DOUBLE, STRING, DISTRIBUTION, MONEY.</summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecInitProvider
{
    /// <summary>The resource name of the Log Bucket that owns the Log Metric. Only Log Buckets in projects are supported. The bucket has to be in the same project as the metric.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a ProjectBucketConfig in logging to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1MetricSpecInitProviderBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a ProjectBucketConfig in logging to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1MetricSpecInitProviderBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>The bucketOptions are required when the logs-based metric is using a DISTRIBUTION value type and it describes the bucket boundaries used to create a histogram of the extracted values. Structure is documented below.</summary>
    [JsonPropertyName("bucketOptions")]
    public IList<V1beta1MetricSpecInitProviderBucketOptions>? BucketOptions { get; set; }

    /// <summary>A description of this metric, which is used in documentation. The maximum length of the description is 8000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set to True, then this metric is disabled and it does not generate any points.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-filters) which is used to match log entries.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>A map from a label key string to an extractor expression which is used to extract data from a log entry field and assign as the label value. Each label key specified in the LabelDescriptor must have an associated extractor expression in this map. The syntax of the extractor expression is the same as for the valueExtractor field.</summary>
    [JsonPropertyName("labelExtractors")]
    public IDictionary<string, string>? LabelExtractors { get; set; }

    /// <summary>The optional metric descriptor associated with the logs-based metric. If unspecified, it uses a default metric descriptor with a DELTA metric kind, INT64 value type, with no labels and a unit of "1". Such a metric counts the number of log entries matching the filter expression. Structure is documented below.</summary>
    [JsonPropertyName("metricDescriptor")]
    public IList<V1beta1MetricSpecInitProviderMetricDescriptor>? MetricDescriptor { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A valueExtractor is required when using a distribution logs-based metric to extract the values to record from a log entry. Two functions are supported for value extraction - EXTRACT(field) or REGEXP_EXTRACT(field, regex). The argument are 1. field - The name of the log entry field from which the value is to be extracted. 2. regex - A regular expression using the Google RE2 syntax (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from the specified log entry field. The value of the field is converted to a string before applying the regex. It is an error to specify a regex that does not include exactly one capture group.</summary>
    [JsonPropertyName("valueExtractor")]
    public string? ValueExtractor { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecProviderConfigRefPolicy
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
public partial class V1beta1MetricSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetricSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MetricSpec defines the desired state of Metric</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MetricSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MetricSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MetricSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MetricSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricStatusAtProviderBucketOptionsExplicitBuckets
{
    /// <summary>The values must be monotonically increasing.</summary>
    [JsonPropertyName("bounds")]
    public IList<double>? Bounds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricStatusAtProviderBucketOptionsExponentialBuckets
{
    /// <summary>Must be greater than 1.</summary>
    [JsonPropertyName("growthFactor")]
    public double? GrowthFactor { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("numFiniteBuckets")]
    public double? NumFiniteBuckets { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricStatusAtProviderBucketOptionsLinearBuckets
{
    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("numFiniteBuckets")]
    public double? NumFiniteBuckets { get; set; }

    /// <summary>Lower bound of the first bucket.</summary>
    [JsonPropertyName("offset")]
    public double? Offset { get; set; }

    /// <summary>Must be greater than 0.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricStatusAtProviderBucketOptions
{
    /// <summary>Specifies a set of buckets with arbitrary widths. Structure is documented below.</summary>
    [JsonPropertyName("explicitBuckets")]
    public IList<V1beta1MetricStatusAtProviderBucketOptionsExplicitBuckets>? ExplicitBuckets { get; set; }

    /// <summary>Specifies an exponential sequence of buckets that have a width that is proportional to the value of the lower bound. Each bucket represents a constant relative uncertainty on a specific value in the bucket. Structure is documented below.</summary>
    [JsonPropertyName("exponentialBuckets")]
    public IList<V1beta1MetricStatusAtProviderBucketOptionsExponentialBuckets>? ExponentialBuckets { get; set; }

    /// <summary>Specifies a linear sequence of buckets that all have the same width (except overflow and underflow). Each bucket represents a constant absolute uncertainty on the specific value in the bucket. Structure is documented below.</summary>
    [JsonPropertyName("linearBuckets")]
    public IList<V1beta1MetricStatusAtProviderBucketOptionsLinearBuckets>? LinearBuckets { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricStatusAtProviderMetricDescriptorLabels
{
    /// <summary>A human-readable description for the label.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The label key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Whether the measurement is an integer, a floating-point number, etc. Some combinations of metricKind and valueType might not be supported. For counter metrics, set this to INT64. Possible values are: BOOL, INT64, DOUBLE, STRING, DISTRIBUTION, MONEY.</summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricStatusAtProviderMetricDescriptor
{
    /// <summary>A concise name for the metric, which can be displayed in user interfaces. Use sentence case without an ending period, for example "Request count". This field is optional but it is recommended to be set for any metrics associated with user-visible concepts, such as Quota.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The set of labels that can be used to describe a specific instance of this metric type. For example, the appengine.googleapis.com/http/server/response_latencies metric type has a label for the HTTP response code, response_code, so you can look at latencies for successful responses or just for responses that failed. Structure is documented below.</summary>
    [JsonPropertyName("labels")]
    public IList<V1beta1MetricStatusAtProviderMetricDescriptorLabels>? Labels { get; set; }

    /// <summary>Whether the metric records instantaneous values, changes to a value, etc. Some combinations of metricKind and valueType might not be supported. For counter metrics, set this to DELTA. Possible values are: DELTA, GAUGE, CUMULATIVE.</summary>
    [JsonPropertyName("metricKind")]
    public string? MetricKind { get; set; }

    /// <summary>The unit in which the metric value is reported. It is only applicable if the valueType is INT64, DOUBLE, or DISTRIBUTION. The supported units are a subset of The Unified Code for Units of Measure standard</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Whether the measurement is an integer, a floating-point number, etc. Some combinations of metricKind and valueType might not be supported. For counter metrics, set this to INT64. Possible values are: BOOL, INT64, DOUBLE, STRING, DISTRIBUTION, MONEY.</summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricStatusAtProvider
{
    /// <summary>The resource name of the Log Bucket that owns the Log Metric. Only Log Buckets in projects are supported. The bucket has to be in the same project as the metric.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The bucketOptions are required when the logs-based metric is using a DISTRIBUTION value type and it describes the bucket boundaries used to create a histogram of the extracted values. Structure is documented below.</summary>
    [JsonPropertyName("bucketOptions")]
    public IList<V1beta1MetricStatusAtProviderBucketOptions>? BucketOptions { get; set; }

    /// <summary>A description of this metric, which is used in documentation. The maximum length of the description is 8000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set to True, then this metric is disabled and it does not generate any points.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-filters) which is used to match log entries.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A map from a label key string to an extractor expression which is used to extract data from a log entry field and assign as the label value. Each label key specified in the LabelDescriptor must have an associated extractor expression in this map. The syntax of the extractor expression is the same as for the valueExtractor field.</summary>
    [JsonPropertyName("labelExtractors")]
    public IDictionary<string, string>? LabelExtractors { get; set; }

    /// <summary>The optional metric descriptor associated with the logs-based metric. If unspecified, it uses a default metric descriptor with a DELTA metric kind, INT64 value type, with no labels and a unit of "1". Such a metric counts the number of log entries matching the filter expression. Structure is documented below.</summary>
    [JsonPropertyName("metricDescriptor")]
    public IList<V1beta1MetricStatusAtProviderMetricDescriptor>? MetricDescriptor { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>A valueExtractor is required when using a distribution logs-based metric to extract the values to record from a log entry. Two functions are supported for value extraction - EXTRACT(field) or REGEXP_EXTRACT(field, regex). The argument are 1. field - The name of the log entry field from which the value is to be extracted. 2. regex - A regular expression using the Google RE2 syntax (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from the specified log entry field. The value of the field is converted to a string before applying the regex. It is an error to specify a regex that does not include exactly one capture group.</summary>
    [JsonPropertyName("valueExtractor")]
    public string? ValueExtractor { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricStatusConditions
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

/// <summary>MetricStatus defines the observed state of Metric.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MetricStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MetricStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Metric is the Schema for the Metrics API. Logs-based metric can also be used to extract values from logs and create a a distribution of the values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Metric : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MetricSpec>, IStatus<V1beta1MetricStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Metric";
    public const string KubeGroup = "logging.gcp.upbound.io";
    public const string KubePluralName = "metrics";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MetricSpec defines the desired state of Metric</summary>
    [JsonPropertyName("spec")]
    public V1beta1MetricSpec Spec { get; set; }

    /// <summary>MetricStatus defines the observed state of Metric.</summary>
    [JsonPropertyName("status")]
    public V1beta1MetricStatus? Status { get; set; }
}

/// <summary>Metric is the Schema for the Metrics API. Logs-based metric can also be used to extract values from logs and create a a distribution of the values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MetricList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Metric>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MetricList";
    public const string KubeGroup = "logging.gcp.upbound.io";
    public const string KubePluralName = "metrics";
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
    public IList<V1beta1Metric> Items { get; set; }
}