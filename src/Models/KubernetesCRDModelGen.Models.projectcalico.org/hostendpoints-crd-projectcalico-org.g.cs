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
public partial class V1HostEndpointSpecPorts
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public IntstrIntOrString Protocol { get; set; }
}

/// <summary>HostEndpointSpec contains the specification for a HostEndpoint resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1HostEndpointSpec
{
    /// <summary>The expected IP addresses (IPv4 and IPv6) of the endpoint. If "InterfaceName" is not present, Calico will look for an interface matching any of the IPs in the list and apply policy to that. Note: 	When using the selector match criteria in an ingress or egress security Policy 	or Profile, Calico converts the selector into a set of IP addresses. For host 	endpoints, the ExpectedIPs field is used for that purpose. (If only the interface 	name is specified, Calico does not learn the IPs of the interface for use in match 	criteria.)</summary>
    [JsonPropertyName("expectedIPs")]
    public IList<string>? ExpectedIPs { get; set; }

    /// <summary>Either "*", or the name of a specific Linux interface to apply policy to; or empty.  "*" indicates that this HostEndpoint governs all traffic to, from or through the default network namespace of the host named by the "Node" field; entering and leaving that namespace via any interface, including those from/to non-host-networked local workloads.   If InterfaceName is not "*", this HostEndpoint only governs traffic that enters or leaves the host through the specific interface named by InterfaceName, or - when InterfaceName is empty - through the specific interface that has one of the IPs in ExpectedIPs. Therefore, when InterfaceName is empty, at least one expected IP must be specified.  Only external interfaces (such as "eth0") are supported here; it isn't possible for a HostEndpoint to protect traffic through a specific local workload interface.   Note: Only some kinds of policy are implemented for "*" HostEndpoints; initially just pre-DNAT policy.  Please check Calico documentation for the latest position.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>The node name identifying the Calico node instance.</summary>
    [JsonPropertyName("node")]
    public string? Node { get; set; }

    /// <summary>Ports contains the endpoint's named ports, which may be referenced in security policy rules.</summary>
    [JsonPropertyName("ports")]
    public IList<V1HostEndpointSpecPorts>? Ports { get; set; }

    /// <summary>A list of identifiers of security Profile objects that apply to this endpoint. Each profile is applied in the order that they appear in this list.  Profile rules are applied after the selector-based security policy.</summary>
    [JsonPropertyName("profiles")]
    public IList<string>? Profiles { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1HostEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1HostEndpointSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "HostEndpoint";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "hostendpoints";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HostEndpointSpec contains the specification for a HostEndpoint resource.</summary>
    [JsonPropertyName("spec")]
    public V1HostEndpointSpec? Spec { get; set; }
}