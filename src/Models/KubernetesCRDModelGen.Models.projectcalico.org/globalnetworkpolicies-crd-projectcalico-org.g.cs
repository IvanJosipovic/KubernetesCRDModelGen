using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1GlobalNetworkPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1GlobalNetworkPolicy>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "GlobalNetworkPolicyList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "globalnetworkpolicies";
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
    public IList<V1GlobalNetworkPolicy> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressDestinationServiceAccounts
{
    /// <summary></summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressDestinationServices
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressDestination
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
    public V1GlobalNetworkPolicySpecEgressDestinationServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1GlobalNetworkPolicySpecEgressDestinationServices? Services { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressHttpPaths
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressHttp
{
    /// <summary></summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paths")]
    public IList<V1GlobalNetworkPolicySpecEgressHttpPaths>? Paths { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressIcmp
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressNotICMP
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressSourceServiceAccounts
{
    /// <summary></summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressSourceServices
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressSource
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
    public V1GlobalNetworkPolicySpecEgressSourceServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1GlobalNetworkPolicySpecEgressSourceServices? Services { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgress
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1GlobalNetworkPolicySpecEgressDestination? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public V1GlobalNetworkPolicySpecEgressHttp? Http { get; set; }

    /// <summary></summary>
    [JsonPropertyName("icmp")]
    public V1GlobalNetworkPolicySpecEgressIcmp? Icmp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1GlobalNetworkPolicySpecEgressMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notICMP")]
    public V1GlobalNetworkPolicySpecEgressNotICMP? NotICMP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notProtocol")]
    public IntstrIntOrString? NotProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public IntstrIntOrString? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1GlobalNetworkPolicySpecEgressSource? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressDestinationServiceAccounts
{
    /// <summary></summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressDestinationServices
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressDestination
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
    public V1GlobalNetworkPolicySpecIngressDestinationServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1GlobalNetworkPolicySpecIngressDestinationServices? Services { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressHttpPaths
{
    /// <summary></summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressHttp
{
    /// <summary></summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("paths")]
    public IList<V1GlobalNetworkPolicySpecIngressHttpPaths>? Paths { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressIcmp
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressNotICMP
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressSourceServiceAccounts
{
    /// <summary></summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressSourceServices
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressSource
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
    public V1GlobalNetworkPolicySpecIngressSourceServiceAccounts? ServiceAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("services")]
    public V1GlobalNetworkPolicySpecIngressSourceServices? Services { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngress
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1GlobalNetworkPolicySpecIngressDestination? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public V1GlobalNetworkPolicySpecIngressHttp? Http { get; set; }

    /// <summary></summary>
    [JsonPropertyName("icmp")]
    public V1GlobalNetworkPolicySpecIngressIcmp? Icmp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1GlobalNetworkPolicySpecIngressMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notICMP")]
    public V1GlobalNetworkPolicySpecIngressNotICMP? NotICMP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notProtocol")]
    public IntstrIntOrString? NotProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public IntstrIntOrString? Protocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1GlobalNetworkPolicySpecIngressSource? Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("applyOnForward")]
    public bool? ApplyOnForward { get; set; }

    /// <summary></summary>
    [JsonPropertyName("doNotTrack")]
    public bool? DoNotTrack { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egress")]
    public IList<V1GlobalNetworkPolicySpecEgress>? Egress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingress")]
    public IList<V1GlobalNetworkPolicySpecIngress>? Ingress { get; set; }

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
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1GlobalNetworkPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1GlobalNetworkPolicySpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "GlobalNetworkPolicy";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "globalnetworkpolicies";
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
    public V1GlobalNetworkPolicySpec? Spec { get; set; }
}
#nullable disable
