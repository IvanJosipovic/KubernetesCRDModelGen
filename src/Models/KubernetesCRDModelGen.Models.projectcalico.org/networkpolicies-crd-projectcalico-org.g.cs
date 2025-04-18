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
public partial class V1NetworkPolicySpecEgressDestinationServiceAccounts
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
public partial class V1NetworkPolicySpecEgressDestinationServices
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
public partial class V1NetworkPolicySpecEgressDestination
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
    public V1NetworkPolicySpecEgressDestinationServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1NetworkPolicySpecEgressDestinationServices? Services { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressHttpPaths
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
public partial class V1NetworkPolicySpecEgressHttp
{
    /// <summary></summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paths")]
    public IList<V1NetworkPolicySpecEgressHttpPaths>? Paths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressIcmp
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
public partial class V1NetworkPolicySpecEgressMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressNotICMP
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
public partial class V1NetworkPolicySpecEgressSourceServiceAccounts
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
public partial class V1NetworkPolicySpecEgressSourceServices
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
public partial class V1NetworkPolicySpecEgressSource
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
    public V1NetworkPolicySpecEgressSourceServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1NetworkPolicySpecEgressSourceServices? Services { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgress
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1NetworkPolicySpecEgressDestination? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public V1NetworkPolicySpecEgressHttp? Http { get; set; }

    /// <summary></summary>
    [JsonPropertyName("icmp")]
    public V1NetworkPolicySpecEgressIcmp? Icmp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1NetworkPolicySpecEgressMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notICMP")]
    public V1NetworkPolicySpecEgressNotICMP? NotICMP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notProtocol")]
    public IntstrIntOrString? NotProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public IntstrIntOrString? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1NetworkPolicySpecEgressSource? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressDestinationServiceAccounts
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
public partial class V1NetworkPolicySpecIngressDestinationServices
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
public partial class V1NetworkPolicySpecIngressDestination
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
    public V1NetworkPolicySpecIngressDestinationServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1NetworkPolicySpecIngressDestinationServices? Services { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressHttpPaths
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
public partial class V1NetworkPolicySpecIngressHttp
{
    /// <summary></summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paths")]
    public IList<V1NetworkPolicySpecIngressHttpPaths>? Paths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressIcmp
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
public partial class V1NetworkPolicySpecIngressMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressNotICMP
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
public partial class V1NetworkPolicySpecIngressSourceServiceAccounts
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
public partial class V1NetworkPolicySpecIngressSourceServices
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
public partial class V1NetworkPolicySpecIngressSource
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
    public V1NetworkPolicySpecIngressSourceServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1NetworkPolicySpecIngressSourceServices? Services { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngress
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1NetworkPolicySpecIngressDestination? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public V1NetworkPolicySpecIngressHttp? Http { get; set; }

    /// <summary></summary>
    [JsonPropertyName("icmp")]
    public V1NetworkPolicySpecIngressIcmp? Icmp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1NetworkPolicySpecIngressMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notICMP")]
    public V1NetworkPolicySpecIngressNotICMP? NotICMP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notProtocol")]
    public IntstrIntOrString? NotProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public IntstrIntOrString? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1NetworkPolicySpecIngressSource? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("egress")]
    public IList<V1NetworkPolicySpecEgress>? Egress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingress")]
    public IList<V1NetworkPolicySpecIngress>? Ingress { get; set; }

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
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1NetworkPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1NetworkPolicySpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "NetworkPolicy";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "networkpolicies";
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
    public V1NetworkPolicySpec? Spec { get; set; }
}