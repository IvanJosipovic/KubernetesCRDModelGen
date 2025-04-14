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
public partial class V1StagedGlobalNetworkPolicySpecEgressDestinationServiceAccounts
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
public partial class V1StagedGlobalNetworkPolicySpecEgressDestinationServices
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
public partial class V1StagedGlobalNetworkPolicySpecEgressDestination
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
    public V1StagedGlobalNetworkPolicySpecEgressDestinationServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1StagedGlobalNetworkPolicySpecEgressDestinationServices? Services { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressHttpPaths
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
public partial class V1StagedGlobalNetworkPolicySpecEgressHttp
{
    /// <summary></summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paths")]
    public IList<V1StagedGlobalNetworkPolicySpecEgressHttpPaths>? Paths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressIcmp
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
public partial class V1StagedGlobalNetworkPolicySpecEgressMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressNotICMP
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
public partial class V1StagedGlobalNetworkPolicySpecEgressSourceServiceAccounts
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
public partial class V1StagedGlobalNetworkPolicySpecEgressSourceServices
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
public partial class V1StagedGlobalNetworkPolicySpecEgressSource
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
    public V1StagedGlobalNetworkPolicySpecEgressSourceServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1StagedGlobalNetworkPolicySpecEgressSourceServices? Services { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgress
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1StagedGlobalNetworkPolicySpecEgressDestination? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public V1StagedGlobalNetworkPolicySpecEgressHttp? Http { get; set; }

    /// <summary></summary>
    [JsonPropertyName("icmp")]
    public V1StagedGlobalNetworkPolicySpecEgressIcmp? Icmp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1StagedGlobalNetworkPolicySpecEgressMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notICMP")]
    public V1StagedGlobalNetworkPolicySpecEgressNotICMP? NotICMP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notProtocol")]
    public IntstrIntOrString? NotProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public IntstrIntOrString? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1StagedGlobalNetworkPolicySpecEgressSource? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressDestinationServiceAccounts
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
public partial class V1StagedGlobalNetworkPolicySpecIngressDestinationServices
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
public partial class V1StagedGlobalNetworkPolicySpecIngressDestination
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
    public V1StagedGlobalNetworkPolicySpecIngressDestinationServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1StagedGlobalNetworkPolicySpecIngressDestinationServices? Services { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressHttpPaths
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
public partial class V1StagedGlobalNetworkPolicySpecIngressHttp
{
    /// <summary></summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paths")]
    public IList<V1StagedGlobalNetworkPolicySpecIngressHttpPaths>? Paths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressIcmp
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
public partial class V1StagedGlobalNetworkPolicySpecIngressMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressNotICMP
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
public partial class V1StagedGlobalNetworkPolicySpecIngressSourceServiceAccounts
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
public partial class V1StagedGlobalNetworkPolicySpecIngressSourceServices
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
public partial class V1StagedGlobalNetworkPolicySpecIngressSource
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
    public V1StagedGlobalNetworkPolicySpecIngressSourceServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1StagedGlobalNetworkPolicySpecIngressSourceServices? Services { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngress
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1StagedGlobalNetworkPolicySpecIngressDestination? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public V1StagedGlobalNetworkPolicySpecIngressHttp? Http { get; set; }

    /// <summary></summary>
    [JsonPropertyName("icmp")]
    public V1StagedGlobalNetworkPolicySpecIngressIcmp? Icmp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1StagedGlobalNetworkPolicySpecIngressMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notICMP")]
    public V1StagedGlobalNetworkPolicySpecIngressNotICMP? NotICMP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notProtocol")]
    public IntstrIntOrString? NotProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public IntstrIntOrString? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1StagedGlobalNetworkPolicySpecIngressSource? Source { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("applyOnForward")]
    public bool? ApplyOnForward { get; set; }

    /// <summary></summary>
    [JsonPropertyName("doNotTrack")]
    public bool? DoNotTrack { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egress")]
    public IList<V1StagedGlobalNetworkPolicySpecEgress>? Egress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingress")]
    public IList<V1StagedGlobalNetworkPolicySpecIngress>? Ingress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary></summary>
    [JsonPropertyName("performanceHints")]
    public IList<string>? PerformanceHints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preDNAT")]
    public bool? PreDNAT { get; set; }

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
public partial class V1StagedGlobalNetworkPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1StagedGlobalNetworkPolicySpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "StagedGlobalNetworkPolicy";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "stagedglobalnetworkpolicies";
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
    public V1StagedGlobalNetworkPolicySpec? Spec { get; set; }
}