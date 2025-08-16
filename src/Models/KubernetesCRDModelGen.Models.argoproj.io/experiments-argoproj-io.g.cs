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
public partial class V1alpha1ExperimentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Experiment>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ExperimentList";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "experiments";
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
    public IList<V1alpha1Experiment> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecAnalysesArgsValueFromFieldRef
{
    /// <summary></summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecAnalysesArgsValueFromSecretKeyRef
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
public partial class V1alpha1ExperimentSpecAnalysesArgsValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1ExperimentSpecAnalysesArgsValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ExperimentSpecAnalysesArgsValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecAnalysesArgs
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1ExperimentSpecAnalysesArgsValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecAnalyses
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<V1alpha1ExperimentSpecAnalysesArgs>? Args { get; set; }

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
public partial class V1alpha1ExperimentSpecAnalysisRunMetadata
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
public partial class V1alpha1ExperimentSpecDryRun
{
    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string MetricName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecMeasurementRetention
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
public partial class V1alpha1ExperimentSpecTemplatesSelectorMatchExpressions
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
public partial class V1alpha1ExperimentSpecTemplatesSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ExperimentSpecTemplatesSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesService
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateMetadata
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchFields")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("preference")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchFields")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinity
{
    /// <summary></summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecAffinity
{
    /// <summary></summary>
    [JsonPropertyName("nodeAffinity")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podAffinity")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvValueFromFieldRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvFromConfigMapRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvFromSecretRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePostStartExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePostStartHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePostStartSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePostStartTcpSocket
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePostStart
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePreStopExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePreStopHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePreStopSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePreStopTcpSocket
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePreStop
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecycle
{
    /// <summary></summary>
    [JsonPropertyName("postStart")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preStop")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecyclePreStop? PreStop { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLivenessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLivenessProbeGrpc
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLivenessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLivenessProbeTcpSocket
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLivenessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersPorts
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersReadinessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersReadinessProbeGrpc
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersReadinessProbeHttpGetHttpHeaders
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersReadinessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersReadinessProbeTcpSocket
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersReadinessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersReadinessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersResizePolicy
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersResourcesClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersResources
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecContainersResourcesClaims>? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersSecurityContextCapabilities
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersSecurityContextSeccompProfile
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersSecurityContextWindowsOptions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersStartupProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersStartupProbeGrpc
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersStartupProbeHttpGetHttpHeaders
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersStartupProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersStartupProbeTcpSocket
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersStartupProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersStartupProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersVolumeDevices
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainersVolumeMounts
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecContainers
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envFrom")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLifecycle? Lifecycle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecContainersPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessProbe")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecDnsConfigOptions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecDnsConfig
{
    /// <summary></summary>
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("options")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecDnsConfigOptions>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvValueFromFieldRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvFromConfigMapRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvFromSecretRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePostStartExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePostStartHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePostStartSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePostStart
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePreStopExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePreStopHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePreStopSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePreStop
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecycle
{
    /// <summary></summary>
    [JsonPropertyName("postStart")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preStop")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecyclePreStop? PreStop { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLivenessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLivenessProbeGrpc
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLivenessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLivenessProbeTcpSocket
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLivenessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLivenessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersPorts
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersReadinessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersReadinessProbeGrpc
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersReadinessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersReadinessProbeTcpSocket
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersReadinessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersReadinessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersResizePolicy
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersResourcesClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersResources
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersResourcesClaims>? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersSecurityContextCapabilities
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersSecurityContextSeccompProfile
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersSecurityContextWindowsOptions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersStartupProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersStartupProbeGrpc
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersStartupProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersStartupProbeTcpSocket
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersStartupProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersStartupProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersStartupProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersVolumeDevices
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersVolumeMounts
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainers
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envFrom")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLifecycle? Lifecycle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessProbe")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecHostAliases
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecImagePullSecrets
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvValueFromConfigMapKeyRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvValueFromFieldRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvValueFromResourceFieldRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvValueFromSecretKeyRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fieldRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvFromConfigMapRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvFromSecretRef
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePostStartExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePostStartHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePostStartHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePostStartSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePostStartTcpSocket
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePostStart
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePostStartExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePostStartHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePostStartSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePostStartTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePreStopExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePreStopHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePreStopHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePreStopSleep
{
    /// <summary></summary>
    [JsonPropertyName("seconds")]
    public long Seconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePreStopTcpSocket
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePreStop
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePreStopExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePreStopHttpGet? HttpGet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sleep")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePreStopSleep? Sleep { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePreStopTcpSocket? TcpSocket { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecycle
{
    /// <summary></summary>
    [JsonPropertyName("postStart")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePostStart? PostStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preStop")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecyclePreStop? PreStop { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLivenessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLivenessProbeGrpc
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLivenessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLivenessProbeTcpSocket
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLivenessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLivenessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLivenessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersPorts
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersReadinessProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersReadinessProbeGrpc
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersReadinessProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersReadinessProbeTcpSocket
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersReadinessProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersReadinessProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersReadinessProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersReadinessProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersReadinessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersResizePolicy
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersResourcesClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersResources
{
    /// <summary></summary>
    [JsonPropertyName("claims")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersResourcesClaims>? Claims { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limits")]
    public JsonNode? Limits { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requests")]
    public JsonNode? Requests { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersSecurityContextCapabilities
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersSecurityContextSeLinuxOptions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersSecurityContextSeccompProfile
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersSecurityContextWindowsOptions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersSecurityContext
{
    /// <summary></summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersStartupProbeExec
{
    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersStartupProbeGrpc
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersStartupProbeHttpGet
{
    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersStartupProbeTcpSocket
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersStartupProbe
{
    /// <summary></summary>
    [JsonPropertyName("exec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersStartupProbeExec? Exec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("grpc")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersStartupProbeHttpGet? HttpGet { get; set; }

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
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersVolumeDevices
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersVolumeMounts
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainers
{
    /// <summary></summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary></summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envFrom")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLifecycle? Lifecycle { get; set; }

    /// <summary></summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readinessProbe")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resizePolicy")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersResizePolicy>? ResizePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersResources? Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersSecurityContext? SecurityContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersStartupProbe? StartupProbe { get; set; }

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
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersVolumeDevices>? VolumeDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecOs
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecReadinessGates
{
    /// <summary></summary>
    [JsonPropertyName("conditionType")]
    public string ConditionType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecResourceClaimsSource
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecResourceClaims
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecResourceClaimsSource? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecSchedulingGates
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecSecurityContextSeLinuxOptions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecSecurityContextSeccompProfile
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecSecurityContextSysctls
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecSecurityContextWindowsOptions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecSecurityContext
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
    public V1alpha1ExperimentSpecTemplatesTemplateSpecSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("seccompProfile")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecSecurityContextSeccompProfile? SeccompProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supplementalGroups")]
    public IList<long>? SupplementalGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sysctls")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecSecurityContextSysctls>? Sysctls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("windowsOptions")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecTolerations
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecTopologySpreadConstraintsLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpecTopologySpreadConstraints
{
    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

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
public partial class V1alpha1ExperimentSpecTemplatesTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("activeDeadlineSeconds")]
    public long? ActiveDeadlineSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("affinity")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecAffinity? Affinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("automountServiceAccountToken")]
    public bool? AutomountServiceAccountToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containers")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecContainers> Containers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsConfig")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecDnsConfig? DnsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsPolicy")]
    public string? DnsPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ephemeralContainers")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecEphemeralContainers>? EphemeralContainers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecHostAliases>? HostAliases { get; set; }

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
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initContainers")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecInitContainers>? InitContainers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeName")]
    public string? NodeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("os")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecOs? Os { get; set; }

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
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecReadinessGates>? ReadinessGates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceClaims")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecResourceClaims>? ResourceClaims { get; set; }

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
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecSchedulingGates>? SchedulingGates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityContext")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpecSecurityContext? SecurityContext { get; set; }

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
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecTolerations>? Tolerations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1alpha1ExperimentSpecTemplatesTemplateSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public JsonNode? Volumes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplatesTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ExperimentSpecTemplatesTemplateMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ExperimentSpecTemplatesTemplateSpec? Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpecTemplates
{
    /// <summary></summary>
    [JsonPropertyName("minReadySeconds")]
    public int? MinReadySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public V1alpha1ExperimentSpecTemplatesSelector Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("service")]
    public V1alpha1ExperimentSpecTemplatesService? Service { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ExperimentSpecTemplatesTemplate Template { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentSpec
{
    /// <summary></summary>
    [JsonPropertyName("analyses")]
    public IList<V1alpha1ExperimentSpecAnalyses>? Analyses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("analysisRunMetadata")]
    public V1alpha1ExperimentSpecAnalysisRunMetadata? AnalysisRunMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dryRun")]
    public IList<V1alpha1ExperimentSpecDryRun>? DryRun { get; set; }

    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("measurementRetention")]
    public IList<V1alpha1ExperimentSpecMeasurementRetention>? MeasurementRetention { get; set; }

    /// <summary></summary>
    [JsonPropertyName("progressDeadlineSeconds")]
    public int? ProgressDeadlineSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleDownDelaySeconds")]
    public int? ScaleDownDelaySeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templates")]
    public IList<V1alpha1ExperimentSpecTemplates> Templates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminate")]
    public bool? Terminate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentStatusAnalysisRuns
{
    /// <summary></summary>
    [JsonPropertyName("analysisRun")]
    public string AnalysisRun { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phase")]
    public string Phase { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentStatusConditions
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
public partial class V1alpha1ExperimentStatusTemplateStatuses
{
    /// <summary></summary>
    [JsonPropertyName("availableReplicas")]
    public int AvailableReplicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("collisionCount")]
    public int? CollisionCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podTemplateHash")]
    public string? PodTemplateHash { get; set; }

    /// <summary></summary>
    [JsonPropertyName("readyReplicas")]
    public int ReadyReplicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public int Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedReplicas")]
    public int UpdatedReplicas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ExperimentStatus
{
    /// <summary></summary>
    [JsonPropertyName("analysisRuns")]
    public IList<V1alpha1ExperimentStatusAnalysisRuns>? AnalysisRuns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("availableAt")]
    public string? AvailableAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ExperimentStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templateStatuses")]
    public IList<V1alpha1ExperimentStatusTemplateStatuses>? TemplateStatuses { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Experiment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ExperimentSpec>, IStatus<V1alpha1ExperimentStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Experiment";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "experiments";
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
    public V1alpha1ExperimentSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1ExperimentStatus? Status { get; set; }
}