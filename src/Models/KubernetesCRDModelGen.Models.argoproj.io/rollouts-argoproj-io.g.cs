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
public partial class V1alpha1RolloutSpecAnalysis
{
    /// <summary></summary>
    [JsonPropertyName("successfulRunHistoryLimit")]
    public int? SuccessfulRunHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("unsuccessfulRunHistoryLimit")]
    public int? UnsuccessfulRunHistoryLimit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecRollbackWindow
{
    /// <summary></summary>
    [JsonPropertyName("revisions")]
    public int? Revisions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecSelectorMatchExpressions
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
public partial class V1alpha1RolloutSpecSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1RolloutSpecSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyBlueGreenActiveMetadata
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
public partial class V1alpha1RolloutSpecStrategyBlueGreenAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyBlueGreenAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyBlueGreenAntiAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha1RolloutSpecStrategyBlueGreenAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha1RolloutSpecStrategyBlueGreenAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysisAnalysisRunMetadata
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
public partial class V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysisArgsValueFromFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysisArgsValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysisArgsValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podTemplateHashValue")]
    public string? PodTemplateHashValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysisArgs
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysisArgsValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysisDryRun
{
    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string MetricName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysisMeasurementRetention
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
public partial class V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysisTemplates
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
public partial class V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysis
{
    /// <summary></summary>
    [JsonPropertyName("analysisRunMetadata")]
    public V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysisAnalysisRunMetadata? AnalysisRunMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysisArgs>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dryRun")]
    public IList<V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysisDryRun>? DryRun { get; set; }

    /// <summary></summary>
    [JsonPropertyName("measurementRetention")]
    public IList<V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysisMeasurementRetention>? MeasurementRetention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templates")]
    public IList<V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysisTemplates>? Templates { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysisAnalysisRunMetadata
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
public partial class V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysisArgsValueFromFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysisArgsValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysisArgsValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podTemplateHashValue")]
    public string? PodTemplateHashValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysisArgs
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysisArgsValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysisDryRun
{
    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string MetricName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysisMeasurementRetention
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
public partial class V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysisTemplates
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
public partial class V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysis
{
    /// <summary></summary>
    [JsonPropertyName("analysisRunMetadata")]
    public V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysisAnalysisRunMetadata? AnalysisRunMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysisArgs>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dryRun")]
    public IList<V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysisDryRun>? DryRun { get; set; }

    /// <summary></summary>
    [JsonPropertyName("measurementRetention")]
    public IList<V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysisMeasurementRetention>? MeasurementRetention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templates")]
    public IList<V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysisTemplates>? Templates { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyBlueGreenPreviewMetadata
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
public partial class V1alpha1RolloutSpecStrategyBlueGreen
{
    /// <summary></summary>
    [JsonPropertyName("abortScaleDownDelaySeconds")]
    public int? AbortScaleDownDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("activeMetadata")]
    public V1alpha1RolloutSpecStrategyBlueGreenActiveMetadata? ActiveMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("activeService")]
    public string ActiveService { get; set; }

    /// <summary></summary>
    [JsonPropertyName("antiAffinity")]
    public V1alpha1RolloutSpecStrategyBlueGreenAntiAffinity? AntiAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoPromotionEnabled")]
    public bool? AutoPromotionEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoPromotionSeconds")]
    public int? AutoPromotionSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxUnavailable")]
    public IntstrIntOrString? MaxUnavailable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("postPromotionAnalysis")]
    public V1alpha1RolloutSpecStrategyBlueGreenPostPromotionAnalysis? PostPromotionAnalysis { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prePromotionAnalysis")]
    public V1alpha1RolloutSpecStrategyBlueGreenPrePromotionAnalysis? PrePromotionAnalysis { get; set; }

    /// <summary></summary>
    [JsonPropertyName("previewMetadata")]
    public V1alpha1RolloutSpecStrategyBlueGreenPreviewMetadata? PreviewMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("previewReplicaCount")]
    public int? PreviewReplicaCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("previewService")]
    public string? PreviewService { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleDownDelayRevisionLimit")]
    public int? ScaleDownDelayRevisionLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleDownDelaySeconds")]
    public int? ScaleDownDelaySeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryAnalysisAnalysisRunMetadata
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
public partial class V1alpha1RolloutSpecStrategyCanaryAnalysisArgsValueFromFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryAnalysisArgsValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1RolloutSpecStrategyCanaryAnalysisArgsValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podTemplateHashValue")]
    public string? PodTemplateHashValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryAnalysisArgs
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1RolloutSpecStrategyCanaryAnalysisArgsValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryAnalysisDryRun
{
    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string MetricName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryAnalysisMeasurementRetention
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
public partial class V1alpha1RolloutSpecStrategyCanaryAnalysisTemplates
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
public partial class V1alpha1RolloutSpecStrategyCanaryAnalysis
{
    /// <summary></summary>
    [JsonPropertyName("analysisRunMetadata")]
    public V1alpha1RolloutSpecStrategyCanaryAnalysisAnalysisRunMetadata? AnalysisRunMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<V1alpha1RolloutSpecStrategyCanaryAnalysisArgs>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dryRun")]
    public IList<V1alpha1RolloutSpecStrategyCanaryAnalysisDryRun>? DryRun { get; set; }

    /// <summary></summary>
    [JsonPropertyName("measurementRetention")]
    public IList<V1alpha1RolloutSpecStrategyCanaryAnalysisMeasurementRetention>? MeasurementRetention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startingStep")]
    public int? StartingStep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templates")]
    public IList<V1alpha1RolloutSpecStrategyCanaryAnalysisTemplates>? Templates { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryAntiAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha1RolloutSpecStrategyCanaryAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha1RolloutSpecStrategyCanaryAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryCanaryMetadata
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
public partial class V1alpha1RolloutSpecStrategyCanaryPingPong
{
    /// <summary></summary>
    [JsonPropertyName("pingService")]
    public string PingService { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pongService")]
    public string PongService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStableMetadata
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
public partial class V1alpha1RolloutSpecStrategyCanaryStepsAnalysisAnalysisRunMetadata
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
public partial class V1alpha1RolloutSpecStrategyCanaryStepsAnalysisArgsValueFromFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsAnalysisArgsValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1RolloutSpecStrategyCanaryStepsAnalysisArgsValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podTemplateHashValue")]
    public string? PodTemplateHashValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsAnalysisArgs
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1RolloutSpecStrategyCanaryStepsAnalysisArgsValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsAnalysisDryRun
{
    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string MetricName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsAnalysisMeasurementRetention
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
public partial class V1alpha1RolloutSpecStrategyCanaryStepsAnalysisTemplates
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
public partial class V1alpha1RolloutSpecStrategyCanaryStepsAnalysis
{
    /// <summary></summary>
    [JsonPropertyName("analysisRunMetadata")]
    public V1alpha1RolloutSpecStrategyCanaryStepsAnalysisAnalysisRunMetadata? AnalysisRunMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<V1alpha1RolloutSpecStrategyCanaryStepsAnalysisArgs>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dryRun")]
    public IList<V1alpha1RolloutSpecStrategyCanaryStepsAnalysisDryRun>? DryRun { get; set; }

    /// <summary></summary>
    [JsonPropertyName("measurementRetention")]
    public IList<V1alpha1RolloutSpecStrategyCanaryStepsAnalysisMeasurementRetention>? MeasurementRetention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templates")]
    public IList<V1alpha1RolloutSpecStrategyCanaryStepsAnalysisTemplates>? Templates { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsExperimentAnalysesArgsValueFromFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsExperimentAnalysesArgsValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1RolloutSpecStrategyCanaryStepsExperimentAnalysesArgsValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podTemplateHashValue")]
    public string? PodTemplateHashValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsExperimentAnalysesArgs
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1RolloutSpecStrategyCanaryStepsExperimentAnalysesArgsValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsExperimentAnalyses
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<V1alpha1RolloutSpecStrategyCanaryStepsExperimentAnalysesArgs>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterScope")]
    public bool? ClusterScope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredForCompletion")]
    public bool? RequiredForCompletion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templateName")]
    public string TemplateName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsExperimentAnalysisRunMetadata
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
public partial class V1alpha1RolloutSpecStrategyCanaryStepsExperimentDryRun
{
    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string MetricName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsExperimentTemplatesMetadata
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
public partial class V1alpha1RolloutSpecStrategyCanaryStepsExperimentTemplatesSelectorMatchExpressions
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
public partial class V1alpha1RolloutSpecStrategyCanaryStepsExperimentTemplatesSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1RolloutSpecStrategyCanaryStepsExperimentTemplatesSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsExperimentTemplatesService
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsExperimentTemplates
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1RolloutSpecStrategyCanaryStepsExperimentTemplatesMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public V1alpha1RolloutSpecStrategyCanaryStepsExperimentTemplatesSelector? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public V1alpha1RolloutSpecStrategyCanaryStepsExperimentTemplatesService? Service { get; set; }

    /// <summary></summary>
    [JsonPropertyName("specRef")]
    public string SpecRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsExperiment
{
    /// <summary></summary>
    [JsonPropertyName("analyses")]
    public IList<V1alpha1RolloutSpecStrategyCanaryStepsExperimentAnalyses>? Analyses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("analysisRunMetadata")]
    public V1alpha1RolloutSpecStrategyCanaryStepsExperimentAnalysisRunMetadata? AnalysisRunMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dryRun")]
    public IList<V1alpha1RolloutSpecStrategyCanaryStepsExperimentDryRun>? DryRun { get; set; }

    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templates")]
    public IList<V1alpha1RolloutSpecStrategyCanaryStepsExperimentTemplates> Templates { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsPause
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public IntstrIntOrString? Duration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsSetCanaryScale
{
    /// <summary></summary>
    [JsonPropertyName("matchTrafficWeight")]
    public bool? MatchTrafficWeight { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsSetHeaderRouteMatchHeaderValue
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsSetHeaderRouteMatch
{
    /// <summary></summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headerValue")]
    public V1alpha1RolloutSpecStrategyCanaryStepsSetHeaderRouteMatchHeaderValue HeaderValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsSetHeaderRoute
{
    /// <summary></summary>
    [JsonPropertyName("match")]
    public IList<V1alpha1RolloutSpecStrategyCanaryStepsSetHeaderRouteMatch>? Match { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsSetMirrorRouteMatchHeaders
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsSetMirrorRouteMatchMethod
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsSetMirrorRouteMatchPath
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsSetMirrorRouteMatch
{
    /// <summary></summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, V1alpha1RolloutSpecStrategyCanaryStepsSetMirrorRouteMatchHeaders>? Headers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("method")]
    public V1alpha1RolloutSpecStrategyCanaryStepsSetMirrorRouteMatchMethod? Method { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public V1alpha1RolloutSpecStrategyCanaryStepsSetMirrorRouteMatchPath? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryStepsSetMirrorRoute
{
    /// <summary></summary>
    [JsonPropertyName("match")]
    public IList<V1alpha1RolloutSpecStrategyCanaryStepsSetMirrorRouteMatch>? Match { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("percentage")]
    public int? Percentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanarySteps
{
    /// <summary></summary>
    [JsonPropertyName("analysis")]
    public V1alpha1RolloutSpecStrategyCanaryStepsAnalysis? Analysis { get; set; }

    /// <summary></summary>
    [JsonPropertyName("experiment")]
    public V1alpha1RolloutSpecStrategyCanaryStepsExperiment? Experiment { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pause")]
    public V1alpha1RolloutSpecStrategyCanaryStepsPause? Pause { get; set; }

    /// <summary></summary>
    [JsonPropertyName("setCanaryScale")]
    public V1alpha1RolloutSpecStrategyCanaryStepsSetCanaryScale? SetCanaryScale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("setHeaderRoute")]
    public V1alpha1RolloutSpecStrategyCanaryStepsSetHeaderRoute? SetHeaderRoute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("setMirrorRoute")]
    public V1alpha1RolloutSpecStrategyCanaryStepsSetMirrorRoute? SetMirrorRoute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("setWeight")]
    public int? SetWeight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAlbStickinessConfig
{
    /// <summary></summary>
    [JsonPropertyName("durationSeconds")]
    public long DurationSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAlb
{
    /// <summary></summary>
    [JsonPropertyName("annotationPrefix")]
    public string? AnnotationPrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingress")]
    public string? Ingress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingresses")]
    public IList<string>? Ingresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootService")]
    public string? RootService { get; set; }

    /// <summary></summary>
    [JsonPropertyName("servicePort")]
    public int ServicePort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stickinessConfig")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAlbStickinessConfig? StickinessConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAmbassador
{
    /// <summary></summary>
    [JsonPropertyName("mappings")]
    public IList<string> Mappings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingApisixRoute
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<string>? Rules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingApisix
{
    /// <summary></summary>
    [JsonPropertyName("route")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingApisixRoute? Route { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAppMeshVirtualNodeGroupCanaryVirtualNodeRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAppMeshVirtualNodeGroupStableVirtualNodeRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAppMeshVirtualNodeGroup
{
    /// <summary></summary>
    [JsonPropertyName("canaryVirtualNodeRef")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAppMeshVirtualNodeGroupCanaryVirtualNodeRef CanaryVirtualNodeRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stableVirtualNodeRef")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAppMeshVirtualNodeGroupStableVirtualNodeRef StableVirtualNodeRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAppMeshVirtualService
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("routes")]
    public IList<string>? Routes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAppMesh
{
    /// <summary></summary>
    [JsonPropertyName("virtualNodeGroup")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAppMeshVirtualNodeGroup? VirtualNodeGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualService")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAppMeshVirtualService? VirtualService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstioDestinationRule
{
    /// <summary></summary>
    [JsonPropertyName("canarySubsetName")]
    public string CanarySubsetName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stableSubsetName")]
    public string StableSubsetName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstioVirtualServiceTcpRoutes
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstioVirtualServiceTlsRoutes
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sniHosts")]
    public IList<string>? SniHosts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstioVirtualService
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("routes")]
    public IList<string>? Routes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpRoutes")]
    public IList<V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstioVirtualServiceTcpRoutes>? TcpRoutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlsRoutes")]
    public IList<V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstioVirtualServiceTlsRoutes>? TlsRoutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstioVirtualServicesTcpRoutes
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstioVirtualServicesTlsRoutes
{
    /// <summary></summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sniHosts")]
    public IList<string>? SniHosts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstioVirtualServices
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("routes")]
    public IList<string>? Routes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpRoutes")]
    public IList<V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstioVirtualServicesTcpRoutes>? TcpRoutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlsRoutes")]
    public IList<V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstioVirtualServicesTlsRoutes>? TlsRoutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstio
{
    /// <summary></summary>
    [JsonPropertyName("destinationRule")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstioDestinationRule? DestinationRule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualService")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstioVirtualService? VirtualService { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualServices")]
    public IList<V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstioVirtualServices>? VirtualServices { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingManagedRoutes
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingNginx
{
    /// <summary></summary>
    [JsonPropertyName("additionalIngressAnnotations")]
    public IDictionary<string, string>? AdditionalIngressAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("annotationPrefix")]
    public string? AnnotationPrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stableIngress")]
    public string? StableIngress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stableIngresses")]
    public IList<string>? StableIngresses { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingSmi
{
    /// <summary></summary>
    [JsonPropertyName("rootService")]
    public string? RootService { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trafficSplitName")]
    public string? TrafficSplitName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRoutingTraefik
{
    /// <summary></summary>
    [JsonPropertyName("weightedTraefikServiceName")]
    public string WeightedTraefikServiceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanaryTrafficRouting
{
    /// <summary></summary>
    [JsonPropertyName("alb")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAlb? Alb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ambassador")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAmbassador? Ambassador { get; set; }

    /// <summary></summary>
    [JsonPropertyName("apisix")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingApisix? Apisix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("appMesh")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingAppMesh? AppMesh { get; set; }

    /// <summary></summary>
    [JsonPropertyName("istio")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingIstio? Istio { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedRoutes")]
    public IList<V1alpha1RolloutSpecStrategyCanaryTrafficRoutingManagedRoutes>? ManagedRoutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxTrafficWeight")]
    public int? MaxTrafficWeight { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nginx")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingNginx? Nginx { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugins")]
    public JsonNode? Plugins { get; set; }

    /// <summary></summary>
    [JsonPropertyName("smi")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingSmi? Smi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("traefik")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRoutingTraefik? Traefik { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategyCanary
{
    /// <summary></summary>
    [JsonPropertyName("abortScaleDownDelaySeconds")]
    public int? AbortScaleDownDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("analysis")]
    public V1alpha1RolloutSpecStrategyCanaryAnalysis? Analysis { get; set; }

    /// <summary></summary>
    [JsonPropertyName("antiAffinity")]
    public V1alpha1RolloutSpecStrategyCanaryAntiAffinity? AntiAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("canaryMetadata")]
    public V1alpha1RolloutSpecStrategyCanaryCanaryMetadata? CanaryMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("canaryService")]
    public string? CanaryService { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dynamicStableScale")]
    public bool? DynamicStableScale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxSurge")]
    public IntstrIntOrString? MaxSurge { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxUnavailable")]
    public IntstrIntOrString? MaxUnavailable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minPodsPerReplicaSet")]
    public int? MinPodsPerReplicaSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pingPong")]
    public V1alpha1RolloutSpecStrategyCanaryPingPong? PingPong { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleDownDelayRevisionLimit")]
    public int? ScaleDownDelayRevisionLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleDownDelaySeconds")]
    public int? ScaleDownDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stableMetadata")]
    public V1alpha1RolloutSpecStrategyCanaryStableMetadata? StableMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stableService")]
    public string? StableService { get; set; }

    /// <summary></summary>
    [JsonPropertyName("steps")]
    public IList<V1alpha1RolloutSpecStrategyCanarySteps>? Steps { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trafficRouting")]
    public V1alpha1RolloutSpecStrategyCanaryTrafficRouting? TrafficRouting { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecStrategy
{
    /// <summary></summary>
    [JsonPropertyName("blueGreen")]
    public V1alpha1RolloutSpecStrategyBlueGreen? BlueGreen { get; set; }

    /// <summary></summary>
    [JsonPropertyName("canary")]
    public V1alpha1RolloutSpecStrategyCanary? Canary { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateMetadata
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
public partial class V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
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
public partial class V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
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
public partial class V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchFields")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("preference")]
    public V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
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
public partial class V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
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
public partial class V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchFields")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecAffinity
{
    /// <summary></summary>
    [JsonPropertyName("nodeAffinity")]
    public V1alpha1RolloutSpecTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podAffinity")]
    public V1alpha1RolloutSpecTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1alpha1RolloutSpecTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersEnvValueFromFieldRef
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersEnvValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1RolloutSpecTemplateSpecContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1RolloutSpecTemplateSpecContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1RolloutSpecTemplateSpecContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1RolloutSpecTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1RolloutSpecTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersEnvFromConfigMapRef
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersEnvFromSecretRef
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersEnvFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1RolloutSpecTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1RolloutSpecTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersLifecyclePostStartExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersLifecyclePostStartHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RolloutSpecTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpecContainersLifecyclePostStartSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersLifecyclePostStartTcpSocket
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersLifecyclePostStart
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1RolloutSpecTemplateSpecContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RolloutSpecTemplateSpecContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1RolloutSpecTemplateSpecContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1RolloutSpecTemplateSpecContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersLifecyclePreStopExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersLifecyclePreStopHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RolloutSpecTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpecContainersLifecyclePreStopSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersLifecyclePreStopTcpSocket
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersLifecyclePreStop
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1RolloutSpecTemplateSpecContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RolloutSpecTemplateSpecContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1RolloutSpecTemplateSpecContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1RolloutSpecTemplateSpecContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersLifecycle
{
    /// <summary></summary>
    [JsonPropertyName("postStart")]
    public V1alpha1RolloutSpecTemplateSpecContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preStop")]
    public V1alpha1RolloutSpecTemplateSpecContainersLifecyclePreStop? PreStop { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersLivenessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersLivenessProbeGrpc
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersLivenessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RolloutSpecTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpecContainersLivenessProbeTcpSocket
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersLivenessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1RolloutSpecTemplateSpecContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1RolloutSpecTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RolloutSpecTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1RolloutSpecTemplateSpecContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersPorts
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersReadinessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersReadinessProbeGrpc
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersReadinessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RolloutSpecTemplateSpecContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpecContainersReadinessProbeTcpSocket
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersReadinessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1RolloutSpecTemplateSpecContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1RolloutSpecTemplateSpecContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RolloutSpecTemplateSpecContainersReadinessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1RolloutSpecTemplateSpecContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersResizePolicy
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersResourcesClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersResources
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public IList<V1alpha1RolloutSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersSecurityContextCapabilities
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersSecurityContextSeccompProfile
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersSecurityContextWindowsOptions
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1RolloutSpecTemplateSpecContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1RolloutSpecTemplateSpecContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1RolloutSpecTemplateSpecContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1RolloutSpecTemplateSpecContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersStartupProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersStartupProbeGrpc
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersStartupProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RolloutSpecTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpecContainersStartupProbeTcpSocket
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersStartupProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1RolloutSpecTemplateSpecContainersStartupProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1RolloutSpecTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RolloutSpecTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1RolloutSpecTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecContainersVolumeDevices
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
public partial class V1alpha1RolloutSpecTemplateSpecContainersVolumeMounts
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
public partial class V1alpha1RolloutSpecTemplateSpecContainers
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1RolloutSpecTemplateSpecContainersEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envFrom")]
    public IList<V1alpha1RolloutSpecTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1RolloutSpecTemplateSpecContainersLifecycle? Lifecycle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1RolloutSpecTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1RolloutSpecTemplateSpecContainersPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessProbe")]
    public V1alpha1RolloutSpecTemplateSpecContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1RolloutSpecTemplateSpecContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public V1alpha1RolloutSpecTemplateSpecContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1RolloutSpecTemplateSpecContainersSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1RolloutSpecTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1RolloutSpecTemplateSpecContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1RolloutSpecTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecDnsConfigOptions
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
public partial class V1alpha1RolloutSpecTemplateSpecDnsConfig
{
    /// <summary></summary>
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("options")]
    public IList<V1alpha1RolloutSpecTemplateSpecDnsConfigOptions>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvFromSecretRef
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePostStartExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePostStart
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePreStopExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePreStop
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecycle
{
    /// <summary></summary>
    [JsonPropertyName("postStart")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preStop")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecyclePreStop? PreStop { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLivenessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLivenessProbeGrpc
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RolloutSpecTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersLivenessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLivenessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersPorts
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersReadinessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersReadinessProbeGrpc
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RolloutSpecTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersReadinessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersReadinessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersResizePolicy
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersResourcesClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersResources
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public IList<V1alpha1RolloutSpecTemplateSpecEphemeralContainersResourcesClaims>? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersSecurityContextCapabilities
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersStartupProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersStartupProbeGrpc
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersStartupProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RolloutSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersStartupProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersStartupProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersStartupProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersVolumeDevices
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainersVolumeMounts
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
public partial class V1alpha1RolloutSpecTemplateSpecEphemeralContainers
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envFrom")]
    public IList<V1alpha1RolloutSpecTemplateSpecEphemeralContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLifecycle? Lifecycle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1RolloutSpecTemplateSpecEphemeralContainersPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessProbe")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1RolloutSpecTemplateSpecEphemeralContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1RolloutSpecTemplateSpecEphemeralContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1RolloutSpecTemplateSpecEphemeralContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1RolloutSpecTemplateSpecEphemeralContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecHostAliases
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
public partial class V1alpha1RolloutSpecTemplateSpecImagePullSecrets
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersEnvValueFromFieldRef
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersEnvValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersEnvFromConfigMapRef
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersEnvFromSecretRef
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersEnvFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePostStartExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePostStartHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePostStartSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePostStart
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePreStopExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePreStopHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePreStopSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePreStop
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLifecycle
{
    /// <summary></summary>
    [JsonPropertyName("postStart")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preStop")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersLifecyclePreStop? PreStop { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLivenessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLivenessProbeGrpc
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLivenessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RolloutSpecTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLivenessProbeTcpSocket
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersLivenessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersLivenessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1RolloutSpecTemplateSpecInitContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersPorts
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersReadinessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersReadinessProbeGrpc
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersReadinessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RolloutSpecTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersReadinessProbeTcpSocket
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersReadinessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersReadinessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1RolloutSpecTemplateSpecInitContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersResizePolicy
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersResourcesClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersResources
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public IList<V1alpha1RolloutSpecTemplateSpecInitContainersResourcesClaims>? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersSecurityContextCapabilities
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersSecurityContextSeccompProfile
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersSecurityContextWindowsOptions
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1RolloutSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersStartupProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersStartupProbeGrpc
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersStartupProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RolloutSpecTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersStartupProbeTcpSocket
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersStartupProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersStartupProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersStartupProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1RolloutSpecTemplateSpecInitContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersVolumeDevices
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainersVolumeMounts
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
public partial class V1alpha1RolloutSpecTemplateSpecInitContainers
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1RolloutSpecTemplateSpecInitContainersEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envFrom")]
    public IList<V1alpha1RolloutSpecTemplateSpecInitContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersLifecycle? Lifecycle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1RolloutSpecTemplateSpecInitContainersPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessProbe")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1RolloutSpecTemplateSpecInitContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1RolloutSpecTemplateSpecInitContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1RolloutSpecTemplateSpecInitContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1RolloutSpecTemplateSpecInitContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecOs
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecReadinessGates
{
    /// <summary></summary>
    [JsonPropertyName("conditionType")]
    public string ConditionType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecResourceClaimsSource
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
public partial class V1alpha1RolloutSpecTemplateSpecResourceClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1RolloutSpecTemplateSpecResourceClaimsSource? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecSchedulingGates
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecSecurityContextSeLinuxOptions
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
public partial class V1alpha1RolloutSpecTemplateSpecSecurityContextSeccompProfile
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
public partial class V1alpha1RolloutSpecTemplateSpecSecurityContextSysctls
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
public partial class V1alpha1RolloutSpecTemplateSpecSecurityContextWindowsOptions
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
public partial class V1alpha1RolloutSpecTemplateSpecSecurityContext
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
    public V1alpha1RolloutSpecTemplateSpecSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1RolloutSpecTemplateSpecSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supplementalGroups")]
    public IList<long>? SupplementalGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sysctls")]
    public IList<V1alpha1RolloutSpecTemplateSpecSecurityContextSysctls>? Sysctls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1RolloutSpecTemplateSpecSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecTolerations
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
public partial class V1alpha1RolloutSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
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
public partial class V1alpha1RolloutSpecTemplateSpecTopologySpreadConstraintsLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1RolloutSpecTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplateSpecTopologySpreadConstraints
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1RolloutSpecTemplateSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

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
public partial class V1alpha1RolloutSpecTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("activeDeadlineSeconds")]
    public long? ActiveDeadlineSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("affinity")]
    public V1alpha1RolloutSpecTemplateSpecAffinity? Affinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("automountServiceAccountToken")]
    public bool? AutomountServiceAccountToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containers")]
    public IList<V1alpha1RolloutSpecTemplateSpecContainers> Containers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsConfig")]
    public V1alpha1RolloutSpecTemplateSpecDnsConfig? DnsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsPolicy")]
    public string? DnsPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ephemeralContainers")]
    public IList<V1alpha1RolloutSpecTemplateSpecEphemeralContainers>? EphemeralContainers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1alpha1RolloutSpecTemplateSpecHostAliases>? HostAliases { get; set; }

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
    public IList<V1alpha1RolloutSpecTemplateSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initContainers")]
    public IList<V1alpha1RolloutSpecTemplateSpecInitContainers>? InitContainers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeName")]
    public string? NodeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("os")]
    public V1alpha1RolloutSpecTemplateSpecOs? Os { get; set; }

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
    public IList<V1alpha1RolloutSpecTemplateSpecReadinessGates>? ReadinessGates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceClaims")]
    public IList<V1alpha1RolloutSpecTemplateSpecResourceClaims>? ResourceClaims { get; set; }

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
    public IList<V1alpha1RolloutSpecTemplateSpecSchedulingGates>? SchedulingGates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1RolloutSpecTemplateSpecSecurityContext? SecurityContext { get; set; }

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
    public IList<V1alpha1RolloutSpecTemplateSpecTolerations>? Tolerations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1alpha1RolloutSpecTemplateSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<JsonNode>? Volumes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1RolloutSpecTemplateMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1RolloutSpecTemplateSpec? Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpecWorkloadRef
{
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleDown")]
    public string? ScaleDown { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutSpec
{
    /// <summary></summary>
    [JsonPropertyName("analysis")]
    public V1alpha1RolloutSpecAnalysis? Analysis { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minReadySeconds")]
    public int? MinReadySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }

    /// <summary></summary>
    [JsonPropertyName("progressDeadlineAbort")]
    public bool? ProgressDeadlineAbort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("progressDeadlineSeconds")]
    public int? ProgressDeadlineSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartAt")]
    public string? RestartAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public int? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rollbackWindow")]
    public V1alpha1RolloutSpecRollbackWindow? RollbackWindow { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public V1alpha1RolloutSpecSelector? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("strategy")]
    public V1alpha1RolloutSpecStrategy? Strategy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1RolloutSpecTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workloadRef")]
    public V1alpha1RolloutSpecWorkloadRef? WorkloadRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusAlbCanaryTargetGroup
{
    /// <summary></summary>
    [JsonPropertyName("arn")]
    public string Arn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusAlbLoadBalancer
{
    /// <summary></summary>
    [JsonPropertyName("arn")]
    public string Arn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusAlbStableTargetGroup
{
    /// <summary></summary>
    [JsonPropertyName("arn")]
    public string Arn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusAlb
{
    /// <summary></summary>
    [JsonPropertyName("canaryTargetGroup")]
    public V1alpha1RolloutStatusAlbCanaryTargetGroup? CanaryTargetGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingress")]
    public string? Ingress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancer")]
    public V1alpha1RolloutStatusAlbLoadBalancer? LoadBalancer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stableTargetGroup")]
    public V1alpha1RolloutStatusAlbStableTargetGroup? StableTargetGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusAlbsCanaryTargetGroup
{
    /// <summary></summary>
    [JsonPropertyName("arn")]
    public string Arn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusAlbsLoadBalancer
{
    /// <summary></summary>
    [JsonPropertyName("arn")]
    public string Arn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusAlbsStableTargetGroup
{
    /// <summary></summary>
    [JsonPropertyName("arn")]
    public string Arn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusAlbs
{
    /// <summary></summary>
    [JsonPropertyName("canaryTargetGroup")]
    public V1alpha1RolloutStatusAlbsCanaryTargetGroup? CanaryTargetGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingress")]
    public string? Ingress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancer")]
    public V1alpha1RolloutStatusAlbsLoadBalancer? LoadBalancer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stableTargetGroup")]
    public V1alpha1RolloutStatusAlbsStableTargetGroup? StableTargetGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusBlueGreenPostPromotionAnalysisRunStatus
{
    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusBlueGreenPrePromotionAnalysisRunStatus
{
    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusBlueGreen
{
    /// <summary></summary>
    [JsonPropertyName("activeSelector")]
    public string? ActiveSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("postPromotionAnalysisRunStatus")]
    public V1alpha1RolloutStatusBlueGreenPostPromotionAnalysisRunStatus? PostPromotionAnalysisRunStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prePromotionAnalysisRunStatus")]
    public V1alpha1RolloutStatusBlueGreenPrePromotionAnalysisRunStatus? PrePromotionAnalysisRunStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("previewSelector")]
    public string? PreviewSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleUpPreviewCheckPoint")]
    public bool? ScaleUpPreviewCheckPoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusCanaryCurrentBackgroundAnalysisRunStatus
{
    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusCanaryCurrentStepAnalysisRunStatus
{
    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusCanaryWeightsAdditional
{
    /// <summary></summary>
    [JsonPropertyName("podTemplateHash")]
    public string? PodTemplateHash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusCanaryWeightsCanary
{
    /// <summary></summary>
    [JsonPropertyName("podTemplateHash")]
    public string? PodTemplateHash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusCanaryWeightsStable
{
    /// <summary></summary>
    [JsonPropertyName("podTemplateHash")]
    public string? PodTemplateHash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusCanaryWeights
{
    /// <summary></summary>
    [JsonPropertyName("additional")]
    public IList<V1alpha1RolloutStatusCanaryWeightsAdditional>? Additional { get; set; }

    /// <summary></summary>
    [JsonPropertyName("canary")]
    public V1alpha1RolloutStatusCanaryWeightsCanary Canary { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stable")]
    public V1alpha1RolloutStatusCanaryWeightsStable Stable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("verified")]
    public bool? Verified { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusCanary
{
    /// <summary></summary>
    [JsonPropertyName("currentBackgroundAnalysisRunStatus")]
    public V1alpha1RolloutStatusCanaryCurrentBackgroundAnalysisRunStatus? CurrentBackgroundAnalysisRunStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("currentExperiment")]
    public string? CurrentExperiment { get; set; }

    /// <summary></summary>
    [JsonPropertyName("currentStepAnalysisRunStatus")]
    public V1alpha1RolloutStatusCanaryCurrentStepAnalysisRunStatus? CurrentStepAnalysisRunStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stablePingPong")]
    public string? StablePingPong { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weights")]
    public V1alpha1RolloutStatusCanaryWeights? Weights { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusConditions
{
    /// <summary></summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastUpdateTime")]
    public string LastUpdateTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatusPauseConditions
{
    /// <summary></summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string StartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RolloutStatus
{
    /// <summary></summary>
    [JsonPropertyName("HPAReplicas")]
    public int? HPAReplicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("abort")]
    public bool? Abort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("abortedAt")]
    public string? AbortedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("alb")]
    public V1alpha1RolloutStatusAlb? Alb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("albs")]
    public IList<V1alpha1RolloutStatusAlbs>? Albs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("availableReplicas")]
    public int? AvailableReplicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("blueGreen")]
    public V1alpha1RolloutStatusBlueGreen? BlueGreen { get; set; }

    /// <summary></summary>
    [JsonPropertyName("canary")]
    public V1alpha1RolloutStatusCanary? Canary { get; set; }

    /// <summary></summary>
    [JsonPropertyName("collisionCount")]
    public int? CollisionCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RolloutStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("controllerPause")]
    public bool? ControllerPause { get; set; }

    /// <summary></summary>
    [JsonPropertyName("currentPodHash")]
    public string? CurrentPodHash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("currentStepHash")]
    public string? CurrentStepHash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("currentStepIndex")]
    public int? CurrentStepIndex { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("observedGeneration")]
    public string? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pauseConditions")]
    public IList<V1alpha1RolloutStatusPauseConditions>? PauseConditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary></summary>
    [JsonPropertyName("promoteFull")]
    public bool? PromoteFull { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readyReplicas")]
    public int? ReadyReplicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartedAt")]
    public string? RestartedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stableRS")]
    public string? StableRS { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedReplicas")]
    public int? UpdatedReplicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workloadObservedGeneration")]
    public string? WorkloadObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Rollout : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RolloutSpec>, IStatus<V1alpha1RolloutStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Rollout";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "rollouts";
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
    public V1alpha1RolloutSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1RolloutStatus? Status { get; set; }
}