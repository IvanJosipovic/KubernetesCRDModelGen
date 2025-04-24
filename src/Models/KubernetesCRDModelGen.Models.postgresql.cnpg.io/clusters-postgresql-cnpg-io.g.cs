using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecAffinityAdditionalPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecAffinityAdditionalPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1ClusterSpecAffinityAdditionalPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1ClusterSpecAffinityAdditionalPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1ClusterSpecAffinityAdditionalPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecAffinityAdditionalPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecAffinityAdditionalPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1ClusterSpecAffinityAdditionalPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1ClusterSpecAffinityAdditionalPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>AdditionalPodAffinity allows to specify pod affinity terms to be passed to all the cluster's pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1ClusterSpecAffinityAdditionalPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1ClusterSpecAffinityAdditionalPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecAffinityAdditionalPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecAffinityAdditionalPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1ClusterSpecAffinityAdditionalPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1ClusterSpecAffinityAdditionalPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1ClusterSpecAffinityAdditionalPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecAffinityAdditionalPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecAffinityAdditionalPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1ClusterSpecAffinityAdditionalPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key in (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with `labelSelector` as `key notin (value)` to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is a beta field and requires enabling MatchLabelKeysInPodAffinity feature gate (enabled by default).</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1ClusterSpecAffinityAdditionalPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>AdditionalPodAntiAffinity allows to specify pod anti-affinity terms to be added to the ones generated by the operator if EnablePodAntiAffinity is set to true (default) or to be used exclusively if set to false.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityAdditionalPodAntiAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1ClusterSpecAffinityAdditionalPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1ClusterSpecAffinityAdditionalPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary>A list of node selector requirements by node's labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node's fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1ClusterSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary>An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A node selector term, associated with the corresponding weight.</summary>
    [JsonPropertyName("preference")]
    public V1ClusterSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary>A list of node selector requirements by node's labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node's fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1ClusterSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

/// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1ClusterSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary>NodeAffinity describes node affinity scheduling rules for the pod. More info: https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#node-affinity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityNodeAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1ClusterSpecAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1ClusterSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>The pod this Toleration is attached to tolerates any taint that matches the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinityTolerations
{
    /// <summary>Effect indicates the taint effect to match. Empty means match all taint effects. When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Key is the taint key that the toleration applies to. Empty means match all taint keys. If the key is empty, operator must be Exists; this combination means to match all values and all keys.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Operator represents a key's relationship to the value. Valid operators are Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value, so that a pod can tolerate all taints of a particular category.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>TolerationSeconds represents the period of time the toleration (which must be of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default, it is not set, which means tolerate the taint forever (do not evict). Zero and negative values will be treated as 0 (evict immediately) by the system.</summary>
    [JsonPropertyName("tolerationSeconds")]
    public long? TolerationSeconds { get; set; }

    /// <summary>Value is the taint value the toleration matches to. If the operator is Exists, the value should be empty, otherwise just a regular string.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Affinity/Anti-affinity rules for Pods</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecAffinity
{
    /// <summary>AdditionalPodAffinity allows to specify pod affinity terms to be passed to all the cluster's pods.</summary>
    [JsonPropertyName("additionalPodAffinity")]
    public V1ClusterSpecAffinityAdditionalPodAffinity? AdditionalPodAffinity { get; set; }

    /// <summary>AdditionalPodAntiAffinity allows to specify pod anti-affinity terms to be added to the ones generated by the operator if EnablePodAntiAffinity is set to true (default) or to be used exclusively if set to false.</summary>
    [JsonPropertyName("additionalPodAntiAffinity")]
    public V1ClusterSpecAffinityAdditionalPodAntiAffinity? AdditionalPodAntiAffinity { get; set; }

    /// <summary>Activates anti-affinity for the pods. The operator will define pods anti-affinity unless this field is explicitly set to false</summary>
    [JsonPropertyName("enablePodAntiAffinity")]
    public bool? EnablePodAntiAffinity { get; set; }

    /// <summary>NodeAffinity describes node affinity scheduling rules for the pod. More info: https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#node-affinity</summary>
    [JsonPropertyName("nodeAffinity")]
    public V1ClusterSpecAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary>NodeSelector is map of key-value pairs used to define the nodes on which the pods can run. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>PodAntiAffinityType allows the user to decide whether pod anti-affinity between cluster instance has to be considered a strong requirement during scheduling or not. Allowed values are: "preferred" (default if empty) or "required". Setting it to "required", could lead to instances remaining pending until new kubernetes nodes are added if all the existing nodes don't match the required pod anti-affinity rule. More info: https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#inter-pod-affinity-and-anti-affinity</summary>
    [JsonPropertyName("podAntiAffinityType")]
    public string? PodAntiAffinityType { get; set; }

    /// <summary>Tolerations is a list of Tolerations that should be set for all the pods, in order to allow them to run on tainted nodes. More info: https://kubernetes.io/docs/concepts/scheduling-eviction/taint-and-toleration/</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1ClusterSpecAffinityTolerations>? Tolerations { get; set; }

    /// <summary>TopologyKey to use for anti-affinity configuration. See k8s documentation for more info on that</summary>
    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

/// <summary>The connection string to be used</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStoreAzureCredentialsConnectionString
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The storage account where to upload data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStoreAzureCredentialsStorageAccount
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The storage account key to be used in conjunction with the storage account name</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStoreAzureCredentialsStorageKey
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A shared-access-signature to be used in conjunction with the storage account name</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStoreAzureCredentialsStorageSasToken
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The credentials to use to upload data to Azure Blob Storage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStoreAzureCredentials
{
    /// <summary>The connection string to be used</summary>
    [JsonPropertyName("connectionString")]
    public V1ClusterSpecBackupBarmanObjectStoreAzureCredentialsConnectionString? ConnectionString { get; set; }

    /// <summary>Use the Azure AD based authentication without providing explicitly the keys.</summary>
    [JsonPropertyName("inheritFromAzureAD")]
    public bool? InheritFromAzureAD { get; set; }

    /// <summary>The storage account where to upload data</summary>
    [JsonPropertyName("storageAccount")]
    public V1ClusterSpecBackupBarmanObjectStoreAzureCredentialsStorageAccount? StorageAccount { get; set; }

    /// <summary>The storage account key to be used in conjunction with the storage account name</summary>
    [JsonPropertyName("storageKey")]
    public V1ClusterSpecBackupBarmanObjectStoreAzureCredentialsStorageKey? StorageKey { get; set; }

    /// <summary>A shared-access-signature to be used in conjunction with the storage account name</summary>
    [JsonPropertyName("storageSasToken")]
    public V1ClusterSpecBackupBarmanObjectStoreAzureCredentialsStorageSasToken? StorageSasToken { get; set; }
}

/// <summary>The configuration to be used to backup the data files When not defined, base backups files will be stored uncompressed and may be unencrypted in the object store, according to the bucket default policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStoreData
{
    /// <summary>AdditionalCommandArgs represents additional arguments that can be appended to the 'barman-cloud-backup' command-line invocation. These arguments provide flexibility to customize the backup process further according to specific requirements or configurations.  Example: In a scenario where specialized backup options are required, such as setting a specific timeout or defining custom behavior, users can use this field to specify additional command arguments.  Note: It's essential to ensure that the provided arguments are valid and supported by the 'barman-cloud-backup' command, to avoid potential errors or unintended behavior during execution.</summary>
    [JsonPropertyName("additionalCommandArgs")]
    public IList<string>? AdditionalCommandArgs { get; set; }

    /// <summary>Compress a backup file (a tar file per tablespace) while streaming it to the object store. Available options are empty string (no compression, default), `gzip`, `bzip2` or `snappy`.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>Whenever to force the encryption of files (if the bucket is not already configured for that). Allowed options are empty string (use the bucket policy, default), `AES256` and `aws:kms`</summary>
    [JsonPropertyName("encryption")]
    public string? Encryption { get; set; }

    /// <summary>Control whether the I/O workload for the backup initial checkpoint will be limited, according to the `checkpoint_completion_target` setting on the PostgreSQL server. If set to true, an immediate checkpoint will be used, meaning PostgreSQL will complete the checkpoint as soon as possible. `false` by default.</summary>
    [JsonPropertyName("immediateCheckpoint")]
    public bool? ImmediateCheckpoint { get; set; }

    /// <summary>The number of parallel jobs to be used to upload the backup, defaults to 2</summary>
    [JsonPropertyName("jobs")]
    public int? Jobs { get; set; }
}

/// <summary>EndpointCA store the CA bundle of the barman endpoint. Useful when using self-signed certificates to avoid errors with certificate issuer and barman-cloud-wal-archive</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStoreEndpointCA
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The secret containing the Google Cloud Storage JSON file with the credentials</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStoreGoogleCredentialsApplicationCredentials
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The credentials to use to upload data to Google Cloud Storage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStoreGoogleCredentials
{
    /// <summary>The secret containing the Google Cloud Storage JSON file with the credentials</summary>
    [JsonPropertyName("applicationCredentials")]
    public V1ClusterSpecBackupBarmanObjectStoreGoogleCredentialsApplicationCredentials? ApplicationCredentials { get; set; }

    /// <summary>If set to true, will presume that it's running inside a GKE environment, default to false.</summary>
    [JsonPropertyName("gkeEnvironment")]
    public bool? GkeEnvironment { get; set; }
}

/// <summary>The reference to the access key id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStoreS3CredentialsAccessKeyId
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The reference to the secret containing the region name</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStoreS3CredentialsRegion
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The reference to the secret access key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStoreS3CredentialsSecretAccessKey
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The references to the session key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStoreS3CredentialsSessionToken
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The credentials to use to upload data to S3</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStoreS3Credentials
{
    /// <summary>The reference to the access key id</summary>
    [JsonPropertyName("accessKeyId")]
    public V1ClusterSpecBackupBarmanObjectStoreS3CredentialsAccessKeyId? AccessKeyId { get; set; }

    /// <summary>Use the role based authentication without providing explicitly the keys.</summary>
    [JsonPropertyName("inheritFromIAMRole")]
    public bool? InheritFromIAMRole { get; set; }

    /// <summary>The reference to the secret containing the region name</summary>
    [JsonPropertyName("region")]
    public V1ClusterSpecBackupBarmanObjectStoreS3CredentialsRegion? Region { get; set; }

    /// <summary>The reference to the secret access key</summary>
    [JsonPropertyName("secretAccessKey")]
    public V1ClusterSpecBackupBarmanObjectStoreS3CredentialsSecretAccessKey? SecretAccessKey { get; set; }

    /// <summary>The references to the session key</summary>
    [JsonPropertyName("sessionToken")]
    public V1ClusterSpecBackupBarmanObjectStoreS3CredentialsSessionToken? SessionToken { get; set; }
}

/// <summary>The configuration for the backup of the WAL stream. When not defined, WAL files will be stored uncompressed and may be unencrypted in the object store, according to the bucket default policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStoreWal
{
    /// <summary>Additional arguments that can be appended to the 'barman-cloud-wal-archive' command-line invocation. These arguments provide flexibility to customize the WAL archive process further, according to specific requirements or configurations.  Example: In a scenario where specialized backup options are required, such as setting a specific timeout or defining custom behavior, users can use this field to specify additional command arguments.  Note: It's essential to ensure that the provided arguments are valid and supported by the 'barman-cloud-wal-archive' command, to avoid potential errors or unintended behavior during execution.</summary>
    [JsonPropertyName("archiveAdditionalCommandArgs")]
    public IList<string>? ArchiveAdditionalCommandArgs { get; set; }

    /// <summary>Compress a WAL file before sending it to the object store. Available options are empty string (no compression, default), `gzip`, `bzip2` or `snappy`.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>Whenever to force the encryption of files (if the bucket is not already configured for that). Allowed options are empty string (use the bucket policy, default), `AES256` and `aws:kms`</summary>
    [JsonPropertyName("encryption")]
    public string? Encryption { get; set; }

    /// <summary>Number of WAL files to be either archived in parallel (when the PostgreSQL instance is archiving to a backup object store) or restored in parallel (when a PostgreSQL standby is fetching WAL files from a recovery object store). If not specified, WAL files will be processed one at a time. It accepts a positive integer as a value - with 1 being the minimum accepted value.</summary>
    [JsonPropertyName("maxParallel")]
    public int? MaxParallel { get; set; }

    /// <summary>Additional arguments that can be appended to the 'barman-cloud-wal-restore' command-line invocation. These arguments provide flexibility to customize the WAL restore process further, according to specific requirements or configurations.  Example: In a scenario where specialized backup options are required, such as setting a specific timeout or defining custom behavior, users can use this field to specify additional command arguments.  Note: It's essential to ensure that the provided arguments are valid and supported by the 'barman-cloud-wal-restore' command, to avoid potential errors or unintended behavior during execution.</summary>
    [JsonPropertyName("restoreAdditionalCommandArgs")]
    public IList<string>? RestoreAdditionalCommandArgs { get; set; }
}

/// <summary>The configuration for the barman-cloud tool suite</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupBarmanObjectStore
{
    /// <summary>The credentials to use to upload data to Azure Blob Storage</summary>
    [JsonPropertyName("azureCredentials")]
    public V1ClusterSpecBackupBarmanObjectStoreAzureCredentials? AzureCredentials { get; set; }

    /// <summary>The configuration to be used to backup the data files When not defined, base backups files will be stored uncompressed and may be unencrypted in the object store, according to the bucket default policy.</summary>
    [JsonPropertyName("data")]
    public V1ClusterSpecBackupBarmanObjectStoreData? Data { get; set; }

    /// <summary>The path where to store the backup (i.e. s3://bucket/path/to/folder) this path, with different destination folders, will be used for WALs and for data</summary>
    [JsonPropertyName("destinationPath")]
    public string DestinationPath { get; set; }

    /// <summary>EndpointCA store the CA bundle of the barman endpoint. Useful when using self-signed certificates to avoid errors with certificate issuer and barman-cloud-wal-archive</summary>
    [JsonPropertyName("endpointCA")]
    public V1ClusterSpecBackupBarmanObjectStoreEndpointCA? EndpointCA { get; set; }

    /// <summary>Endpoint to be used to upload data to the cloud, overriding the automatic endpoint discovery</summary>
    [JsonPropertyName("endpointURL")]
    public string? EndpointURL { get; set; }

    /// <summary>The credentials to use to upload data to Google Cloud Storage</summary>
    [JsonPropertyName("googleCredentials")]
    public V1ClusterSpecBackupBarmanObjectStoreGoogleCredentials? GoogleCredentials { get; set; }

    /// <summary>HistoryTags is a list of key value pairs that will be passed to the Barman --history-tags option.</summary>
    [JsonPropertyName("historyTags")]
    public IDictionary<string, string>? HistoryTags { get; set; }

    /// <summary>The credentials to use to upload data to S3</summary>
    [JsonPropertyName("s3Credentials")]
    public V1ClusterSpecBackupBarmanObjectStoreS3Credentials? S3Credentials { get; set; }

    /// <summary>The server name on S3, the cluster name is used if this parameter is omitted</summary>
    [JsonPropertyName("serverName")]
    public string? ServerName { get; set; }

    /// <summary>Tags is a list of key value pairs that will be passed to the Barman --tags option.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The configuration for the backup of the WAL stream. When not defined, WAL files will be stored uncompressed and may be unencrypted in the object store, according to the bucket default policy.</summary>
    [JsonPropertyName("wal")]
    public V1ClusterSpecBackupBarmanObjectStoreWal? Wal { get; set; }
}

/// <summary>Configuration parameters to control the online/hot backup with volume snapshots</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupVolumeSnapshotOnlineConfiguration
{
    /// <summary>Control whether the I/O workload for the backup initial checkpoint will be limited, according to the `checkpoint_completion_target` setting on the PostgreSQL server. If set to true, an immediate checkpoint will be used, meaning PostgreSQL will complete the checkpoint as soon as possible. `false` by default.</summary>
    [JsonPropertyName("immediateCheckpoint")]
    public bool? ImmediateCheckpoint { get; set; }

    /// <summary>If false, the function will return immediately after the backup is completed, without waiting for WAL to be archived. This behavior is only useful with backup software that independently monitors WAL archiving. Otherwise, WAL required to make the backup consistent might be missing and make the backup useless. By default, or when this parameter is true, pg_backup_stop will wait for WAL to be archived when archiving is enabled. On a standby, this means that it will wait only when archive_mode = always. If write activity on the primary is low, it may be useful to run pg_switch_wal on the primary in order to trigger an immediate segment switch.</summary>
    [JsonPropertyName("waitForArchive")]
    public bool? WaitForArchive { get; set; }
}

/// <summary>VolumeSnapshot provides the configuration for the execution of volume snapshot backups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackupVolumeSnapshot
{
    /// <summary>Annotations key-value pairs that will be added to .metadata.annotations snapshot resources.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>ClassName specifies the Snapshot Class to be used for PG_DATA PersistentVolumeClaim. It is the default class for the other types if no specific class is present</summary>
    [JsonPropertyName("className")]
    public string? ClassName { get; set; }

    /// <summary>Labels are key-value pairs that will be added to .metadata.labels snapshot resources.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Whether the default type of backup with volume snapshots is online/hot (`true`, default) or offline/cold (`false`)</summary>
    [JsonPropertyName("online")]
    public bool? Online { get; set; }

    /// <summary>Configuration parameters to control the online/hot backup with volume snapshots</summary>
    [JsonPropertyName("onlineConfiguration")]
    public V1ClusterSpecBackupVolumeSnapshotOnlineConfiguration? OnlineConfiguration { get; set; }

    /// <summary>SnapshotOwnerReference indicates the type of owner reference the snapshot should have</summary>
    [JsonPropertyName("snapshotOwnerReference")]
    public string? SnapshotOwnerReference { get; set; }

    /// <summary>TablespaceClassName specifies the Snapshot Class to be used for the tablespaces. defaults to the PGDATA Snapshot Class, if set</summary>
    [JsonPropertyName("tablespaceClassName")]
    public IDictionary<string, string>? TablespaceClassName { get; set; }

    /// <summary>WalClassName specifies the Snapshot Class to be used for the PG_WAL PersistentVolumeClaim.</summary>
    [JsonPropertyName("walClassName")]
    public string? WalClassName { get; set; }
}

/// <summary>The configuration to be used for backups</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBackup
{
    /// <summary>The configuration for the barman-cloud tool suite</summary>
    [JsonPropertyName("barmanObjectStore")]
    public V1ClusterSpecBackupBarmanObjectStore? BarmanObjectStore { get; set; }

    /// <summary>RetentionPolicy is the retention policy to be used for backups and WALs (i.e. '60d'). The retention policy is expressed in the form of `XXu` where `XX` is a positive integer and `u` is in `[dwm]` - days, weeks, months. It's currently only applicable when using the BarmanObjectStore method.</summary>
    [JsonPropertyName("retentionPolicy")]
    public string? RetentionPolicy { get; set; }

    /// <summary>The policy to decide which instance should perform backups. Available options are empty string, which will default to `prefer-standby` policy, `primary` to have backups run always on primary instances, `prefer-standby` to have backups run preferably on the most updated standby, if available.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>VolumeSnapshot provides the configuration for the execution of volume snapshot backups.</summary>
    [JsonPropertyName("volumeSnapshot")]
    public V1ClusterSpecBackupVolumeSnapshot? VolumeSnapshot { get; set; }
}

/// <summary>The source of the import</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapInitdbImportSource
{
    /// <summary>The name of the externalCluster used for import</summary>
    [JsonPropertyName("externalCluster")]
    public string ExternalCluster { get; set; }
}

/// <summary>Bootstraps the new cluster by importing data from an existing PostgreSQL instance using logical backup (`pg_dump` and `pg_restore`)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapInitdbImport
{
    /// <summary>The databases to import</summary>
    [JsonPropertyName("databases")]
    public IList<string> Databases { get; set; }

    /// <summary>List of custom options to pass to the `pg_dump` command. IMPORTANT: Use these options with caution and at your own risk, as the operator does not validate their content. Be aware that certain options may conflict with the operator's intended functionality or design.</summary>
    [JsonPropertyName("pgDumpExtraOptions")]
    public IList<string>? PgDumpExtraOptions { get; set; }

    /// <summary>List of custom options to pass to the `pg_restore` command. IMPORTANT: Use these options with caution and at your own risk, as the operator does not validate their content. Be aware that certain options may conflict with the operator's intended functionality or design.</summary>
    [JsonPropertyName("pgRestoreExtraOptions")]
    public IList<string>? PgRestoreExtraOptions { get; set; }

    /// <summary>List of SQL queries to be executed as a superuser in the application database right after is imported - to be used with extreme care (by default empty). Only available in microservice type.</summary>
    [JsonPropertyName("postImportApplicationSQL")]
    public IList<string>? PostImportApplicationSQL { get; set; }

    /// <summary>The roles to import</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>When set to true, only the `pre-data` and `post-data` sections of `pg_restore` are invoked, avoiding data import. Default: `false`.</summary>
    [JsonPropertyName("schemaOnly")]
    public bool? SchemaOnly { get; set; }

    /// <summary>The source of the import</summary>
    [JsonPropertyName("source")]
    public V1ClusterSpecBootstrapInitdbImportSource Source { get; set; }

    /// <summary>The import type. Can be `microservice` or `monolith`.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>ConfigMapKeySelector contains enough information to let you locate the key of a ConfigMap</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapInitdbPostInitApplicationSQLRefsConfigMapRefs
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretKeySelector contains enough information to let you locate the key of a Secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapInitdbPostInitApplicationSQLRefsSecretRefs
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>List of references to ConfigMaps or Secrets containing SQL files to be executed as a superuser in the application database right after the cluster has been created. The references are processed in a specific order: first, all Secrets are processed, followed by all ConfigMaps. Within each group, the processing order follows the sequence specified in their respective arrays. (by default empty)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapInitdbPostInitApplicationSQLRefs
{
    /// <summary>ConfigMapRefs holds a list of references to ConfigMaps</summary>
    [JsonPropertyName("configMapRefs")]
    public IList<V1ClusterSpecBootstrapInitdbPostInitApplicationSQLRefsConfigMapRefs>? ConfigMapRefs { get; set; }

    /// <summary>SecretRefs holds a list of references to Secrets</summary>
    [JsonPropertyName("secretRefs")]
    public IList<V1ClusterSpecBootstrapInitdbPostInitApplicationSQLRefsSecretRefs>? SecretRefs { get; set; }
}

/// <summary>ConfigMapKeySelector contains enough information to let you locate the key of a ConfigMap</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapInitdbPostInitSQLRefsConfigMapRefs
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretKeySelector contains enough information to let you locate the key of a Secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapInitdbPostInitSQLRefsSecretRefs
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>List of references to ConfigMaps or Secrets containing SQL files to be executed as a superuser in the `postgres` database right after the cluster has been created. The references are processed in a specific order: first, all Secrets are processed, followed by all ConfigMaps. Within each group, the processing order follows the sequence specified in their respective arrays. (by default empty)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapInitdbPostInitSQLRefs
{
    /// <summary>ConfigMapRefs holds a list of references to ConfigMaps</summary>
    [JsonPropertyName("configMapRefs")]
    public IList<V1ClusterSpecBootstrapInitdbPostInitSQLRefsConfigMapRefs>? ConfigMapRefs { get; set; }

    /// <summary>SecretRefs holds a list of references to Secrets</summary>
    [JsonPropertyName("secretRefs")]
    public IList<V1ClusterSpecBootstrapInitdbPostInitSQLRefsSecretRefs>? SecretRefs { get; set; }
}

/// <summary>ConfigMapKeySelector contains enough information to let you locate the key of a ConfigMap</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapInitdbPostInitTemplateSQLRefsConfigMapRefs
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretKeySelector contains enough information to let you locate the key of a Secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapInitdbPostInitTemplateSQLRefsSecretRefs
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>List of references to ConfigMaps or Secrets containing SQL files to be executed as a superuser in the `template1` database right after the cluster has been created. The references are processed in a specific order: first, all Secrets are processed, followed by all ConfigMaps. Within each group, the processing order follows the sequence specified in their respective arrays. (by default empty)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapInitdbPostInitTemplateSQLRefs
{
    /// <summary>ConfigMapRefs holds a list of references to ConfigMaps</summary>
    [JsonPropertyName("configMapRefs")]
    public IList<V1ClusterSpecBootstrapInitdbPostInitTemplateSQLRefsConfigMapRefs>? ConfigMapRefs { get; set; }

    /// <summary>SecretRefs holds a list of references to Secrets</summary>
    [JsonPropertyName("secretRefs")]
    public IList<V1ClusterSpecBootstrapInitdbPostInitTemplateSQLRefsSecretRefs>? SecretRefs { get; set; }
}

/// <summary>Name of the secret containing the initial credentials for the owner of the user database. If empty a new secret will be created from scratch</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapInitdbSecret
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Bootstrap the cluster via initdb</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapInitdb
{
    /// <summary>Specifies the locale name when the builtin provider is used. This option requires `localeProvider` to be set to `builtin`. Available from PostgreSQL 17.</summary>
    [JsonPropertyName("builtinLocale")]
    public string? BuiltinLocale { get; set; }

    /// <summary>Whether the `-k` option should be passed to initdb, enabling checksums on data pages (default: `false`)</summary>
    [JsonPropertyName("dataChecksums")]
    public bool? DataChecksums { get; set; }

    /// <summary>Name of the database used by the application. Default: `app`.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>The value to be passed as option `--encoding` for initdb (default:`UTF8`)</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Specifies the ICU locale when the ICU provider is used. This option requires `localeProvider` to be set to `icu`. Available from PostgreSQL 15.</summary>
    [JsonPropertyName("icuLocale")]
    public string? IcuLocale { get; set; }

    /// <summary>Specifies additional collation rules to customize the behavior of the default collation. This option requires `localeProvider` to be set to `icu`. Available from PostgreSQL 16.</summary>
    [JsonPropertyName("icuRules")]
    public string? IcuRules { get; set; }

    /// <summary>Bootstraps the new cluster by importing data from an existing PostgreSQL instance using logical backup (`pg_dump` and `pg_restore`)</summary>
    [JsonPropertyName("import")]
    public V1ClusterSpecBootstrapInitdbImport? Import { get; set; }

    /// <summary>Sets the default collation order and character classification in the new database.</summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>The value to be passed as option `--lc-ctype` for initdb (default:`C`)</summary>
    [JsonPropertyName("localeCType")]
    public string? LocaleCType { get; set; }

    /// <summary>The value to be passed as option `--lc-collate` for initdb (default:`C`)</summary>
    [JsonPropertyName("localeCollate")]
    public string? LocaleCollate { get; set; }

    /// <summary>This option sets the locale provider for databases created in the new cluster. Available from PostgreSQL 16.</summary>
    [JsonPropertyName("localeProvider")]
    public string? LocaleProvider { get; set; }

    /// <summary>The list of options that must be passed to initdb when creating the cluster. Deprecated: This could lead to inconsistent configurations, please use the explicit provided parameters instead. If defined, explicit values will be ignored.</summary>
    [JsonPropertyName("options")]
    public IList<string>? Options { get; set; }

    /// <summary>Name of the owner of the database in the instance to be used by applications. Defaults to the value of the `database` key.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>List of SQL queries to be executed as a superuser in the application database right after the cluster has been created - to be used with extreme care (by default empty)</summary>
    [JsonPropertyName("postInitApplicationSQL")]
    public IList<string>? PostInitApplicationSQL { get; set; }

    /// <summary>List of references to ConfigMaps or Secrets containing SQL files to be executed as a superuser in the application database right after the cluster has been created. The references are processed in a specific order: first, all Secrets are processed, followed by all ConfigMaps. Within each group, the processing order follows the sequence specified in their respective arrays. (by default empty)</summary>
    [JsonPropertyName("postInitApplicationSQLRefs")]
    public V1ClusterSpecBootstrapInitdbPostInitApplicationSQLRefs? PostInitApplicationSQLRefs { get; set; }

    /// <summary>List of SQL queries to be executed as a superuser in the `postgres` database right after the cluster has been created - to be used with extreme care (by default empty)</summary>
    [JsonPropertyName("postInitSQL")]
    public IList<string>? PostInitSQL { get; set; }

    /// <summary>List of references to ConfigMaps or Secrets containing SQL files to be executed as a superuser in the `postgres` database right after the cluster has been created. The references are processed in a specific order: first, all Secrets are processed, followed by all ConfigMaps. Within each group, the processing order follows the sequence specified in their respective arrays. (by default empty)</summary>
    [JsonPropertyName("postInitSQLRefs")]
    public V1ClusterSpecBootstrapInitdbPostInitSQLRefs? PostInitSQLRefs { get; set; }

    /// <summary>List of SQL queries to be executed as a superuser in the `template1` database right after the cluster has been created - to be used with extreme care (by default empty)</summary>
    [JsonPropertyName("postInitTemplateSQL")]
    public IList<string>? PostInitTemplateSQL { get; set; }

    /// <summary>List of references to ConfigMaps or Secrets containing SQL files to be executed as a superuser in the `template1` database right after the cluster has been created. The references are processed in a specific order: first, all Secrets are processed, followed by all ConfigMaps. Within each group, the processing order follows the sequence specified in their respective arrays. (by default empty)</summary>
    [JsonPropertyName("postInitTemplateSQLRefs")]
    public V1ClusterSpecBootstrapInitdbPostInitTemplateSQLRefs? PostInitTemplateSQLRefs { get; set; }

    /// <summary>Name of the secret containing the initial credentials for the owner of the user database. If empty a new secret will be created from scratch</summary>
    [JsonPropertyName("secret")]
    public V1ClusterSpecBootstrapInitdbSecret? Secret { get; set; }

    /// <summary>The value in megabytes (1 to 1024) to be passed to the `--wal-segsize` option for initdb (default: empty, resulting in PostgreSQL default: 16MB)</summary>
    [JsonPropertyName("walSegmentSize")]
    public int? WalSegmentSize { get; set; }
}

/// <summary>Name of the secret containing the initial credentials for the owner of the user database. If empty a new secret will be created from scratch</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapPgBasebackupSecret
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Bootstrap the cluster taking a physical backup of another compatible PostgreSQL instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapPgBasebackup
{
    /// <summary>Name of the database used by the application. Default: `app`.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Name of the owner of the database in the instance to be used by applications. Defaults to the value of the `database` key.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Name of the secret containing the initial credentials for the owner of the user database. If empty a new secret will be created from scratch</summary>
    [JsonPropertyName("secret")]
    public V1ClusterSpecBootstrapPgBasebackupSecret? Secret { get; set; }

    /// <summary>The name of the server of which we need to take a physical backup</summary>
    [JsonPropertyName("source")]
    public string Source { get; set; }
}

/// <summary>EndpointCA store the CA bundle of the barman endpoint. Useful when using self-signed certificates to avoid errors with certificate issuer and barman-cloud-wal-archive.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapRecoveryBackupEndpointCA
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The backup object containing the physical base backup from which to initiate the recovery procedure. Mutually exclusive with `source` and `volumeSnapshots`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapRecoveryBackup
{
    /// <summary>EndpointCA store the CA bundle of the barman endpoint. Useful when using self-signed certificates to avoid errors with certificate issuer and barman-cloud-wal-archive.</summary>
    [JsonPropertyName("endpointCA")]
    public V1ClusterSpecBootstrapRecoveryBackupEndpointCA? EndpointCA { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>By default, the recovery process applies all the available WAL files in the archive (full recovery). However, you can also end the recovery as soon as a consistent state is reached or recover to a point-in-time (PITR) by specifying a `RecoveryTarget` object, as expected by PostgreSQL (i.e., timestamp, transaction Id, LSN, ...). More info: https://www.postgresql.org/docs/current/runtime-config-wal.html#RUNTIME-CONFIG-WAL-RECOVERY-TARGET</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapRecoveryRecoveryTarget
{
    /// <summary>The ID of the backup from which to start the recovery process. If empty (default) the operator will automatically detect the backup based on targetTime or targetLSN if specified. Otherwise use the latest available backup in chronological order.</summary>
    [JsonPropertyName("backupID")]
    public string? BackupID { get; set; }

    /// <summary>Set the target to be exclusive. If omitted, defaults to false, so that in Postgres, `recovery_target_inclusive` will be true</summary>
    [JsonPropertyName("exclusive")]
    public bool? Exclusive { get; set; }

    /// <summary>End recovery as soon as a consistent state is reached</summary>
    [JsonPropertyName("targetImmediate")]
    public bool? TargetImmediate { get; set; }

    /// <summary>The target LSN (Log Sequence Number)</summary>
    [JsonPropertyName("targetLSN")]
    public string? TargetLSN { get; set; }

    /// <summary>The target name (to be previously created with `pg_create_restore_point`)</summary>
    [JsonPropertyName("targetName")]
    public string? TargetName { get; set; }

    /// <summary>The target timeline ("latest" or a positive integer)</summary>
    [JsonPropertyName("targetTLI")]
    public string? TargetTLI { get; set; }

    /// <summary>The target time as a timestamp in the RFC3339 standard</summary>
    [JsonPropertyName("targetTime")]
    public string? TargetTime { get; set; }

    /// <summary>The target transaction ID</summary>
    [JsonPropertyName("targetXID")]
    public string? TargetXID { get; set; }
}

/// <summary>Name of the secret containing the initial credentials for the owner of the user database. If empty a new secret will be created from scratch</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapRecoverySecret
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Configuration of the storage of the instances</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapRecoveryVolumeSnapshotsStorage
{
    /// <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>Kind is the type of resource being referenced</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of resource being referenced</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>TypedLocalObjectReference contains enough information to let you locate the typed referenced object inside the same namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapRecoveryVolumeSnapshotsTablespaceStorage
{
    /// <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>Kind is the type of resource being referenced</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of resource being referenced</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Configuration of the storage for PostgreSQL WAL (Write-Ahead Log)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapRecoveryVolumeSnapshotsWalStorage
{
    /// <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>Kind is the type of resource being referenced</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of resource being referenced</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The static PVC data source(s) from which to initiate the recovery procedure. Currently supporting `VolumeSnapshot` and `PersistentVolumeClaim` resources that map an existing PVC group, compatible with CloudNativePG, and taken with a cold backup copy on a fenced Postgres instance (limitation which will be removed in the future when online backup will be implemented). Mutually exclusive with `backup`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapRecoveryVolumeSnapshots
{
    /// <summary>Configuration of the storage of the instances</summary>
    [JsonPropertyName("storage")]
    public V1ClusterSpecBootstrapRecoveryVolumeSnapshotsStorage Storage { get; set; }

    /// <summary>Configuration of the storage for PostgreSQL tablespaces</summary>
    [JsonPropertyName("tablespaceStorage")]
    public IDictionary<string, V1ClusterSpecBootstrapRecoveryVolumeSnapshotsTablespaceStorage>? TablespaceStorage { get; set; }

    /// <summary>Configuration of the storage for PostgreSQL WAL (Write-Ahead Log)</summary>
    [JsonPropertyName("walStorage")]
    public V1ClusterSpecBootstrapRecoveryVolumeSnapshotsWalStorage? WalStorage { get; set; }
}

/// <summary>Bootstrap the cluster from a backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrapRecovery
{
    /// <summary>The backup object containing the physical base backup from which to initiate the recovery procedure. Mutually exclusive with `source` and `volumeSnapshots`.</summary>
    [JsonPropertyName("backup")]
    public V1ClusterSpecBootstrapRecoveryBackup? Backup { get; set; }

    /// <summary>Name of the database used by the application. Default: `app`.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Name of the owner of the database in the instance to be used by applications. Defaults to the value of the `database` key.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>By default, the recovery process applies all the available WAL files in the archive (full recovery). However, you can also end the recovery as soon as a consistent state is reached or recover to a point-in-time (PITR) by specifying a `RecoveryTarget` object, as expected by PostgreSQL (i.e., timestamp, transaction Id, LSN, ...). More info: https://www.postgresql.org/docs/current/runtime-config-wal.html#RUNTIME-CONFIG-WAL-RECOVERY-TARGET</summary>
    [JsonPropertyName("recoveryTarget")]
    public V1ClusterSpecBootstrapRecoveryRecoveryTarget? RecoveryTarget { get; set; }

    /// <summary>Name of the secret containing the initial credentials for the owner of the user database. If empty a new secret will be created from scratch</summary>
    [JsonPropertyName("secret")]
    public V1ClusterSpecBootstrapRecoverySecret? Secret { get; set; }

    /// <summary>The external cluster whose backup we will restore. This is also used as the name of the folder under which the backup is stored, so it must be set to the name of the source cluster Mutually exclusive with `backup`.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The static PVC data source(s) from which to initiate the recovery procedure. Currently supporting `VolumeSnapshot` and `PersistentVolumeClaim` resources that map an existing PVC group, compatible with CloudNativePG, and taken with a cold backup copy on a fenced Postgres instance (limitation which will be removed in the future when online backup will be implemented). Mutually exclusive with `backup`.</summary>
    [JsonPropertyName("volumeSnapshots")]
    public V1ClusterSpecBootstrapRecoveryVolumeSnapshots? VolumeSnapshots { get; set; }
}

/// <summary>Instructions to bootstrap this cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecBootstrap
{
    /// <summary>Bootstrap the cluster via initdb</summary>
    [JsonPropertyName("initdb")]
    public V1ClusterSpecBootstrapInitdb? Initdb { get; set; }

    /// <summary>Bootstrap the cluster taking a physical backup of another compatible PostgreSQL instance</summary>
    [JsonPropertyName("pg_basebackup")]
    public V1ClusterSpecBootstrapPgBasebackup? PgBasebackup { get; set; }

    /// <summary>Bootstrap the cluster from a backup</summary>
    [JsonPropertyName("recovery")]
    public V1ClusterSpecBootstrapRecovery? Recovery { get; set; }
}

/// <summary>The configuration for the CA and related certificates</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecCertificates
{
    /// <summary>The secret containing the Client CA certificate. If not defined, a new secret will be created with a self-signed CA and will be used to generate all the client certificates.&lt;br /&gt; &lt;br /&gt; Contains:&lt;br /&gt; &lt;br /&gt; - `ca.crt`: CA that should be used to validate the client certificates, used as `ssl_ca_file` of all the instances.&lt;br /&gt; - `ca.key`: key used to generate client certificates, if ReplicationTLSSecret is provided, this can be omitted.&lt;br /&gt;</summary>
    [JsonPropertyName("clientCASecret")]
    public string? ClientCASecret { get; set; }

    /// <summary>The secret of type kubernetes.io/tls containing the client certificate to authenticate as the `streaming_replica` user. If not defined, ClientCASecret must provide also `ca.key`, and a new secret will be created using the provided CA.</summary>
    [JsonPropertyName("replicationTLSSecret")]
    public string? ReplicationTLSSecret { get; set; }

    /// <summary>The list of the server alternative DNS names to be added to the generated server TLS certificates, when required.</summary>
    [JsonPropertyName("serverAltDNSNames")]
    public IList<string>? ServerAltDNSNames { get; set; }

    /// <summary>The secret containing the Server CA certificate. If not defined, a new secret will be created with a self-signed CA and will be used to generate the TLS certificate ServerTLSSecret.&lt;br /&gt; &lt;br /&gt; Contains:&lt;br /&gt; &lt;br /&gt; - `ca.crt`: CA that should be used to validate the server certificate, used as `sslrootcert` in client connection strings.&lt;br /&gt; - `ca.key`: key used to generate Server SSL certs, if ServerTLSSecret is provided, this can be omitted.&lt;br /&gt;</summary>
    [JsonPropertyName("serverCASecret")]
    public string? ServerCASecret { get; set; }

    /// <summary>The secret of type kubernetes.io/tls containing the server TLS certificate and key that will be set as `ssl_cert_file` and `ssl_key_file` so that clients can connect to postgres securely. If not defined, ServerCASecret must provide also `ca.key` and a new secret will be created using the provided CA.</summary>
    [JsonPropertyName("serverTLSSecret")]
    public string? ServerTLSSecret { get; set; }
}

/// <summary>Selects a key of a ConfigMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEnvValueFromConfigMapKeyRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Selects a field of the pod: supports metadata.name, metadata.namespace, `metadata.labels['&lt;KEY&gt;']`, `metadata.annotations['&lt;KEY&gt;']`, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEnvValueFromFieldRef
{
    /// <summary>Version of the schema the FieldPath is written in terms of, defaults to "v1".</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Path of the field to select in the specified API version.</summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEnvValueFromResourceFieldRef
{
    /// <summary>Container name: required for volumes, optional for env vars</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Specifies the output format of the exposed resources, defaults to "1"</summary>
    [JsonPropertyName("divisor")]
    public IntstrIntOrString? Divisor { get; set; }

    /// <summary>Required: resource to select</summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }
}

/// <summary>Selects a key of a secret in the pod's namespace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEnvValueFromSecretKeyRef
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Source for the environment variable's value. Cannot be used if value is not empty.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEnvValueFrom
{
    /// <summary>Selects a key of a ConfigMap.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1ClusterSpecEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>Selects a field of the pod: supports metadata.name, metadata.namespace, `metadata.labels['&lt;KEY&gt;']`, `metadata.annotations['&lt;KEY&gt;']`, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.</summary>
    [JsonPropertyName("fieldRef")]
    public V1ClusterSpecEnvValueFromFieldRef? FieldRef { get; set; }

    /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.</summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1ClusterSpecEnvValueFromResourceFieldRef? ResourceFieldRef { get; set; }

    /// <summary>Selects a key of a secret in the pod's namespace</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1ClusterSpecEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>EnvVar represents an environment variable present in a Container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEnv
{
    /// <summary>Name of the environment variable. Must be a C_IDENTIFIER.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Variable references $(VAR_NAME) are expanded using the previously defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable's value. Cannot be used if value is not empty.</summary>
    [JsonPropertyName("valueFrom")]
    public V1ClusterSpecEnvValueFrom? ValueFrom { get; set; }
}

/// <summary>The ConfigMap to select from</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEnvFromConfigMapRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>The Secret to select from</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEnvFromSecretRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>EnvFromSource represents the source of a set of ConfigMaps</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEnvFrom
{
    /// <summary>The ConfigMap to select from</summary>
    [JsonPropertyName("configMapRef")]
    public V1ClusterSpecEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary>An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The Secret to select from</summary>
    [JsonPropertyName("secretRef")]
    public V1ClusterSpecEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary>May contain labels and annotations that will be copied into the PVC when creating it. No other fields are allowed and will be rejected during validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplateMetadata
{
}

/// <summary>dataSource field can be used to specify either: * An existing VolumeSnapshot object (snapshot.storage.k8s.io/VolumeSnapshot) * An existing PVC (PersistentVolumeClaim) If the provisioner or an external controller can support the specified data source, it will create a new volume based on the contents of the specified data source. When the AnyVolumeDataSource feature gate is enabled, dataSource contents will be copied to dataSourceRef, and dataSourceRef contents will be copied to dataSource when dataSourceRef.namespace is not specified. If the namespace is specified, then dataSourceRef will not be copied to dataSource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplateSpecDataSource
{
    /// <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>Kind is the type of resource being referenced</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of resource being referenced</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>dataSourceRef specifies the object from which to populate the volume with data, if a non-empty volume is desired. This may be any object from a non-empty API group (non core object) or a PersistentVolumeClaim object. When this field is specified, volume binding will only succeed if the type of the specified object matches some installed volume populator or dynamic provisioner. This field will replace the functionality of the dataSource field and as such if both fields are non-empty, they must have the same value. For backwards compatibility, when namespace isn't specified in dataSourceRef, both fields (dataSource and dataSourceRef) will be set to the same value automatically if one of them is empty and the other is non-empty. When namespace is specified in dataSourceRef, dataSource isn't set to the same value and must be empty. There are three important differences between dataSource and dataSourceRef: * While dataSource only allows two specific types of objects, dataSourceRef   allows any non-core object, as well as PersistentVolumeClaim objects. * While dataSource ignores disallowed values (dropping them), dataSourceRef   preserves all values, and generates an error if a disallowed value is   specified. * While dataSource only allows local objects, dataSourceRef allows objects   in any namespaces. (Beta) Using this field requires the AnyVolumeDataSource feature gate to be enabled. (Alpha) Using the namespace field of dataSourceRef requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplateSpecDataSourceRef
{
    /// <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>Kind is the type of resource being referenced</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of resource being referenced</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace is the namespace of resource being referenced Note that when a namespace is specified, a gateway.networking.k8s.io/ReferenceGrant object is required in the referent namespace to allow that namespace's owner to accept the reference. See the ReferenceGrant documentation for details. (Alpha) This field requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>resources represents the minimum resources the volume should have. If RecoverVolumeExpansionFailure feature is enabled users are allowed to specify resource requirements that are lower than previous value but must still be higher than capacity recorded in the status field of the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplateSpecResources
{
    /// <summary>Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntstrIntOrString>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntstrIntOrString>? Requests { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplateSpecSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>selector is a label query over volumes to consider for binding.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplateSpecSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplateSpecSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>The specification for the PersistentVolumeClaim. The entire content is copied unchanged into the PVC that gets created from this template. The same fields as in a PersistentVolumeClaim are also valid here.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplateSpec
{
    /// <summary>accessModes contains the desired access modes the volume should have. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1</summary>
    [JsonPropertyName("accessModes")]
    public IList<string>? AccessModes { get; set; }

    /// <summary>dataSource field can be used to specify either: * An existing VolumeSnapshot object (snapshot.storage.k8s.io/VolumeSnapshot) * An existing PVC (PersistentVolumeClaim) If the provisioner or an external controller can support the specified data source, it will create a new volume based on the contents of the specified data source. When the AnyVolumeDataSource feature gate is enabled, dataSource contents will be copied to dataSourceRef, and dataSourceRef contents will be copied to dataSource when dataSourceRef.namespace is not specified. If the namespace is specified, then dataSourceRef will not be copied to dataSource.</summary>
    [JsonPropertyName("dataSource")]
    public V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplateSpecDataSource? DataSource { get; set; }

    /// <summary>dataSourceRef specifies the object from which to populate the volume with data, if a non-empty volume is desired. This may be any object from a non-empty API group (non core object) or a PersistentVolumeClaim object. When this field is specified, volume binding will only succeed if the type of the specified object matches some installed volume populator or dynamic provisioner. This field will replace the functionality of the dataSource field and as such if both fields are non-empty, they must have the same value. For backwards compatibility, when namespace isn't specified in dataSourceRef, both fields (dataSource and dataSourceRef) will be set to the same value automatically if one of them is empty and the other is non-empty. When namespace is specified in dataSourceRef, dataSource isn't set to the same value and must be empty. There are three important differences between dataSource and dataSourceRef: * While dataSource only allows two specific types of objects, dataSourceRef   allows any non-core object, as well as PersistentVolumeClaim objects. * While dataSource ignores disallowed values (dropping them), dataSourceRef   preserves all values, and generates an error if a disallowed value is   specified. * While dataSource only allows local objects, dataSourceRef allows objects   in any namespaces. (Beta) Using this field requires the AnyVolumeDataSource feature gate to be enabled. (Alpha) Using the namespace field of dataSourceRef requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
    [JsonPropertyName("dataSourceRef")]
    public V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplateSpecDataSourceRef? DataSourceRef { get; set; }

    /// <summary>resources represents the minimum resources the volume should have. If RecoverVolumeExpansionFailure feature is enabled users are allowed to specify resource requirements that are lower than previous value but must still be higher than capacity recorded in the status field of the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources</summary>
    [JsonPropertyName("resources")]
    public V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplateSpecResources? Resources { get; set; }

    /// <summary>selector is a label query over volumes to consider for binding.</summary>
    [JsonPropertyName("selector")]
    public V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplateSpecSelector? Selector { get; set; }

    /// <summary>storageClassName is the name of the StorageClass required by the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#class-1</summary>
    [JsonPropertyName("storageClassName")]
    public string? StorageClassName { get; set; }

    /// <summary>volumeAttributesClassName may be used to set the VolumeAttributesClass used by this claim. If specified, the CSI driver will create or update the volume with the attributes defined in the corresponding VolumeAttributesClass. This has a different purpose than storageClassName, it can be changed after the claim is created. An empty string value means that no VolumeAttributesClass will be applied to the claim but it's not allowed to reset this field to empty string once it is set. If unspecified and the PersistentVolumeClaim is unbound, the default VolumeAttributesClass will be set by the persistentvolume controller if it exists. If the resource referred to by volumeAttributesClass does not exist, this PersistentVolumeClaim will be set to a Pending state, as reflected by the modifyVolumeStatus field, until such as a resource exists. More info: https://kubernetes.io/docs/concepts/storage/volume-attributes-classes/ (Beta) Using this field requires the VolumeAttributesClass feature gate to be enabled (off by default).</summary>
    [JsonPropertyName("volumeAttributesClassName")]
    public string? VolumeAttributesClassName { get; set; }

    /// <summary>volumeMode defines what type of volume is required by the claim. Value of Filesystem is implied when not included in claim spec.</summary>
    [JsonPropertyName("volumeMode")]
    public string? VolumeMode { get; set; }

    /// <summary>volumeName is the binding reference to the PersistentVolume backing this claim.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>Will be used to create a stand-alone PVC to provision the volume. The pod in which this EphemeralVolumeSource is embedded will be the owner of the PVC, i.e. the PVC will be deleted together with the pod.  The name of the PVC will be `&lt;pod name&gt;-&lt;volume name&gt;` where `&lt;volume name&gt;` is the name from the `PodSpec.Volumes` array entry. Pod validation will reject the pod if the concatenated name is not valid for a PVC (for example, too long).  An existing PVC with that name that is not owned by the pod will *not* be used for the pod to avoid using an unrelated volume by mistake. Starting the pod is then blocked until the unrelated PVC is removed. If such a pre-created PVC is meant to be used by the pod, the PVC has to updated with an owner reference to the pod once the pod exists. Normally this should not be necessary, but it may be useful when manually reconstructing a broken cluster.  This field is read-only and no changes will be made by Kubernetes to the PVC after it has been created.  Required, must not be nil.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplate
{
    /// <summary>May contain labels and annotations that will be copied into the PVC when creating it. No other fields are allowed and will be rejected during validation.</summary>
    [JsonPropertyName("metadata")]
    public V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplateMetadata? Metadata { get; set; }

    /// <summary>The specification for the PersistentVolumeClaim. The entire content is copied unchanged into the PVC that gets created from this template. The same fields as in a PersistentVolumeClaim are also valid here.</summary>
    [JsonPropertyName("spec")]
    public V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplateSpec Spec { get; set; }
}

/// <summary>EphemeralVolumeSource allows the user to configure the source of ephemeral volumes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEphemeralVolumeSource
{
    /// <summary>Will be used to create a stand-alone PVC to provision the volume. The pod in which this EphemeralVolumeSource is embedded will be the owner of the PVC, i.e. the PVC will be deleted together with the pod.  The name of the PVC will be `&lt;pod name&gt;-&lt;volume name&gt;` where `&lt;volume name&gt;` is the name from the `PodSpec.Volumes` array entry. Pod validation will reject the pod if the concatenated name is not valid for a PVC (for example, too long).  An existing PVC with that name that is not owned by the pod will *not* be used for the pod to avoid using an unrelated volume by mistake. Starting the pod is then blocked until the unrelated PVC is removed. If such a pre-created PVC is meant to be used by the pod, the PVC has to updated with an owner reference to the pod once the pod exists. Normally this should not be necessary, but it may be useful when manually reconstructing a broken cluster.  This field is read-only and no changes will be made by Kubernetes to the PVC after it has been created.  Required, must not be nil.</summary>
    [JsonPropertyName("volumeClaimTemplate")]
    public V1ClusterSpecEphemeralVolumeSourceVolumeClaimTemplate? VolumeClaimTemplate { get; set; }
}

/// <summary>EphemeralVolumesSizeLimit allows the user to set the limits for the ephemeral volumes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecEphemeralVolumesSizeLimit
{
    /// <summary>Shm is the size limit of the shared memory volume</summary>
    [JsonPropertyName("shm")]
    public IntstrIntOrString? Shm { get; set; }

    /// <summary>TemporaryData is the size limit of the temporary data volume</summary>
    [JsonPropertyName("temporaryData")]
    public IntstrIntOrString? TemporaryData { get; set; }
}

/// <summary>The connection string to be used</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStoreAzureCredentialsConnectionString
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The storage account where to upload data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStoreAzureCredentialsStorageAccount
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The storage account key to be used in conjunction with the storage account name</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStoreAzureCredentialsStorageKey
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A shared-access-signature to be used in conjunction with the storage account name</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStoreAzureCredentialsStorageSasToken
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The credentials to use to upload data to Azure Blob Storage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStoreAzureCredentials
{
    /// <summary>The connection string to be used</summary>
    [JsonPropertyName("connectionString")]
    public V1ClusterSpecExternalClustersBarmanObjectStoreAzureCredentialsConnectionString? ConnectionString { get; set; }

    /// <summary>Use the Azure AD based authentication without providing explicitly the keys.</summary>
    [JsonPropertyName("inheritFromAzureAD")]
    public bool? InheritFromAzureAD { get; set; }

    /// <summary>The storage account where to upload data</summary>
    [JsonPropertyName("storageAccount")]
    public V1ClusterSpecExternalClustersBarmanObjectStoreAzureCredentialsStorageAccount? StorageAccount { get; set; }

    /// <summary>The storage account key to be used in conjunction with the storage account name</summary>
    [JsonPropertyName("storageKey")]
    public V1ClusterSpecExternalClustersBarmanObjectStoreAzureCredentialsStorageKey? StorageKey { get; set; }

    /// <summary>A shared-access-signature to be used in conjunction with the storage account name</summary>
    [JsonPropertyName("storageSasToken")]
    public V1ClusterSpecExternalClustersBarmanObjectStoreAzureCredentialsStorageSasToken? StorageSasToken { get; set; }
}

/// <summary>The configuration to be used to backup the data files When not defined, base backups files will be stored uncompressed and may be unencrypted in the object store, according to the bucket default policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStoreData
{
    /// <summary>AdditionalCommandArgs represents additional arguments that can be appended to the 'barman-cloud-backup' command-line invocation. These arguments provide flexibility to customize the backup process further according to specific requirements or configurations.  Example: In a scenario where specialized backup options are required, such as setting a specific timeout or defining custom behavior, users can use this field to specify additional command arguments.  Note: It's essential to ensure that the provided arguments are valid and supported by the 'barman-cloud-backup' command, to avoid potential errors or unintended behavior during execution.</summary>
    [JsonPropertyName("additionalCommandArgs")]
    public IList<string>? AdditionalCommandArgs { get; set; }

    /// <summary>Compress a backup file (a tar file per tablespace) while streaming it to the object store. Available options are empty string (no compression, default), `gzip`, `bzip2` or `snappy`.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>Whenever to force the encryption of files (if the bucket is not already configured for that). Allowed options are empty string (use the bucket policy, default), `AES256` and `aws:kms`</summary>
    [JsonPropertyName("encryption")]
    public string? Encryption { get; set; }

    /// <summary>Control whether the I/O workload for the backup initial checkpoint will be limited, according to the `checkpoint_completion_target` setting on the PostgreSQL server. If set to true, an immediate checkpoint will be used, meaning PostgreSQL will complete the checkpoint as soon as possible. `false` by default.</summary>
    [JsonPropertyName("immediateCheckpoint")]
    public bool? ImmediateCheckpoint { get; set; }

    /// <summary>The number of parallel jobs to be used to upload the backup, defaults to 2</summary>
    [JsonPropertyName("jobs")]
    public int? Jobs { get; set; }
}

/// <summary>EndpointCA store the CA bundle of the barman endpoint. Useful when using self-signed certificates to avoid errors with certificate issuer and barman-cloud-wal-archive</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStoreEndpointCA
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The secret containing the Google Cloud Storage JSON file with the credentials</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStoreGoogleCredentialsApplicationCredentials
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The credentials to use to upload data to Google Cloud Storage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStoreGoogleCredentials
{
    /// <summary>The secret containing the Google Cloud Storage JSON file with the credentials</summary>
    [JsonPropertyName("applicationCredentials")]
    public V1ClusterSpecExternalClustersBarmanObjectStoreGoogleCredentialsApplicationCredentials? ApplicationCredentials { get; set; }

    /// <summary>If set to true, will presume that it's running inside a GKE environment, default to false.</summary>
    [JsonPropertyName("gkeEnvironment")]
    public bool? GkeEnvironment { get; set; }
}

/// <summary>The reference to the access key id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStoreS3CredentialsAccessKeyId
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The reference to the secret containing the region name</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStoreS3CredentialsRegion
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The reference to the secret access key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStoreS3CredentialsSecretAccessKey
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The references to the session key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStoreS3CredentialsSessionToken
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The credentials to use to upload data to S3</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStoreS3Credentials
{
    /// <summary>The reference to the access key id</summary>
    [JsonPropertyName("accessKeyId")]
    public V1ClusterSpecExternalClustersBarmanObjectStoreS3CredentialsAccessKeyId? AccessKeyId { get; set; }

    /// <summary>Use the role based authentication without providing explicitly the keys.</summary>
    [JsonPropertyName("inheritFromIAMRole")]
    public bool? InheritFromIAMRole { get; set; }

    /// <summary>The reference to the secret containing the region name</summary>
    [JsonPropertyName("region")]
    public V1ClusterSpecExternalClustersBarmanObjectStoreS3CredentialsRegion? Region { get; set; }

    /// <summary>The reference to the secret access key</summary>
    [JsonPropertyName("secretAccessKey")]
    public V1ClusterSpecExternalClustersBarmanObjectStoreS3CredentialsSecretAccessKey? SecretAccessKey { get; set; }

    /// <summary>The references to the session key</summary>
    [JsonPropertyName("sessionToken")]
    public V1ClusterSpecExternalClustersBarmanObjectStoreS3CredentialsSessionToken? SessionToken { get; set; }
}

/// <summary>The configuration for the backup of the WAL stream. When not defined, WAL files will be stored uncompressed and may be unencrypted in the object store, according to the bucket default policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStoreWal
{
    /// <summary>Additional arguments that can be appended to the 'barman-cloud-wal-archive' command-line invocation. These arguments provide flexibility to customize the WAL archive process further, according to specific requirements or configurations.  Example: In a scenario where specialized backup options are required, such as setting a specific timeout or defining custom behavior, users can use this field to specify additional command arguments.  Note: It's essential to ensure that the provided arguments are valid and supported by the 'barman-cloud-wal-archive' command, to avoid potential errors or unintended behavior during execution.</summary>
    [JsonPropertyName("archiveAdditionalCommandArgs")]
    public IList<string>? ArchiveAdditionalCommandArgs { get; set; }

    /// <summary>Compress a WAL file before sending it to the object store. Available options are empty string (no compression, default), `gzip`, `bzip2` or `snappy`.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>Whenever to force the encryption of files (if the bucket is not already configured for that). Allowed options are empty string (use the bucket policy, default), `AES256` and `aws:kms`</summary>
    [JsonPropertyName("encryption")]
    public string? Encryption { get; set; }

    /// <summary>Number of WAL files to be either archived in parallel (when the PostgreSQL instance is archiving to a backup object store) or restored in parallel (when a PostgreSQL standby is fetching WAL files from a recovery object store). If not specified, WAL files will be processed one at a time. It accepts a positive integer as a value - with 1 being the minimum accepted value.</summary>
    [JsonPropertyName("maxParallel")]
    public int? MaxParallel { get; set; }

    /// <summary>Additional arguments that can be appended to the 'barman-cloud-wal-restore' command-line invocation. These arguments provide flexibility to customize the WAL restore process further, according to specific requirements or configurations.  Example: In a scenario where specialized backup options are required, such as setting a specific timeout or defining custom behavior, users can use this field to specify additional command arguments.  Note: It's essential to ensure that the provided arguments are valid and supported by the 'barman-cloud-wal-restore' command, to avoid potential errors or unintended behavior during execution.</summary>
    [JsonPropertyName("restoreAdditionalCommandArgs")]
    public IList<string>? RestoreAdditionalCommandArgs { get; set; }
}

/// <summary>The configuration for the barman-cloud tool suite</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersBarmanObjectStore
{
    /// <summary>The credentials to use to upload data to Azure Blob Storage</summary>
    [JsonPropertyName("azureCredentials")]
    public V1ClusterSpecExternalClustersBarmanObjectStoreAzureCredentials? AzureCredentials { get; set; }

    /// <summary>The configuration to be used to backup the data files When not defined, base backups files will be stored uncompressed and may be unencrypted in the object store, according to the bucket default policy.</summary>
    [JsonPropertyName("data")]
    public V1ClusterSpecExternalClustersBarmanObjectStoreData? Data { get; set; }

    /// <summary>The path where to store the backup (i.e. s3://bucket/path/to/folder) this path, with different destination folders, will be used for WALs and for data</summary>
    [JsonPropertyName("destinationPath")]
    public string DestinationPath { get; set; }

    /// <summary>EndpointCA store the CA bundle of the barman endpoint. Useful when using self-signed certificates to avoid errors with certificate issuer and barman-cloud-wal-archive</summary>
    [JsonPropertyName("endpointCA")]
    public V1ClusterSpecExternalClustersBarmanObjectStoreEndpointCA? EndpointCA { get; set; }

    /// <summary>Endpoint to be used to upload data to the cloud, overriding the automatic endpoint discovery</summary>
    [JsonPropertyName("endpointURL")]
    public string? EndpointURL { get; set; }

    /// <summary>The credentials to use to upload data to Google Cloud Storage</summary>
    [JsonPropertyName("googleCredentials")]
    public V1ClusterSpecExternalClustersBarmanObjectStoreGoogleCredentials? GoogleCredentials { get; set; }

    /// <summary>HistoryTags is a list of key value pairs that will be passed to the Barman --history-tags option.</summary>
    [JsonPropertyName("historyTags")]
    public IDictionary<string, string>? HistoryTags { get; set; }

    /// <summary>The credentials to use to upload data to S3</summary>
    [JsonPropertyName("s3Credentials")]
    public V1ClusterSpecExternalClustersBarmanObjectStoreS3Credentials? S3Credentials { get; set; }

    /// <summary>The server name on S3, the cluster name is used if this parameter is omitted</summary>
    [JsonPropertyName("serverName")]
    public string? ServerName { get; set; }

    /// <summary>Tags is a list of key value pairs that will be passed to the Barman --tags option.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The configuration for the backup of the WAL stream. When not defined, WAL files will be stored uncompressed and may be unencrypted in the object store, according to the bucket default policy.</summary>
    [JsonPropertyName("wal")]
    public V1ClusterSpecExternalClustersBarmanObjectStoreWal? Wal { get; set; }
}

/// <summary>The reference to the password to be used to connect to the server. If a password is provided, CloudNativePG creates a PostgreSQL passfile at `/controller/external/NAME/pass` (where "NAME" is the cluster's name). This passfile is automatically referenced in the connection string when establishing a connection to the remote PostgreSQL server from the current PostgreSQL `Cluster`. This ensures secure and efficient password management for external clusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersPassword
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>The configuration of the plugin that is taking care of WAL archiving and backups for this external cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersPlugin
{
    /// <summary>Enabled is true if this plugin will be used</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Only one plugin can be declared as WALArchiver. Cannot be active if ".spec.backup.barmanObjectStore" configuration is present.</summary>
    [JsonPropertyName("isWALArchiver")]
    public bool? IsWALArchiver { get; set; }

    /// <summary>Name is the plugin name</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Parameters is the configuration of the plugin</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>The reference to an SSL certificate to be used to connect to this instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersSslCert
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>The reference to an SSL private key to be used to connect to this instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersSslKey
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>The reference to an SSL CA public key to be used to connect to this instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClustersSslRootCert
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ExternalCluster represents the connection parameters to an external cluster which is used in the other sections of the configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecExternalClusters
{
    /// <summary>The configuration for the barman-cloud tool suite</summary>
    [JsonPropertyName("barmanObjectStore")]
    public V1ClusterSpecExternalClustersBarmanObjectStore? BarmanObjectStore { get; set; }

    /// <summary>The list of connection parameters, such as dbname, host, username, etc</summary>
    [JsonPropertyName("connectionParameters")]
    public IDictionary<string, string>? ConnectionParameters { get; set; }

    /// <summary>The server name, required</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The reference to the password to be used to connect to the server. If a password is provided, CloudNativePG creates a PostgreSQL passfile at `/controller/external/NAME/pass` (where "NAME" is the cluster's name). This passfile is automatically referenced in the connection string when establishing a connection to the remote PostgreSQL server from the current PostgreSQL `Cluster`. This ensures secure and efficient password management for external clusters.</summary>
    [JsonPropertyName("password")]
    public V1ClusterSpecExternalClustersPassword? Password { get; set; }

    /// <summary>The configuration of the plugin that is taking care of WAL archiving and backups for this external cluster</summary>
    [JsonPropertyName("plugin")]
    public V1ClusterSpecExternalClustersPlugin? Plugin { get; set; }

    /// <summary>The reference to an SSL certificate to be used to connect to this instance</summary>
    [JsonPropertyName("sslCert")]
    public V1ClusterSpecExternalClustersSslCert? SslCert { get; set; }

    /// <summary>The reference to an SSL private key to be used to connect to this instance</summary>
    [JsonPropertyName("sslKey")]
    public V1ClusterSpecExternalClustersSslKey? SslKey { get; set; }

    /// <summary>The reference to an SSL CA public key to be used to connect to this instance</summary>
    [JsonPropertyName("sslRootCert")]
    public V1ClusterSpecExternalClustersSslRootCert? SslRootCert { get; set; }
}

/// <summary>Defines the major PostgreSQL version we want to use within an ImageCatalog</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecImageCatalogRef
{
    /// <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>Kind is the type of resource being referenced</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>The major version of PostgreSQL we want to use from the ImageCatalog</summary>
    [JsonPropertyName("major")]
    public int Major { get; set; }

    /// <summary>Name is the name of resource being referenced</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>LocalObjectReference contains enough information to let you locate a local object with a known type inside the same namespace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecImagePullSecrets
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Metadata that will be inherited by all objects related to the Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecInheritedMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>Secret containing the password of the role (if present) If null, the password will be ignored unless DisablePassword is set</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecManagedRolesPasswordSecret
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>RoleConfiguration is the representation, in Kubernetes, of a PostgreSQL role with the additional field Ensure specifying whether to ensure the presence or absence of the role in the database  The defaults of the CREATE ROLE command are applied Reference: https://www.postgresql.org/docs/current/sql-createrole.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecManagedRoles
{
    /// <summary>Whether a role bypasses every row-level security (RLS) policy. Default is `false`.</summary>
    [JsonPropertyName("bypassrls")]
    public bool? Bypassrls { get; set; }

    /// <summary>Description of the role</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>If the role can log in, this specifies how many concurrent connections the role can make. `-1` (the default) means no limit.</summary>
    [JsonPropertyName("connectionLimit")]
    public long? ConnectionLimit { get; set; }

    /// <summary>When set to `true`, the role being defined will be allowed to create new databases. Specifying `false` (default) will deny a role the ability to create databases.</summary>
    [JsonPropertyName("createdb")]
    public bool? Createdb { get; set; }

    /// <summary>Whether the role will be permitted to create, alter, drop, comment on, change the security label for, and grant or revoke membership in other roles. Default is `false`.</summary>
    [JsonPropertyName("createrole")]
    public bool? Createrole { get; set; }

    /// <summary>DisablePassword indicates that a role's password should be set to NULL in Postgres</summary>
    [JsonPropertyName("disablePassword")]
    public bool? DisablePassword { get; set; }

    /// <summary>Ensure the role is `present` or `absent` - defaults to "present"</summary>
    [JsonPropertyName("ensure")]
    public string? Ensure { get; set; }

    /// <summary>List of one or more existing roles to which this role will be immediately added as a new member. Default empty.</summary>
    [JsonPropertyName("inRoles")]
    public IList<string>? InRoles { get; set; }

    /// <summary>Whether a role "inherits" the privileges of roles it is a member of. Defaults is `true`.</summary>
    [JsonPropertyName("inherit")]
    public bool? Inherit { get; set; }

    /// <summary>Whether the role is allowed to log in. A role having the `login` attribute can be thought of as a user. Roles without this attribute are useful for managing database privileges, but are not users in the usual sense of the word. Default is `false`.</summary>
    [JsonPropertyName("login")]
    public bool? Login { get; set; }

    /// <summary>Name of the role</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Secret containing the password of the role (if present) If null, the password will be ignored unless DisablePassword is set</summary>
    [JsonPropertyName("passwordSecret")]
    public V1ClusterSpecManagedRolesPasswordSecret? PasswordSecret { get; set; }

    /// <summary>Whether a role is a replication role. A role must have this attribute (or be a superuser) in order to be able to connect to the server in replication mode (physical or logical replication) and in order to be able to create or drop replication slots. A role having the `replication` attribute is a very highly privileged role, and should only be used on roles actually used for replication. Default is `false`.</summary>
    [JsonPropertyName("replication")]
    public bool? Replication { get; set; }

    /// <summary>Whether the role is a `superuser` who can override all access restrictions within the database - superuser status is dangerous and should be used only when really needed. You must yourself be a superuser to create a new superuser. Defaults is `false`.</summary>
    [JsonPropertyName("superuser")]
    public bool? Superuser { get; set; }

    /// <summary>Date and time after which the role's password is no longer valid. When omitted, the password will never expire (default).</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

/// <summary>Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecManagedServicesAdditionalServiceTemplateMetadata
{
    /// <summary>Annotations is an unstructured key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when modifying objects. More info: http://kubernetes.io/docs/user-guide/annotations</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects. May match selectors of replication controllers and services. More info: http://kubernetes.io/docs/user-guide/labels</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the resource. Only supported for certain types</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ServicePort contains information on service's port.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecManagedServicesAdditionalServiceTemplateSpecPorts
{
    /// <summary>The application protocol for this port. This is used as a hint for implementations to offer richer behavior for protocols that they understand. This field follows standard Kubernetes label syntax. Valid values are either:  * Un-prefixed protocol names - reserved for IANA standard service names (as per RFC-6335 and https://www.iana.org/assignments/service-names).  * Kubernetes-defined prefixed names:   * 'kubernetes.io/h2c' - HTTP/2 prior knowledge over cleartext as described in https://www.rfc-editor.org/rfc/rfc9113.html#name-starting-http-2-with-prior-   * 'kubernetes.io/ws'  - WebSocket over cleartext as described in https://www.rfc-editor.org/rfc/rfc6455   * 'kubernetes.io/wss' - WebSocket over TLS as described in https://www.rfc-editor.org/rfc/rfc6455  * Other protocols should use implementation-defined prefixed names such as mycompany.com/my-custom-protocol.</summary>
    [JsonPropertyName("appProtocol")]
    public string? AppProtocol { get; set; }

    /// <summary>The name of this port within the service. This must be a DNS_LABEL. All ports within a ServiceSpec must have unique names. When considering the endpoints for a Service, this must match the 'name' field in the EndpointPort. Optional if only one ServicePort is defined on this service.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port on each node on which this service is exposed when type is NodePort or LoadBalancer.  Usually assigned by the system. If a value is specified, in-range, and not in use it will be used, otherwise the operation will fail.  If not specified, a port will be allocated if this Service requires one.  If this field is specified when creating a Service which does not need it, creation will fail. This field will be wiped when updating a Service to no longer need it (e.g. changing type from NodePort to ClusterIP). More info: https://kubernetes.io/docs/concepts/services-networking/service/#type-nodeport</summary>
    [JsonPropertyName("nodePort")]
    public int? NodePort { get; set; }

    /// <summary>The port that will be exposed by this service.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>The IP protocol for this port. Supports "TCP", "UDP", and "SCTP". Default is TCP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Number or name of the port to access on the pods targeted by the service. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME. If this is a string, it will be looked up as a named port in the target Pod's container ports. If this is not specified, the value of the 'port' field is used (an identity map). This field is ignored for services with clusterIP=None, and should be omitted or set equal to the 'port' field. More info: https://kubernetes.io/docs/concepts/services-networking/service/#defining-a-service</summary>
    [JsonPropertyName("targetPort")]
    public IntstrIntOrString? TargetPort { get; set; }
}

/// <summary>clientIP contains the configurations of Client IP based session affinity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecManagedServicesAdditionalServiceTemplateSpecSessionAffinityConfigClientIP
{
    /// <summary>timeoutSeconds specifies the seconds of ClientIP type session sticky time. The value must be &gt;0 &amp;&amp; &lt;=86400(for 1 day) if ServiceAffinity == "ClientIP". Default value is 10800(for 3 hours).</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>sessionAffinityConfig contains the configurations of session affinity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecManagedServicesAdditionalServiceTemplateSpecSessionAffinityConfig
{
    /// <summary>clientIP contains the configurations of Client IP based session affinity.</summary>
    [JsonPropertyName("clientIP")]
    public V1ClusterSpecManagedServicesAdditionalServiceTemplateSpecSessionAffinityConfigClientIP? ClientIP { get; set; }
}

/// <summary>Specification of the desired behavior of the service. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecManagedServicesAdditionalServiceTemplateSpec
{
    /// <summary>allocateLoadBalancerNodePorts defines if NodePorts will be automatically allocated for services with type LoadBalancer.  Default is "true". It may be set to "false" if the cluster load-balancer does not rely on NodePorts.  If the caller requests specific NodePorts (by specifying a value), those requests will be respected, regardless of this field. This field may only be set for services with type LoadBalancer and will be cleared if the type is changed to any other type.</summary>
    [JsonPropertyName("allocateLoadBalancerNodePorts")]
    public bool? AllocateLoadBalancerNodePorts { get; set; }

    /// <summary>clusterIP is the IP address of the service and is usually assigned randomly. If an address is specified manually, is in-range (as per system configuration), and is not in use, it will be allocated to the service; otherwise creation of the service will fail. This field may not be changed through updates unless the type field is also being changed to ExternalName (which requires this field to be blank) or the type field is being changed from ExternalName (in which case this field may optionally be specified, as describe above).  Valid values are "None", empty string (""), or a valid IP address. Setting this to "None" makes a "headless service" (no virtual IP), which is useful when direct endpoint connections are preferred and proxying is not required.  Only applies to types ClusterIP, NodePort, and LoadBalancer. If this field is specified when creating a Service of type ExternalName, creation will fail. This field will be wiped when updating a Service to type ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies</summary>
    [JsonPropertyName("clusterIP")]
    public string? ClusterIP { get; set; }

    /// <summary>ClusterIPs is a list of IP addresses assigned to this service, and are usually assigned randomly.  If an address is specified manually, is in-range (as per system configuration), and is not in use, it will be allocated to the service; otherwise creation of the service will fail. This field may not be changed through updates unless the type field is also being changed to ExternalName (which requires this field to be empty) or the type field is being changed from ExternalName (in which case this field may optionally be specified, as describe above).  Valid values are "None", empty string (""), or a valid IP address.  Setting this to "None" makes a "headless service" (no virtual IP), which is useful when direct endpoint connections are preferred and proxying is not required.  Only applies to types ClusterIP, NodePort, and LoadBalancer. If this field is specified when creating a Service of type ExternalName, creation will fail. This field will be wiped when updating a Service to type ExternalName.  If this field is not specified, it will be initialized from the clusterIP field.  If this field is specified, clients must ensure that clusterIPs[0] and clusterIP have the same value.  This field may hold a maximum of two entries (dual-stack IPs, in either order). These IPs must correspond to the values of the ipFamilies field. Both clusterIPs and ipFamilies are governed by the ipFamilyPolicy field. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies</summary>
    [JsonPropertyName("clusterIPs")]
    public IList<string>? ClusterIPs { get; set; }

    /// <summary>externalIPs is a list of IP addresses for which nodes in the cluster will also accept traffic for this service.  These IPs are not managed by Kubernetes.  The user is responsible for ensuring that traffic arrives at a node with this IP.  A common example is external load-balancers that are not part of the Kubernetes system.</summary>
    [JsonPropertyName("externalIPs")]
    public IList<string>? ExternalIPs { get; set; }

    /// <summary>externalName is the external reference that discovery mechanisms will return as an alias for this service (e.g. a DNS CNAME record). No proxying will be involved.  Must be a lowercase RFC-1123 hostname (https://tools.ietf.org/html/rfc1123) and requires `type` to be "ExternalName".</summary>
    [JsonPropertyName("externalName")]
    public string? ExternalName { get; set; }

    /// <summary>externalTrafficPolicy describes how nodes distribute service traffic they receive on one of the Service's "externally-facing" addresses (NodePorts, ExternalIPs, and LoadBalancer IPs). If set to "Local", the proxy will configure the service in a way that assumes that external load balancers will take care of balancing the service traffic between nodes, and so each node will deliver traffic only to the node-local endpoints of the service, without masquerading the client source IP. (Traffic mistakenly sent to a node with no endpoints will be dropped.) The default value, "Cluster", uses the standard behavior of routing to all endpoints evenly (possibly modified by topology and other features). Note that traffic sent to an External IP or LoadBalancer IP from within the cluster will always get "Cluster" semantics, but clients sending to a NodePort from within the cluster may need to take traffic policy into account when picking a node.</summary>
    [JsonPropertyName("externalTrafficPolicy")]
    public string? ExternalTrafficPolicy { get; set; }

    /// <summary>healthCheckNodePort specifies the healthcheck nodePort for the service. This only applies when type is set to LoadBalancer and externalTrafficPolicy is set to Local. If a value is specified, is in-range, and is not in use, it will be used.  If not specified, a value will be automatically allocated.  External systems (e.g. load-balancers) can use this port to determine if a given node holds endpoints for this service or not.  If this field is specified when creating a Service which does not need it, creation will fail. This field will be wiped when updating a Service to no longer need it (e.g. changing type). This field cannot be updated once set.</summary>
    [JsonPropertyName("healthCheckNodePort")]
    public int? HealthCheckNodePort { get; set; }

    /// <summary>InternalTrafficPolicy describes how nodes distribute service traffic they receive on the ClusterIP. If set to "Local", the proxy will assume that pods only want to talk to endpoints of the service on the same node as the pod, dropping the traffic if there are no local endpoints. The default value, "Cluster", uses the standard behavior of routing to all endpoints evenly (possibly modified by topology and other features).</summary>
    [JsonPropertyName("internalTrafficPolicy")]
    public string? InternalTrafficPolicy { get; set; }

    /// <summary>IPFamilies is a list of IP families (e.g. IPv4, IPv6) assigned to this service. This field is usually assigned automatically based on cluster configuration and the ipFamilyPolicy field. If this field is specified manually, the requested family is available in the cluster, and ipFamilyPolicy allows it, it will be used; otherwise creation of the service will fail. This field is conditionally mutable: it allows for adding or removing a secondary IP family, but it does not allow changing the primary IP family of the Service. Valid values are "IPv4" and "IPv6".  This field only applies to Services of types ClusterIP, NodePort, and LoadBalancer, and does apply to "headless" services. This field will be wiped when updating a Service to type ExternalName.  This field may hold a maximum of two entries (dual-stack families, in either order).  These families must correspond to the values of the clusterIPs field, if specified. Both clusterIPs and ipFamilies are governed by the ipFamilyPolicy field.</summary>
    [JsonPropertyName("ipFamilies")]
    public IList<string>? IpFamilies { get; set; }

    /// <summary>IPFamilyPolicy represents the dual-stack-ness requested or required by this Service. If there is no value provided, then this field will be set to SingleStack. Services can be "SingleStack" (a single IP family), "PreferDualStack" (two IP families on dual-stack configured clusters or a single IP family on single-stack clusters), or "RequireDualStack" (two IP families on dual-stack configured clusters, otherwise fail). The ipFamilies and clusterIPs fields depend on the value of this field. This field will be wiped when updating a service to type ExternalName.</summary>
    [JsonPropertyName("ipFamilyPolicy")]
    public string? IpFamilyPolicy { get; set; }

    /// <summary>loadBalancerClass is the class of the load balancer implementation this Service belongs to. If specified, the value of this field must be a label-style identifier, with an optional prefix, e.g. "internal-vip" or "example.com/internal-vip". Unprefixed names are reserved for end-users. This field can only be set when the Service type is 'LoadBalancer'. If not set, the default load balancer implementation is used, today this is typically done through the cloud provider integration, but should apply for any default implementation. If set, it is assumed that a load balancer implementation is watching for Services with a matching class. Any default load balancer implementation (e.g. cloud providers) should ignore Services that set this field. This field can only be set when creating or updating a Service to type 'LoadBalancer'. Once set, it can not be changed. This field will be wiped when a service is updated to a non 'LoadBalancer' type.</summary>
    [JsonPropertyName("loadBalancerClass")]
    public string? LoadBalancerClass { get; set; }

    /// <summary>Only applies to Service Type: LoadBalancer. This feature depends on whether the underlying cloud-provider supports specifying the loadBalancerIP when a load balancer is created. This field will be ignored if the cloud-provider does not support the feature. Deprecated: This field was under-specified and its meaning varies across implementations. Using it is non-portable and it may not support dual-stack. Users are encouraged to use implementation-specific annotations when available.</summary>
    [JsonPropertyName("loadBalancerIP")]
    public string? LoadBalancerIP { get; set; }

    /// <summary>If specified and supported by the platform, this will restrict traffic through the cloud-provider load-balancer will be restricted to the specified client IPs. This field will be ignored if the cloud-provider does not support the feature." More info: https://kubernetes.io/docs/tasks/access-application-cluster/create-external-load-balancer/</summary>
    [JsonPropertyName("loadBalancerSourceRanges")]
    public IList<string>? LoadBalancerSourceRanges { get; set; }

    /// <summary>The list of ports that are exposed by this service. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies</summary>
    [JsonPropertyName("ports")]
    public IList<V1ClusterSpecManagedServicesAdditionalServiceTemplateSpecPorts>? Ports { get; set; }

    /// <summary>publishNotReadyAddresses indicates that any agent which deals with endpoints for this Service should disregard any indications of ready/not-ready. The primary use case for setting this field is for a StatefulSet's Headless Service to propagate SRV DNS records for its Pods for the purpose of peer discovery. The Kubernetes controllers that generate Endpoints and EndpointSlice resources for Services interpret this to mean that all endpoints are considered "ready" even if the Pods themselves are not. Agents which consume only Kubernetes generated endpoints through the Endpoints or EndpointSlice resources can safely assume this behavior.</summary>
    [JsonPropertyName("publishNotReadyAddresses")]
    public bool? PublishNotReadyAddresses { get; set; }

    /// <summary>Route service traffic to pods with label keys and values matching this selector. If empty or not present, the service is assumed to have an external process managing its endpoints, which Kubernetes will not modify. Only applies to types ClusterIP, NodePort, and LoadBalancer. Ignored if type is ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/</summary>
    [JsonPropertyName("selector")]
    public IDictionary<string, string>? Selector { get; set; }

    /// <summary>Supports "ClientIP" and "None". Used to maintain session affinity. Enable client IP based session affinity. Must be ClientIP or None. Defaults to None. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies</summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>sessionAffinityConfig contains the configurations of session affinity.</summary>
    [JsonPropertyName("sessionAffinityConfig")]
    public V1ClusterSpecManagedServicesAdditionalServiceTemplateSpecSessionAffinityConfig? SessionAffinityConfig { get; set; }

    /// <summary>TrafficDistribution offers a way to express preferences for how traffic is distributed to Service endpoints. Implementations can use this field as a hint, but are not required to guarantee strict adherence. If the field is not set, the implementation will apply its default routing strategy. If set to "PreferClose", implementations should prioritize endpoints that are topologically close (e.g., same zone). This is a beta field and requires enabling ServiceTrafficDistribution feature.</summary>
    [JsonPropertyName("trafficDistribution")]
    public string? TrafficDistribution { get; set; }

    /// <summary>type determines how the Service is exposed. Defaults to ClusterIP. Valid options are ExternalName, ClusterIP, NodePort, and LoadBalancer. "ClusterIP" allocates a cluster-internal IP address for load-balancing to endpoints. Endpoints are determined by the selector or if that is not specified, by manual construction of an Endpoints object or EndpointSlice objects. If clusterIP is "None", no virtual IP is allocated and the endpoints are published as a set of endpoints rather than a virtual IP. "NodePort" builds on ClusterIP and allocates a port on every node which routes to the same endpoints as the clusterIP. "LoadBalancer" builds on NodePort and creates an external load-balancer (if supported in the current cloud) which routes to the same endpoints as the clusterIP. "ExternalName" aliases this service to the specified externalName. Several other fields do not apply to ExternalName services. More info: https://kubernetes.io/docs/concepts/services-networking/service/#publishing-services-service-types</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ServiceTemplate is the template specification for the service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecManagedServicesAdditionalServiceTemplate
{
    /// <summary>Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ClusterSpecManagedServicesAdditionalServiceTemplateMetadata? Metadata { get; set; }

    /// <summary>Specification of the desired behavior of the service. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("spec")]
    public V1ClusterSpecManagedServicesAdditionalServiceTemplateSpec? Spec { get; set; }
}

/// <summary>ManagedService represents a specific service managed by the cluster. It includes the type of service and its associated template specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecManagedServicesAdditional
{
    /// <summary>SelectorType specifies the type of selectors that the service will have. Valid values are "rw", "r", and "ro", representing read-write, read, and read-only services.</summary>
    [JsonPropertyName("selectorType")]
    public string SelectorType { get; set; }

    /// <summary>ServiceTemplate is the template specification for the service.</summary>
    [JsonPropertyName("serviceTemplate")]
    public V1ClusterSpecManagedServicesAdditionalServiceTemplate ServiceTemplate { get; set; }

    /// <summary>UpdateStrategy describes how the service differences should be reconciled</summary>
    [JsonPropertyName("updateStrategy")]
    public string? UpdateStrategy { get; set; }
}

/// <summary>Services roles managed by the `Cluster`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecManagedServices
{
    /// <summary>Additional is a list of additional managed services specified by the user.</summary>
    [JsonPropertyName("additional")]
    public IList<V1ClusterSpecManagedServicesAdditional>? Additional { get; set; }

    /// <summary>DisabledDefaultServices is a list of service types that are disabled by default. Valid values are "r", and "ro", representing read, and read-only services.</summary>
    [JsonPropertyName("disabledDefaultServices")]
    public IList<string>? DisabledDefaultServices { get; set; }
}

/// <summary>The configuration that is used by the portions of PostgreSQL that are managed by the instance manager</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecManaged
{
    /// <summary>Database roles managed by the `Cluster`</summary>
    [JsonPropertyName("roles")]
    public IList<V1ClusterSpecManagedRoles>? Roles { get; set; }

    /// <summary>Services roles managed by the `Cluster`</summary>
    [JsonPropertyName("services")]
    public V1ClusterSpecManagedServices? Services { get; set; }
}

/// <summary>ConfigMapKeySelector contains enough information to let you locate the key of a ConfigMap</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecMonitoringCustomQueriesConfigMap
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretKeySelector contains enough information to let you locate the key of a Secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecMonitoringCustomQueriesSecret
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>RelabelConfig allows dynamic rewriting of the label set for targets, alerts, scraped samples and remote write samples.  More info: https://prometheus.io/docs/prometheus/latest/configuration/configuration/#relabel_config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecMonitoringPodMonitorMetricRelabelings
{
    /// <summary>Action to perform based on the regex matching.  `Uppercase` and `Lowercase` actions require Prometheus &gt;= v2.36.0. `DropEqual` and `KeepEqual` actions require Prometheus &gt;= v2.41.0.  Default: "Replace"</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Modulus to take of the hash of the source label values.  Only applicable when the action is `HashMod`.</summary>
    [JsonPropertyName("modulus")]
    public long? Modulus { get; set; }

    /// <summary>Regular expression against which the extracted value is matched.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Replacement value against which a Replace action is performed if the regular expression matches.  Regex capture groups are available.</summary>
    [JsonPropertyName("replacement")]
    public string? Replacement { get; set; }

    /// <summary>Separator is the string between concatenated SourceLabels.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>The source labels select values from existing labels. Their content is concatenated using the configured Separator and matched against the configured regular expression.</summary>
    [JsonPropertyName("sourceLabels")]
    public IList<string>? SourceLabels { get; set; }

    /// <summary>Label to which the resulting string is written in a replacement.  It is mandatory for `Replace`, `HashMod`, `Lowercase`, `Uppercase`, `KeepEqual` and `DropEqual` actions.  Regex capture groups are available.</summary>
    [JsonPropertyName("targetLabel")]
    public string? TargetLabel { get; set; }
}

/// <summary>RelabelConfig allows dynamic rewriting of the label set for targets, alerts, scraped samples and remote write samples.  More info: https://prometheus.io/docs/prometheus/latest/configuration/configuration/#relabel_config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecMonitoringPodMonitorRelabelings
{
    /// <summary>Action to perform based on the regex matching.  `Uppercase` and `Lowercase` actions require Prometheus &gt;= v2.36.0. `DropEqual` and `KeepEqual` actions require Prometheus &gt;= v2.41.0.  Default: "Replace"</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Modulus to take of the hash of the source label values.  Only applicable when the action is `HashMod`.</summary>
    [JsonPropertyName("modulus")]
    public long? Modulus { get; set; }

    /// <summary>Regular expression against which the extracted value is matched.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Replacement value against which a Replace action is performed if the regular expression matches.  Regex capture groups are available.</summary>
    [JsonPropertyName("replacement")]
    public string? Replacement { get; set; }

    /// <summary>Separator is the string between concatenated SourceLabels.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    /// <summary>The source labels select values from existing labels. Their content is concatenated using the configured Separator and matched against the configured regular expression.</summary>
    [JsonPropertyName("sourceLabels")]
    public IList<string>? SourceLabels { get; set; }

    /// <summary>Label to which the resulting string is written in a replacement.  It is mandatory for `Replace`, `HashMod`, `Lowercase`, `Uppercase`, `KeepEqual` and `DropEqual` actions.  Regex capture groups are available.</summary>
    [JsonPropertyName("targetLabel")]
    public string? TargetLabel { get; set; }
}

/// <summary>Configure TLS communication for the metrics endpoint. Changing tls.enabled option will force a rollout of all instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecMonitoringTls
{
    /// <summary>Enable TLS for the monitoring endpoint. Changing this option will force a rollout of all instances.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The configuration of the monitoring infrastructure of this cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecMonitoring
{
    /// <summary>The list of config maps containing the custom queries</summary>
    [JsonPropertyName("customQueriesConfigMap")]
    public IList<V1ClusterSpecMonitoringCustomQueriesConfigMap>? CustomQueriesConfigMap { get; set; }

    /// <summary>The list of secrets containing the custom queries</summary>
    [JsonPropertyName("customQueriesSecret")]
    public IList<V1ClusterSpecMonitoringCustomQueriesSecret>? CustomQueriesSecret { get; set; }

    /// <summary>Whether the default queries should be injected. Set it to `true` if you don't want to inject default queries into the cluster. Default: false.</summary>
    [JsonPropertyName("disableDefaultQueries")]
    public bool? DisableDefaultQueries { get; set; }

    /// <summary>Enable or disable the `PodMonitor`</summary>
    [JsonPropertyName("enablePodMonitor")]
    public bool? EnablePodMonitor { get; set; }

    /// <summary>The list of metric relabelings for the `PodMonitor`. Applied to samples before ingestion.</summary>
    [JsonPropertyName("podMonitorMetricRelabelings")]
    public IList<V1ClusterSpecMonitoringPodMonitorMetricRelabelings>? PodMonitorMetricRelabelings { get; set; }

    /// <summary>The list of relabelings for the `PodMonitor`. Applied to samples before scraping.</summary>
    [JsonPropertyName("podMonitorRelabelings")]
    public IList<V1ClusterSpecMonitoringPodMonitorRelabelings>? PodMonitorRelabelings { get; set; }

    /// <summary>Configure TLS communication for the metrics endpoint. Changing tls.enabled option will force a rollout of all instances.</summary>
    [JsonPropertyName("tls")]
    public V1ClusterSpecMonitoringTls? Tls { get; set; }
}

/// <summary>Define a maintenance window for the Kubernetes nodes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecNodeMaintenanceWindow
{
    /// <summary>Is there a node maintenance activity in progress?</summary>
    [JsonPropertyName("inProgress")]
    public bool? InProgress { get; set; }

    /// <summary>Reuse the existing PVC (wait for the node to come up again) or not (recreate it elsewhere - when `instances` &gt;1)</summary>
    [JsonPropertyName("reusePVC")]
    public bool? ReusePVC { get; set; }
}

/// <summary>PluginConfiguration specifies a plugin that need to be loaded for this cluster to be reconciled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecPlugins
{
    /// <summary>Enabled is true if this plugin will be used</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Only one plugin can be declared as WALArchiver. Cannot be active if ".spec.backup.barmanObjectStore" configuration is present.</summary>
    [JsonPropertyName("isWALArchiver")]
    public bool? IsWALArchiver { get; set; }

    /// <summary>Name is the plugin name</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Parameters is the configuration of the plugin</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>Bind as authentication configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecPostgresqlLdapBindAsAuth
{
    /// <summary>Prefix for the bind authentication option</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Suffix for the bind authentication option</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Secret with the password for the user to bind to the directory</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecPostgresqlLdapBindSearchAuthBindPassword
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Bind+Search authentication configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecPostgresqlLdapBindSearchAuth
{
    /// <summary>Root DN to begin the user search</summary>
    [JsonPropertyName("baseDN")]
    public string? BaseDN { get; set; }

    /// <summary>DN of the user to bind to the directory</summary>
    [JsonPropertyName("bindDN")]
    public string? BindDN { get; set; }

    /// <summary>Secret with the password for the user to bind to the directory</summary>
    [JsonPropertyName("bindPassword")]
    public V1ClusterSpecPostgresqlLdapBindSearchAuthBindPassword? BindPassword { get; set; }

    /// <summary>Attribute to match against the username</summary>
    [JsonPropertyName("searchAttribute")]
    public string? SearchAttribute { get; set; }

    /// <summary>Search filter to use when doing the search+bind authentication</summary>
    [JsonPropertyName("searchFilter")]
    public string? SearchFilter { get; set; }
}

/// <summary>Options to specify LDAP configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecPostgresqlLdap
{
    /// <summary>Bind as authentication configuration</summary>
    [JsonPropertyName("bindAsAuth")]
    public V1ClusterSpecPostgresqlLdapBindAsAuth? BindAsAuth { get; set; }

    /// <summary>Bind+Search authentication configuration</summary>
    [JsonPropertyName("bindSearchAuth")]
    public V1ClusterSpecPostgresqlLdapBindSearchAuth? BindSearchAuth { get; set; }

    /// <summary>LDAP server port</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>LDAP schema to be used, possible options are `ldap` and `ldaps`</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>LDAP hostname or IP address</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>Set to 'true' to enable LDAP over TLS. 'false' is default</summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }
}

/// <summary>Requirements to be met by sync replicas. This will affect how the "synchronous_standby_names" parameter will be set up.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecPostgresqlSyncReplicaElectionConstraint
{
    /// <summary>This flag enables the constraints for sync replicas</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>A list of node labels values to extract and compare to evaluate if the pods reside in the same topology or not</summary>
    [JsonPropertyName("nodeLabelsAntiAffinity")]
    public IList<string>? NodeLabelsAntiAffinity { get; set; }
}

/// <summary>Configuration of the PostgreSQL synchronous replication feature</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecPostgresqlSynchronous
{
    /// <summary>If set to "required", data durability is strictly enforced. Write operations with synchronous commit settings (`on`, `remote_write`, or `remote_apply`) will block if there are insufficient healthy replicas, ensuring data persistence. If set to "preferred", data durability is maintained when healthy replicas are available, but the required number of instances will adjust dynamically if replicas become unavailable. This setting relaxes strict durability enforcement to allow for operational continuity. This setting is only applicable if both `standbyNamesPre` and `standbyNamesPost` are unset (empty).</summary>
    [JsonPropertyName("dataDurability")]
    public string? DataDurability { get; set; }

    /// <summary>Specifies the maximum number of local cluster pods that can be automatically included in the `synchronous_standby_names` option in PostgreSQL.</summary>
    [JsonPropertyName("maxStandbyNamesFromCluster")]
    public int? MaxStandbyNamesFromCluster { get; set; }

    /// <summary>Method to select synchronous replication standbys from the listed servers, accepting 'any' (quorum-based synchronous replication) or 'first' (priority-based synchronous replication) as values.</summary>
    [JsonPropertyName("method")]
    public string Method { get; set; }

    /// <summary>Specifies the number of synchronous standby servers that transactions must wait for responses from.</summary>
    [JsonPropertyName("number")]
    public int Number { get; set; }

    /// <summary>A user-defined list of application names to be added to `synchronous_standby_names` after local cluster pods (the order is only useful for priority-based synchronous replication).</summary>
    [JsonPropertyName("standbyNamesPost")]
    public IList<string>? StandbyNamesPost { get; set; }

    /// <summary>A user-defined list of application names to be added to `synchronous_standby_names` before local cluster pods (the order is only useful for priority-based synchronous replication).</summary>
    [JsonPropertyName("standbyNamesPre")]
    public IList<string>? StandbyNamesPre { get; set; }
}

/// <summary>Configuration of the PostgreSQL server</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecPostgresql
{
    /// <summary>If this parameter is true, the user will be able to invoke `ALTER SYSTEM` on this CloudNativePG Cluster. This should only be used for debugging and troubleshooting. Defaults to false.</summary>
    [JsonPropertyName("enableAlterSystem")]
    public bool? EnableAlterSystem { get; set; }

    /// <summary>Options to specify LDAP configuration</summary>
    [JsonPropertyName("ldap")]
    public V1ClusterSpecPostgresqlLdap? Ldap { get; set; }

    /// <summary>PostgreSQL configuration options (postgresql.conf)</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>PostgreSQL Host Based Authentication rules (lines to be appended to the pg_hba.conf file)</summary>
    [JsonPropertyName("pg_hba")]
    public IList<string>? PgHba { get; set; }

    /// <summary>PostgreSQL User Name Maps rules (lines to be appended to the pg_ident.conf file)</summary>
    [JsonPropertyName("pg_ident")]
    public IList<string>? PgIdent { get; set; }

    /// <summary>Specifies the maximum number of seconds to wait when promoting an instance to primary. Default value is 40000000, greater than one year in seconds, big enough to simulate an infinite timeout</summary>
    [JsonPropertyName("promotionTimeout")]
    public int? PromotionTimeout { get; set; }

    /// <summary>Lists of shared preload libraries to add to the default ones</summary>
    [JsonPropertyName("shared_preload_libraries")]
    public IList<string>? SharedPreloadLibraries { get; set; }

    /// <summary>Requirements to be met by sync replicas. This will affect how the "synchronous_standby_names" parameter will be set up.</summary>
    [JsonPropertyName("syncReplicaElectionConstraint")]
    public V1ClusterSpecPostgresqlSyncReplicaElectionConstraint? SyncReplicaElectionConstraint { get; set; }

    /// <summary>Configuration of the PostgreSQL synchronous replication feature</summary>
    [JsonPropertyName("synchronous")]
    public V1ClusterSpecPostgresqlSynchronous? Synchronous { get; set; }
}

/// <summary>The liveness probe configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProbesLiveness
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>The readiness probe configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProbesReadiness
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>The startup probe configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProbesStartup
{
    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>The configuration of the probes to be injected in the PostgreSQL Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProbes
{
    /// <summary>The liveness probe configuration</summary>
    [JsonPropertyName("liveness")]
    public V1ClusterSpecProbesLiveness? Liveness { get; set; }

    /// <summary>The readiness probe configuration</summary>
    [JsonPropertyName("readiness")]
    public V1ClusterSpecProbesReadiness? Readiness { get; set; }

    /// <summary>The startup probe configuration</summary>
    [JsonPropertyName("startup")]
    public V1ClusterSpecProbesStartup? Startup { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProjectedVolumeTemplateSourcesClusterTrustBundleLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Select all ClusterTrustBundles that match this label selector.  Only has effect if signerName is set.  Mutually-exclusive with name.  If unset, interpreted as "match nothing".  If set but empty, interpreted as "match everything".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProjectedVolumeTemplateSourcesClusterTrustBundleLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecProjectedVolumeTemplateSourcesClusterTrustBundleLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>ClusterTrustBundle allows a pod to access the `.spec.trustBundle` field of ClusterTrustBundle objects in an auto-updating file.  Alpha, gated by the ClusterTrustBundleProjection feature gate.  ClusterTrustBundle objects can either be selected by name, or by the combination of signer name and a label selector.  Kubelet performs aggressive normalization of the PEM contents written into the pod filesystem.  Esoteric PEM features such as inter-block comments and block headers are stripped.  Certificates are deduplicated. The ordering of certificates within the file is arbitrary, and Kubelet may change the order over time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProjectedVolumeTemplateSourcesClusterTrustBundle
{
    /// <summary>Select all ClusterTrustBundles that match this label selector.  Only has effect if signerName is set.  Mutually-exclusive with name.  If unset, interpreted as "match nothing".  If set but empty, interpreted as "match everything".</summary>
    [JsonPropertyName("labelSelector")]
    public V1ClusterSpecProjectedVolumeTemplateSourcesClusterTrustBundleLabelSelector? LabelSelector { get; set; }

    /// <summary>Select a single ClusterTrustBundle by object name.  Mutually-exclusive with signerName and labelSelector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>If true, don't block pod startup if the referenced ClusterTrustBundle(s) aren't available.  If using name, then the named ClusterTrustBundle is allowed not to exist.  If using signerName, then the combination of signerName and labelSelector is allowed to match zero ClusterTrustBundles.</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    /// <summary>Relative path from the volume root to write the bundle.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>Select all ClusterTrustBundles that match this signer name. Mutually-exclusive with name.  The contents of all selected ClusterTrustBundles will be unified and deduplicated.</summary>
    [JsonPropertyName("signerName")]
    public string? SignerName { get; set; }
}

/// <summary>Maps a string key to a path within a volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProjectedVolumeTemplateSourcesConfigMapItems
{
    /// <summary>key is the key to project.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>mode is Optional: mode bits used to set permissions on this file. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>path is the relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>configMap information about the configMap data to project</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProjectedVolumeTemplateSourcesConfigMap
{
    /// <summary>items if unspecified, each key-value pair in the Data field of the referenced ConfigMap will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the ConfigMap, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
    [JsonPropertyName("items")]
    public IList<V1ClusterSpecProjectedVolumeTemplateSourcesConfigMapItems>? Items { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>optional specify whether the ConfigMap or its keys must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Required: Selects a field of the pod: only annotations, labels, name, namespace and uid are supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProjectedVolumeTemplateSourcesDownwardAPIItemsFieldRef
{
    /// <summary>Version of the schema the FieldPath is written in terms of, defaults to "v1".</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Path of the field to select in the specified API version.</summary>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }
}

/// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProjectedVolumeTemplateSourcesDownwardAPIItemsResourceFieldRef
{
    /// <summary>Container name: required for volumes, optional for env vars</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Specifies the output format of the exposed resources, defaults to "1"</summary>
    [JsonPropertyName("divisor")]
    public IntstrIntOrString? Divisor { get; set; }

    /// <summary>Required: resource to select</summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }
}

/// <summary>DownwardAPIVolumeFile represents information to create the file containing the pod field</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProjectedVolumeTemplateSourcesDownwardAPIItems
{
    /// <summary>Required: Selects a field of the pod: only annotations, labels, name, namespace and uid are supported.</summary>
    [JsonPropertyName("fieldRef")]
    public V1ClusterSpecProjectedVolumeTemplateSourcesDownwardAPIItemsFieldRef? FieldRef { get; set; }

    /// <summary>Optional: mode bits used to set permissions on this file, must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.</summary>
    [JsonPropertyName("resourceFieldRef")]
    public V1ClusterSpecProjectedVolumeTemplateSourcesDownwardAPIItemsResourceFieldRef? ResourceFieldRef { get; set; }
}

/// <summary>downwardAPI information about the downwardAPI data to project</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProjectedVolumeTemplateSourcesDownwardAPI
{
    /// <summary>Items is a list of DownwardAPIVolume file</summary>
    [JsonPropertyName("items")]
    public IList<V1ClusterSpecProjectedVolumeTemplateSourcesDownwardAPIItems>? Items { get; set; }
}

/// <summary>Maps a string key to a path within a volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProjectedVolumeTemplateSourcesSecretItems
{
    /// <summary>key is the key to project.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>mode is Optional: mode bits used to set permissions on this file. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>path is the relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>secret information about the secret data to project</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProjectedVolumeTemplateSourcesSecret
{
    /// <summary>items if unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
    [JsonPropertyName("items")]
    public IList<V1ClusterSpecProjectedVolumeTemplateSourcesSecretItems>? Items { get; set; }

    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>optional field specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>serviceAccountToken is information about the serviceAccountToken data to project</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProjectedVolumeTemplateSourcesServiceAccountToken
{
    /// <summary>audience is the intended audience of the token. A recipient of a token must identify itself with an identifier specified in the audience of the token, and otherwise should reject the token. The audience defaults to the identifier of the apiserver.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>expirationSeconds is the requested duration of validity of the service account token. As the token approaches expiration, the kubelet volume plugin will proactively rotate the service account token. The kubelet will start trying to rotate the token if the token is older than 80 percent of its time to live or if the token is older than 24 hours.Defaults to 1 hour and must be at least 10 minutes.</summary>
    [JsonPropertyName("expirationSeconds")]
    public long? ExpirationSeconds { get; set; }

    /// <summary>path is the path relative to the mount point of the file to project the token into.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary>Projection that may be projected along with other supported volume types. Exactly one of these fields must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProjectedVolumeTemplateSources
{
    /// <summary>ClusterTrustBundle allows a pod to access the `.spec.trustBundle` field of ClusterTrustBundle objects in an auto-updating file.  Alpha, gated by the ClusterTrustBundleProjection feature gate.  ClusterTrustBundle objects can either be selected by name, or by the combination of signer name and a label selector.  Kubelet performs aggressive normalization of the PEM contents written into the pod filesystem.  Esoteric PEM features such as inter-block comments and block headers are stripped.  Certificates are deduplicated. The ordering of certificates within the file is arbitrary, and Kubelet may change the order over time.</summary>
    [JsonPropertyName("clusterTrustBundle")]
    public V1ClusterSpecProjectedVolumeTemplateSourcesClusterTrustBundle? ClusterTrustBundle { get; set; }

    /// <summary>configMap information about the configMap data to project</summary>
    [JsonPropertyName("configMap")]
    public V1ClusterSpecProjectedVolumeTemplateSourcesConfigMap? ConfigMap { get; set; }

    /// <summary>downwardAPI information about the downwardAPI data to project</summary>
    [JsonPropertyName("downwardAPI")]
    public V1ClusterSpecProjectedVolumeTemplateSourcesDownwardAPI? DownwardAPI { get; set; }

    /// <summary>secret information about the secret data to project</summary>
    [JsonPropertyName("secret")]
    public V1ClusterSpecProjectedVolumeTemplateSourcesSecret? Secret { get; set; }

    /// <summary>serviceAccountToken is information about the serviceAccountToken data to project</summary>
    [JsonPropertyName("serviceAccountToken")]
    public V1ClusterSpecProjectedVolumeTemplateSourcesServiceAccountToken? ServiceAccountToken { get; set; }
}

/// <summary>Template to be used to define projected volumes, projected volumes will be mounted under `/projected` base folder</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecProjectedVolumeTemplate
{
    /// <summary>defaultMode are the mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>sources is the list of volume projections. Each entry in this list handles one source.</summary>
    [JsonPropertyName("sources")]
    public IList<V1ClusterSpecProjectedVolumeTemplateSources>? Sources { get; set; }
}

/// <summary>Replica cluster configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecReplica
{
    /// <summary>If replica mode is enabled, this cluster will be a replica of an existing cluster. Replica cluster can be created from a recovery object store or via streaming through pg_basebackup. Refer to the Replica clusters page of the documentation for more information.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>When replica mode is enabled, this parameter allows you to replay transactions only when the system time is at least the configured time past the commit time. This provides an opportunity to correct data loss errors. Note that when this parameter is set, a promotion token cannot be used.</summary>
    [JsonPropertyName("minApplyDelay")]
    public string? MinApplyDelay { get; set; }

    /// <summary>Primary defines which Cluster is defined to be the primary in the distributed PostgreSQL cluster, based on the topology specified in externalClusters</summary>
    [JsonPropertyName("primary")]
    public string? Primary { get; set; }

    /// <summary>A demotion token generated by an external cluster used to check if the promotion requirements are met.</summary>
    [JsonPropertyName("promotionToken")]
    public string? PromotionToken { get; set; }

    /// <summary>Self defines the name of this cluster. It is used to determine if this is a primary or a replica cluster, comparing it with `primary`</summary>
    [JsonPropertyName("self")]
    public string? Self { get; set; }

    /// <summary>The name of the external cluster which is the replication origin</summary>
    [JsonPropertyName("source")]
    public string Source { get; set; }
}

/// <summary>Replication slots for high availability configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecReplicationSlotsHighAvailability
{
    /// <summary>If enabled (default), the operator will automatically manage replication slots on the primary instance and use them in streaming replication connections with all the standby instances that are part of the HA cluster. If disabled, the operator will not take advantage of replication slots in streaming connections with the replicas. This feature also controls replication slots in replica cluster, from the designated primary to its cascading replicas.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Prefix for replication slots managed by the operator for HA. It may only contain lower case letters, numbers, and the underscore character. This can only be set at creation time. By default set to `_cnpg_`.</summary>
    [JsonPropertyName("slotPrefix")]
    public string? SlotPrefix { get; set; }
}

/// <summary>Configures the synchronization of the user defined physical replication slots</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecReplicationSlotsSynchronizeReplicas
{
    /// <summary>When set to true, every replication slot that is on the primary is synchronized on each standby</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>List of regular expression patterns to match the names of replication slots to be excluded (by default empty)</summary>
    [JsonPropertyName("excludePatterns")]
    public IList<string>? ExcludePatterns { get; set; }
}

/// <summary>Replication slots management configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecReplicationSlots
{
    /// <summary>Replication slots for high availability configuration</summary>
    [JsonPropertyName("highAvailability")]
    public V1ClusterSpecReplicationSlotsHighAvailability? HighAvailability { get; set; }

    /// <summary>Configures the synchronization of the user defined physical replication slots</summary>
    [JsonPropertyName("synchronizeReplicas")]
    public V1ClusterSpecReplicationSlotsSynchronizeReplicas? SynchronizeReplicas { get; set; }

    /// <summary>Standby will update the status of the local replication slots every `updateInterval` seconds (default 30).</summary>
    [JsonPropertyName("updateInterval")]
    public int? UpdateInterval { get; set; }
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecResourcesClaims
{
    /// <summary>Name must match the name of one entry in pod.spec.resourceClaims of the Pod where this field is used. It makes that resource available inside a container.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Request is the name chosen for a request in the referenced claim. If empty, everything from the claim is made available, otherwise only the result of this request.</summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>Resources requirements of every generated Pod. Please refer to https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/ for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecResources
{
    /// <summary>Claims lists the names of resources, defined in spec.resourceClaims, that are used by this container.  This is an alpha field and requires enabling the DynamicResourceAllocation feature gate.  This field is immutable. It can only be set for containers.</summary>
    [JsonPropertyName("claims")]
    public IList<V1ClusterSpecResourcesClaims>? Claims { get; set; }

    /// <summary>Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntstrIntOrString>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntstrIntOrString>? Requests { get; set; }
}

/// <summary>The SeccompProfile applied to every Pod and Container. Defaults to: `RuntimeDefault`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecSeccompProfile
{
    /// <summary>localhostProfile indicates a profile defined in a file on the node should be used. The profile must be preconfigured on the node to work. Must be a descending path, relative to the kubelet's configured seccomp profile location. Must be set if type is "Localhost". Must NOT be set for any other type.</summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary>type indicates which kind of seccomp profile will be applied. Valid options are:  Localhost - a profile defined in a file on the node should be used. RuntimeDefault - the container runtime default profile should be used. Unconfined - no profile should be applied.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Metadata are the metadata to be used for the generated service account</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecServiceAccountTemplateMetadata
{
    /// <summary>Annotations is an unstructured key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when modifying objects. More info: http://kubernetes.io/docs/user-guide/annotations</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects. May match selectors of replication controllers and services. More info: http://kubernetes.io/docs/user-guide/labels</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the resource. Only supported for certain types</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configure the generation of the service account</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecServiceAccountTemplate
{
    /// <summary>Metadata are the metadata to be used for the generated service account</summary>
    [JsonPropertyName("metadata")]
    public V1ClusterSpecServiceAccountTemplateMetadata Metadata { get; set; }
}

/// <summary>dataSource field can be used to specify either: * An existing VolumeSnapshot object (snapshot.storage.k8s.io/VolumeSnapshot) * An existing PVC (PersistentVolumeClaim) If the provisioner or an external controller can support the specified data source, it will create a new volume based on the contents of the specified data source. When the AnyVolumeDataSource feature gate is enabled, dataSource contents will be copied to dataSourceRef, and dataSourceRef contents will be copied to dataSource when dataSourceRef.namespace is not specified. If the namespace is specified, then dataSourceRef will not be copied to dataSource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecStoragePvcTemplateDataSource
{
    /// <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>Kind is the type of resource being referenced</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of resource being referenced</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>dataSourceRef specifies the object from which to populate the volume with data, if a non-empty volume is desired. This may be any object from a non-empty API group (non core object) or a PersistentVolumeClaim object. When this field is specified, volume binding will only succeed if the type of the specified object matches some installed volume populator or dynamic provisioner. This field will replace the functionality of the dataSource field and as such if both fields are non-empty, they must have the same value. For backwards compatibility, when namespace isn't specified in dataSourceRef, both fields (dataSource and dataSourceRef) will be set to the same value automatically if one of them is empty and the other is non-empty. When namespace is specified in dataSourceRef, dataSource isn't set to the same value and must be empty. There are three important differences between dataSource and dataSourceRef: * While dataSource only allows two specific types of objects, dataSourceRef   allows any non-core object, as well as PersistentVolumeClaim objects. * While dataSource ignores disallowed values (dropping them), dataSourceRef   preserves all values, and generates an error if a disallowed value is   specified. * While dataSource only allows local objects, dataSourceRef allows objects   in any namespaces. (Beta) Using this field requires the AnyVolumeDataSource feature gate to be enabled. (Alpha) Using the namespace field of dataSourceRef requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecStoragePvcTemplateDataSourceRef
{
    /// <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>Kind is the type of resource being referenced</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of resource being referenced</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace is the namespace of resource being referenced Note that when a namespace is specified, a gateway.networking.k8s.io/ReferenceGrant object is required in the referent namespace to allow that namespace's owner to accept the reference. See the ReferenceGrant documentation for details. (Alpha) This field requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>resources represents the minimum resources the volume should have. If RecoverVolumeExpansionFailure feature is enabled users are allowed to specify resource requirements that are lower than previous value but must still be higher than capacity recorded in the status field of the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecStoragePvcTemplateResources
{
    /// <summary>Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntstrIntOrString>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntstrIntOrString>? Requests { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecStoragePvcTemplateSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>selector is a label query over volumes to consider for binding.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecStoragePvcTemplateSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecStoragePvcTemplateSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Template to be used to generate the Persistent Volume Claim</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecStoragePvcTemplate
{
    /// <summary>accessModes contains the desired access modes the volume should have. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1</summary>
    [JsonPropertyName("accessModes")]
    public IList<string>? AccessModes { get; set; }

    /// <summary>dataSource field can be used to specify either: * An existing VolumeSnapshot object (snapshot.storage.k8s.io/VolumeSnapshot) * An existing PVC (PersistentVolumeClaim) If the provisioner or an external controller can support the specified data source, it will create a new volume based on the contents of the specified data source. When the AnyVolumeDataSource feature gate is enabled, dataSource contents will be copied to dataSourceRef, and dataSourceRef contents will be copied to dataSource when dataSourceRef.namespace is not specified. If the namespace is specified, then dataSourceRef will not be copied to dataSource.</summary>
    [JsonPropertyName("dataSource")]
    public V1ClusterSpecStoragePvcTemplateDataSource? DataSource { get; set; }

    /// <summary>dataSourceRef specifies the object from which to populate the volume with data, if a non-empty volume is desired. This may be any object from a non-empty API group (non core object) or a PersistentVolumeClaim object. When this field is specified, volume binding will only succeed if the type of the specified object matches some installed volume populator or dynamic provisioner. This field will replace the functionality of the dataSource field and as such if both fields are non-empty, they must have the same value. For backwards compatibility, when namespace isn't specified in dataSourceRef, both fields (dataSource and dataSourceRef) will be set to the same value automatically if one of them is empty and the other is non-empty. When namespace is specified in dataSourceRef, dataSource isn't set to the same value and must be empty. There are three important differences between dataSource and dataSourceRef: * While dataSource only allows two specific types of objects, dataSourceRef   allows any non-core object, as well as PersistentVolumeClaim objects. * While dataSource ignores disallowed values (dropping them), dataSourceRef   preserves all values, and generates an error if a disallowed value is   specified. * While dataSource only allows local objects, dataSourceRef allows objects   in any namespaces. (Beta) Using this field requires the AnyVolumeDataSource feature gate to be enabled. (Alpha) Using the namespace field of dataSourceRef requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
    [JsonPropertyName("dataSourceRef")]
    public V1ClusterSpecStoragePvcTemplateDataSourceRef? DataSourceRef { get; set; }

    /// <summary>resources represents the minimum resources the volume should have. If RecoverVolumeExpansionFailure feature is enabled users are allowed to specify resource requirements that are lower than previous value but must still be higher than capacity recorded in the status field of the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources</summary>
    [JsonPropertyName("resources")]
    public V1ClusterSpecStoragePvcTemplateResources? Resources { get; set; }

    /// <summary>selector is a label query over volumes to consider for binding.</summary>
    [JsonPropertyName("selector")]
    public V1ClusterSpecStoragePvcTemplateSelector? Selector { get; set; }

    /// <summary>storageClassName is the name of the StorageClass required by the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#class-1</summary>
    [JsonPropertyName("storageClassName")]
    public string? StorageClassName { get; set; }

    /// <summary>volumeAttributesClassName may be used to set the VolumeAttributesClass used by this claim. If specified, the CSI driver will create or update the volume with the attributes defined in the corresponding VolumeAttributesClass. This has a different purpose than storageClassName, it can be changed after the claim is created. An empty string value means that no VolumeAttributesClass will be applied to the claim but it's not allowed to reset this field to empty string once it is set. If unspecified and the PersistentVolumeClaim is unbound, the default VolumeAttributesClass will be set by the persistentvolume controller if it exists. If the resource referred to by volumeAttributesClass does not exist, this PersistentVolumeClaim will be set to a Pending state, as reflected by the modifyVolumeStatus field, until such as a resource exists. More info: https://kubernetes.io/docs/concepts/storage/volume-attributes-classes/ (Beta) Using this field requires the VolumeAttributesClass feature gate to be enabled (off by default).</summary>
    [JsonPropertyName("volumeAttributesClassName")]
    public string? VolumeAttributesClassName { get; set; }

    /// <summary>volumeMode defines what type of volume is required by the claim. Value of Filesystem is implied when not included in claim spec.</summary>
    [JsonPropertyName("volumeMode")]
    public string? VolumeMode { get; set; }

    /// <summary>volumeName is the binding reference to the PersistentVolume backing this claim.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>Configuration of the storage of the instances</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecStorage
{
    /// <summary>Template to be used to generate the Persistent Volume Claim</summary>
    [JsonPropertyName("pvcTemplate")]
    public V1ClusterSpecStoragePvcTemplate? PvcTemplate { get; set; }

    /// <summary>Resize existent PVCs, defaults to true</summary>
    [JsonPropertyName("resizeInUseVolumes")]
    public bool? ResizeInUseVolumes { get; set; }

    /// <summary>Size of the storage. Required if not already specified in the PVC template. Changes to this field are automatically reapplied to the created PVCs. Size cannot be decreased.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>StorageClass to use for PVCs. Applied after evaluating the PVC template, if available. If not specified, the generated PVCs will use the default storage class</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary>The secret containing the superuser password. If not defined a new secret will be created with a randomly generated password</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecSuperuserSecret
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Owner is the PostgreSQL user owning the tablespace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecTablespacesOwner
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>dataSource field can be used to specify either: * An existing VolumeSnapshot object (snapshot.storage.k8s.io/VolumeSnapshot) * An existing PVC (PersistentVolumeClaim) If the provisioner or an external controller can support the specified data source, it will create a new volume based on the contents of the specified data source. When the AnyVolumeDataSource feature gate is enabled, dataSource contents will be copied to dataSourceRef, and dataSourceRef contents will be copied to dataSource when dataSourceRef.namespace is not specified. If the namespace is specified, then dataSourceRef will not be copied to dataSource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecTablespacesStoragePvcTemplateDataSource
{
    /// <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>Kind is the type of resource being referenced</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of resource being referenced</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>dataSourceRef specifies the object from which to populate the volume with data, if a non-empty volume is desired. This may be any object from a non-empty API group (non core object) or a PersistentVolumeClaim object. When this field is specified, volume binding will only succeed if the type of the specified object matches some installed volume populator or dynamic provisioner. This field will replace the functionality of the dataSource field and as such if both fields are non-empty, they must have the same value. For backwards compatibility, when namespace isn't specified in dataSourceRef, both fields (dataSource and dataSourceRef) will be set to the same value automatically if one of them is empty and the other is non-empty. When namespace is specified in dataSourceRef, dataSource isn't set to the same value and must be empty. There are three important differences between dataSource and dataSourceRef: * While dataSource only allows two specific types of objects, dataSourceRef   allows any non-core object, as well as PersistentVolumeClaim objects. * While dataSource ignores disallowed values (dropping them), dataSourceRef   preserves all values, and generates an error if a disallowed value is   specified. * While dataSource only allows local objects, dataSourceRef allows objects   in any namespaces. (Beta) Using this field requires the AnyVolumeDataSource feature gate to be enabled. (Alpha) Using the namespace field of dataSourceRef requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecTablespacesStoragePvcTemplateDataSourceRef
{
    /// <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>Kind is the type of resource being referenced</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of resource being referenced</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace is the namespace of resource being referenced Note that when a namespace is specified, a gateway.networking.k8s.io/ReferenceGrant object is required in the referent namespace to allow that namespace's owner to accept the reference. See the ReferenceGrant documentation for details. (Alpha) This field requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>resources represents the minimum resources the volume should have. If RecoverVolumeExpansionFailure feature is enabled users are allowed to specify resource requirements that are lower than previous value but must still be higher than capacity recorded in the status field of the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecTablespacesStoragePvcTemplateResources
{
    /// <summary>Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntstrIntOrString>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntstrIntOrString>? Requests { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecTablespacesStoragePvcTemplateSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>selector is a label query over volumes to consider for binding.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecTablespacesStoragePvcTemplateSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecTablespacesStoragePvcTemplateSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Template to be used to generate the Persistent Volume Claim</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecTablespacesStoragePvcTemplate
{
    /// <summary>accessModes contains the desired access modes the volume should have. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1</summary>
    [JsonPropertyName("accessModes")]
    public IList<string>? AccessModes { get; set; }

    /// <summary>dataSource field can be used to specify either: * An existing VolumeSnapshot object (snapshot.storage.k8s.io/VolumeSnapshot) * An existing PVC (PersistentVolumeClaim) If the provisioner or an external controller can support the specified data source, it will create a new volume based on the contents of the specified data source. When the AnyVolumeDataSource feature gate is enabled, dataSource contents will be copied to dataSourceRef, and dataSourceRef contents will be copied to dataSource when dataSourceRef.namespace is not specified. If the namespace is specified, then dataSourceRef will not be copied to dataSource.</summary>
    [JsonPropertyName("dataSource")]
    public V1ClusterSpecTablespacesStoragePvcTemplateDataSource? DataSource { get; set; }

    /// <summary>dataSourceRef specifies the object from which to populate the volume with data, if a non-empty volume is desired. This may be any object from a non-empty API group (non core object) or a PersistentVolumeClaim object. When this field is specified, volume binding will only succeed if the type of the specified object matches some installed volume populator or dynamic provisioner. This field will replace the functionality of the dataSource field and as such if both fields are non-empty, they must have the same value. For backwards compatibility, when namespace isn't specified in dataSourceRef, both fields (dataSource and dataSourceRef) will be set to the same value automatically if one of them is empty and the other is non-empty. When namespace is specified in dataSourceRef, dataSource isn't set to the same value and must be empty. There are three important differences between dataSource and dataSourceRef: * While dataSource only allows two specific types of objects, dataSourceRef   allows any non-core object, as well as PersistentVolumeClaim objects. * While dataSource ignores disallowed values (dropping them), dataSourceRef   preserves all values, and generates an error if a disallowed value is   specified. * While dataSource only allows local objects, dataSourceRef allows objects   in any namespaces. (Beta) Using this field requires the AnyVolumeDataSource feature gate to be enabled. (Alpha) Using the namespace field of dataSourceRef requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
    [JsonPropertyName("dataSourceRef")]
    public V1ClusterSpecTablespacesStoragePvcTemplateDataSourceRef? DataSourceRef { get; set; }

    /// <summary>resources represents the minimum resources the volume should have. If RecoverVolumeExpansionFailure feature is enabled users are allowed to specify resource requirements that are lower than previous value but must still be higher than capacity recorded in the status field of the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources</summary>
    [JsonPropertyName("resources")]
    public V1ClusterSpecTablespacesStoragePvcTemplateResources? Resources { get; set; }

    /// <summary>selector is a label query over volumes to consider for binding.</summary>
    [JsonPropertyName("selector")]
    public V1ClusterSpecTablespacesStoragePvcTemplateSelector? Selector { get; set; }

    /// <summary>storageClassName is the name of the StorageClass required by the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#class-1</summary>
    [JsonPropertyName("storageClassName")]
    public string? StorageClassName { get; set; }

    /// <summary>volumeAttributesClassName may be used to set the VolumeAttributesClass used by this claim. If specified, the CSI driver will create or update the volume with the attributes defined in the corresponding VolumeAttributesClass. This has a different purpose than storageClassName, it can be changed after the claim is created. An empty string value means that no VolumeAttributesClass will be applied to the claim but it's not allowed to reset this field to empty string once it is set. If unspecified and the PersistentVolumeClaim is unbound, the default VolumeAttributesClass will be set by the persistentvolume controller if it exists. If the resource referred to by volumeAttributesClass does not exist, this PersistentVolumeClaim will be set to a Pending state, as reflected by the modifyVolumeStatus field, until such as a resource exists. More info: https://kubernetes.io/docs/concepts/storage/volume-attributes-classes/ (Beta) Using this field requires the VolumeAttributesClass feature gate to be enabled (off by default).</summary>
    [JsonPropertyName("volumeAttributesClassName")]
    public string? VolumeAttributesClassName { get; set; }

    /// <summary>volumeMode defines what type of volume is required by the claim. Value of Filesystem is implied when not included in claim spec.</summary>
    [JsonPropertyName("volumeMode")]
    public string? VolumeMode { get; set; }

    /// <summary>volumeName is the binding reference to the PersistentVolume backing this claim.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>The storage configuration for the tablespace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecTablespacesStorage
{
    /// <summary>Template to be used to generate the Persistent Volume Claim</summary>
    [JsonPropertyName("pvcTemplate")]
    public V1ClusterSpecTablespacesStoragePvcTemplate? PvcTemplate { get; set; }

    /// <summary>Resize existent PVCs, defaults to true</summary>
    [JsonPropertyName("resizeInUseVolumes")]
    public bool? ResizeInUseVolumes { get; set; }

    /// <summary>Size of the storage. Required if not already specified in the PVC template. Changes to this field are automatically reapplied to the created PVCs. Size cannot be decreased.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>StorageClass to use for PVCs. Applied after evaluating the PVC template, if available. If not specified, the generated PVCs will use the default storage class</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary>TablespaceConfiguration is the configuration of a tablespace, and includes the storage specification for the tablespace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecTablespaces
{
    /// <summary>The name of the tablespace</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Owner is the PostgreSQL user owning the tablespace</summary>
    [JsonPropertyName("owner")]
    public V1ClusterSpecTablespacesOwner? Owner { get; set; }

    /// <summary>The storage configuration for the tablespace</summary>
    [JsonPropertyName("storage")]
    public V1ClusterSpecTablespacesStorage Storage { get; set; }

    /// <summary>When set to true, the tablespace will be added as a `temp_tablespaces` entry in PostgreSQL, and will be available to automatically house temp database objects, or other temporary files. Please refer to PostgreSQL documentation for more information on the `temp_tablespaces` GUC.</summary>
    [JsonPropertyName("temporary")]
    public bool? Temporary { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecTopologySpreadConstraintsLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>LabelSelector is used to find matching pods. Pods that match this label selector are counted to determine the number of pods in their corresponding topology domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecTopologySpreadConstraintsLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>TopologySpreadConstraint specifies how to spread matching pods among the given topology.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecTopologySpreadConstraints
{
    /// <summary>LabelSelector is used to find matching pods. Pods that match this label selector are counted to determine the number of pods in their corresponding topology domain.</summary>
    [JsonPropertyName("labelSelector")]
    public V1ClusterSpecTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select the pods over which spreading will be calculated. The keys are used to lookup values from the incoming pod labels, those key-value labels are ANDed with labelSelector to select the group of existing pods over which spreading will be calculated for the incoming pod. The same key is forbidden to exist in both MatchLabelKeys and LabelSelector. MatchLabelKeys cannot be set when LabelSelector isn't set. Keys that don't exist in the incoming pod labels will be ignored. A null or empty list means only match against labelSelector.  This is a beta field and requires the MatchLabelKeysInPodTopologySpread feature gate to be enabled (enabled by default).</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MaxSkew describes the degree to which pods may be unevenly distributed. When `whenUnsatisfiable=DoNotSchedule`, it is the maximum permitted difference between the number of matching pods in the target topology and the global minimum. The global minimum is the minimum number of matching pods in an eligible domain or zero if the number of eligible domains is less than MinDomains. For example, in a 3-zone cluster, MaxSkew is set to 1, and pods with the same labelSelector spread as 2/2/1: In this case, the global minimum is 1. | zone1 | zone2 | zone3 | |  P P  |  P P  |   P   | - if MaxSkew is 1, incoming pod can only be scheduled to zone3 to become 2/2/2; scheduling it onto zone1(zone2) would make the ActualSkew(3-1) on zone1(zone2) violate MaxSkew(1). - if MaxSkew is 2, incoming pod can be scheduled onto any zone. When `whenUnsatisfiable=ScheduleAnyway`, it is used to give higher precedence to topologies that satisfy it. It's a required field. Default value is 1 and 0 is not allowed.</summary>
    [JsonPropertyName("maxSkew")]
    public int MaxSkew { get; set; }

    /// <summary>MinDomains indicates a minimum number of eligible domains. When the number of eligible domains with matching topology keys is less than minDomains, Pod Topology Spread treats "global minimum" as 0, and then the calculation of Skew is performed. And when the number of eligible domains with matching topology keys equals or greater than minDomains, this value has no effect on scheduling. As a result, when the number of eligible domains is less than minDomains, scheduler won't schedule more than maxSkew Pods to those domains. If value is nil, the constraint behaves as if MinDomains is equal to 1. Valid values are integers greater than 0. When value is not nil, WhenUnsatisfiable must be DoNotSchedule.  For example, in a 3-zone cluster, MaxSkew is set to 2, MinDomains is set to 5 and pods with the same labelSelector spread as 2/2/2: | zone1 | zone2 | zone3 | |  P P  |  P P  |  P P  | The number of domains is less than 5(MinDomains), so "global minimum" is treated as 0. In this situation, new pod with the same labelSelector cannot be scheduled, because computed skew will be 3(3 - 0) if new Pod is scheduled to any of the three zones, it will violate MaxSkew.</summary>
    [JsonPropertyName("minDomains")]
    public int? MinDomains { get; set; }

    /// <summary>NodeAffinityPolicy indicates how we will treat Pod's nodeAffinity/nodeSelector when calculating pod topology spread skew. Options are: - Honor: only nodes matching nodeAffinity/nodeSelector are included in the calculations. - Ignore: nodeAffinity/nodeSelector are ignored. All nodes are included in the calculations.  If this value is nil, the behavior is equivalent to the Honor policy. This is a beta-level feature default enabled by the NodeInclusionPolicyInPodTopologySpread feature flag.</summary>
    [JsonPropertyName("nodeAffinityPolicy")]
    public string? NodeAffinityPolicy { get; set; }

    /// <summary>NodeTaintsPolicy indicates how we will treat node taints when calculating pod topology spread skew. Options are: - Honor: nodes without taints, along with tainted nodes for which the incoming pod has a toleration, are included. - Ignore: node taints are ignored. All nodes are included.  If this value is nil, the behavior is equivalent to the Ignore policy. This is a beta-level feature default enabled by the NodeInclusionPolicyInPodTopologySpread feature flag.</summary>
    [JsonPropertyName("nodeTaintsPolicy")]
    public string? NodeTaintsPolicy { get; set; }

    /// <summary>TopologyKey is the key of node labels. Nodes that have a label with this key and identical values are considered to be in the same topology. We consider each &lt;key, value&gt; as a "bucket", and try to put balanced number of pods into each bucket. We define a domain as a particular instance of a topology. Also, we define an eligible domain as a domain whose nodes meet the requirements of nodeAffinityPolicy and nodeTaintsPolicy. e.g. If TopologyKey is "kubernetes.io/hostname", each Node is a domain of that topology. And, if TopologyKey is "topology.kubernetes.io/zone", each zone is a domain of that topology. It's a required field.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }

    /// <summary>WhenUnsatisfiable indicates how to deal with a pod if it doesn't satisfy the spread constraint. - DoNotSchedule (default) tells the scheduler not to schedule it. - ScheduleAnyway tells the scheduler to schedule the pod in any location,   but giving higher precedence to topologies that would help reduce the   skew. A constraint is considered "Unsatisfiable" for an incoming pod if and only if every possible node assignment for that pod would violate "MaxSkew" on some topology. For example, in a 3-zone cluster, MaxSkew is set to 1, and pods with the same labelSelector spread as 3/1/1: | zone1 | zone2 | zone3 | | P P P |   P   |   P   | If WhenUnsatisfiable is set to DoNotSchedule, incoming pod can only be scheduled to zone2(zone3) to become 3/2/1(3/1/2) as ActualSkew(2-1) on zone2(zone3) satisfies MaxSkew(1). In other words, the cluster can still be imbalanced, but scheduler won't make it *more* imbalanced. It's a required field.</summary>
    [JsonPropertyName("whenUnsatisfiable")]
    public string WhenUnsatisfiable { get; set; }
}

/// <summary>dataSource field can be used to specify either: * An existing VolumeSnapshot object (snapshot.storage.k8s.io/VolumeSnapshot) * An existing PVC (PersistentVolumeClaim) If the provisioner or an external controller can support the specified data source, it will create a new volume based on the contents of the specified data source. When the AnyVolumeDataSource feature gate is enabled, dataSource contents will be copied to dataSourceRef, and dataSourceRef contents will be copied to dataSource when dataSourceRef.namespace is not specified. If the namespace is specified, then dataSourceRef will not be copied to dataSource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecWalStoragePvcTemplateDataSource
{
    /// <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>Kind is the type of resource being referenced</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of resource being referenced</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>dataSourceRef specifies the object from which to populate the volume with data, if a non-empty volume is desired. This may be any object from a non-empty API group (non core object) or a PersistentVolumeClaim object. When this field is specified, volume binding will only succeed if the type of the specified object matches some installed volume populator or dynamic provisioner. This field will replace the functionality of the dataSource field and as such if both fields are non-empty, they must have the same value. For backwards compatibility, when namespace isn't specified in dataSourceRef, both fields (dataSource and dataSourceRef) will be set to the same value automatically if one of them is empty and the other is non-empty. When namespace is specified in dataSourceRef, dataSource isn't set to the same value and must be empty. There are three important differences between dataSource and dataSourceRef: * While dataSource only allows two specific types of objects, dataSourceRef   allows any non-core object, as well as PersistentVolumeClaim objects. * While dataSource ignores disallowed values (dropping them), dataSourceRef   preserves all values, and generates an error if a disallowed value is   specified. * While dataSource only allows local objects, dataSourceRef allows objects   in any namespaces. (Beta) Using this field requires the AnyVolumeDataSource feature gate to be enabled. (Alpha) Using the namespace field of dataSourceRef requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecWalStoragePvcTemplateDataSourceRef
{
    /// <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>Kind is the type of resource being referenced</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name is the name of resource being referenced</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace is the namespace of resource being referenced Note that when a namespace is specified, a gateway.networking.k8s.io/ReferenceGrant object is required in the referent namespace to allow that namespace's owner to accept the reference. See the ReferenceGrant documentation for details. (Alpha) This field requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>resources represents the minimum resources the volume should have. If RecoverVolumeExpansionFailure feature is enabled users are allowed to specify resource requirements that are lower than previous value but must still be higher than capacity recorded in the status field of the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecWalStoragePvcTemplateResources
{
    /// <summary>Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntstrIntOrString>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntstrIntOrString>? Requests { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecWalStoragePvcTemplateSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>selector is a label query over volumes to consider for binding.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecWalStoragePvcTemplateSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ClusterSpecWalStoragePvcTemplateSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Template to be used to generate the Persistent Volume Claim</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecWalStoragePvcTemplate
{
    /// <summary>accessModes contains the desired access modes the volume should have. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1</summary>
    [JsonPropertyName("accessModes")]
    public IList<string>? AccessModes { get; set; }

    /// <summary>dataSource field can be used to specify either: * An existing VolumeSnapshot object (snapshot.storage.k8s.io/VolumeSnapshot) * An existing PVC (PersistentVolumeClaim) If the provisioner or an external controller can support the specified data source, it will create a new volume based on the contents of the specified data source. When the AnyVolumeDataSource feature gate is enabled, dataSource contents will be copied to dataSourceRef, and dataSourceRef contents will be copied to dataSource when dataSourceRef.namespace is not specified. If the namespace is specified, then dataSourceRef will not be copied to dataSource.</summary>
    [JsonPropertyName("dataSource")]
    public V1ClusterSpecWalStoragePvcTemplateDataSource? DataSource { get; set; }

    /// <summary>dataSourceRef specifies the object from which to populate the volume with data, if a non-empty volume is desired. This may be any object from a non-empty API group (non core object) or a PersistentVolumeClaim object. When this field is specified, volume binding will only succeed if the type of the specified object matches some installed volume populator or dynamic provisioner. This field will replace the functionality of the dataSource field and as such if both fields are non-empty, they must have the same value. For backwards compatibility, when namespace isn't specified in dataSourceRef, both fields (dataSource and dataSourceRef) will be set to the same value automatically if one of them is empty and the other is non-empty. When namespace is specified in dataSourceRef, dataSource isn't set to the same value and must be empty. There are three important differences between dataSource and dataSourceRef: * While dataSource only allows two specific types of objects, dataSourceRef   allows any non-core object, as well as PersistentVolumeClaim objects. * While dataSource ignores disallowed values (dropping them), dataSourceRef   preserves all values, and generates an error if a disallowed value is   specified. * While dataSource only allows local objects, dataSourceRef allows objects   in any namespaces. (Beta) Using this field requires the AnyVolumeDataSource feature gate to be enabled. (Alpha) Using the namespace field of dataSourceRef requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
    [JsonPropertyName("dataSourceRef")]
    public V1ClusterSpecWalStoragePvcTemplateDataSourceRef? DataSourceRef { get; set; }

    /// <summary>resources represents the minimum resources the volume should have. If RecoverVolumeExpansionFailure feature is enabled users are allowed to specify resource requirements that are lower than previous value but must still be higher than capacity recorded in the status field of the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources</summary>
    [JsonPropertyName("resources")]
    public V1ClusterSpecWalStoragePvcTemplateResources? Resources { get; set; }

    /// <summary>selector is a label query over volumes to consider for binding.</summary>
    [JsonPropertyName("selector")]
    public V1ClusterSpecWalStoragePvcTemplateSelector? Selector { get; set; }

    /// <summary>storageClassName is the name of the StorageClass required by the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#class-1</summary>
    [JsonPropertyName("storageClassName")]
    public string? StorageClassName { get; set; }

    /// <summary>volumeAttributesClassName may be used to set the VolumeAttributesClass used by this claim. If specified, the CSI driver will create or update the volume with the attributes defined in the corresponding VolumeAttributesClass. This has a different purpose than storageClassName, it can be changed after the claim is created. An empty string value means that no VolumeAttributesClass will be applied to the claim but it's not allowed to reset this field to empty string once it is set. If unspecified and the PersistentVolumeClaim is unbound, the default VolumeAttributesClass will be set by the persistentvolume controller if it exists. If the resource referred to by volumeAttributesClass does not exist, this PersistentVolumeClaim will be set to a Pending state, as reflected by the modifyVolumeStatus field, until such as a resource exists. More info: https://kubernetes.io/docs/concepts/storage/volume-attributes-classes/ (Beta) Using this field requires the VolumeAttributesClass feature gate to be enabled (off by default).</summary>
    [JsonPropertyName("volumeAttributesClassName")]
    public string? VolumeAttributesClassName { get; set; }

    /// <summary>volumeMode defines what type of volume is required by the claim. Value of Filesystem is implied when not included in claim spec.</summary>
    [JsonPropertyName("volumeMode")]
    public string? VolumeMode { get; set; }

    /// <summary>volumeName is the binding reference to the PersistentVolume backing this claim.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>Configuration of the storage for PostgreSQL WAL (Write-Ahead Log)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpecWalStorage
{
    /// <summary>Template to be used to generate the Persistent Volume Claim</summary>
    [JsonPropertyName("pvcTemplate")]
    public V1ClusterSpecWalStoragePvcTemplate? PvcTemplate { get; set; }

    /// <summary>Resize existent PVCs, defaults to true</summary>
    [JsonPropertyName("resizeInUseVolumes")]
    public bool? ResizeInUseVolumes { get; set; }

    /// <summary>Size of the storage. Required if not already specified in the PVC template. Changes to this field are automatically reapplied to the created PVCs. Size cannot be decreased.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>StorageClass to use for PVCs. Applied after evaluating the PVC template, if available. If not specified, the generated PVCs will use the default storage class</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary>Specification of the desired behavior of the cluster. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterSpec
{
    /// <summary>Affinity/Anti-affinity rules for Pods</summary>
    [JsonPropertyName("affinity")]
    public V1ClusterSpecAffinity? Affinity { get; set; }

    /// <summary>The configuration to be used for backups</summary>
    [JsonPropertyName("backup")]
    public V1ClusterSpecBackup? Backup { get; set; }

    /// <summary>Instructions to bootstrap this cluster</summary>
    [JsonPropertyName("bootstrap")]
    public V1ClusterSpecBootstrap? Bootstrap { get; set; }

    /// <summary>The configuration for the CA and related certificates</summary>
    [JsonPropertyName("certificates")]
    public V1ClusterSpecCertificates? Certificates { get; set; }

    /// <summary>Description of this PostgreSQL cluster</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Manage the `PodDisruptionBudget` resources within the cluster. When configured as `true` (default setting), the pod disruption budgets will safeguard the primary node from being terminated. Conversely, setting it to `false` will result in the absence of any `PodDisruptionBudget` resource, permitting the shutdown of all nodes hosting the PostgreSQL cluster. This latter configuration is advisable for any PostgreSQL cluster employed for development/staging purposes.</summary>
    [JsonPropertyName("enablePDB")]
    public bool? EnablePDB { get; set; }

    /// <summary>When this option is enabled, the operator will use the `SuperuserSecret` to update the `postgres` user password (if the secret is not present, the operator will automatically create one). When this option is disabled, the operator will ignore the `SuperuserSecret` content, delete it when automatically created, and then blank the password of the `postgres` user by setting it to `NULL`. Disabled by default.</summary>
    [JsonPropertyName("enableSuperuserAccess")]
    public bool? EnableSuperuserAccess { get; set; }

    /// <summary>Env follows the Env format to pass environment variables to the pods created in the cluster</summary>
    [JsonPropertyName("env")]
    public IList<V1ClusterSpecEnv>? Env { get; set; }

    /// <summary>EnvFrom follows the EnvFrom format to pass environment variables sources to the pods to be used by Env</summary>
    [JsonPropertyName("envFrom")]
    public IList<V1ClusterSpecEnvFrom>? EnvFrom { get; set; }

    /// <summary>EphemeralVolumeSource allows the user to configure the source of ephemeral volumes.</summary>
    [JsonPropertyName("ephemeralVolumeSource")]
    public V1ClusterSpecEphemeralVolumeSource? EphemeralVolumeSource { get; set; }

    /// <summary>EphemeralVolumesSizeLimit allows the user to set the limits for the ephemeral volumes</summary>
    [JsonPropertyName("ephemeralVolumesSizeLimit")]
    public V1ClusterSpecEphemeralVolumesSizeLimit? EphemeralVolumesSizeLimit { get; set; }

    /// <summary>The list of external clusters which are used in the configuration</summary>
    [JsonPropertyName("externalClusters")]
    public IList<V1ClusterSpecExternalClusters>? ExternalClusters { get; set; }

    /// <summary>The amount of time (in seconds) to wait before triggering a failover after the primary PostgreSQL instance in the cluster was detected to be unhealthy</summary>
    [JsonPropertyName("failoverDelay")]
    public int? FailoverDelay { get; set; }

    /// <summary>Defines the major PostgreSQL version we want to use within an ImageCatalog</summary>
    [JsonPropertyName("imageCatalogRef")]
    public V1ClusterSpecImageCatalogRef? ImageCatalogRef { get; set; }

    /// <summary>Name of the container image, supporting both tags (`&lt;image&gt;:&lt;tag&gt;`) and digests for deterministic and repeatable deployments (`&lt;image&gt;:&lt;tag&gt;@sha256:&lt;digestValue&gt;`)</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>Image pull policy. One of `Always`, `Never` or `IfNotPresent`. If not defined, it defaults to `IfNotPresent`. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>The list of pull secrets to be used to pull the images</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1ClusterSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>Metadata that will be inherited by all objects related to the Cluster</summary>
    [JsonPropertyName("inheritedMetadata")]
    public V1ClusterSpecInheritedMetadata? InheritedMetadata { get; set; }

    /// <summary>Number of instances required in the cluster</summary>
    [JsonPropertyName("instances")]
    public int Instances { get; set; }

    /// <summary>LivenessProbeTimeout is the time (in seconds) that is allowed for a PostgreSQL instance to successfully respond to the liveness probe (default 30). The Liveness probe failure threshold is derived from this value using the formula: ceiling(livenessProbe / 10).</summary>
    [JsonPropertyName("livenessProbeTimeout")]
    public int? LivenessProbeTimeout { get; set; }

    /// <summary>The instances' log level, one of the following values: error, warning, info (default), debug, trace</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>The configuration that is used by the portions of PostgreSQL that are managed by the instance manager</summary>
    [JsonPropertyName("managed")]
    public V1ClusterSpecManaged? Managed { get; set; }

    /// <summary>The target value for the synchronous replication quorum, that can be decreased if the number of ready standbys is lower than this. Undefined or 0 disable synchronous replication.</summary>
    [JsonPropertyName("maxSyncReplicas")]
    public int? MaxSyncReplicas { get; set; }

    /// <summary>Minimum number of instances required in synchronous replication with the primary. Undefined or 0 allow writes to complete when no standby is available.</summary>
    [JsonPropertyName("minSyncReplicas")]
    public int? MinSyncReplicas { get; set; }

    /// <summary>The configuration of the monitoring infrastructure of this cluster</summary>
    [JsonPropertyName("monitoring")]
    public V1ClusterSpecMonitoring? Monitoring { get; set; }

    /// <summary>Define a maintenance window for the Kubernetes nodes</summary>
    [JsonPropertyName("nodeMaintenanceWindow")]
    public V1ClusterSpecNodeMaintenanceWindow? NodeMaintenanceWindow { get; set; }

    /// <summary>The plugins configuration, containing any plugin to be loaded with the corresponding configuration</summary>
    [JsonPropertyName("plugins")]
    public IList<V1ClusterSpecPlugins>? Plugins { get; set; }

    /// <summary>The GID of the `postgres` user inside the image, defaults to `26`</summary>
    [JsonPropertyName("postgresGID")]
    public long? PostgresGID { get; set; }

    /// <summary>The UID of the `postgres` user inside the image, defaults to `26`</summary>
    [JsonPropertyName("postgresUID")]
    public long? PostgresUID { get; set; }

    /// <summary>Configuration of the PostgreSQL server</summary>
    [JsonPropertyName("postgresql")]
    public V1ClusterSpecPostgresql? Postgresql { get; set; }

    /// <summary>Method to follow to upgrade the primary server during a rolling update procedure, after all replicas have been successfully updated: it can be with a switchover (`switchover`) or in-place (`restart` - default)</summary>
    [JsonPropertyName("primaryUpdateMethod")]
    public string? PrimaryUpdateMethod { get; set; }

    /// <summary>Deployment strategy to follow to upgrade the primary server during a rolling update procedure, after all replicas have been successfully updated: it can be automated (`unsupervised` - default) or manual (`supervised`)</summary>
    [JsonPropertyName("primaryUpdateStrategy")]
    public string? PrimaryUpdateStrategy { get; set; }

    /// <summary>Name of the priority class which will be used in every generated Pod, if the PriorityClass specified does not exist, the pod will not be able to schedule.  Please refer to https://kubernetes.io/docs/concepts/scheduling-eviction/pod-priority-preemption/#priorityclass for more information</summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>The configuration of the probes to be injected in the PostgreSQL Pods.</summary>
    [JsonPropertyName("probes")]
    public V1ClusterSpecProbes? Probes { get; set; }

    /// <summary>Template to be used to define projected volumes, projected volumes will be mounted under `/projected` base folder</summary>
    [JsonPropertyName("projectedVolumeTemplate")]
    public V1ClusterSpecProjectedVolumeTemplate? ProjectedVolumeTemplate { get; set; }

    /// <summary>Replica cluster configuration</summary>
    [JsonPropertyName("replica")]
    public V1ClusterSpecReplica? Replica { get; set; }

    /// <summary>Replication slots management configuration</summary>
    [JsonPropertyName("replicationSlots")]
    public V1ClusterSpecReplicationSlots? ReplicationSlots { get; set; }

    /// <summary>Resources requirements of every generated Pod. Please refer to https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/ for more information.</summary>
    [JsonPropertyName("resources")]
    public V1ClusterSpecResources? Resources { get; set; }

    /// <summary>If specified, the pod will be dispatched by specified Kubernetes scheduler. If not specified, the pod will be dispatched by the default scheduler. More info: https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/</summary>
    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    /// <summary>The SeccompProfile applied to every Pod and Container. Defaults to: `RuntimeDefault`</summary>
    [JsonPropertyName("seccompProfile")]
    public V1ClusterSpecSeccompProfile? SeccompProfile { get; set; }

    /// <summary>Configure the generation of the service account</summary>
    [JsonPropertyName("serviceAccountTemplate")]
    public V1ClusterSpecServiceAccountTemplate? ServiceAccountTemplate { get; set; }

    /// <summary>The time in seconds that controls the window of time reserved for the smart shutdown of Postgres to complete. Make sure you reserve enough time for the operator to request a fast shutdown of Postgres (that is: `stopDelay` - `smartShutdownTimeout`).</summary>
    [JsonPropertyName("smartShutdownTimeout")]
    public int? SmartShutdownTimeout { get; set; }

    /// <summary>The time in seconds that is allowed for a PostgreSQL instance to successfully start up (default 3600). The startup probe failure threshold is derived from this value using the formula: ceiling(startDelay / 10).</summary>
    [JsonPropertyName("startDelay")]
    public int? StartDelay { get; set; }

    /// <summary>The time in seconds that is allowed for a PostgreSQL instance to gracefully shutdown (default 1800)</summary>
    [JsonPropertyName("stopDelay")]
    public int? StopDelay { get; set; }

    /// <summary>Configuration of the storage of the instances</summary>
    [JsonPropertyName("storage")]
    public V1ClusterSpecStorage? Storage { get; set; }

    /// <summary>The secret containing the superuser password. If not defined a new secret will be created with a randomly generated password</summary>
    [JsonPropertyName("superuserSecret")]
    public V1ClusterSpecSuperuserSecret? SuperuserSecret { get; set; }

    /// <summary>The time in seconds that is allowed for a primary PostgreSQL instance to gracefully shutdown during a switchover. Default value is 3600 seconds (1 hour).</summary>
    [JsonPropertyName("switchoverDelay")]
    public int? SwitchoverDelay { get; set; }

    /// <summary>The tablespaces configuration</summary>
    [JsonPropertyName("tablespaces")]
    public IList<V1ClusterSpecTablespaces>? Tablespaces { get; set; }

    /// <summary>TopologySpreadConstraints specifies how to spread matching pods among the given topology. More info: https://kubernetes.io/docs/concepts/scheduling-eviction/topology-spread-constraints/</summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1ClusterSpecTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary>Configuration of the storage for PostgreSQL WAL (Write-Ahead Log)</summary>
    [JsonPropertyName("walStorage")]
    public V1ClusterSpecWalStorage? WalStorage { get; set; }
}

/// <summary>AvailableArchitecture represents the state of a cluster's architecture</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterStatusAvailableArchitectures
{
    /// <summary>GoArch is the name of the executable architecture</summary>
    [JsonPropertyName("goArch")]
    public string GoArch { get; set; }

    /// <summary>Hash is the hash of the executable</summary>
    [JsonPropertyName("hash")]
    public string Hash { get; set; }
}

/// <summary>The configuration for the CA and related certificates, initialized with defaults.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterStatusCertificates
{
    /// <summary>The secret containing the Client CA certificate. If not defined, a new secret will be created with a self-signed CA and will be used to generate all the client certificates.&lt;br /&gt; &lt;br /&gt; Contains:&lt;br /&gt; &lt;br /&gt; - `ca.crt`: CA that should be used to validate the client certificates, used as `ssl_ca_file` of all the instances.&lt;br /&gt; - `ca.key`: key used to generate client certificates, if ReplicationTLSSecret is provided, this can be omitted.&lt;br /&gt;</summary>
    [JsonPropertyName("clientCASecret")]
    public string? ClientCASecret { get; set; }

    /// <summary>Expiration dates for all certificates.</summary>
    [JsonPropertyName("expirations")]
    public IDictionary<string, string>? Expirations { get; set; }

    /// <summary>The secret of type kubernetes.io/tls containing the client certificate to authenticate as the `streaming_replica` user. If not defined, ClientCASecret must provide also `ca.key`, and a new secret will be created using the provided CA.</summary>
    [JsonPropertyName("replicationTLSSecret")]
    public string? ReplicationTLSSecret { get; set; }

    /// <summary>The list of the server alternative DNS names to be added to the generated server TLS certificates, when required.</summary>
    [JsonPropertyName("serverAltDNSNames")]
    public IList<string>? ServerAltDNSNames { get; set; }

    /// <summary>The secret containing the Server CA certificate. If not defined, a new secret will be created with a self-signed CA and will be used to generate the TLS certificate ServerTLSSecret.&lt;br /&gt; &lt;br /&gt; Contains:&lt;br /&gt; &lt;br /&gt; - `ca.crt`: CA that should be used to validate the server certificate, used as `sslrootcert` in client connection strings.&lt;br /&gt; - `ca.key`: key used to generate Server SSL certs, if ServerTLSSecret is provided, this can be omitted.&lt;br /&gt;</summary>
    [JsonPropertyName("serverCASecret")]
    public string? ServerCASecret { get; set; }

    /// <summary>The secret of type kubernetes.io/tls containing the server TLS certificate and key that will be set as `ssl_cert_file` and `ssl_key_file` so that clients can connect to postgres securely. If not defined, ServerCASecret must provide also `ca.key` and a new secret will be created using the provided CA.</summary>
    [JsonPropertyName("serverTLSSecret")]
    public string? ServerTLSSecret { get; set; }
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterStatusConditions
{
    /// <summary>lastTransitionTime is the last time the condition transitioned from one status to another. This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>message is a human readable message indicating details about the transition. This may be an empty string.</summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>observedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>reason contains a programmatic identifier indicating the reason for the condition's last transition. Producers of specific condition types may define expected values and meanings for this field, and whether the values are considered a guaranteed API. The value should be a CamelCase string. This field may not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>The list of resource versions of the configmaps, managed by the operator. Every change here is done in the interest of the instance manager, which will refresh the configmap data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterStatusConfigMapResourceVersion
{
    /// <summary>A map with the versions of all the config maps used to pass metrics. Map keys are the config map names, map values are the versions</summary>
    [JsonPropertyName("metrics")]
    public IDictionary<string, string>? Metrics { get; set; }
}

/// <summary>InstanceReportedState describes the last reported state of an instance during a reconciliation loop</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterStatusInstancesReportedState
{
    /// <summary>indicates if an instance is the primary one</summary>
    [JsonPropertyName("isPrimary")]
    public bool IsPrimary { get; set; }

    /// <summary>indicates on which TimelineId the instance is</summary>
    [JsonPropertyName("timeLineID")]
    public int? TimeLineID { get; set; }
}

/// <summary>PasswordState represents the state of the password of a managed RoleConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterStatusManagedRolesStatusPasswordStatus
{
    /// <summary>the resource version of the password secret</summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>the last transaction ID to affect the role definition in PostgreSQL</summary>
    [JsonPropertyName("transactionID")]
    public long? TransactionID { get; set; }
}

/// <summary>ManagedRolesStatus reports the state of the managed roles in the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterStatusManagedRolesStatus
{
    /// <summary>ByStatus gives the list of roles in each state</summary>
    [JsonPropertyName("byStatus")]
    public IDictionary<string, IList<string>>? ByStatus { get; set; }

    /// <summary>CannotReconcile lists roles that cannot be reconciled in PostgreSQL, with an explanation of the cause</summary>
    [JsonPropertyName("cannotReconcile")]
    public IDictionary<string, IList<string>>? CannotReconcile { get; set; }

    /// <summary>PasswordStatus gives the last transaction id and password secret version for each managed role</summary>
    [JsonPropertyName("passwordStatus")]
    public IDictionary<string, V1ClusterStatusManagedRolesStatusPasswordStatus>? PasswordStatus { get; set; }
}

/// <summary>PluginStatus is the status of a loaded plugin</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterStatusPluginStatus
{
    /// <summary>BackupCapabilities are the list of capabilities of the plugin regarding the Backup management</summary>
    [JsonPropertyName("backupCapabilities")]
    public IList<string>? BackupCapabilities { get; set; }

    /// <summary>Capabilities are the list of capabilities of the plugin</summary>
    [JsonPropertyName("capabilities")]
    public IList<string>? Capabilities { get; set; }

    /// <summary>Name is the name of the plugin</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>OperatorCapabilities are the list of capabilities of the plugin regarding the reconciler</summary>
    [JsonPropertyName("operatorCapabilities")]
    public IList<string>? OperatorCapabilities { get; set; }

    /// <summary>RestoreJobHookCapabilities are the list of capabilities of the plugin regarding the RestoreJobHook management</summary>
    [JsonPropertyName("restoreJobHookCapabilities")]
    public IList<string>? RestoreJobHookCapabilities { get; set; }

    /// <summary>Status contain the status reported by the plugin through the SetStatusInCluster interface</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Version is the version of the plugin loaded by the latest reconciliation loop</summary>
    [JsonPropertyName("version")]
    public string Version { get; set; }

    /// <summary>WALCapabilities are the list of capabilities of the plugin regarding the WAL management</summary>
    [JsonPropertyName("walCapabilities")]
    public IList<string>? WalCapabilities { get; set; }
}

/// <summary>PgBouncerIntegrationStatus encapsulates the needed integration for the pgbouncer poolers referencing the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterStatusPoolerIntegrationsPgBouncerIntegration
{
    /// <summary></summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }
}

/// <summary>The integration needed by poolers referencing the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterStatusPoolerIntegrations
{
    /// <summary>PgBouncerIntegrationStatus encapsulates the needed integration for the pgbouncer poolers referencing the cluster</summary>
    [JsonPropertyName("pgBouncerIntegration")]
    public V1ClusterStatusPoolerIntegrationsPgBouncerIntegration? PgBouncerIntegration { get; set; }
}

/// <summary>The list of resource versions of the secrets managed by the operator. Every change here is done in the interest of the instance manager, which will refresh the secret data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterStatusSecretsResourceVersion
{
    /// <summary>The resource version of the "app" user secret</summary>
    [JsonPropertyName("applicationSecretVersion")]
    public string? ApplicationSecretVersion { get; set; }

    /// <summary>The resource version of the Barman Endpoint CA if provided</summary>
    [JsonPropertyName("barmanEndpointCA")]
    public string? BarmanEndpointCA { get; set; }

    /// <summary>Unused. Retained for compatibility with old versions.</summary>
    [JsonPropertyName("caSecretVersion")]
    public string? CaSecretVersion { get; set; }

    /// <summary>The resource version of the PostgreSQL client-side CA secret version</summary>
    [JsonPropertyName("clientCaSecretVersion")]
    public string? ClientCaSecretVersion { get; set; }

    /// <summary>The resource versions of the external cluster secrets</summary>
    [JsonPropertyName("externalClusterSecretVersion")]
    public IDictionary<string, string>? ExternalClusterSecretVersion { get; set; }

    /// <summary>The resource versions of the managed roles secrets</summary>
    [JsonPropertyName("managedRoleSecretVersion")]
    public IDictionary<string, string>? ManagedRoleSecretVersion { get; set; }

    /// <summary>A map with the versions of all the secrets used to pass metrics. Map keys are the secret names, map values are the versions</summary>
    [JsonPropertyName("metrics")]
    public IDictionary<string, string>? Metrics { get; set; }

    /// <summary>The resource version of the "streaming_replica" user secret</summary>
    [JsonPropertyName("replicationSecretVersion")]
    public string? ReplicationSecretVersion { get; set; }

    /// <summary>The resource version of the PostgreSQL server-side CA secret version</summary>
    [JsonPropertyName("serverCaSecretVersion")]
    public string? ServerCaSecretVersion { get; set; }

    /// <summary>The resource version of the PostgreSQL server-side secret version</summary>
    [JsonPropertyName("serverSecretVersion")]
    public string? ServerSecretVersion { get; set; }

    /// <summary>The resource version of the "postgres" user secret</summary>
    [JsonPropertyName("superuserSecretVersion")]
    public string? SuperuserSecretVersion { get; set; }
}

/// <summary>SwitchReplicaClusterStatus is the status of the switch to replica cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterStatusSwitchReplicaClusterStatus
{
    /// <summary>InProgress indicates if there is an ongoing procedure of switching a cluster to a replica cluster.</summary>
    [JsonPropertyName("inProgress")]
    public bool? InProgress { get; set; }
}

/// <summary>TablespaceState represents the state of a tablespace in a cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterStatusTablespacesStatus
{
    /// <summary>Error is the reconciliation error, if any</summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>Name is the name of the tablespace</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Owner is the PostgreSQL user owning the tablespace</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>State is the latest reconciliation state</summary>
    [JsonPropertyName("state")]
    public string State { get; set; }
}

/// <summary>Instances topology.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterStatusTopology
{
    /// <summary>Instances contains the pod topology of the instances</summary>
    [JsonPropertyName("instances")]
    public IDictionary<string, IDictionary<string, string>>? Instances { get; set; }

    /// <summary>NodesUsed represents the count of distinct nodes accommodating the instances. A value of '1' suggests that all instances are hosted on a single node, implying the absence of High Availability (HA). Ideally, this value should be the same as the number of instances in the Postgres HA cluster, implying shared nothing architecture on the compute side.</summary>
    [JsonPropertyName("nodesUsed")]
    public int? NodesUsed { get; set; }

    /// <summary>SuccessfullyExtracted indicates if the topology data was extract. It is useful to enact fallback behaviors in synchronous replica election in case of failures</summary>
    [JsonPropertyName("successfullyExtracted")]
    public bool? SuccessfullyExtracted { get; set; }
}

/// <summary>Most recently observed status of the cluster. This data may not be up to date. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterStatus
{
    /// <summary>AvailableArchitectures reports the available architectures of a cluster</summary>
    [JsonPropertyName("availableArchitectures")]
    public IList<V1ClusterStatusAvailableArchitectures>? AvailableArchitectures { get; set; }

    /// <summary>AzurePVCUpdateEnabled shows if the PVC online upgrade is enabled for this cluster</summary>
    [JsonPropertyName("azurePVCUpdateEnabled")]
    public bool? AzurePVCUpdateEnabled { get; set; }

    /// <summary>The configuration for the CA and related certificates, initialized with defaults.</summary>
    [JsonPropertyName("certificates")]
    public V1ClusterStatusCertificates? Certificates { get; set; }

    /// <summary>The commit hash number of which this operator running</summary>
    [JsonPropertyName("cloudNativePGCommitHash")]
    public string? CloudNativePGCommitHash { get; set; }

    /// <summary>The hash of the binary of the operator</summary>
    [JsonPropertyName("cloudNativePGOperatorHash")]
    public string? CloudNativePGOperatorHash { get; set; }

    /// <summary>Conditions for cluster object</summary>
    [JsonPropertyName("conditions")]
    public IList<V1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>The list of resource versions of the configmaps, managed by the operator. Every change here is done in the interest of the instance manager, which will refresh the configmap data</summary>
    [JsonPropertyName("configMapResourceVersion")]
    public V1ClusterStatusConfigMapResourceVersion? ConfigMapResourceVersion { get; set; }

    /// <summary>Current primary instance</summary>
    [JsonPropertyName("currentPrimary")]
    public string? CurrentPrimary { get; set; }

    /// <summary>The timestamp when the primary was detected to be unhealthy This field is reported when `.spec.failoverDelay` is populated or during online upgrades</summary>
    [JsonPropertyName("currentPrimaryFailingSinceTimestamp")]
    public string? CurrentPrimaryFailingSinceTimestamp { get; set; }

    /// <summary>The timestamp when the last actual promotion to primary has occurred</summary>
    [JsonPropertyName("currentPrimaryTimestamp")]
    public string? CurrentPrimaryTimestamp { get; set; }

    /// <summary>List of all the PVCs created by this cluster and still available which are not attached to a Pod</summary>
    [JsonPropertyName("danglingPVC")]
    public IList<string>? DanglingPVC { get; set; }

    /// <summary>DemotionToken is a JSON token containing the information from pg_controldata such as Database system identifier, Latest checkpoint's TimeLineID, Latest checkpoint's REDO location, Latest checkpoint's REDO WAL file, and Time of latest checkpoint</summary>
    [JsonPropertyName("demotionToken")]
    public string? DemotionToken { get; set; }

    /// <summary>The first recoverability point, stored as a date in RFC3339 format. This field is calculated from the content of FirstRecoverabilityPointByMethod</summary>
    [JsonPropertyName("firstRecoverabilityPoint")]
    public string? FirstRecoverabilityPoint { get; set; }

    /// <summary>The first recoverability point, stored as a date in RFC3339 format, per backup method type</summary>
    [JsonPropertyName("firstRecoverabilityPointByMethod")]
    public IDictionary<string, string>? FirstRecoverabilityPointByMethod { get; set; }

    /// <summary>List of all the PVCs not dangling nor initializing</summary>
    [JsonPropertyName("healthyPVC")]
    public IList<string>? HealthyPVC { get; set; }

    /// <summary>Image contains the image name used by the pods</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>List of all the PVCs that are being initialized by this cluster</summary>
    [JsonPropertyName("initializingPVC")]
    public IList<string>? InitializingPVC { get; set; }

    /// <summary>List of instance names in the cluster</summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>The total number of PVC Groups detected in the cluster. It may differ from the number of existing instance pods.</summary>
    [JsonPropertyName("instances")]
    public int? Instances { get; set; }

    /// <summary>The reported state of the instances during the last reconciliation loop</summary>
    [JsonPropertyName("instancesReportedState")]
    public IDictionary<string, V1ClusterStatusInstancesReportedState>? InstancesReportedState { get; set; }

    /// <summary>InstancesStatus indicates in which status the instances are</summary>
    [JsonPropertyName("instancesStatus")]
    public IDictionary<string, IList<string>>? InstancesStatus { get; set; }

    /// <summary>How many Jobs have been created by this cluster</summary>
    [JsonPropertyName("jobCount")]
    public int? JobCount { get; set; }

    /// <summary>Stored as a date in RFC3339 format</summary>
    [JsonPropertyName("lastFailedBackup")]
    public string? LastFailedBackup { get; set; }

    /// <summary>LastPromotionToken is the last verified promotion token that was used to promote a replica cluster</summary>
    [JsonPropertyName("lastPromotionToken")]
    public string? LastPromotionToken { get; set; }

    /// <summary>Last successful backup, stored as a date in RFC3339 format This field is calculated from the content of LastSuccessfulBackupByMethod</summary>
    [JsonPropertyName("lastSuccessfulBackup")]
    public string? LastSuccessfulBackup { get; set; }

    /// <summary>Last successful backup, stored as a date in RFC3339 format, per backup method type</summary>
    [JsonPropertyName("lastSuccessfulBackupByMethod")]
    public IDictionary<string, string>? LastSuccessfulBackupByMethod { get; set; }

    /// <summary>ID of the latest generated node (used to avoid node name clashing)</summary>
    [JsonPropertyName("latestGeneratedNode")]
    public int? LatestGeneratedNode { get; set; }

    /// <summary>ManagedRolesStatus reports the state of the managed roles in the cluster</summary>
    [JsonPropertyName("managedRolesStatus")]
    public V1ClusterStatusManagedRolesStatus? ManagedRolesStatus { get; set; }

    /// <summary>OnlineUpdateEnabled shows if the online upgrade is enabled inside the cluster</summary>
    [JsonPropertyName("onlineUpdateEnabled")]
    public bool? OnlineUpdateEnabled { get; set; }

    /// <summary>Current phase of the cluster</summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>Reason for the current phase</summary>
    [JsonPropertyName("phaseReason")]
    public string? PhaseReason { get; set; }

    /// <summary>PluginStatus is the status of the loaded plugins</summary>
    [JsonPropertyName("pluginStatus")]
    public IList<V1ClusterStatusPluginStatus>? PluginStatus { get; set; }

    /// <summary>The integration needed by poolers referencing the cluster</summary>
    [JsonPropertyName("poolerIntegrations")]
    public V1ClusterStatusPoolerIntegrations? PoolerIntegrations { get; set; }

    /// <summary>How many PVCs have been created by this cluster</summary>
    [JsonPropertyName("pvcCount")]
    public int? PvcCount { get; set; }

    /// <summary>Current list of read pods</summary>
    [JsonPropertyName("readService")]
    public string? ReadService { get; set; }

    /// <summary>The total number of ready instances in the cluster. It is equal to the number of ready instance pods.</summary>
    [JsonPropertyName("readyInstances")]
    public int? ReadyInstances { get; set; }

    /// <summary>List of all the PVCs that have ResizingPVC condition.</summary>
    [JsonPropertyName("resizingPVC")]
    public IList<string>? ResizingPVC { get; set; }

    /// <summary>The list of resource versions of the secrets managed by the operator. Every change here is done in the interest of the instance manager, which will refresh the secret data</summary>
    [JsonPropertyName("secretsResourceVersion")]
    public V1ClusterStatusSecretsResourceVersion? SecretsResourceVersion { get; set; }

    /// <summary>SwitchReplicaClusterStatus is the status of the switch to replica cluster</summary>
    [JsonPropertyName("switchReplicaClusterStatus")]
    public V1ClusterStatusSwitchReplicaClusterStatus? SwitchReplicaClusterStatus { get; set; }

    /// <summary>TablespacesStatus reports the state of the declarative tablespaces in the cluster</summary>
    [JsonPropertyName("tablespacesStatus")]
    public IList<V1ClusterStatusTablespacesStatus>? TablespacesStatus { get; set; }

    /// <summary>Target primary instance, this is different from the previous one during a switchover or a failover</summary>
    [JsonPropertyName("targetPrimary")]
    public string? TargetPrimary { get; set; }

    /// <summary>The timestamp when the last request for a new primary has occurred</summary>
    [JsonPropertyName("targetPrimaryTimestamp")]
    public string? TargetPrimaryTimestamp { get; set; }

    /// <summary>The timeline of the Postgres cluster</summary>
    [JsonPropertyName("timelineID")]
    public int? TimelineID { get; set; }

    /// <summary>Instances topology.</summary>
    [JsonPropertyName("topology")]
    public V1ClusterStatusTopology? Topology { get; set; }

    /// <summary>List of all the PVCs that are unusable because another PVC is missing</summary>
    [JsonPropertyName("unusablePVC")]
    public IList<string>? UnusablePVC { get; set; }

    /// <summary>Current write pod</summary>
    [JsonPropertyName("writeService")]
    public string? WriteService { get; set; }
}

/// <summary>Cluster is the Schema for the PostgreSQL API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1ClusterSpec>, IStatus<V1ClusterStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "clusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Specification of the desired behavior of the cluster. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("spec")]
    public V1ClusterSpec Spec { get; set; }

    /// <summary>Most recently observed status of the cluster. This data may not be up to date. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("status")]
    public V1ClusterStatus? Status { get; set; }
}

/// <summary>Cluster is the Schema for the PostgreSQL API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1Cluster>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "clusters";
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
    public IList<V1Cluster> Items { get; set; }
}