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
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1StagedNetworkPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1StagedNetworkPolicy>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "StagedNetworkPolicyList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "stagednetworkpolicies";
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
    public IList<V1StagedNetworkPolicy> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressDestinationServiceAccounts
{
    /// <summary></summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressDestinationServices
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressDestination
{
    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notPorts")]
    public IList<IntstrIntOrString>? NotPorts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<IntstrIntOrString>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccounts")]
    public V1StagedNetworkPolicySpecEgressDestinationServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1StagedNetworkPolicySpecEgressDestinationServices? Services { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressHttpPaths
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressHttp
{
    /// <summary></summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paths")]
    public IList<V1StagedNetworkPolicySpecEgressHttpPaths>? Paths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressIcmp
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressNotICMP
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressSourceServiceAccounts
{
    /// <summary></summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressSourceServices
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressSource
{
    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notPorts")]
    public IList<IntstrIntOrString>? NotPorts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<IntstrIntOrString>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccounts")]
    public V1StagedNetworkPolicySpecEgressSourceServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1StagedNetworkPolicySpecEgressSourceServices? Services { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgress
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1StagedNetworkPolicySpecEgressDestination? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public V1StagedNetworkPolicySpecEgressHttp? Http { get; set; }

    /// <summary></summary>
    [JsonPropertyName("icmp")]
    public V1StagedNetworkPolicySpecEgressIcmp? Icmp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1StagedNetworkPolicySpecEgressMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notICMP")]
    public V1StagedNetworkPolicySpecEgressNotICMP? NotICMP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notProtocol")]
    public IntstrIntOrString? NotProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public IntstrIntOrString? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1StagedNetworkPolicySpecEgressSource? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressDestinationServiceAccounts
{
    /// <summary></summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressDestinationServices
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressDestination
{
    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notPorts")]
    public IList<IntstrIntOrString>? NotPorts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<IntstrIntOrString>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccounts")]
    public V1StagedNetworkPolicySpecIngressDestinationServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1StagedNetworkPolicySpecIngressDestinationServices? Services { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressHttpPaths
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressHttp
{
    /// <summary></summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paths")]
    public IList<V1StagedNetworkPolicySpecIngressHttpPaths>? Paths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressIcmp
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressNotICMP
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressSourceServiceAccounts
{
    /// <summary></summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressSourceServices
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressSource
{
    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notPorts")]
    public IList<IntstrIntOrString>? NotPorts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ports")]
    public IList<IntstrIntOrString>? Ports { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccounts")]
    public V1StagedNetworkPolicySpecIngressSourceServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1StagedNetworkPolicySpecIngressSourceServices? Services { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngress
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1StagedNetworkPolicySpecIngressDestination? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public V1StagedNetworkPolicySpecIngressHttp? Http { get; set; }

    /// <summary></summary>
    [JsonPropertyName("icmp")]
    public V1StagedNetworkPolicySpecIngressIcmp? Icmp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1StagedNetworkPolicySpecIngressMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notICMP")]
    public V1StagedNetworkPolicySpecIngressNotICMP? NotICMP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notProtocol")]
    public IntstrIntOrString? NotProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public IntstrIntOrString? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1StagedNetworkPolicySpecIngressSource? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("egress")]
    public IList<V1StagedNetworkPolicySpecEgress>? Egress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingress")]
    public IList<V1StagedNetworkPolicySpecIngress>? Ingress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary></summary>
    [JsonPropertyName("performanceHints")]
    public IList<string>? PerformanceHints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccountSelector")]
    public string? ServiceAccountSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stagedAction")]
    public string? StagedAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1StagedNetworkPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1StagedNetworkPolicySpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "StagedNetworkPolicy";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "stagednetworkpolicies";
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
    public V1StagedNetworkPolicySpec? Spec { get; set; }
}