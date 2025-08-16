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
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterAnalysisTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ClusterAnalysisTemplate>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterAnalysisTemplateList";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "clusteranalysistemplates";
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
    public IList<V1alpha1ClusterAnalysisTemplate> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecArgsValueFromFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecArgsValueFromSecretKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecArgsValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1ClusterAnalysisTemplateSpecArgsValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecArgsValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecArgs
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1ClusterAnalysisTemplateSpecArgsValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecDryRun
{
    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string MetricName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMeasurementRetention
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetricDimensions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetric
{
    /// <summary></summary>
    [JsonPropertyName("dimensions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStat
{
    /// <summary></summary>
    [JsonPropertyName("metric")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStatMetric? Metric { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueries
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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("period")]
    public IntstrIntOrString? Period { get; set; }

    /// <summary></summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatch
{
    /// <summary></summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatchMetricDataQueries> MetricDataQueries { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderDatadogSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaced")]
    public bool? Namespaced { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderDatadog
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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderDatadogSecretRef? SecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderGraphite
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderInfluxdb
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobMetadata
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnExitCodes
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnPodConditions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRules
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("onExitCodes")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnExitCodes? OnExitCodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("onPodConditions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRulesOnPodConditions>? OnPodConditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicy
{
    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicyRules> Rules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateMetadata
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchFields")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("preference")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchFields")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinity
{
    /// <summary></summary>
    [JsonPropertyName("nodeAffinity")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podAffinity")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromFieldRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromConfigMapRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromSecretRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartTcpSocket
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStart
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopTcpSocket
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStop
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecycle
{
    /// <summary></summary>
    [JsonPropertyName("postStart")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preStop")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecyclePreStop? PreStop { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeGrpc
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeTcpSocket
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersPorts
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeGrpc
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeTcpSocket
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResizePolicy
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResourcesClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResources
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextCapabilities
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeccompProfile
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextWindowsOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeGrpc
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeTcpSocket
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeDevices
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeMounts
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainers
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envFrom")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLifecycle? Lifecycle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfigOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfig
{
    /// <summary></summary>
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("options")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfigOptions>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromSecretRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStart
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStop
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecycle
{
    /// <summary></summary>
    [JsonPropertyName("postStart")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preStop")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecyclePreStop? PreStop { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeGrpc
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersPorts
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeGrpc
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResizePolicy
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResourcesClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResources
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResourcesClaims>? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextCapabilities
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeGrpc
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeDevices
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeMounts
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainers
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envFrom")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLifecycle? Lifecycle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecHostAliases
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecImagePullSecrets
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromFieldRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromConfigMapRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromSecretRef
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStart
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStop
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecycle
{
    /// <summary></summary>
    [JsonPropertyName("postStart")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preStop")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecyclePreStop? PreStop { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeGrpc
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeTcpSocket
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersPorts
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeGrpc
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeTcpSocket
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResizePolicy
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResourcesClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResources
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResourcesClaims>? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextCapabilities
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeccompProfile
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextWindowsOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeGrpc
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeTcpSocket
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeDevices
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeMounts
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainers
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envFrom")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLifecycle? Lifecycle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecOs
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecReadinessGates
{
    /// <summary></summary>
    [JsonPropertyName("conditionType")]
    public string ConditionType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourceClaimsSource
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourceClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourceClaimsSource? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSchedulingGates
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeLinuxOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeccompProfile
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSysctls
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextWindowsOptions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContext
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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supplementalGroups")]
    public IList<long>? SupplementalGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sysctls")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextSysctls>? Sysctls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTolerations
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraints
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("activeDeadlineSeconds")]
    public long? ActiveDeadlineSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("affinity")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecAffinity? Affinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("automountServiceAccountToken")]
    public bool? AutomountServiceAccountToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containers")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecContainers> Containers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsConfig")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecDnsConfig? DnsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsPolicy")]
    public string? DnsPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ephemeralContainers")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecEphemeralContainers>? EphemeralContainers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecHostAliases>? HostAliases { get; set; }

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
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initContainers")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecInitContainers>? InitContainers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeName")]
    public string? NodeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("os")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecOs? Os { get; set; }

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
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecReadinessGates>? ReadinessGates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceClaims")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecResourceClaims>? ResourceClaims { get; set; }

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
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSchedulingGates>? SchedulingGates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecSecurityContext? SecurityContext { get; set; }

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
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTolerations>? Tolerations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public JsonNode? Volumes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplateSpec? Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpec
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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecPodFailurePolicy? PodFailurePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podReplacementPolicy")]
    public string? PodReplacementPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecSelector? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpecTemplate Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ttlSecondsAfterFinished")]
    public int? TtlSecondsAfterFinished { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJob
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJobSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaScopesControlScope
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaScopesExperimentScope
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaScopes
{
    /// <summary></summary>
    [JsonPropertyName("controlScope")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaScopesControlScope ControlScope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("experimentScope")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaScopesExperimentScope ExperimentScope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaThreshold
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayenta
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
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaScopes> Scopes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountName")]
    public string StorageAccountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("threshold")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayentaThreshold Threshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderNewRelic
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusAuthenticationOauth2
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusAuthenticationSigv4
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusAuthentication
{
    /// <summary></summary>
    [JsonPropertyName("oauth2")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusAuthenticationOauth2? Oauth2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sigv4")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusAuthenticationSigv4? Sigv4 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusRangeQuery
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheus
{
    /// <summary></summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authentication")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusAuthentication? Authentication { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusHeaders>? Headers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rangeQuery")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheusRangeQuery? RangeQuery { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeout")]
    public long? Timeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderSkywalking
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWavefront
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebAuthenticationOauth2
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebAuthenticationSigv4
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebAuthentication
{
    /// <summary></summary>
    [JsonPropertyName("oauth2")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebAuthenticationOauth2? Oauth2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sigv4")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebAuthenticationSigv4? Sigv4 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebHeaders
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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWeb
{
    /// <summary></summary>
    [JsonPropertyName("authentication")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebAuthentication? Authentication { get; set; }

    /// <summary></summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWebHeaders>? Headers { get; set; }

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
public partial class V1alpha1ClusterAnalysisTemplateSpecMetricsProvider
{
    /// <summary></summary>
    [JsonPropertyName("cloudWatch")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderCloudWatch? CloudWatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datadog")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderDatadog? Datadog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("graphite")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderGraphite? Graphite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("influxdb")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderInfluxdb? Influxdb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("job")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderJob? Job { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kayenta")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderKayenta? Kayenta { get; set; }

    /// <summary></summary>
    [JsonPropertyName("newRelic")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderNewRelic? NewRelic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public JsonNode? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prometheus")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderPrometheus? Prometheus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skywalking")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderSkywalking? Skywalking { get; set; }

    /// <summary></summary>
    [JsonPropertyName("wavefront")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWavefront? Wavefront { get; set; }

    /// <summary></summary>
    [JsonPropertyName("web")]
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProviderWeb? Web { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecMetrics
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
    public V1alpha1ClusterAnalysisTemplateSpecMetricsProvider Provider { get; set; }

    /// <summary></summary>
    [JsonPropertyName("successCondition")]
    public string? SuccessCondition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpecTemplates
{
    /// <summary></summary>
    [JsonPropertyName("clusterScope")]
    public bool? ClusterScope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templateName")]
    public string? TemplateName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterAnalysisTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecArgs>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dryRun")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecDryRun>? DryRun { get; set; }

    /// <summary></summary>
    [JsonPropertyName("measurementRetention")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMeasurementRetention>? MeasurementRetention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metrics")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecMetrics>? Metrics { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templates")]
    public IList<V1alpha1ClusterAnalysisTemplateSpecTemplates>? Templates { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterAnalysisTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterAnalysisTemplateSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterAnalysisTemplate";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "clusteranalysistemplates";
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
    public V1alpha1ClusterAnalysisTemplateSpec Spec { get; set; }
}