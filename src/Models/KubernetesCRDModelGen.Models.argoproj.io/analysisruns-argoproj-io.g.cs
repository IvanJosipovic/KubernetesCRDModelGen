using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.argoproj.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecArgsValueFromFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecArgsValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecArgsValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1AnalysisRunSpecArgsValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1AnalysisRunSpecArgsValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecArgs
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1AnalysisRunSpecArgsValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecDryRun
{
    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string MetricName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMeasurementRetention
{
    /// <summary></summary>
    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string MetricName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetric
{
    /// <summary></summary>
    [JsonPropertyName("dimensions")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderCloudWatchMetricDataQueriesMetricStat
{
    /// <summary></summary>
    [JsonPropertyName("metric")]
    public V1alpha1AnalysisRunSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary></summary>
    [JsonPropertyName("period")]
    public IntstrIntOrString? Period { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderCloudWatchMetricDataQueries
{
    /// <summary></summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricStat")]
    public V1alpha1AnalysisRunSpecMetricsProviderCloudWatchMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("period")]
    public IntstrIntOrString? Period { get; set; }

    /// <summary></summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderCloudWatch
{
    /// <summary></summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderCloudWatchMetricDataQueries> MetricDataQueries { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1alpha1AnalysisRunSpecMetricsProviderDatadogAggregatorEnum
{
    [EnumMember(Value = "avg"), JsonStringEnumMemberName("avg")]
    /// <summary>avg</summary>
    Avg,
    [EnumMember(Value = "min"), JsonStringEnumMemberName("min")]
    /// <summary>min</summary>
    Min,
    [EnumMember(Value = "max"), JsonStringEnumMemberName("max")]
    /// <summary>max</summary>
    Max,
    [EnumMember(Value = "sum"), JsonStringEnumMemberName("sum")]
    /// <summary>sum</summary>
    Sum,
    [EnumMember(Value = "last"), JsonStringEnumMemberName("last")]
    /// <summary>last</summary>
    Last,
    [EnumMember(Value = "percentile"), JsonStringEnumMemberName("percentile")]
    /// <summary>percentile</summary>
    Percentile,
    [EnumMember(Value = "mean"), JsonStringEnumMemberName("mean")]
    /// <summary>mean</summary>
    Mean,
    [EnumMember(Value = "l2norm"), JsonStringEnumMemberName("l2norm")]
    /// <summary>l2norm</summary>
    L2norm,
    [EnumMember(Value = "area"), JsonStringEnumMemberName("area")]
    /// <summary>area</summary>
    Area
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1alpha1AnalysisRunSpecMetricsProviderDatadogApiVersionEnum
{
    [EnumMember(Value = "v1"), JsonStringEnumMemberName("v1")]
    /// <summary>v1</summary>
    V1,
    [EnumMember(Value = "v2"), JsonStringEnumMemberName("v2")]
    /// <summary>v2</summary>
    V2
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderDatadog
{
    /// <summary></summary>
    [JsonPropertyName("aggregator")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AnalysisRunSpecMetricsProviderDatadogAggregatorEnum>))]
    public V1alpha1AnalysisRunSpecMetricsProviderDatadogAggregatorEnum? Aggregator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AnalysisRunSpecMetricsProviderDatadogApiVersionEnum>))]
    public V1alpha1AnalysisRunSpecMetricsProviderDatadogApiVersionEnum? ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("formula")]
    public string? Formula { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queries")]
    public IDictionary<string, string>? Queries { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderGraphite
{
    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderInfluxdb
{
    /// <summary></summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecPodFailurePolicyRulesOnExitCodes
{
    /// <summary></summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<int> Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecPodFailurePolicyRulesOnPodConditions
{
    /// <summary></summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecPodFailurePolicyRules
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("onExitCodes")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecPodFailurePolicyRulesOnExitCodes? OnExitCodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("onPodConditions")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecPodFailurePolicyRulesOnPodConditions>? OnPodConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecPodFailurePolicy
{
    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecPodFailurePolicyRules> Rules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchFields")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("preference")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchFields")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinity
{
    /// <summary></summary>
    [JsonPropertyName("nodeAffinity")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podAffinity")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromResourceFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("divisor")]
    public IntstrIntOrString? Divisor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromConfigMapRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStart
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStop
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecycle
{
    /// <summary></summary>
    [JsonPropertyName("postStart")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preStop")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStop? PreStop { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersPorts
{
    /// <summary></summary>
    [JsonPropertyName("containerPort")]
    public int ContainerPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostIP")]
    public string? HostIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostPort")]
    public int? HostPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersResizePolicy
{
    /// <summary></summary>
    [JsonPropertyName("resourceName")]
    public string ResourceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string RestartPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersResourcesClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersResources
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextCapabilities
{
    /// <summary></summary>
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    /// <summary></summary>
    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeLinuxOptions
{
    /// <summary></summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary></summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeccompProfile
{
    /// <summary></summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextWindowsOptions
{
    /// <summary></summary>
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextCapabilities? Capabilities { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    /// <summary></summary>
    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsGroup")]
    public long? RunAsGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsUser")]
    public long? RunAsUser { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seLinuxOptions")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersVolumeDevices
{
    /// <summary></summary>
    [JsonPropertyName("devicePath")]
    public string DevicePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersVolumeMounts
{
    /// <summary></summary>
    [JsonPropertyName("mountPath")]
    public string MountPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainers
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envFrom")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLifecycle? Lifecycle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessProbe")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stdin")]
    public bool? Stdin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stdinOnce")]
    public bool? StdinOnce { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationMessagePath")]
    public string? TerminationMessagePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationMessagePolicy")]
    public string? TerminationMessagePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tty")]
    public bool? Tty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeDevices")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecDnsConfigOptions
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecDnsConfig
{
    /// <summary></summary>
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("options")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecDnsConfigOptions>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("divisor")]
    public IntstrIntOrString? Divisor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStart
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStop
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecycle
{
    /// <summary></summary>
    [JsonPropertyName("postStart")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preStop")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStop? PreStop { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersPorts
{
    /// <summary></summary>
    [JsonPropertyName("containerPort")]
    public int ContainerPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostIP")]
    public string? HostIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostPort")]
    public int? HostPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResizePolicy
{
    /// <summary></summary>
    [JsonPropertyName("resourceName")]
    public string ResourceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string RestartPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResourcesClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResources
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResourcesClaims>? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextCapabilities
{
    /// <summary></summary>
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    /// <summary></summary>
    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions
{
    /// <summary></summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary></summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile
{
    /// <summary></summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions
{
    /// <summary></summary>
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextCapabilities? Capabilities { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    /// <summary></summary>
    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsGroup")]
    public long? RunAsGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsUser")]
    public long? RunAsUser { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seLinuxOptions")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeDevices
{
    /// <summary></summary>
    [JsonPropertyName("devicePath")]
    public string DevicePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeMounts
{
    /// <summary></summary>
    [JsonPropertyName("mountPath")]
    public string MountPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainers
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envFrom")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecycle? Lifecycle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessProbe")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbe? StartupProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stdin")]
    public bool? Stdin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stdinOnce")]
    public bool? StdinOnce { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetContainerName")]
    public string? TargetContainerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationMessagePath")]
    public string? TerminationMessagePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationMessagePolicy")]
    public string? TerminationMessagePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tty")]
    public bool? Tty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeDevices")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecHostAliases
{
    /// <summary></summary>
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecImagePullSecrets
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("divisor")]
    public IntstrIntOrString? Divisor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromConfigMapRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStart
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStop
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecycle
{
    /// <summary></summary>
    [JsonPropertyName("postStart")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preStop")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStop? PreStop { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersPorts
{
    /// <summary></summary>
    [JsonPropertyName("containerPort")]
    public int ContainerPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostIP")]
    public string? HostIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostPort")]
    public int? HostPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersResizePolicy
{
    /// <summary></summary>
    [JsonPropertyName("resourceName")]
    public string ResourceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string RestartPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersResourcesClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersResources
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersResourcesClaims>? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextCapabilities
{
    /// <summary></summary>
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    /// <summary></summary>
    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions
{
    /// <summary></summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary></summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeccompProfile
{
    /// <summary></summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextWindowsOptions
{
    /// <summary></summary>
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextCapabilities? Capabilities { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    /// <summary></summary>
    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsGroup")]
    public long? RunAsGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsUser")]
    public long? RunAsUser { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seLinuxOptions")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeDevices
{
    /// <summary></summary>
    [JsonPropertyName("devicePath")]
    public string DevicePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeMounts
{
    /// <summary></summary>
    [JsonPropertyName("mountPath")]
    public string MountPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainers
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envFrom")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecycle? Lifecycle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessProbe")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbe? StartupProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stdin")]
    public bool? Stdin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stdinOnce")]
    public bool? StdinOnce { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationMessagePath")]
    public string? TerminationMessagePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationMessagePolicy")]
    public string? TerminationMessagePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tty")]
    public bool? Tty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeDevices")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecOs
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecReadinessGates
{
    /// <summary></summary>
    [JsonPropertyName("conditionType")]
    public string ConditionType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecResourceClaimsSource
{
    /// <summary></summary>
    [JsonPropertyName("resourceClaimName")]
    public string? ResourceClaimName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceClaimTemplateName")]
    public string? ResourceClaimTemplateName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecResourceClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecResourceClaimsSource? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecSchedulingGates
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeLinuxOptions
{
    /// <summary></summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary></summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeccompProfile
{
    /// <summary></summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecSecurityContextSysctls
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecSecurityContextWindowsOptions
{
    /// <summary></summary>
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("fsGroup")]
    public long? FsGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fsGroupChangePolicy")]
    public string? FsGroupChangePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsGroup")]
    public long? RunAsGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runAsUser")]
    public long? RunAsUser { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seLinuxOptions")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supplementalGroups")]
    public IList<long>? SupplementalGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sysctls")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecSecurityContextSysctls>? Sysctls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecTolerations
{
    /// <summary></summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tolerationSeconds")]
    public long? TolerationSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraints
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxSkew")]
    public int MaxSkew { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minDomains")]
    public int? MinDomains { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeAffinityPolicy")]
    public string? NodeAffinityPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeTaintsPolicy")]
    public string? NodeTaintsPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whenUnsatisfiable")]
    public string WhenUnsatisfiable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("activeDeadlineSeconds")]
    public long? ActiveDeadlineSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("affinity")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecAffinity? Affinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("automountServiceAccountToken")]
    public bool? AutomountServiceAccountToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containers")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecContainers> Containers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsConfig")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecDnsConfig? DnsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsPolicy")]
    public string? DnsPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ephemeralContainers")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecEphemeralContainers>? EphemeralContainers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecHostAliases>? HostAliases { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostIPC")]
    public bool? HostIPC { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostNetwork")]
    public bool? HostNetwork { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostPID")]
    public bool? HostPID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostUsers")]
    public bool? HostUsers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initContainers")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecInitContainers>? InitContainers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeName")]
    public string? NodeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("os")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecOs? Os { get; set; }

    /// <summary></summary>
    [JsonPropertyName("overhead")]
    public IDictionary<string, IntstrIntOrString>? Overhead { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preemptionPolicy")]
    public string? PreemptionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessGates")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecReadinessGates>? ReadinessGates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceClaims")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecResourceClaims>? ResourceClaims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeClassName")]
    public string? RuntimeClassName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("schedulingGates")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecSchedulingGates>? SchedulingGates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("setHostnameAsFQDN")]
    public bool? SetHostnameAsFQDN { get; set; }

    /// <summary></summary>
    [JsonPropertyName("shareProcessNamespace")]
    public bool? ShareProcessNamespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subdomain")]
    public string? Subdomain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tolerations")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecTolerations>? Tolerations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public JsonNode? Volumes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplateSpec? Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJobSpec
{
    /// <summary></summary>
    [JsonPropertyName("activeDeadlineSeconds")]
    public long? ActiveDeadlineSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backoffLimit")]
    public int? BackoffLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backoffLimitPerIndex")]
    public int? BackoffLimitPerIndex { get; set; }

    /// <summary></summary>
    [JsonPropertyName("completionMode")]
    public string? CompletionMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("completions")]
    public int? Completions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("manualSelector")]
    public bool? ManualSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxFailedIndexes")]
    public int? MaxFailedIndexes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parallelism")]
    public int? Parallelism { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podFailurePolicy")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecPodFailurePolicy? PodFailurePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podReplacementPolicy")]
    public string? PodReplacementPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecSelector? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpecTemplate Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ttlSecondsAfterFinished")]
    public int? TtlSecondsAfterFinished { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderJob
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1AnalysisRunSpecMetricsProviderJobSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderKayentaScopesControlScope
{
    /// <summary></summary>
    [JsonPropertyName("end")]
    public string End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scope")]
    public string Scope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string Start { get; set; }

    /// <summary></summary>
    [JsonPropertyName("step")]
    public long Step { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderKayentaScopesExperimentScope
{
    /// <summary></summary>
    [JsonPropertyName("end")]
    public string End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scope")]
    public string Scope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string Start { get; set; }

    /// <summary></summary>
    [JsonPropertyName("step")]
    public long Step { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderKayentaScopes
{
    /// <summary></summary>
    [JsonPropertyName("controlScope")]
    public V1alpha1AnalysisRunSpecMetricsProviderKayentaScopesControlScope ControlScope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("experimentScope")]
    public V1alpha1AnalysisRunSpecMetricsProviderKayentaScopesExperimentScope ExperimentScope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderKayentaThreshold
{
    /// <summary></summary>
    [JsonPropertyName("marginal")]
    public long Marginal { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pass")]
    public long Pass { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderKayenta
{
    /// <summary></summary>
    [JsonPropertyName("address")]
    public string Address { get; set; }

    /// <summary></summary>
    [JsonPropertyName("application")]
    public string Application { get; set; }

    /// <summary></summary>
    [JsonPropertyName("canaryConfigName")]
    public string CanaryConfigName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configurationAccountName")]
    public string ConfigurationAccountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricsAccountName")]
    public string MetricsAccountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderKayentaScopes> Scopes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountName")]
    public string StorageAccountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("threshold")]
    public V1alpha1AnalysisRunSpecMetricsProviderKayentaThreshold Threshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderNewRelic
{
    /// <summary></summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string Query { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderPrometheusAuthenticationOauth2
{
    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenUrl")]
    public string? TokenUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderPrometheusAuthenticationSigv4
{
    /// <summary></summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderPrometheusAuthentication
{
    /// <summary></summary>
    [JsonPropertyName("oauth2")]
    public V1alpha1AnalysisRunSpecMetricsProviderPrometheusAuthenticationOauth2? Oauth2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sigv4")]
    public V1alpha1AnalysisRunSpecMetricsProviderPrometheusAuthenticationSigv4? Sigv4 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderPrometheusHeaders
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderPrometheus
{
    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authentication")]
    public V1alpha1AnalysisRunSpecMetricsProviderPrometheusAuthentication? Authentication { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderPrometheusHeaders>? Headers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeout")]
    public long? Timeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderSkywalking
{
    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderWavefront
{
    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderWebAuthenticationOauth2
{
    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenUrl")]
    public string? TokenUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderWebAuthenticationSigv4
{
    /// <summary></summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderWebAuthentication
{
    /// <summary></summary>
    [JsonPropertyName("oauth2")]
    public V1alpha1AnalysisRunSpecMetricsProviderWebAuthenticationOauth2? Oauth2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sigv4")]
    public V1alpha1AnalysisRunSpecMetricsProviderWebAuthenticationSigv4? Sigv4 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderWebHeaders
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProviderWeb
{
    /// <summary></summary>
    [JsonPropertyName("authentication")]
    public V1alpha1AnalysisRunSpecMetricsProviderWebAuthentication? Authentication { get; set; }

    /// <summary></summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1AnalysisRunSpecMetricsProviderWebHeaders>? Headers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonBody")]
    public JsonNode? JsonBody { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public long? TimeoutSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetricsProvider
{
    /// <summary></summary>
    [JsonPropertyName("cloudWatch")]
    public V1alpha1AnalysisRunSpecMetricsProviderCloudWatch? CloudWatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datadog")]
    public V1alpha1AnalysisRunSpecMetricsProviderDatadog? Datadog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("graphite")]
    public V1alpha1AnalysisRunSpecMetricsProviderGraphite? Graphite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("influxdb")]
    public V1alpha1AnalysisRunSpecMetricsProviderInfluxdb? Influxdb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("job")]
    public V1alpha1AnalysisRunSpecMetricsProviderJob? Job { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kayenta")]
    public V1alpha1AnalysisRunSpecMetricsProviderKayenta? Kayenta { get; set; }

    /// <summary></summary>
    [JsonPropertyName("newRelic")]
    public V1alpha1AnalysisRunSpecMetricsProviderNewRelic? NewRelic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public JsonNode? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prometheus")]
    public V1alpha1AnalysisRunSpecMetricsProviderPrometheus? Prometheus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skywalking")]
    public V1alpha1AnalysisRunSpecMetricsProviderSkywalking? Skywalking { get; set; }

    /// <summary></summary>
    [JsonPropertyName("wavefront")]
    public V1alpha1AnalysisRunSpecMetricsProviderWavefront? Wavefront { get; set; }

    /// <summary></summary>
    [JsonPropertyName("web")]
    public V1alpha1AnalysisRunSpecMetricsProviderWeb? Web { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecMetrics
{
    /// <summary></summary>
    [JsonPropertyName("consecutiveErrorLimit")]
    public IntstrIntOrString? ConsecutiveErrorLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureCondition")]
    public string? FailureCondition { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureLimit")]
    public IntstrIntOrString? FailureLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inconclusiveLimit")]
    public IntstrIntOrString? InconclusiveLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialDelay")]
    public string? InitialDelay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provider")]
    public V1alpha1AnalysisRunSpecMetricsProvider Provider { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successCondition")]
    public string? SuccessCondition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpecTtlStrategy
{
    /// <summary></summary>
    [JsonPropertyName("secondsAfterCompletion")]
    public int? SecondsAfterCompletion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secondsAfterFailure")]
    public int? SecondsAfterFailure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secondsAfterSuccess")]
    public int? SecondsAfterSuccess { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunSpec
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<V1alpha1AnalysisRunSpecArgs>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dryRun")]
    public IList<V1alpha1AnalysisRunSpecDryRun>? DryRun { get; set; }

    /// <summary></summary>
    [JsonPropertyName("measurementRetention")]
    public IList<V1alpha1AnalysisRunSpecMeasurementRetention>? MeasurementRetention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metrics")]
    public IList<V1alpha1AnalysisRunSpecMetrics> Metrics { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminate")]
    public bool? Terminate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ttlStrategy")]
    public V1alpha1AnalysisRunSpecTtlStrategy? TtlStrategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunStatusDryRunSummary
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("error")]
    public int? Error { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failed")]
    public int? Failed { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inconclusive")]
    public int? Inconclusive { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successful")]
    public int? Successful { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunStatusMetricResultsMeasurements
{
    /// <summary></summary>
    [JsonPropertyName("finishedAt")]
    public string? FinishedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phase")]
    public string Phase { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resumeAt")]
    public string? ResumeAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startedAt")]
    public string? StartedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunStatusMetricResults
{
    /// <summary></summary>
    [JsonPropertyName("consecutiveError")]
    public int? ConsecutiveError { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary></summary>
    [JsonPropertyName("error")]
    public int? Error { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failed")]
    public int? Failed { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inconclusive")]
    public int? Inconclusive { get; set; }

    /// <summary></summary>
    [JsonPropertyName("measurements")]
    public IList<V1alpha1AnalysisRunStatusMetricResultsMeasurements>? Measurements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phase")]
    public string Phase { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successful")]
    public int? Successful { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunStatusRunSummary
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("error")]
    public int? Error { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failed")]
    public int? Failed { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inconclusive")]
    public int? Inconclusive { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successful")]
    public int? Successful { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisRunStatus
{
    /// <summary></summary>
    [JsonPropertyName("completedAt")]
    public string? CompletedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dryRunSummary")]
    public V1alpha1AnalysisRunStatusDryRunSummary? DryRunSummary { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricResults")]
    public IList<V1alpha1AnalysisRunStatusMetricResults>? MetricResults { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phase")]
    public string Phase { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runSummary")]
    public V1alpha1AnalysisRunStatusRunSummary? RunSummary { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startedAt")]
    public string? StartedAt { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AnalysisRun : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AnalysisRunSpec>, IStatus<V1alpha1AnalysisRunStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AnalysisRun";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "analysisruns";
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
    public V1alpha1AnalysisRunSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1AnalysisRunStatus? Status { get; set; }
}