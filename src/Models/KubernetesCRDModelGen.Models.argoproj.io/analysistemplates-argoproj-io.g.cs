using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.argoproj.io;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AnalysisTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AnalysisTemplate>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AnalysisTemplateList";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "analysistemplates";
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
    public IList<V1alpha1AnalysisTemplate> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecArgsValueFromFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecArgsValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecArgsValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1AnalysisTemplateSpecArgsValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1AnalysisTemplateSpecArgsValueFromSecretKeyRef? SecretKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecArgs
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1AnalysisTemplateSpecArgsValueFrom? ValueFrom { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecDryRun
{
    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string MetricName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMeasurementRetention
{
    /// <summary></summary>
    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string MetricName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetric
{
    /// <summary></summary>
    [JsonPropertyName("dimensions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStat
{
    /// <summary></summary>
    [JsonPropertyName("metric")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetric? Metric { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueries
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
    public V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("period")]
    public IntstrIntOrString? Period { get; set; }

    /// <summary></summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatch
{
    /// <summary></summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueries> MetricDataQueries { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderDatadogSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaced")]
    public bool? Namespaced { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderDatadog
{
    /// <summary></summary>
    [JsonPropertyName("aggregator")]
    public string? Aggregator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

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

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderDatadogSecretRef? SecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderGraphite
{
    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderInfluxdb
{
    /// <summary></summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnExitCodes
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnPodConditions
{
    /// <summary></summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRules
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("onExitCodes")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnExitCodes? OnExitCodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("onPodConditions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnPodConditions>? OnPodConditions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicy
{
    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRules> Rules { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecSelectorMatchExpressions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchFields")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("preference")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchFields")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinity
{
    /// <summary></summary>
    [JsonPropertyName("nodeAffinity")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podAffinity")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromResourceFieldRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromSecretKeyRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromConfigMapRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStart
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStop
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecycle
{
    /// <summary></summary>
    [JsonPropertyName("postStart")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preStop")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStop? PreStop { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersPorts
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResizePolicy
{
    /// <summary></summary>
    [JsonPropertyName("resourceName")]
    public string ResourceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string RestartPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResourcesClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResources
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextCapabilities
{
    /// <summary></summary>
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    /// <summary></summary>
    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeLinuxOptions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeccompProfile
{
    /// <summary></summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextWindowsOptions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeDevices
{
    /// <summary></summary>
    [JsonPropertyName("devicePath")]
    public string DevicePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeMounts
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainers
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envFrom")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecycle? Lifecycle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfigOptions
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfig
{
    /// <summary></summary>
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("options")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfigOptions>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFrom? ValueFrom { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromSecretRef? SecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStart
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStop
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecycle
{
    /// <summary></summary>
    [JsonPropertyName("postStart")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preStop")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStop? PreStop { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersPorts
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResizePolicy
{
    /// <summary></summary>
    [JsonPropertyName("resourceName")]
    public string ResourceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string RestartPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResourcesClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResources
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResourcesClaims>? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextCapabilities
{
    /// <summary></summary>
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    /// <summary></summary>
    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile
{
    /// <summary></summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeDevices
{
    /// <summary></summary>
    [JsonPropertyName("devicePath")]
    public string DevicePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeMounts
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainers
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envFrom")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecycle? Lifecycle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecHostAliases
{
    /// <summary></summary>
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecImagePullSecrets
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFrom? ValueFrom { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromConfigMapRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromSecretRef? SecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStart
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStop
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecycle
{
    /// <summary></summary>
    [JsonPropertyName("postStart")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preStop")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStop? PreStop { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersPorts
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResizePolicy
{
    /// <summary></summary>
    [JsonPropertyName("resourceName")]
    public string ResourceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string RestartPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResourcesClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResources
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResourcesClaims>? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextCapabilities
{
    /// <summary></summary>
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    /// <summary></summary>
    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeccompProfile
{
    /// <summary></summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextWindowsOptions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeGrpc
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeTcpSocket
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeDevices
{
    /// <summary></summary>
    [JsonPropertyName("devicePath")]
    public string DevicePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeMounts
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainers
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envFrom")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecycle? Lifecycle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecOs
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecReadinessGates
{
    /// <summary></summary>
    [JsonPropertyName("conditionType")]
    public string ConditionType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourceClaimsSource
{
    /// <summary></summary>
    [JsonPropertyName("resourceClaimName")]
    public string? ResourceClaimName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceClaimTemplateName")]
    public string? ResourceClaimTemplateName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourceClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourceClaimsSource? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSchedulingGates
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeLinuxOptions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeccompProfile
{
    /// <summary></summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSysctls
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextWindowsOptions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContext
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
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supplementalGroups")]
    public IList<long>? SupplementalGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sysctls")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSysctls>? Sysctls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextWindowsOptions? WindowsOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTolerations
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraints
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("activeDeadlineSeconds")]
    public long? ActiveDeadlineSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("affinity")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinity? Affinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("automountServiceAccountToken")]
    public bool? AutomountServiceAccountToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containers")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainers> Containers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsConfig")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfig? DnsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsPolicy")]
    public string? DnsPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ephemeralContainers")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainers>? EphemeralContainers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecHostAliases>? HostAliases { get; set; }

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
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initContainers")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainers>? InitContainers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeName")]
    public string? NodeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("os")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecOs? Os { get; set; }

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
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecReadinessGates>? ReadinessGates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceClaims")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourceClaims>? ResourceClaims { get; set; }

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
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSchedulingGates>? SchedulingGates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContext? SecurityContext { get; set; }

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
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTolerations>? Tolerations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public JsonNode? Volumes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplateSpec? Spec { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJobSpec
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
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicy? PodFailurePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podReplacementPolicy")]
    public string? PodReplacementPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecSelector? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpecTemplate Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ttlSecondsAfterFinished")]
    public int? TtlSecondsAfterFinished { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderJob
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJobSpec Spec { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderKayentaScopesControlScope
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderKayentaScopesExperimentScope
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderKayentaScopes
{
    /// <summary></summary>
    [JsonPropertyName("controlScope")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderKayentaScopesControlScope ControlScope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("experimentScope")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderKayentaScopesExperimentScope ExperimentScope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderKayentaThreshold
{
    /// <summary></summary>
    [JsonPropertyName("marginal")]
    public long Marginal { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pass")]
    public long Pass { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderKayenta
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
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderKayentaScopes> Scopes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountName")]
    public string StorageAccountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("threshold")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderKayentaThreshold Threshold { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderNewRelic
{
    /// <summary></summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string Query { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeout")]
    public long? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusAuthenticationOauth2
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusAuthenticationSigv4
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusAuthentication
{
    /// <summary></summary>
    [JsonPropertyName("oauth2")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusAuthenticationOauth2? Oauth2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sigv4")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusAuthenticationSigv4? Sigv4 { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusHeaders
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusRangeQuery
{
    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary></summary>
    [JsonPropertyName("step")]
    public string? Step { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderPrometheus
{
    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authentication")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusAuthentication? Authentication { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusHeaders>? Headers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rangeQuery")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderPrometheusRangeQuery? RangeQuery { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeout")]
    public long? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderSkywalking
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderWavefront
{
    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderWebAuthenticationOauth2
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderWebAuthenticationSigv4
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderWebAuthentication
{
    /// <summary></summary>
    [JsonPropertyName("oauth2")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderWebAuthenticationOauth2? Oauth2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sigv4")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderWebAuthenticationSigv4? Sigv4 { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderWebHeaders
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProviderWeb
{
    /// <summary></summary>
    [JsonPropertyName("authentication")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderWebAuthentication? Authentication { get; set; }

    /// <summary></summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1AnalysisTemplateSpecMetricsProviderWebHeaders>? Headers { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetricsProvider
{
    /// <summary></summary>
    [JsonPropertyName("cloudWatch")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderCloudWatch? CloudWatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datadog")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderDatadog? Datadog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("graphite")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderGraphite? Graphite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("influxdb")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderInfluxdb? Influxdb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("job")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderJob? Job { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kayenta")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderKayenta? Kayenta { get; set; }

    /// <summary></summary>
    [JsonPropertyName("newRelic")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderNewRelic? NewRelic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public JsonNode? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prometheus")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderPrometheus? Prometheus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skywalking")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderSkywalking? Skywalking { get; set; }

    /// <summary></summary>
    [JsonPropertyName("wavefront")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderWavefront? Wavefront { get; set; }

    /// <summary></summary>
    [JsonPropertyName("web")]
    public V1alpha1AnalysisTemplateSpecMetricsProviderWeb? Web { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecMetrics
{
    /// <summary></summary>
    [JsonPropertyName("consecutiveErrorLimit")]
    public IntstrIntOrString? ConsecutiveErrorLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consecutiveSuccessLimit")]
    public IntstrIntOrString? ConsecutiveSuccessLimit { get; set; }

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
    public V1alpha1AnalysisTemplateSpecMetricsProvider Provider { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successCondition")]
    public string? SuccessCondition { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpecTemplates
{
    /// <summary></summary>
    [JsonPropertyName("clusterScope")]
    public bool? ClusterScope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templateName")]
    public string? TemplateName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AnalysisTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<V1alpha1AnalysisTemplateSpecArgs>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dryRun")]
    public IList<V1alpha1AnalysisTemplateSpecDryRun>? DryRun { get; set; }

    /// <summary></summary>
    [JsonPropertyName("measurementRetention")]
    public IList<V1alpha1AnalysisTemplateSpecMeasurementRetention>? MeasurementRetention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metrics")]
    public IList<V1alpha1AnalysisTemplateSpecMetrics>? Metrics { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templates")]
    public IList<V1alpha1AnalysisTemplateSpecTemplates>? Templates { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AnalysisTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AnalysisTemplateSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AnalysisTemplate";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "analysistemplates";
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
    public V1alpha1AnalysisTemplateSpec Spec { get; set; }
}
#nullable disable
