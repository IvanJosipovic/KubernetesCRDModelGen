using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressPorts
{
    /// <summary></summary>
    [JsonPropertyName("endPort")]
    public int? EndPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressToIpBlock
{
    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string Cidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("except")]
    public IList<string>? Except { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressToNamespaceSelectorMatchExpressions
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
public partial class V1StagedKubernetesNetworkPolicySpecEgressToNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1StagedKubernetesNetworkPolicySpecEgressToNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressToPodSelectorMatchExpressions
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
public partial class V1StagedKubernetesNetworkPolicySpecEgressToPodSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1StagedKubernetesNetworkPolicySpecEgressToPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressTo
{
    /// <summary></summary>
    [JsonPropertyName("ipBlock")]
    public V1StagedKubernetesNetworkPolicySpecEgressToIpBlock? IpBlock { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1StagedKubernetesNetworkPolicySpecEgressToNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podSelector")]
    public V1StagedKubernetesNetworkPolicySpecEgressToPodSelector? PodSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgress
{
    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1StagedKubernetesNetworkPolicySpecEgressPorts>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("to")]
    public IList<V1StagedKubernetesNetworkPolicySpecEgressTo>? To { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFromIpBlock
{
    /// <summary></summary>
    [JsonPropertyName("cidr")]
    public string Cidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("except")]
    public IList<string>? Except { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFromNamespaceSelectorMatchExpressions
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
public partial class V1StagedKubernetesNetworkPolicySpecIngressFromNamespaceSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1StagedKubernetesNetworkPolicySpecIngressFromNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFromPodSelectorMatchExpressions
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
public partial class V1StagedKubernetesNetworkPolicySpecIngressFromPodSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1StagedKubernetesNetworkPolicySpecIngressFromPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFrom
{
    /// <summary></summary>
    [JsonPropertyName("ipBlock")]
    public V1StagedKubernetesNetworkPolicySpecIngressFromIpBlock? IpBlock { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public V1StagedKubernetesNetworkPolicySpecIngressFromNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podSelector")]
    public V1StagedKubernetesNetworkPolicySpecIngressFromPodSelector? PodSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressPorts
{
    /// <summary></summary>
    [JsonPropertyName("endPort")]
    public int? EndPort { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public IntstrIntOrString? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngress
{
    /// <summary></summary>
    [JsonPropertyName("from")]
    public IList<V1StagedKubernetesNetworkPolicySpecIngressFrom>? From { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<V1StagedKubernetesNetworkPolicySpecIngressPorts>? Ports { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecPodSelectorMatchExpressions
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
public partial class V1StagedKubernetesNetworkPolicySpecPodSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1StagedKubernetesNetworkPolicySpecPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("egress")]
    public IList<V1StagedKubernetesNetworkPolicySpecEgress>? Egress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingress")]
    public IList<V1StagedKubernetesNetworkPolicySpecIngress>? Ingress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podSelector")]
    public V1StagedKubernetesNetworkPolicySpecPodSelector? PodSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyTypes")]
    public IList<string>? PolicyTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stagedAction")]
    public string? StagedAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1StagedKubernetesNetworkPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1StagedKubernetesNetworkPolicySpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "StagedKubernetesNetworkPolicy";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "stagedkubernetesnetworkpolicies";
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
    public V1StagedKubernetesNetworkPolicySpec? Spec { get; set; }
}